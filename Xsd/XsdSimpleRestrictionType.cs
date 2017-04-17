using System.Collections.Generic;
using System.Linq;
using XmlSchemaProcessor.Xsd.Facets;

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

        public static XsdSimpleRestrictionType NormalizedString = new XsdSimpleRestrictionType(NORMALIZED_STRING, XsdBuiltInType.String);
        public static XsdSimpleRestrictionType Token = new XsdSimpleRestrictionType(TOKEN, NormalizedString);
        public static XsdSimpleRestrictionType Language = new XsdSimpleRestrictionType(LANGUAGE, Token);
        public static XsdSimpleRestrictionType _Name = new XsdSimpleRestrictionType(NAME, Token);
        public static XsdSimpleRestrictionType NMToken = new XsdSimpleRestrictionType(NMTOKEN, Token);

        public static XsdSimpleRestrictionType NCName = new XsdSimpleRestrictionType(NCNAME, _Name);
        public static XsdSimpleRestrictionType Id = new XsdSimpleRestrictionType(ID, NCName);
        public static XsdSimpleRestrictionType IdRef = new XsdSimpleRestrictionType(IDREF, NCName);
        public static XsdSimpleRestrictionType Entity = new XsdSimpleRestrictionType(ENTITY, NCName);

        public static XsdSimpleRestrictionType Integer = new XsdSimpleRestrictionType(INTEGER, XsdBuiltInType.Decimal);

        public static XsdSimpleRestrictionType NonPositiveInteger = new XsdSimpleRestrictionType(NON_POSITIVE_INTEGER, Integer);
        public static XsdSimpleRestrictionType NegativeInteger = new XsdSimpleRestrictionType(NEGATIVE_INTEGER, NonPositiveInteger);

        public static XsdSimpleRestrictionType NonNegativeInteger = new XsdSimpleRestrictionType(NON_NEGATIVE_INTEGER, Integer);
        public static XsdSimpleRestrictionType PositiveInteger = new XsdSimpleRestrictionType(POSITIVE_INTEGER, NonNegativeInteger);

        public static XsdSimpleRestrictionType UnsignedLong = new XsdSimpleRestrictionType(UNSIGNED_LONG, NonNegativeInteger);
        public static XsdSimpleRestrictionType UnsignedInt = new XsdSimpleRestrictionType(UNSIGNED_INT, UnsignedLong);
        public static XsdSimpleRestrictionType UnsignedShort = new XsdSimpleRestrictionType(UNSIGNED_SHORT, UnsignedInt);
        public static XsdSimpleRestrictionType UnsignedByte = new XsdSimpleRestrictionType(UNSIGNED_BYTE, UnsignedShort);

        public static XsdSimpleRestrictionType Long = new XsdSimpleRestrictionType(LONG, Integer);
        public static XsdSimpleRestrictionType Int = new XsdSimpleRestrictionType(INT, Long);
        public static XsdSimpleRestrictionType Short = new XsdSimpleRestrictionType(SHORT, Int);
        public static XsdSimpleRestrictionType Byte = new XsdSimpleRestrictionType(BYTE, Short);

        public XsdSimpleRestrictionType()
        {
            this.Facets = new List<XsdFacet>();
        }

        private XsdSimpleRestrictionType(string name, XsdSimpleType baseType)
        {
            this.Facets = new List<XsdFacet>();

            this.Name = name;
            this.BaseType = baseType;
            this.BuiltIn = true;
            this.TopLevel = true;
        }

        public XsdSimpleType BaseType { get; set; }

        public bool BuiltIn { get; set; }

        public List<XsdFacet> Facets { get; internal set; }

        public override bool IsBuiltIn()
        {
            return this.BuiltIn;
        }

        public override XsdSimpleType GetRootType()
        {
            return this.BaseType;
        }

        public override XsdSimpleType GetBuiltInRootType()
        {
            return (this.IsBuiltIn()
                ? this
                : (this.BaseType != null ?
                    this.BaseType.GetBuiltInRootType()
                    : null));
        }

        public override string ToString()
        {
            return string.Format("{0} Restrictions {{ {1} }} of {2}",
                                 this.Name,
                                 this.Facets.Select(x => x.ToString()).ToStringAsList("; "),
                                 this.BaseType.Name);
        }
    }
}