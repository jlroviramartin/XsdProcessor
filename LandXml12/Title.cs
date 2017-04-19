#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// This may be expanded, but the LandXML schema is not really aimed at providing title information so I think name is sufficient
    /// </summary>

    public class Title : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.TitleType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("titleType"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.TitleType != null)
            {
                buff.AppendFormat("titleType = {0}", this.TitleType).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.TitleType != null)
            {
                buff.AppendFormat(" titleType=\"{0}\"", this.TitleType);
            }


            return buff.ToString();
        }

        public string Name;

        public string TitleType;


    }
}
#endif

