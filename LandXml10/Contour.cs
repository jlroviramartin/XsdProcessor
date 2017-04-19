#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// The contour is defined by an elevation attribute and a 2D north/east list of points that define the geometry.
    /// is identified by the "name" attribute.
    /// </summary>

    public class Contour : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Elev = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("elev"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Elev != null)
            {
                buff.AppendFormat("elev = {0}", this.Elev).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Elev != null)
            {
                buff.AppendFormat(" elev=\"{0}\"", this.Elev);
            }


            return buff.ToString();
        }

        public double Elev;


    }
}
#endif

