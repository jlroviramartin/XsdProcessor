#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Sequence [1, 1]
    ///     Choice [1, 1]
    ///         InstrumentDetails [1, 1]
    ///         LaserDetails [1, 1]
    ///         GPSReceiverDetails [1, 1]
    ///         GPSAntennaDetails [1, 1]
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class Equipment : XsdBaseReader
    {
        public Equipment(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            return buff.ToString();
        }


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("FieldNote"))
            {
                return Tuple.Create("FieldNote", this.NewReader<FieldNote>());
            }
            if (name.EqualsIgnoreCase("GPSAntennaDetails"))
            {
                return Tuple.Create("GPSAntennaDetails", this.NewReader<GPSAntennaDetails>());
            }
            if (name.EqualsIgnoreCase("GPSReceiverDetails"))
            {
                return Tuple.Create("GPSReceiverDetails", this.NewReader<GPSReceiverDetails>());
            }
            if (name.EqualsIgnoreCase("LaserDetails"))
            {
                return Tuple.Create("LaserDetails", this.NewReader<LaserDetails>());
            }
            if (name.EqualsIgnoreCase("InstrumentDetails"))
            {
                return Tuple.Create("InstrumentDetails", this.NewReader<InstrumentDetails>());
            }

            return null;
        }
    }
}
#endif

