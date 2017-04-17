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

using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor
{
    public class XsdProcess
    {
        public virtual void Process(XsdSchema schema)
        {
            foreach (XsdElement element in schema.Elements)
            {
                this.Process(element);
            }
        }

        public virtual void Process(XsdElement element)
        {
            this.Process(element.TypeDefinition);
        }

        #region XsdType

        public virtual void Process(XmlSchemaProcessor.Xsd.XsdType xsdType)
        {
            if (xsdType is XsdSimpleType)
            {
                this.Process((XsdSimpleType)xsdType);
            }
            else if (xsdType is XsdComplexType)
            {
                this.Process((XsdComplexType)xsdType);
            }
        }

        #region XsdSimpleType

        public virtual void Process(XsdSimpleType xsdType)
        {
            if (xsdType is XsdBuiltInType)
            {
                this.Process((XsdBuiltInType)xsdType);
            }
            else if (xsdType is XsdSimpleListType)
            {
                this.Process((XsdSimpleListType)xsdType);
            }
            else if (xsdType is XsdSimpleRestrictionType)
            {
                this.Process((XsdSimpleRestrictionType)xsdType);
            }
            else if (xsdType is XsdSimpleUnionType)
            {
                this.Process((XsdSimpleUnionType)xsdType);
            }
        }

        public virtual void Process(XsdBuiltInType xsdType)
        {
        }

        public virtual void Process(XsdSimpleListType xsdType)
        {
        }

        public virtual void Process(XsdSimpleRestrictionType xsdType)
        {
        }

        public virtual void Process(XsdSimpleUnionType xsdType)
        {
        }

        #endregion

        #region XsdComplexType

        public virtual void Process(XsdComplexType xsdType)
        {
            if (xsdType is XsdComplexComplexContentType)
            {
                this.Process((XsdComplexComplexContentType)xsdType);
            }
            else if (xsdType is XsdComplexImplicitContentType)
            {
                this.Process((XsdComplexImplicitContentType)xsdType);
            }
            else if (xsdType is XsdComplexSimpleContentType)
            {
                this.Process((XsdComplexSimpleContentType)xsdType);
            }
        }

        public virtual void Process(XsdComplexComplexContentType xsdType)
        {
        }

        public virtual void Process(XsdComplexImplicitContentType xsdType)
        {
        }

        public virtual void Process(XsdComplexSimpleContentType xsdType)
        {
        }

        #endregion

        #endregion

        #region XsdAttribute

        public virtual void Process(XsdAttributes xsdAttributes)
        {
            foreach (XsdAttribute xsdAttribute in xsdAttributes.Content)
            {
                this.Process(xsdAttribute);
            }
        }

        public virtual void Process(XsdAttribute xsdAttribute)
        {
        }

        #endregion

        #region XsdParticle

        public virtual void Process(XsdParticle xsdParticle)
        {
            if (xsdParticle is XsdParticleGroup)
            {
                this.Process((XsdParticleGroup)xsdParticle);
            }
            else if (xsdParticle is XsdParticleAny)
            {
                this.Process((XsdParticleAny)xsdParticle);
            }
            else if (xsdParticle is XsdParticleElement)
            {
                this.Process((XsdParticleElement)xsdParticle);
            }
        }

        public virtual void Process(XsdParticleGroup xsdParticle)
        {
        }

        public virtual void Process(XsdParticleAny xsdParticle)
        {
        }

        public virtual void Process(XsdParticleElement xsdParticle)
        {
        }

        #endregion
    }
}