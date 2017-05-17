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

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// This element stores a range of Administrative dates which may vary from jurisdiction to jurisdiction.
    /// </summary>

    public class AdministrativeDate : XsdBaseReader
    {
        public AdministrativeDate(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// This is the name of the admin date type for the Survey
        /// </summary>

        public string AdminDateType;

        public DateTime AdminDate;

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

            this.AdminDateType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adminDateType"));

            this.AdminDate = XsdConverter.Instance.Convert<DateTime>(
                    attributes.GetSafe("adminDate"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.AdminDateType != null)
            {
                buff.Append("adminDateType", this.AdminDateType);
            }
            if ((object)this.AdminDate != null)
            {
                buff.Append("adminDate", this.AdminDate);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            if ((object)this.AdminDateType != null)
            {
                buff.AppendFormat("adminDateType = {0}", this.AdminDateType).AppendLine();
            }
            if ((object)this.AdminDate != null)
            {
                buff.AppendFormat("adminDate = {0}", this.AdminDate).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
