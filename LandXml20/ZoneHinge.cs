#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public class ZoneHinge : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));



            this.StaEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staEnd"));



            this.HingeType = XsdConverter.Instance.Convert<ZoneHingeType>(
                    attributes.GetSafe("hingeType"));



            this.ZonePriorityRef = XsdConverter.Instance.Convert<int>(
                    attributes.GetSafe("zonePriorityRef"));



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
            if ((object)this.HingeType != null)
            {
                buff.AppendFormat("hingeType = {0}", this.HingeType).AppendLine();
            }
            if ((object)this.ZonePriorityRef != null)
            {
                buff.AppendFormat("zonePriorityRef = {0}", this.ZonePriorityRef).AppendLine();
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
            if ((object)this.HingeType != null)
            {
                buff.AppendFormat(" hingeType=\"{0}\"", this.HingeType);
            }
            if ((object)this.ZonePriorityRef != null)
            {
                buff.AppendFormat(" zonePriorityRef=\"{0}\"", this.ZonePriorityRef);
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

        public ZoneHingeType HingeType;

        public int ZonePriorityRef;


    }
}
#endif

