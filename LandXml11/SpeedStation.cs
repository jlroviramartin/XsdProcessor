#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// A cant speed-only station.
    ///             The “station” is a required double that is internal station value.
    ///  The “speed” is an optional double that is the design speed.  This value is in kmph or mph depending upon the units.
    /// </summary>

    public class SpeedStation : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Station = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("station"));



            this.Speed = XsdConverter.Instance.Convert<double>(
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
            if ((object)this.Speed != null)
            {
                buff.AppendFormat(" speed=\"{0}\"", this.Speed);
            }


            return buff.ToString();
        }

        public double Station;

        public double Speed;


    }
}
#endif

