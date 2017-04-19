#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Optional element to identify the software that was used to create the file.
    /// </summary>

    public class Application : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.Manufacturer = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("manufacturer"));



            this.Version = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("version"));



            this.ManufacturerURL = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("manufacturerURL"));



            this.TimeStamp = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("timeStamp"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Manufacturer != null)
            {
                buff.AppendFormat("manufacturer = {0}", this.Manufacturer).AppendLine();
            }
            if ((object)this.Version != null)
            {
                buff.AppendFormat("version = {0}", this.Version).AppendLine();
            }
            if ((object)this.ManufacturerURL != null)
            {
                buff.AppendFormat("manufacturerURL = {0}", this.ManufacturerURL).AppendLine();
            }
            if ((object)this.TimeStamp != null)
            {
                buff.AppendFormat("timeStamp = {0}", this.TimeStamp).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.Manufacturer != null)
            {
                buff.AppendFormat(" manufacturer=\"{0}\"", this.Manufacturer);
            }
            if ((object)this.Version != null)
            {
                buff.AppendFormat(" version=\"{0}\"", this.Version);
            }
            if ((object)this.ManufacturerURL != null)
            {
                buff.AppendFormat(" manufacturerURL=\"{0}\"", this.ManufacturerURL);
            }
            if ((object)this.TimeStamp != null)
            {
                buff.AppendFormat(" timeStamp=\"{0}\"", this.TimeStamp);
            }


            return buff.ToString();
        }

        public string Name;

        public string Desc;

        public string Manufacturer;

        public string Version;

        public string ManufacturerURL;

        public DateTime? TimeStamp;


    }
}
#endif

