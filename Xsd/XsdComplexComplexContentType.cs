using System.IO;

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

        #region XsdComplexType

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

        #endregion

        #region object

        public override string ToString()
        {
            using (StringWriter inner = new StringWriter())
            using (TextWriterEx writer = new TextWriterEx(inner))
            {
                if (!string.IsNullOrEmpty(this.Name))
                {
                    writer.Write(this.Name + " ");
                }
                else
                {
                    writer.Write("<unnamed> ");
                }
                writer.WriteLine(this.Derivation + " of " + this.BaseType.Name);

                if (!this.BaseType.TopLevel)
                {
                    writer.Indent();
                    writer.WriteLine(this.BaseType);
                    writer.Unindent();
                }

                if (this.Attributes.Content.Count > 0)
                {
                    writer.Indent();
                    writer.WriteLine(this.Attributes);
                    writer.Unindent();
                }

                if (this.Particle != null)
                {
                    writer.Indent();
                    writer.WriteLine(this.Particle);
                    writer.Unindent();
                }

                return inner.ToString();
            }
        }

        #endregion
    }
}