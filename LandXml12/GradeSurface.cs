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
    /// Choice [1, *]
    ///     Start [0, 1]
    ///     Zones [1, 2]
    ///     Feature [0, *]
    /// </summary>

    public class GradeSurface : XsdBaseReader
    {
        public GradeSurface(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.AlignmentRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("alignmentRef"));

            this.StationAlignmentRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("stationAlignmentRef"));

            this.SurfaceType = XsdConverter.Instance.Convert<ZoneSurfaceType>(
                    attributes.GetSafe("surfaceType"));

            this.SurfaceRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surfaceRef"));

            this.SurfaceRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("surfaceRefs"));

            this.CgPointRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("cgPointRefs"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.AlignmentRef != null)
            {
                buff.AppendFormat("alignmentRef = {0}", this.AlignmentRef).AppendLine();
            }
            if ((object)this.StationAlignmentRef != null)
            {
                buff.AppendFormat("stationAlignmentRef = {0}", this.StationAlignmentRef).AppendLine();
            }
            if ((object)this.SurfaceType != null)
            {
                buff.AppendFormat("surfaceType = {0}", this.SurfaceType).AppendLine();
            }
            if ((object)this.SurfaceRef != null)
            {
                buff.AppendFormat("surfaceRef = {0}", this.SurfaceRef).AppendLine();
            }
            if ((object)this.SurfaceRefs != null)
            {
                buff.AppendFormat("surfaceRefs = {0}", this.SurfaceRefs).AppendLine();
            }
            if ((object)this.CgPointRefs != null)
            {
                buff.AppendFormat("cgPointRefs = {0}", this.CgPointRefs).AppendLine();
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

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.AlignmentRef != null)
            {
                buff.Append("alignmentRef", this.AlignmentRef);
            }
            if ((object)this.StationAlignmentRef != null)
            {
                buff.Append("stationAlignmentRef", this.StationAlignmentRef);
            }
            if ((object)this.SurfaceType != null)
            {
                buff.Append("surfaceType", this.SurfaceType);
            }
            if ((object)this.SurfaceRef != null)
            {
                buff.Append("surfaceRef", this.SurfaceRef);
            }
            if ((object)this.SurfaceRefs != null)
            {
                buff.Append("surfaceRefs", this.SurfaceRefs);
            }
            if ((object)this.CgPointRefs != null)
            {
                buff.Append("cgPointRefs", this.CgPointRefs);
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

            return buff.ToString();
        }

        /// <summary>
        /// A reference name value referring to Alignment.name attribute.
        /// </summary>

        public string AlignmentRef;
        /// <summary>
        /// A reference name value referring to Alignment.name attribute.
        /// </summary>

        public string StationAlignmentRef;

        public ZoneSurfaceType SurfaceType;
        /// <summary>
        /// A reference name value referring to Surface.name attribute.
        /// </summary>

        public string SurfaceRef;
        /// <summary>
        /// A list of reference names values refering to one or more Surface.name attributes.
        /// </summary>

        public IList<string> SurfaceRefs;
        /// <summary>
        /// A list of reference names values refering to one or more PointType derived name attributes.
        /// </summary>

        public IList<string> CgPointRefs;

        public string Name;

        public string Desc;

        public StateType? State;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("Zones"))
            {
                return Tuple.Create("Zones", this.NewReader<Zones>());
            }
            if (name.EqualsIgnoreCase("Start"))
            {
                return Tuple.Create("Start", this.NewReader<PointType>());
            }

            return null;
        }
    }
}
#endif

