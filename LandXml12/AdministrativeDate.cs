#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// This element stores a range of Administrative dates which may vary from jurisdiction to jurisdiction.
    /// </summary>

    public class AdministrativeDate : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.AdminDateType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adminDateType"));



            this.AdminDate = XsdConverter.Instance.Convert<DateTime>(
                    attributes.GetSafe("adminDate"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.AdminDateType != null)
            {
                buff.AppendFormat("adminDateType = {0}", this.AdminDateType).AppendLine();
            }
            if ((object)this.AdminDate != null)
            {
                buff.AppendFormat("adminDate = {0}", this.AdminDate).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.AdminDateType != null)
            {
                buff.AppendFormat(" adminDateType=\"{0}\"", this.AdminDateType);
            }
            if ((object)this.AdminDate != null)
            {
                buff.AppendFormat(" adminDate=\"{0}\"", this.AdminDate);
            }


            return buff.ToString();
        }

        /// <summary>
        /// This is the name of the admin date type for the Survey
        /// </summary>

        public string AdminDateType;

        public DateTime AdminDate;


    }
}
#endif

