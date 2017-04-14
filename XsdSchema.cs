using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XmlSchemaTest
{
    public class XsdSchema
    {
        public XsdSchema()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.AddBuiltIn("duration");
            this.AddBuiltIn("dateTime");
            this.AddBuiltIn("time");
            this.AddBuiltIn("date");
            XsdbuiltInType _string = this.AddBuiltIn("string");
            this.AddBuiltIn("boolean");
            this.AddBuiltIn("base64Binary");
            this.AddBuiltIn("hexBinary");
            this.AddBuiltIn("float");
            this.AddBuiltIn("double");
            XsdbuiltInType _decimal = this.AddBuiltIn("decimal");

            this.AddBuiltIn("anyURI");
            this.AddBuiltIn("QName");
            this.AddBuiltIn("NOTATION");

            XsdSimpleRestrictionType normalizedString = this.AddDerivedBuiltIn("normalizedString", _string);
            XsdSimpleRestrictionType token = this.AddDerivedBuiltIn("token", normalizedString);
            this.AddDerivedBuiltIn("language", token);
            XsdSimpleRestrictionType name = this.AddDerivedBuiltIn("Name", token);
            this.AddDerivedBuiltIn("NMTOKEN", token);

            XsdSimpleRestrictionType ncName = this.AddDerivedBuiltIn("NCName", name);
            XsdSimpleRestrictionType id = this.AddDerivedBuiltIn("ID", ncName);
            this.AddDerivedBuiltIn("IDREF", ncName);
            XsdSimpleRestrictionType entity = this.AddDerivedBuiltIn("ENTITY", ncName);

            XsdSimpleRestrictionType integer = this.AddDerivedBuiltIn("integer", _decimal);

            XsdSimpleRestrictionType nonPositiveInteger = this.AddDerivedBuiltIn("nonPositiveInteger", integer);
            this.AddDerivedBuiltIn("negativeInteger", nonPositiveInteger);

            XsdSimpleRestrictionType nonNegativeInteger = this.AddDerivedBuiltIn("nonNegativeInteger", integer);
            this.AddDerivedBuiltIn("positiveInteger", nonNegativeInteger);

            XsdSimpleRestrictionType unsignedLong = this.AddDerivedBuiltIn("unsignedLong", nonNegativeInteger);
            XsdSimpleRestrictionType unsignedInt = this.AddDerivedBuiltIn("unsignedInt", unsignedLong);
            XsdSimpleRestrictionType unsignedShort = this.AddDerivedBuiltIn("unsignedShort", unsignedInt);
            this.AddDerivedBuiltIn("unsignedByte", unsignedShort);

            XsdSimpleRestrictionType _long = this.AddDerivedBuiltIn("long", integer);
            XsdSimpleRestrictionType _int = this.AddDerivedBuiltIn("int", _long);
            XsdSimpleRestrictionType _short = this.AddDerivedBuiltIn("short", _int);
            this.AddDerivedBuiltIn("byte", _short);

            this.AddListBuiltIn("IDREFS", id);
            this.AddListBuiltIn("ENTITIES", entity);
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

        private XsdbuiltInType AddBuiltIn(string name)
        {
            XsdbuiltInType type = new XsdbuiltInType() { Name = name };
            type.TopLevel = true;
            this.types.Add(type.Name, type);
            return type;
        }

        private XsdSimpleRestrictionType AddDerivedBuiltIn(string name, XsdSimpleType baseType)
        {
            XsdSimpleRestrictionType type = new XsdSimpleRestrictionType() { Name = name, BaseType = baseType };
            type.TopLevel = true;
            this.types.Add(type.Name, type);
            return type;
        }

        private XsdSimpleListType AddListBuiltIn(string name, XsdSimpleType itemType)
        {
            XsdSimpleListType type = new XsdSimpleListType() { Name = name, ItemType = itemType };
            type.TopLevel = true;
            this.types.Add(type.Name, type);
            return type;
        }

        private readonly Dictionary<string, XsdType> types = new Dictionary<string, XsdType>();
        private readonly Dictionary<string, XsdElement> elements = new Dictionary<string, XsdElement>();
        private readonly Dictionary<string, XsdAttribute> attributes = new Dictionary<string, XsdAttribute>();

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