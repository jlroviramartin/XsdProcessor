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
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml;

namespace XmlSchemaProcessor.Processors
{
    public class XsdBaseReader : XsdBaseObject
    {
        public int Depth
        {
            get { return this.depth; }
        }

        public Tuple<string, object> NextChild()
        {
            Tuple<string, object> current = null;
            if (this.reader.Read())
            {
                // We only process the children ("this.depth + 1").
                while (this.reader.Depth > this.depth + 1)
                {
                    this.reader.Read();
                }

                while ((this.reader.Depth == this.depth + 1) && (this.reader.NodeType != XmlNodeType.Element))
                {
                    this.reader.Read();
                }

                if ((this.reader.Depth == this.depth + 1) && (this.reader.NodeType == XmlNodeType.Element))
                {
                    current = this.NewReader(this.reader.NamespaceURI, this.reader.Name);
                }
            }
            return current;
        }

        #region protected

        protected XsdBaseReader(XmlReader reader)
        {
            this.reader = reader;
            this.depth = reader.Depth;
        }

        protected bool ReadAttributes()
        {
            IDictionary<string, string> attributes = new Dictionary<string, string>();
            if (this.reader.MoveToFirstAttribute())
            {
                if (this.TestURI(this.reader.NamespaceURI))
                {
                    attributes.Add(this.reader.Name, this.reader.Value);
                }
                while (this.reader.MoveToNextAttribute())
                {
                    if (this.TestURI(this.reader.NamespaceURI))
                    {
                        attributes.Add(this.reader.Name, this.reader.Value);
                    }
                }
                bool b = this.reader.MoveToElement();
            }

            string content = string.Empty;
            if (this.NeedContent)
            {
                content = this.ReadContent();
            }
            return this.Read(attributes, content);
        }

        protected virtual bool NeedContent
        {
            get { return false; }
        }

        protected virtual Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }

        protected virtual object NewReader<T>()
        {
            T result;
            if (typeof(XsdBaseReader).IsAssignableFrom(typeof(T)))
            {
                ConstructorInfo constructorInfo = typeof(T).GetConstructor(new[] { typeof(XmlReader) });
                XsdBaseReader aux = (XsdBaseReader)constructorInfo.Invoke(new[] { this.reader });
                aux.ReadAttributes();
                result = (T)(object)aux;
            }
            else
            {
                string content = this.ReadContent();
                result = XsdConverter.Instance.Convert<T>(content);
            }
            return result;
        }

        #endregion

        #region private

        private bool TestURI(string namespaceURI)
        {
            return true;
        }

        private string ReadContent()
        {
            StringBuilder buff = new StringBuilder();
            using (XmlReader subReader = this.reader.ReadSubtree())
            {
                while (subReader.Read())
                {
                    if (subReader.NodeType == XmlNodeType.Text || subReader.NodeType == XmlNodeType.CDATA)
                    {
                        buff.Append(subReader.Value);
                    }
                }
            }
            return buff.ToString();
        }

        private readonly XmlReader reader;
        private readonly int depth;

        #endregion
    }

    /// <summary>
    /// This class build a string using name-value pairs, similar to the attributes of an Xml element.
    /// </summary>
    public class AttributesBuilder
    {
        public AttributesBuilder()
        {
        }

        public AttributesBuilder(string str)
        {
            this.buff.Append(str);
        }

        public AttributesBuilder Append(string name, object value)
        {
            if (this.buff.Length > 0)
            {
                this.buff.Append(" ");
            }
            if (value is ICollection)
            {
                StringBuilder buff = new StringBuilder();
                foreach (object v in (ICollection)value)
                {
                    if (buff.Length > 0)
                    {
                        buff.Append(" ");
                    }
                    buff.Append(v);
                }
                this.buff.Append(name)
                    .Append("=\"")
                    .Append(buff)
                    .Append("\"");
            }
            else
            {
                this.buff.Append(name)
                    .Append("=\"")
                    .Append(value)
                    .Append("\"");
            }
            return this;
        }

        #region private

        private readonly StringBuilder buff = new StringBuilder();

        #endregion

        #region object

        public override string ToString()
        {
            return this.buff.ToString();
        }

        #endregion
    }
}