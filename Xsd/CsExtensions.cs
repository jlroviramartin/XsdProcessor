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

using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.Xsd
{
    public static class CsExtensions
    {
        public static string ToNetType(this XsdElement xsdElement, bool optional)
        {
            if (xsdElement.TypeDefinition is XsdComplexType)
            {
                if (xsdElement.TypeDefinition.TopLevel)
                {
                    return xsdElement.TypeDefinition.ToNetType(optional);
                }
                else
                {
                    return xsdElement.Name.ToTypeName();
                }
            }
            else if (xsdElement.TypeDefinition is XsdSimpleType)
            {
                return xsdElement.TypeDefinition.ToNetType(optional);
            }
            return "<Error>";
        }
    }
}