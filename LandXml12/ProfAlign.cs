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
    /// The "ProfAlign" element will typically represent a proposed vertical alignment for a profile.
    /// It is defined by a sequential series of any combination of the four "PVI" element types.
    /// Sequence [1, 1]
    ///     Choice [1, *]
    ///         PVI [0, *]
    ///         ParaCurve [0, *]
    ///         UnsymParaCurve [0, *]
    ///         CircCurve [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class ProfAlign : XsdBaseReader
    {
        public ProfAlign(System.Xml.XmlReader reader) : base(reader)
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
            if (name.EqualsIgnoreCase("CircCurve"))
            {
                this.SetCurrent("CircCurve", this.NewReader<CircCurve>());
                return true;
            }
            if (name.EqualsIgnoreCase("UnsymParaCurve"))
            {
                this.SetCurrent("UnsymParaCurve", this.NewReader<UnsymParaCurve>());
                return true;
            }
            if (name.EqualsIgnoreCase("ParaCurve"))
            {
                this.SetCurrent("ParaCurve", this.NewReader<ParaCurve>());
                return true;
            }
            if (name.EqualsIgnoreCase("PVI"))
            {
                this.SetCurrent("PVI", this.NewReader<PVI>());
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
