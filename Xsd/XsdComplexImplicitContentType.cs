using System.Text;
using XmlSchemaTest;

namespace XmlSchemaProcessor.Xsd
{
    /// <summary>
    /// El tipo puede contener atributos y elementos.
    /// </summary>
    public sealed class XsdComplexImplicitContentType : XsdComplexType
    {
        // openContent
        public XsdParticle Particle { get; set; }

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
                buff.Append(this.Name);
            }
            else
            {
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