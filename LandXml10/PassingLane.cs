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

    public class PassingLane : XsdBaseReader
    {
        public PassingLane(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? StaStart;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? StaEnd;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? BeginFullWidthSta;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? EndFullWidthSta;

        public double? Width;

        public SideofRoadType? SideofRoad;

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

            this.StaStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staStart"));

            this.StaEnd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staEnd"));

            this.BeginFullWidthSta = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("beginFullWidthSta"));

            this.EndFullWidthSta = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("endFullWidthSta"));

            this.Width = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("width"));

            this.SideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(
                    attributes.GetSafe("sideofRoad"));

            return true;
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
            if ((object)this.BeginFullWidthSta != null)
            {
                buff.Append("beginFullWidthSta", this.BeginFullWidthSta);
            }
            if ((object)this.EndFullWidthSta != null)
            {
                buff.Append("endFullWidthSta", this.EndFullWidthSta);
            }
            if ((object)this.Width != null)
            {
                buff.Append("width", this.Width);
            }
            if ((object)this.SideofRoad != null)
            {
                buff.Append("sideofRoad", this.SideofRoad);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat("staEnd = {0}", this.StaEnd).AppendLine();
            }
            if ((object)this.BeginFullWidthSta != null)
            {
                buff.AppendFormat("beginFullWidthSta = {0}", this.BeginFullWidthSta).AppendLine();
            }
            if ((object)this.EndFullWidthSta != null)
            {
                buff.AppendFormat("endFullWidthSta = {0}", this.EndFullWidthSta).AppendLine();
            }
            if ((object)this.Width != null)
            {
                buff.AppendFormat("width = {0}", this.Width).AppendLine();
            }
            if ((object)this.SideofRoad != null)
            {
                buff.AppendFormat("sideofRoad = {0}", this.SideofRoad).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

