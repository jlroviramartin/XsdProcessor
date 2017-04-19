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

    public class PointFile : XsdBaseObject
    {
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

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

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

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.FileName != null)
            {
                buff.AppendFormat(" fileName=\"{0}\"", this.FileName);
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

        public string FileName;

        public string FileType;

        public string FileFormat;


    }
}
#endif
