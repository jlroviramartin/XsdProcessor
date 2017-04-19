#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class LaserDetails : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));



            this.LaserVertOffset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("laserVertOffset"));



            this.Manufacturer = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("manufacturer"));



            this.Model = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("model"));



            this.SerialNumber = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("serialNumber"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Id != null)
            {
                buff.AppendFormat("id = {0}", this.Id).AppendLine();
            }
            if ((object)this.LaserVertOffset != null)
            {
                buff.AppendFormat("laserVertOffset = {0}", this.LaserVertOffset).AppendLine();
            }
            if ((object)this.Manufacturer != null)
            {
                buff.AppendFormat("manufacturer = {0}", this.Manufacturer).AppendLine();
            }
            if ((object)this.Model != null)
            {
                buff.AppendFormat("model = {0}", this.Model).AppendLine();
            }
            if ((object)this.SerialNumber != null)
            {
                buff.AppendFormat("serialNumber = {0}", this.SerialNumber).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.AppendFormat(" id=\"{0}\"", this.Id);
            }
            if ((object)this.LaserVertOffset != null)
            {
                buff.AppendFormat(" laserVertOffset=\"{0}\"", this.LaserVertOffset);
            }
            if ((object)this.Manufacturer != null)
            {
                buff.AppendFormat(" manufacturer=\"{0}\"", this.Manufacturer);
            }
            if ((object)this.Model != null)
            {
                buff.AppendFormat(" model=\"{0}\"", this.Model);
            }
            if ((object)this.SerialNumber != null)
            {
                buff.AppendFormat(" serialNumber=\"{0}\"", this.SerialNumber);
            }


            return buff.ToString();
        }

        public string Id;

        public double? LaserVertOffset;

        public string Manufacturer;

        public string Model;

        public string SerialNumber;


    }
}
#endif

