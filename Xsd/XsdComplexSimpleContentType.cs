using System.Text;

namespace XmlSchemaProcessor.Xsd
{
    /// <summary>
    /// El tipo puede contener atributos pero no elementos. Deriva de un tipo simple o de un complejo con contenido simple (XsdComplexSimpleContentType).
    /// </summary>
    public sealed class XsdComplexSimpleContentType : XsdComplexType
    {
        // -----> public XsdSimpleType BaseType { get; set; }
        public XsdType BaseType { get; set; }
        public DerivationMethod Derivation { get; set; }

        // Facets solo para Derivation = restriction

        public override XsdType GetBaseType()
        {
            return this.BaseType ?? base.GetBaseType();
        }

        public override DerivationMethod GetDerivation()
        {
            return this.Derivation;
        }

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            string indent = string.Empty;

            if (!string.IsNullOrEmpty(this.Name))
            {
                indent = StringUtils.INDENT;
                buff.Append(this.Name + " ");
            }
            else
            {
                buff.Append("<- ");
            }
            buff.Append(this.Derivation + " of " + this.BaseType.Name);

            if (!this.BaseType.TopLevel)
            {
                buff.AppendLineSafe();
                buff.AppendRegion(this.BaseType, indent);
            }

            if (this.Attributes.Content.Count > 0)
            {
                buff.AppendLineSafe();
                buff.AppendIndent(this.Attributes, indent);
            }

            return buff.ToString();
        }
    }
}