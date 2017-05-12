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
    /// A sequential list of Line and/or Curve and/or Spiral elements.
    /// Sequence [1, 1]
    ///     Choice [1, *]
    ///         Line [0, *]
    ///         IrregularLine [0, *]
    ///         Curve [0, *]
    ///         Spiral [0, *]
    ///         Chain [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class CoordGeom : XsdBaseReader
    {
        public CoordGeom(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }

            return buff.ToString();
        }

        public string Desc;

        public string Name;

        public StateType? State;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("Chain"))
            {
                return Tuple.Create("Chain", this.NewReader<Chain>());
            }
            if (name.EqualsIgnoreCase("Spiral"))
            {
                return Tuple.Create("Spiral", this.NewReader<Spiral>());
            }
            if (name.EqualsIgnoreCase("Curve"))
            {
                return Tuple.Create("Curve", this.NewReader<Curve>());
            }
            if (name.EqualsIgnoreCase("IrregularLine"))
            {
                return Tuple.Create("IrregularLine", this.NewReader<IrregularLine>());
            }
            if (name.EqualsIgnoreCase("Line"))
            {
                return Tuple.Create("Line", this.NewReader<Line>());
            }

            return null;
        }
    }
}
#endif

