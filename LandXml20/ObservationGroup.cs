#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// All observations to the same point in a group should be averaged together (they have consistant orientation)
    /// </summary>

    public class ObservationGroup : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));



            this.Purpose = XsdConverter.Instance.Convert<PurposeType?>(
                    attributes.GetSafe("purpose"));



            this.SetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID"));



            this.TargetSetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("targetSetupID"));



            this.SetID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setID"));



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

            if ((object)this.Id != null)
            {
                buff.AppendFormat("id = {0}", this.Id).AppendLine();
            }
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

            if ((object)this.Id != null)
            {
                buff.AppendFormat(" id=\"{0}\"", this.Id);
            }
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

        public string Id;
        /// <summary>
        /// Used by many of the Survey elements
        /// </summary>

        public PurposeType? Purpose;

        public string SetupID;

        public string TargetSetupID;

        public string SetID;
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

