#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Records the dealing information to allow  audit trail between the survey document and the titling system
    /// Sequence [1, 1]
    ///     AmendmentItem [1, *]
    /// </summary>

    public class Amendment : XsdBaseReader
    {
        public Amendment(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string DealingNumber;

        public DateTime? AmendmentDate;

        public string Comments;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("AmendmentItem"))
            {
                return Tuple.Create("AmendmentItem", this.NewReader<AmendmentItem>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

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

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.DealingNumber != null)
            {
                buff.Append("dealingNumber", this.DealingNumber);
            }
            if ((object)this.AmendmentDate != null)
            {
                buff.Append("amendmentDate", this.AmendmentDate);
            }
            if ((object)this.Comments != null)
            {
                buff.Append("comments", this.Comments);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

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

        #endregion
    }
}
#endif

