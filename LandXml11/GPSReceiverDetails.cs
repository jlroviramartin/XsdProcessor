#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Sequence [1, 1]
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class GPSReceiverDetails : XsdBaseReader
    {
        public GPSReceiverDetails(System.Xml.XmlReader reader) : base(reader)
        {
        }

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

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.Append("id", this.Id);
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

            return buff.ToString();
        }

        public string Id;

        public string Manufacturer;

        public string Model;

        public string SerialNumber;


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

            return null;
        }
    }
}
#endif

