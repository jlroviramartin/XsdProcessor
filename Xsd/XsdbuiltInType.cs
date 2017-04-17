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

        public static readonly XsdBuiltInType Duration = new XsdBuiltInType(DURATION);
        public static readonly XsdBuiltInType DateTime = new XsdBuiltInType(DATETIME);
        public static readonly XsdBuiltInType Time = new XsdBuiltInType(TIME);
        public static readonly XsdBuiltInType Date = new XsdBuiltInType(DATE);
        public static readonly XsdBuiltInType String = new XsdBuiltInType(STRING);
        public static readonly XsdBuiltInType Boolean = new XsdBuiltInType(BOOLEAN);
        public static readonly XsdBuiltInType Base64Binary = new XsdBuiltInType(BASE_64_BINARY);
        public static readonly XsdBuiltInType HexBinary = new XsdBuiltInType(HEX_BINARY);
        public static readonly XsdBuiltInType Float = new XsdBuiltInType(FLOAT);
        public static readonly XsdBuiltInType Double = new XsdBuiltInType(DOUBLE);
        public static readonly XsdBuiltInType Decimal = new XsdBuiltInType(DECIMAL);
        public static readonly XsdBuiltInType AnyURI = new XsdBuiltInType(ANY_URI);
        public static readonly XsdBuiltInType QName = new XsdBuiltInType(QNAME);
        public static readonly XsdBuiltInType Notation = new XsdBuiltInType(NOTATION);

        public XsdBuiltInType()
        {
        }

        private XsdBuiltInType(string name)
        {
            this.Name = name;
            this.TopLevel = true;
        }

        public override bool IsBuiltIn()
        {
            return true;
        }

        public override XsdSimpleType GetBuiltInRootType()
        {
            return this;
        }
    }
}