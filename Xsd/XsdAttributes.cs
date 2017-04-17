using System.Collections.Generic;
using System.Text;

namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdAttributes
    {
        public IList<XsdAttribute> Content
        {
            get { return this.content; }
        }

        private readonly List<XsdAttribute> content = new List<XsdAttribute>();

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();
            int i = 0;
            foreach (XsdAttribute attribute in this.Content)
            {
                buff.AppendLineSafe();
                buff.Append(attribute);
            }
            return buff.ToString();
        }
    }
}