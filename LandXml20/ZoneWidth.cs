#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
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
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double StaStart;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double StaEnd;

        public double StartWidth;

        public double? EndWidth;


    }
}
#endif

