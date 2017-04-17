using System.Text;

namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdAttribute : XsdObject
    {
        public string Name { get; set; }
        public XsdSimpleType Type { get; set; }

        public string DefValue { get; set; }

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            buff.Append("Attribute " + this.Name);

            if ((this.Type != null) && !string.IsNullOrEmpty(this.Type.Name))
            {
                buff.Append(" of type " + this.Type.Name);
            }

            if ((this.Type != null) && !this.Type.TopLevel)
            {
                buff.AppendLineSafe();
                buff.AppendRegion(this.Type);
            }

            return buff.ToString();
        }
    }
}