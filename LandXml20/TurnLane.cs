#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Choice [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class TurnLane : XsdBaseReader
    {
        public TurnLane(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? StaStart;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? StaEnd;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? BeginFullWidthSta;

        public double? Width;

        public SideofRoadType? SideofRoad;

        public TurnLaneType? Type;

        public LaneTaperType? TaperType;

        public double? TaperTangentLength;

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

            this.Width = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("width"));

            this.SideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(
                    attributes.GetSafe("sideofRoad"));

            this.Type = XsdConverter.Instance.Convert<TurnLaneType?>(
                    attributes.GetSafe("type"));

            this.TaperType = XsdConverter.Instance.Convert<LaneTaperType?>(
                    attributes.GetSafe("taperType"));

            this.TaperTangentLength = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("taperTangentLength"));

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
            if ((object)this.Width != null)
            {
                buff.Append("width", this.Width);
            }
            if ((object)this.SideofRoad != null)
            {
                buff.Append("sideofRoad", this.SideofRoad);
            }
            if ((object)this.Type != null)
            {
                buff.Append("type", this.Type);
            }
            if ((object)this.TaperType != null)
            {
                buff.Append("taperType", this.TaperType);
            }
            if ((object)this.TaperTangentLength != null)
            {
                buff.Append("taperTangentLength", this.TaperTangentLength);
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
            if ((object)this.Width != null)
            {
                buff.AppendFormat("width = {0}", this.Width).AppendLine();
            }
            if ((object)this.SideofRoad != null)
            {
                buff.AppendFormat("sideofRoad = {0}", this.SideofRoad).AppendLine();
            }
            if ((object)this.Type != null)
            {
                buff.AppendFormat("type = {0}", this.Type).AppendLine();
            }
            if ((object)this.TaperType != null)
            {
                buff.AppendFormat("taperType = {0}", this.TaperType).AppendLine();
            }
            if ((object)this.TaperTangentLength != null)
            {
                buff.AppendFormat("taperTangentLength = {0}", this.TaperTangentLength).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

