//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime: <..>
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using XmlSchemaProcessor.Common;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// This relates the new monument element to a survey - indicating its purpose in the survey and distrubed / replaced info as well
    /// Sequence [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class SurveyMonument : XsdBaseReader
    {
        public SurveyMonument(System.Xml.XmlReader reader) : base(reader)
        {
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

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                this.SetCurrent("Feature", this.NewReader<Feature>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

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

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.MntRef != null)
            {
                buff.Append("mntRef", this.MntRef);
            }
            if ((object)this.Purpose != null)
            {
                buff.Append("purpose", this.Purpose);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.AdoptedSurvey != null)
            {
                buff.Append("adoptedSurvey", this.AdoptedSurvey);
            }
            if ((object)this.DisturbedMonument != null)
            {
                buff.Append("disturbedMonument", this.DisturbedMonument);
            }
            if ((object)this.DisturbedDate != null)
            {
                buff.Append("disturbedDate", this.DisturbedDate);
            }
            if ((object)this.DisturbedAnnotation != null)
            {
                buff.Append("disturbedAnnotation", this.DisturbedAnnotation);
            }
            if ((object)this.ReplacedMonument != null)
            {
                buff.Append("replacedMonument", this.ReplacedMonument);
            }
            if ((object)this.ReplacedDate != null)
            {
                buff.Append("replacedDate", this.ReplacedDate);
            }
            if ((object)this.ReplacedAnnotation != null)
            {
                buff.Append("replacedAnnotation", this.ReplacedAnnotation);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

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

        #endregion
    }
}
#endif
