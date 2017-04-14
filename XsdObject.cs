using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlSchemaTest
{
    public class XsdObject
    {
        public bool TopLevel { get; set; }
    }

    #region Type (SimpleType / ComplexType)

    public abstract class XsdType : XsdObject
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }

    /// <summary>
    /// El tipo no contiene ni elementos ni atributos.
    /// </summary>
    public abstract class XsdSimpleType : XsdType
    {
    }

    public sealed class XsdbuiltInType : XsdSimpleType
    {
        public const string DURATION = "duration";
        public const string DATETIME = "dateTime";
        public const string TIME = "time";
        public const string DATE = "date";
        public const string STRING = "string";
        public const string BOOLEAN = "boolean";
        public const string BASE_64_BINARY = "base64Binary";
        public const string HEX_BINARY = "hexBinary";
        public const string FLOAT = "float";
        public const string DOUBLE = "double";
        public const string DECIMAL = "decimal";
        public const string ANY_URI = "anyURI";
        public const string QNAME = "QName";
        public const string NOTATION = "NOTATION";
    }

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

        public XsdSimpleType BaseType { get; set; }

        public override string ToString()
        {
            return this.Name + " Restriction of " + this.BaseType.Name;
        }
    }

    public sealed class XsdSimpleListType : XsdSimpleType
    {
        public const string IDREFS = "IDREFS";
        public const string ENTITIES = "ENTITIES";

        public XsdSimpleType ItemType { get; set; }

        public override string ToString()
        {
            return this.Name + " List of " + this.ItemType.Name;
        }
    }

    public sealed class XsdSimpleUnionType : XsdSimpleType
    {
        public IList<XsdSimpleType> MemberTypes { get; set; }

        public override string ToString()
        {
            return this.Name + " Union of " + this.MemberTypes.Select(x => x.Name).Aggregate(string.Empty, (a, b) => ((a != string.Empty) ? (a + " , " + b) : b));
        }
    }

    /// <summary>
    /// El tipo puede contener elementos y/o atributos.
    /// </summary>
    public abstract class XsdComplexType : XsdType
    {
        public XsdAttributes Attributes { get; set; }
    }

    /// <summary>
    /// El tipo puede contener atributos pero no elementos. Deriva de un tipo simple o de un complejo con contenido simple (XsdComplexSimpleContentType).
    /// </summary>
    public sealed class XsdComplexSimpleContentType : XsdComplexType
    {
        // -----> public XsdSimpleType BaseType { get; set; }
        public XsdType BaseType { get; set; }
        public DerivationMethod Derivation { get; set; }

        // Facets solo para Derivation = restriction

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            string indent = string.Empty;

            if (!string.IsNullOrEmpty(this.Name))
            {
                indent = StringUtils.INDENT;
                buff.Append(this.Name + " " + this.Derivation + " of " + this.BaseType.Name);
            }
            else
            {
                buff.Append("<- " + this.Derivation + " of " + this.BaseType.Name);
            }

            if (!this.BaseType.TopLevel)
            {
                buff.AppendLineSafe();
                buff.AppendRegion(this.BaseType, indent);
            }

            if (this.Attributes.Content.Count > 0)
            {
                buff.AppendLineSafe();
                buff.AppendIndent(this.Attributes, indent);
            }

            return buff.ToString();
        }
    }

    /// <summary>
    /// El tipo puede contener atributos y elementos.
    /// </summary>
    public sealed class XsdComplexImplicitContentType : XsdComplexType
    {
        // openContent
        public XsdParticle Particle { get; set; }

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            string indent = string.Empty;

            if (!string.IsNullOrEmpty(this.Name))
            {
                indent = StringUtils.INDENT;
                buff.Append(this.Name);
            }
            else
            {
            }

            if (this.Attributes.Content.Count > 0)
            {
                buff.AppendLineSafe();
                buff.AppendIndent(this.Attributes, indent);
            }

            if (this.Particle != null)
            {
                buff.AppendLineSafe();
                buff.AppendIndent(this.Particle, indent);
            }

            return buff.ToString();
        }
    }

    /// <summary>
    /// El tipo puede contener atributos y elementos. Deriva de un tipo complejo.
    /// </summary>
    public sealed class XsdComplexComplexContentType : XsdComplexType
    {
        public XsdComplexType BaseType { get; set; }
        public DerivationMethod Derivation { get; set; }

        // openContent
        public XsdParticle Particle { get; set; }

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            string indent = string.Empty;

            if (!string.IsNullOrEmpty(this.Name))
            {
                indent = StringUtils.INDENT;
                buff.Append(this.Name + " " + this.Derivation + " of " + this.BaseType.Name);
            }
            else
            {
                buff.Append("<- " + this.Derivation + " of " + this.BaseType.Name);
            }

            if (!this.BaseType.TopLevel)
            {
                buff.AppendLineSafe();
                buff.AppendRegion(this.BaseType, indent);
            }

            if (this.Attributes.Content.Count > 0)
            {
                buff.AppendLineSafe();
                buff.AppendIndent(this.Attributes, indent);
            }

            if (this.Particle != null)
            {
                buff.AppendLineSafe();
                buff.AppendIndent(this.Particle, indent);
            }

            return buff.ToString();
        }
    }

    public enum DerivationMethod
    {
        Restriction,
        Extension
    }

    #endregion Type (SimpleType / ComplexType)

    #region Particles

    public abstract class XsdParticle : XsdObject
    {
        public int MinOccurs { get; set; }
        public int MaxOccurs { get; set; }

        protected string PrintOccurs()
        {
            return ("[" + this.MinOccurs + ", " + ((this.MaxOccurs != int.MaxValue) ? "" + this.MaxOccurs : "*") + "]");
        }
    }

    public sealed class XsdParticleAny : XsdParticle
    {
    }

    public sealed class XsdParticleElement : XsdParticle
    {
        public XsdElement Element { get; set; }

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            buff.Append(this.Element.Name + " " + this.PrintOccurs());

            if (!this.Element.TopLevel)
            {
                buff.AppendLineSafe();
                buff.AppendRegion(this.Element);
            }

            return buff.ToString();
        }
    }

    public sealed class XmlParticleGroup : XsdParticle
    {
        public IList<XsdParticle> Items
        {
            get { return this.items; }
        }

        public ParticleGroupType GroupType { get; set; }

        private readonly List<XsdParticle> items = new List<XsdParticle>();

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            buff.Append(this.GroupType + " " + this.PrintOccurs());

            foreach (XsdParticle particle in this.Items)
            {
                buff.AppendLineSafe();
                buff.AppendIndent(particle);
            }

            return buff.ToString();
        }
    }

    public enum ParticleGroupType
    {
        All,
        Choice,
        Sequence
    }

    #endregion Particles

    public sealed class XsdAttributes
    {
        public IList<XsdAttribute> Content
        {
            get { return this.content; }
        }

        private readonly List<XsdAttribute> content = new List<XsdAttribute>();

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();
            int i = 0;
            foreach (XsdAttribute attribute in this.Content)
            {
                buff.AppendLineSafe();
                buff.Append(attribute);
            }
            return buff.ToString();
        }
    }

    public sealed class XsdElement : XsdObject
    {
        public string Name { get; set; }

        public bool IsAbstract { get; set; }
        public bool IsNillable { get; set; }

        public XsdType TypeDefinition { get; set; }

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            buff.Append("Element " + this.Name);

            if ((this.TypeDefinition != null) && !string.IsNullOrEmpty(this.TypeDefinition.Name))
            {
                buff.Append(" of type " + this.TypeDefinition.Name);
            }

            if (!this.TypeDefinition.TopLevel)
            {
                buff.AppendLineSafe();
                buff.AppendRegion(this.TypeDefinition);
            }

            return buff.ToString();
        }
    }

    public class XsdAttribute : XsdObject
    {
        public string Name { get; set; }
        public XsdSimpleType Type { get; set; }

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            buff.Append("Attribute " + this.Name);

            if ((this.Type != null) && !string.IsNullOrEmpty(this.Type.Name))
            {
                buff.Append(" of type " + this.Type.Name);
            }

            if ((this.Type != null) && !this.Type.TopLevel)
            {
                buff.AppendLineSafe();
                buff.AppendRegion(this.Type);
            }

            return buff.ToString();
        }
    }
}