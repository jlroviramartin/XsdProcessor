namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdSimpleRestrictionType : XsdSimpleType
    {
        public const string NORMALIZED_STRING = "normalizedString";
        public const string TOKEN = "token";
        public const string LANGUAGE = "language";
        public const string NAME = "Name";
        public const string NMTOKEN = "NMTOKEN";
        public const string NCNAME = "NCName";
        public const string ID = "ID";
        public const string IDREF = "IDREF";
        public const string ENTITY = "ENTITY";
        public const string INTEGER = "integer";
        public const string NON_POSITIVE_INTEGER = "nonPositiveInteger";
        public const string NEGATIVE_INTEGER = "negativeInteger";
        public const string NON_NEGATIVE_INTEGER = "nonNegativeInteger";
        public const string POSITIVE_INTEGER = "positiveInteger";
        public const string UNSIGNED_LONG = "unsignedLong";
        public const string UNSIGNED_INT = "unsignedInt";
        public const string UNSIGNED_SHORT = "unsignedShort";
        public const string UNSIGNED_BYTE = "unsignedByte";
        public const string LONG = "long";
        public const string INT = "int";
        public const string SHORT = "short";
        public const string BYTE = "byte";

        public const string IDREFS = "IDREFS";
        public const string ENTITIES = "ENTITIES";

        public XsdSimpleType BaseType { get; set; }

        public bool BuiltIn { get; set; }

        public override bool IsBuiltIn()
        {
            return this.BuiltIn;
        }

        public override XsdSimpleType GetRootType()
        {
            return this.BaseType;
        }

        public override string ToString()
        {
            return this.Name + " Restriction of " + this.BaseType.Name;
        }
    }
}