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
    /// Choice [0, *]
    ///     ThruLane [0, *]
    ///     PassingLane [0, *]
    ///     TurnLane [0, *]
    ///     TwoWayLeftTurnLane [0, *]
    ///     ClimbLane [0, *]
    ///     OffsetLane [0, *]
    ///     WideningLane [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Lanes : XsdBaseReader
    {
        public Lanes(System.Xml.XmlReader reader) : base(reader)
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
            if (name.EqualsIgnoreCase("WideningLane"))
            {
                return Tuple.Create("WideningLane", this.NewReader<WideningLane>());
            }
            if (name.EqualsIgnoreCase("OffsetLane"))
            {
                return Tuple.Create("OffsetLane", this.NewReader<OffsetLane>());
            }
            if (name.EqualsIgnoreCase("ClimbLane"))
            {
                return Tuple.Create("ClimbLane", this.NewReader<ClimbLane>());
            }
            if (name.EqualsIgnoreCase("TwoWayLeftTurnLane"))
            {
                return Tuple.Create("TwoWayLeftTurnLane", this.NewReader<TwoWayLeftTurnLane>());
            }
            if (name.EqualsIgnoreCase("TurnLane"))
            {
                return Tuple.Create("TurnLane", this.NewReader<TurnLane>());
            }
            if (name.EqualsIgnoreCase("PassingLane"))
            {
                return Tuple.Create("PassingLane", this.NewReader<PassingLane>());
            }
            if (name.EqualsIgnoreCase("ThruLane"))
            {
                return Tuple.Create("ThruLane", this.NewReader<ThruLane>());
            }

            return null;
        }
    }
}
#endif

