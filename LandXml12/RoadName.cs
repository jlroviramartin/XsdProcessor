#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public class RoadName : XsdBaseReader
    {
        public RoadName(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// to define a jurisdictionally specific list of Road name types such a street, road, avenue etc.
        /// </summary>

        public string RoadNameType;

        public string _RoadName;
        /// <summary>
        /// to Allow a list of specific road suffixes to be specified, ie east, upper etc (ie Fred Street East)
        /// </summary>

        public string RoadNameSuffix;
        /// <summary>
        /// To define if the road is a public or private road.
        /// </summary>

        public string RoadType;
        /// <summary>
        /// A list of reference names values refering to one or more Parcel.name attributes.
        /// </summary>

        public IList<string> PclRef;

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

            this.RoadNameType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("roadNameType"));

            this._RoadName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("roadName"));

            this.RoadNameSuffix = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("roadNameSuffix"));

            this.RoadType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("roadType"));

            this.PclRef = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("pclRef"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.RoadNameType != null)
            {
                buff.Append("roadNameType", this.RoadNameType);
            }
            if ((object)this._RoadName != null)
            {
                buff.Append("roadName", this._RoadName);
            }
            if ((object)this.RoadNameSuffix != null)
            {
                buff.Append("roadNameSuffix", this.RoadNameSuffix);
            }
            if ((object)this.RoadType != null)
            {
                buff.Append("roadType", this.RoadType);
            }
            if ((object)this.PclRef != null)
            {
                buff.Append("pclRef", this.PclRef);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.RoadNameType != null)
            {
                buff.AppendFormat("roadNameType = {0}", this.RoadNameType).AppendLine();
            }
            if ((object)this._RoadName != null)
            {
                buff.AppendFormat("roadName = {0}", this._RoadName).AppendLine();
            }
            if ((object)this.RoadNameSuffix != null)
            {
                buff.AppendFormat("roadNameSuffix = {0}", this.RoadNameSuffix).AppendLine();
            }
            if ((object)this.RoadType != null)
            {
                buff.AppendFormat("roadType = {0}", this.RoadType).AppendLine();
            }
            if ((object)this.PclRef != null)
            {
                buff.AppendFormat("pclRef = {0}", this.PclRef).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

