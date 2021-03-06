//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime: <..>
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using XmlSchemaProcessor.Common;

namespace XmlSchemaProcessor.LandXml11
{

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

        public string Id;

        public double? TargetHeight;

        public double? EdmTargetVertOffset;

        public double? PrismConstant;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                this.SetCurrent("Feature", this.NewReader<Feature>());
                return true;
            }
            if (name.EqualsIgnoreCase("FieldNote"))
            {
                this.SetCurrent("FieldNote", this.NewReader<FieldNote>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

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

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

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

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

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

        #endregion
    }
}
#endif
