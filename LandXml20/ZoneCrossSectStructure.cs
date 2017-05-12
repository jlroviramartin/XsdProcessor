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
    /// Sequence [1, 1]
    ///     PntList2D [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class ZoneCrossSectStructure : XsdBaseReader
    {
        public ZoneCrossSectStructure(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.InnerConnectPnt = XsdConverter.Instance.Convert<IList<double>>(
                    attributes.GetSafe("innerConnectPnt"));

            this.OuterConnectPnt = XsdConverter.Instance.Convert<IList<double>>(
                    attributes.GetSafe("outerConnectPnt"));

            this.OffsetMode = XsdConverter.Instance.Convert<ZoneOffsetType?>(
                    attributes.GetSafe("offsetMode"),
                    XsdConverter.Instance.Convert<ZoneOffsetType?>("zone"));

            this.StartOffset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("startOffset"),
                    XsdConverter.Instance.Convert<double?>("0.0"));

            this.StartOffsetElev = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("startOffsetElev"),
                    XsdConverter.Instance.Convert<double?>("0.0"));

            this.EndOffset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("endOffset"),
                    XsdConverter.Instance.Convert<double?>("0.0"));

            this.EndOffsetElev = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("endOffsetElev"),
                    XsdConverter.Instance.Convert<double?>("0.0"));

            this.Transition = XsdConverter.Instance.Convert<ZoneTransitionType?>(
                    attributes.GetSafe("transition"),
                    XsdConverter.Instance.Convert<ZoneTransitionType?>("parallel"));

            this.Placement = XsdConverter.Instance.Convert<ZonePlacementType?>(
                    attributes.GetSafe("placement"),
                    XsdConverter.Instance.Convert<ZonePlacementType?>("dependent"));

            this.CatalogReference = XsdConverter.Instance.Convert<Uri>(
                    attributes.GetSafe("catalogReference"));

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
            if ((object)this.InnerConnectPnt != null)
            {
                buff.AppendFormat("innerConnectPnt = {0}", this.InnerConnectPnt).AppendLine();
            }
            if ((object)this.OuterConnectPnt != null)
            {
                buff.AppendFormat("outerConnectPnt = {0}", this.OuterConnectPnt).AppendLine();
            }
            if ((object)this.OffsetMode != null)
            {
                buff.AppendFormat("offsetMode = {0} defvalue = {1}", this.OffsetMode, "zone").AppendLine();
            }
            if ((object)this.StartOffset != null)
            {
                buff.AppendFormat("startOffset = {0} defvalue = {1}", this.StartOffset, "0.0").AppendLine();
            }
            if ((object)this.StartOffsetElev != null)
            {
                buff.AppendFormat("startOffsetElev = {0} defvalue = {1}", this.StartOffsetElev, "0.0").AppendLine();
            }
            if ((object)this.EndOffset != null)
            {
                buff.AppendFormat("endOffset = {0} defvalue = {1}", this.EndOffset, "0.0").AppendLine();
            }
            if ((object)this.EndOffsetElev != null)
            {
                buff.AppendFormat("endOffsetElev = {0} defvalue = {1}", this.EndOffsetElev, "0.0").AppendLine();
            }
            if ((object)this.Transition != null)
            {
                buff.AppendFormat("transition = {0} defvalue = {1}", this.Transition, "parallel").AppendLine();
            }
            if ((object)this.Placement != null)
            {
                buff.AppendFormat("placement = {0} defvalue = {1}", this.Placement, "dependent").AppendLine();
            }
            if ((object)this.CatalogReference != null)
            {
                buff.AppendFormat("catalogReference = {0}", this.CatalogReference).AppendLine();
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
            if ((object)this.InnerConnectPnt != null)
            {
                buff.Append("innerConnectPnt", this.InnerConnectPnt);
            }
            if ((object)this.OuterConnectPnt != null)
            {
                buff.Append("outerConnectPnt", this.OuterConnectPnt);
            }
            if ((object)this.OffsetMode != null)
            {
                buff.Append("offsetMode", this.OffsetMode);
            }
            if ((object)this.StartOffset != null)
            {
                buff.Append("startOffset", this.StartOffset);
            }
            if ((object)this.StartOffsetElev != null)
            {
                buff.Append("startOffsetElev", this.StartOffsetElev);
            }
            if ((object)this.EndOffset != null)
            {
                buff.Append("endOffset", this.EndOffset);
            }
            if ((object)this.EndOffsetElev != null)
            {
                buff.Append("endOffsetElev", this.EndOffsetElev);
            }
            if ((object)this.Transition != null)
            {
                buff.Append("transition", this.Transition);
            }
            if ((object)this.Placement != null)
            {
                buff.Append("placement", this.Placement);
            }
            if ((object)this.CatalogReference != null)
            {
                buff.Append("catalogReference", this.CatalogReference);
            }

            return buff.ToString();
        }

        public string Name;
        /// <summary>
        /// Attribute that represents a space delimited, cross section offset/elevation pair. 
        ///             Example: crossSectionPnt="12.0 723.3456" 
        /// Restriction:
        /// Restriction:
        /// A text value that is a space delimited list of doubles. It is used as the base type to define point coordinates in the form of "northing easting" or "northing easting elevation" as well as point lists of 2D or 3D points with items such as surface boundaries or "station elevation", "station offset" lists for items such as profiles and cross sections: 
        /// Example, "1632.546 2391.045 240.30"
        /// </summary>

        public IList<double> InnerConnectPnt;
        /// <summary>
        /// Attribute that represents a space delimited, cross section offset/elevation pair. 
        ///             Example: crossSectionPnt="12.0 723.3456" 
        /// Restriction:
        /// Restriction:
        /// A text value that is a space delimited list of doubles. It is used as the base type to define point coordinates in the form of "northing easting" or "northing easting elevation" as well as point lists of 2D or 3D points with items such as surface boundaries or "station elevation", "station offset" lists for items such as profiles and cross sections: 
        /// Example, "1632.546 2391.045 240.30"
        /// </summary>

        public IList<double> OuterConnectPnt;

        public ZoneOffsetType? OffsetMode;
        /// <summary>
        /// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
        /// </summary>

        public double? StartOffset;
        /// <summary>
        /// Represents a vertical offset distance or elevational shift. In all cases a positive value indicates a vertical elevational shift above the origin and negative values indicate a vertical elevational shift below the origin. The value is in decimal form expressed in length units.
        /// </summary>

        public double? StartOffsetElev;
        /// <summary>
        /// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
        /// </summary>

        public double? EndOffset;
        /// <summary>
        /// Represents a vertical offset distance or elevational shift. In all cases a positive value indicates a vertical elevational shift above the origin and negative values indicate a vertical elevational shift below the origin. The value is in decimal form expressed in length units.
        /// </summary>

        public double? EndOffsetElev;

        public ZoneTransitionType? Transition;

        public ZonePlacementType? Placement;

        public Uri CatalogReference;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("PntList2D"))
            {
                return Tuple.Create("PntList2D", this.NewReader<IList<double>>());
            }

            return null;
        }
    }
}
#endif

