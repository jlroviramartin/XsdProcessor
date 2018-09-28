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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Antlr4.StringTemplate;
using Antlr4.StringTemplate.Misc;
using XmlSchemaProcessor.Xsd;
using XmlSchemaProcessor.Xsd.Facets;

namespace XmlSchemaProcessor.Processors
{
    public class XsdToNetProcess_v2 : XsdProcess
    {
        public XsdToNetProcess_v2(string @namespace, string outputPath)
        {
            this.@namespace = @namespace;
            this.outputPath = outputPath;

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

        public void AddXsdRoot(string typeName)
        {
            this.xsdRoots.Add(typeName.ToUpperInvariant());
        }

        #region private

        private bool IsXsdRoot(string typeName)
        {
            return this.xsdRoots.Contains(typeName.ToUpperInvariant());
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
                    baseType = "XsdBaseReader";
                }

                StringBuilder documentation = new StringBuilder();
                documentation.Append(docToAdd);
                documentation.Append(xsdComplexType.GetNetDocumentation());

                Template template = group.GetInstanceOf("BuildType_v2");
                template.Add("namespace", this.@namespace);

                template.Add("typeName", typeName);
                template.Add("baseType", baseType);
                template.Add("properties", xsdComplexType.Attributes.Content.Select(attribute => new Property(attribute, this.PropertyMap.Map(xsdComplexType, typeName, attribute.Name))));

                template.Add("includeContent", xsdBaseType is XsdSimpleType); // (xsdComplexType is XsdComplexSimpleContentType)
                template.Add("contentType", xsdBaseType);
                template.Add("contentFieldName", contentFieldName);

                template.Add("isXsdRoot", this.IsXsdRoot(typeName));

                List<SimpleEvent> events = new List<SimpleEvent>();
                if (xsdComplexType.GetParticle() != null)
                {
                    documentation.Append(xsdComplexType.GetParticle());

                    Stack<XsdParticle> stack = new Stack<XsdParticle>();
                    stack.Push(xsdComplexType.GetParticle());
                    while (stack.Count > 0)
                    {
                        XsdParticle particle = stack.Pop();
                        if (particle is XsdParticleElement)
                        {
                            XsdElement xsdElement = ((XsdParticleElement)particle).Element;

                            if (xsdElement != null)
                            {
                                bool needContent = xsdElement.TypeDefinition is XsdComplexType;
                                events.Add(new SimpleEvent(xsdElement.Name,
                                                           xsdElement.ToNetType(false),
                                                           needContent,
                                                           GetElementDocumentation(xsdElement)));
                            }
                        }
                        else if (particle is XsdParticleGroup)
                        {
                            stack.PushAll(((XsdParticleGroup)particle).Items);
                        }
                    }
                }
                template.Add("events", events);
                template.Add("documentation", documentation.ToString());

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

        private static string GetElementDocumentation(XsdElement xsdElement)
        {
            return xsdElement.ToString();
        }

        private void WriteInFile(string name, Action<TextWriterEx> toWrite)
        {
            System.IO.Directory.CreateDirectory(this.outputPath);

            using (FileStream fstream = new FileInfo(System.IO.Path.Combine(this.outputPath, name + ".cs")).Open(FileMode.Create, FileAccess.Write))
            using (StreamWriter stream = new StreamWriter(fstream))
            using (TextWriterEx writer = new TextWriterEx(stream))
            {
                toWrite(writer);
            }
        }

        static XsdToNetProcess_v2()
        {
            try
            {
                string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string groupFile = System.IO.Path.Combine(path, @"Resources\Templates\csharp\MainTemplateGroup_v2.stg");

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

        private const string contentFieldName = "content";

        private readonly List<string> namespacesURI = new List<string>();

        private readonly string outputPath;
        private readonly HashSet<string> xsdRoots = new HashSet<string>();

        #endregion

        #region XsdProcess

        public override void Process(XsdSchema schema)
        {
            foreach (XsdType xsdType in schema.Types)
            {
                if (xsdType is XsdSimpleType && !((XsdSimpleType)xsdType).IsBuiltIn())
                {
                    this.Process(xsdType);
                }
                else if (xsdType is XsdComplexType)
                {
                    this.BuildType((XsdComplexType)xsdType, xsdType.Name);
                }
            }

            foreach (XsdElement element in schema.Elements)
            {
                this.ProcessElement(element);
            }
        }

        private void ProcessElement(XsdElement xsdElement)
        {
            if (xsdElement.TypeDefinition is XsdSimpleType)
            {
            }
            else if (xsdElement.TypeDefinition is XsdComplexType)
            {
                if (xsdElement.TypeDefinition.TopLevel)
                {
                }
                else
                {
                    this.BuildType((XsdComplexType)xsdElement.TypeDefinition, xsdElement.Name, xsdElement.GetNetDocumentation());
                }
            }
            else
            {
                Debug.WriteLine("class {0} ???", xsdElement.Name);
            }
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