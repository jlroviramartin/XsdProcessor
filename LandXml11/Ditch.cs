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

    /// <summary>
    /// Choice [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Ditch : XsdBaseReader
    {
        public Ditch(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double StaStart;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double StaEnd;

        public double BottomWidth;

        public DitchBottomShape? BottomShape;

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

            this.BottomWidth = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("bottomWidth"));

            this.BottomShape = XsdConverter.Instance.Convert<DitchBottomShape?>(
                    attributes.GetSafe("bottomShape"));

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
            if ((object)this.BottomWidth != null)
            {
                buff.Append("bottomWidth", this.BottomWidth);
            }
            if ((object)this.BottomShape != null)
            {
                buff.Append("bottomShape", this.BottomShape);
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
            if ((object)this.BottomWidth != null)
            {
                buff.AppendFormat("bottomWidth = {0}", this.BottomWidth).AppendLine();
            }
            if ((object)this.BottomShape != null)
            {
                buff.AppendFormat("bottomShape = {0}", this.BottomShape).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
