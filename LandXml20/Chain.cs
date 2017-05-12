#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    // needContent    : true
    // includeContent : true
    /// <summary>
    /// A text value that is a space delimited list of CgPoint names that form a linear connected chain. 
    ///    example: 
    /// <Chain xmlns="http://www.landxml.org/schema/LandXML-2.0">1 23 45 34</Chain>
    ///    represents a linear connection between CgPoint name 1, 23, 45 and 34.
    /// </summary>

    public class Chain : XsdBaseReader
    {
        public Chain(System.Xml.XmlReader reader) : base(reader)
        {
        }

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

            this.PointGeometry = XsdConverter.Instance.Convert<PointGeometryType?>(
                    attributes.GetSafe("pointGeometry"));

            this.DTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(
                    attributes.GetSafe("DTMAttribute"));

            this.TimeStamp = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("timeStamp"));

            this.Role = XsdConverter.Instance.Convert<SurveyRoleType?>(
                    attributes.GetSafe("role"));

            this.Station = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("station"));

            this.Zone = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("zone"));

            this.Status = XsdConverter.Instance.Convert<ObservationStatusType?>(
                    attributes.GetSafe("status"));

            this.Content = XsdConverter.Instance.Convert<IList<string>>(text);
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
            if ((object)this.Station != null)
            {
                buff.AppendFormat("station = {0}", this.Station).AppendLine();
            }
            if ((object)this.Zone != null)
            {
                buff.AppendFormat("zone = {0}", this.Zone).AppendLine();
            }
            if ((object)this.Status != null)
            {
                buff.AppendFormat("status = {0}", this.Status).AppendLine();
            }

            if ((object)this.Content != null)
            {
                buff.AppendFormat("content = {0}", this.Content).AppendLine();
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
            if ((object)this.Station != null)
            {
                buff.Append("station", this.Station);
            }
            if ((object)this.Zone != null)
            {
                buff.Append("zone", this.Zone);
            }
            if ((object)this.Status != null)
            {
                buff.Append("status", this.Status);
            }

            if ((object)this.Content != null)
            {
                buff.Append("content", this.Content);
            }
            return buff.ToString();
        }

        public string Name;

        public string Desc;

        public string Code;

        public StateType? State;

        public PointGeometryType? PointGeometry;

        public DTMAttributeType? DTMAttribute;

        public DateTime? TimeStamp;

        public SurveyRoleType? Role;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? Station;

        public string Zone;

        public ObservationStatusType? Status;


        protected override bool NeedContent { get { return true; } }

        public IList<string> Content;

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

