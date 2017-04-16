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
using System.Text;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaTest
{
    public class PlantUmlOutput : XsdProcess
    {
        public PlantUmlOutput()
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
            if (IsSequence(root, Path.Empty, 1, 1) && CountItems(root, Path.Empty) == 1
                && IsChoice(root, new Path(0), 0, int.MaxValue)
                && AllItemsAreElements(root, new Path(0)))
            {
                XsdParticleGroup group = (XsdParticleGroup)Get(root, new Path(0));
                this.buff.WriteLine("// List of " + ToStringAsList(group.Items.Cast<XsdParticleElement>().Select(x => x.Element.Name), " ; "));
                return;
            }

            // Choice [0, *] OR Choice [1, *]
            //   ( Element )+
            if ((IsChoice(root, Path.Empty, 0, int.MaxValue) || IsChoice(root, Path.Empty, 1, int.MaxValue))
                && AllItemsAreElements(root, Path.Empty))
            {
                XsdParticleGroup group = (XsdParticleGroup)Get(root, Path.Empty);
                this.buff.WriteLine("// List of " + ToStringAsList(group.Items.Cast<XsdParticleElement>().Select(x => x.Element.Name), " ; "));
                return;
            }

            // Choice [1, 1]
            //   Element
            if (IsChoice(root, Path.Empty, 1, 1) && CountItems(root, Path.Empty) == 1
                && AllItemsAreElements(root, Path.Empty))
            {
                XsdParticleGroup group = (XsdParticleGroup)Get(root, Path.Empty);
                this.Write((XsdParticleElement)group.Items[0]);
                return;
            }

            // Sequence [1, 1]
            //   ( Element )+
            if (IsSequence(root, Path.Empty, 1, 1)
                && AllItemsAreElements(root, Path.Empty))
            {
                XsdParticleGroup group = (XsdParticleGroup)Get(root, Path.Empty);
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
            if (IsSequence(root, Path.Empty, 1, 1) && CountItems(root, Path.Empty) == 2
                && IsChoice(root, new Path(0), 1, 1) && AllItemsAreElements(root, new Path(0))
                && IsElement(root, new Path(1)))
            {
                XsdParticleGroup group = (XsdParticleGroup)Get(root, new Path(0));
                this.buff.WriteLine("// Choice");
                this.buff.Indent();
                foreach (XsdParticleElement item in group.Items.Cast<XsdParticleElement>())
                {
                    this.Write(item);
                }
                this.buff.Unindent();
                this.Write((XsdParticleElement)Get(root, new Path(1)));
                return;
            }

            // Sequence [1, 1]
            //   ( Element OR ( ( Choice [0, *] OR Choice [1, *])
            //                      ( Element )+ ) )+
            if (IsSequence(root, Path.Empty, 1, 1)
                && AllItemsAreElementOrChoiceOfElements(root, Path.Empty))
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
                        this.buff.WriteLine("// List of " + ToStringAsList(group2.Items.Cast<XsdParticleElement>().Select(x => x.Element.Name), " ; "));
                    }
                }
                return;
            }

            this.Process(root);
        }

        public override void Process(XsdParticleGroup xsdParticle)
        {
            this.buff.WriteLine("// {0} [{1}, {2}]", xsdParticle.GroupType, xsdParticle.MinOccurs, SafeMaxOccursToString(xsdParticle.MaxOccurs));
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
            this.buff.WriteLine("{0} [{1}, {2}]", xsdParticle.Element.Name, xsdParticle.MinOccurs, SafeMaxOccursToString(xsdParticle.MaxOccurs));
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

        private static bool IsSequence(XsdParticle root, Path path, int min, int max)
        {
            return IsGroup(root, path, ParticleGroupType.Sequence, min, max);
        }

        private static bool IsChoice(XsdParticle root, Path path, int min, int max)
        {
            return IsGroup(root, path, ParticleGroupType.Choice, min, max);
        }

        private static bool IsGroup(XsdParticle root, Path path, ParticleGroupType type, int min, int max)
        {
            bool ret = false;

            XsdParticleGroup group = root as XsdParticleGroup;
            if (group != null)
            {
                if (path.IsEmpty())
                {
                    ret = (group.GroupType == type) && (group.MinOccurs == min) && (group.MaxOccurs == max);
                }
                else if (path.Head() < group.Items.Count)
                {
                    ret = IsGroup(group.Items[path.Head()], path.Tail(), type, min, max);
                }
            }
            return ret;
        }

        private static bool AllItemsAreElements(XsdParticle root, Path path)
        {
            bool ret = false;

            XsdParticleGroup group = Get(root, path) as XsdParticleGroup;
            if (group != null)
            {
                ret = group.Items.All(x => x is XsdParticleElement);
            }
            return ret;
        }

        private static int CountItems(XsdParticle root, Path path)
        {
            int ret = 0;

            XsdParticleGroup group = Get(root, path) as XsdParticleGroup;
            if (group != null)
            {
                ret = group.Items.Count;
            }
            return ret;
        }

        private static bool IsElement(XsdParticle root, Path path)
        {
            return Get(root, path) is XsdParticleElement;
        }

        private static bool TestAllItems(XsdParticle root, Path path, Func<Path, bool> test)
        {
            bool ret = false;

            XsdParticleGroup group = Get(root, path) as XsdParticleGroup;
            if (group != null)
            {
                ret = true;
                int i = 0;
                while ((i < group.Items.Count) && ret)
                {
                    if (!test(path.Sub(i)))
                    {
                        ret = false;
                    }
                    i++;
                }
            }
            return ret;
        }

        private static bool TestAllItems_2(XsdParticle root, Path path, Func<Path, bool> test)
        {
            XsdParticleGroup group = Get(root, path) as XsdParticleGroup;
            if (group == null)
            {
                return false;
            }

            for (int i = 0; i < group.Items.Count; i++)
            {
                if (!test(path.Sub(i)))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool AllItemsAreElementOrChoiceOfElements(XsdParticle root, Path path)
        {
            return TestAllItems(root, path, subpath =>
            {
                return IsElement(root, subpath)
                       || ((IsChoice(root, subpath, 0, int.MaxValue) || IsChoice(root, subpath, 1, int.MaxValue))
                           && AllItemsAreElements(root, subpath));
            });
        }

        #endregion

        private static XsdParticle Get(XsdParticle root, Path path)
        {
            XsdParticle found = null;

            if (path.IsEmpty())
            {
                found = root;
            }
            else
            {
                XsdParticleGroup group = root as XsdParticleGroup;
                if (group != null)
                {
                    if (path.Head() < group.Items.Count)
                    {
                        found = Get(group.Items[path.Head()], path.Tail());
                    }
                }
            }
            return found;
        }

        private void Write(XsdParticleElement particle)
        {
            if (particle.MaxOccurs == 1)
            {
                this.buff.WriteLine("// " + particle.Element.Name);
            }
            else
            {
                this.buff.WriteLine("// List of {0} [{1}, {2}]", particle.Element.Name, particle.MinOccurs, SafeMaxOccursToString(particle.MaxOccurs));
            }
        }

        private static string ToStringAsList(IEnumerable<string> enumer, string sep)
        {
            StringBuilder buff = new StringBuilder();
            bool first = true;
            foreach (string s in enumer)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    buff.Append(sep);
                }
                buff.Append(s);
            }
            return buff.ToString();
        }

        private static string SafeMaxOccursToString(int maxOccurs)
        {
            if (maxOccurs == int.MaxValue)
            {
                return "*";
            }
            return maxOccurs.ToString();
        }

        private class Path
        {
            public static readonly Path Empty = new Path(new int[0]);

            public Path(params int[] value)
            {
                this.value = value;
            }

            public bool IsEmpty()
            {
                return this.value.Length == 0;
            }

            public int Head()
            {
                return this.value[0];
            }

            public Path Tail()
            {
                return new Path(this.value.Skip(1).ToArray());
            }

            public Path Sub(int i)
            {
                return new Path(this.value.Concat(new[] { i }).ToArray());
            }

            private readonly int[] value;
        }
    }
}