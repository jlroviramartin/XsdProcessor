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
using System.Reflection;
using System.Text;
using System.Xml;

namespace XmlSchemaProcessor.Common
{
    public class XsdBaseReader : XsdBaseObject
    {
        public int Depth
        {
            get { return this.depth; }
        }

        public bool NextChild()
        {
            bool hasNext = false;
            if (this.xmlReader.Read())
            {
                // We only process the children ('this.depth + 1').
                while (this.xmlReader.Depth > this.depth + 1)
                {
                    this.xmlReader.Read();
                }

                while ((this.xmlReader.Depth == this.depth + 1) && (this.xmlReader.NodeType != XmlNodeType.Element))
                {
                    this.xmlReader.Read();
                }

                if ((this.xmlReader.Depth == this.depth + 1) && (this.xmlReader.NodeType == XmlNodeType.Element))
                {
                    if (this.TestURI(this.xmlReader.NamespaceURI))
                    {
                        hasNext = this.NewReader(this.xmlReader.NamespaceURI, this.xmlReader.Name);
                    }
                }
            }
            return hasNext;
        }

        public string CurrentElementName
        {
            get { return this.currentElementName; }
        }

        public object CurrentElement
        {
            get { return this.currentElement; }
        }

        #region protected

        protected XsdBaseReader(XmlReader reader)
        {
            this.xmlReader = reader;
            this.depth = reader.Depth;
        }

        protected bool ReadAttributes()
        {
            IDictionary<string, string> attributes = new Dictionary<string, string>();
            if (this.xmlReader.MoveToFirstAttribute())
            {
                if (this.TestURI(this.xmlReader.NamespaceURI))
                {
                    attributes.Add(this.xmlReader.Name, this.xmlReader.Value);
                }
                while (this.xmlReader.MoveToNextAttribute())
                {
                    if (this.TestURI(this.xmlReader.NamespaceURI))
                    {
                        attributes.Add(this.xmlReader.Name, this.xmlReader.Value);
                    }
                }
                bool b = this.xmlReader.MoveToElement();
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

        protected virtual bool NewReader(string namespaceURI, string name)
        {
            return false;
        }

        protected object NewReader<T>()
        {
            T result;
            if (typeof(XsdBaseReader).IsAssignableFrom(typeof(T)))
            {
                Func<XmlReader, XsdBaseReader> fun;
                if (!this.map.TryGetValue(typeof(T), out fun))
                {
                    ConstructorInfo constructorInfo = typeof(T).GetConstructor(new[] { typeof(XmlReader) });
                    if (constructorInfo == null)
                    {
                        throw new Exception("No tiene un constructor apropiado.");
                    }
                    fun = (x) => (XsdBaseReader)constructorInfo.Invoke(new object[] { x });

                    this.map.Add(typeof(T), fun);
                }

                XmlReader xmlReader = this.xmlReader;
                if (this.useSubtree)
                {
                    xmlReader = this.xmlReader.ReadSubtree();
                    xmlReader.Read();
                }
                XsdBaseReader aux = fun(xmlReader);
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

        protected bool UseSubtree
        {
            get { return this.useSubtree; }
        }

        protected void SetCurrent(string name, object value)
        {
            this.currentElementName = name;
            this.currentElement = value;
        }

        #endregion

        #region private

        private string ReadContent()
        {
            StringBuilder buff = new StringBuilder();
            using (XmlReader subReader = this.xmlReader.ReadSubtree())
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

        private bool TestURI(string namespaceURI)
        {
            return true;
        }

        private readonly XmlReader xmlReader;
        private readonly int depth;
        private readonly Dictionary<Type, Func<XmlReader, XsdBaseReader>> map = new Dictionary<Type, Func<XmlReader, XsdBaseReader>>();

        private bool useSubtree;

        private string currentElementName;
        private object currentElement;

        #endregion
    }
}