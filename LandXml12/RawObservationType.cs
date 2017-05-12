#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Sequence [1, 1]
    ///     TargetPoint [1, 1]
    ///     OffsetVals [0, 1]
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class RawObservationType : XsdBaseReader
    {
        public RawObservationType(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.SetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID"));

            this.TargetSetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("targetSetupID"));

            this.SetID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setID"));

            this.Purpose = XsdConverter.Instance.Convert<PurposeType?>(
                    attributes.GetSafe("purpose"));

            this.TargetHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("targetHeight"));

            this.HorizAngle = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("horizAngle"));

            this.SlopeDistance = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("slopeDistance"));

            this.ZenithAngle = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("zenithAngle"));

            this.HorizDistance = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("horizDistance"));

            this.VertDistance = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("vertDistance"));

            this.Azimuth = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("azimuth"));

            this.Unused = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("unused"));

            this.DirectFace = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("directFace"));

            this.CoordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("coordGeomRefs"));

            this.TimeStamp = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("timeStamp"));

            this.AlignRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("alignRef"));

            this.AlignStationName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("alignStationName"));

            this.AlignOffset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("alignOffset"));

            this.UpperStadia = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("upperStadia"));

            this.Rod = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("rod"));

            this.LowerStadia = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("lowerStadia"));

            this.CirclePositionSet = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("circlePositionSet"));

            this.Status = XsdConverter.Instance.Convert<ObservationStatusType?>(
                    attributes.GetSafe("status"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.SetupID != null)
            {
                buff.AppendFormat("setupID = {0}", this.SetupID).AppendLine();
            }
            if ((object)this.TargetSetupID != null)
            {
                buff.AppendFormat("targetSetupID = {0}", this.TargetSetupID).AppendLine();
            }
            if ((object)this.SetID != null)
            {
                buff.AppendFormat("setID = {0}", this.SetID).AppendLine();
            }
            if ((object)this.Purpose != null)
            {
                buff.AppendFormat("purpose = {0}", this.Purpose).AppendLine();
            }
            if ((object)this.TargetHeight != null)
            {
                buff.AppendFormat("targetHeight = {0}", this.TargetHeight).AppendLine();
            }
            if ((object)this.HorizAngle != null)
            {
                buff.AppendFormat("horizAngle = {0}", this.HorizAngle).AppendLine();
            }
            if ((object)this.SlopeDistance != null)
            {
                buff.AppendFormat("slopeDistance = {0}", this.SlopeDistance).AppendLine();
            }
            if ((object)this.ZenithAngle != null)
            {
                buff.AppendFormat("zenithAngle = {0}", this.ZenithAngle).AppendLine();
            }
            if ((object)this.HorizDistance != null)
            {
                buff.AppendFormat("horizDistance = {0}", this.HorizDistance).AppendLine();
            }
            if ((object)this.VertDistance != null)
            {
                buff.AppendFormat("vertDistance = {0}", this.VertDistance).AppendLine();
            }
            if ((object)this.Azimuth != null)
            {
                buff.AppendFormat("azimuth = {0}", this.Azimuth).AppendLine();
            }
            if ((object)this.Unused != null)
            {
                buff.AppendFormat("unused = {0}", this.Unused).AppendLine();
            }
            if ((object)this.DirectFace != null)
            {
                buff.AppendFormat("directFace = {0}", this.DirectFace).AppendLine();
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.AppendFormat("coordGeomRefs = {0}", this.CoordGeomRefs).AppendLine();
            }
            if ((object)this.TimeStamp != null)
            {
                buff.AppendFormat("timeStamp = {0}", this.TimeStamp).AppendLine();
            }
            if ((object)this.AlignRef != null)
            {
                buff.AppendFormat("alignRef = {0}", this.AlignRef).AppendLine();
            }
            if ((object)this.AlignStationName != null)
            {
                buff.AppendFormat("alignStationName = {0}", this.AlignStationName).AppendLine();
            }
            if ((object)this.AlignOffset != null)
            {
                buff.AppendFormat("alignOffset = {0}", this.AlignOffset).AppendLine();
            }
            if ((object)this.UpperStadia != null)
            {
                buff.AppendFormat("upperStadia = {0}", this.UpperStadia).AppendLine();
            }
            if ((object)this.Rod != null)
            {
                buff.AppendFormat("rod = {0}", this.Rod).AppendLine();
            }
            if ((object)this.LowerStadia != null)
            {
                buff.AppendFormat("lowerStadia = {0}", this.LowerStadia).AppendLine();
            }
            if ((object)this.CirclePositionSet != null)
            {
                buff.AppendFormat("circlePositionSet = {0}", this.CirclePositionSet).AppendLine();
            }
            if ((object)this.Status != null)
            {
                buff.AppendFormat("status = {0}", this.Status).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.SetupID != null)
            {
                buff.Append("setupID", this.SetupID);
            }
            if ((object)this.TargetSetupID != null)
            {
                buff.Append("targetSetupID", this.TargetSetupID);
            }
            if ((object)this.SetID != null)
            {
                buff.Append("setID", this.SetID);
            }
            if ((object)this.Purpose != null)
            {
                buff.Append("purpose", this.Purpose);
            }
            if ((object)this.TargetHeight != null)
            {
                buff.Append("targetHeight", this.TargetHeight);
            }
            if ((object)this.HorizAngle != null)
            {
                buff.Append("horizAngle", this.HorizAngle);
            }
            if ((object)this.SlopeDistance != null)
            {
                buff.Append("slopeDistance", this.SlopeDistance);
            }
            if ((object)this.ZenithAngle != null)
            {
                buff.Append("zenithAngle", this.ZenithAngle);
            }
            if ((object)this.HorizDistance != null)
            {
                buff.Append("horizDistance", this.HorizDistance);
            }
            if ((object)this.VertDistance != null)
            {
                buff.Append("vertDistance", this.VertDistance);
            }
            if ((object)this.Azimuth != null)
            {
                buff.Append("azimuth", this.Azimuth);
            }
            if ((object)this.Unused != null)
            {
                buff.Append("unused", this.Unused);
            }
            if ((object)this.DirectFace != null)
            {
                buff.Append("directFace", this.DirectFace);
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.Append("coordGeomRefs", this.CoordGeomRefs);
            }
            if ((object)this.TimeStamp != null)
            {
                buff.Append("timeStamp", this.TimeStamp);
            }
            if ((object)this.AlignRef != null)
            {
                buff.Append("alignRef", this.AlignRef);
            }
            if ((object)this.AlignStationName != null)
            {
                buff.Append("alignStationName", this.AlignStationName);
            }
            if ((object)this.AlignOffset != null)
            {
                buff.Append("alignOffset", this.AlignOffset);
            }
            if ((object)this.UpperStadia != null)
            {
                buff.Append("upperStadia", this.UpperStadia);
            }
            if ((object)this.Rod != null)
            {
                buff.Append("rod", this.Rod);
            }
            if ((object)this.LowerStadia != null)
            {
                buff.Append("lowerStadia", this.LowerStadia);
            }
            if ((object)this.CirclePositionSet != null)
            {
                buff.Append("circlePositionSet", this.CirclePositionSet);
            }
            if ((object)this.Status != null)
            {
                buff.Append("status", this.Status);
            }

            return buff.ToString();
        }

        public string SetupID;

        public string TargetSetupID;

        public string SetID;
        /// <summary>
        /// Used by many of the Survey elements
        /// </summary>

        public PurposeType? Purpose;

        public double? TargetHeight;
        /// <summary>
        /// Represents a normalized angular value in the specified Angular units. Assume 0 degrees = east
        /// </summary>

        public double? HorizAngle;

        public double? SlopeDistance;
        /// <summary>
        /// Represents zenith angles with the 0 origin as
        ///     straight up and measured in a clockwise direction in the specified
        ///     Angular units.
        /// </summary>

        public double? ZenithAngle;

        public double? HorizDistance;

        public double? VertDistance;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? Azimuth;

        public bool? Unused;

        public bool? DirectFace;
        /// <summary>
        /// A list of reference names values refering to one or more CoordGeom.name attributes.
        /// </summary>

        public IList<string> CoordGeomRefs;

        public DateTime? TimeStamp;
        /// <summary>
        /// A reference name value referring to Alignment.name attribute.
        /// </summary>

        public string AlignRef;

        public string AlignStationName;
        /// <summary>
        /// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
        /// </summary>

        public double? AlignOffset;

        public double? UpperStadia;

        public double? Rod;

        public double? LowerStadia;

        public double? CirclePositionSet;

        public ObservationStatusType? Status;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("FieldNote"))
            {
                return Tuple.Create("FieldNote", this.NewReader<FieldNote>());
            }
            if (name.EqualsIgnoreCase("OffsetVals"))
            {
                return Tuple.Create("OffsetVals", this.NewReader<OffsetVals>());
            }
            if (name.EqualsIgnoreCase("TargetPoint"))
            {
                return Tuple.Create("TargetPoint", this.NewReader<PointType>());
            }

            return null;
        }
    }
}
#endif

