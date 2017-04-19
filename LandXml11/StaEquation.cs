#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// The "staInternal" value identifies the location of the station equation. It is the station value with no equations applied (staStart + dist). "staAhead" is the new station value and "staIncrement" indicates whether or not the station values increase or decrease.
    /// </summary>

    public class StaEquation : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.StaAhead = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staAhead"));



            this.StaBack = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staBack"));



            this.StaInternal = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staInternal"));



            this.StaIncrement = XsdConverter.Instance.Convert<StationIncrementDirectionType?>(
                    attributes.GetSafe("staIncrement"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.StaAhead != null)
            {
                buff.AppendFormat("staAhead = {0}", this.StaAhead).AppendLine();
            }
            if ((object)this.StaBack != null)
            {
                buff.AppendFormat("staBack = {0}", this.StaBack).AppendLine();
            }
            if ((object)this.StaInternal != null)
            {
                buff.AppendFormat("staInternal = {0}", this.StaInternal).AppendLine();
            }
            if ((object)this.StaIncrement != null)
            {
                buff.AppendFormat("staIncrement = {0}", this.StaIncrement).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.StaAhead != null)
            {
                buff.AppendFormat(" staAhead=\"{0}\"", this.StaAhead);
            }
            if ((object)this.StaBack != null)
            {
                buff.AppendFormat(" staBack=\"{0}\"", this.StaBack);
            }
            if ((object)this.StaInternal != null)
            {
                buff.AppendFormat(" staInternal=\"{0}\"", this.StaInternal);
            }
            if ((object)this.StaIncrement != null)
            {
                buff.AppendFormat(" staIncrement=\"{0}\"", this.StaIncrement);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }


            return buff.ToString();
        }

        public double StaAhead;

        public double? StaBack;

        public double StaInternal;

        public StationIncrementDirectionType? StaIncrement;

        public string Desc;


    }
}
#endif

