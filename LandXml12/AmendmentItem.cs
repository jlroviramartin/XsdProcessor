#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public class AmendmentItem : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.ElementName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("elementName"));



            this.OldName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oldName"));



            this.NewName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("newName"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.ElementName != null)
            {
                buff.AppendFormat("elementName = {0}", this.ElementName).AppendLine();
            }
            if ((object)this.OldName != null)
            {
                buff.AppendFormat("oldName = {0}", this.OldName).AppendLine();
            }
            if ((object)this.NewName != null)
            {
                buff.AppendFormat("newName = {0}", this.NewName).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.ElementName != null)
            {
                buff.AppendFormat(" elementName=\"{0}\"", this.ElementName);
            }
            if ((object)this.OldName != null)
            {
                buff.AppendFormat(" oldName=\"{0}\"", this.OldName);
            }
            if ((object)this.NewName != null)
            {
                buff.AppendFormat(" newName=\"{0}\"", this.NewName);
            }


            return buff.ToString();
        }

        public string ElementName;

        public string OldName;

        public string NewName;


    }
}
#endif

