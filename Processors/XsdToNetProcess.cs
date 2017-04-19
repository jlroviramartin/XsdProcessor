// Copyright 2017 Jose Luis Rovira Martin
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using Antlr4.StringTemplate;
using Antlr4.StringTemplate.Misc;
using XmlSchemaProcessor.Xsd;
using XmlSchemaProcessor.Xsd.Facets;

namespace XmlSchemaProcessor.Processors
{
    public class XsdToNetProcess : XsdProcess
    {
        public XsdToNetProcess(string @namespace, string path)
        {
            this.@namespace = @namespace;
            this.path = path;

            this.PropertyMap = IdentityPropertyMap.Instance;
        }

        public void AddNamespaceURI(string uri)
        {
            this.namespacesURI.Add(uri);
        }

        /// <summary>
        /// Property map used to get the name of a property related to an attribute. 
        /// </summary>
        public IPropertyMap PropertyMap { get; set; }

        #region private

        private void WriteEventInterface()
        {
            try
            {
                Template template = group.GetInstanceOf("EventsInterface");
                template.Add("namespace", this.@namespace);
                template.Add("interfaceTypeName", "ILandXmlEvents");
                template.Add("events", this.events);

                this.WriteInFile("ILandXmlEvents", buff => buff.Write(template.Render()));
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        private void WriteEventImplementation()
        {
            try
            {
                Template template = group.GetInstanceOf("EventsImplementation");
                template.Add("namespace", this.@namespace);
                template.Add("implementationTypeName", implementationTypeName);
                template.Add("interfaceTypeName", interfaceTypeName);
                template.Add("events", this.events);

                this.WriteInFile("LandXmlEvents", buff => buff.Write(template.Render()));
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        private void WriteEventTest()
        {
            try
            {
                Template template = group.GetInstanceOf("EventsTest");
                template.Add("namespace", this.@namespace);
                template.Add("testTypeName", testTypeName);
                template.Add("interfaceTypeName", interfaceTypeName);
                template.Add("events", this.events);

                this.WriteInFile("TestLandXmlEvents", buff => buff.Write(template.Render()));
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        private void WriteReader()
        {
            try
            {
                Template template = group.GetInstanceOf("XmlReader");
                template.Add("namespace", this.@namespace);
                template.Add("xmlReaderTypeName", xmlReaderTypeName);
                template.Add("namespacesURI", this.namespacesURI);
                template.Add("events", this.events);

                this.WriteInFile("LandXmlReader", buff => buff.Write(template.Render()));
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        private void BuildType(XsdComplexType xsdComplexType, string typeName, string docToAdd = "")
        {
            XsdType xsdBaseType = xsdComplexType.GetBaseType();

            try
            {
                string baseType;
                if ((xsdBaseType != null) && xsdBaseType.TopLevel && !(xsdBaseType is XsdSimpleType))
                {
                    baseType = xsdComplexType.GetBaseType().Name;
                }
                else
                {
                    baseType = "XsdBaseObject";
                }

                Template template = group.GetInstanceOf("BuildType");
                template.Add("namespace", this.@namespace);
                template.Add("documentation", docToAdd + xsdComplexType.GetNetDocumentation());

                template.Add("typeName", typeName);
                template.Add("baseType", baseType);
                template.Add("properties", xsdComplexType.Attributes.Content.Select(attribute => new Property(attribute, this.PropertyMap.Map(xsdComplexType, typeName, attribute.Name))));

                template.Add("includeContent", xsdBaseType is XsdSimpleType);
                template.Add("contentType", xsdBaseType);
                template.Add("contentFieldName", contentFieldName);

                this.WriteInFile(typeName.ToTypeName(), buff => buff.Write(template.Render()));
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        private void BuildEnum(XsdSimpleRestrictionType xsdType)
        {
            XsdSimpleType builtInRootType = xsdType.GetBuiltInRootType();
            if ((builtInRootType != null) && (builtInRootType.Name == XsdBuiltInType.STRING))
            {
                string[] values = xsdType.Facets
                                         .Where(x => x.FacetType == FacetType.Enumeration)
                                         .Select(x => (string)x.Value)
                                         .ToArray();

                if (values.Length > 0)
                {
                    try
                    {
                        Template template = group.GetInstanceOf("BuildEnum");
                        template.Add("namespace", this.@namespace);
                        template.Add("enumType", xsdType);
                        template.Add("enumValues", values);

                        this.WriteInFile(xsdType.Name.ToTypeName(), buff => buff.Write(template.Render()));
                    }
                    catch (Exception exception)
                    {
                        Debug.WriteLine(exception);
                    }
                }
            }
        }

        private void NewEvent(string name, string argType, bool needContent, string documentation)
        {
            this.events.Add(new SimpleEvent(name, argType, needContent, documentation));
        }

        private static string GetElementDocumentation(XsdElement xsdElement)
        {
            return xsdElement.ToString();
        }

        private void WriteInFile(string name, Action<TextWriterEx> toWrite)
        {
            using (FileStream fstream = new FileInfo(System.IO.Path.Combine(this.path, name + ".cs")).Open(FileMode.Create, FileAccess.Write))
            using (StreamWriter stream = new StreamWriter(fstream))
            using (TextWriterEx writer = new TextWriterEx(stream))
            {
                toWrite(writer);
            }
        }

        static XsdToNetProcess()
        {
            try
            {
                string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string groupFile = System.IO.Path.Combine(path, @"Resources\Templates\csharp\MainTemplateGroup.stg");

                group = new TemplateGroupFile(groupFile);
                //group.Verbose = true;
                group.ErrorManager = new ErrorManager(new MyTemplateErrorListener());
                group.RegisterRenderer(typeof(string), new StringNetRenderer());
                group.RegisterRenderer(typeof(XsdType), new XsdTypeNetRenderer());
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        private static readonly TemplateGroupFile group;

        private readonly string @namespace;

        private const string testTypeName = "TestLandXmlEvents";
        private const string implementationTypeName = "LandXmlEvents";
        private const string interfaceTypeName = "ILandXmlEvents";
        private const string xmlReaderTypeName = "LandXmlReader";
        private const string contentFieldName = "content";

        private readonly List<string> namespacesURI = new List<string>();

        private readonly string path;

        private readonly List<SimpleEvent> events = new List<SimpleEvent>();

        #endregion

        #region XsdProcess

        public override void Process(XsdSchema schema)
        {
            foreach (XsdSimpleType xsdType in schema.Types.OfType<XsdSimpleType>().Where(x => !x.IsBuiltIn()))
            {
                this.Process(xsdType);
            }

            foreach (XsdComplexType xsdType in schema.Types.OfType<XsdComplexType>())
            {
                this.BuildType(xsdType, xsdType.Name);
            }

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition is XsdSimpleType))
            {
                this.ProcessSimpleElement(element);
            }

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition is XsdComplexType))
            {
                this.ProcessComplexElement(element);
            }

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition == null))
            {
                Debug.WriteLine("class {0} ???", element.Name);
            }

            this.WriteEventInterface();
            this.WriteEventImplementation();
            this.WriteEventTest();
            this.WriteReader();
        }

        private void ProcessComplexElement(XsdElement xsdElement)
        {
            Contract.Assert(xsdElement.TypeDefinition is XsdComplexType);
            if (xsdElement.TypeDefinition.TopLevel)
            {
                this.NewEvent(xsdElement.Name, xsdElement.TypeDefinition.ToNetType(false), false, GetElementDocumentation(xsdElement));
            }
            else
            {
                this.BuildType((XsdComplexType)xsdElement.TypeDefinition, xsdElement.Name, xsdElement.GetNetDocumentation());

                this.NewEvent(xsdElement.Name, xsdElement.Name.ToTypeName(), false, GetElementDocumentation(xsdElement));
            }
        }

        private void ProcessSimpleElement(XsdElement xsdElement)
        {
            Contract.Assert(xsdElement.TypeDefinition is XsdSimpleType);
            this.NewEvent(xsdElement.Name, xsdElement.TypeDefinition.ToNetType(false), true, GetElementDocumentation(xsdElement));
        }

        #region XsdSimpleType

        public override void Process(XsdSimpleType xsdType)
        {
            if (xsdType is XsdSimpleRestrictionType)
            {
                this.BuildEnum((XsdSimpleRestrictionType)xsdType);
            }
        }

        #endregion

        #endregion

        #region inner classes

        private sealed class SimpleEvent
        {
            public SimpleEvent(string name, string argType, bool needContent, string documentation)
            {
                this.Name = name;
                this.ArgType = argType;
                this.NeedContent = needContent;
                this.Documentation = documentation;
            }

            public readonly string Name;
            public readonly string ArgType;
            public readonly bool NeedContent;
            public readonly string Documentation;
        }

        private sealed class MyTemplateErrorListener : ITemplateErrorListener
        {
            public void CompiletimeError(TemplateMessage msg)
            {
                Debug.WriteLine(msg);
            }

            public void RuntimeError(TemplateMessage msg)
            {
                Debug.WriteLine(msg);
            }

            public void IOError(TemplateMessage msg)
            {
                Debug.WriteLine(msg);
            }

            public void InternalError(TemplateMessage msg)
            {
                Debug.WriteLine(msg);
            }
        }

        private class Property
        {
            public Property(XsdAttribute xsdAttribute, string name)
            {
                XsdSimpleType attributeType = xsdAttribute.Type ?? XsdBuiltInType.String;
                this.Documentation = attributeType.GetNetDocumentation();
                this.AttributeName = xsdAttribute.Name;
                this.PropertyType = attributeType;
                this.Name = name;
                this.DefValue = xsdAttribute.DefValue;
                this.Optional = xsdAttribute.Use != AttributeUse.Required;
            }

            public string Documentation;
            public string AttributeName;
            public XsdSimpleType PropertyType; // Can't use Type in StringTemplate!
            public string Name;
            public string DefValue;
            public bool Optional;
        }

        #endregion
    }
}