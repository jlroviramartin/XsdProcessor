using System.IO;

namespace XmlSchemaProcessor.Xsd
{
    /// <summary>
    /// El tipo puede contener atributos y elementos.
    /// </summary>
    public sealed class XsdComplexImplicitContentType : XsdComplexType
    {
        // openContent
        public XsdParticle Particle { get; set; }

        #region XsdComplexType

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
                    writer.WriteLine(this.Name);
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