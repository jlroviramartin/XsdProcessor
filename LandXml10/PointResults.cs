#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Sequence [1, 1]
    ///     TargetPoint [0, 1]
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class PointResults : XsdBaseReader
    {
        public PointResults(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string SetupID;

        public string TargetSetupID;

        public double? MeanHorizAngle;

        public double? HorizStdDeviation;

        public double? MeanzenithAngle;

        public double? VertStdDeviation;

        public double? MeanSlopeDistance;

        public double? SlopeDistanceStdDeviation;

        #region XsdBaseReader

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
            if (name.EqualsIgnoreCase("TargetPoint"))
            {
                return Tuple.Create("TargetPoint", this.NewReader<PointType>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

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

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.SetupID != null)
            {
                buff.Append("setupID", this.SetupID);
            }
            if ((object)this.TargetSetupID != null)
            {
                buff.Append("targetSetupID", this.TargetSetupID);
            }
            if ((object)this.MeanHorizAngle != null)
            {
                buff.Append("meanHorizAngle", this.MeanHorizAngle);
            }
            if ((object)this.HorizStdDeviation != null)
            {
                buff.Append("horizStdDeviation", this.HorizStdDeviation);
            }
            if ((object)this.MeanzenithAngle != null)
            {
                buff.Append("meanzenithAngle", this.MeanzenithAngle);
            }
            if ((object)this.VertStdDeviation != null)
            {
                buff.Append("vertStdDeviation", this.VertStdDeviation);
            }
            if ((object)this.MeanSlopeDistance != null)
            {
                buff.Append("meanSlopeDistance", this.MeanSlopeDistance);
            }
            if ((object)this.SlopeDistanceStdDeviation != null)
            {
                buff.Append("slopeDistanceStdDeviation", this.SlopeDistanceStdDeviation);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

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

        #endregion
    }
}
#endif

