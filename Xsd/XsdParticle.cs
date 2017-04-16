namespace XmlSchemaProcessor.Xsd
{
    public abstract class XsdParticle : XsdObject
    {
        public int MinOccurs { get; set; }
        public int MaxOccurs { get; set; }

        protected string PrintOccurs()
        {
            return ("[" + this.MinOccurs + ", " + ((this.MaxOccurs != int.MaxValue) ? "" + this.MaxOccurs : "*") + "]");
        }
    }
}