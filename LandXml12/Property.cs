#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Used to include additional information that is not explicitly defined by the LandXML schema. Each Property element defines one piece of data.
    /// The "label" attribute defines the name of the value held in the "value" attribute.
    /// </summary>

    public class Property : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Label = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("label"));



            this.Value = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("value"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Label != null)
            {
                buff.AppendFormat("label = {0}", this.Label).AppendLine();
            }
            if ((object)this.Value != null)
            {
                buff.AppendFormat("value = {0}", this.Value).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Label != null)
            {
                buff.AppendFormat(" label=\"{0}\"", this.Label);
            }
            if ((object)this.Value != null)
            {
                buff.AppendFormat(" value=\"{0}\"", this.Value);
            }


            return buff.ToString();
        }

        public string Label;

        public string Value;


    }
}
#endif

