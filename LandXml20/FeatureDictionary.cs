#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Used to describe specific Feature code / property type values. DocFileRef points to reference documentation
    /// Each Property element defines one piece of data.
    /// Sequence [1, 1]
    ///     DocFileRef [0, *]
    /// </summary>

    public class FeatureDictionary : XsdBaseReader
    {
        public FeatureDictionary(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public string Version;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("DocFileRef"))
            {
                return Tuple.Create("DocFileRef", this.NewReader<DocFileRef>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Version = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("version"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Version != null)
            {
                buff.Append("version", this.Version);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Version != null)
            {
                buff.AppendFormat("version = {0}", this.Version).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

