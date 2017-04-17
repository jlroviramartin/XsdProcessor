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

namespace XmlSchemaProcessor.Xsd.Facets
{
    /*
        [XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
        [XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
        [XmlElement("length", typeof(XmlSchemaLengthFacet))]
        [XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
        [XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
        [XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
        [XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
        [XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
        [XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
        [XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
        [XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
        [XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
     */

    public abstract class XsdFacet
    {
        public XsdFacet(FacetType facetType, object value)
        {
            this.FacetType = facetType;
            this.Value = value;
        }

        public FacetType FacetType { get; private set; }
        public object Value { get; private set; }

        #region object

        public override string ToString()
        {
            return string.Format("[{0} {1}]", this.FacetType, this.Value);
        }

        #endregion
    }
}