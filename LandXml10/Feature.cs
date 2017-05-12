#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Used to include additional information that is not explicitly defined by the LandXML schema, Feature may contain one or more Property, DocFileRef or nested Feature elements. 
    /// NOTE: to allow any valid content, the explicit definitions for Property, DocFileRef and Feature have been commented out, but are still expected in common use.
    /// Each Property element defines one piece of data.
    /// Choice [0, *]
    ///     XmlSchemaProcessor.Xsd.XsdParticleAny
    /// </summary>

    public class Feature : XsdBaseReader
    {
        public Feature(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Code = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("code"));

            this.Source = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("source"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Code != null)
            {
                buff.AppendFormat("code = {0}", this.Code).AppendLine();
            }
            if ((object)this.Source != null)
            {
                buff.AppendFormat("source = {0}", this.Source).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Code != null)
            {
                buff.Append("code", this.Code);
            }
            if ((object)this.Source != null)
            {
                buff.Append("source", this.Source);
            }

            return buff.ToString();
        }

        public string Code;

        public string Source;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

