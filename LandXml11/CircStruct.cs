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
    ///     Feature [0, *]
    /// </summary>

    public class CircStruct : XsdBaseReader
    {
        public CircStruct(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Diameter = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("diameter"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.InletCase = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("inletCase"));

            this.LossCoeff = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("lossCoeff"));

            this.Material = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("material"));

            this.Thickness = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("thickness"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Diameter != null)
            {
                buff.AppendFormat("diameter = {0}", this.Diameter).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.InletCase != null)
            {
                buff.AppendFormat("inletCase = {0}", this.InletCase).AppendLine();
            }
            if ((object)this.LossCoeff != null)
            {
                buff.AppendFormat("lossCoeff = {0}", this.LossCoeff).AppendLine();
            }
            if ((object)this.Material != null)
            {
                buff.AppendFormat("material = {0}", this.Material).AppendLine();
            }
            if ((object)this.Thickness != null)
            {
                buff.AppendFormat("thickness = {0}", this.Thickness).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Diameter != null)
            {
                buff.Append("diameter", this.Diameter);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.InletCase != null)
            {
                buff.Append("inletCase", this.InletCase);
            }
            if ((object)this.LossCoeff != null)
            {
                buff.Append("lossCoeff", this.LossCoeff);
            }
            if ((object)this.Material != null)
            {
                buff.Append("material", this.Material);
            }
            if ((object)this.Thickness != null)
            {
                buff.Append("thickness", this.Thickness);
            }

            return buff.ToString();
        }

        public double Diameter;

        public string Desc;

        public string InletCase;

        public double? LossCoeff;

        public string Material;

        public double? Thickness;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }
    }
}
#endif

