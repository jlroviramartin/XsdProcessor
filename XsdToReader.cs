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
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using XmlSchemaProcessor.Xsd;
using XmlSchemaProcessor.Xsd.Facets;

namespace XmlSchemaTest
{
    public class XsdToReader : XsdProcess
    {
        public XsdToReader()
        {
            this.stringWriter = new StringWriter();
            this.buff = new TextWriterEx(this.stringWriter);

            this.stringWriterReaders = new StringWriter();
            this.buffReaders = new TextWriterEx(this.stringWriterReaders);
        }

        public void Write()
        {
            Debug.WriteLine(this.stringWriter);
            Debug.WriteLine("--------------------");
            Debug.WriteLine(this.stringWriterReaders);
        }

        private void Write(XsdParticleElement particle)
        {
            if (particle.MaxOccurs == 1)
            {
                this.buff.WriteLine("// " + particle.Element.Name);
            }
            else
            {
                this.buff.WriteLine("// List of {0} {1}", particle.Element.Name, particle.SafeOccursToString());
            }
        }

        private readonly StringWriter stringWriter;
        private readonly TextWriterEx buff;

        private readonly StringWriter stringWriterReaders;
        private readonly TextWriterEx buffReaders;

        public override void Process(XsdSchema schema)
        {
            this.buff.WriteLine("// Simple types");
            this.buff.WriteLine("// ------------");

            foreach (XsdSimpleType xsdType in schema.Types.OfType<XsdSimpleType>().Where(x => !x.IsBuiltIn()))
            {
                //this.buff.WriteLine(xsdType.ToString());
                this.Process(xsdType);
            }

            this.buff.WriteLine("// Complex types");
            this.buff.WriteLine("// -------------");

            foreach (XsdComplexType xsdType in schema.Types.OfType<XsdComplexType>())
            {
                this.ProcessComplexType(xsdType, xsdType.Name, true);
            }

            this.buff.WriteLine("");
            this.buff.WriteLine("");
            this.buff.WriteLine("");

            this.buff.WriteLine("// Elements from simple types");
            this.buff.WriteLine("// --------------------------");

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition is XsdSimpleType))
            {
                this.ProcessSimpleElement(element);
            }

            this.buff.WriteLine("// Elements from complex types");
            this.buff.WriteLine("// ---------------------------");

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition is XsdComplexType))
            {
                this.ProcessComplexElement(element);
            }

            this.buff.WriteLine("// Elements others");
            this.buff.WriteLine("// ---------------");

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition == null))
            {
                this.buff.WriteLine("class {0}", element.Name);
            }
        }

        private void ProcessComplexElement(XsdElement element)
        {
            Contract.Assert(element.TypeDefinition is XsdComplexType);
            if (element.TypeDefinition.TopLevel)
            {
                this.buffReaders.WriteLine("public void Read{0}( {1} value )", element.Name, element.TypeDefinition.Name);
            }
            else
            {
                this.ProcessComplexType((XsdComplexType)element.TypeDefinition, element.Name, false);
                this.buffReaders.WriteLine("public void Read{0}( {1} value )", element.Name, element.Name);
            }
        }

        private void ProcessSimpleElement(XsdElement element)
        {
            Contract.Assert(element.TypeDefinition is XsdSimpleType);
            this.buffReaders.WriteLine("public void Read{0}( {1} value )", element.Name, element.TypeDefinition.GetType());
        }

        #region XsdSimpleType

        public override void Process(XsdSimpleType xsdType)
        {
            if (xsdType is XsdSimpleRestrictionType)
            {
                XsdSimpleType builtInRootType = xsdType.GetBuiltInRootType();
                if ((builtInRootType != null) && builtInRootType.Name == XsdBuiltInType.STRING)
                {
                    string[] values = ((XsdSimpleRestrictionType)xsdType).Facets
                                                                         .Where(x => x.FacetType == FacetType.Enumeration)
                                                                         .Select(x => (string)x.Value)
                                                                         .ToArray();

                    if (values.Length > 0)
                    {
                        this.buff.WriteLine("enum {0}", xsdType.Name);
                        this.buff.WriteLine("{");

                        this.buff.Indent();
                        foreach (string value in values)
                        {
                            this.buff.Write(value);
                            this.buff.WriteLine(",");
                        }
                        this.buff.Unindent();

                        this.buff.WriteLine("}");
                    }
                }
            }
        }

        #endregion

        #region XsdComplexType

        public override void Process(XsdComplexType xsdType)
        {
            if (!string.IsNullOrEmpty(xsdType.Name))
            {
                this.buff.WriteLine("// " + xsdType.Name);
            }

            if (xsdType.GetBaseType() != null)
            {
                if (xsdType.GetBaseType().TopLevel)
                {
                    this.buff.WriteLine("// " + xsdType.GetDerivation() + " of " + xsdType.GetBaseType().Name);
                }
                else
                {
                    this.Process(xsdType.GetBaseType());
                }
            }

            this.Process(xsdType.Attributes);

            //if (xsdType.GetParticle() != null)
            //{
            //    this.Process(xsdType.GetParticle());
            //}
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
                this.buff.Write(xsdAttribute.Name + " : ");
                if (xsdAttribute.Type != null)
                {
                    this.buff.WriteLine(xsdAttribute.Type.ToType());
                }
                else
                {
                    this.buff.WriteLine(XsdBuiltInType.STRING);
                }
            }
        }

        #endregion

        private void ProcessComplexType(XsdComplexType complexType, string name, bool @abstract)
        {
            if (@abstract)
            {
                this.buff.Write("abstract ");
            }
            if ((complexType.GetBaseType() != null) && complexType.GetBaseType().TopLevel)
            {
                //this.buff.WriteLine("{0} <|-- {1}", complexType.GetBaseType().Name, name);
                this.buff.WriteLine("class {0} : {1}", name, complexType.GetBaseType().Name);
            }
            else
            {
                this.buff.WriteLine("class {0}", name);
            }
            this.buff.WriteLine("{");
            this.buff.Indent();

            this.Process(complexType);

            this.buff.Unindent();
            this.buff.WriteLine("}");
        }

        #region Test particle

        #endregion
    }
}