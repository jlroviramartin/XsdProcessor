using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor.Processors
{
    public interface IPropertyMap
    {
        string Map(XsdComplexType xsdComplexType, string typeName, string attributeName);
    }

    public sealed class IdentityPropertyMap : IPropertyMap
    {
        public static readonly IPropertyMap Instance = new IdentityPropertyMap();

        public string Map(XsdComplexType xsdComplexType, string typeName, string attributeName)
        {
            return attributeName;
        }

        private IdentityPropertyMap()
        {
        }
    }
}