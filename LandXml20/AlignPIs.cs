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
    /// A sequential list of Alignment PI Definitions
    /// Sequence [2, *]
    ///     AlignPI [1, 1]
    /// </summary>

    public class AlignPIs : XsdBaseReader
    {
        public AlignPIs(System.Xml.XmlReader reader) : base(reader)
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
            if (name.EqualsIgnoreCase("AlignPI"))
            {
                return Tuple.Create("AlignPI", this.NewReader<AlignPI>());
            }

            return null;
        }
    }
}
#endif

