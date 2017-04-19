#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class PassingLane : XsdBaseObject
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
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? EndFullWidthSta;

        public double? Width;

        public SideofRoadType? SideofRoad;


    }
}
#endif

