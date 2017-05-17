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
    /// The "ProfSurf" element will typically represent an existing ground surface for a profile. 
    /// It is defined with a space delimited PntList2D of station/elevations pairs. 
    /// Example: "0.000 86.52 6.267 86.89 12.413 87.01 26.020 87.83" 
    /// Note: Gaps in the profile are handled by having 2 or more PntList2D elements.
    /// Sequence [1, 1]
    ///     PntList2D [1, *]
    ///     Feature [0, *]
    /// </summary>

    public class ProfSurf : XsdBaseReader
    {
        public ProfSurf(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public string Desc;

        public StateType? State;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                this.SetCurrent("Feature", this.NewReader<Feature>());
                return true;
            }
            if (name.EqualsIgnoreCase("PntList2D"))
            {
                this.SetCurrent("PntList2D", this.NewReader<IList<double>>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
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
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
