#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Used to describe specific Feature code / property type values. DocFileRef points to reference documentation
    /// Each Property element defines one piece of data.
    /// </summary>

    public class FeatureDictionary : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Version = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("version"));



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
            if ((object)this.Version != null)
            {
                buff.AppendFormat("version = {0}", this.Version).AppendLine();
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
            if ((object)this.Version != null)
            {
                buff.AppendFormat(" version=\"{0}\"", this.Version);
            }


            return buff.ToString();
        }

        public string Name;

        public string Version;


    }
}
#endif

