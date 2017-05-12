#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    // needContent    : false
    // includeContent : false
    public class ComplexName : XsdBaseReader
    {
        public ComplexName(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Priority = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("priority"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Priority != null)
            {
                buff.AppendFormat("priority = {0}", this.Priority).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Priority != null)
            {
                buff.Append("priority", this.Priority);
            }

            return buff.ToString();
        }

        public string Desc;

        public int? Priority;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

