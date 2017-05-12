#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Identifies a drain point from the watershed with a space delimited "northing easting elevation" value.
    /// If it drains to another known watershed, then the name of that watershed is identified by the "refWs" attribute.
    /// </summary>

    public class Outlet : PointType3dReq
    {
        public Outlet(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// A reference name value referring to WaterShed.name attribute.
        /// </summary>

        public string RefWS;

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

            this.RefWS = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("refWS"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.RefWS != null)
            {
                buff.Append("refWS", this.RefWS);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.RefWS != null)
            {
                buff.AppendFormat("refWS = {0}", this.RefWS).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

