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

namespace XmlSchemaProcessor.LandXml11
{

    public class SurveyorCertificate : XsdBaseReader
    {
        public SurveyorCertificate(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public string CertificateType;

        public string TextCertificate;

        public DateTime? SurveyDate;

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

            this.CertificateType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("certificateType"));

            this.TextCertificate = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("textCertificate"));

            this.SurveyDate = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("surveyDate"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

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

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

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

        #endregion
    }
}
#endif
