#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// A reference to any external document file containing related information for the associated element.
    /// </summary>

    public class DocFileRef : XsdBaseObject
    {
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

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

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

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.Location != null)
            {
                buff.AppendFormat(" location=\"{0}\"", this.Location);
            }
            if ((object)this.FileType != null)
            {
                buff.AppendFormat(" fileType=\"{0}\"", this.FileType);
            }
            if ((object)this.FileFormat != null)
            {
                buff.AppendFormat(" fileFormat=\"{0}\"", this.FileFormat);
            }


            return buff.ToString();
        }

        public string Name;

        public Uri Location;

        public string FileType;

        public string FileFormat;


    }
}
#endif

