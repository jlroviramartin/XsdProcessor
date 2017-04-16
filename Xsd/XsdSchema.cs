using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using XmlSchemaTest;

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

            this.AddBuiltIn(XsdBuiltInType.DURATION);
            this.AddBuiltIn(XsdBuiltInType.DATETIME);
            this.AddBuiltIn(XsdBuiltInType.TIME);
            this.AddBuiltIn(XsdBuiltInType.DATE);
            XsdBuiltInType _string = this.AddBuiltIn(XsdBuiltInType.STRING);
            this.AddBuiltIn(XsdBuiltInType.BOOLEAN);
            this.AddBuiltIn(XsdBuiltInType.BASE_64_BINARY);
            this.AddBuiltIn(XsdBuiltInType.HEX_BINARY);
            this.AddBuiltIn(XsdBuiltInType.FLOAT);
            this.AddBuiltIn(XsdBuiltInType.DOUBLE);
            XsdBuiltInType _decimal = this.AddBuiltIn(XsdBuiltInType.DECIMAL);

            this.AddBuiltIn(XsdBuiltInType.ANY_URI);
            this.AddBuiltIn(XsdBuiltInType.QNAME);
            this.AddBuiltIn(XsdBuiltInType.NOTATION);

            // XsdSimpleRestrictionType

            XsdSimpleRestrictionType normalizedString = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.NORMALIZED_STRING, _string);
            XsdSimpleRestrictionType token = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.TOKEN, normalizedString);
            this.AddDerivedBuiltIn(XsdSimpleRestrictionType.LANGUAGE, token);
            XsdSimpleRestrictionType name = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.NAME, token);
            this.AddDerivedBuiltIn(XsdSimpleRestrictionType.NMTOKEN, token);

            XsdSimpleRestrictionType ncName = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.NCNAME, name);
            XsdSimpleRestrictionType id = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.ID, ncName);
            this.AddDerivedBuiltIn(XsdSimpleRestrictionType.IDREF, ncName);
            XsdSimpleRestrictionType entity = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.ENTITY, ncName);

            XsdSimpleRestrictionType integer = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.INTEGER, _decimal);

            XsdSimpleRestrictionType nonPositiveInteger = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.NON_POSITIVE_INTEGER, integer);
            this.AddDerivedBuiltIn(XsdSimpleRestrictionType.NEGATIVE_INTEGER, nonPositiveInteger);

            XsdSimpleRestrictionType nonNegativeInteger = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.NON_NEGATIVE_INTEGER, integer);
            this.AddDerivedBuiltIn(XsdSimpleRestrictionType.POSITIVE_INTEGER, nonNegativeInteger);

            XsdSimpleRestrictionType unsignedLong = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.UNSIGNED_LONG, nonNegativeInteger);
            XsdSimpleRestrictionType unsignedInt = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.UNSIGNED_INT, unsignedLong);
            XsdSimpleRestrictionType unsignedShort = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.UNSIGNED_SHORT, unsignedInt);
            this.AddDerivedBuiltIn(XsdSimpleRestrictionType.UNSIGNED_BYTE, unsignedShort);

            XsdSimpleRestrictionType _long = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.LONG, integer);
            XsdSimpleRestrictionType _int = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.INT, _long);
            XsdSimpleRestrictionType _short = this.AddDerivedBuiltIn(XsdSimpleRestrictionType.SHORT, _int);
            this.AddDerivedBuiltIn(XsdSimpleRestrictionType.BYTE, _short);

            // XsdSimpleListType

            this.AddListBuiltIn(XsdSimpleListType.IDREFS, id);
            this.AddListBuiltIn(XsdSimpleListType.ENTITIES, entity);
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

        private XsdBuiltInType AddBuiltIn(string name)
        {
            XsdBuiltInType type = new XsdBuiltInType() { Name = name };
            type.TopLevel = true;
            this.types.Add(type.Name, type);
            return type;
        }

        private XsdSimpleRestrictionType AddDerivedBuiltIn(string name, XsdSimpleType baseType)
        {
            XsdSimpleRestrictionType type = new XsdSimpleRestrictionType() { Name = name, BaseType = baseType };
            type.TopLevel = true;
            type.BuiltIn = true;
            this.types.Add(type.Name, type);
            return type;
        }

        private XsdSimpleListType AddListBuiltIn(string name, XsdSimpleType itemType)
        {
            XsdSimpleListType type = new XsdSimpleListType() { Name = name, ItemType = itemType };
            type.TopLevel = true;
            type.BuiltIn = true;
            this.types.Add(type.Name, type);
            return type;
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