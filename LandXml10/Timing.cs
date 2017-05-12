#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Choice [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Timing : XsdBaseReader
    {
        public Timing(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? Station;

        public int? LegNumber;

        public double? ProtectedTurnPercent;

        public double? UnprotectedTurnPercent;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

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

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

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

        #endregion
    }
}
#endif

