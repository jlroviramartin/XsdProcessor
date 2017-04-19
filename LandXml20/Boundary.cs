#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

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
    /// </summary>

    public class Boundary : XsdBaseObject
    {
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

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

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

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.BndType != null)
            {
                buff.AppendFormat(" bndType=\"{0}\"", this.BndType);
            }
            if ((object)this.EdgeTrim != null)
            {
                buff.AppendFormat(" edgeTrim=\"{0}\"", this.EdgeTrim);
            }
            if ((object)this.Area != null)
            {
                buff.AppendFormat(" area=\"{0}\"", this.Area);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.Coefficient != null)
            {
                buff.AppendFormat(" coefficient=\"{0}\"", this.Coefficient);
            }
            if ((object)this.Cn != null)
            {
                buff.AppendFormat(" cn=\"{0}\"", this.Cn);
            }
            if ((object)this.M != null)
            {
                buff.AppendFormat(" m=\"{0}\"", this.M);
            }


            return buff.ToString();
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


    }
}
#endif

