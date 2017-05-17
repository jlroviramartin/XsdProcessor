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

    /// <summary>
    /// Represents a  Point of Vertical Intersection with a space delimited "station elevation" text value
    /// </summary>

    public class PVI : XsdBaseReader
    {
        public PVI(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Desc;

        public IList<double> Content;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            return base.NewReader(namespaceURI, name);
        }

        protected override bool NeedContent { get { return true; } }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Content = XsdConverter.Instance.Convert<IList<double>>(text);
            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }

            if ((object)this.Content != null)
            {
                buff.Append("content", this.Content);
            }
            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }

            if ((object)this.Content != null)
            {
                buff.AppendFormat("content = {0}", this.Content).AppendLine();
            }
            return buff.ToString();
        }

        #endregion
    }
}
#endif
