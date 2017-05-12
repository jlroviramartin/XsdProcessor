#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// This is a new element that represents a physical monument placed to mark a CgPoint within a survey
    /// </summary>

    public class Monument : XsdBaseReader
    {
        public Monument(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;
        /// <summary>
        /// A reference name value referring to a PointType derived name attribute. An attribute if this type contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data.
        /// </summary>

        public string PntRef;

        public string Desc;

        public StateType? State;
        /// <summary>
        /// This indicates the material makeup of the Monument
        /// </summary>

        public MonumentType? Type;
        /// <summary>
        /// This gives a general indication of the condition of the monument
        /// </summary>

        public MonumentCondition? Condition;
        /// <summary>
        /// This indicates the category of a geodetic Monument
        /// </summary>

        public MonumentCategory? Category;
        /// <summary>
        /// Indicates whether there is any physical structure
        ///    for the monument - helps location, these enumerations may need expanding
        /// </summary>

        public BeaconType? Beacon;
        /// <summary>
        /// Indicates any structure that protects the
        ///   monument, these enumerations may need expanding
        /// </summary>

        public BeaconProtectionType? BeaconProtection;

        public string OID;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.PntRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("pntRef"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.Type = XsdConverter.Instance.Convert<MonumentType?>(
                    attributes.GetSafe("type"));

            this.Condition = XsdConverter.Instance.Convert<MonumentCondition?>(
                    attributes.GetSafe("condition"));

            this.Category = XsdConverter.Instance.Convert<MonumentCategory?>(
                    attributes.GetSafe("category"));

            this.Beacon = XsdConverter.Instance.Convert<BeaconType?>(
                    attributes.GetSafe("beacon"));

            this.BeaconProtection = XsdConverter.Instance.Convert<BeaconProtectionType?>(
                    attributes.GetSafe("beaconProtection"));

            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.PntRef != null)
            {
                buff.Append("pntRef", this.PntRef);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.Type != null)
            {
                buff.Append("type", this.Type);
            }
            if ((object)this.Condition != null)
            {
                buff.Append("condition", this.Condition);
            }
            if ((object)this.Category != null)
            {
                buff.Append("category", this.Category);
            }
            if ((object)this.Beacon != null)
            {
                buff.Append("beacon", this.Beacon);
            }
            if ((object)this.BeaconProtection != null)
            {
                buff.Append("beaconProtection", this.BeaconProtection);
            }
            if ((object)this.OID != null)
            {
                buff.Append("oID", this.OID);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.PntRef != null)
            {
                buff.AppendFormat("pntRef = {0}", this.PntRef).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.Type != null)
            {
                buff.AppendFormat("type = {0}", this.Type).AppendLine();
            }
            if ((object)this.Condition != null)
            {
                buff.AppendFormat("condition = {0}", this.Condition).AppendLine();
            }
            if ((object)this.Category != null)
            {
                buff.AppendFormat("category = {0}", this.Category).AppendLine();
            }
            if ((object)this.Beacon != null)
            {
                buff.AppendFormat("beacon = {0}", this.Beacon).AppendLine();
            }
            if ((object)this.BeaconProtection != null)
            {
                buff.AppendFormat("beaconProtection = {0}", this.BeaconProtection).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

