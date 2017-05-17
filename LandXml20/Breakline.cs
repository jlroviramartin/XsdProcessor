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
    /// The breakline is defined by a 2D north/east or 3D north/east/elev list of points that define the geometry.
    /// is identified by the "name" attribute.
    /// Sequence [1, 1]
    ///     Choice [1, 1]
    ///         PntList2D [1, 1]
    ///         PntList3D [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class Breakline : XsdBaseReader
    {
        public Breakline(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public BreakLineType? BrkType;

        public string Desc;

        public string Name;

        public StateType? State;
        /// <summary>
        /// A integer based index value to a table item in the material table.
        /// </summary>

        public IList<int?> M;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                this.SetCurrent("Feature", this.NewReader<Feature>());
                return true;
            }
            if (name.EqualsIgnoreCase("PntList3D"))
            {
                this.SetCurrent("PntList3D", this.NewReader<IList<double>>());
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

            this.BrkType = XsdConverter.Instance.Convert<BreakLineType?>(
                    attributes.GetSafe("brkType"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.M = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("m"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.BrkType != null)
            {
                buff.Append("brkType", this.BrkType);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.M != null)
            {
                buff.Append("m", this.M);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            if ((object)this.BrkType != null)
            {
                buff.AppendFormat("brkType = {0}", this.BrkType).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.M != null)
            {
                buff.AppendFormat("m = {0}", this.M).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
