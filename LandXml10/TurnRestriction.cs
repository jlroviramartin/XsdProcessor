#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class TurnRestriction : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Station = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("station"));



            this.LegNumber = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("legNumber"));



            this.Type = XsdConverter.Instance.Convert<TrafficTurnRestriction?>(
                    attributes.GetSafe("type"));



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
            if ((object)this.Type != null)
            {
                buff.AppendFormat("type = {0}", this.Type).AppendLine();
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
            if ((object)this.Type != null)
            {
                buff.AppendFormat(" type=\"{0}\"", this.Type);
            }


            return buff.ToString();
        }

        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? Station;

        public int? LegNumber;

        public TrafficTurnRestriction? Type;


    }
}
#endif

