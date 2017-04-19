#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class Ditch : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));



            this.StaEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staEnd"));



            this.BottomWidth = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("bottomWidth"));



            this.BottomShape = XsdConverter.Instance.Convert<DitchBottomShape?>(
                    attributes.GetSafe("bottomShape"));



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
            if ((object)this.BottomWidth != null)
            {
                buff.AppendFormat("bottomWidth = {0}", this.BottomWidth).AppendLine();
            }
            if ((object)this.BottomShape != null)
            {
                buff.AppendFormat("bottomShape = {0}", this.BottomShape).AppendLine();
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
            if ((object)this.BottomWidth != null)
            {
                buff.AppendFormat(" bottomWidth=\"{0}\"", this.BottomWidth);
            }
            if ((object)this.BottomShape != null)
            {
                buff.AppendFormat(" bottomShape=\"{0}\"", this.BottomShape);
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

        public double BottomWidth;

        public DitchBottomShape? BottomShape;


    }
}
#endif

