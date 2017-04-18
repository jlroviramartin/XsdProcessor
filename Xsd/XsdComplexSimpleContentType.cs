using System.IO;

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

        #region XsdComplexType

        public override XsdType GetBaseType()
        {
            return this.BaseType ?? base.GetBaseType();
        }

        public override DerivationMethod GetDerivation()
        {
            return this.Derivation;
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

                return inner.ToString();
            }
        }

        #endregion
    }
}