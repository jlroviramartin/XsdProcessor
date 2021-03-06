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
    /// The boundary region contains a 2D north/east or 3D north/east/elev list of points that define the geometry.
    /// is identified by the "name" attribute.
    /// If the "edgeTrim" attribute is true the faces are trimmed at the boundary edge, otherwise faces are not trimmed
    /// and must exist entirely within the boundary.
    /// coefficient = Hydrology Rational method runoff coefficient (double value between 0.0-1.0) for the land cover type.
    /// cn = Hydrology SCS runoff method CN number (Integer value between 0-100).
    /// m is the material table index for color and texture data.
    /// Sequence [1, 1]
    ///     Choice [1, 1]
    ///         PntList2D [1, 1]
    ///         PntList3D [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class Boundary : XsdBaseReader
    {
        public Boundary(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Surface boundaries can be one of three types: outer, void, island
        /// </summary>

        public SurfBndType BndType;

        public bool? EdgeTrim;

        public double? Area;

        public string Desc;

        public string Name;

        public StateType? State;

        public double? Coefficient;

        public int? Cn;
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

            this.BndType = XsdConverter.Instance.Convert<SurfBndType>(
                    attributes.GetSafe("bndType"));

            this.EdgeTrim = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("edgeTrim"));

            this.Area = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("area"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.Coefficient = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("coefficient"));

            this.Cn = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("cn"));

            this.M = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("m"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.BndType != null)
            {
                buff.Append("bndType", this.BndType);
            }
            if ((object)this.EdgeTrim != null)
            {
                buff.Append("edgeTrim", this.EdgeTrim);
            }
            if ((object)this.Area != null)
            {
                buff.Append("area", this.Area);
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
            if ((object)this.Coefficient != null)
            {
                buff.Append("coefficient", this.Coefficient);
            }
            if ((object)this.Cn != null)
            {
                buff.Append("cn", this.Cn);
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

            if ((object)this.BndType != null)
            {
                buff.AppendFormat("bndType = {0}", this.BndType).AppendLine();
            }
            if ((object)this.EdgeTrim != null)
            {
                buff.AppendFormat("edgeTrim = {0}", this.EdgeTrim).AppendLine();
            }
            if ((object)this.Area != null)
            {
                buff.AppendFormat("area = {0}", this.Area).AppendLine();
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
            if ((object)this.Coefficient != null)
            {
                buff.AppendFormat("coefficient = {0}", this.Coefficient).AppendLine();
            }
            if ((object)this.Cn != null)
            {
                buff.AppendFormat("cn = {0}", this.Cn).AppendLine();
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
