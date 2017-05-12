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
    ///     TrafficControl [0, *]
    ///     Timing [0, *]
    ///     Volume [0, *]
    ///     TurnSpeed [0, *]
    ///     TurnRestriction [0, *]
    ///     Curb [0, *]
    ///     Corner [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Intersection : XsdBaseReader
    {
        public Intersection(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.RoadwayRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("roadwayRef"));

            this.RoadwayPI = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("roadwayPI"));

            this.IntersectingRoadwayRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("intersectingRoadwayRef"));

            this.IntersectRoadwayPI = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("intersectRoadwayPI"));

            this.ContructionType = XsdConverter.Instance.Convert<IntersectionConstructionType?>(
                    attributes.GetSafe("contructionType"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.RoadwayRef != null)
            {
                buff.AppendFormat("roadwayRef = {0}", this.RoadwayRef).AppendLine();
            }
            if ((object)this.RoadwayPI != null)
            {
                buff.AppendFormat("roadwayPI = {0}", this.RoadwayPI).AppendLine();
            }
            if ((object)this.IntersectingRoadwayRef != null)
            {
                buff.AppendFormat("intersectingRoadwayRef = {0}", this.IntersectingRoadwayRef).AppendLine();
            }
            if ((object)this.IntersectRoadwayPI != null)
            {
                buff.AppendFormat("intersectRoadwayPI = {0}", this.IntersectRoadwayPI).AppendLine();
            }
            if ((object)this.ContructionType != null)
            {
                buff.AppendFormat("contructionType = {0}", this.ContructionType).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.RoadwayRef != null)
            {
                buff.Append("roadwayRef", this.RoadwayRef);
            }
            if ((object)this.RoadwayPI != null)
            {
                buff.Append("roadwayPI", this.RoadwayPI);
            }
            if ((object)this.IntersectingRoadwayRef != null)
            {
                buff.Append("intersectingRoadwayRef", this.IntersectingRoadwayRef);
            }
            if ((object)this.IntersectRoadwayPI != null)
            {
                buff.Append("intersectRoadwayPI", this.IntersectRoadwayPI);
            }
            if ((object)this.ContructionType != null)
            {
                buff.Append("contructionType", this.ContructionType);
            }

            return buff.ToString();
        }

        /// <summary>
        /// A reference name value referring to Raodway.name attribute.
        /// </summary>

        public string RoadwayRef;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? RoadwayPI;
        /// <summary>
        /// A reference name value referring to Raodway.name attribute.
        /// </summary>

        public string IntersectingRoadwayRef;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? IntersectRoadwayPI;

        public IntersectionConstructionType? ContructionType;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("Corner"))
            {
                return Tuple.Create("Corner", this.NewReader<Corner>());
            }
            if (name.EqualsIgnoreCase("Curb"))
            {
                return Tuple.Create("Curb", this.NewReader<Curb>());
            }
            if (name.EqualsIgnoreCase("TurnRestriction"))
            {
                return Tuple.Create("TurnRestriction", this.NewReader<TurnRestriction>());
            }
            if (name.EqualsIgnoreCase("TurnSpeed"))
            {
                return Tuple.Create("TurnSpeed", this.NewReader<TurnSpeed>());
            }
            if (name.EqualsIgnoreCase("Volume"))
            {
                return Tuple.Create("Volume", this.NewReader<Volume>());
            }
            if (name.EqualsIgnoreCase("Timing"))
            {
                return Tuple.Create("Timing", this.NewReader<Timing>());
            }
            if (name.EqualsIgnoreCase("TrafficControl"))
            {
                return Tuple.Create("TrafficControl", this.NewReader<TrafficControl>());
            }

            return null;
        }
    }
}
#endif

