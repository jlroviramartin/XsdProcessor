#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public class Roadway : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.AlignmentRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("alignmentRefs"));



            this.SurfaceRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("surfaceRefs"));



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
            if ((object)this.SurfaceRefs != null)
            {
                buff.AppendFormat("surfaceRefs = {0}", this.SurfaceRefs).AppendLine();
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
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.AlignmentRefs != null)
            {
                buff.AppendFormat(" alignmentRefs=\"{0}\"", this.AlignmentRefs);
            }
            if ((object)this.SurfaceRefs != null)
            {
                buff.AppendFormat(" surfaceRefs=\"{0}\"", this.SurfaceRefs);
            }
            if ((object)this.GradeModelRefs != null)
            {
                buff.AppendFormat(" gradeModelRefs=\"{0}\"", this.GradeModelRefs);
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat(" staStart=\"{0}\"", this.StaStart);
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat(" staEnd=\"{0}\"", this.StaEnd);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.RoadTerrain != null)
            {
                buff.AppendFormat(" roadTerrain=\"{0}\"", this.RoadTerrain);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }


            return buff.ToString();
        }

        public string Name;
        /// <summary>
        /// A list of reference names values refering to one or more Alignment.name attributes.
        /// </summary>

        public IList<string> AlignmentRefs;
        /// <summary>
        /// A list of reference names values refering to one or more Surface.name attributes.
        /// </summary>

        public IList<string> SurfaceRefs;
        /// <summary>
        /// A list of reference names values refering to one or more GradeModel.name attributes.
        /// </summary>

        public IList<string> GradeModelRefs;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? StaStart;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? StaEnd;

        public string Desc;

        public RoadTerrainType? RoadTerrain;

        public StateType? State;


    }
}
#endif

