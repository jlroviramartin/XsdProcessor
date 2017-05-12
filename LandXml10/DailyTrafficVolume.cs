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
    /// Choice [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class DailyTrafficVolume : XsdBaseReader
    {
        public DailyTrafficVolume(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.StaStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staStart"));

            this.StaEnd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staEnd"));

            this.ADT = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("ADT"));

            this.Year = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("year"));

            this.EscFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("escFactor"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat("staEnd = {0}", this.StaEnd).AppendLine();
            }
            if ((object)this.ADT != null)
            {
                buff.AppendFormat("ADT = {0}", this.ADT).AppendLine();
            }
            if ((object)this.Year != null)
            {
                buff.AppendFormat("year = {0}", this.Year).AppendLine();
            }
            if ((object)this.EscFactor != null)
            {
                buff.AppendFormat("escFactor = {0}", this.EscFactor).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.StaEnd != null)
            {
                buff.Append("staEnd", this.StaEnd);
            }
            if ((object)this.ADT != null)
            {
                buff.Append("ADT", this.ADT);
            }
            if ((object)this.Year != null)
            {
                buff.Append("year", this.Year);
            }
            if ((object)this.EscFactor != null)
            {
                buff.Append("escFactor", this.EscFactor);
            }

            return buff.ToString();
        }

        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? StaStart;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? StaEnd;

        public double? ADT;

        public DateTime? Year;

        public double? EscFactor;


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

