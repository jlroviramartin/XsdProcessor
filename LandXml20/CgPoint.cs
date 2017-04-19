#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Represents a COrdinate GeOmetry Point. The Point is identified by the "name" attr and the data value will be a sequence of space delimented, two or three double numberic values: (Northing Easting) or (Northing Easting Elevation).
    /// </summary>

    public class CgPoint : PointType
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));



            this.SurveyOrder = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyOrder"));



            this.PntSurv = XsdConverter.Instance.Convert<SurvPntType?>(
                    attributes.GetSafe("pntSurv"));



            this.ZoneNumber = XsdConverter.Instance.Convert<uint?>(
                    attributes.GetSafe("zoneNumber"));



            this.SurveyHorizontalOrder = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyHorizontalOrder"));



            this.SurveyVerticalOrder = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyVerticalOrder"));



            this.LocalUncertainity = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("localUncertainity"));



            this.PositionalUncertainity = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("positionalUncertainity"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.SurveyOrder != null)
            {
                buff.AppendFormat("surveyOrder = {0}", this.SurveyOrder).AppendLine();
            }
            if ((object)this.PntSurv != null)
            {
                buff.AppendFormat("pntSurv = {0}", this.PntSurv).AppendLine();
            }
            if ((object)this.ZoneNumber != null)
            {
                buff.AppendFormat("zoneNumber = {0}", this.ZoneNumber).AppendLine();
            }
            if ((object)this.SurveyHorizontalOrder != null)
            {
                buff.AppendFormat("surveyHorizontalOrder = {0}", this.SurveyHorizontalOrder).AppendLine();
            }
            if ((object)this.SurveyVerticalOrder != null)
            {
                buff.AppendFormat("surveyVerticalOrder = {0}", this.SurveyVerticalOrder).AppendLine();
            }
            if ((object)this.LocalUncertainity != null)
            {
                buff.AppendFormat("localUncertainity = {0}", this.LocalUncertainity).AppendLine();
            }
            if ((object)this.PositionalUncertainity != null)
            {
                buff.AppendFormat("positionalUncertainity = {0}", this.PositionalUncertainity).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.OID != null)
            {
                buff.AppendFormat(" oID=\"{0}\"", this.OID);
            }
            if ((object)this.SurveyOrder != null)
            {
                buff.AppendFormat(" surveyOrder=\"{0}\"", this.SurveyOrder);
            }
            if ((object)this.PntSurv != null)
            {
                buff.AppendFormat(" pntSurv=\"{0}\"", this.PntSurv);
            }
            if ((object)this.ZoneNumber != null)
            {
                buff.AppendFormat(" zoneNumber=\"{0}\"", this.ZoneNumber);
            }
            if ((object)this.SurveyHorizontalOrder != null)
            {
                buff.AppendFormat(" surveyHorizontalOrder=\"{0}\"", this.SurveyHorizontalOrder);
            }
            if ((object)this.SurveyVerticalOrder != null)
            {
                buff.AppendFormat(" surveyVerticalOrder=\"{0}\"", this.SurveyVerticalOrder);
            }
            if ((object)this.LocalUncertainity != null)
            {
                buff.AppendFormat(" localUncertainity=\"{0}\"", this.LocalUncertainity);
            }
            if ((object)this.PositionalUncertainity != null)
            {
                buff.AppendFormat(" positionalUncertainity=\"{0}\"", this.PositionalUncertainity);
            }


            return buff.ToString();
        }

        public string OID;

        public string SurveyOrder;
        /// <summary>
        /// Optional COGO Point attribute to designate the survey point type.
        /// </summary>

        public SurvPntType? PntSurv;

        public uint? ZoneNumber;

        public string SurveyHorizontalOrder;

        public string SurveyVerticalOrder;

        public double? LocalUncertainity;

        public double? PositionalUncertainity;


    }
}
#endif

