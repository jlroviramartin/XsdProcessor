#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class Intersection : XsdBaseObject
    {
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
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.RoadwayRef != null)
            {
                buff.AppendFormat(" roadwayRef=\"{0}\"", this.RoadwayRef);
            }
            if ((object)this.RoadwayPI != null)
            {
                buff.AppendFormat(" roadwayPI=\"{0}\"", this.RoadwayPI);
            }
            if ((object)this.IntersectingRoadwayRef != null)
            {
                buff.AppendFormat(" intersectingRoadwayRef=\"{0}\"", this.IntersectingRoadwayRef);
            }
            if ((object)this.IntersectRoadwayPI != null)
            {
                buff.AppendFormat(" intersectRoadwayPI=\"{0}\"", this.IntersectRoadwayPI);
            }
            if ((object)this.ContructionType != null)
            {
                buff.AppendFormat(" contructionType=\"{0}\"", this.ContructionType);
            }


            return buff.ToString();
        }

        /// <summary>
        /// A reference name value referring to Raodway.name attribute.
        /// </summary>

        public string RoadwayRef;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? RoadwayPI;
        /// <summary>
        /// A reference name value referring to Raodway.name attribute.
        /// </summary>

        public string IntersectingRoadwayRef;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? IntersectRoadwayPI;

        public IntersectionConstructionType? ContructionType;


    }
}
#endif

