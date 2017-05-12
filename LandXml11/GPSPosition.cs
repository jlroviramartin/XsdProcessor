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
    /// Sequence [1, 1]
    ///     TargetPoint [1, 1]
    ///     GPSQCInfoLevel1 [0, 1]
    ///     GPSQCInfoLevel2 [0, 1]
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class GPSPosition : XsdBaseReader
    {
        public GPSPosition(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.SetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID"));

            this.SetID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setID"));

            this.WgsHeight = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("wgsHeight"));

            this.WgsLatitude = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("wgsLatitude"));

            this.WgsLongitude = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("wgsLongitude"));

            this.Purpose = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("purpose"));

            this.CoordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("coordGeomRefs"));

            this.PntRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("pntRef"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.SetupID != null)
            {
                buff.AppendFormat("setupID = {0}", this.SetupID).AppendLine();
            }
            if ((object)this.SetID != null)
            {
                buff.AppendFormat("setID = {0}", this.SetID).AppendLine();
            }
            if ((object)this.WgsHeight != null)
            {
                buff.AppendFormat("wgsHeight = {0}", this.WgsHeight).AppendLine();
            }
            if ((object)this.WgsLatitude != null)
            {
                buff.AppendFormat("wgsLatitude = {0}", this.WgsLatitude).AppendLine();
            }
            if ((object)this.WgsLongitude != null)
            {
                buff.AppendFormat("wgsLongitude = {0}", this.WgsLongitude).AppendLine();
            }
            if ((object)this.Purpose != null)
            {
                buff.AppendFormat("purpose = {0}", this.Purpose).AppendLine();
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.AppendFormat("coordGeomRefs = {0}", this.CoordGeomRefs).AppendLine();
            }
            if ((object)this.PntRef != null)
            {
                buff.AppendFormat("pntRef = {0}", this.PntRef).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.SetupID != null)
            {
                buff.Append("setupID", this.SetupID);
            }
            if ((object)this.SetID != null)
            {
                buff.Append("setID", this.SetID);
            }
            if ((object)this.WgsHeight != null)
            {
                buff.Append("wgsHeight", this.WgsHeight);
            }
            if ((object)this.WgsLatitude != null)
            {
                buff.Append("wgsLatitude", this.WgsLatitude);
            }
            if ((object)this.WgsLongitude != null)
            {
                buff.Append("wgsLongitude", this.WgsLongitude);
            }
            if ((object)this.Purpose != null)
            {
                buff.Append("purpose", this.Purpose);
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.Append("coordGeomRefs", this.CoordGeomRefs);
            }
            if ((object)this.PntRef != null)
            {
                buff.Append("pntRef", this.PntRef);
            }

            return buff.ToString();
        }

        public string SetupID;

        public string SetID;

        public double WgsHeight;

        public double WgsLatitude;

        public double WgsLongitude;

        public string Purpose;
        /// <summary>
        /// A list of reference names values refering to one or more CoordGeom.name attributes.
        /// </summary>

        public IList<string> CoordGeomRefs;
        /// <summary>
        /// A reference name value referring to a PointType derived name attribute. An attribute if this type contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data.
        /// </summary>

        public string PntRef;


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
            if (name.EqualsIgnoreCase("GPSQCInfoLevel2"))
            {
                return Tuple.Create("GPSQCInfoLevel2", this.NewReader<GPSQCInfoLevel2>());
            }
            if (name.EqualsIgnoreCase("GPSQCInfoLevel1"))
            {
                return Tuple.Create("GPSQCInfoLevel1", this.NewReader<GPSQCInfoLevel1>());
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

