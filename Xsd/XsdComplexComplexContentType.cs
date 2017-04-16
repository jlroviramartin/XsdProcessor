using System.Text;
using XmlSchemaTest;

namespace XmlSchemaProcessor.Xsd
{
    /// <summary>
    /// El tipo puede contener atributos y elementos. Deriva de un tipo complejo.
    /// </summary>
    public sealed class XsdComplexComplexContentType : XsdComplexType
    {
        public XsdComplexType BaseType { get; set; }
        public DerivationMethod Derivation { get; set; }

        // openContent
        public XsdParticle Particle { get; set; }

        public override XsdType GetBaseType()
        {
            return this.BaseType ?? base.GetBaseType();
        }

        public override DerivationMethod GetDerivation()
        {
            return this.Derivation;
        }

        public override XsdParticle GetParticle()
        {
            return this.Particle;
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

            if (this.Particle != null)
            {
                buff.AppendLineSafe();
                buff.AppendIndent(this.Particle, indent);
            }

            return buff.ToString();
        }
    }
}