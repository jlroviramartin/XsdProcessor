#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// This element is used to define the location or positional address of a parcel. The address record is not designed to be a postal address (ie it has not postcode or zipcode etc) The element also needs to be able to handle both primary addresses and aliases if required.
    /// </summary>

    public class LocationAddress : XsdBaseObject
    {
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

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

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

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.AddressType != null)
            {
                buff.AppendFormat(" addressType=\"{0}\"", this.AddressType);
            }
            if ((object)this.FlatType != null)
            {
                buff.AppendFormat(" flatType=\"{0}\"", this.FlatType);
            }
            if ((object)this.FlatNumber != null)
            {
                buff.AppendFormat(" flatNumber=\"{0}\"", this.FlatNumber);
            }
            if ((object)this.FloorLevelType != null)
            {
                buff.AppendFormat(" floorLevelType=\"{0}\"", this.FloorLevelType);
            }
            if ((object)this.FloorLevelNumber != null)
            {
                buff.AppendFormat(" floorLevelNumber=\"{0}\"", this.FloorLevelNumber);
            }
            if ((object)this.NumberFirst != null)
            {
                buff.AppendFormat(" numberFirst=\"{0}\"", this.NumberFirst);
            }
            if ((object)this.NumberSuffixFirst != null)
            {
                buff.AppendFormat(" numberSuffixFirst=\"{0}\"", this.NumberSuffixFirst);
            }
            if ((object)this.NumberLast != null)
            {
                buff.AppendFormat(" numberLast=\"{0}\"", this.NumberLast);
            }
            if ((object)this.NumberSuffixLast != null)
            {
                buff.AppendFormat(" numberSuffixLast=\"{0}\"", this.NumberSuffixLast);
            }


            return buff.ToString();
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


    }
}
#endif

