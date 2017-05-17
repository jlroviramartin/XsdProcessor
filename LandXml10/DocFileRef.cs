//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime: <..>
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using XmlSchemaProcessor.Common;

namespace XmlSchemaProcessor.LandXml10
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

        protected override bool NewReader(string namespaceURI, string name)
        {
            return base.NewReader(namespaceURI, name);
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
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

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
            StringBuilder buff = new StringBuilder(base.ToString());

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
