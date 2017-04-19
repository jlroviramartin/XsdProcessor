#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class TurnSpeed : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Station = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("station"));



            this.LegNumber = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("legNumber"));



            this.Speed = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("speed"));



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
            if ((object)this.Speed != null)
            {
                buff.AppendFormat("speed = {0}", this.Speed).AppendLine();
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
            if ((object)this.Speed != null)
            {
                buff.AppendFormat(" speed=\"{0}\"", this.Speed);
            }


            return buff.ToString();
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? Station;

        public int? LegNumber;

        public double? Speed;


    }
}
#endif

