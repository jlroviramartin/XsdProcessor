#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Choice [0, *]
    ///     Classification [0, *]
    ///     Lanes [0, *]
    ///     Roadside [0, *]
    ///     Speeds [0, *]
    ///     NoPassingZone [0, *]
    ///     TrafficVolume [0, *]
    ///     CrashData [0, *]
    ///     DecisionSightDistance [0, *]
    ///     BridgeElement [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Roadway : XsdBaseReader
    {
        public Roadway(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.AlignmentRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("alignmentRefs"));

            this.GradeModelRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("gradeModelRefs"));

            this.StaStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staStart"));

            this.StaEnd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staEnd"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.RoadTerrain = XsdConverter.Instance.Convert<RoadTerrainType?>(
                    attributes.GetSafe("roadTerrain"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.AlignmentRefs != null)
            {
                buff.AppendFormat("alignmentRefs = {0}", this.AlignmentRefs).AppendLine();
            }
            if ((object)this.GradeModelRefs != null)
            {
                buff.AppendFormat("gradeModelRefs = {0}", this.GradeModelRefs).AppendLine();
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat("staEnd = {0}", this.StaEnd).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.RoadTerrain != null)
            {
                buff.AppendFormat("roadTerrain = {0}", this.RoadTerrain).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.AlignmentRefs != null)
            {
                buff.Append("alignmentRefs", this.AlignmentRefs);
            }
            if ((object)this.GradeModelRefs != null)
            {
                buff.Append("gradeModelRefs", this.GradeModelRefs);
            }
            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.StaEnd != null)
            {
                buff.Append("staEnd", this.StaEnd);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.RoadTerrain != null)
            {
                buff.Append("roadTerrain", this.RoadTerrain);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }

            return buff.ToString();
        }

        public string Name;
        /// <summary>
        /// A list of reference names values refering to one or more Alignment.name attributes.
        /// </summary>

        public IList<string> AlignmentRefs;
        /// <summary>
        /// A list of reference names values refering to one or more GradeModel.name attributes.
        /// </summary>

        public IList<string> GradeModelRefs;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? StaStart;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? StaEnd;

        public string Desc;

        public RoadTerrainType? RoadTerrain;

        public StateType? State;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("BridgeElement"))
            {
                return Tuple.Create("BridgeElement", this.NewReader<BridgeElement>());
            }
            if (name.EqualsIgnoreCase("DecisionSightDistance"))
            {
                return Tuple.Create("DecisionSightDistance", this.NewReader<DecisionSightDistance>());
            }
            if (name.EqualsIgnoreCase("CrashData"))
            {
                return Tuple.Create("CrashData", this.NewReader<CrashData>());
            }
            if (name.EqualsIgnoreCase("TrafficVolume"))
            {
                return Tuple.Create("TrafficVolume", this.NewReader<TrafficVolume>());
            }
            if (name.EqualsIgnoreCase("NoPassingZone"))
            {
                return Tuple.Create("NoPassingZone", this.NewReader<NoPassingZone>());
            }
            if (name.EqualsIgnoreCase("Speeds"))
            {
                return Tuple.Create("Speeds", this.NewReader<Speeds>());
            }
            if (name.EqualsIgnoreCase("Roadside"))
            {
                return Tuple.Create("Roadside", this.NewReader<Roadside>());
            }
            if (name.EqualsIgnoreCase("Lanes"))
            {
                return Tuple.Create("Lanes", this.NewReader<Lanes>());
            }
            if (name.EqualsIgnoreCase("Classification"))
            {
                return Tuple.Create("Classification", this.NewReader<Classification>());
            }

            return null;
        }
    }
}
#endif

