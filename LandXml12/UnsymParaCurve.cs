#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// A  Point of Vertical Intersection with a space delimited "station elevation" text value.
    /// with an unsymetrical parabolic vertical curve defined by "lengthIn and "lengthOut" attributes.
    /// </summary>

    public class UnsymParaCurve : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.LengthIn = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("lengthIn"));



            this.LengthOut = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("lengthOut"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.Content = XsdConverter.Instance.Convert<IList<double>>(text);

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.LengthIn != null)
            {
                buff.AppendFormat("lengthIn = {0}", this.LengthIn).AppendLine();
            }
            if ((object)this.LengthOut != null)
            {
                buff.AppendFormat("lengthOut = {0}", this.LengthOut).AppendLine();
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

            if ((object)this.LengthIn != null)
            {
                buff.AppendFormat(" lengthIn=\"{0}\"", this.LengthIn);
            }
            if ((object)this.LengthOut != null)
            {
                buff.AppendFormat(" lengthOut=\"{0}\"", this.LengthOut);
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

        public double LengthIn;

        public double LengthOut;

        public string Desc;


        public IList<double> Content;
    }
}
#endif

