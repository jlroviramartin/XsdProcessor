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
            if (this.Element != null)
            {
                buff.Append(this.Element.Name + " " + this.PrintOccurs());

                if (!this.Element.TopLevel)
                {
                    buff.AppendLineSafe();
                    buff.AppendRegion(this.Element);
                }
            }
            else
            {
                buff.Append("<NO_NAME> " + this.PrintOccurs());
            }

            return buff.ToString();
        }

        #endregion
    }
}