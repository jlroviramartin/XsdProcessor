#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// All elements derived from PointType will either contain a coordinate text value ( "north east" or "north east elev"), a "pntRef" attribute value, or both. The "pntRef" attribute contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data. If this element has a "pntRef" value, then it's coordinates will be retrieved from the referenced element. If an element contains both a coordinate value and a pntRef, the coordinate value should be used as the point location and the referenced point is either ignored or is used for point attributes such as number or desc.
    /// </summary>

    public class PointType : XsdBaseReader
    {
        public PointType(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public string Desc;

        public string Code;

        public StateType? State;
        /// <summary>
        /// A reference name value referring to a PointType derived name attribute. An attribute if this type contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data.
        /// </summary>

        public string PntRef;

        public PointGeometryType? PointGeometry;

        public DTMAttributeType? DTMAttribute;

        public DateTime? TimeStamp;

        public SurveyRoleType? Role;

        public DateTime? DeterminedTimeStamp;
        /// <summary>
        /// Represents the National Geodedic Survey ellipsiod elevation expressed in the unit height attribute value
        /// </summary>

        public double? EllipsoidElev;
        /// <summary>
        /// Latitude/Longitude coordinate angular values expressed in latLongAngularUnit. Latitude (range -90 to +90) positive values for the northern hemispher, negative indicate the southern. Longitude (range -180 to +180) positive values are to the east of the prime meridian, negative values are to the west. Values expressed in "decimal dd.mm.ss" units have the numeric format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
        /// </summary>

        public double? Latitude;
        /// <summary>
        /// Latitude/Longitude coordinate angular values expressed in latLongAngularUnit. Latitude (range -90 to +90) positive values for the northern hemispher, negative indicate the southern. Longitude (range -180 to +180) positive values are to the east of the prime meridian, negative values are to the west. Values expressed in "decimal dd.mm.ss" units have the numeric format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
        /// </summary>

        public double? Longitude;

        public IList<double> Content;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }

        protected override bool NeedContent { get { return true; } }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Code = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("code"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.PntRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("pntRef"));

            this.PointGeometry = XsdConverter.Instance.Convert<PointGeometryType?>(
                    attributes.GetSafe("pointGeometry"));

            this.DTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(
                    attributes.GetSafe("DTMAttribute"));

            this.TimeStamp = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("timeStamp"));

            this.Role = XsdConverter.Instance.Convert<SurveyRoleType?>(
                    attributes.GetSafe("role"));

            this.DeterminedTimeStamp = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("determinedTimeStamp"));

            this.EllipsoidElev = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("ellipsoidElev"));

            this.Latitude = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("latitude"));

            this.Longitude = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("longitude"));

            this.Content = XsdConverter.Instance.Convert<IList<double>>(text);
            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Code != null)
            {
                buff.Append("code", this.Code);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.PntRef != null)
            {
                buff.Append("pntRef", this.PntRef);
            }
            if ((object)this.PointGeometry != null)
            {
                buff.Append("pointGeometry", this.PointGeometry);
            }
            if ((object)this.DTMAttribute != null)
            {
                buff.Append("DTMAttribute", this.DTMAttribute);
            }
            if ((object)this.TimeStamp != null)
            {
                buff.Append("timeStamp", this.TimeStamp);
            }
            if ((object)this.Role != null)
            {
                buff.Append("role", this.Role);
            }
            if ((object)this.DeterminedTimeStamp != null)
            {
                buff.Append("determinedTimeStamp", this.DeterminedTimeStamp);
            }
            if ((object)this.EllipsoidElev != null)
            {
                buff.Append("ellipsoidElev", this.EllipsoidElev);
            }
            if ((object)this.Latitude != null)
            {
                buff.Append("latitude", this.Latitude);
            }
            if ((object)this.Longitude != null)
            {
                buff.Append("longitude", this.Longitude);
            }

            if ((object)this.Content != null)
            {
                buff.Append("content", this.Content);
            }
            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Code != null)
            {
                buff.AppendFormat("code = {0}", this.Code).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.PntRef != null)
            {
                buff.AppendFormat("pntRef = {0}", this.PntRef).AppendLine();
            }
            if ((object)this.PointGeometry != null)
            {
                buff.AppendFormat("pointGeometry = {0}", this.PointGeometry).AppendLine();
            }
            if ((object)this.DTMAttribute != null)
            {
                buff.AppendFormat("DTMAttribute = {0}", this.DTMAttribute).AppendLine();
            }
            if ((object)this.TimeStamp != null)
            {
                buff.AppendFormat("timeStamp = {0}", this.TimeStamp).AppendLine();
            }
            if ((object)this.Role != null)
            {
                buff.AppendFormat("role = {0}", this.Role).AppendLine();
            }
            if ((object)this.DeterminedTimeStamp != null)
            {
                buff.AppendFormat("determinedTimeStamp = {0}", this.DeterminedTimeStamp).AppendLine();
            }
            if ((object)this.EllipsoidElev != null)
            {
                buff.AppendFormat("ellipsoidElev = {0}", this.EllipsoidElev).AppendLine();
            }
            if ((object)this.Latitude != null)
            {
                buff.AppendFormat("latitude = {0}", this.Latitude).AppendLine();
            }
            if ((object)this.Longitude != null)
            {
                buff.AppendFormat("longitude = {0}", this.Longitude).AppendLine();
            }

            if ((object)this.Content != null)
            {
                buff.AppendFormat("content = {0}", this.Content).AppendLine();
            }
            return buff.ToString();
        }

        #endregion
    }
}
#endif

