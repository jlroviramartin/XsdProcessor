#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Sequence [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class CircPipe : XsdBaseReader
    {
        public CircPipe(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public double Diameter;

        public string Desc;

        public double? HazenWilliams;

        public double? Mannings;

        public string Material;

        public double? Thickness;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Diameter = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("diameter"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.HazenWilliams = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("hazenWilliams"));

            this.Mannings = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("mannings"));

            this.Material = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("material"));

            this.Thickness = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("thickness"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Diameter != null)
            {
                buff.Append("diameter", this.Diameter);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.HazenWilliams != null)
            {
                buff.Append("hazenWilliams", this.HazenWilliams);
            }
            if ((object)this.Mannings != null)
            {
                buff.Append("mannings", this.Mannings);
            }
            if ((object)this.Material != null)
            {
                buff.Append("material", this.Material);
            }
            if ((object)this.Thickness != null)
            {
                buff.Append("thickness", this.Thickness);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Diameter != null)
            {
                buff.AppendFormat("diameter = {0}", this.Diameter).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.HazenWilliams != null)
            {
                buff.AppendFormat("hazenWilliams = {0}", this.HazenWilliams).AppendLine();
            }
            if ((object)this.Mannings != null)
            {
                buff.AppendFormat("mannings = {0}", this.Mannings).AppendLine();
            }
            if ((object)this.Material != null)
            {
                buff.AppendFormat("material = {0}", this.Material).AppendLine();
            }
            if ((object)this.Thickness != null)
            {
                buff.AppendFormat("thickness = {0}", this.Thickness).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

