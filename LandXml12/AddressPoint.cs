//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime: <..>
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using XmlSchemaProcessor.Common;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Represents a 2D or 3D Address Point. The Address Point is the geocoded point with which to reference an address
    /// </summary>

    public class AddressPoint : PointType
    {
        public AddressPoint(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// This is a string to define the type of Geocode that the address point is for examplecentroid of parcel, Access Point etc.  This will be a jurisdictionally based list.
        /// </summary>

        public string AddressPointType;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.AddressPointType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("addressPointType"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.AddressPointType != null)
            {
                buff.Append("addressPointType", this.AddressPointType);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            if ((object)this.AddressPointType != null)
            {
                buff.AppendFormat("addressPointType = {0}", this.AddressPointType).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
