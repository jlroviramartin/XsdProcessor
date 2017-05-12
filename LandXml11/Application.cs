#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Optional element to identify the software that was used to create the file.
    /// Sequence [1, 1]
    ///     Choice [1, 1]
    ///         Author [0, *]
    ///         XmlSchemaProcessor.Xsd.XsdParticleAny
    /// </summary>

    public class Application : XsdBaseReader
    {
        public Application(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public string Desc;

        public string Manufacturer;

        public string Version;

        public string ManufacturerURL;

        public DateTime? TimeStamp;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Author"))
            {
                return Tuple.Create("Author", this.NewReader<Author>());
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

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Manufacturer = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("manufacturer"));

            this.Version = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("version"));

            this.ManufacturerURL = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("manufacturerURL"));

            this.TimeStamp = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("timeStamp"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Manufacturer != null)
            {
                buff.Append("manufacturer", this.Manufacturer);
            }
            if ((object)this.Version != null)
            {
                buff.Append("version", this.Version);
            }
            if ((object)this.ManufacturerURL != null)
            {
                buff.Append("manufacturerURL", this.ManufacturerURL);
            }
            if ((object)this.TimeStamp != null)
            {
                buff.Append("timeStamp", this.TimeStamp);
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
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Manufacturer != null)
            {
                buff.AppendFormat("manufacturer = {0}", this.Manufacturer).AppendLine();
            }
            if ((object)this.Version != null)
            {
                buff.AppendFormat("version = {0}", this.Version).AppendLine();
            }
            if ((object)this.ManufacturerURL != null)
            {
                buff.AppendFormat("manufacturerURL = {0}", this.ManufacturerURL).AppendLine();
            }
            if ((object)this.TimeStamp != null)
            {
                buff.AppendFormat("timeStamp = {0}", this.TimeStamp).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

