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

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Choice [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class ZoneWidth : XsdBaseReader
    {
        public ZoneWidth(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double StaStart;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double StaEnd;

        public double StartWidth;

        public double? EndWidth;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                this.SetCurrent("Feature", this.NewReader<Feature>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));

            this.StaEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staEnd"));

            this.StartWidth = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("startWidth"));

            this.EndWidth = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("endWidth"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.StaEnd != null)
            {
                buff.Append("staEnd", this.StaEnd);
            }
            if ((object)this.StartWidth != null)
            {
                buff.Append("startWidth", this.StartWidth);
            }
            if ((object)this.EndWidth != null)
            {
                buff.Append("endWidth", this.EndWidth);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat("staEnd = {0}", this.StaEnd).AppendLine();
            }
            if ((object)this.StartWidth != null)
            {
                buff.AppendFormat("startWidth = {0}", this.StartWidth).AppendLine();
            }
            if ((object)this.EndWidth != null)
            {
                buff.AppendFormat("endWidth = {0}", this.EndWidth).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
