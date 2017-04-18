using System.Text;

namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdElement : XsdAnnotated
    {
        public string Name { get; set; }

        public bool IsAbstract { get; set; }
        public bool IsNillable { get; set; }

        public XsdType TypeDefinition { get; set; }

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            buff.Append("Element " + this.Name);
            if (this.TypeDefinition != null)
            {
                if (!string.IsNullOrEmpty(this.TypeDefinition.Name))
                {
                    buff.Append(" of type " + this.TypeDefinition.Name);
                }

                if (!this.TypeDefinition.TopLevel)
                {
                    buff.AppendLineSafe();
                    buff.AppendRegion(this.TypeDefinition);
                }
            }
            return buff.ToString();
        }

        #endregion
    }
}