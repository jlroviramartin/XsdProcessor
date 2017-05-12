#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// This element stores the administrative boundaries for a survey
    /// </summary>

    public class AdministrativeArea : XsdBaseReader
    {
        public AdministrativeArea(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.AdminAreaType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adminAreaType"));

            this.AdminAreaName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adminAreaName"));

            this.AdminAreaCode = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("adminAreaCode"));

            this.PclRef = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("pclRef"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.AdminAreaType != null)
            {
                buff.AppendFormat("adminAreaType = {0}", this.AdminAreaType).AppendLine();
            }
            if ((object)this.AdminAreaName != null)
            {
                buff.AppendFormat("adminAreaName = {0}", this.AdminAreaName).AppendLine();
            }
            if ((object)this.AdminAreaCode != null)
            {
                buff.AppendFormat("adminAreaCode = {0}", this.AdminAreaCode).AppendLine();
            }
            if ((object)this.PclRef != null)
            {
                buff.AppendFormat("pclRef = {0}", this.PclRef).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.AdminAreaType != null)
            {
                buff.Append("adminAreaType", this.AdminAreaType);
            }
            if ((object)this.AdminAreaName != null)
            {
                buff.Append("adminAreaName", this.AdminAreaName);
            }
            if ((object)this.AdminAreaCode != null)
            {
                buff.Append("adminAreaCode", this.AdminAreaCode);
            }
            if ((object)this.PclRef != null)
            {
                buff.Append("pclRef", this.PclRef);
            }

            return buff.ToString();
        }

        /// <summary>
        /// This is a jurdictionally specific list of types and may include parish, town, local government, locality etc
        /// </summary>

        public string AdminAreaType;

        public string AdminAreaName;

        public string AdminAreaCode;
        /// <summary>
        /// A list of reference names values refering to one or more Parcel.name attributes.
        /// </summary>

        public IList<string> PclRef;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

