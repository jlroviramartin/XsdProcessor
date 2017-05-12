#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// An "infinite" spiral radius is denoted by the value "INF". 
    /// This conforms to XML Schema which defines infinity as "INF" or "-INF" for all numeric datatypes 
    /// Sequence [1, 1]
    ///     Start [1, 1]
    ///     PI [1, 1]
    ///     End [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class Spiral : XsdBaseReader
    {
        public Spiral(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public double Length;

        public double RadiusEnd;

        public double RadiusStart;

        public Clockwise Rot;

        public SpiralType SpiType;

        public double? Chord;

        public double? Constant;

        public string Desc;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
        /// </summary>

        public double? DirEnd;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
        /// </summary>

        public double? DirStart;

        public string Name;
        /// <summary>
        /// Represents a normalized angular value in the specified Angular units.
        /// </summary>

        public double? Theta;

        public double? TotalY;

        public double? TotalX;

        public double? StaStart;

        public StateType? State;

        public double? TanLong;

        public double? TanShort;

        public string OID;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("End"))
            {
                return Tuple.Create("End", this.NewReader<PointType>());
            }
            if (name.EqualsIgnoreCase("PI"))
            {
                return Tuple.Create("PI", this.NewReader<PointType>());
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

            this.Length = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("length"));

            this.RadiusEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("radiusEnd"));

            this.RadiusStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("radiusStart"));

            this.Rot = XsdConverter.Instance.Convert<Clockwise>(
                    attributes.GetSafe("rot"));

            this.SpiType = XsdConverter.Instance.Convert<SpiralType>(
                    attributes.GetSafe("spiType"));

            this.Chord = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("chord"));

            this.Constant = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("constant"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.DirEnd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("dirEnd"));

            this.DirStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("dirStart"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Theta = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("theta"));

            this.TotalY = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("totalY"));

            this.TotalX = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("totalX"));

            this.StaStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staStart"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.TanLong = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("tanLong"));

            this.TanShort = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("tanShort"));

            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Length != null)
            {
                buff.Append("length", this.Length);
            }
            if ((object)this.RadiusEnd != null)
            {
                buff.Append("radiusEnd", this.RadiusEnd);
            }
            if ((object)this.RadiusStart != null)
            {
                buff.Append("radiusStart", this.RadiusStart);
            }
            if ((object)this.Rot != null)
            {
                buff.Append("rot", this.Rot);
            }
            if ((object)this.SpiType != null)
            {
                buff.Append("spiType", this.SpiType);
            }
            if ((object)this.Chord != null)
            {
                buff.Append("chord", this.Chord);
            }
            if ((object)this.Constant != null)
            {
                buff.Append("constant", this.Constant);
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
            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Theta != null)
            {
                buff.Append("theta", this.Theta);
            }
            if ((object)this.TotalY != null)
            {
                buff.Append("totalY", this.TotalY);
            }
            if ((object)this.TotalX != null)
            {
                buff.Append("totalX", this.TotalX);
            }
            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.TanLong != null)
            {
                buff.Append("tanLong", this.TanLong);
            }
            if ((object)this.TanShort != null)
            {
                buff.Append("tanShort", this.TanShort);
            }
            if ((object)this.OID != null)
            {
                buff.Append("oID", this.OID);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Length != null)
            {
                buff.AppendFormat("length = {0}", this.Length).AppendLine();
            }
            if ((object)this.RadiusEnd != null)
            {
                buff.AppendFormat("radiusEnd = {0}", this.RadiusEnd).AppendLine();
            }
            if ((object)this.RadiusStart != null)
            {
                buff.AppendFormat("radiusStart = {0}", this.RadiusStart).AppendLine();
            }
            if ((object)this.Rot != null)
            {
                buff.AppendFormat("rot = {0}", this.Rot).AppendLine();
            }
            if ((object)this.SpiType != null)
            {
                buff.AppendFormat("spiType = {0}", this.SpiType).AppendLine();
            }
            if ((object)this.Chord != null)
            {
                buff.AppendFormat("chord = {0}", this.Chord).AppendLine();
            }
            if ((object)this.Constant != null)
            {
                buff.AppendFormat("constant = {0}", this.Constant).AppendLine();
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
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Theta != null)
            {
                buff.AppendFormat("theta = {0}", this.Theta).AppendLine();
            }
            if ((object)this.TotalY != null)
            {
                buff.AppendFormat("totalY = {0}", this.TotalY).AppendLine();
            }
            if ((object)this.TotalX != null)
            {
                buff.AppendFormat("totalX = {0}", this.TotalX).AppendLine();
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.TanLong != null)
            {
                buff.AppendFormat("tanLong = {0}", this.TanLong).AppendLine();
            }
            if ((object)this.TanShort != null)
            {
                buff.AppendFormat("tanShort = {0}", this.TanShort).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

