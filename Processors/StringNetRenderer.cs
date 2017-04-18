using System.Globalization;
using Antlr4.StringTemplate;

namespace XmlSchemaProcessor.Processors
{
    /// <summary>
    /// String template renderer used to format string values.
    /// </summary>
    public class StringNetRenderer : IAttributeRenderer
    {
        public string ToString(object obj, string formatString, CultureInfo culture)
        {
            string s = (string)obj;
            switch (formatString)
            {
                case "FirstUpper":
                    return s.FirstUpper();
                case "FirstLower":
                    return s.FirstLower();
                case "FieldName":
                    return s.ToFieldName();
                case "MethodName":
                    return s.ToMethodName();
                case "EnumValueName":
                    return s.ToEnumValueName();
                case "TypeName":
                    return s.ToTypeName();
                case "NetDocumentation":
                    return ProcessorUtils.PrepareNetDocumentation(s);
            }
            return (string)obj;
        }
    }
}