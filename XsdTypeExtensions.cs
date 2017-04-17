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
using System.Linq;
using XmlSchemaProcessor.Xsd;
using XmlSchemaProcessor.Xsd.Facets;

namespace XmlSchemaProcessor
{
    public static class XsdTypeExtensions
    {
        public static string ToNetType(this XsdType xsdType)
        {
            if (xsdType is XsdSimpleType)
            {
                return ToNetType((XsdSimpleType)xsdType);
            }
            else
            {
                return xsdType.Name.ToTypeName();
            }
        }

        public static string ToNetType(this XsdSimpleType xsdType)
        {
            if (xsdType is XsdBuiltInType)
            {
                return ToNetType((XsdBuiltInType)xsdType);
            }
            else if (xsdType is XsdSimpleListType)
            {
                return ToNetType((XsdSimpleListType)xsdType);
            }
            else if (xsdType is XsdSimpleRestrictionType)
            {
                return ToNetType((XsdSimpleRestrictionType)xsdType);
            }
            else if (xsdType is XsdSimpleUnionType)
            {
                return ToNetType((XsdSimpleUnionType)xsdType);
            }
            throw new IndexOutOfRangeException();
        }

        private static string ToNetType(XsdBuiltInType xsdType)
        {
            switch (xsdType.Name)
            {
                case XsdBuiltInType.DURATION:
                    return "System.TimeSpan";
                case XsdBuiltInType.DATETIME:
                case XsdBuiltInType.DATE:
                case XsdBuiltInType.TIME:
                    return "System.DateTime";
                case XsdBuiltInType.STRING:
                    return "string";
                case XsdBuiltInType.BOOLEAN:
                    return "bool";
                case XsdBuiltInType.BASE_64_BINARY:
                case XsdBuiltInType.HEX_BINARY:
                    return "byte[]";
                case XsdBuiltInType.FLOAT:
                    return "float";
                case XsdBuiltInType.DOUBLE:
                    return "double";
                case XsdBuiltInType.DECIMAL:
                    return "decimal";

                case XsdBuiltInType.ANY_URI:
                    return "System.Uri";
                case XsdBuiltInType.QNAME:
                case XsdBuiltInType.NOTATION:
                    return "string";
            }
            throw new IndexOutOfRangeException();
        }

        private static string ToNetType(XsdSimpleRestrictionType xsdType)
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
                    return "int";
                case XsdSimpleRestrictionType.NON_NEGATIVE_INTEGER:
                case XsdSimpleRestrictionType.POSITIVE_INTEGER:
                    return "uint";

                case XsdSimpleRestrictionType.UNSIGNED_LONG:
                    return "ulong";
                case XsdSimpleRestrictionType.UNSIGNED_INT:
                    return "uint";
                case XsdSimpleRestrictionType.UNSIGNED_SHORT:
                    return "ushort";
                case XsdSimpleRestrictionType.UNSIGNED_BYTE:
                    return "byte";

                case XsdSimpleRestrictionType.LONG:
                    return "long";
                case XsdSimpleRestrictionType.INT:
                    return "int";
                case XsdSimpleRestrictionType.SHORT:
                    return "short";
                case XsdSimpleRestrictionType.BYTE:
                    return "sbyte";
            }

            XsdSimpleType builtInRootType = xsdType.GetBuiltInRootType();
            if ((builtInRootType != null) && builtInRootType.Name == XsdBuiltInType.STRING)
            {
                if (xsdType.Facets
                           .Where(x => x.FacetType == FacetType.Enumeration)
                           .Select(x => x.Value)
                           .Any())
                {
                    return xsdType.Name.ToTypeName();
                }
            }

            return ToNetType(xsdType.BaseType);
        }

        private static string ToNetType(XsdSimpleListType xsdType)
        {
            return "IList<" + ToNetType(xsdType.ItemType) + ">";
        }
    }
}