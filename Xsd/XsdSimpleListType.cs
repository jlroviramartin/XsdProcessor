namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdSimpleListType : XsdSimpleType
    {
        public const string IDREFS = "IDREFS";
        public const string ENTITIES = "ENTITIES";

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