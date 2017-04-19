#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// I've added state here as a safety net
    /// </summary>

    public class Survey : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.Date = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("date"));



            this.StartTime = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("startTime"));



            this.EndTime = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("endTime"));



            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));



            this.HorizontalAccuracy = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("horizontalAccuracy"));



            this.VerticalAccuracy = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("verticalAccuracy"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Date != null)
            {
                buff.AppendFormat("date = {0}", this.Date).AppendLine();
            }
            if ((object)this.StartTime != null)
            {
                buff.AppendFormat("startTime = {0}", this.StartTime).AppendLine();
            }
            if ((object)this.EndTime != null)
            {
                buff.AppendFormat("endTime = {0}", this.EndTime).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.HorizontalAccuracy != null)
            {
                buff.AppendFormat("horizontalAccuracy = {0}", this.HorizontalAccuracy).AppendLine();
            }
            if ((object)this.VerticalAccuracy != null)
            {
                buff.AppendFormat("verticalAccuracy = {0}", this.VerticalAccuracy).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.Date != null)
            {
                buff.AppendFormat(" date=\"{0}\"", this.Date);
            }
            if ((object)this.StartTime != null)
            {
                buff.AppendFormat(" startTime=\"{0}\"", this.StartTime);
            }
            if ((object)this.EndTime != null)
            {
                buff.AppendFormat(" endTime=\"{0}\"", this.EndTime);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.HorizontalAccuracy != null)
            {
                buff.AppendFormat(" horizontalAccuracy=\"{0}\"", this.HorizontalAccuracy);
            }
            if ((object)this.VerticalAccuracy != null)
            {
                buff.AppendFormat(" verticalAccuracy=\"{0}\"", this.VerticalAccuracy);
            }


            return buff.ToString();
        }

        public string Desc;

        public DateTime? Date;

        public DateTime? StartTime;

        public DateTime? EndTime;

        public StateType? State;

        public string HorizontalAccuracy;

        public string VerticalAccuracy;


    }
}
#endif

