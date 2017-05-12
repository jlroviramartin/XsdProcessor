#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Optional element to identify the source of the file.
    /// Sequence [1, 1]
    ///     XmlSchemaProcessor.Xsd.XsdParticleAny
    /// </summary>

    public class Author : XsdBaseReader
    {
        public Author(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string CreatedBy;

        public string CreatedByEmail;

        public string Company;

        public string CompanyURL;

        public DateTime? TimeStamp;

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

            this.CreatedBy = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("createdBy"));

            this.CreatedByEmail = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("createdByEmail"));

            this.Company = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("company"));

            this.CompanyURL = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("companyURL"));

            this.TimeStamp = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("timeStamp"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.CreatedBy != null)
            {
                buff.Append("createdBy", this.CreatedBy);
            }
            if ((object)this.CreatedByEmail != null)
            {
                buff.Append("createdByEmail", this.CreatedByEmail);
            }
            if ((object)this.Company != null)
            {
                buff.Append("company", this.Company);
            }
            if ((object)this.CompanyURL != null)
            {
                buff.Append("companyURL", this.CompanyURL);
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

            if ((object)this.CreatedBy != null)
            {
                buff.AppendFormat("createdBy = {0}", this.CreatedBy).AppendLine();
            }
            if ((object)this.CreatedByEmail != null)
            {
                buff.AppendFormat("createdByEmail = {0}", this.CreatedByEmail).AppendLine();
            }
            if ((object)this.Company != null)
            {
                buff.AppendFormat("company = {0}", this.Company).AppendLine();
            }
            if ((object)this.CompanyURL != null)
            {
                buff.AppendFormat("companyURL = {0}", this.CompanyURL).AppendLine();
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

