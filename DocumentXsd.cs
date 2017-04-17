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

using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor
{
    public class DocumentXsd : XsdProcess
    {
        public DocumentXsd()
        {
            this.stringWriter = new StringWriter();
            this.buff = new TextWriterEx(this.stringWriter);
        }

        public void Write()
        {
            Debug.WriteLine(this.stringWriter);
        }

        private readonly StringWriter stringWriter;
        private readonly TextWriterEx buff;

        public override void Process(XsdSchema schema)
        {
            this.buff.WriteLine("// Simple types");
            this.buff.WriteLine("// ------------");

            foreach (XsdSimpleType xsdType in schema.Types.OfType<XsdSimpleType>().Where(x => !x.IsBuiltIn()))
            {
                this.buff.WriteLine(xsdType.ToString());
            }

            this.buff.WriteLine("// Elements from simple type");
            this.buff.WriteLine("// -------------------------");

            foreach (XsdElement element in schema.Elements.Where(e => e.TypeDefinition is XsdSimpleType))
            {
                this.ProcessSimpleElement(element);
            }

            this.buff.WriteLine("// Complex types");
            this.buff.WriteLine("// -------------");

            foreach (XsdComplexType xsdType in schema.Types.OfType<XsdComplexType>())
            {
                this.ProcessComplexType(xsdType, xsdType.Name, true);
            }

            this.buff.WriteLine("// Elements from complex type");
            this.buff.WriteLine("// --------");

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
                this.buff.WriteLine("class {0} : {1} {{ }}", element.Name, element.TypeDefinition.Name);
            }
            else
            {
                this.ProcessComplexType((XsdComplexType)element.TypeDefinition, element.Name, false);
            }
        }

        private void ProcessSimpleElement(XsdElement element)
        {
            Contract.Assert(element.TypeDefinition is XsdSimpleType);
            if (element.TypeDefinition.TopLevel)
            {
                this.buff.WriteLine("class {0} : {1}", element.Name, element.TypeDefinition.Name);
            }
            else
            {
                this.buff.WriteLine("class {0} : {1}", element.Name, element.TypeDefinition);
            }
        }

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

            if (xsdType.GetParticle() != null)
            {
                this.ProcessParticle(xsdType.GetParticle());
            }
        }

        #endregion

        #region XsdParticle

        private void ProcessParticle(XsdParticle root)
        {
            // Sequence [1, 1]
            //   Choice [0, *]
            //     ( Element )+
            if (root.IsSequence(Path.Empty, 1, 1) && root.CountItems(Path.Empty) == 1
                && root.IsChoice(new Path(0), 0, int.MaxValue)
                && root.AllItemsAreElements(new Path(0)))
            {
                XsdParticleGroup group = (XsdParticleGroup)root.Get(new Path(0));
                this.buff.WriteLine("// List of " + @group.Items.Cast<XsdParticleElement>().Select(x => x.Element.Name).ToStringAsList(" ; "));
                return;
            }

            // Choice [0, *] OR Choice [1, *]
            //   ( Element )+
            if ((root.IsChoice(Path.Empty, 0, int.MaxValue) || root.IsChoice(Path.Empty, 1, int.MaxValue))
                && root.AllItemsAreElements(Path.Empty))
            {
                XsdParticleGroup group = (XsdParticleGroup)root.Get(Path.Empty);
                this.buff.WriteLine("// List of " + @group.Items.Cast<XsdParticleElement>().Select(x => x.Element.Name).ToStringAsList(" ; "));
                return;
            }

            // Choice [1, 1]
            //   Element
            if (root.IsChoice(Path.Empty, 1, 1) && root.CountItems(Path.Empty) == 1
                && root.AllItemsAreElements(Path.Empty))
            {
                XsdParticleGroup group = (XsdParticleGroup)root.Get(Path.Empty);
                this.Write((XsdParticleElement)group.Items[0]);
                return;
            }

            // Sequence [1, 1]
            //   ( Element )+
            if (root.IsSequence(Path.Empty, 1, 1)
                && root.AllItemsAreElements(Path.Empty))
            {
                XsdParticleGroup group = (XsdParticleGroup)root.Get(Path.Empty);
                foreach (XsdParticleElement item in group.Items.Cast<XsdParticleElement>())
                {
                    this.Write(item);
                }
                return;
            }

            // Sequence [1, 1]
            //   Choice [1, 1]
            //     ( Element )+
            //   Element
            if (root.IsSequence(Path.Empty, 1, 1) && root.CountItems(Path.Empty) == 2
                && root.IsChoice(new Path(0), 1, 1) && root.AllItemsAreElements(new Path(0))
                && root.IsElement(new Path(1)))
            {
                XsdParticleGroup group = (XsdParticleGroup)root.Get(new Path(0));
                this.buff.WriteLine("// Choice");
                this.buff.Indent();
                foreach (XsdParticleElement item in group.Items.Cast<XsdParticleElement>())
                {
                    this.Write(item);
                }
                this.buff.Unindent();
                this.Write((XsdParticleElement)root.Get(new Path(1)));
                return;
            }

            // Sequence [1, 1]
            //   ( Element OR ( ( Choice [0, *] OR Choice [1, *])
            //                      ( Element )+ ) )+
            if (root.IsSequence(Path.Empty, 1, 1)
                && root.AllItemsAreElementOrChoiceOfElements(Path.Empty))
            {
                XsdParticleGroup group = (XsdParticleGroup)root;
                foreach (XsdParticle item in group.Items)
                {
                    if (item is XsdParticleElement)
                    {
                        this.Write((XsdParticleElement)item);
                    }
                    else
                    {
                        XsdParticleGroup group2 = (XsdParticleGroup)item;
                        this.buff.WriteLine("// List of " + group2.Items.Cast<XsdParticleElement>().Select(x => x.Element.Name).ToStringAsList(" ; "));
                    }
                }
                return;
            }

            this.Process(root);
        }

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
                    this.buff.WriteLine(xsdAttribute.Type.Name);
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
    }
}