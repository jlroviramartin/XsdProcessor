#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// The distance from the Start to the Center provides the radius value.
    /// The rotation attribute "rot" defines whether the arc travels clockwise or counter-clockwise from the Start to End point.
    /// Choice [3, *]
    ///     Start [1, 1]
    ///     Center [1, 1]
    ///     End [1, 1]
    ///     PI [0, 1]
    ///     Feature [0, *]
    /// </summary>

    public class Curve : XsdBaseReader
    {
        public Curve(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public Clockwise Rot;

        public double? Chord;

        public CurveType? CrvType;
        /// <summary>
        /// Represents a normalized angular value in the specified Angular units. Assume 0 degrees = east
        /// </summary>

        public double? Delta;

        public string Desc;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? DirEnd;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? DirStart;

        public double? External;

        public double? Length;

        public double? MidOrd;

        public string Name;

        public double? Radius;

        public double? StaStart;

        public StateType? State;

        public double? Tangent;

        public string OID;

        public string Note;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("PI"))
            {
                return Tuple.Create("PI", this.NewReader<PointType>());
            }
            if (name.EqualsIgnoreCase("End"))
            {
                return Tuple.Create("End", this.NewReader<PointType>());
            }
            if (name.EqualsIgnoreCase("Center"))
            {
                return Tuple.Create("Center", this.NewReader<PointType>());
            }
            if (name.EqualsIgnoreCase("Start"))
            {
                return Tuple.Create("Start", this.NewReader<PointType>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Rot = XsdConverter.Instance.Convert<Clockwise>(
                    attributes.GetSafe("rot"));

            this.Chord = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("chord"));

            this.CrvType = XsdConverter.Instance.Convert<CurveType?>(
                    attributes.GetSafe("crvType"));

            this.Delta = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("delta"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.DirEnd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("dirEnd"));

            this.DirStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("dirStart"));

            this.External = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("external"));

            this.Length = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("length"));

            this.MidOrd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("midOrd"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Radius = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("radius"));

            this.StaStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staStart"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.Tangent = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("tangent"));

            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));

            this.Note = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("note"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Rot != null)
            {
                buff.Append("rot", this.Rot);
            }
            if ((object)this.Chord != null)
            {
                buff.Append("chord", this.Chord);
            }
            if ((object)this.CrvType != null)
            {
                buff.Append("crvType", this.CrvType);
            }
            if ((object)this.Delta != null)
            {
                buff.Append("delta", this.Delta);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.DirEnd != null)
            {
                buff.Append("dirEnd", this.DirEnd);
            }
            if ((object)this.DirStart != null)
            {
                buff.Append("dirStart", this.DirStart);
            }
            if ((object)this.External != null)
            {
                buff.Append("external", this.External);
            }
            if ((object)this.Length != null)
            {
                buff.Append("length", this.Length);
            }
            if ((object)this.MidOrd != null)
            {
                buff.Append("midOrd", this.MidOrd);
            }
            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Radius != null)
            {
                buff.Append("radius", this.Radius);
            }
            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.Tangent != null)
            {
                buff.Append("tangent", this.Tangent);
            }
            if ((object)this.OID != null)
            {
                buff.Append("oID", this.OID);
            }
            if ((object)this.Note != null)
            {
                buff.Append("note", this.Note);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Rot != null)
            {
                buff.AppendFormat("rot = {0}", this.Rot).AppendLine();
            }
            if ((object)this.Chord != null)
            {
                buff.AppendFormat("chord = {0}", this.Chord).AppendLine();
            }
            if ((object)this.CrvType != null)
            {
                buff.AppendFormat("crvType = {0}", this.CrvType).AppendLine();
            }
            if ((object)this.Delta != null)
            {
                buff.AppendFormat("delta = {0}", this.Delta).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.DirEnd != null)
            {
                buff.AppendFormat("dirEnd = {0}", this.DirEnd).AppendLine();
            }
            if ((object)this.DirStart != null)
            {
                buff.AppendFormat("dirStart = {0}", this.DirStart).AppendLine();
            }
            if ((object)this.External != null)
            {
                buff.AppendFormat("external = {0}", this.External).AppendLine();
            }
            if ((object)this.Length != null)
            {
                buff.AppendFormat("length = {0}", this.Length).AppendLine();
            }
            if ((object)this.MidOrd != null)
            {
                buff.AppendFormat("midOrd = {0}", this.MidOrd).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Radius != null)
            {
                buff.AppendFormat("radius = {0}", this.Radius).AppendLine();
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.Tangent != null)
            {
                buff.AppendFormat("tangent = {0}", this.Tangent).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.Note != null)
            {
                buff.AppendFormat("note = {0}", this.Note).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

