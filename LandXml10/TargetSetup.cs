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
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class TargetSetup : XsdBaseReader
    {
        public TargetSetup(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));

            this.TargetHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("targetHeight"));

            this.EdmTargetVertOffset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("edmTargetVertOffset"));

            this.PrismConstant = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("prismConstant"));

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
            if ((object)this.TargetHeight != null)
            {
                buff.AppendFormat("targetHeight = {0}", this.TargetHeight).AppendLine();
            }
            if ((object)this.EdmTargetVertOffset != null)
            {
                buff.AppendFormat("edmTargetVertOffset = {0}", this.EdmTargetVertOffset).AppendLine();
            }
            if ((object)this.PrismConstant != null)
            {
                buff.AppendFormat("prismConstant = {0}", this.PrismConstant).AppendLine();
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
            if ((object)this.TargetHeight != null)
            {
                buff.Append("targetHeight", this.TargetHeight);
            }
            if ((object)this.EdmTargetVertOffset != null)
            {
                buff.Append("edmTargetVertOffset", this.EdmTargetVertOffset);
            }
            if ((object)this.PrismConstant != null)
            {
                buff.Append("prismConstant", this.PrismConstant);
            }

            return buff.ToString();
        }

        public string Id;

        public double? TargetHeight;

        public double? EdmTargetVertOffset;

        public double? PrismConstant;


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

