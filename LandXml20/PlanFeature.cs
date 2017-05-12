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
    /// A planimetric feature not otherwise defined by the schema, such as building footprints, guard rails, tree lines, lightpoles or signage.
    /// Choice [0, *]
    ///     CoordGeom [1, 1]
    ///     Location [0, *]
    ///     FieldNote [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class PlanFeature : XsdBaseReader
    {
        public PlanFeature(System.Xml.XmlReader reader) : base(reader)
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

            this.M = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("m"));

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
            if ((object)this.M != null)
            {
                buff.AppendFormat("m = {0}", this.M).AppendLine();
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
            if ((object)this.M != null)
            {
                buff.Append("m", this.M);
            }

            return buff.ToString();
        }

        public string Desc;

        public string Name;

        public StateType? State;
        /// <summary>
        /// A integer based index value to a table item in the material table.
        /// </summary>

        public IList<int?> M;


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
            if (name.EqualsIgnoreCase("Location"))
            {
                return Tuple.Create("Location", this.NewReader<PointType>());
            }
            if (name.EqualsIgnoreCase("CoordGeom"))
            {
                return Tuple.Create("CoordGeom", this.NewReader<CoordGeom>());
            }

            return null;
        }
    }
}
#endif

