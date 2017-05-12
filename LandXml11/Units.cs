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
    /// All angular and direction values default to radians unless otherwise noted. Angular values, expressed in the specified Units.angleUnit are measured counter-clockwise from east=0. Horizontal directions, expressed in the specified Units.directionUnit are measured counter-clockwise from 0 degrees = north
    /// Choice [1, 1]
    ///     Metric [1, 1]
    ///     Imperial [1, 1]
    /// </summary>

    public class Units : XsdBaseReader
    {
        public Units(System.Xml.XmlReader reader) : base(reader)
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
            if (name.EqualsIgnoreCase("Imperial"))
            {
                return Tuple.Create("Imperial", this.NewReader<Imperial>());
            }
            if (name.EqualsIgnoreCase("Metric"))
            {
                return Tuple.Create("Metric", this.NewReader<Metric>());
            }

            return null;
        }
    }
}
#endif

