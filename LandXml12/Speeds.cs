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
    /// Choice [0, *]
    ///     DesignSpeed [1, *]
    ///     DesignSpeed85th [1, *]
    ///     PostedSpeed [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Speeds : XsdBaseReader
    {
        public Speeds(System.Xml.XmlReader reader) : base(reader)
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
            if (name.EqualsIgnoreCase("PostedSpeed"))
            {
                return Tuple.Create("PostedSpeed", this.NewReader<PostedSpeed>());
            }
            if (name.EqualsIgnoreCase("DesignSpeed85th"))
            {
                return Tuple.Create("DesignSpeed85th", this.NewReader<DesignSpeed85th>());
            }
            if (name.EqualsIgnoreCase("DesignSpeed"))
            {
                return Tuple.Create("DesignSpeed", this.NewReader<DesignSpeed>());
            }

            return null;
        }
    }
}
#endif

