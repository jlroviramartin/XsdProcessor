#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Sequence [1, 1]
    ///     Corrections [1, 1]
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class InstrumentDetails : XsdBaseReader
    {
        public InstrumentDetails(System.Xml.XmlReader reader) : base(reader)
        {
        }

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

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.Append("id", this.Id);
            }
            if ((object)this.EdmAccuracyConstant != null)
            {
                buff.Append("edmAccuracyConstant", this.EdmAccuracyConstant);
            }
            if ((object)this.EdmAccuracyppm != null)
            {
                buff.Append("edmAccuracyppm", this.EdmAccuracyppm);
            }
            if ((object)this.EdmVertOffset != null)
            {
                buff.Append("edmVertOffset", this.EdmVertOffset);
            }
            if ((object)this.HorizAnglePrecision != null)
            {
                buff.Append("horizAnglePrecision", this.HorizAnglePrecision);
            }
            if ((object)this.Manufacturer != null)
            {
                buff.Append("manufacturer", this.Manufacturer);
            }
            if ((object)this.Model != null)
            {
                buff.Append("model", this.Model);
            }
            if ((object)this.SerialNumber != null)
            {
                buff.Append("serialNumber", this.SerialNumber);
            }
            if ((object)this.ZenithAnglePrecision != null)
            {
                buff.Append("zenithAnglePrecision", this.ZenithAnglePrecision);
            }
            if ((object)this.CarrierWavelength != null)
            {
                buff.Append("carrierWavelength", this.CarrierWavelength);
            }
            if ((object)this.RefractiveIndex != null)
            {
                buff.Append("refractiveIndex", this.RefractiveIndex);
            }
            if ((object)this.HorizCollimation != null)
            {
                buff.Append("horizCollimation", this.HorizCollimation);
            }
            if ((object)this.VertCollimation != null)
            {
                buff.Append("vertCollimation", this.VertCollimation);
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


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("FieldNote"))
            {
                return Tuple.Create("FieldNote", this.NewReader<FieldNote>());
            }
            if (name.EqualsIgnoreCase("Corrections"))
            {
                return Tuple.Create("Corrections", this.NewReader<Corrections>());
            }

            return null;
        }
    }
}
#endif

