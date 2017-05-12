#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// We seemed to have doubled up on the survey purpose here, but the two are quite different - maybe need a different name
    /// Choice [0, *]
    ///     Annotation [0, *]
    ///     AdministrativeArea [0, *]
    ///     AdministrativeDate [0, *]
    ///     CoordinateSystem [0, 1]
    ///     Units [0, 1]
    ///     MapPoint [0, *]
    ///     Personnel [0, *]
    ///     FieldNote [0, *]
    ///     Feature [0, *]
    ///     SurveyorCertificate [0, *]
    ///     PurposeOfSurvey [0, *]
    ///     HeadOfPower [0, *]
    /// </summary>

    public class SurveyHeader : XsdBaseReader
    {
        public SurveyHeader(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public string Desc;
        /// <summary>
        /// Used by many of the Survey elements
        /// </summary>

        public PurposeType? Purpose;

        public DateTime? StartTime;

        public DateTime? EndTime;

        public string Surveyor;

        public string SurveyorFirm;

        public string SurveyorReference;

        public string SurveyorRegistration;

        public string SurveyPurpose;
        /// <summary>
        /// This enumeration indicates whether the survey was acutally performed in the field, compiled from a series of existing surveys, or simply computed using known observations and maths
        /// </summary>

        public SurveyType? Type;

        public string Class;

        public string County;

        public bool? ApplyAtmosphericCorrection;

        public double? Pressure;

        public double? Temperature;

        public bool? ApplySeaLevelCorrection;

        public double? ScaleFactor;

        public double? SeaLevelCorrectionFactor;

        public double? CombinedFactor;
        /// <summary>
        /// This is the name of the juridiction in which the Survey Lies (ie which state)
        /// </summary>

        public string Jurisdiction;

        public DateTime? SubmissionDate;
        /// <summary>
        /// This field identifes the legal status for this document, for example it is the leagal record of survey, if was data captured from historical data etc.  This is used to determine processing of the record
        /// </summary>

        public string DocumentStatus;
        /// <summary>
        /// Describes the format of the survey and is a jurisdictionally specific list for example a stand format survey, Building Format Survey.
        /// </summary>

        public string SurveyFormat;
        /// <summary>
        /// Defines the status of this version of the file and will be a jurisdictionally specific list, for example "survey Record Only", Suitable for Registration" etc
        /// </summary>

        public string SurveyStatus;

        public int? CommunityTitleSchemeNo;

        public string CommunityTitleSchemeName;

        public bool? FieldNoteFlag;

        public string FieldNoteReference;

        public string FieldReport;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("HeadOfPower"))
            {
                return Tuple.Create("HeadOfPower", this.NewReader<HeadOfPower>());
            }
            if (name.EqualsIgnoreCase("PurposeOfSurvey"))
            {
                return Tuple.Create("PurposeOfSurvey", this.NewReader<PurposeOfSurvey>());
            }
            if (name.EqualsIgnoreCase("SurveyorCertificate"))
            {
                return Tuple.Create("SurveyorCertificate", this.NewReader<SurveyorCertificate>());
            }
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("FieldNote"))
            {
                return Tuple.Create("FieldNote", this.NewReader<FieldNote>());
            }
            if (name.EqualsIgnoreCase("Personnel"))
            {
                return Tuple.Create("Personnel", this.NewReader<Personnel>());
            }
            if (name.EqualsIgnoreCase("MapPoint"))
            {
                return Tuple.Create("MapPoint", this.NewReader<PointType>());
            }
            if (name.EqualsIgnoreCase("Units"))
            {
                return Tuple.Create("Units", this.NewReader<Units>());
            }
            if (name.EqualsIgnoreCase("CoordinateSystem"))
            {
                return Tuple.Create("CoordinateSystem", this.NewReader<CoordinateSystem>());
            }
            if (name.EqualsIgnoreCase("AdministrativeDate"))
            {
                return Tuple.Create("AdministrativeDate", this.NewReader<AdministrativeDate>());
            }
            if (name.EqualsIgnoreCase("AdministrativeArea"))
            {
                return Tuple.Create("AdministrativeArea", this.NewReader<AdministrativeArea>());
            }
            if (name.EqualsIgnoreCase("Annotation"))
            {
                return Tuple.Create("Annotation", this.NewReader<Annotation>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Purpose = XsdConverter.Instance.Convert<PurposeType?>(
                    attributes.GetSafe("purpose"));

            this.StartTime = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("startTime"));

            this.EndTime = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("endTime"));

            this.Surveyor = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyor"));

            this.SurveyorFirm = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyorFirm"));

            this.SurveyorReference = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyorReference"));

            this.SurveyorRegistration = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyorRegistration"));

            this.SurveyPurpose = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyPurpose"));

            this.Type = XsdConverter.Instance.Convert<SurveyType?>(
                    attributes.GetSafe("type"));

            this.Class = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("class"));

            this.County = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("county"));

            this.ApplyAtmosphericCorrection = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("applyAtmosphericCorrection"));

            this.Pressure = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("pressure"));

            this.Temperature = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("temperature"));

            this.ApplySeaLevelCorrection = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("applySeaLevelCorrection"));

            this.ScaleFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("scaleFactor"));

            this.SeaLevelCorrectionFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("seaLevelCorrectionFactor"));

            this.CombinedFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("combinedFactor"));

            this.Jurisdiction = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("jurisdiction"));

            this.SubmissionDate = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("submissionDate"));

            this.DocumentStatus = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("documentStatus"));

            this.SurveyFormat = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyFormat"));

            this.SurveyStatus = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surveyStatus"));

            this.CommunityTitleSchemeNo = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("communityTitleSchemeNo"));

            this.CommunityTitleSchemeName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("communityTitleSchemeName"));

            this.FieldNoteFlag = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("fieldNoteFlag"));

            this.FieldNoteReference = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("fieldNoteReference"));

            this.FieldReport = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("fieldReport"));

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
            if ((object)this.Purpose != null)
            {
                buff.Append("purpose", this.Purpose);
            }
            if ((object)this.StartTime != null)
            {
                buff.Append("startTime", this.StartTime);
            }
            if ((object)this.EndTime != null)
            {
                buff.Append("endTime", this.EndTime);
            }
            if ((object)this.Surveyor != null)
            {
                buff.Append("surveyor", this.Surveyor);
            }
            if ((object)this.SurveyorFirm != null)
            {
                buff.Append("surveyorFirm", this.SurveyorFirm);
            }
            if ((object)this.SurveyorReference != null)
            {
                buff.Append("surveyorReference", this.SurveyorReference);
            }
            if ((object)this.SurveyorRegistration != null)
            {
                buff.Append("surveyorRegistration", this.SurveyorRegistration);
            }
            if ((object)this.SurveyPurpose != null)
            {
                buff.Append("surveyPurpose", this.SurveyPurpose);
            }
            if ((object)this.Type != null)
            {
                buff.Append("type", this.Type);
            }
            if ((object)this.Class != null)
            {
                buff.Append("class", this.Class);
            }
            if ((object)this.County != null)
            {
                buff.Append("county", this.County);
            }
            if ((object)this.ApplyAtmosphericCorrection != null)
            {
                buff.Append("applyAtmosphericCorrection", this.ApplyAtmosphericCorrection);
            }
            if ((object)this.Pressure != null)
            {
                buff.Append("pressure", this.Pressure);
            }
            if ((object)this.Temperature != null)
            {
                buff.Append("temperature", this.Temperature);
            }
            if ((object)this.ApplySeaLevelCorrection != null)
            {
                buff.Append("applySeaLevelCorrection", this.ApplySeaLevelCorrection);
            }
            if ((object)this.ScaleFactor != null)
            {
                buff.Append("scaleFactor", this.ScaleFactor);
            }
            if ((object)this.SeaLevelCorrectionFactor != null)
            {
                buff.Append("seaLevelCorrectionFactor", this.SeaLevelCorrectionFactor);
            }
            if ((object)this.CombinedFactor != null)
            {
                buff.Append("combinedFactor", this.CombinedFactor);
            }
            if ((object)this.Jurisdiction != null)
            {
                buff.Append("jurisdiction", this.Jurisdiction);
            }
            if ((object)this.SubmissionDate != null)
            {
                buff.Append("submissionDate", this.SubmissionDate);
            }
            if ((object)this.DocumentStatus != null)
            {
                buff.Append("documentStatus", this.DocumentStatus);
            }
            if ((object)this.SurveyFormat != null)
            {
                buff.Append("surveyFormat", this.SurveyFormat);
            }
            if ((object)this.SurveyStatus != null)
            {
                buff.Append("surveyStatus", this.SurveyStatus);
            }
            if ((object)this.CommunityTitleSchemeNo != null)
            {
                buff.Append("communityTitleSchemeNo", this.CommunityTitleSchemeNo);
            }
            if ((object)this.CommunityTitleSchemeName != null)
            {
                buff.Append("communityTitleSchemeName", this.CommunityTitleSchemeName);
            }
            if ((object)this.FieldNoteFlag != null)
            {
                buff.Append("fieldNoteFlag", this.FieldNoteFlag);
            }
            if ((object)this.FieldNoteReference != null)
            {
                buff.Append("fieldNoteReference", this.FieldNoteReference);
            }
            if ((object)this.FieldReport != null)
            {
                buff.Append("fieldReport", this.FieldReport);
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
            if ((object)this.Purpose != null)
            {
                buff.AppendFormat("purpose = {0}", this.Purpose).AppendLine();
            }
            if ((object)this.StartTime != null)
            {
                buff.AppendFormat("startTime = {0}", this.StartTime).AppendLine();
            }
            if ((object)this.EndTime != null)
            {
                buff.AppendFormat("endTime = {0}", this.EndTime).AppendLine();
            }
            if ((object)this.Surveyor != null)
            {
                buff.AppendFormat("surveyor = {0}", this.Surveyor).AppendLine();
            }
            if ((object)this.SurveyorFirm != null)
            {
                buff.AppendFormat("surveyorFirm = {0}", this.SurveyorFirm).AppendLine();
            }
            if ((object)this.SurveyorReference != null)
            {
                buff.AppendFormat("surveyorReference = {0}", this.SurveyorReference).AppendLine();
            }
            if ((object)this.SurveyorRegistration != null)
            {
                buff.AppendFormat("surveyorRegistration = {0}", this.SurveyorRegistration).AppendLine();
            }
            if ((object)this.SurveyPurpose != null)
            {
                buff.AppendFormat("surveyPurpose = {0}", this.SurveyPurpose).AppendLine();
            }
            if ((object)this.Type != null)
            {
                buff.AppendFormat("type = {0}", this.Type).AppendLine();
            }
            if ((object)this.Class != null)
            {
                buff.AppendFormat("class = {0}", this.Class).AppendLine();
            }
            if ((object)this.County != null)
            {
                buff.AppendFormat("county = {0}", this.County).AppendLine();
            }
            if ((object)this.ApplyAtmosphericCorrection != null)
            {
                buff.AppendFormat("applyAtmosphericCorrection = {0}", this.ApplyAtmosphericCorrection).AppendLine();
            }
            if ((object)this.Pressure != null)
            {
                buff.AppendFormat("pressure = {0}", this.Pressure).AppendLine();
            }
            if ((object)this.Temperature != null)
            {
                buff.AppendFormat("temperature = {0}", this.Temperature).AppendLine();
            }
            if ((object)this.ApplySeaLevelCorrection != null)
            {
                buff.AppendFormat("applySeaLevelCorrection = {0}", this.ApplySeaLevelCorrection).AppendLine();
            }
            if ((object)this.ScaleFactor != null)
            {
                buff.AppendFormat("scaleFactor = {0}", this.ScaleFactor).AppendLine();
            }
            if ((object)this.SeaLevelCorrectionFactor != null)
            {
                buff.AppendFormat("seaLevelCorrectionFactor = {0}", this.SeaLevelCorrectionFactor).AppendLine();
            }
            if ((object)this.CombinedFactor != null)
            {
                buff.AppendFormat("combinedFactor = {0}", this.CombinedFactor).AppendLine();
            }
            if ((object)this.Jurisdiction != null)
            {
                buff.AppendFormat("jurisdiction = {0}", this.Jurisdiction).AppendLine();
            }
            if ((object)this.SubmissionDate != null)
            {
                buff.AppendFormat("submissionDate = {0}", this.SubmissionDate).AppendLine();
            }
            if ((object)this.DocumentStatus != null)
            {
                buff.AppendFormat("documentStatus = {0}", this.DocumentStatus).AppendLine();
            }
            if ((object)this.SurveyFormat != null)
            {
                buff.AppendFormat("surveyFormat = {0}", this.SurveyFormat).AppendLine();
            }
            if ((object)this.SurveyStatus != null)
            {
                buff.AppendFormat("surveyStatus = {0}", this.SurveyStatus).AppendLine();
            }
            if ((object)this.CommunityTitleSchemeNo != null)
            {
                buff.AppendFormat("communityTitleSchemeNo = {0}", this.CommunityTitleSchemeNo).AppendLine();
            }
            if ((object)this.CommunityTitleSchemeName != null)
            {
                buff.AppendFormat("communityTitleSchemeName = {0}", this.CommunityTitleSchemeName).AppendLine();
            }
            if ((object)this.FieldNoteFlag != null)
            {
                buff.AppendFormat("fieldNoteFlag = {0}", this.FieldNoteFlag).AppendLine();
            }
            if ((object)this.FieldNoteReference != null)
            {
                buff.AppendFormat("fieldNoteReference = {0}", this.FieldNoteReference).AppendLine();
            }
            if ((object)this.FieldReport != null)
            {
                buff.AppendFormat("fieldReport = {0}", this.FieldReport).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

