#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class ZoneWidth : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));



            this.StaEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staEnd"));



            this.StartWidth = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("startWidth"));



            this.EndWidth = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("endWidth"));



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
            if ((object)this.StartWidth != null)
            {
                buff.AppendFormat("startWidth = {0}", this.StartWidth).AppendLine();
            }
            if ((object)this.EndWidth != null)
            {
                buff.AppendFormat("endWidth = {0}", this.EndWidth).AppendLine();
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
            if ((object)this.StartWidth != null)
            {
                buff.AppendFormat(" startWidth=\"{0}\"", this.StartWidth);
            }
            if ((object)this.EndWidth != null)
            {
                buff.AppendFormat(" endWidth=\"{0}\"", this.EndWidth);
            }


            return buff.ToString();
        }

        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double StaStart;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double StaEnd;

        public double StartWidth;

        public double? EndWidth;


    }
}
#endif

