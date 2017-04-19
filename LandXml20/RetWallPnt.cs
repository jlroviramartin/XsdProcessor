#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// A retaining wall point defined by a space delimited "northing easting elevation" text value with height and offset attributes to define the wall point
    /// The height value is positive if the northing/easting/elevation point is at the bottom of the wall, negative if the point is at the top of the wall.
    /// The offset value is negative for left and positive for right.
    /// </summary>

    public class RetWallPnt : PointType3dReq
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Height = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("height"));



            this.Offset = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("offset"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Height != null)
            {
                buff.AppendFormat("height = {0}", this.Height).AppendLine();
            }
            if ((object)this.Offset != null)
            {
                buff.AppendFormat("offset = {0}", this.Offset).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Height != null)
            {
                buff.AppendFormat(" height=\"{0}\"", this.Height);
            }
            if ((object)this.Offset != null)
            {
                buff.AppendFormat(" offset=\"{0}\"", this.Offset);
            }


            return buff.ToString();
        }

        public double Height;

        public double Offset;


    }
}
#endif

