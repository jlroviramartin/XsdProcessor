#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// A reference to an external file containing point information.
    /// The format of the information is defined by the order and delimeter attributes.
    /// </summary>

    public class PointFile : XsdBaseReader
    {
        public PointFile(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string FileName;

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

            this.FileName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("fileName"));

            this.FileType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("fileType"));

            this.FileFormat = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("fileFormat"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.FileName != null)
            {
                buff.Append("fileName", this.FileName);
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

            if ((object)this.FileName != null)
            {
                buff.AppendFormat("fileName = {0}", this.FileName).AppendLine();
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

