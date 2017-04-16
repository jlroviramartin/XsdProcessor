namespace XmlSchemaProcessor.Xsd
{
    /// <summary>
    /// El tipo no contiene ni elementos ni atributos.
    /// Simple types can only have content directly contained between the
    /// element’s opening and closing tags. They cannot have attributes or child elements.
    /// 
    /// A simple type’s content can be one of:
    ///  - atomic types, which have indivisible values, such as '#000' and '#AACCDD'
    ///  - list types, which have whitespace-separated lists of indivisible values, such as 'blue green red'
    ///  - union types, which have either atomic or list values, but they can be the union of other types, such as 'blue #000 red' for a set of colors
    /// </summary>
    public abstract class XsdSimpleType : XsdType
    {
        public virtual bool IsBuiltIn()
        {
            return false;
        }

        public virtual XsdSimpleType GetRootType()
        {
            return this;
        }

        public virtual XsdSimpleType GetBuiltInRootType()
        {
            return (this.IsBuiltIn() ? this : null);
        }
    }
}