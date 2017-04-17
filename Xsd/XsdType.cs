namespace XmlSchemaProcessor.Xsd
{
    public abstract class XsdType : XsdObject
    {
        public string Name { get; set; }

        #region object

        public override string ToString()
        {
            return this.Name;
        }

        #endregion
    }
}