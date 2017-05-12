#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// The boundary region contains a 2D north/east or 3D north/east/elev list of points that define the geometry.
    /// is identified by the "name" attribute.
    /// If the "edgeTrim" attribute is true the faces are trimmed at the boundary edge, otherwise faces are not trimmed
    /// and must exist entirely within the boundary.
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

        public bool EdgeTrim;

        public double? Area;

        public string Desc;

        public string Name;

        public StateType? State;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("PntList3D"))
            {
                return Tuple.Create("PntList3D", this.NewReader<IList<double>>());
            }
            if (name.EqualsIgnoreCase("PntList2D"))
            {
                return Tuple.Create("PntList2D", this.NewReader<IList<double>>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.BndType = XsdConverter.Instance.Convert<SurfBndType>(
                    attributes.GetSafe("bndType"));

            this.EdgeTrim = XsdConverter.Instance.Convert<bool>(
                    attributes.GetSafe("edgeTrim"));

            this.Area = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("area"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

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

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

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

            return buff.ToString();
        }

        #endregion
    }
}
#endif

