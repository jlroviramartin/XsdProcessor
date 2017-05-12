#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Annotation is a descriptive string use to describe an action on survey
    /// </summary>

    public class Annotation : XsdBaseReader
    {
        public Annotation(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// An Annotation will be a specific type within a jurisdiction. 
        /// </summary>

        public string Type;

        public string Name;

        public string Desc;
        /// <summary>
        /// A list of reference names values refering to one or more Parcel.name attributes.
        /// </summary>

        public IList<string> PclRef;

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

            this.Type = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("type"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.PclRef = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("pclRef"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Type != null)
            {
                buff.Append("type", this.Type);
            }
            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.PclRef != null)
            {
                buff.Append("pclRef", this.PclRef);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Type != null)
            {
                buff.AppendFormat("type = {0}", this.Type).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.PclRef != null)
            {
                buff.AppendFormat("pclRef = {0}", this.PclRef).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

