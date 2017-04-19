#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public class GPSPosition : XsdBaseObject
    {
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
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.SetupID != null)
            {
                buff.AppendFormat(" setupID=\"{0}\"", this.SetupID);
            }
            if ((object)this.SetID != null)
            {
                buff.AppendFormat(" setID=\"{0}\"", this.SetID);
            }
            if ((object)this.WgsHeight != null)
            {
                buff.AppendFormat(" wgsHeight=\"{0}\"", this.WgsHeight);
            }
            if ((object)this.WgsLatitude != null)
            {
                buff.AppendFormat(" wgsLatitude=\"{0}\"", this.WgsLatitude);
            }
            if ((object)this.WgsLongitude != null)
            {
                buff.AppendFormat(" wgsLongitude=\"{0}\"", this.WgsLongitude);
            }
            if ((object)this.Purpose != null)
            {
                buff.AppendFormat(" purpose=\"{0}\"", this.Purpose);
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.AppendFormat(" coordGeomRefs=\"{0}\"", this.CoordGeomRefs);
            }
            if ((object)this.PntRef != null)
            {
                buff.AppendFormat(" pntRef=\"{0}\"", this.PntRef);
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


    }
}
#endif

