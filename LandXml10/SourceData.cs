#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// The collection of data that was used to create the surface.
    /// Sequence [1, *]
    ///     Choice [1, 1]
    ///         Chain [0, *]
    ///         PointFiles [0, *]
    ///         Boundaries [0, *]
    ///         Breaklines [0, *]
    ///         Contours [0, *]
    ///         DataPoints [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class SourceData : XsdBaseReader
    {
        public SourceData(System.Xml.XmlReader reader) : base(reader)
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
            if (name.EqualsIgnoreCase("DataPoints"))
            {
                return Tuple.Create("DataPoints", this.NewReader<DataPoints>());
            }
            if (name.EqualsIgnoreCase("Contours"))
            {
                return Tuple.Create("Contours", this.NewReader<Contours>());
            }
            if (name.EqualsIgnoreCase("Breaklines"))
            {
                return Tuple.Create("Breaklines", this.NewReader<Breaklines>());
            }
            if (name.EqualsIgnoreCase("Boundaries"))
            {
                return Tuple.Create("Boundaries", this.NewReader<Boundaries>());
            }
            if (name.EqualsIgnoreCase("PointFiles"))
            {
                return Tuple.Create("PointFiles", this.NewReader<PointFiles>());
            }
            if (name.EqualsIgnoreCase("Chain"))
            {
                return Tuple.Create("Chain", this.NewReader<Chain>());
            }

            return null;
        }
    }
}
#endif

