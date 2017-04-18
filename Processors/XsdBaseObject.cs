using System.Collections.Generic;

namespace XmlSchemaProcessor.Processors
{
    public class XsdBaseObject
    {
        public virtual bool Read(IDictionary<string, string> attributes, string text)
        {
            return true;
        }

        public override string ToString()
        {
            return "Type = " + base.ToString();
        }
    }
}
