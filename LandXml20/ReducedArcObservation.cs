#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// As we discussed this element is used to provide measured information for calculating boundary arcs. The definition information required is quite different to the curve element
    /// </summary>

    public class ReducedArcObservation : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Purpose = XsdConverter.Instance.Convert<PurposeType?>(
                    attributes.GetSafe("purpose"));



            this.SetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID"));



            this.TargetSetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("targetSetupID"));



            this.SetID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setID"));



            this.ChordAzimuth = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("chordAzimuth"));



            this.Radius = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("radius"));



            this.Length = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("length"));



            this.Rot = XsdConverter.Instance.Convert<Clockwise>(
                    attributes.GetSafe("rot"));



            this.EquipmentUsed = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("equipmentUsed"));



            this.ArcAzimuthAccuracy = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("arcAzimuthAccuracy"));



            this.ArcLengthAccuracy = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("arcLengthAccuracy"));



            this.Date = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("date"));



            this.ArcType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("arcType"));



            this.AdoptedSurvey = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adoptedSurvey"));



            this.LengthAccClass = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("lengthAccClass"));



            this.AzimuthAccClass = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("azimuthAccClass"));



            this.AzimuthAdoptionFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("azimuthAdoptionFactor"));



            this.LengthAdoptionFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("lengthAdoptionFactor"));



            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));



            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));



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
            if ((object)this.SetID != null)
            {
                buff.AppendFormat("setID = {0}", this.SetID).AppendLine();
            }
            if ((object)this.ChordAzimuth != null)
            {
                buff.AppendFormat("chordAzimuth = {0}", this.ChordAzimuth).AppendLine();
            }
            if ((object)this.Radius != null)
            {
                buff.AppendFormat("radius = {0}", this.Radius).AppendLine();
            }
            if ((object)this.Length != null)
            {
                buff.AppendFormat("length = {0}", this.Length).AppendLine();
            }
            if ((object)this.Rot != null)
            {
                buff.AppendFormat("rot = {0}", this.Rot).AppendLine();
            }
            if ((object)this.EquipmentUsed != null)
            {
                buff.AppendFormat("equipmentUsed = {0}", this.EquipmentUsed).AppendLine();
            }
            if ((object)this.ArcAzimuthAccuracy != null)
            {
                buff.AppendFormat("arcAzimuthAccuracy = {0}", this.ArcAzimuthAccuracy).AppendLine();
            }
            if ((object)this.ArcLengthAccuracy != null)
            {
                buff.AppendFormat("arcLengthAccuracy = {0}", this.ArcLengthAccuracy).AppendLine();
            }
            if ((object)this.Date != null)
            {
                buff.AppendFormat("date = {0}", this.Date).AppendLine();
            }
            if ((object)this.ArcType != null)
            {
                buff.AppendFormat("arcType = {0}", this.ArcType).AppendLine();
            }
            if ((object)this.AdoptedSurvey != null)
            {
                buff.AppendFormat("adoptedSurvey = {0}", this.AdoptedSurvey).AppendLine();
            }
            if ((object)this.LengthAccClass != null)
            {
                buff.AppendFormat("lengthAccClass = {0}", this.LengthAccClass).AppendLine();
            }
            if ((object)this.AzimuthAccClass != null)
            {
                buff.AppendFormat("azimuthAccClass = {0}", this.AzimuthAccClass).AppendLine();
            }
            if ((object)this.AzimuthAdoptionFactor != null)
            {
                buff.AppendFormat("azimuthAdoptionFactor = {0}", this.AzimuthAdoptionFactor).AppendLine();
            }
            if ((object)this.LengthAdoptionFactor != null)
            {
                buff.AppendFormat("lengthAdoptionFactor = {0}", this.LengthAdoptionFactor).AppendLine();
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
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Purpose != null)
            {
                buff.AppendFormat(" purpose=\"{0}\"", this.Purpose);
            }
            if ((object)this.SetupID != null)
            {
                buff.AppendFormat(" setupID=\"{0}\"", this.SetupID);
            }
            if ((object)this.TargetSetupID != null)
            {
                buff.AppendFormat(" targetSetupID=\"{0}\"", this.TargetSetupID);
            }
            if ((object)this.SetID != null)
            {
                buff.AppendFormat(" setID=\"{0}\"", this.SetID);
            }
            if ((object)this.ChordAzimuth != null)
            {
                buff.AppendFormat(" chordAzimuth=\"{0}\"", this.ChordAzimuth);
            }
            if ((object)this.Radius != null)
            {
                buff.AppendFormat(" radius=\"{0}\"", this.Radius);
            }
            if ((object)this.Length != null)
            {
                buff.AppendFormat(" length=\"{0}\"", this.Length);
            }
            if ((object)this.Rot != null)
            {
                buff.AppendFormat(" rot=\"{0}\"", this.Rot);
            }
            if ((object)this.EquipmentUsed != null)
            {
                buff.AppendFormat(" equipmentUsed=\"{0}\"", this.EquipmentUsed);
            }
            if ((object)this.ArcAzimuthAccuracy != null)
            {
                buff.AppendFormat(" arcAzimuthAccuracy=\"{0}\"", this.ArcAzimuthAccuracy);
            }
            if ((object)this.ArcLengthAccuracy != null)
            {
                buff.AppendFormat(" arcLengthAccuracy=\"{0}\"", this.ArcLengthAccuracy);
            }
            if ((object)this.Date != null)
            {
                buff.AppendFormat(" date=\"{0}\"", this.Date);
            }
            if ((object)this.ArcType != null)
            {
                buff.AppendFormat(" arcType=\"{0}\"", this.ArcType);
            }
            if ((object)this.AdoptedSurvey != null)
            {
                buff.AppendFormat(" adoptedSurvey=\"{0}\"", this.AdoptedSurvey);
            }
            if ((object)this.LengthAccClass != null)
            {
                buff.AppendFormat(" lengthAccClass=\"{0}\"", this.LengthAccClass);
            }
            if ((object)this.AzimuthAccClass != null)
            {
                buff.AppendFormat(" azimuthAccClass=\"{0}\"", this.AzimuthAccClass);
            }
            if ((object)this.AzimuthAdoptionFactor != null)
            {
                buff.AppendFormat(" azimuthAdoptionFactor=\"{0}\"", this.AzimuthAdoptionFactor);
            }
            if ((object)this.LengthAdoptionFactor != null)
            {
                buff.AppendFormat(" lengthAdoptionFactor=\"{0}\"", this.LengthAdoptionFactor);
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat(" oID=\"{0}\"", this.OID);
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.AppendFormat(" coordGeomRefs=\"{0}\"", this.CoordGeomRefs);
            }
            if ((object)this.AlignRef != null)
            {
                buff.AppendFormat(" alignRef=\"{0}\"", this.AlignRef);
            }
            if ((object)this.AlignStationName != null)
            {
                buff.AppendFormat(" alignStationName=\"{0}\"", this.AlignStationName);
            }
            if ((object)this.AlignOffset != null)
            {
                buff.AppendFormat(" alignOffset=\"{0}\"", this.AlignOffset);
            }


            return buff.ToString();
        }

        /// <summary>
        /// Used by many of the Survey elements
        /// </summary>

        public PurposeType? Purpose;

        public string SetupID;

        public string TargetSetupID;

        public string SetID;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double ChordAzimuth;

        public double Radius;

        public double Length;

        public Clockwise Rot;
        /// <summary>
        /// This gives a list of equipment used for the observation this list of equipment is used to estimate the accuracy of the observation.. 
        /// </summary>

        public string EquipmentUsed;

        public double? ArcAzimuthAccuracy;

        public double? ArcLengthAccuracy;

        public DateTime? Date;

        public string ArcType;

        public string AdoptedSurvey;

        public string LengthAccClass;

        public string AzimuthAccClass;

        public double? AzimuthAdoptionFactor;

        public double? LengthAdoptionFactor;

        public string Name;

        public string Desc;

        public StateType? State;

        public string OID;
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


    }
}
#endif

