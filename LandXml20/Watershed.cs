#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// The watershed region contains a 2D north/east or 3D north/east/elev list of points that define the boundary.
    /// A watershed is identified by the "name" attribute.
    /// It may have 1 or more Outlet elements.
    /// </summary>

    public class Watershed : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Area = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("area"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



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
            if ((object)this.Area != null)
            {
                buff.AppendFormat("area = {0}", this.Area).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
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
            if ((object)this.Area != null)
            {
                buff.AppendFormat(" area=\"{0}\"", this.Area);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }


            return buff.ToString();
        }

        public string Name;

        public double? Area;

        public string Desc;


    }
}
#endif

