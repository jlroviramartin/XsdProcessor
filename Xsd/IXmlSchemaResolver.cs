using System.Xml.Schema;

namespace XmlSchemaProcessor.Xsd
{
    public interface IXmlSchemaResolver
    {
        XmlSchema Resolve(string schemaLocation);
    }
}