using System.Collections.Generic;

namespace XmlSchemaProcessor.Xsd
{
    public class XsdObject
    {
        public bool TopLevel { get; set; }
    }

    public class XsdAnnotated : XsdObject
    {
        public XsdAnnotated()
        {
            this.Annotations = new List<XsdDocumentation>();
        }

        public IList<XsdDocumentation> Annotations { get; private set; }
    }
}