#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    // needContent    : true
    // includeContent : true
    /// <summary>
    /// A  Point of Vertical Intersection with a space delimited "station elevation" text value.
    /// with an unsymetrical parabolic vertical curve defined by "lengthIn and "lengthOut" attributes.
    /// </summary>

    public class UnsymParaCurve : XsdBaseReader
    {
        public UnsymParaCurve(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.LengthIn = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("lengthIn"));

            this.LengthOut = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("lengthOut"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Content = XsdConverter.Instance.Convert<IList<double>>(text);
            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.LengthIn != null)
            {
                buff.AppendFormat("lengthIn = {0}", this.LengthIn).AppendLine();
            }
            if ((object)this.LengthOut != null)
            {
                buff.AppendFormat("lengthOut = {0}", this.LengthOut).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }

            if ((object)this.Content != null)
            {
                buff.AppendFormat("content = {0}", this.Content).AppendLine();
            }
            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.LengthIn != null)
            {
                buff.Append("lengthIn", this.LengthIn);
            }
            if ((object)this.LengthOut != null)
            {
                buff.Append("lengthOut", this.LengthOut);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }

            if ((object)this.Content != null)
            {
                buff.Append("content", this.Content);
            }
            return buff.ToString();
        }

        public double LengthIn;

        public double LengthOut;

        public string Desc;


        protected override bool NeedContent { get { return true; } }

        public IList<double> Content;

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

