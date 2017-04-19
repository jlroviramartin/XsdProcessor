#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public class PointResults : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.SetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID"));



            this.TargetSetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("targetSetupID"));



            this.MeanHorizAngle = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("meanHorizAngle"));



            this.HorizStdDeviation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("horizStdDeviation"));



            this.MeanzenithAngle = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("meanzenithAngle"));



            this.VertStdDeviation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("vertStdDeviation"));



            this.MeanSlopeDistance = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("meanSlopeDistance"));



            this.SlopeDistanceStdDeviation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("slopeDistanceStdDeviation"));



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
            if ((object)this.TargetSetupID != null)
            {
                buff.AppendFormat("targetSetupID = {0}", this.TargetSetupID).AppendLine();
            }
            if ((object)this.MeanHorizAngle != null)
            {
                buff.AppendFormat("meanHorizAngle = {0}", this.MeanHorizAngle).AppendLine();
            }
            if ((object)this.HorizStdDeviation != null)
            {
                buff.AppendFormat("horizStdDeviation = {0}", this.HorizStdDeviation).AppendLine();
            }
            if ((object)this.MeanzenithAngle != null)
            {
                buff.AppendFormat("meanzenithAngle = {0}", this.MeanzenithAngle).AppendLine();
            }
            if ((object)this.VertStdDeviation != null)
            {
                buff.AppendFormat("vertStdDeviation = {0}", this.VertStdDeviation).AppendLine();
            }
            if ((object)this.MeanSlopeDistance != null)
            {
                buff.AppendFormat("meanSlopeDistance = {0}", this.MeanSlopeDistance).AppendLine();
            }
            if ((object)this.SlopeDistanceStdDeviation != null)
            {
                buff.AppendFormat("slopeDistanceStdDeviation = {0}", this.SlopeDistanceStdDeviation).AppendLine();
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
            if ((object)this.TargetSetupID != null)
            {
                buff.AppendFormat(" targetSetupID=\"{0}\"", this.TargetSetupID);
            }
            if ((object)this.MeanHorizAngle != null)
            {
                buff.AppendFormat(" meanHorizAngle=\"{0}\"", this.MeanHorizAngle);
            }
            if ((object)this.HorizStdDeviation != null)
            {
                buff.AppendFormat(" horizStdDeviation=\"{0}\"", this.HorizStdDeviation);
            }
            if ((object)this.MeanzenithAngle != null)
            {
                buff.AppendFormat(" meanzenithAngle=\"{0}\"", this.MeanzenithAngle);
            }
            if ((object)this.VertStdDeviation != null)
            {
                buff.AppendFormat(" vertStdDeviation=\"{0}\"", this.VertStdDeviation);
            }
            if ((object)this.MeanSlopeDistance != null)
            {
                buff.AppendFormat(" meanSlopeDistance=\"{0}\"", this.MeanSlopeDistance);
            }
            if ((object)this.SlopeDistanceStdDeviation != null)
            {
                buff.AppendFormat(" slopeDistanceStdDeviation=\"{0}\"", this.SlopeDistanceStdDeviation);
            }


            return buff.ToString();
        }

        public string SetupID;

        public string TargetSetupID;

        public double? MeanHorizAngle;

        public double? HorizStdDeviation;
        /// <summary>
        /// Represents zenith angles with the 0 origin as
        ///     straight up and measured in a clockwise direction in the specified
        ///     Angular units.
        /// </summary>

        public double? MeanzenithAngle;

        public double? VertStdDeviation;

        public double? MeanSlopeDistance;

        public double? SlopeDistanceStdDeviation;


    }
}
#endif

