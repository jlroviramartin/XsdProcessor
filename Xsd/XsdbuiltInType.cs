namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdBuiltInType : XsdSimpleType
    {
        public const string DURATION = "duration";
        public const string DATETIME = "dateTime";
        public const string TIME = "time";
        public const string DATE = "date";
        public const string STRING = "string";
        public const string BOOLEAN = "boolean";
        public const string BASE_64_BINARY = "base64Binary";
        public const string HEX_BINARY = "hexBinary";
        public const string FLOAT = "float";
        public const string DOUBLE = "double";
        public const string DECIMAL = "decimal";
        public const string ANY_URI = "anyURI";
        public const string QNAME = "QName";
        public const string NOTATION = "NOTATION";

        public override bool IsBuiltIn()
        {
            return true;
        }
    }
}