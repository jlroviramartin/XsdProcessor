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

    public class AmendmentItem : XsdBaseReader
    {
        public AmendmentItem(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string ElementName;

        public string OldName;

        public string NewName;

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

            this.ElementName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("elementName"));

            this.OldName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oldName"));

            this.NewName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("newName"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.ElementName != null)
            {
                buff.Append("elementName", this.ElementName);
            }
            if ((object)this.OldName != null)
            {
                buff.Append("oldName", this.OldName);
            }
            if ((object)this.NewName != null)
            {
                buff.Append("newName", this.NewName);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            if ((object)this.ElementName != null)
            {
                buff.AppendFormat("elementName = {0}", this.ElementName).AppendLine();
            }
            if ((object)this.OldName != null)
            {
                buff.AppendFormat("oldName = {0}", this.OldName).AppendLine();
            }
            if ((object)this.NewName != null)
            {
                buff.AppendFormat("newName = {0}", this.NewName).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
