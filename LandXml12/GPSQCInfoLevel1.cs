#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week     
    /// </summary>

    public class GPSQCInfoLevel1 : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.GPSSolnType = XsdConverter.Instance.Convert<GPSSolutionTypeEnum?>(
                    attributes.GetSafe("GPSSolnType"));



            this.GPSSolnFreq = XsdConverter.Instance.Convert<GPSSolutionFrequencyEnum?>(
                    attributes.GetSafe("GPSSolnFreq"));



            this.NbrSatellites = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("nbrSatellites"));



            this.RDOP = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("RDOP"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.GPSSolnType != null)
            {
                buff.AppendFormat("GPSSolnType = {0}", this.GPSSolnType).AppendLine();
            }
            if ((object)this.GPSSolnFreq != null)
            {
                buff.AppendFormat("GPSSolnFreq = {0}", this.GPSSolnFreq).AppendLine();
            }
            if ((object)this.NbrSatellites != null)
            {
                buff.AppendFormat("nbrSatellites = {0}", this.NbrSatellites).AppendLine();
            }
            if ((object)this.RDOP != null)
            {
                buff.AppendFormat("RDOP = {0}", this.RDOP).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.GPSSolnType != null)
            {
                buff.AppendFormat(" GPSSolnType=\"{0}\"", this.GPSSolnType);
            }
            if ((object)this.GPSSolnFreq != null)
            {
                buff.AppendFormat(" GPSSolnFreq=\"{0}\"", this.GPSSolnFreq);
            }
            if ((object)this.NbrSatellites != null)
            {
                buff.AppendFormat(" nbrSatellites=\"{0}\"", this.NbrSatellites);
            }
            if ((object)this.RDOP != null)
            {
                buff.AppendFormat(" RDOP=\"{0}\"", this.RDOP);
            }


            return buff.ToString();
        }

        /// <summary>
        /// The GPS solution type indicates the type of computed solution for a GPS vector or position
        /// </summary>

        public GPSSolutionTypeEnum? GPSSolnType;
        /// <summary>
        /// The GPS solution frequency indicates the GPS frequencies used in the computed solution for a GPS vector or position 
        /// </summary>

        public GPSSolutionFrequencyEnum? GPSSolnFreq;

        public int? NbrSatellites;

        public double? RDOP;


    }
}
#endif

