#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// The "staInternal" value identifies the location of the station equation. It is the station value with no equations applied (staStart + dist).
    /// Sequence [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class StaEquation : XsdBaseReader
    {
        public StaEquation(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.StaAhead = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staAhead"));

            this.StaBack = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staBack"));

            this.StaInternal = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staInternal"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.StaAhead != null)
            {
                buff.AppendFormat("staAhead = {0}", this.StaAhead).AppendLine();
            }
            if ((object)this.StaBack != null)
            {
                buff.AppendFormat("staBack = {0}", this.StaBack).AppendLine();
            }
            if ((object)this.StaInternal != null)
            {
                buff.AppendFormat("staInternal = {0}", this.StaInternal).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.StaAhead != null)
            {
                buff.Append("staAhead", this.StaAhead);
            }
            if ((object)this.StaBack != null)
            {
                buff.Append("staBack", this.StaBack);
            }
            if ((object)this.StaInternal != null)
            {
                buff.Append("staInternal", this.StaInternal);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }

            return buff.ToString();
        }

        public double StaAhead;

        public double? StaBack;

        public double StaInternal;

        public string Desc;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }
    }
}
#endif

