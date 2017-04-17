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

using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using XmlSchemaProcessor.Xsd;
using XmlSchemaProcessor.Xsd.Facets;

namespace XmlSchemaProcessor
{
    public class XsdToNetReader : XsdProcess
    {
        public XsdToNetReader()
        {
            this.stringWriter = new StringWriter();
            this.buff = new TextWriterEx(this.stringWriter);
        }

        public void Write(string outFile, string @namespace)
        {
            using (FileStream fstream = new FileInfo(outFile).Open(FileMode.Create, FileAccess.Write))
            using (StreamWriter stream = new StreamWriter(fstream))
            using (TextWriterEx writer = new TextWriterEx(stream))
            {
                writer.WriteLine("#if !BUILD_LAND_XML");

                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using XmlSchemaProcessor;");
                writer.WriteLine("using XmlSchemaProcessor.LandXml;");

                writer.WriteLine("namespace {0}", @namespace);
                writer.WriteLine("{");
                writer.Indent();

                writer.WriteLine(this.stringWriter);

                // Interface para los eventos.
                writer.WriteLine("public interface ILandXmlEvents");
                writer.WriteLine("{");
                writer.Indent();

                foreach (SimpleEvent simpleEvent in this.events)
                {
                    writer.WriteLine("void BeginRead{0}( {1} value );",
                                     simpleEvent.Name.FirstUpper(),
                                     simpleEvent.ArgType);

                    writer.WriteLine("void EndRead{0}();",
                                     simpleEvent.Name.FirstUpper());
                }

                writer.Unindent();
                writer.WriteLine("}");

                // Clase para los eventos.
                writer.WriteLine("public class LandXmlEvents : ILandXmlEvents");
                writer.WriteLine("{");
                writer.Indent();

                foreach (SimpleEvent simpleEvent in this.events)
                {
                    writer.WriteLine("public virtual void BeginRead{0}( {1} value ) {{}}",
                                     simpleEvent.Name.FirstUpper(),
                                     simpleEvent.ArgType);

                    writer.WriteLine("public virtual void EndRead{0}() {{}}",
                                     simpleEvent.Name.FirstUpper());
                }

                writer.Unindent();
                writer.WriteLine("}");

                // Clase reader.
                writer.WriteLine("public class LandXmlReader : SimpleReader");
                writer.WriteLine("{");
                writer.Indent();

                writer.WriteLine("public LandXmlReader(ILandXmlEvents events)");
                writer.Indent();
                writer.WriteLine(": base(\"{0}\")", this.xsdNamespace);
                writer.Unindent();
                writer.WriteLine("{");
                writer.Indent();

                foreach (SimpleEvent simpleEvent in this.events)
                {
                    writer.WriteLine("this.Register<{2}>(\"{0}\", events.BeginRead{1}, events.EndRead{1}, {3});",
                                     simpleEvent.Name,
                                     simpleEvent.Name.FirstUpper(),
                                     simpleEvent.ArgType,
                                     simpleEvent.NeedContent ? "true" : "false");
                }

                writer.Unindent();
                writer.WriteLine("}");

                writer.Unindent();
                writer.WriteLine("}");

                writer.Unindent();
                writer.WriteLine("}");

                writer.WriteLine("#endif");
            }
            //Debug.WriteLine(this.stringWriter);
            //Debug.WriteLine("--------------------");
            //Debug.WriteLine(this.stringWriterEvents);
        }

        #region private

        private void Write(XsdParticleElement xsdParticle)
        {
            if (xsdParticle.MaxOccurs == 1)
            {
                this.buff.WriteLine("// " + xsdParticle.Element.Name);
            }
            else
            {
                this.buff.WriteLine("// List of {0} {1}", xsdParticle.Element.Name, xsdParticle.SafeOccursToString());
            }
        }

        private void BuildType(XsdComplexType xsdComplexType, string name, bool @abstract)
        {
            XsdType xsdBaseType = xsdComplexType.GetBaseType();
            if ((xsdBaseType != null) && xsdBaseType.TopLevel && !(xsdBaseType is XsdSimpleType))
            {
                this.buff.WriteLine("public class {0} : {1}",
                                    name.ToTypeName(),
                                    xsdComplexType.GetBaseType().Name.ToTypeName());
            }
            else
            {
                this.buff.WriteLine("public class {0} : XsdBaseObject",
                                    name.ToTypeName());
            }

            this.buff.WriteLine("{");
            this.buff.Indent();

            // Attributes.
            this.Process(xsdComplexType);

            // Content.
            if (xsdBaseType is XsdSimpleType)
            {
                this.buff.WriteLine("public {0} {1};",
                                    xsdBaseType.ToNetType(),
                                    this.contentFieldName.ToFieldName());
            }

            this.buff.Unindent();
            this.buff.WriteLine("}");
            this.buff.WriteLine();
        }

        private void BuildEvents(string name, string argType, bool needContent)
        {
            this.events.Add(new SimpleEvent(name, argType, needContent));
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
                    this.buff.WriteLine("public enum {0}", xsdType.Name.ToTypeName());
                    this.buff.WriteLine("{");

                    this.buff.Indent();
                    foreach (string value in values)
                    {
                        this.buff.WriteLine("[StringValue(\"{0}\")]", value);
                        this.buff.WriteLine("{0},", value.ToEnumValueName());
                    }
                    this.buff.Unindent();

                    this.buff.WriteLine("}");
                }
            }
        }

        private void BuildRead(XsdAttributes xsdAttributes, XsdType xsdBaseType)
        {
            // Constructor.
            this.buff.WriteLine("public override bool Read(IDictionary<string, string> attributes, string text)");
            this.buff.WriteLine("{");
            this.buff.Indent();

            this.buff.WriteLine("base.Read(attributes, text);");

            // Attributes.
            foreach (XsdAttribute xsdAttribute in xsdAttributes.Content)
            {
                XsdSimpleType xsdAttributeType = xsdAttribute.Type ?? XsdBuiltInType.String;

                if (xsdAttribute.DefValue != null)
                {
                    this.buff.WriteLine("this.{0} = XsdConverter.Instance.Convert<{2}>(attributes.GetSafe(\"{1}\"), XsdConverter.Instance.Convert<{2}>(\"{3}\"));",
                                        xsdAttribute.Name.ToFieldName(),
                                        xsdAttribute.Name,
                                        xsdAttributeType.ToNetType(),
                                        xsdAttribute.DefValue);
                }
                else
                {
                    this.buff.WriteLine("this.{0} = XsdConverter.Instance.Convert<{2}>(attributes.GetSafe(\"{1}\"));",
                                        xsdAttribute.Name.ToFieldName(),
                                        xsdAttribute.Name,
                                        xsdAttributeType.ToNetType());
                }
            }

            // Content.
            if (xsdBaseType is XsdSimpleType)
            {
                this.buff.WriteLine("this.{0} = XsdConverter.Instance.Convert<{1}>(text);",
                                    this.contentFieldName.ToFieldName(),
                                    xsdBaseType.ToNetType());
            }

            this.buff.WriteLine("return true;");

            this.buff.Unindent();
            this.buff.WriteLine("}");
        }

        private readonly string contentFieldName = "content";

        private string xsdNamespace;

        private readonly StringWriter stringWriter;
        private readonly TextWriterEx buff;

        private readonly List<SimpleEvent> events = new List<SimpleEvent>();

        #endregion

        public override void Process(XsdSchema schema)
        {
            this.xsdNamespace = schema.NamespaceURI;

            this.buff.WriteLine("// Simple types");
            this.buff.WriteLine("// ------------");

            foreach (XsdSimpleType xsdType in schema.Types.OfType<XsdSimpleType>().Where(x => !x.IsBuiltIn()))
            {
                this.Process(xsdType);
            }

            this.buff.WriteLine("");
            this.buff.WriteLine("// Complex types");
            this.buff.WriteLine("// -------------");

            foreach (XsdComplexType xsdType in schema.Types.OfType<XsdComplexType>())
            {
                this.BuildType(xsdType, xsdType.Name, true);
            }

            this.buff.WriteLine("");
            this.buff.WriteLine("// Elements from simple types");
            this.buff.WriteLine("// --------------------------");

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition is XsdSimpleType))
            {
                this.ProcessSimpleElement(element);
            }

            this.buff.WriteLine("");
            this.buff.WriteLine("// Elements from complex types");
            this.buff.WriteLine("// ---------------------------");

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition is XsdComplexType))
            {
                this.ProcessComplexElement(element);
            }

            this.buff.WriteLine("");
            this.buff.WriteLine("// Elements others");
            this.buff.WriteLine("// ---------------");

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition == null))
            {
                this.buff.WriteLine("// class {0} ???", element.Name);
            }
        }

        private void ProcessComplexElement(XsdElement xsdElement)
        {
            Contract.Assert(xsdElement.TypeDefinition is XsdComplexType);
            if (xsdElement.TypeDefinition.TopLevel)
            {
                this.BuildEvents(xsdElement.Name, xsdElement.TypeDefinition.ToNetType(), false);
            }
            else
            {
                this.BuildType((XsdComplexType)xsdElement.TypeDefinition, xsdElement.Name, false);

                this.BuildEvents(xsdElement.Name, xsdElement.Name.ToTypeName(), false);
            }
        }

        private void ProcessSimpleElement(XsdElement xsdElement)
        {
            Contract.Assert(xsdElement.TypeDefinition is XsdSimpleType);
            this.BuildEvents(xsdElement.Name, xsdElement.TypeDefinition.ToNetType(), true);
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

        #region XsdComplexType

        public override void Process(XsdComplexType xsdType)
        {
            XsdType xsdBaseType = xsdType.GetBaseType();
            this.BuildRead(xsdType.Attributes, xsdBaseType);

            this.Process(xsdType.Attributes);
        }

        #endregion

        #region XsdParticle

        public override void Process(XsdParticleGroup xsdParticle)
        {
            this.buff.WriteLine("// {0} {1}", xsdParticle.GroupType, xsdParticle.SafeOccursToString());
            this.buff.WriteLine("{");
            this.buff.Indent();

            foreach (XsdParticle xsdParticleItem in xsdParticle.Items)
            {
                this.Process(xsdParticleItem);
            }

            this.buff.Unindent();
            this.buff.WriteLine("}");
        }

        public override void Process(XsdParticleAny xsdParticle)
        {
            this.buff.WriteLine("// <Any>");
        }

        public override void Process(XsdParticleElement xsdParticle)
        {
            this.buff.WriteLine("{0} {1}", xsdParticle.Element.Name, xsdParticle.SafeOccursToString());
        }

        #endregion

        #region XsdAttribute

        public override void Process(XsdAttributes xsdAttributes)
        {
            foreach (XsdAttribute xsdAttribute in xsdAttributes.Content)
            {
                XsdSimpleType xsdAttributeType = xsdAttribute.Type ?? XsdBuiltInType.String;

                this.buff.WriteLine("public {0} {1};",
                                    xsdAttributeType.ToNetType(),
                                    xsdAttribute.Name.ToFieldName());
            }
        }

        #endregion

        #region inner classes

        private sealed class SimpleEvent
        {
            public SimpleEvent(string name, string argType, bool needContent)
            {
                this.Name = name;
                this.ArgType = argType;
                this.NeedContent = needContent;
            }

            public readonly string Name;
            public readonly string ArgType;
            public readonly bool NeedContent;
        }

        #endregion
    }
}