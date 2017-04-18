﻿// Copyright 2017 Jose Luis Rovira Martin
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
using System.Text;
using XmlSchemaProcessor.Xsd;
using XmlSchemaProcessor.Xsd.Facets;

namespace XmlSchemaProcessor.Processors
{
    public class XsdToNetProcess : XsdProcess
    {
        public XsdToNetProcess()
        {
        }

        public void Write(string outFile, string @namespace)
        {
            using (FileStream fstream = new FileInfo(outFile).Open(FileMode.Create, FileAccess.Write))
            using (StreamWriter stream = new StreamWriter(fstream))
            using (TextWriterEx writer = new TextWriterEx(stream))
            {
                writer.WriteLine("#if !BUILD_LAND_XML");

                writer.WriteLine("using System;");
                writer.WriteLine("using System.IO;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using XmlSchemaProcessor.Processors;");

                writer.WriteLine("namespace {0}", @namespace);
                writer.WriteLine("{");
                writer.Indent();

                writer.WriteLine(this.buff.Inner);

                this.WriteEventInterface(writer);
                this.WriteEventImplementation(writer);
                this.WriteEventTest(writer);
                this.WriteReader(writer);

                writer.Unindent();
                writer.WriteLine("}");

                writer.WriteLine("#endif");
            }
            //Debug.WriteLine(this.stringWriter);
            //Debug.WriteLine("--------------------");
            //Debug.WriteLine(this.stringWriterEvents);
        }

        public void AddNamespaceURI(string uri)
        {
            this.namespacesURI.Add(uri);
        }

        #region private

        public static string PrepareNetDocumentation(string doc1, string doc2)
        {
            if (string.IsNullOrWhiteSpace(doc1))
            {
                return PrepareNetDocumentation(doc2);
            }
            if (string.IsNullOrWhiteSpace(doc2))
            {
                return PrepareNetDocumentation(doc1);
            }
            StringBuilder buff = new StringBuilder();
            buff.AppendLine(doc1);
            buff.AppendLine(doc2);
            return PrepareNetDocumentation(buff.ToString());
        }

        public static string PrepareNetDocumentation(string doc)
        {
            if (string.IsNullOrWhiteSpace(doc))
            {
                return string.Empty;
            }
            StringBuilder buff = new StringBuilder();
            buff.AppendLine("/// <summary>");
            buff.Append("/// ").AppendLine(doc.Replace("\n", "\n/// "));
            buff.AppendLine("/// </summary>");
            return buff.ToString();
        }

        private void WriteEventInterface(TextWriterEx writer)
        {
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
        }

        private void WriteEventImplementation(TextWriterEx writer)
        {
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
        }

        private void WriteEventTest(TextWriterEx writer)
        {
            // Clase para los eventos.
            writer.WriteLine("public class TestLandXmlEvents : ILandXmlEvents");
            writer.WriteLine("{");
            writer.Indent();

            writer.WriteLine("public bool AsXml { get; set; }");

            // DebugWrite
            writer.WriteLine("public void DebugWrite(string outFile)");
            writer.WriteLine("{");
            writer.Indent();

            writer.WriteLine("using (FileStream fstream = new FileInfo(outFile).Open(FileMode.Create, FileAccess.Write))");
            writer.WriteLine("using (StreamWriter stream = new StreamWriter(fstream))");
            writer.WriteLine("using (TextWriterEx writer = new TextWriterEx(stream))");
            writer.WriteLine("{");
            writer.Indent();

            writer.WriteLine("writer.WriteLine(this.buff.Inner);");

            writer.Unindent();
            writer.WriteLine("}");

            writer.Unindent();
            writer.WriteLine("}");

            writer.WriteLine("private readonly TextWriterEx buff = new TextWriterEx(new StringWriter());");

            foreach (SimpleEvent simpleEvent in this.events)
            {
                writer.WriteLine("public virtual void BeginRead{0}( {1} value )",
                                 simpleEvent.Name.FirstUpper(),
                                 simpleEvent.ArgType);
                writer.WriteLine("{");
                writer.Indent();

                // BeginRead
                writer.WriteLine("if (this.AsXml)");
                writer.WriteLine("{");
                writer.Indent();

                writer.WriteLine("buff.WriteLine(\"<{0}>\");",
                                 simpleEvent.Name.FirstUpper());
                writer.WriteLine("buff.Indent();");

                writer.Unindent();
                writer.WriteLine("}");
                writer.WriteLine("else");
                writer.WriteLine("{");
                writer.Indent();

                writer.WriteLine("buff.WriteLine(\"BeginRead{0}\");",
                                 simpleEvent.Name.FirstUpper());
                writer.WriteLine("buff.Indent();");
                writer.WriteLine("buff.WriteLine(value);");
                writer.WriteLine("buff.Indent();");

                writer.Unindent();
                writer.WriteLine("}");

                writer.Unindent();
                writer.WriteLine("}");

                // EndRead
                writer.WriteLine("public virtual void EndRead{0}()",
                                 simpleEvent.Name.FirstUpper());

                writer.WriteLine("{");
                writer.Indent();

                writer.WriteLine("if (this.AsXml)");
                writer.WriteLine("{");
                writer.Indent();

                writer.WriteLine("buff.Unindent();");
                writer.WriteLine("buff.WriteLine(\"</{0}>\");",
                                 simpleEvent.Name.FirstUpper());

                writer.Unindent();
                writer.WriteLine("}");
                writer.WriteLine("else");
                writer.WriteLine("{");
                writer.Indent();

                writer.WriteLine("buff.Unindent();");
                writer.WriteLine("buff.Unindent();");
                writer.WriteLine("buff.WriteLine(\"EndRead{0}\");",
                                 simpleEvent.Name.FirstUpper());

                writer.Unindent();
                writer.WriteLine("}");

                writer.Unindent();
                writer.WriteLine("}");
            }

            writer.Unindent();
            writer.WriteLine("}");
        }

        private void WriteReader(TextWriterEx writer)
        {
            // Clase reader.
            writer.WriteLine("public class LandXmlReader : SimpleReader");
            writer.WriteLine("{");
            writer.Indent();

            writer.WriteLine("public LandXmlReader(ILandXmlEvents events)");
            writer.Indent();
            writer.Write(": base(");
            bool first = true;
            foreach (string uri in this.namespacesURI)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    writer.Write(", ");
                }
                writer.Write("\"{0}\"", uri);
            }
            writer.WriteLine(")");

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
        }

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

        private void BuildType(XsdComplexType xsdComplexType, string name, string docToAdd = "")
        {
            XsdType xsdBaseType = xsdComplexType.GetBaseType();

            this.buff.Write(PrepareNetDocumentation(docToAdd, xsdComplexType.GetNetDocumentation()));

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

            this.Process(xsdComplexType);

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
                    this.buff.Write(PrepareNetDocumentation(xsdType.GetNetDocumentation()));

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
                                        xsdAttributeType.ToNetType(xsdAttribute.Use != AttributeUse.Required),
                                        xsdAttribute.DefValue);
                }
                else
                {
                    this.buff.WriteLine("this.{0} = XsdConverter.Instance.Convert<{2}>(attributes.GetSafe(\"{1}\"));",
                                        xsdAttribute.Name.ToFieldName(),
                                        xsdAttribute.Name,
                                        xsdAttributeType.ToNetType(xsdAttribute.Use != AttributeUse.Required));
                }
            }

            // Content.
            if (xsdBaseType is XsdSimpleType)
            {
                this.buff.WriteLine("this.{0} = XsdConverter.Instance.Convert<{1}>(text);",
                                    this.contentFieldName.ToFieldName(),
                                    xsdBaseType.ToNetType(false));
            }

            this.buff.WriteLine("return true;");

            this.buff.Unindent();
            this.buff.WriteLine("}");
        }

        private void BuildToString(XsdAttributes xsdAttributes, XsdType xsdBaseType)
        {
            // Constructor.
            this.buff.WriteLine("public override string ToString()");
            this.buff.WriteLine("{");
            this.buff.Indent();

            this.buff.WriteLine("System.Text.StringBuilder buff = new System.Text.StringBuilder();");
            this.buff.WriteLine("buff.AppendLine(base.ToString());");

            // Attributes.
            foreach (XsdAttribute xsdAttribute in xsdAttributes.Content)
            {
                if (xsdAttribute.DefValue != null)
                {
                    this.buff.WriteLine("buff.Append(\"{0} = \").Append(this.{0}).AppendLine(\" defvalue = {1}\");",
                                        xsdAttribute.Name.ToFieldName(),
                                        xsdAttribute.DefValue);
                }
                else
                {
                    this.buff.WriteLine("buff.Append(\"{0} = \").AppendLine(this.{0});",
                                        xsdAttribute.Name.ToFieldName());
                }
            }

            // Content.
            if (xsdBaseType is XsdSimpleType)
            {
                this.buff.WriteLine("buff.Append(\"{0} = \").AppendLine(this.{0});",
                                    this.contentFieldName.ToFieldName());
            }

            this.buff.WriteLine("return buff.ToString();");

            this.buff.Unindent();
            this.buff.WriteLine("}");
        }

        private readonly string contentFieldName = "content";

        private readonly List<string> namespacesURI = new List<string>();

        private readonly TextWriterEx buff = new TextWriterEx(new StringWriter());

        private readonly List<SimpleEvent> events = new List<SimpleEvent>();

        #endregion

        public override void Process(XsdSchema schema)
        {
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
                this.BuildType(xsdType, xsdType.Name);
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
                this.BuildEvents(xsdElement.Name, xsdElement.TypeDefinition.ToNetType(false), false);
            }
            else
            {
                this.BuildType((XsdComplexType)xsdElement.TypeDefinition, xsdElement.Name, xsdElement.GetNetDocumentation());

                this.BuildEvents(xsdElement.Name, xsdElement.Name.ToTypeName(), false);
            }
        }

        private void ProcessSimpleElement(XsdElement xsdElement)
        {
            Contract.Assert(xsdElement.TypeDefinition is XsdSimpleType);
            this.BuildEvents(xsdElement.Name, xsdElement.TypeDefinition.ToNetType(false), true);
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
            this.BuildToString(xsdType.Attributes, xsdBaseType);

            // Attributes.
            this.Process(xsdType.Attributes);

            // Content.
            if (xsdBaseType is XsdSimpleType)
            {
                this.buff.WriteLine("public {0} {1};",
                                    xsdBaseType.ToNetType(false),
                                    this.contentFieldName.ToFieldName());
            }
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

                this.buff.Write(PrepareNetDocumentation(xsdAttributeType.GetNetDocumentation()));

                this.buff.WriteLine("public {0} {1};",
                                    xsdAttributeType.ToNetType(xsdAttribute.Use != AttributeUse.Required),
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