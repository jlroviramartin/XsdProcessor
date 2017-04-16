namespace XmlSchemaProcessor.Xsd.Facets
{
    public class XsdIntFacet : XsdFacet
    {
        public XsdIntFacet(FacetType facetType, string value)
            : this(facetType, int.Parse(value))
        {
        }

        public XsdIntFacet(FacetType facetType, int value)
            : base(facetType, value)
        {
        }

        public new int Value
        {
            get { return (int)base.Value; }
        }
    }
}