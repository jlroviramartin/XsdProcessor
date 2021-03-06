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

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// This element is used to define the location or positional address of a parcel. The address record is not designed to be a postal address (ie it has not postcode or zipcode etc) The element also needs to be able to handle both primary addresses and aliases if required.
    /// Sequence [1, 1]
    ///     ComplexName [0, *]
    ///     RoadName [0, *]
    ///     AdministrativeArea [0, *]
    ///     AddressPoint [0, *]
    /// </summary>

    public class LocationAddress : XsdBaseReader
    {
        public LocationAddress(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// This Type is to define a ljurisdictional specific list of address types such a primary addres, alias, secondary, historical etc.
        /// </summary>

        public string AddressType;
        /// <summary>
        /// To define a Jurisdictional specific list of address living unit types for addressing
        /// </summary>

        public string FlatType;

        public string FlatNumber;
        /// <summary>
        /// To define a jurisdictionally specific list of floo level types for example, Lower Ground Floor
        /// </summary>

        public string FloorLevelType;

        public string FloorLevelNumber;

        public int? NumberFirst;

        public string NumberSuffixFirst;

        public int? NumberLast;

        public string NumberSuffixLast;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("AddressPoint"))
            {
                this.SetCurrent("AddressPoint", this.NewReader<AddressPoint>());
                return true;
            }
            if (name.EqualsIgnoreCase("AdministrativeArea"))
            {
                this.SetCurrent("AdministrativeArea", this.NewReader<AdministrativeArea>());
                return true;
            }
            if (name.EqualsIgnoreCase("RoadName"))
            {
                this.SetCurrent("RoadName", this.NewReader<RoadName>());
                return true;
            }
            if (name.EqualsIgnoreCase("ComplexName"))
            {
                this.SetCurrent("ComplexName", this.NewReader<ComplexName>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.AddressType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("addressType"));

            this.FlatType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("flatType"));

            this.FlatNumber = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("flatNumber"));

            this.FloorLevelType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("floorLevelType"));

            this.FloorLevelNumber = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("floorLevelNumber"));

            this.NumberFirst = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("numberFirst"));

            this.NumberSuffixFirst = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("numberSuffixFirst"));

            this.NumberLast = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("numberLast"));

            this.NumberSuffixLast = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("numberSuffixLast"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.AddressType != null)
            {
                buff.Append("addressType", this.AddressType);
            }
            if ((object)this.FlatType != null)
            {
                buff.Append("flatType", this.FlatType);
            }
            if ((object)this.FlatNumber != null)
            {
                buff.Append("flatNumber", this.FlatNumber);
            }
            if ((object)this.FloorLevelType != null)
            {
                buff.Append("floorLevelType", this.FloorLevelType);
            }
            if ((object)this.FloorLevelNumber != null)
            {
                buff.Append("floorLevelNumber", this.FloorLevelNumber);
            }
            if ((object)this.NumberFirst != null)
            {
                buff.Append("numberFirst", this.NumberFirst);
            }
            if ((object)this.NumberSuffixFirst != null)
            {
                buff.Append("numberSuffixFirst", this.NumberSuffixFirst);
            }
            if ((object)this.NumberLast != null)
            {
                buff.Append("numberLast", this.NumberLast);
            }
            if ((object)this.NumberSuffixLast != null)
            {
                buff.Append("numberSuffixLast", this.NumberSuffixLast);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            if ((object)this.AddressType != null)
            {
                buff.AppendFormat("addressType = {0}", this.AddressType).AppendLine();
            }
            if ((object)this.FlatType != null)
            {
                buff.AppendFormat("flatType = {0}", this.FlatType).AppendLine();
            }
            if ((object)this.FlatNumber != null)
            {
                buff.AppendFormat("flatNumber = {0}", this.FlatNumber).AppendLine();
            }
            if ((object)this.FloorLevelType != null)
            {
                buff.AppendFormat("floorLevelType = {0}", this.FloorLevelType).AppendLine();
            }
            if ((object)this.FloorLevelNumber != null)
            {
                buff.AppendFormat("floorLevelNumber = {0}", this.FloorLevelNumber).AppendLine();
            }
            if ((object)this.NumberFirst != null)
            {
                buff.AppendFormat("numberFirst = {0}", this.NumberFirst).AppendLine();
            }
            if ((object)this.NumberSuffixFirst != null)
            {
                buff.AppendFormat("numberSuffixFirst = {0}", this.NumberSuffixFirst).AppendLine();
            }
            if ((object)this.NumberLast != null)
            {
                buff.AppendFormat("numberLast = {0}", this.NumberLast).AppendLine();
            }
            if ((object)this.NumberSuffixLast != null)
            {
                buff.AppendFormat("numberSuffixLast = {0}", this.NumberSuffixLast).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
