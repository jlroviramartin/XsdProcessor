using System.Collections;
using System.Text;

namespace XmlSchemaProcessor.Common
{
    /// <summary>
    /// This class build a string using name-value pairs, similar to the attributes of an Xml element.
    /// </summary>
    public class AttributesBuilder
    {
        public AttributesBuilder()
        {
        }

        public AttributesBuilder(string str)
        {
            this.buff.Append(str);
        }

        public AttributesBuilder Append(string name, object value)
        {
            if (this.buff.Length > 0)
            {
                this.buff.Append(" ");
            }
            if (value is ICollection)
            {
                StringBuilder buff = new StringBuilder();
                foreach (object v in (ICollection)value)
                {
                    if (buff.Length > 0)
                    {
                        buff.Append(" ");
                    }
                    buff.Append(v);
                }
                this.buff.Append(name)
                    .Append("=\"")
                    .Append(buff)
                    .Append("\"");
            }
            else
            {
                this.buff.Append(name)
                    .Append("=\"")
                    .Append(value)
                    .Append("\"");
            }
            return this;
        }

        #region private

        private readonly StringBuilder buff = new StringBuilder();

        #endregion

        #region object

        public override string ToString()
        {
            return this.buff.ToString();
        }

        #endregion
    }
}