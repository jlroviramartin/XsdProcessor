#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Choice [1, *]
    ///     DailyTrafficVolume [1, 1]
    ///     DesignHour [1, 1]
    ///     PeakHour [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class TrafficVolume : XsdBaseReader
    {
        public TrafficVolume(System.Xml.XmlReader reader) : base(reader)
        {
        }

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("PeakHour"))
            {
                return Tuple.Create("PeakHour", this.NewReader<PeakHour>());
            }
            if (name.EqualsIgnoreCase("DesignHour"))
            {
                return Tuple.Create("DesignHour", this.NewReader<DesignHour>());
            }
            if (name.EqualsIgnoreCase("DailyTrafficVolume"))
            {
                return Tuple.Create("DailyTrafficVolume", this.NewReader<DailyTrafficVolume>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            return buff.ToString();
        }

        #endregion
    }
}
#endif

