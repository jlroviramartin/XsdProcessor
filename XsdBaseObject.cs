using System.Collections.Generic;

namespace XmlSchemaProcessor
{
    public class XsdBaseObject
    {
        public virtual bool Read(IDictionary<string, string> attributes, string text)
        {
            return true;
        }
    }
}
