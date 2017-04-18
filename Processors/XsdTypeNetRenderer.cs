using System.Globalization;
using Antlr4.StringTemplate;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor.Processors
{
    /// <summary>
    /// String template renderer used to format string values.
    /// </summary>
    public class XsdTypeNetRenderer : IAttributeRenderer
    {
        public string ToString(object obj, string formatString, CultureInfo culture)
        {
            XsdType xsdType = (XsdType)obj ?? XsdBuiltInType.String;
            switch (formatString)
            {
                case "NetDocumentation":
                    return ProcessorUtils.PrepareNetDocumentation(xsdType.GetNetDocumentation());
                case "NetType":
                    return xsdType.ToNetType(false);
            }
            return xsdType.ToString();
        }
    }
}