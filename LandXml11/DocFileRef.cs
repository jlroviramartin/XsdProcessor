#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// A reference to any external document file containing related information for the associated element.
    /// </summary>

    public class DocFileRef : XsdBaseReader
    {
        public DocFileRef(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public Uri Location;

        public string FileType;

        public string FileFormat;

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

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Location = XsdConverter.Instance.Convert<Uri>(
                    attributes.GetSafe("location"));

            this.FileType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("fileType"));

            this.FileFormat = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("fileFormat"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Location != null)
            {
                buff.Append("location", this.Location);
            }
            if ((object)this.FileType != null)
            {
                buff.Append("fileType", this.FileType);
            }
            if ((object)this.FileFormat != null)
            {
                buff.Append("fileFormat", this.FileFormat);
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
            if ((object)this.Location != null)
            {
                buff.AppendFormat("location = {0}", this.Location).AppendLine();
            }
            if ((object)this.FileType != null)
            {
                buff.AppendFormat("fileType = {0}", this.FileType).AppendLine();
            }
            if ((object)this.FileFormat != null)
            {
                buff.AppendFormat("fileFormat = {0}", this.FileFormat).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

