using System.Globalization;
using Antlr4.StringTemplate;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor.Processors
{
    /// <summary>
    /// String template renderer used to format string values.
    /// </summary>
    public class XsdAttributeNetRenderer : IAttributeRenderer
    {
        public string ToString(object obj, string formatString, CultureInfo culture)
        {
            XsdAttribute xsdAttribute = (XsdAttribute)obj;
            XsdSimpleType xsdAttributeType = xsdAttribute.Type ?? XsdBuiltInType.String;
            switch (formatString)
            {
                case "NetDocumentation":
                    return ProcessorUtils.PrepareNetDocumentation(xsdAttributeType.GetNetDocumentation());
                case "NetType":
                    return xsdAttributeType.ToNetType(xsdAttribute.Use != AttributeUse.Required);
            }
            return xsdAttribute.ToString();
        }
    }
}