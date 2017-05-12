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

    public class Corrections : XsdBaseReader
    {
        public Corrections(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.RefractionCoefficient = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("refractionCoefficient"));

            this.ApplyRefractionCoefficient = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("applyRefractionCoefficient"));

            this.Sphericity = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("sphericity"));

            this.PrismEccentricity = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("prismEccentricity"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.RefractionCoefficient != null)
            {
                buff.AppendFormat("refractionCoefficient = {0}", this.RefractionCoefficient).AppendLine();
            }
            if ((object)this.ApplyRefractionCoefficient != null)
            {
                buff.AppendFormat("applyRefractionCoefficient = {0}", this.ApplyRefractionCoefficient).AppendLine();
            }
            if ((object)this.Sphericity != null)
            {
                buff.AppendFormat("sphericity = {0}", this.Sphericity).AppendLine();
            }
            if ((object)this.PrismEccentricity != null)
            {
                buff.AppendFormat("prismEccentricity = {0}", this.PrismEccentricity).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.RefractionCoefficient != null)
            {
                buff.Append("refractionCoefficient", this.RefractionCoefficient);
            }
            if ((object)this.ApplyRefractionCoefficient != null)
            {
                buff.Append("applyRefractionCoefficient", this.ApplyRefractionCoefficient);
            }
            if ((object)this.Sphericity != null)
            {
                buff.Append("sphericity", this.Sphericity);
            }
            if ((object)this.PrismEccentricity != null)
            {
                buff.Append("prismEccentricity", this.PrismEccentricity);
            }

            return buff.ToString();
        }

        public double? RefractionCoefficient;

        public bool? ApplyRefractionCoefficient;

        public double? Sphericity;

        public double? PrismEccentricity;


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

