#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class WideningLane : XsdBaseObject
    {
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



            this.Offset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("offset"));



            this.Widening = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("widening"));



            this.Width = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("width"));



            this.SideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(
                    attributes.GetSafe("sideofRoad"));



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
            if ((object)this.BeginFullWidthSta != null)
            {
                buff.AppendFormat("beginFullWidthSta = {0}", this.BeginFullWidthSta).AppendLine();
            }
            if ((object)this.EndFullWidthSta != null)
            {
                buff.AppendFormat("endFullWidthSta = {0}", this.EndFullWidthSta).AppendLine();
            }
            if ((object)this.Offset != null)
            {
                buff.AppendFormat("offset = {0}", this.Offset).AppendLine();
            }
            if ((object)this.Widening != null)
            {
                buff.AppendFormat("widening = {0}", this.Widening).AppendLine();
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

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.StaStart != null)
            {
                buff.AppendFormat(" staStart=\"{0}\"", this.StaStart);
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat(" staEnd=\"{0}\"", this.StaEnd);
            }
            if ((object)this.BeginFullWidthSta != null)
            {
                buff.AppendFormat(" beginFullWidthSta=\"{0}\"", this.BeginFullWidthSta);
            }
            if ((object)this.EndFullWidthSta != null)
            {
                buff.AppendFormat(" endFullWidthSta=\"{0}\"", this.EndFullWidthSta);
            }
            if ((object)this.Offset != null)
            {
                buff.AppendFormat(" offset=\"{0}\"", this.Offset);
            }
            if ((object)this.Widening != null)
            {
                buff.AppendFormat(" widening=\"{0}\"", this.Widening);
            }
            if ((object)this.Width != null)
            {
                buff.AppendFormat(" width=\"{0}\"", this.Width);
            }
            if ((object)this.SideofRoad != null)
            {
                buff.AppendFormat(" sideofRoad=\"{0}\"", this.SideofRoad);
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
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? BeginFullWidthSta;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? EndFullWidthSta;
        /// <summary>
        /// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
        /// </summary>

        public double? Offset;

        public double? Widening;

        public double? Width;

        public SideofRoadType? SideofRoad;


    }
}
#endif
