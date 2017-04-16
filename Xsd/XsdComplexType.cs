namespace XmlSchemaProcessor.Xsd
{
    /// <summary>
    /// El tipo puede contener elementos y/o atributos.
    /// Complex types can have attributes, other elements, mixture of elements and text, etc etc.
    /// 
    /// Complex types have a “content model,” which refers to how the content (the data between the element’s opening and closing tags) is arranged:
    ///  - simple content is only character data, no child elements allowed
    ///  - element-only content is only children, no data allowed
    ///  - mixed content means character data and child elements can be intermingled
    ///  - empty content means the element is empty (<foo/>) and either conveys information by just existing, or has attributes but no content.
    /// </summary>
    public abstract class XsdComplexType : XsdType
    {
        public virtual XsdType GetBaseType()
        {
            return null;
        }

        public virtual DerivationMethod GetDerivation()
        {
            return DerivationMethod.Extension;
        }

        public virtual XsdParticle GetParticle()
        {
            return null;
        }

        public XsdAttributes Attributes { get; set; }
    }
}