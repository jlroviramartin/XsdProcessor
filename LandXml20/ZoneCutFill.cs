#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public class ZoneCutFill : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));



            this.StaEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staEnd"));



            this.CutSlope = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("cutSlope"));



            this.FillSlope = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("fillSlope"));



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
            if ((object)this.CutSlope != null)
            {
                buff.AppendFormat("cutSlope = {0}", this.CutSlope).AppendLine();
            }
            if ((object)this.FillSlope != null)
            {
                buff.AppendFormat("fillSlope = {0}", this.FillSlope).AppendLine();
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
            if ((object)this.CutSlope != null)
            {
                buff.AppendFormat(" cutSlope=\"{0}\"", this.CutSlope);
            }
            if ((object)this.FillSlope != null)
            {
                buff.AppendFormat(" fillSlope=\"{0}\"", this.FillSlope);
            }


            return buff.ToString();
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double StaStart;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double StaEnd;
        /// <summary>
        /// This item is the cross slope, the slope of the traveled way as measure perpendicular to the horizontal alignment, negative when the shoulder has a lower elevation than the centerline. The unit of measure for this item is PERCENT %.
        /// </summary>

        public double? CutSlope;
        /// <summary>
        /// This item is the cross slope, the slope of the traveled way as measure perpendicular to the horizontal alignment, negative when the shoulder has a lower elevation than the centerline. The unit of measure for this item is PERCENT %.
        /// </summary>

        public double? FillSlope;


    }
}
#endif

