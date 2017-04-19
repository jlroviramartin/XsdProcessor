#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public class LandXML : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Date = XsdConverter.Instance.Convert<DateTime>(
                    attributes.GetSafe("date"));



            this.Time = XsdConverter.Instance.Convert<DateTime>(
                    attributes.GetSafe("time"));



            this.Version = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("version"));



            this.Language = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("language"));



            this.ReadOnly = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("readOnly"));



            this.LandXMLId = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("LandXMLId"));



            this.Crc = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("crc"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Date != null)
            {
                buff.AppendFormat("date = {0}", this.Date).AppendLine();
            }
            if ((object)this.Time != null)
            {
                buff.AppendFormat("time = {0}", this.Time).AppendLine();
            }
            if ((object)this.Version != null)
            {
                buff.AppendFormat("version = {0}", this.Version).AppendLine();
            }
            if ((object)this.Language != null)
            {
                buff.AppendFormat("language = {0}", this.Language).AppendLine();
            }
            if ((object)this.ReadOnly != null)
            {
                buff.AppendFormat("readOnly = {0}", this.ReadOnly).AppendLine();
            }
            if ((object)this.LandXMLId != null)
            {
                buff.AppendFormat("LandXMLId = {0}", this.LandXMLId).AppendLine();
            }
            if ((object)this.Crc != null)
            {
                buff.AppendFormat("crc = {0}", this.Crc).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Date != null)
            {
                buff.AppendFormat(" date=\"{0}\"", this.Date);
            }
            if ((object)this.Time != null)
            {
                buff.AppendFormat(" time=\"{0}\"", this.Time);
            }
            if ((object)this.Version != null)
            {
                buff.AppendFormat(" version=\"{0}\"", this.Version);
            }
            if ((object)this.Language != null)
            {
                buff.AppendFormat(" language=\"{0}\"", this.Language);
            }
            if ((object)this.ReadOnly != null)
            {
                buff.AppendFormat(" readOnly=\"{0}\"", this.ReadOnly);
            }
            if ((object)this.LandXMLId != null)
            {
                buff.AppendFormat(" LandXMLId=\"{0}\"", this.LandXMLId);
            }
            if ((object)this.Crc != null)
            {
                buff.AppendFormat(" crc=\"{0}\"", this.Crc);
            }


            return buff.ToString();
        }

        public DateTime Date;

        public DateTime Time;

        public string Version;

        public string Language;

        public bool? ReadOnly;

        public int? LandXMLId;

        public int? Crc;


    }
}
#endif

