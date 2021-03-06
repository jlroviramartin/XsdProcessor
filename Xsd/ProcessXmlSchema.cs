﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using XmlSchemaProcessor.Xsd.Facets;

namespace XmlSchemaProcessor.Xsd
{
    public class ProcessXmlSchema
    {
        public ProcessXmlSchema(XmlSchema xmlSchema)
        {
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(xmlSchema);
            schemaSet.Compile();

            this.schema.NamespaceURI = xmlSchema.TargetNamespace;

            this.Process(xmlSchema);
        }

        public XsdSchema GetSchema()
        {
            return this.schema;
        }

        public static XmlSchema LoadXmlSchema(string file)
        {
            using (FileStream stream = new FileStream(file, FileMode.Open))
            using (XmlTextReader xmlReader = new XmlTextReader(stream))
            {
                XmlSchema xmlSchema = XmlSchema.Read(xmlReader, Validation);
                return xmlSchema;
            }
        }

        public static XmlSchema NewXmlSchema(string schema)
        {
            using (StringReader reader = new StringReader(schema))
            using (XmlTextReader xmlReader = new XmlTextReader(reader))
            {
                XmlSchema xmlSchema = XmlSchema.Read(xmlReader, Validation);
                return xmlSchema;
            }
        }

        #region private

        private static AttributeUse GetAttributeUse(XmlSchemaUse use)
        {
            AttributeUse _use = AttributeUse.None;
            switch (use)
            {
                case XmlSchemaUse.None:
                    _use = AttributeUse.None;
                    break;
                case XmlSchemaUse.Optional:
                    _use = AttributeUse.Optional;
                    break;
                case XmlSchemaUse.Prohibited:
                    _use = AttributeUse.Prohibited;
                    break;
                case XmlSchemaUse.Required:
                    _use = AttributeUse.Required;
                    break;
            }
            return _use;
        }

        private bool Process(XmlSchema xmlSchema)
        {
            // The collection of XmlSchemaAnnotation, XmlSchemaAttribute, XmlSchemaAttributeGroup, XmlSchemaComplexType, XmlSchemaSimpleType, XmlSchemaElement, XmlSchemaGroup, or XmlSchemaNotation.
            // xmlSchema.Items

            foreach (XmlSchemaObject schemaObject in xmlSchema.Items)
            {
                // Se procesan los tipos simples.
                if (schemaObject is XmlSchemaSimpleType)
                {
                    this.schema.Add(this.ProcessXmlSchemaSimpleType((XmlSchemaSimpleType)schemaObject));
                }
                else if (schemaObject is XmlSchemaComplexType)
                {
                    // Se procesan los tipos complejos.
                    this.schema.Add(this.ProcessXmlSchemaComplexType((XmlSchemaComplexType)schemaObject));
                }
                else if (schemaObject is XmlSchemaAttribute)
                {
                    // Se procesan los atributos.
                    this.schema.Add(this.ProcessXmlAttribute((XmlSchemaAttribute)schemaObject));
                }
                else if (schemaObject is XmlSchemaAttributeGroup)
                {
                    // Se procesan los grupos de atributos.
                    XsdAttributeGroup _attributeGroup = this.ProcessXmlAttributeGroup((XmlSchemaAttributeGroup)schemaObject);
                }
                else if (schemaObject is XmlSchemaGroup)
                {
                    // Se procesan los grupos.
                    XsdGroup _group = this.ProcessXmlSchemaGroup((XmlSchemaGroup)schemaObject);
                }
                else if (schemaObject is XmlSchemaElement)
                {
                    // Se procesan los elementos.
                    this.schema.Add(this.ProcessXmlSchemaElement((XmlSchemaElement)schemaObject));
                }
                else if (schemaObject is XmlSchemaNotation)
                {
                }
                else if (schemaObject is XmlSchemaAnnotation)
                {
                    List<XsdDocumentation> annotations = this.ProcessXmlSchemaAnnotation((XmlSchemaAnnotation)schemaObject).ToList();
                    this.schema.Annotations.AddRange(annotations);
                }
                else
                {
                    throw new Exception();
                }
            }

            bool error = this.postProcess.Aggregate(false, (current, find) => current | find());

            this.postProcess.Clear();

            return error;
        }

        private XsdType ProcessXmlSchemaType(XmlSchemaType xmlSchemaType)
        {
            if (xmlSchemaType is XmlSchemaSimpleType)
            {
                return this.ProcessXmlSchemaSimpleType((XmlSchemaSimpleType)xmlSchemaType);
            }
            else if (xmlSchemaType is XmlSchemaComplexType)
            {
                return this.ProcessXmlSchemaComplexType((XmlSchemaComplexType)xmlSchemaType);
            }
            else
            {
                throw new Exception();
            }
        }

        #region xs:simpleType : tipos basicos

        /// <summary>
        /// <![CDATA[
        /// <simpleType
        ///   final = (#all | List of (list | union | restriction | extension))
        ///   id = ID
        ///   name = NCName
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (restriction | list | union))
        /// </simpleType>
        /// <restriction
        ///   base = QName
        ///   id = ID
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (simpleType?, (minExclusive | minInclusive | maxExclusive | maxInclusive | totalDigits | fractionDigits | length | minLength | maxLength | enumeration | whiteSpace | pattern | assertion | explicitTimezone | {any with namespace: ##other})*))
        /// </restriction>
        /// <list
        ///   id = ID
        ///   itemType = QName
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, simpleType?)
        /// </list>
        /// <union
        ///   id = ID
        ///   memberTypes = List of QName
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, simpleType*)
        /// </union>
        /// ]]>
        /// </summary>
        private XsdSimpleType ProcessXmlSchemaSimpleType(XmlSchemaSimpleType xmlSchemaSimpleType)
        {
            string id = xmlSchemaSimpleType.Id;
            XmlSchemaAnnotation annotation = xmlSchemaSimpleType.Annotation;
            XmlAttribute[] unhandledAttributes = xmlSchemaSimpleType.UnhandledAttributes;

            string name = xmlSchemaSimpleType.Name;
            XmlQualifiedName qualifiedName = xmlSchemaSimpleType.QualifiedName;

            XmlTypeCode typeCode = xmlSchemaSimpleType.TypeCode;
            XmlSchemaDatatype datatype = xmlSchemaSimpleType.Datatype;

            XmlSchemaType baseSchemaType = xmlSchemaSimpleType.BaseXmlSchemaType;

            XmlSchemaDerivationMethod derivedBy = xmlSchemaSimpleType.DerivedBy;
            XmlSchemaDerivationMethod @final = xmlSchemaSimpleType.Final;
            XmlSchemaDerivationMethod finalResolved = xmlSchemaSimpleType.FinalResolved;
            bool mixed = xmlSchemaSimpleType.IsMixed;

            XmlSchemaSimpleTypeContent content = xmlSchemaSimpleType.Content;

            // Anotaciones.
            List<XsdDocumentation> annotations = this.ProcessXmlSchemaAnnotation(annotation).ToList();

            XsdSimpleType ret = null;
            if (content is XmlSchemaSimpleTypeRestriction)
            {
                XmlSchemaSimpleTypeRestriction restriction = (XmlSchemaSimpleTypeRestriction)content;

                if (restriction.BaseType != null)
                {
                    XsdSimpleRestrictionType _simpleType = new XsdSimpleRestrictionType();
                    _simpleType.Name = name;
                    _simpleType.BaseType = this.ProcessXmlSchemaSimpleType(restriction.BaseType);

                    _simpleType.Facets.AddRange(restriction.Facets.OfType<XmlSchemaFacet>().Select(this.ProcessFacet));

                    ret = _simpleType;
                }
                else if (!restriction.BaseTypeName.IsEmpty)
                {
                    XsdSimpleRestrictionType _simpleType = new XsdSimpleRestrictionType();
                    _simpleType.Name = name;
                    this.FindSimple(restriction.BaseTypeName, x => _simpleType.BaseType = x);

                    _simpleType.Facets.AddRange(restriction.Facets.OfType<XmlSchemaFacet>().Select(this.ProcessFacet));

                    ret = _simpleType;
                }
            }
            else if (content is XmlSchemaSimpleTypeList)
            {
                XmlSchemaSimpleTypeList list = (XmlSchemaSimpleTypeList)content;

                if (list.ItemType != null)
                {
                    XsdSimpleListType _simpleType = new XsdSimpleListType();
                    _simpleType.Name = name;
                    _simpleType.ItemType = this.ProcessXmlSchemaSimpleType(list.ItemType);

                    ret = _simpleType;
                }
                else if (!list.ItemTypeName.IsEmpty)
                {
                    XsdSimpleListType _simpleType = new XsdSimpleListType();
                    _simpleType.Name = name;
                    this.FindSimple(list.ItemTypeName, x => _simpleType.ItemType = x);

                    ret = _simpleType;
                }
            }
            else if (content is XmlSchemaSimpleTypeUnion)
            {
                XmlSchemaSimpleTypeUnion simpleTypeUnion = (XmlSchemaSimpleTypeUnion)content;

                throw new NotImplementedException();
            }

            if (ret == null)
            {
                throw new Exception();
            }

            ret.Annotations.AddRange(annotations);
            return ret;
        }

        private XsdFacet ProcessFacet(XmlSchemaFacet facet)
        {
            if (facet is XmlSchemaPatternFacet)
            {
                return new XsdStringFacet(FacetType.Pattern, facet.Value);
            }
            if (facet is XmlSchemaWhiteSpaceFacet)
            {
                return new XsdStringFacet(FacetType.WhiteSpace, facet.Value);
            }
            if (facet is XmlSchemaEnumerationFacet)
            {
                return new XsdStringFacet(FacetType.Enumeration, facet.Value);
            }

            if (facet is XmlSchemaMinExclusiveFacet)
            {
                return new XsdNumericFacet(FacetType.MinExclusive, facet.Value);
            }
            if (facet is XmlSchemaMaxExclusiveFacet)
            {
                return new XsdNumericFacet(FacetType.MaxExclusive, facet.Value);
            }
            if (facet is XmlSchemaMinInclusiveFacet)
            {
                return new XsdNumericFacet(FacetType.MinInclusive, facet.Value);
            }
            if (facet is XmlSchemaMaxInclusiveFacet)
            {
                return new XsdNumericFacet(FacetType.MaxInclusive, facet.Value);
            }

            if (facet is XmlSchemaLengthFacet)
            {
                return new XsdIntFacet(FacetType.Length, facet.Value);
            }
            if (facet is XmlSchemaMinLengthFacet)
            {
                return new XsdIntFacet(FacetType.MinLength, facet.Value);
            }
            if (facet is XmlSchemaMaxLengthFacet)
            {
                return new XsdIntFacet(FacetType.MaxLength, facet.Value);
            }
            if (facet is XmlSchemaTotalDigitsFacet)
            {
                return new XsdIntFacet(FacetType.TotalDigits, facet.Value);
            }
            if (facet is XmlSchemaFractionDigitsFacet)
            {
                return new XsdIntFacet(FacetType.FractionDigits, facet.Value);
            }

            throw new IndexOutOfRangeException();
        }

        #endregion

        #region xs:complexType : tipos complejos

        /// <summary>
        /// <![CDATA[
        /// <complexType
        ///   abstract = boolean : false
        ///   block = (#all | List of (extension | restriction))
        ///   final = (#all | List of (extension | restriction))
        ///   id = ID
        ///   mixed = boolean
        ///   name = NCName
        ///   defaultAttributesApply = boolean : true
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (simpleContent | complexContent | (openContent?, (group | all | choice | sequence)?, ((attribute | attributeGroup)*, anyAttribute?), assert*)))
        /// </complexType>
        /// 
        /// <simpleContent
        ///   id = ID
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (restriction | extension))
        /// </simpleContent>
        /// <restriction
        ///   base = QName
        ///   id = ID
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (simpleType?, (minExclusive | minInclusive | maxExclusive | maxInclusive | totalDigits | fractionDigits | length | minLength | maxLength | enumeration | whiteSpace | pattern | assertion | {any with namespace: ##other})*)?, ((attribute | attributeGroup)*, anyAttribute?), assert*)
        /// </restriction>
        /// <extension
        ///   base = QName
        ///   id = ID
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, ((attribute | attributeGroup)*, anyAttribute?), assert*)
        /// </extension>
        /// 
        /// <complexContent
        ///   id = ID
        ///   mixed = boolean
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (restriction | extension))
        /// </complexContent>
        /// <restriction
        ///   base = QName
        ///   id = ID
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, openContent?, (group | all | choice | sequence)?, ((attribute | attributeGroup)*, anyAttribute?), assert*)
        /// </restriction>
        /// <extension
        ///   base = QName
        ///   id = ID
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, openContent?, ((group | all | choice | sequence)?, ((attribute | attributeGroup)*, anyAttribute?), assert*))
        /// </extension>
        /// 
        /// <openContent
        ///   id = ID
        ///   mode = (none | interleave | suffix) : interleave
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, any?)
        /// </openContent>
        /// ]]>
        /// </summary>
        private XsdComplexType ProcessXmlSchemaComplexType(XmlSchemaComplexType complexType)
        {
            string id = complexType.Id;
            XmlSchemaAnnotation annotation = complexType.Annotation;

            string name = complexType.Name;
            bool isAnonymous = string.IsNullOrEmpty(name);

            bool isMixed = complexType.IsMixed;
            bool isAbstract = complexType.IsAbstract;

            XmlSchemaContentModel contentModel = complexType.ContentModel;
            XmlSchemaParticle particle = complexType.Particle; // complexType.ContentTypeParticle;

            // Anotaciones.
            List<XsdDocumentation> annotations = this.ProcessXmlSchemaAnnotation(annotation).ToList();

            XsdComplexType ret = null;
            if (contentModel != null)
            {
                Contract.Assert(particle == null);

                if (contentModel is XmlSchemaSimpleContent)
                {
                    XmlSchemaSimpleContent simpleContent = (XmlSchemaSimpleContent)contentModel;
                    XmlSchemaContent content = simpleContent.Content;

                    if (content is XmlSchemaSimpleContentRestriction)
                    {
                        XmlSchemaSimpleContentRestriction restriction = (XmlSchemaSimpleContentRestriction)content;

                        if (restriction.BaseType != null)
                        {
                            XsdComplexSimpleContentType _complexType = new XsdComplexSimpleContentType();
                            _complexType.Name = name;
                            _complexType.Derivation = DerivationMethod.Restriction;
                            _complexType.BaseType = this.ProcessXmlSchemaSimpleType(restriction.BaseType);
                            _complexType.Attributes = this.ProcessXmlAttributes(restriction.Attributes, restriction.AnyAttribute);

                            ret = _complexType;
                        }
                        else if (!restriction.BaseTypeName.IsEmpty)
                        {
                            XsdComplexSimpleContentType _complexType = new XsdComplexSimpleContentType();
                            _complexType.Name = name;
                            _complexType.Derivation = DerivationMethod.Restriction;
                            this.FindSimple(restriction.BaseTypeName, x => _complexType.BaseType = x);
                            _complexType.Attributes = this.ProcessXmlAttributes(restriction.Attributes, restriction.AnyAttribute);

                            ret = _complexType;
                        }
                    }
                    else if (content is XmlSchemaSimpleContentExtension)
                    {
                        XmlSchemaSimpleContentExtension extension = (XmlSchemaSimpleContentExtension)content;

                        if (!extension.BaseTypeName.IsEmpty)
                        {
                            XsdComplexSimpleContentType _complexType = new XsdComplexSimpleContentType();
                            _complexType.Name = name;
                            _complexType.Derivation = DerivationMethod.Extension;
                            // -----> this.FindSimple(extension.BaseTypeName, x => _complexType.BaseType = x);
                            this.FindType(extension.BaseTypeName, x => _complexType.BaseType = x);
                            _complexType.Attributes = this.ProcessXmlAttributes(extension.Attributes, extension.AnyAttribute);

                            ret = _complexType;
                        }
                    }
                }
                else if (contentModel is XmlSchemaComplexContent)
                {
                    XmlSchemaComplexContent complexContent = (XmlSchemaComplexContent)contentModel;
                    XmlSchemaContent content = complexContent.Content;

                    if (content is XmlSchemaComplexContentRestriction)
                    {
                        XmlSchemaComplexContentRestriction restriction = (XmlSchemaComplexContentRestriction)content;

                        if (!restriction.BaseTypeName.IsEmpty)
                        {
                            XsdComplexComplexContentType _complexType = new XsdComplexComplexContentType();
                            _complexType.Name = name;
                            _complexType.Derivation = DerivationMethod.Restriction;
                            this.FindComplex(restriction.BaseTypeName, x => _complexType.BaseType = x);
                            _complexType.Particle = this.ProcessXmlSchemaParticle(restriction.Particle);
                            _complexType.Attributes = this.ProcessXmlAttributes(restriction.Attributes, restriction.AnyAttribute);

                            ret = _complexType;
                        }
                    }
                    else if (content is XmlSchemaComplexContentExtension)
                    {
                        XmlSchemaComplexContentExtension extension = (XmlSchemaComplexContentExtension)content;

                        if (!extension.BaseTypeName.IsEmpty)
                        {
                            XsdComplexComplexContentType _complexType = new XsdComplexComplexContentType();
                            _complexType.Name = name;
                            _complexType.Derivation = DerivationMethod.Restriction;
                            this.FindComplex(extension.BaseTypeName, x => _complexType.BaseType = x);
                            _complexType.Particle = this.ProcessXmlSchemaParticle(extension.Particle);
                            _complexType.Attributes = this.ProcessXmlAttributes(extension.Attributes, extension.AnyAttribute);

                            ret = _complexType;
                        }
                    }
                }
            }
            else
            {
                XsdComplexImplicitContentType _complexType = new XsdComplexImplicitContentType();
                _complexType.Name = name;
                if (particle != null)
                {
                    _complexType.Particle = this.ProcessXmlSchemaParticle(particle);
                }
                _complexType.Attributes = this.ProcessXmlAttributes(complexType.Attributes, complexType.AnyAttribute);

                ret = _complexType;
            }

            if (ret == null)
            {
                // Falta openContent, attribute, attributeGroup, anyAttribute, assert
                throw new Exception();
            }

            ret.Annotations.AddRange(annotations);
            return ret;
        }

        /// <summary>
        /// <![CDATA[
        /// <group
        ///   id = ID
        ///   maxOccurs = (nonNegativeInteger | unbounded)  : 1
        ///   minOccurs = nonNegativeInteger : 1
        ///   name = NCName
        ///   ref = QName
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (all | choice | sequence)?)
        /// </group>
        /// 
        /// <all
        ///   id = ID
        ///   maxOccurs = (0 | 1) : 1
        ///   minOccurs = (0 | 1) : 1
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (element | any | group)*)
        /// </all>
        /// <choice
        ///   id = ID
        ///   maxOccurs = (nonNegativeInteger | unbounded)  : 1
        ///   minOccurs = nonNegativeInteger : 1
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (element | group | choice | sequence | any)*)
        /// </choice>
        /// <sequence
        ///   id = ID
        ///   maxOccurs = (nonNegativeInteger | unbounded)  : 1
        ///   minOccurs = nonNegativeInteger : 1
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, (element | group | choice | sequence | any)*)
        /// </sequence>
        /// 
        /// <element ...>
        /// ]]>
        /// </summary>
        private XsdParticle ProcessXmlSchemaParticle(XmlSchemaParticle particle)
        {
            if (particle == null)
            {
                return null;
            }

            int min = (int)particle.MinOccurs;
            int max = ((particle.MaxOccurs != decimal.MaxValue) ? (int)particle.MaxOccurs : int.MaxValue); // unbounded = decimal.MaxValue

            if (particle is XmlSchemaAny)
            {
                XmlSchemaAny any = (XmlSchemaAny)particle;

                XsdParticleAny _particleAny = new XsdParticleAny();
                _particleAny.MinOccurs = min;
                _particleAny.MaxOccurs = max;

                return _particleAny;
            }
            else if (particle is XmlSchemaElement)
            {
                XmlSchemaElement element = (XmlSchemaElement)particle;

                XsdParticleElement _particleElement = new XsdParticleElement();
                _particleElement.MinOccurs = min;
                _particleElement.MaxOccurs = max;

                if (!element.RefName.IsEmpty)
                {
                    this.FindElement(element.RefName, x => _particleElement.Element = x);
                }
                else
                {
                    _particleElement.Element = this.ProcessXmlSchemaElement(element);
                }

                return _particleElement;
            }
            else if (particle is XmlSchemaGroupBase)
            {
                XmlSchemaGroupBase group = (XmlSchemaGroupBase)particle;

                XsdParticleGroup _group = new XsdParticleGroup();
                _group.MinOccurs = min;
                _group.MaxOccurs = max;
                _group.GroupType = ((group is XmlSchemaAll)
                    ? ParticleGroupType.All
                    : ((group is XmlSchemaChoice)
                        ? ParticleGroupType.Choice
                        : ParticleGroupType.Sequence));

                foreach (XmlSchemaParticle item in group.Items.Cast<XmlSchemaParticle>())
                {
                    _group.Items.Add(this.ProcessXmlSchemaParticle(item));
                }

                return _group;
            }
            else if (particle is XmlSchemaGroupRef)
            {
                XmlSchemaGroupRef groupRef = (XmlSchemaGroupRef)particle;

                throw new NotImplementedException();
            }

            throw new Exception();
        }

        /// <summary>
        /// <![CDATA[
        /// <attribute
        ///   default = string
        ///   fixed = string
        ///   form = (qualified | unqualified)
        ///   id = ID
        ///   name = NCName
        ///   ref = QName
        ///   targetNamespace = anyURI
        ///   type = QName
        ///   use = (optional | prohibited | required) : optional
        ///   inheritable = boolean
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, simpleType?)
        /// </attribute>
        /// <attributeGroup
        ///   id = ID
        ///   name = NCName
        ///   ref = QName
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, ((attribute | attributeGroup)*, anyAttribute?))
        /// </attributeGroup>
        /// <anyAttribute
        ///   id = ID
        ///   namespace = ((##any | ##other) | List of (anyURI | (##targetNamespace | ##local)) )
        ///   notNamespace = List of (anyURI | (##targetNamespace | ##local))
        ///   notQName = List of (QName | ##defined)
        ///   processContents = (lax | skip | strict) : strict
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?)
        /// </anyAttribute>
        /// ]]>
        /// </summary>
        private XsdAttributes ProcessXmlAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute)
        {
            XsdAttributes _attributes = new XsdAttributes();

            foreach (XmlSchemaObject schemaObject in attributes)
            {
                if (schemaObject is XmlSchemaAttribute)
                {
                    XmlSchemaAttribute attribute = (XmlSchemaAttribute)schemaObject;

                    if (!attribute.RefName.IsEmpty)
                    {
                        int index = _attributes.Content.Count;
                        this.FindAttribute(attribute.RefName, x => _attributes.Content.Insert(index, x));
                    }
                    else
                    {
                        _attributes.Content.Add(this.ProcessXmlAttribute(attribute));
                    }
                }
                else if (schemaObject is XmlSchemaAttributeGroupRef)
                {
                    XmlSchemaAttributeGroupRef attributeGroupRef = (XmlSchemaAttributeGroupRef)schemaObject;

                    throw new NotImplementedException();
                }
            }
            return _attributes;
        }

        private XsdAttribute ProcessXmlAttribute(XmlSchemaAttribute attribute)
        {
            string name = attribute.Name;
            string defValue = attribute.DefaultValue;

            XmlSchemaSimpleType schemaType = attribute.SchemaType;
            XmlQualifiedName schemaTypeName = attribute.SchemaTypeName;
            XmlSchemaSimpleType attributeSchemaType = attribute.AttributeSchemaType; // based on the SchemaType or SchemaTypeName

            XmlSchemaUse use = attribute.Use;

            XsdAttribute ret = null;
            if (attribute.RefName.IsEmpty)
            {
                if (!schemaTypeName.IsEmpty)
                {
                    Contract.Assert(schemaType == null);

                    XsdAttribute _attribute = new XsdAttribute();
                    _attribute.Name = name;
                    this.FindSimple(schemaTypeName, x => _attribute.Type = x);

                    ret = _attribute;
                }
                else if (schemaType != null)
                {
                    XsdAttribute _attribute = new XsdAttribute();
                    _attribute.Name = name;
                    _attribute.Type = this.ProcessXmlSchemaSimpleType(schemaType);

                    ret = _attribute;
                }
                else
                {
                    // No tiene definido tipo (a veces ocurre).
                    XsdAttribute _attribute = new XsdAttribute();
                    _attribute.Name = name;
                    //_attribute.Type = ..;

                    ret = _attribute;
                }
            }

            if (ret == null)
            {
                throw new Exception();
            }

            AttributeUse _use = GetAttributeUse(use);
            ret.Use = _use;
            ret.DefValue = defValue;
            return ret;
        }

        private XsdAttributeGroup ProcessXmlAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
        {
            string name = attributeGroup.Name;

            XsdAttributeGroup _attributeGroup = new XsdAttributeGroup();
            _attributeGroup.Name = name;
            _attributeGroup.Attributes = this.ProcessXmlAttributes(attributeGroup.Attributes, attributeGroup.AnyAttribute);

            return _attributeGroup;
        }

        private XsdGroup ProcessXmlSchemaGroup(XmlSchemaGroup group)
        {
            string name = group.Name;

            XsdGroup _group = new XsdGroup();
            _group.Name = name;
            _group.Particle = this.ProcessXmlSchemaParticle(group.Particle);

            return _group;
        }

        #endregion

        #region xs:element : elementos

        /// <summary>
        /// <![CDATA[
        /// <element
        ///   abstract = boolean : false
        ///   block = (#all | List of (extension | restriction | substitution))
        ///   default = string
        ///   final = (#all | List of (extension | restriction))
        ///   fixed = string
        ///   form = (qualified | unqualified)
        ///   id = ID
        ///   maxOccurs = (nonNegativeInteger | unbounded)  : 1
        ///   minOccurs = nonNegativeInteger : 1
        ///   name = NCName
        ///   nillable = boolean : false
        ///   ref = QName
        ///   substitutionGroup = List of QName
        ///   targetNamespace = anyURI
        ///   type = QName
        ///   {any attributes with non-schema namespace . . .}>
        ///   Content: (annotation?, ((simpleType | complexType)?, alternative*, (unique | key | keyref)*))
        /// </element>
        /// ]]>
        /// </summary>
        private XsdElement ProcessXmlSchemaElement(XmlSchemaElement xmlSchemaElement)
        {
            // XmlSchemaAnnotated
            string id = xmlSchemaElement.Id;
            XmlSchemaAnnotation annotation = xmlSchemaElement.Annotation;

            // Solo para cuando sean particulas.
            //int min = (int)xmlSchemaElement.MinOccurs;
            //int max = ((xmlSchemaElement.MaxOccurs != decimal.MaxValue) ? (int)xmlSchemaElement.MaxOccurs : int.MaxValue); // unbounded = decimal.MaxValue

            string defaultValue = xmlSchemaElement.DefaultValue;
            string fixedValue = xmlSchemaElement.FixedValue;

            bool isAbstract = xmlSchemaElement.IsAbstract;
            bool isNillable = xmlSchemaElement.IsNillable;

            string name = xmlSchemaElement.Name;

            XmlSchemaType schemaType = xmlSchemaElement.SchemaType;
            XmlQualifiedName schemaTypeName = xmlSchemaElement.SchemaTypeName;
            XmlSchemaType elementSchemaType = xmlSchemaElement.ElementSchemaType; // based on the SchemaType or SchemaTypeName

            // Anotaciones.
            List<XsdDocumentation> annotations = this.ProcessXmlSchemaAnnotation(annotation).ToList();

            XsdElement ret = null;
            if (xmlSchemaElement.RefName.IsEmpty)
            {
                if (!schemaTypeName.IsEmpty)
                {
                    Contract.Assert(schemaType == null);

                    XsdElement _element = new XsdElement();
                    _element.Name = name;
                    _element.IsAbstract = isAbstract;
                    _element.IsNillable = isNillable;
                    this.FindType(schemaTypeName, x => _element.TypeDefinition = x);

                    ret = _element;
                }
                else if (schemaType != null)
                {
                    XsdElement _element = new XsdElement();
                    _element.Name = name;
                    _element.IsAbstract = isAbstract;
                    _element.IsNillable = isNillable;
                    _element.TypeDefinition = this.ProcessXmlSchemaType(schemaType);

                    ret = _element;
                }
                else
                {
                    // No tiene definido tipo (¿puede ocurrir?).
                    XsdElement _element = new XsdElement();
                    _element.Name = name;
                    _element.IsAbstract = isAbstract;
                    _element.IsNillable = isNillable;

                    ret = _element;
                }
            }

            if (ret == null)
            {
                throw new Exception();
            }

            ret.Annotations.AddRange(annotations);
            return ret;
        }

        #endregion

        private IEnumerable<XsdDocumentation> ProcessXmlSchemaAnnotation(XmlSchemaAnnotation annotation)
        {
            List<XsdDocumentation> ret = new List<XsdDocumentation>();
            if (annotation != null)
            {
                foreach (XmlSchemaObject schemaObject in annotation.Items)
                {
                    if (schemaObject is XmlSchemaAppInfo)
                    {
                        /*XmlSchemaAppInfo schemaAppInfo = (XmlSchemaAppInfo)schemaObject;
                        StringBuilder buff = new StringBuilder();
                        foreach (XmlNode markup in schemaAppInfo.Markup)
                        {
                            buff.AppendLine(markup.OuterXml);
                        }*/
                    }
                    else if (schemaObject is XmlSchemaDocumentation)
                    {
                        XmlSchemaDocumentation schemaDocumentation = (XmlSchemaDocumentation)schemaObject;
                        StringBuilder buff = new StringBuilder();
                        foreach (XmlNode markup in schemaDocumentation.Markup)
                        {
                            buff.AppendLine(markup.OuterXml);
                        }
                        ret.Add(new XsdDocumentation(schemaDocumentation.Source, schemaDocumentation.Language, buff.ToString()));
                    }
                }
            }
            return ret;
        }

        private void Find<T>(Func<XmlQualifiedName, T> find, XmlQualifiedName baseTypeName, Action<T> found)
        {
            Func<bool> _find = () =>
            {
                T type = find(baseTypeName);
                if (type != null)
                {
                    found(type);
                    return true;
                }
                return false;
            };

            if (!_find())
            {
                this.postProcess.Add(_find);
            }
        }

        private void FindType(XmlQualifiedName baseTypeName, Action<XsdType> found)
        {
            this.Find(this.schema.FindType, baseTypeName, found);
        }

        private void FindSimple(XmlQualifiedName baseTypeName, Action<XsdSimpleType> found)
        {
            this.Find(this.schema.FindSimple, baseTypeName, found);
        }

        private void FindComplex(XmlQualifiedName baseTypeName, Action<XsdComplexType> found)
        {
            this.Find(this.schema.FindComplex, baseTypeName, found);
        }

        private void FindElement(XmlQualifiedName baseTypeName, Action<XsdElement> found)
        {
            this.Find(this.schema.FindElement, baseTypeName, found);
        }

        private void FindAttribute(XmlQualifiedName baseTypeName, Action<XsdAttribute> found)
        {
            this.Find(this.schema.FindAttribute, baseTypeName, found);
        }

        private static void Validation(object sender, ValidationEventArgs args)
        {
            Debug.WriteLine("Validation Error: {0}", args.Message);
        }

        private readonly XsdSchema schema = new XsdSchema();
        private readonly List<Func<bool>> postProcess = new List<Func<bool>>();

        #endregion

        #region inner classes

        private class XsdGroup
        {
            public string Name { get; set; }
            public XsdParticle Particle { get; set; }
        }

        private class XsdAttributeGroup
        {
            public string Name { get; set; }
            public XsdAttributes Attributes { get; set; }
        }

        #endregion
    }
}