#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// The collection of breaklines that were used to define the surface.
    /// Use is optional.
    /// Sequence [1, 1]
    ///     Breakline [0, *]
    ///     RetWall [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Breaklines : XsdBaseReader
    {
        public Breaklines(System.Xml.XmlReader reader) : base(reader)
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
            if (name.EqualsIgnoreCase("RetWall"))
            {
                return Tuple.Create("RetWall", this.NewReader<RetWall>());
            }
            if (name.EqualsIgnoreCase("Breakline"))
            {
                return Tuple.Create("Breakline", this.NewReader<Breakline>());
            }

            return null;
        }
    }
}
#endif

