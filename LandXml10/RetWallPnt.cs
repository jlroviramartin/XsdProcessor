#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    // needContent    : true
    // includeContent : false
    /// <summary>
    /// A retaining wall point defined by a space delimited "northing easting elevation" text value with height and offset attributes to define the wall point
    /// The height value is positive if the northing/easting/elevation point is at the bottom of the wall, negative if the point is at the top of the wall.
    /// The offset value is negative for left and positive for right.
    /// </summary>

    public class RetWallPnt : PointType3dReq
    {
        public RetWallPnt(System.Xml.XmlReader reader) : base(reader)
        {
        }

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
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Height != null)
            {
                buff.Append("height", this.Height);
            }
            if ((object)this.Offset != null)
            {
                buff.Append("offset", this.Offset);
            }

            return buff.ToString();
        }

        public double Height;

        public double Offset;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

