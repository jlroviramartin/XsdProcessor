using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using BeginRead = System.Action<System.Collections.Generic.IDictionary<string, string>, string>;
using EndRead = System.Action;

namespace XmlSchemaProcessor.Processors
{
    public class SimpleReader
    {
        public SimpleReader(params string[] namespacesURI)
        {
            this.namespacesURI = new HashSet<string>(namespacesURI);
        }

        public void Read(string url)
        {
            using (XmlReader xmlReader = new XmlTextReader(url))
            {
                this.Read(xmlReader);
            }
        }

        public void Read(XmlReader reader)
        {
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                    {
                        ReadBeginEnd readBeginEnd;
                        IDictionary<string, string> attributes;
                        if (this.TestURI(reader.NamespaceURI))
                        {
                            readBeginEnd = this.map.GetSafe(reader.Name);
                            attributes = this.ReadAttributes(reader, true);
                        }
                        else
                        {
                            readBeginEnd = this.nonNamespaceURIReader;
                            attributes = this.ReadAttributes(reader, false);
                        }

                        string content = null;
                        if (readBeginEnd.NeedContent)
                        {
                            content = ReadContent(reader);
                        }

                        readBeginEnd.BeginRead(attributes, content);

                        if (readBeginEnd.NeedContent || reader.IsEmptyElement)
                        {
                            readBeginEnd.EndRead();
                        }
                        break;
                    }
                    case XmlNodeType.EndElement:
                    {
                        ReadBeginEnd readBeginEnd = this.map.GetSafe(reader.Name);
                        readBeginEnd.EndRead();
                        break;
                    }
                }
            }
        }

        public void Register<T>(string elementName, Action<T> beginRead, EndRead endRead, bool needContent)
        {
            this.map.Add(elementName, new ReadBeginEnd(
                             (attrs, text) =>
                             {
                                 if (typeof(XsdBaseObject).IsAssignableFrom(typeof(T)))
                                 {
                                     T value = Activator.CreateInstance<T>();
                                     ((XsdBaseObject)(object)value).Read(attrs, text);
                                     beginRead(value);
                                 }
                                 else
                                 {
                                     beginRead(XsdConverter.Instance.Convert<T>(text));
                                 }
                             },
                             endRead,
                             needContent));
        }

        public void Register(string elementName, BeginRead beginRead, EndRead endRead, bool needContent)
        {
            this.map.Add(elementName, new ReadBeginEnd(beginRead, endRead, needContent));
        }

        #region private

        private IDictionary<string, string> ReadAttributes(XmlReader reader, bool useNamespaceURI)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            if (reader.MoveToFirstAttribute())
            {
                while (reader.MoveToNextAttribute())
                {
                    bool sameURI = this.TestURI(reader.NamespaceURI);

                    if (string.IsNullOrWhiteSpace(reader.NamespaceURI)
                        || (useNamespaceURI && sameURI)
                        || (!useNamespaceURI && !sameURI))
                    {
                        string name = reader.Name;
                        reader.ReadAttributeValue();
                        string value = reader.Value;
                        attributes.SafeAdd(name, value);
                    }
                }
                reader.MoveToElement();
            }
            return attributes;
        }

        private static string ReadContent(XmlReader reader)
        {
            StringBuilder buff = new StringBuilder();
            using (XmlReader subReader = reader.ReadSubtree())
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

        private bool TestURI(string uri)
        {
            return this.namespacesURI.Contains(uri);
        }

        private readonly HashSet<string> namespacesURI;
        private readonly Dictionary<string, ReadBeginEnd> map = new Dictionary<string, ReadBeginEnd>();

        private readonly ReadBeginEnd nonNamespaceURIReader = new ReadBeginEnd(
            (attrs, text) =>
            {
            }, () =>
            {
            },
            false);

        #endregion

        #region inner classes

        private class ReadBeginEnd
        {
            public ReadBeginEnd(BeginRead beginRead, EndRead endRead, bool needContent)
            {
                this.beginRead = beginRead;
                this.endRead = endRead;
                this.NeedContent = needContent;
            }

            public readonly bool NeedContent;

            public void BeginRead(IDictionary<string, string> attributes, string text)
            {
                this.beginRead(attributes, text);
            }

            public void EndRead()
            {
                this.endRead();
            }

            private readonly BeginRead beginRead;
            private readonly EndRead endRead;
        }

        #endregion
    }
}