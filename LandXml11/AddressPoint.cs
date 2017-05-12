#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    // needContent    : true
    // includeContent : false
    /// <summary>
    /// Represents a 2D or 3D Address Point. The Address Point is the geocoded point with which to reference an address
    /// </summary>

    public class AddressPoint : PointType
    {
        public AddressPoint(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.AddressPointType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("addressPointType"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.AddressPointType != null)
            {
                buff.AppendFormat("addressPointType = {0}", this.AddressPointType).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.AddressPointType != null)
            {
                buff.Append("addressPointType", this.AddressPointType);
            }

            return buff.ToString();
        }

        /// <summary>
        /// This is a string to define the type of Geocode that the address point is for examplecentroid of parcel, Access Point etc.  This will be a jurisdictionally based list.
        /// </summary>

        public string AddressPointType;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

