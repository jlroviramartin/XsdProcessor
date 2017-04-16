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

namespace XmlSchemaTest
{
    public static class XsdSimpleTypeExtensions
    {
        public static string ToType(this XsdSimpleType xsdType)
        {
            if (xsdType is XsdBuiltInType)
            {
                return ToType((XsdBuiltInType)xsdType);
            }
            else if (xsdType is XsdSimpleListType)
            {
                return ToType((XsdSimpleListType)xsdType);
            }
            else if (xsdType is XsdSimpleRestrictionType)
            {
                return ToType((XsdSimpleRestrictionType)xsdType);
            }
            else if (xsdType is XsdSimpleUnionType)
            {
                return ToType((XsdSimpleUnionType)xsdType);
            }
            throw new IndexOutOfRangeException();
        }

        private static string ToType(XsdBuiltInType xsdType)
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
                    return "System.string";
                case XsdBuiltInType.BOOLEAN:
                    return "System.bool";
                case XsdBuiltInType.BASE_64_BINARY:
                case XsdBuiltInType.HEX_BINARY:
                    return "System.byte[]";
                case XsdBuiltInType.FLOAT:
                    return "System.float";
                case XsdBuiltInType.DOUBLE:
                    return "System.double";
                case XsdBuiltInType.DECIMAL:
                    return "System.decimal";

                case XsdBuiltInType.ANY_URI:
                    return "System.Uri";
                case XsdBuiltInType.QNAME:
                case XsdBuiltInType.NOTATION:
                    return "System.string";
            }
            throw new IndexOutOfRangeException();
        }

        private static string ToType(XsdSimpleRestrictionType xsdType)
        {
            switch (xsdType.Name)
            {
                case XsdSimpleRestrictionType.NORMALIZED_STRING:
                case XsdSimpleRestrictionType.TOKEN:
                case XsdSimpleRestrictionType.LANGUAGE:
                case XsdSimpleRestrictionType.NAME:
                case XsdSimpleRestrictionType.NMTOKEN:
                case XsdSimpleRestrictionType.NCNAME:
                    return "System.string";
                case XsdSimpleRestrictionType.ID:
                case XsdSimpleRestrictionType.IDREF:
                    return "System.string";
                case XsdSimpleRestrictionType.ENTITY:
                    return "System.string";

                case XsdSimpleRestrictionType.INTEGER:
                case XsdSimpleRestrictionType.NON_POSITIVE_INTEGER:
                case XsdSimpleRestrictionType.NEGATIVE_INTEGER:
                    return "System.int";
                case XsdSimpleRestrictionType.NON_NEGATIVE_INTEGER:
                case XsdSimpleRestrictionType.POSITIVE_INTEGER:
                    return "System.uint";

                case XsdSimpleRestrictionType.UNSIGNED_LONG:
                    return "System.ulong";
                case XsdSimpleRestrictionType.UNSIGNED_INT:
                    return "System.uint";
                case XsdSimpleRestrictionType.UNSIGNED_SHORT:
                    return "System.ushort";
                case XsdSimpleRestrictionType.UNSIGNED_BYTE:
                    return "System.byte";

                case XsdSimpleRestrictionType.LONG:
                    return "System.long";
                case XsdSimpleRestrictionType.INT:
                    return "System.int";
                case XsdSimpleRestrictionType.SHORT:
                    return "System.short";
                case XsdSimpleRestrictionType.BYTE:
                    return "System.sbyte";
            }

            XsdSimpleType builtInRootType = xsdType.GetBuiltInRootType();
            if ((builtInRootType != null) && builtInRootType.Name == XsdBuiltInType.STRING)
            {
                if (xsdType.Facets
                           .Where(x => x.FacetType == FacetType.Enumeration)
                           .Select(x => x.Value)
                           .Any())
                {
                    return "enum<" + xsdType.Name + ">";
                }
            }

            return ToType(xsdType.BaseType);
        }

        private static string ToType(XsdSimpleListType xsdType)
        {
            return "IList<" + ToType(xsdType.ItemType) + ">";
        }
    }
}