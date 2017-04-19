#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class DailyTrafficVolume : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.StaStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staStart"));



            this.StaEnd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staEnd"));



            this.ADT = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("ADT"));



            this.Year = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("year"));



            this.EscFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("escFactor"));



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
            if ((object)this.ADT != null)
            {
                buff.AppendFormat("ADT = {0}", this.ADT).AppendLine();
            }
            if ((object)this.Year != null)
            {
                buff.AppendFormat("year = {0}", this.Year).AppendLine();
            }
            if ((object)this.EscFactor != null)
            {
                buff.AppendFormat("escFactor = {0}", this.EscFactor).AppendLine();
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
            if ((object)this.ADT != null)
            {
                buff.AppendFormat(" ADT=\"{0}\"", this.ADT);
            }
            if ((object)this.Year != null)
            {
                buff.AppendFormat(" year=\"{0}\"", this.Year);
            }
            if ((object)this.EscFactor != null)
            {
                buff.AppendFormat(" escFactor=\"{0}\"", this.EscFactor);
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

        public double? ADT;

        public DateTime? Year;

        public double? EscFactor;


    }
}
#endif

