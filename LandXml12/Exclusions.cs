#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// An Exclusion is an area which has been reserved from a tenure for a specific purpose but may have no defined spatial extent for example 10ha for road. A single parcel could have more than one eclusion for different purposes.
    /// </summary>

    public class Exclusions : XsdBaseReader
    {
        public Exclusions(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// This is a jurisdictionally based list of exclusions for a Title example would be exclusions for Road, Track, Esplanade etc 
        /// </summary>

        public string ExclusionType;

        public double Area;

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

            this.ExclusionType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("exclusionType"));

            this.Area = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("area"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.ExclusionType != null)
            {
                buff.Append("exclusionType", this.ExclusionType);
            }
            if ((object)this.Area != null)
            {
                buff.Append("area", this.Area);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.ExclusionType != null)
            {
                buff.AppendFormat("exclusionType = {0}", this.ExclusionType).AppendLine();
            }
            if ((object)this.Area != null)
            {
                buff.AppendFormat("area = {0}", this.Area).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

