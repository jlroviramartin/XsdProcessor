#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    // needContent    : false
    // includeContent : false
    public class SurveyorCertificate : XsdBaseReader
    {
        public SurveyorCertificate(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.CertificateType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("certificateType"));

            this.TextCertificate = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("textCertificate"));

            this.SurveyDate = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("surveyDate"));

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
            if ((object)this.CertificateType != null)
            {
                buff.AppendFormat("certificateType = {0}", this.CertificateType).AppendLine();
            }
            if ((object)this.TextCertificate != null)
            {
                buff.AppendFormat("textCertificate = {0}", this.TextCertificate).AppendLine();
            }
            if ((object)this.SurveyDate != null)
            {
                buff.AppendFormat("surveyDate = {0}", this.SurveyDate).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.CertificateType != null)
            {
                buff.Append("certificateType", this.CertificateType);
            }
            if ((object)this.TextCertificate != null)
            {
                buff.Append("textCertificate", this.TextCertificate);
            }
            if ((object)this.SurveyDate != null)
            {
                buff.Append("surveyDate", this.SurveyDate);
            }

            return buff.ToString();
        }

        public string Name;

        public string CertificateType;

        public string TextCertificate;

        public DateTime? SurveyDate;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

