using System;

namespace XmlSchemaProcessor.Xsd.Facets
{
    public class XsdNumericFacet : XsdFacet
    {
        public XsdNumericFacet(FacetType facetType, string value)
            : this(facetType, (IConvertible)value)
        {
        }

        public XsdNumericFacet(FacetType facetType, IConvertible value)
            : base(facetType, value)
        {
        }

        public new IConvertible Value
        {
            get { return base.Value as IConvertible; }
        }
    }
}