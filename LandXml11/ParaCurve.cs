#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// A  Point of Vertical Intersection with a space delimited "station elevation" text value and a parabolic vertical curve defined by the "length" attribute.
    /// </summary>

    public class ParaCurve : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Length = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("length"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.Content = XsdConverter.Instance.Convert<IList<double>>(text);

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Length != null)
            {
                buff.AppendFormat("length = {0}", this.Length).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }


            if ((object)this.Content != null)
            {
                buff.AppendFormat("content = {0}", this.Content).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Length != null)
            {
                buff.AppendFormat(" length=\"{0}\"", this.Length);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }


            if ((object)this.Content != null)
            {
                buff.AppendFormat(" content = \"{0}\"", this.Content);
            }

            return buff.ToString();
        }

        public double Length;

        public string Desc;


        public IList<double> Content;
    }
}
#endif

