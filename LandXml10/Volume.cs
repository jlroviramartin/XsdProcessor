#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class Volume : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Station = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("station"));



            this.LegNumber = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("legNumber"));



            this.TurnPercent = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("turnPercent"));



            this.PercentTrucks = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("percentTrucks"));



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
            if ((object)this.TurnPercent != null)
            {
                buff.AppendFormat("turnPercent = {0}", this.TurnPercent).AppendLine();
            }
            if ((object)this.PercentTrucks != null)
            {
                buff.AppendFormat("percentTrucks = {0}", this.PercentTrucks).AppendLine();
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
            if ((object)this.LegNumber != null)
            {
                buff.AppendFormat(" legNumber=\"{0}\"", this.LegNumber);
            }
            if ((object)this.TurnPercent != null)
            {
                buff.AppendFormat(" turnPercent=\"{0}\"", this.TurnPercent);
            }
            if ((object)this.PercentTrucks != null)
            {
                buff.AppendFormat(" percentTrucks=\"{0}\"", this.PercentTrucks);
            }


            return buff.ToString();
        }

        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? Station;

        public int? LegNumber;

        public double? TurnPercent;

        public double? PercentTrucks;


    }
}
#endif

