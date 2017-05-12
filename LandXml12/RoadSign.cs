#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Choice [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class RoadSign : XsdBaseReader
    {
        public RoadSign(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string MUTCDCode;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? Station;
        /// <summary>
        /// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
        /// </summary>

        public double? Offset;

        public SideofRoadType? SideofRoad;

        public RoadSignType? Type;

        public double? MountHeight;

        public double? Width;

        public double? Height;

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

            this.MUTCDCode = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("MUTCDCode"));

            this.Station = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("station"));

            this.Offset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("offset"));

            this.SideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(
                    attributes.GetSafe("sideofRoad"));

            this.Type = XsdConverter.Instance.Convert<RoadSignType?>(
                    attributes.GetSafe("type"));

            this.MountHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("mountHeight"));

            this.Width = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("width"));

            this.Height = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("height"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.MUTCDCode != null)
            {
                buff.Append("MUTCDCode", this.MUTCDCode);
            }
            if ((object)this.Station != null)
            {
                buff.Append("station", this.Station);
            }
            if ((object)this.Offset != null)
            {
                buff.Append("offset", this.Offset);
            }
            if ((object)this.SideofRoad != null)
            {
                buff.Append("sideofRoad", this.SideofRoad);
            }
            if ((object)this.Type != null)
            {
                buff.Append("type", this.Type);
            }
            if ((object)this.MountHeight != null)
            {
                buff.Append("mountHeight", this.MountHeight);
            }
            if ((object)this.Width != null)
            {
                buff.Append("width", this.Width);
            }
            if ((object)this.Height != null)
            {
                buff.Append("height", this.Height);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.MUTCDCode != null)
            {
                buff.AppendFormat("MUTCDCode = {0}", this.MUTCDCode).AppendLine();
            }
            if ((object)this.Station != null)
            {
                buff.AppendFormat("station = {0}", this.Station).AppendLine();
            }
            if ((object)this.Offset != null)
            {
                buff.AppendFormat("offset = {0}", this.Offset).AppendLine();
            }
            if ((object)this.SideofRoad != null)
            {
                buff.AppendFormat("sideofRoad = {0}", this.SideofRoad).AppendLine();
            }
            if ((object)this.Type != null)
            {
                buff.AppendFormat("type = {0}", this.Type).AppendLine();
            }
            if ((object)this.MountHeight != null)
            {
                buff.AppendFormat("mountHeight = {0}", this.MountHeight).AppendLine();
            }
            if ((object)this.Width != null)
            {
                buff.AppendFormat("width = {0}", this.Width).AppendLine();
            }
            if ((object)this.Height != null)
            {
                buff.AppendFormat("height = {0}", this.Height).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

