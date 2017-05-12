#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    // needContent    : false
    // includeContent : false
    public class Invert : XsdBaseReader
    {
        public Invert(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Elev = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("elev"));

            this.FlowDir = XsdConverter.Instance.Convert<InOut>(
                    attributes.GetSafe("flowDir"));

            this.RefPipe = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("refPipe"));

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
            if ((object)this.Elev != null)
            {
                buff.AppendFormat("elev = {0}", this.Elev).AppendLine();
            }
            if ((object)this.FlowDir != null)
            {
                buff.AppendFormat("flowDir = {0}", this.FlowDir).AppendLine();
            }
            if ((object)this.RefPipe != null)
            {
                buff.AppendFormat("refPipe = {0}", this.RefPipe).AppendLine();
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
            if ((object)this.Elev != null)
            {
                buff.Append("elev", this.Elev);
            }
            if ((object)this.FlowDir != null)
            {
                buff.Append("flowDir", this.FlowDir);
            }
            if ((object)this.RefPipe != null)
            {
                buff.Append("refPipe", this.RefPipe);
            }

            return buff.ToString();
        }

        public string Desc;

        public double Elev;

        public InOut FlowDir;
        /// <summary>
        /// A reference name value referring to Pipe.name attribute.
        /// </summary>

        public string RefPipe;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

