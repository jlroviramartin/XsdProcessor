#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class TargetSetup : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));



            this.TargetHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("targetHeight"));



            this.EdmTargetVertOffset = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("edmTargetVertOffset"));



            this.PrismConstant = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("prismConstant"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Id != null)
            {
                buff.AppendFormat("id = {0}", this.Id).AppendLine();
            }
            if ((object)this.TargetHeight != null)
            {
                buff.AppendFormat("targetHeight = {0}", this.TargetHeight).AppendLine();
            }
            if ((object)this.EdmTargetVertOffset != null)
            {
                buff.AppendFormat("edmTargetVertOffset = {0}", this.EdmTargetVertOffset).AppendLine();
            }
            if ((object)this.PrismConstant != null)
            {
                buff.AppendFormat("prismConstant = {0}", this.PrismConstant).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.AppendFormat(" id=\"{0}\"", this.Id);
            }
            if ((object)this.TargetHeight != null)
            {
                buff.AppendFormat(" targetHeight=\"{0}\"", this.TargetHeight);
            }
            if ((object)this.EdmTargetVertOffset != null)
            {
                buff.AppendFormat(" edmTargetVertOffset=\"{0}\"", this.EdmTargetVertOffset);
            }
            if ((object)this.PrismConstant != null)
            {
                buff.AppendFormat(" prismConstant=\"{0}\"", this.PrismConstant);
            }


            return buff.ToString();
        }

        public string Id;

        public double? TargetHeight;

        public double? EdmTargetVertOffset;

        public double? PrismConstant;


    }
}
#endif

