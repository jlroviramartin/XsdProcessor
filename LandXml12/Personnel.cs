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

namespace XmlSchemaProcessor.LandXml12
{

    public class Personnel : XsdBaseReader
    {
        public Personnel(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;
        /// <summary>
        /// This is a jurisdictionally based list of roles that a surveyor can undertake within a survey for example field hand, authorising surveyor, technician.
        /// </summary>

        public string Role;
        /// <summary>
        /// This is a jurisdictionally based list of classes of registration for a surveyor.  This allows validation of the surveyors role in the survey for legal traceablity.
        /// </summary>

        public string RegType;

        public string RegNumber;

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

            this.Role = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("role"));

            this.RegType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("regType"));

            this.RegNumber = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("regNumber"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Role != null)
            {
                buff.Append("role", this.Role);
            }
            if ((object)this.RegType != null)
            {
                buff.Append("regType", this.RegType);
            }
            if ((object)this.RegNumber != null)
            {
                buff.Append("regNumber", this.RegNumber);
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
            if ((object)this.Role != null)
            {
                buff.AppendFormat("role = {0}", this.Role).AppendLine();
            }
            if ((object)this.RegType != null)
            {
                buff.AppendFormat("regType = {0}", this.RegType).AppendLine();
            }
            if ((object)this.RegNumber != null)
            {
                buff.AppendFormat("regNumber = {0}", this.RegNumber).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
