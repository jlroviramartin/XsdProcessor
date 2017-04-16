using System.Collections.Generic;
using System.Linq;
using XmlSchemaProcessor.Xsd.Facets;
using XmlSchemaTest;

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

        public XsdSimpleRestrictionType()
        {
            this.Facets = new List<XsdFacet>();
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