namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdSimpleListType : XsdSimpleType
    {
        public const string IDREFS = "IDREFS";
        public const string ENTITIES = "ENTITIES";

        public static readonly XsdSimpleListType IdRefs = new XsdSimpleListType(IDREFS, XsdSimpleRestrictionType.Id);
        public static readonly XsdSimpleListType Entities = new XsdSimpleListType(ENTITIES, XsdSimpleRestrictionType.Entity);

        public XsdSimpleListType()
        {
        }

        private XsdSimpleListType(string name, XsdSimpleType itemType)
        {
            this.Name = name;
            this.ItemType = itemType;
            this.BuiltIn = true;
            this.TopLevel = true;
        }

        public XsdSimpleType ItemType { get; set; }

        public bool BuiltIn { get; set; }

        public override bool IsBuiltIn()
        {
            return this.BuiltIn;
        }

        public override string ToString()
        {
            return this.Name + " List of " + this.ItemType.Name;
        }
    }
}