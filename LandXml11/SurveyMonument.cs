#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// This relates the new monument element to a survey - indicating its purpose in the survey and distrubed / replaced info as well
    /// </summary>

    public class SurveyMonument : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.MntRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("mntRef"));



            this.Purpose = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("purpose"));



            this.State = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("state"));



            this.AdoptedSurvey = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adoptedSurvey"));



            this.DisturbedMonument = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("disturbedMonument"));



            this.DisturbedDate = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("disturbedDate"));



            this.DisturbedAnnotation = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("disturbedAnnotation"));



            this.ReplacedMonument = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("replacedMonument"));



            this.ReplacedDate = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("replacedDate"));



            this.ReplacedAnnotation = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("replacedAnnotation"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.MntRef != null)
            {
                buff.AppendFormat("mntRef = {0}", this.MntRef).AppendLine();
            }
            if ((object)this.Purpose != null)
            {
                buff.AppendFormat("purpose = {0}", this.Purpose).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.AdoptedSurvey != null)
            {
                buff.AppendFormat("adoptedSurvey = {0}", this.AdoptedSurvey).AppendLine();
            }
            if ((object)this.DisturbedMonument != null)
            {
                buff.AppendFormat("disturbedMonument = {0}", this.DisturbedMonument).AppendLine();
            }
            if ((object)this.DisturbedDate != null)
            {
                buff.AppendFormat("disturbedDate = {0}", this.DisturbedDate).AppendLine();
            }
            if ((object)this.DisturbedAnnotation != null)
            {
                buff.AppendFormat("disturbedAnnotation = {0}", this.DisturbedAnnotation).AppendLine();
            }
            if ((object)this.ReplacedMonument != null)
            {
                buff.AppendFormat("replacedMonument = {0}", this.ReplacedMonument).AppendLine();
            }
            if ((object)this.ReplacedDate != null)
            {
                buff.AppendFormat("replacedDate = {0}", this.ReplacedDate).AppendLine();
            }
            if ((object)this.ReplacedAnnotation != null)
            {
                buff.AppendFormat("replacedAnnotation = {0}", this.ReplacedAnnotation).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.MntRef != null)
            {
                buff.AppendFormat(" mntRef=\"{0}\"", this.MntRef);
            }
            if ((object)this.Purpose != null)
            {
                buff.AppendFormat(" purpose=\"{0}\"", this.Purpose);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.AdoptedSurvey != null)
            {
                buff.AppendFormat(" adoptedSurvey=\"{0}\"", this.AdoptedSurvey);
            }
            if ((object)this.DisturbedMonument != null)
            {
                buff.AppendFormat(" disturbedMonument=\"{0}\"", this.DisturbedMonument);
            }
            if ((object)this.DisturbedDate != null)
            {
                buff.AppendFormat(" disturbedDate=\"{0}\"", this.DisturbedDate);
            }
            if ((object)this.DisturbedAnnotation != null)
            {
                buff.AppendFormat(" disturbedAnnotation=\"{0}\"", this.DisturbedAnnotation);
            }
            if ((object)this.ReplacedMonument != null)
            {
                buff.AppendFormat(" replacedMonument=\"{0}\"", this.ReplacedMonument);
            }
            if ((object)this.ReplacedDate != null)
            {
                buff.AppendFormat(" replacedDate=\"{0}\"", this.ReplacedDate);
            }
            if ((object)this.ReplacedAnnotation != null)
            {
                buff.AppendFormat(" replacedAnnotation=\"{0}\"", this.ReplacedAnnotation);
            }


            return buff.ToString();
        }

        /// <summary>
        /// A reference name value referring to monument.name attribute.
        /// </summary>

        public string MntRef;
        /// <summary>
        /// This is a list of purposes that the monument was used for on this survey.  The desired list may be based on local regulations. 
        /// </summary>

        public string Purpose;
        /// <summary>
        /// This is a list of states for a monument each  jurisdiction may haqve a list defined by regulation. 
        /// </summary>

        public string State;

        public string AdoptedSurvey;

        public string DisturbedMonument;

        public DateTime? DisturbedDate;

        public string DisturbedAnnotation;

        public string ReplacedMonument;

        public DateTime? ReplacedDate;

        public string ReplacedAnnotation;


    }
}
#endif

