#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// A  Point of Vertical Intersection with a space delimited "station elevation" text value
    /// with a circular vertical curve defined by "length and "radius" attributes.
    /// </summary>

    public class CircCurve : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Length = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("length"));



            this.Radius = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("radius"));



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
            if ((object)this.Radius != null)
            {
                buff.AppendFormat("radius = {0}", this.Radius).AppendLine();
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
            if ((object)this.Radius != null)
            {
                buff.AppendFormat(" radius=\"{0}\"", this.Radius);
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

        public double Radius;

        public string Desc;


        public IList<double> Content;
    }
}
#endif

