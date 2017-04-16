namespace XmlSchemaProcessor.Xsd.Facets
{
    public class XsdStringFacet : XsdFacet
    {
        public XsdStringFacet(FacetType facetType, string value)
            : base(facetType, value)
        {
        }

        public new string Value
        {
            get { return base.Value as string; }
        }
    }
}