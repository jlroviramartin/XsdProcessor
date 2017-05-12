#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// This has been modified to include new fields such as accuracy, date, class and adoption. I've added in bearing (azimuth is in terms of true north whereas bearing is the projection north) 
    ///  - maybe this doesn't matter, may need to discuss
    /// Sequence [1, 1]
    ///     TargetPoint [0, 1]
    ///     OffsetVals [0, 1]
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class ReducedObservation : XsdBaseReader
    {
        public ReducedObservation(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Purpose = XsdConverter.Instance.Convert<PurposeType?>(
                    attributes.GetSafe("purpose"));

            this.SetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID"));

            this.TargetSetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("targetSetupID"));

            this.TargetSetup2ID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("targetSetup2ID"));

            this.SetID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setID"));

            this.TargetHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("targetHeight"));

            this.Azimuth = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("azimuth"));

            this.HorizDistance = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("horizDistance"));

            this.VertDistance = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("vertDistance"));

            this.HorizAngle = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("horizAngle"));

            this.SlopeDistance = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("slopeDistance"));

            this.ZenithAngle = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("zenithAngle"));

            this.EquipmentUsed = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("equipmentUsed"));

            this.AzimuthAccuracy = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("azimuthAccuracy"));

            this.DistanceAccuracy = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("distanceAccuracy"));

            this.AngleAccuracy = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("angleAccuracy"));

            this.Date = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("date"));

            this.DistanceType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("distanceType"));

            this.AzimuthType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("azimuthType"));

            this.AngleType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("angleType"));

            this.AdoptedAzimuthSurvey = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adoptedAzimuthSurvey"));

            this.AdoptedDistanceSurvey = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adoptedDistanceSurvey"));

            this.AdoptedAngleSurvey = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adoptedAngleSurvey"));

            this.DistanceAccClass = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("distanceAccClass"));

            this.AzimuthAccClass = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("azimuthAccClass"));

            this.AngleAccClass = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("angleAccClass"));

            this.AzimuthAdoptionFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("azimuthAdoptionFactor"));

            this.DistanceAdoptionFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("distanceAdoptionFactor"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));

            this.MSLDistance = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("MSLDistance"));

            this.SpherDistance = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("spherDistance"));

            this.CoordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("coordGeomRefs"));

            this.AlignRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("alignRef"));

            this.AlignStationName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("alignStationName"));

            this.AlignOffset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("alignOffset"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Purpose != null)
            {
                buff.AppendFormat("purpose = {0}", this.Purpose).AppendLine();
            }
            if ((object)this.SetupID != null)
            {
                buff.AppendFormat("setupID = {0}", this.SetupID).AppendLine();
            }
            if ((object)this.TargetSetupID != null)
            {
                buff.AppendFormat("targetSetupID = {0}", this.TargetSetupID).AppendLine();
            }
            if ((object)this.TargetSetup2ID != null)
            {
                buff.AppendFormat("targetSetup2ID = {0}", this.TargetSetup2ID).AppendLine();
            }
            if ((object)this.SetID != null)
            {
                buff.AppendFormat("setID = {0}", this.SetID).AppendLine();
            }
            if ((object)this.TargetHeight != null)
            {
                buff.AppendFormat("targetHeight = {0}", this.TargetHeight).AppendLine();
            }
            if ((object)this.Azimuth != null)
            {
                buff.AppendFormat("azimuth = {0}", this.Azimuth).AppendLine();
            }
            if ((object)this.HorizDistance != null)
            {
                buff.AppendFormat("horizDistance = {0}", this.HorizDistance).AppendLine();
            }
            if ((object)this.VertDistance != null)
            {
                buff.AppendFormat("vertDistance = {0}", this.VertDistance).AppendLine();
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
            if ((object)this.EquipmentUsed != null)
            {
                buff.AppendFormat("equipmentUsed = {0}", this.EquipmentUsed).AppendLine();
            }
            if ((object)this.AzimuthAccuracy != null)
            {
                buff.AppendFormat("azimuthAccuracy = {0}", this.AzimuthAccuracy).AppendLine();
            }
            if ((object)this.DistanceAccuracy != null)
            {
                buff.AppendFormat("distanceAccuracy = {0}", this.DistanceAccuracy).AppendLine();
            }
            if ((object)this.AngleAccuracy != null)
            {
                buff.AppendFormat("angleAccuracy = {0}", this.AngleAccuracy).AppendLine();
            }
            if ((object)this.Date != null)
            {
                buff.AppendFormat("date = {0}", this.Date).AppendLine();
            }
            if ((object)this.DistanceType != null)
            {
                buff.AppendFormat("distanceType = {0}", this.DistanceType).AppendLine();
            }
            if ((object)this.AzimuthType != null)
            {
                buff.AppendFormat("azimuthType = {0}", this.AzimuthType).AppendLine();
            }
            if ((object)this.AngleType != null)
            {
                buff.AppendFormat("angleType = {0}", this.AngleType).AppendLine();
            }
            if ((object)this.AdoptedAzimuthSurvey != null)
            {
                buff.AppendFormat("adoptedAzimuthSurvey = {0}", this.AdoptedAzimuthSurvey).AppendLine();
            }
            if ((object)this.AdoptedDistanceSurvey != null)
            {
                buff.AppendFormat("adoptedDistanceSurvey = {0}", this.AdoptedDistanceSurvey).AppendLine();
            }
            if ((object)this.AdoptedAngleSurvey != null)
            {
                buff.AppendFormat("adoptedAngleSurvey = {0}", this.AdoptedAngleSurvey).AppendLine();
            }
            if ((object)this.DistanceAccClass != null)
            {
                buff.AppendFormat("distanceAccClass = {0}", this.DistanceAccClass).AppendLine();
            }
            if ((object)this.AzimuthAccClass != null)
            {
                buff.AppendFormat("azimuthAccClass = {0}", this.AzimuthAccClass).AppendLine();
            }
            if ((object)this.AngleAccClass != null)
            {
                buff.AppendFormat("angleAccClass = {0}", this.AngleAccClass).AppendLine();
            }
            if ((object)this.AzimuthAdoptionFactor != null)
            {
                buff.AppendFormat("azimuthAdoptionFactor = {0}", this.AzimuthAdoptionFactor).AppendLine();
            }
            if ((object)this.DistanceAdoptionFactor != null)
            {
                buff.AppendFormat("distanceAdoptionFactor = {0}", this.DistanceAdoptionFactor).AppendLine();
            }
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
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.MSLDistance != null)
            {
                buff.AppendFormat("MSLDistance = {0}", this.MSLDistance).AppendLine();
            }
            if ((object)this.SpherDistance != null)
            {
                buff.AppendFormat("spherDistance = {0}", this.SpherDistance).AppendLine();
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.AppendFormat("coordGeomRefs = {0}", this.CoordGeomRefs).AppendLine();
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

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Purpose != null)
            {
                buff.Append("purpose", this.Purpose);
            }
            if ((object)this.SetupID != null)
            {
                buff.Append("setupID", this.SetupID);
            }
            if ((object)this.TargetSetupID != null)
            {
                buff.Append("targetSetupID", this.TargetSetupID);
            }
            if ((object)this.TargetSetup2ID != null)
            {
                buff.Append("targetSetup2ID", this.TargetSetup2ID);
            }
            if ((object)this.SetID != null)
            {
                buff.Append("setID", this.SetID);
            }
            if ((object)this.TargetHeight != null)
            {
                buff.Append("targetHeight", this.TargetHeight);
            }
            if ((object)this.Azimuth != null)
            {
                buff.Append("azimuth", this.Azimuth);
            }
            if ((object)this.HorizDistance != null)
            {
                buff.Append("horizDistance", this.HorizDistance);
            }
            if ((object)this.VertDistance != null)
            {
                buff.Append("vertDistance", this.VertDistance);
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
            if ((object)this.EquipmentUsed != null)
            {
                buff.Append("equipmentUsed", this.EquipmentUsed);
            }
            if ((object)this.AzimuthAccuracy != null)
            {
                buff.Append("azimuthAccuracy", this.AzimuthAccuracy);
            }
            if ((object)this.DistanceAccuracy != null)
            {
                buff.Append("distanceAccuracy", this.DistanceAccuracy);
            }
            if ((object)this.AngleAccuracy != null)
            {
                buff.Append("angleAccuracy", this.AngleAccuracy);
            }
            if ((object)this.Date != null)
            {
                buff.Append("date", this.Date);
            }
            if ((object)this.DistanceType != null)
            {
                buff.Append("distanceType", this.DistanceType);
            }
            if ((object)this.AzimuthType != null)
            {
                buff.Append("azimuthType", this.AzimuthType);
            }
            if ((object)this.AngleType != null)
            {
                buff.Append("angleType", this.AngleType);
            }
            if ((object)this.AdoptedAzimuthSurvey != null)
            {
                buff.Append("adoptedAzimuthSurvey", this.AdoptedAzimuthSurvey);
            }
            if ((object)this.AdoptedDistanceSurvey != null)
            {
                buff.Append("adoptedDistanceSurvey", this.AdoptedDistanceSurvey);
            }
            if ((object)this.AdoptedAngleSurvey != null)
            {
                buff.Append("adoptedAngleSurvey", this.AdoptedAngleSurvey);
            }
            if ((object)this.DistanceAccClass != null)
            {
                buff.Append("distanceAccClass", this.DistanceAccClass);
            }
            if ((object)this.AzimuthAccClass != null)
            {
                buff.Append("azimuthAccClass", this.AzimuthAccClass);
            }
            if ((object)this.AngleAccClass != null)
            {
                buff.Append("angleAccClass", this.AngleAccClass);
            }
            if ((object)this.AzimuthAdoptionFactor != null)
            {
                buff.Append("azimuthAdoptionFactor", this.AzimuthAdoptionFactor);
            }
            if ((object)this.DistanceAdoptionFactor != null)
            {
                buff.Append("distanceAdoptionFactor", this.DistanceAdoptionFactor);
            }
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
            if ((object)this.OID != null)
            {
                buff.Append("oID", this.OID);
            }
            if ((object)this.MSLDistance != null)
            {
                buff.Append("MSLDistance", this.MSLDistance);
            }
            if ((object)this.SpherDistance != null)
            {
                buff.Append("spherDistance", this.SpherDistance);
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.Append("coordGeomRefs", this.CoordGeomRefs);
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

            return buff.ToString();
        }

        /// <summary>
        /// Used by many of the Survey elements
        /// </summary>

        public PurposeType? Purpose;

        public string SetupID;

        public string TargetSetupID;

        public string TargetSetup2ID;

        public string SetID;

        public double? TargetHeight;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? Azimuth;

        public double? HorizDistance;

        public double? VertDistance;
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
        /// <summary>
        /// This gives a list of equipment used for the observation this list of equipment is used to estimate the accuracy of the observation.. 
        /// </summary>

        public string EquipmentUsed;

        public double? AzimuthAccuracy;

        public double? DistanceAccuracy;

        public double? AngleAccuracy;

        public DateTime? Date;
        /// <summary>
        /// This is a list of defined observation types, different jurisdictions may have a list defined by regulation can be defined by the jurisdiction. 
        /// </summary>

        public string DistanceType;
        /// <summary>
        /// This is a list of defined observation types, different jurisdictions may have a list defined by regulation can be defined by the jurisdiction. 
        /// </summary>

        public string AzimuthType;
        /// <summary>
        /// This is a list of defined observation types, different jurisdictions may have a list defined by regulation can be defined by the jurisdiction. 
        /// </summary>

        public string AngleType;

        public string AdoptedAzimuthSurvey;

        public string AdoptedDistanceSurvey;

        public string AdoptedAngleSurvey;

        public string DistanceAccClass;

        public string AzimuthAccClass;

        public string AngleAccClass;

        public double? AzimuthAdoptionFactor;

        public double? DistanceAdoptionFactor;

        public string Name;

        public string Desc;

        public StateType? State;

        public string OID;

        public string MSLDistance;

        public string SpherDistance;
        /// <summary>
        /// A list of reference names values refering to one or more CoordGeom.name attributes.
        /// </summary>

        public IList<string> CoordGeomRefs;
        /// <summary>
        /// A reference name value referring to Alignment.name attribute.
        /// </summary>

        public string AlignRef;

        public string AlignStationName;
        /// <summary>
        /// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
        /// </summary>

        public double? AlignOffset;


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

