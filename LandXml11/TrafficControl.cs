#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class TrafficControl : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Station = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("station"));



            this.SignalPeriod = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("signalPeriod"));



            this.ControlPosition = XsdConverter.Instance.Convert<TrafficControlPosition?>(
                    attributes.GetSafe("controlPosition"));



            this.ControlType = XsdConverter.Instance.Convert<TrafficControlType?>(
                    attributes.GetSafe("controlType"));



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
            if ((object)this.SignalPeriod != null)
            {
                buff.AppendFormat("signalPeriod = {0}", this.SignalPeriod).AppendLine();
            }
            if ((object)this.ControlPosition != null)
            {
                buff.AppendFormat("controlPosition = {0}", this.ControlPosition).AppendLine();
            }
            if ((object)this.ControlType != null)
            {
                buff.AppendFormat("controlType = {0}", this.ControlType).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Station != null)
            {
                buff.AppendFormat(" station=\"{0}\"", this.Station);
            }
            if ((object)this.SignalPeriod != null)
            {
                buff.AppendFormat(" signalPeriod=\"{0}\"", this.SignalPeriod);
            }
            if ((object)this.ControlPosition != null)
            {
                buff.AppendFormat(" controlPosition=\"{0}\"", this.ControlPosition);
            }
            if ((object)this.ControlType != null)
            {
                buff.AppendFormat(" controlType=\"{0}\"", this.ControlType);
            }


            return buff.ToString();
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? Station;

        public double? SignalPeriod;

        public TrafficControlPosition? ControlPosition;

        public TrafficControlType? ControlType;


    }
}
#endif
