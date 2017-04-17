using System.Text;

namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdParticleElement : XsdParticle
    {
        public XsdElement Element { get; set; }

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            buff.Append(this.Element.Name + " " + this.PrintOccurs());

            if (!this.Element.TopLevel)
            {
                buff.AppendLineSafe();
                buff.AppendRegion(this.Element);
            }

            return buff.ToString();
        }

        #endregion
    }
}