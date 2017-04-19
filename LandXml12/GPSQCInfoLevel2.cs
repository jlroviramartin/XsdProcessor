#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public class GPSQCInfoLevel2 : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.CovarianceXX = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("covarianceXX"));



            this.CovarianceXY = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("covarianceXY"));



            this.CovarianceXZ = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("covarianceXZ"));



            this.CovarianceYY = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("covarianceYY"));



            this.CovarianceYZ = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("covarianceYZ"));



            this.CovarianceZZ = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("covarianceZZ"));



            this.GPSSolnType = XsdConverter.Instance.Convert<GPSSolutionTypeEnum?>(
                    attributes.GetSafe("GPSSolnType"));



            this.GPSSolnFreq = XsdConverter.Instance.Convert<GPSSolutionFrequencyEnum?>(
                    attributes.GetSafe("GPSSolnFreq"));



            this.RMS = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("RMS"));



            this.Ratio = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("ratio"));



            this.ReferenceVariance = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("referenceVariance"));



            this.NbrSatellites = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("nbrSatellites"));



            this.StartTime = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("startTime"));



            this.StopTime = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("stopTime"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.CovarianceXX != null)
            {
                buff.AppendFormat("covarianceXX = {0}", this.CovarianceXX).AppendLine();
            }
            if ((object)this.CovarianceXY != null)
            {
                buff.AppendFormat("covarianceXY = {0}", this.CovarianceXY).AppendLine();
            }
            if ((object)this.CovarianceXZ != null)
            {
                buff.AppendFormat("covarianceXZ = {0}", this.CovarianceXZ).AppendLine();
            }
            if ((object)this.CovarianceYY != null)
            {
                buff.AppendFormat("covarianceYY = {0}", this.CovarianceYY).AppendLine();
            }
            if ((object)this.CovarianceYZ != null)
            {
                buff.AppendFormat("covarianceYZ = {0}", this.CovarianceYZ).AppendLine();
            }
            if ((object)this.CovarianceZZ != null)
            {
                buff.AppendFormat("covarianceZZ = {0}", this.CovarianceZZ).AppendLine();
            }
            if ((object)this.GPSSolnType != null)
            {
                buff.AppendFormat("GPSSolnType = {0}", this.GPSSolnType).AppendLine();
            }
            if ((object)this.GPSSolnFreq != null)
            {
                buff.AppendFormat("GPSSolnFreq = {0}", this.GPSSolnFreq).AppendLine();
            }
            if ((object)this.RMS != null)
            {
                buff.AppendFormat("RMS = {0}", this.RMS).AppendLine();
            }
            if ((object)this.Ratio != null)
            {
                buff.AppendFormat("ratio = {0}", this.Ratio).AppendLine();
            }
            if ((object)this.ReferenceVariance != null)
            {
                buff.AppendFormat("referenceVariance = {0}", this.ReferenceVariance).AppendLine();
            }
            if ((object)this.NbrSatellites != null)
            {
                buff.AppendFormat("nbrSatellites = {0}", this.NbrSatellites).AppendLine();
            }
            if ((object)this.StartTime != null)
            {
                buff.AppendFormat("startTime = {0}", this.StartTime).AppendLine();
            }
            if ((object)this.StopTime != null)
            {
                buff.AppendFormat("stopTime = {0}", this.StopTime).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.CovarianceXX != null)
            {
                buff.AppendFormat(" covarianceXX=\"{0}\"", this.CovarianceXX);
            }
            if ((object)this.CovarianceXY != null)
            {
                buff.AppendFormat(" covarianceXY=\"{0}\"", this.CovarianceXY);
            }
            if ((object)this.CovarianceXZ != null)
            {
                buff.AppendFormat(" covarianceXZ=\"{0}\"", this.CovarianceXZ);
            }
            if ((object)this.CovarianceYY != null)
            {
                buff.AppendFormat(" covarianceYY=\"{0}\"", this.CovarianceYY);
            }
            if ((object)this.CovarianceYZ != null)
            {
                buff.AppendFormat(" covarianceYZ=\"{0}\"", this.CovarianceYZ);
            }
            if ((object)this.CovarianceZZ != null)
            {
                buff.AppendFormat(" covarianceZZ=\"{0}\"", this.CovarianceZZ);
            }
            if ((object)this.GPSSolnType != null)
            {
                buff.AppendFormat(" GPSSolnType=\"{0}\"", this.GPSSolnType);
            }
            if ((object)this.GPSSolnFreq != null)
            {
                buff.AppendFormat(" GPSSolnFreq=\"{0}\"", this.GPSSolnFreq);
            }
            if ((object)this.RMS != null)
            {
                buff.AppendFormat(" RMS=\"{0}\"", this.RMS);
            }
            if ((object)this.Ratio != null)
            {
                buff.AppendFormat(" ratio=\"{0}\"", this.Ratio);
            }
            if ((object)this.ReferenceVariance != null)
            {
                buff.AppendFormat(" referenceVariance=\"{0}\"", this.ReferenceVariance);
            }
            if ((object)this.NbrSatellites != null)
            {
                buff.AppendFormat(" nbrSatellites=\"{0}\"", this.NbrSatellites);
            }
            if ((object)this.StartTime != null)
            {
                buff.AppendFormat(" startTime=\"{0}\"", this.StartTime);
            }
            if ((object)this.StopTime != null)
            {
                buff.AppendFormat(" stopTime=\"{0}\"", this.StopTime);
            }


            return buff.ToString();
        }

        public double? CovarianceXX;

        public double? CovarianceXY;

        public double? CovarianceXZ;

        public double? CovarianceYY;

        public double? CovarianceYZ;

        public double? CovarianceZZ;
        /// <summary>
        /// The GPS solution type indicates the type of computed solution for a GPS vector or position
        /// </summary>

        public GPSSolutionTypeEnum? GPSSolnType;
        /// <summary>
        /// The GPS solution frequency indicates the GPS frequencies used in the computed solution for a GPS vector or position 
        /// </summary>

        public GPSSolutionFrequencyEnum? GPSSolnFreq;

        public double? RMS;

        public double? Ratio;

        public double? ReferenceVariance;

        public int? NbrSatellites;
        /// <summary>
        ///  GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week.
        /// </summary>

        public double? StartTime;
        /// <summary>
        ///  GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week.
        /// </summary>

        public double? StopTime;


    }
}
#endif

