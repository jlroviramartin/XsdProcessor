#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Records the dealing information to allow  audit trail between the survey document and the titling system
    /// </summary>

    public class Amendment : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.DealingNumber = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("dealingNumber"));



            this.AmendmentDate = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("amendmentDate"));



            this.Comments = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("comments"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.DealingNumber != null)
            {
                buff.AppendFormat("dealingNumber = {0}", this.DealingNumber).AppendLine();
            }
            if ((object)this.AmendmentDate != null)
            {
                buff.AppendFormat("amendmentDate = {0}", this.AmendmentDate).AppendLine();
            }
            if ((object)this.Comments != null)
            {
                buff.AppendFormat("comments = {0}", this.Comments).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.DealingNumber != null)
            {
                buff.AppendFormat(" dealingNumber=\"{0}\"", this.DealingNumber);
            }
            if ((object)this.AmendmentDate != null)
            {
                buff.AppendFormat(" amendmentDate=\"{0}\"", this.AmendmentDate);
            }
            if ((object)this.Comments != null)
            {
                buff.AppendFormat(" comments=\"{0}\"", this.Comments);
            }


            return buff.ToString();
        }

        public string DealingNumber;

        public DateTime? AmendmentDate;

        public string Comments;


    }
}
#endif

