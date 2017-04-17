using System;
using System.Collections.Generic;
using System.Xml;
// XsdBaseObject.Read(IDictionary<string, string> attributes, string text)
using BeginRead = System.Action<System.Collections.Generic.IDictionary<string, string>, string>;
using EndRead = System.Action;

namespace XmlSchemaProcessor.LandXml
{
    public class SimpleReader
    {
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
                        ReadBeginEnd readBeginEnd = this.map.GetSafe(reader.Name) ?? this.defaultReader;
                        IDictionary<string, string> attributes = this.ReadAttributes(reader);

                        //reader.mo

                        readBeginEnd.BeginRead(attributes, "");
                        break;
                    }
                    case XmlNodeType.Text:
                    case XmlNodeType.CDATA:
                        break;
                    case XmlNodeType.XmlDeclaration:
                    case XmlNodeType.ProcessingInstruction:
                        break;
                    case XmlNodeType.Comment:
                        break;
                    case XmlNodeType.EndElement:
                    {
                        ReadBeginEnd readBeginEnd = this.map.GetSafe(reader.Name) ?? this.defaultReader;
                        readBeginEnd.EndRead();
                        break;
                    }
                }
            }
        }

        /*public void Register<T>(string elementName, Action<T> beginRead, Action<T> endRead)
        {
            this.map.Add(elementName, new ReadBeginEnd(x => beginRead((T)x), x => endRead((T)x)));
        }*/

        public void Register<T>(string elementName, Action<T> beginRead, EndRead endRead)
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
                             }, endRead));
        }

        public void Register(string elementName, BeginRead beginRead, EndRead endRead)
        {
            this.map.Add(elementName, new ReadBeginEnd(beginRead, endRead));
        }

        private IDictionary<string, string> ReadAttributes(XmlReader reader)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            if (reader.MoveToFirstAttribute())
            {
                while (reader.MoveToNextAttribute())
                {
                    string name = reader.Name;
                    reader.ReadAttributeValue();
                    string value = reader.Value;
                    attributes.SafeAdd(name, value);
                }
                reader.MoveToElement();
            }
            return attributes;
        }

        private readonly Dictionary<string, ReadBeginEnd> map = new Dictionary<string, ReadBeginEnd>();

        private readonly ReadBeginEnd defaultReader = new ReadBeginEnd(
            (attrs, text) =>
            {
            }, () =>
            {
            });

        private class ReadBeginEnd
        {
            public ReadBeginEnd(BeginRead beginRead, EndRead endRead)
            {
                this.beginRead = beginRead;
                this.endRead = endRead;
            }

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
    }
}