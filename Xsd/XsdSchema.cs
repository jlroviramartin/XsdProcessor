using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XmlSchemaProcessor.Xsd
{
    public class XsdSchema
    {
        public XsdSchema()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            // XsdBuiltInType

            this.AddBuiltIn(XsdBuiltInType.Duration);
            this.AddBuiltIn(XsdBuiltInType.DateTime);
            this.AddBuiltIn(XsdBuiltInType.Time);
            this.AddBuiltIn(XsdBuiltInType.Date);
            this.AddBuiltIn(XsdBuiltInType.String);
            this.AddBuiltIn(XsdBuiltInType.Boolean);
            this.AddBuiltIn(XsdBuiltInType.Base64Binary);
            this.AddBuiltIn(XsdBuiltInType.HexBinary);
            this.AddBuiltIn(XsdBuiltInType.Float);
            this.AddBuiltIn(XsdBuiltInType.Double);
            this.AddBuiltIn(XsdBuiltInType.Decimal);

            this.AddBuiltIn(XsdBuiltInType.AnyURI);
            this.AddBuiltIn(XsdBuiltInType.QName);
            this.AddBuiltIn(XsdBuiltInType.Notation);

            // XsdSimpleRestrictionType

            this.AddBuiltIn(XsdSimpleRestrictionType.NormalizedString);
            this.AddBuiltIn(XsdSimpleRestrictionType.Token);
            this.AddBuiltIn(XsdSimpleRestrictionType.Language);
            this.AddBuiltIn(XsdSimpleRestrictionType._Name);
            this.AddBuiltIn(XsdSimpleRestrictionType.NMToken);

            this.AddBuiltIn(XsdSimpleRestrictionType.NCName);
            this.AddBuiltIn(XsdSimpleRestrictionType.Id);
            this.AddBuiltIn(XsdSimpleRestrictionType.IdRef);
            this.AddBuiltIn(XsdSimpleRestrictionType.Entity);

            this.AddBuiltIn(XsdSimpleRestrictionType.Integer);

            this.AddBuiltIn(XsdSimpleRestrictionType.NonPositiveInteger);
            this.AddBuiltIn(XsdSimpleRestrictionType.NegativeInteger);

            this.AddBuiltIn(XsdSimpleRestrictionType.NonNegativeInteger);
            this.AddBuiltIn(XsdSimpleRestrictionType.PositiveInteger);

            this.AddBuiltIn(XsdSimpleRestrictionType.UnsignedLong);
            this.AddBuiltIn(XsdSimpleRestrictionType.UnsignedInt);
            this.AddBuiltIn(XsdSimpleRestrictionType.UnsignedShort);
            this.AddBuiltIn(XsdSimpleRestrictionType.UnsignedByte);

            this.AddBuiltIn(XsdSimpleRestrictionType.Long);
            this.AddBuiltIn(XsdSimpleRestrictionType.Int);
            this.AddBuiltIn(XsdSimpleRestrictionType.Short);
            this.AddBuiltIn(XsdSimpleRestrictionType.Byte);

            // XsdSimpleListType

            this.AddBuiltIn(XsdSimpleListType.IdRefs);
            this.AddBuiltIn(XsdSimpleListType.Entities);
        }

        public void Add(XsdElement element)
        {
            element.TopLevel = true;
            this.elements.Add(element.Name, element);
        }

        public void Add(XsdAttribute attribute)
        {
            attribute.TopLevel = true;
            this.attributes.Add(attribute.Name, attribute);
        }

        public void Add(XsdType type)
        {
            type.TopLevel = true;
            // http://www.w3.org/2001/XMLSchema
            // http://www.landxml.org/schema/LandXML-1.2
            this.types.Add(type.Name, type);
        }

        public IEnumerable<XsdType> Types
        {
            get { return this.types.Values; }
        }

        public XsdType GetType(string name)
        {
            return this.types.GetSafe(name);
        }

        public IEnumerable<XsdElement> Elements
        {
            get { return this.elements.Values; }
        }

        public XsdElement GetElement(string name)
        {
            return this.elements.GetSafe(name);
        }

        public IEnumerable<XsdAttribute> Attributes
        {
            get { return this.attributes.Values; }
        }

        public XsdAttribute GetAttribute(string name)
        {
            return this.attributes.GetSafe(name);
        }

        #region private

        internal XsdType FindType(XmlQualifiedName baseTypeName)
        {
            XsdType type;
            if (this.types.TryGetValue(baseTypeName.Name, out type))
            {
                return type;
            }
            return null;
        }

        internal XsdSimpleType FindSimple(XmlQualifiedName baseTypeName)
        {
            XsdType type;
            if (this.types.TryGetValue(baseTypeName.Name, out type))
            {
                if (type is XsdSimpleType)
                {
                    return (XsdSimpleType)type;
                }
                throw new Exception();
            }
            return null;
        }

        internal XsdComplexType FindComplex(XmlQualifiedName baseTypeName)
        {
            XsdType type;
            if (this.types.TryGetValue(baseTypeName.Name, out type))
            {
                if (type is XsdComplexType)
                {
                    return (XsdComplexType)type;
                }
                throw new Exception();
            }
            return null;
        }

        internal XsdElement FindElement(XmlQualifiedName baseTypeName)
        {
            XsdElement element;
            if (this.elements.TryGetValue(baseTypeName.Name, out element))
            {
                return element;
            }
            return null;
        }

        internal XsdAttribute FindAttribute(XmlQualifiedName baseTypeName)
        {
            XsdAttribute attribute;
            if (this.attributes.TryGetValue(baseTypeName.Name, out attribute))
            {
                return attribute;
            }
            return null;
        }

        private void AddBuiltIn(XsdType xsdType)
        {
            this.types.Add(xsdType.Name, xsdType);
        }

        private readonly Dictionary<string, XsdType> types = new Dictionary<string, XsdType>();
        private readonly Dictionary<string, XsdElement> elements = new Dictionary<string, XsdElement>();
        private readonly Dictionary<string, XsdAttribute> attributes = new Dictionary<string, XsdAttribute>();

        #endregion

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();
            buff.AppendLine("----- Types -----");
            foreach (XsdType type in this.types.Values)
            {
                buff.AppendLine("" + type);
            }

            buff.AppendLine("----- Elements -----");
            foreach (XsdElement element in this.elements.Values)
            {
                buff.AppendLine("" + element);
            }

            buff.AppendLine("----- Attributes -----");
            foreach (XsdAttribute attribute in this.attributes.Values)
            {
                buff.AppendLine("" + attribute);
            }

            return buff.ToString();
        }
    }
}