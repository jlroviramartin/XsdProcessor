#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class GPSAntennaDetails : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));



            this.Manufacturer = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("manufacturer"));



            this.Model = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("model"));



            this.SerialNumber = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("serialNumber"));



            this.Latitude = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("latitude"));



            this.Longitude = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("longitude"));



            this.Altitude = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("altitude"));



            this.EllipsiodnalHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("ellipsiodnalHeight"));



            this.OrthometricHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("orthometricHeight"));



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
            if ((object)this.Latitude != null)
            {
                buff.AppendFormat("latitude = {0}", this.Latitude).AppendLine();
            }
            if ((object)this.Longitude != null)
            {
                buff.AppendFormat("longitude = {0}", this.Longitude).AppendLine();
            }
            if ((object)this.Altitude != null)
            {
                buff.AppendFormat("altitude = {0}", this.Altitude).AppendLine();
            }
            if ((object)this.EllipsiodnalHeight != null)
            {
                buff.AppendFormat("ellipsiodnalHeight = {0}", this.EllipsiodnalHeight).AppendLine();
            }
            if ((object)this.OrthometricHeight != null)
            {
                buff.AppendFormat("orthometricHeight = {0}", this.OrthometricHeight).AppendLine();
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
            if ((object)this.Latitude != null)
            {
                buff.AppendFormat(" latitude=\"{0}\"", this.Latitude);
            }
            if ((object)this.Longitude != null)
            {
                buff.AppendFormat(" longitude=\"{0}\"", this.Longitude);
            }
            if ((object)this.Altitude != null)
            {
                buff.AppendFormat(" altitude=\"{0}\"", this.Altitude);
            }
            if ((object)this.EllipsiodnalHeight != null)
            {
                buff.AppendFormat(" ellipsiodnalHeight=\"{0}\"", this.EllipsiodnalHeight);
            }
            if ((object)this.OrthometricHeight != null)
            {
                buff.AppendFormat(" orthometricHeight=\"{0}\"", this.OrthometricHeight);
            }


            return buff.ToString();
        }

        public string Id;

        public string Manufacturer;

        public string Model;

        public string SerialNumber;

        public double? Latitude;

        public double? Longitude;

        public double? Altitude;

        public double? EllipsiodnalHeight;

        public double? OrthometricHeight;


    }
}
#endif

