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

    public class ZoneSlope : XsdBaseReader
    {
        public ZoneSlope(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));

            this.StaEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staEnd"));

            this.StartVertValue = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("startVertValue"));

            this.StartVertType = XsdConverter.Instance.Convert<ZoneVertType?>(
                    attributes.GetSafe("startVertType"));

            this.EndVertValue = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("endVertValue"));

            this.EndVertType = XsdConverter.Instance.Convert<ZoneVertType>(
                    attributes.GetSafe("endVertType"));

            this.ParabolicStartStation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("parabolicStartStation"));

            this.ParabolicEndStation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("parabolicEndStation"));

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
            if ((object)this.StartVertValue != null)
            {
                buff.AppendFormat("startVertValue = {0}", this.StartVertValue).AppendLine();
            }
            if ((object)this.StartVertType != null)
            {
                buff.AppendFormat("startVertType = {0}", this.StartVertType).AppendLine();
            }
            if ((object)this.EndVertValue != null)
            {
                buff.AppendFormat("endVertValue = {0}", this.EndVertValue).AppendLine();
            }
            if ((object)this.EndVertType != null)
            {
                buff.AppendFormat("endVertType = {0}", this.EndVertType).AppendLine();
            }
            if ((object)this.ParabolicStartStation != null)
            {
                buff.AppendFormat("parabolicStartStation = {0}", this.ParabolicStartStation).AppendLine();
            }
            if ((object)this.ParabolicEndStation != null)
            {
                buff.AppendFormat("parabolicEndStation = {0}", this.ParabolicEndStation).AppendLine();
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
            if ((object)this.StartVertValue != null)
            {
                buff.Append("startVertValue", this.StartVertValue);
            }
            if ((object)this.StartVertType != null)
            {
                buff.Append("startVertType", this.StartVertType);
            }
            if ((object)this.EndVertValue != null)
            {
                buff.Append("endVertValue", this.EndVertValue);
            }
            if ((object)this.EndVertType != null)
            {
                buff.Append("endVertType", this.EndVertType);
            }
            if ((object)this.ParabolicStartStation != null)
            {
                buff.Append("parabolicStartStation", this.ParabolicStartStation);
            }
            if ((object)this.ParabolicEndStation != null)
            {
                buff.Append("parabolicEndStation", this.ParabolicEndStation);
            }

            return buff.ToString();
        }

        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double StaStart;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double StaEnd;

        public double? StartVertValue;

        public ZoneVertType? StartVertType;

        public double EndVertValue;

        public ZoneVertType EndVertType;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? ParabolicStartStation;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? ParabolicEndStation;


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

