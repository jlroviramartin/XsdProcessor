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
    /// First Curve Definition
    /// All [1, 1]
    ///     Curve [1, 1]
    /// </summary>

    public class Curve1 : XsdBaseReader
    {
        public Curve1(System.Xml.XmlReader reader) : base(reader)
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
            if (name.EqualsIgnoreCase("Curve"))
            {
                return Tuple.Create("Curve", this.NewReader<Curve>());
            }

            return null;
        }
    }
}
#endif

