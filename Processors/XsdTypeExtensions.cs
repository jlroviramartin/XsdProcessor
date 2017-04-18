// Copyright 2017 Jose Luis Rovira Martin
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlSchemaProcessor.Xsd;
using XmlSchemaProcessor.Xsd.Facets;

namespace XmlSchemaProcessor.Processors
{
    public static class XsdTypeExtensions
    {
        public static string GetNetDocumentation(this XsdElement xsdElement)
        {
            StringBuilder buff = new StringBuilder();

            foreach (XsdDocumentation doc in xsdElement.Annotations)
            {
                buff.AppendLine(doc.Text);
            }
            return buff.ToString();
        }

        public static string GetNetDocumentation(this XsdType xsdType)
        {
            return GetNetDocumentationImp(xsdType);
        }

        private static string GetNetDocumentationImp(this XsdType xsdType)
        {
            StringBuilder buff = new StringBuilder();

            foreach (XsdDocumentation doc in xsdType.Annotations)
            {
                buff.AppendLine(doc.Text);
            }

            if (xsdType is XsdSimpleRestrictionType)
            {
                string aux = GetNetDocumentationImp(((XsdSimpleRestrictionType)xsdType).BaseType);
                if (!string.IsNullOrWhiteSpace(aux))
                {
                    buff.AppendLine("Restriction:");
                    buff.AppendLine(aux);
                }
            }
            else if (xsdType is XsdSimpleListType)
            {
                string aux = GetNetDocumentationImp(((XsdSimpleListType)xsdType).ItemType);
                if (!string.IsNullOrWhiteSpace(aux))
                {
                    buff.AppendLine("List:");
                    buff.AppendLine(aux);
                }
            }
            return buff.ToString();
        }

        public static string ToNetType(this XsdType xsdType, bool optional)
        {
            if (xsdType is XsdSimpleType)
            {
                return ToNetType((XsdSimpleType)xsdType, optional);
            }
            else
            {
                return xsdType.Name.ToTypeName();
            }
        }

        public static string ToNetType(this XsdSimpleType xsdType, bool optional)
        {
            if (xsdType is XsdBuiltInType)
            {
                return ToNetType((XsdBuiltInType)xsdType, optional);
            }
            else if (xsdType is XsdSimpleListType)
            {
                return ToNetType((XsdSimpleListType)xsdType, optional);
            }
            else if (xsdType is XsdSimpleRestrictionType)
            {
                return ToNetType((XsdSimpleRestrictionType)xsdType, optional);
            }
            else if (xsdType is XsdSimpleUnionType)
            {
                return ToNetType((XsdSimpleUnionType)xsdType, optional);
            }
            throw new IndexOutOfRangeException();
        }

        private static string ToNetType(XsdBuiltInType xsdType, bool optional)
        {
            switch (xsdType.Name)
            {
                case XsdBuiltInType.DURATION:
                    return CanBeOptional("TimeSpan", optional);
                case XsdBuiltInType.DATETIME:
                case XsdBuiltInType.DATE:
                case XsdBuiltInType.TIME:
                    return CanBeOptional("DateTime", optional);
                case XsdBuiltInType.STRING:
                    return "string";
                case XsdBuiltInType.BOOLEAN:
                    return CanBeOptional("bool", optional);
                case XsdBuiltInType.BASE_64_BINARY:
                case XsdBuiltInType.HEX_BINARY:
                    return "byte[]";
                case XsdBuiltInType.FLOAT:
                    return CanBeOptional("float", optional);
                case XsdBuiltInType.DOUBLE:
                    return CanBeOptional("double", optional);
                case XsdBuiltInType.DECIMAL:
                    return CanBeOptional("decimal", optional);

                case XsdBuiltInType.ANY_URI:
                    return "Uri";
                case XsdBuiltInType.QNAME:
                case XsdBuiltInType.NOTATION:
                    return "string";
            }
            throw new IndexOutOfRangeException();
        }

        private static string ToNetType(XsdSimpleRestrictionType xsdType, bool optional)
        {
            switch (xsdType.Name)
            {
                case XsdSimpleRestrictionType.NORMALIZED_STRING:
                case XsdSimpleRestrictionType.TOKEN:
                case XsdSimpleRestrictionType.LANGUAGE:
                case XsdSimpleRestrictionType.NAME:
                case XsdSimpleRestrictionType.NMTOKEN:
                case XsdSimpleRestrictionType.NCNAME:
                    return "string";
                case XsdSimpleRestrictionType.ID:
                case XsdSimpleRestrictionType.IDREF:
                    return "string";
                case XsdSimpleRestrictionType.ENTITY:
                    return "string";

                case XsdSimpleRestrictionType.INTEGER:
                case XsdSimpleRestrictionType.NON_POSITIVE_INTEGER:
                case XsdSimpleRestrictionType.NEGATIVE_INTEGER:
                    return CanBeOptional("int", optional);
                case XsdSimpleRestrictionType.NON_NEGATIVE_INTEGER:
                case XsdSimpleRestrictionType.POSITIVE_INTEGER:
                    return CanBeOptional("uint", optional);

                case XsdSimpleRestrictionType.UNSIGNED_LONG:
                    return CanBeOptional("ulong", optional);
                case XsdSimpleRestrictionType.UNSIGNED_INT:
                    return CanBeOptional("uint", optional);
                case XsdSimpleRestrictionType.UNSIGNED_SHORT:
                    return CanBeOptional("ushort", optional);
                case XsdSimpleRestrictionType.UNSIGNED_BYTE:
                    return CanBeOptional("byte", optional);

                case XsdSimpleRestrictionType.LONG:
                    return CanBeOptional("long", optional);
                case XsdSimpleRestrictionType.INT:
                    return CanBeOptional("int", optional);
                case XsdSimpleRestrictionType.SHORT:
                    return CanBeOptional("short", optional);
                case XsdSimpleRestrictionType.BYTE:
                    return CanBeOptional("sbyte", optional);
            }

            XsdSimpleType builtInRootType = xsdType.GetBuiltInRootType();
            if ((builtInRootType != null) && builtInRootType.Name == XsdBuiltInType.STRING)
            {
                if (xsdType.Facets
                           .Where(x => x.FacetType == FacetType.Enumeration)
                           .Select(x => x.Value)
                           .Any())
                {
                    return CanBeOptional(xsdType.Name.ToTypeName(), optional);
                }
            }

            return ToNetType(xsdType.BaseType, optional);
        }

        private static string ToNetType(XsdSimpleListType xsdType, bool optional)
        {
            return "IList<" + ToNetType(xsdType.ItemType, optional) + ">";
        }

        private static string CanBeOptional(string type, bool optional)
        {
            return !optional ? type : type + "?";
        }
    }
}