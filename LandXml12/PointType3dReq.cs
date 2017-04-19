#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public class PointType3dReq : XsdBaseObject
    {
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



            this.FeatureRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("featureRef"));



            this.PointGeometry = XsdConverter.Instance.Convert<PointGeometryType?>(
                    attributes.GetSafe("pointGeometry"));



            this.DTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(
                    attributes.GetSafe("DTMAttribute"));



            this.TimeStamp = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("timeStamp"));



            this.Role = XsdConverter.Instance.Convert<SurveyRoleType?>(
                    attributes.GetSafe("role"));



            this.Content = XsdConverter.Instance.Convert<IList<double>>(text);

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
            if ((object)this.PntRef != null)
            {
                buff.AppendFormat("pntRef = {0}", this.PntRef).AppendLine();
            }
            if ((object)this.FeatureRef != null)
            {
                buff.AppendFormat("featureRef = {0}", this.FeatureRef).AppendLine();
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


            if ((object)this.Content != null)
            {
                buff.AppendFormat("content = {0}", this.Content).AppendLine();
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
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.Code != null)
            {
                buff.AppendFormat(" code=\"{0}\"", this.Code);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.PntRef != null)
            {
                buff.AppendFormat(" pntRef=\"{0}\"", this.PntRef);
            }
            if ((object)this.FeatureRef != null)
            {
                buff.AppendFormat(" featureRef=\"{0}\"", this.FeatureRef);
            }
            if ((object)this.PointGeometry != null)
            {
                buff.AppendFormat(" pointGeometry=\"{0}\"", this.PointGeometry);
            }
            if ((object)this.DTMAttribute != null)
            {
                buff.AppendFormat(" DTMAttribute=\"{0}\"", this.DTMAttribute);
            }
            if ((object)this.TimeStamp != null)
            {
                buff.AppendFormat(" timeStamp=\"{0}\"", this.TimeStamp);
            }
            if ((object)this.Role != null)
            {
                buff.AppendFormat(" role=\"{0}\"", this.Role);
            }


            if ((object)this.Content != null)
            {
                buff.AppendFormat(" content = \"{0}\"", this.Content);
            }

            return buff.ToString();
        }

        public string Name;

        public string Desc;

        public string Code;

        public StateType? State;
        /// <summary>
        /// A reference name value referring to a PointType derived name attribute. An attribute if this type contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data.
        /// </summary>

        public string PntRef;
        /// <summary>
        /// A Feature element name attribute reference value refering to one Feature.name attribute.
        /// </summary>

        public string FeatureRef;

        public PointGeometryType? PointGeometry;

        public DTMAttributeType? DTMAttribute;

        public DateTime? TimeStamp;

        public SurveyRoleType? Role;


        public IList<double> Content;
    }
}
#endif

