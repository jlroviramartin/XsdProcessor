#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public class InstrumentDetails : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));



            this.EdmAccuracyConstant = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("edmAccuracyConstant"));



            this.EdmAccuracyppm = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("edmAccuracyppm"));



            this.EdmVertOffset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("edmVertOffset"));



            this.HorizAnglePrecision = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("horizAnglePrecision"));



            this.Manufacturer = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("manufacturer"));



            this.Model = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("model"));



            this.SerialNumber = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("serialNumber"));



            this.ZenithAnglePrecision = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("zenithAnglePrecision"));



            this.CarrierWavelength = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("carrierWavelength"));



            this.RefractiveIndex = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("refractiveIndex"));



            this.HorizCollimation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("horizCollimation"));



            this.VertCollimation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("vertCollimation"));



            this.StadiaFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("stadiaFactor"));



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
            if ((object)this.EdmAccuracyConstant != null)
            {
                buff.AppendFormat("edmAccuracyConstant = {0}", this.EdmAccuracyConstant).AppendLine();
            }
            if ((object)this.EdmAccuracyppm != null)
            {
                buff.AppendFormat("edmAccuracyppm = {0}", this.EdmAccuracyppm).AppendLine();
            }
            if ((object)this.EdmVertOffset != null)
            {
                buff.AppendFormat("edmVertOffset = {0}", this.EdmVertOffset).AppendLine();
            }
            if ((object)this.HorizAnglePrecision != null)
            {
                buff.AppendFormat("horizAnglePrecision = {0}", this.HorizAnglePrecision).AppendLine();
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
            if ((object)this.ZenithAnglePrecision != null)
            {
                buff.AppendFormat("zenithAnglePrecision = {0}", this.ZenithAnglePrecision).AppendLine();
            }
            if ((object)this.CarrierWavelength != null)
            {
                buff.AppendFormat("carrierWavelength = {0}", this.CarrierWavelength).AppendLine();
            }
            if ((object)this.RefractiveIndex != null)
            {
                buff.AppendFormat("refractiveIndex = {0}", this.RefractiveIndex).AppendLine();
            }
            if ((object)this.HorizCollimation != null)
            {
                buff.AppendFormat("horizCollimation = {0}", this.HorizCollimation).AppendLine();
            }
            if ((object)this.VertCollimation != null)
            {
                buff.AppendFormat("vertCollimation = {0}", this.VertCollimation).AppendLine();
            }
            if ((object)this.StadiaFactor != null)
            {
                buff.AppendFormat("stadiaFactor = {0}", this.StadiaFactor).AppendLine();
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
            if ((object)this.EdmAccuracyConstant != null)
            {
                buff.AppendFormat(" edmAccuracyConstant=\"{0}\"", this.EdmAccuracyConstant);
            }
            if ((object)this.EdmAccuracyppm != null)
            {
                buff.AppendFormat(" edmAccuracyppm=\"{0}\"", this.EdmAccuracyppm);
            }
            if ((object)this.EdmVertOffset != null)
            {
                buff.AppendFormat(" edmVertOffset=\"{0}\"", this.EdmVertOffset);
            }
            if ((object)this.HorizAnglePrecision != null)
            {
                buff.AppendFormat(" horizAnglePrecision=\"{0}\"", this.HorizAnglePrecision);
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
            if ((object)this.ZenithAnglePrecision != null)
            {
                buff.AppendFormat(" zenithAnglePrecision=\"{0}\"", this.ZenithAnglePrecision);
            }
            if ((object)this.CarrierWavelength != null)
            {
                buff.AppendFormat(" carrierWavelength=\"{0}\"", this.CarrierWavelength);
            }
            if ((object)this.RefractiveIndex != null)
            {
                buff.AppendFormat(" refractiveIndex=\"{0}\"", this.RefractiveIndex);
            }
            if ((object)this.HorizCollimation != null)
            {
                buff.AppendFormat(" horizCollimation=\"{0}\"", this.HorizCollimation);
            }
            if ((object)this.VertCollimation != null)
            {
                buff.AppendFormat(" vertCollimation=\"{0}\"", this.VertCollimation);
            }
            if ((object)this.StadiaFactor != null)
            {
                buff.AppendFormat(" stadiaFactor=\"{0}\"", this.StadiaFactor);
            }


            return buff.ToString();
        }

        public string Id;

        public double? EdmAccuracyConstant;

        public double? EdmAccuracyppm;

        public double? EdmVertOffset;

        public double? HorizAnglePrecision;

        public string Manufacturer;

        public string Model;

        public string SerialNumber;

        public double? ZenithAnglePrecision;

        public double? CarrierWavelength;

        public double? RefractiveIndex;

        public double? HorizCollimation;

        public double? VertCollimation;

        public double? StadiaFactor;


    }
}
#endif

