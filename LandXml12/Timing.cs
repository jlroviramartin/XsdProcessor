#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Choice [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Timing : XsdBaseReader
    {
        public Timing(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Station = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("station"));

            this.LegNumber = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("legNumber"));

            this.ProtectedTurnPercent = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("protectedTurnPercent"));

            this.UnprotectedTurnPercent = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("unprotectedTurnPercent"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Station != null)
            {
                buff.AppendFormat("station = {0}", this.Station).AppendLine();
            }
            if ((object)this.LegNumber != null)
            {
                buff.AppendFormat("legNumber = {0}", this.LegNumber).AppendLine();
            }
            if ((object)this.ProtectedTurnPercent != null)
            {
                buff.AppendFormat("protectedTurnPercent = {0}", this.ProtectedTurnPercent).AppendLine();
            }
            if ((object)this.UnprotectedTurnPercent != null)
            {
                buff.AppendFormat("unprotectedTurnPercent = {0}", this.UnprotectedTurnPercent).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Station != null)
            {
                buff.Append("station", this.Station);
            }
            if ((object)this.LegNumber != null)
            {
                buff.Append("legNumber", this.LegNumber);
            }
            if ((object)this.ProtectedTurnPercent != null)
            {
                buff.Append("protectedTurnPercent", this.ProtectedTurnPercent);
            }
            if ((object)this.UnprotectedTurnPercent != null)
            {
                buff.Append("unprotectedTurnPercent", this.UnprotectedTurnPercent);
            }

            return buff.ToString();
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? Station;

        public int? LegNumber;

        public double? ProtectedTurnPercent;

        public double? UnprotectedTurnPercent;


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

