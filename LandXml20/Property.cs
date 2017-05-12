#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Used to include additional information that is not explicitly defined by the LandXML schema. Each Property element defines one piece of data.
    /// The "label" attribute defines the name of the value held in the "value" attribute.
    /// </summary>

    public class Property : XsdBaseReader
    {
        public Property(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Label;

        public string Value;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Label = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("label"));

            this.Value = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("value"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Label != null)
            {
                buff.Append("label", this.Label);
            }
            if ((object)this.Value != null)
            {
                buff.Append("value", this.Value);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Label != null)
            {
                buff.AppendFormat("label = {0}", this.Label).AppendLine();
            }
            if ((object)this.Value != null)
            {
                buff.AppendFormat("value = {0}", this.Value).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

