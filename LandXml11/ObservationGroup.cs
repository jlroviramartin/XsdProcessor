#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// All observations to the same point in a group should be averaged together (they have consistant orientation)
    /// Sequence [1, 1]
    ///     TargetPoint [0, 1]
    ///     Choice [0, *]
    ///         Backsight [1, 1]
    ///         RawObservation [1, *]
    ///         ReducedObservation [1, 1]
    ///         RedHorizontalPosition [0, 1]
    ///         ReducedArcObservation [0, 1]
    ///         RedVerticalObservation [0, 1]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class ObservationGroup : XsdBaseReader
    {
        public ObservationGroup(System.Xml.XmlReader reader) : base(reader)
        {
        }

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

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.Append("id", this.Id);
            }
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
            if ((object)this.SetID != null)
            {
                buff.Append("setID", this.SetID);
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.Append("coordGeomRefs", this.CoordGeomRefs);
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
            if (name.EqualsIgnoreCase("RedVerticalObservation"))
            {
                return Tuple.Create("RedVerticalObservation", this.NewReader<RedVerticalObservation>());
            }
            if (name.EqualsIgnoreCase("ReducedArcObservation"))
            {
                return Tuple.Create("ReducedArcObservation", this.NewReader<ReducedArcObservation>());
            }
            if (name.EqualsIgnoreCase("RedHorizontalPosition"))
            {
                return Tuple.Create("RedHorizontalPosition", this.NewReader<RedHorizontalPosition>());
            }
            if (name.EqualsIgnoreCase("ReducedObservation"))
            {
                return Tuple.Create("ReducedObservation", this.NewReader<ReducedObservation>());
            }
            if (name.EqualsIgnoreCase("RawObservation"))
            {
                return Tuple.Create("RawObservation", this.NewReader<RawObservation>());
            }
            if (name.EqualsIgnoreCase("Backsight"))
            {
                return Tuple.Create("Backsight", this.NewReader<Backsight>());
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

