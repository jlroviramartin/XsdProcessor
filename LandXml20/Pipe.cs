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
    /// Each Pipe within a Pipes collection element will have a unique  "name" attribute.
    /// The pipe type is determined by the existance of one of the following elements: CircPipe, ElliPipe or RectPipe.
    /// The "startRef and "endRef" attributes reference Struct "name" values.
    /// The start and end invert elevations for the pipe are defined in the Invert elements of referenced structures.
    /// Since a struct may have more than one Invert element, the Invert "pipeRef" attribute is used to select the correct invert element.
    /// Sequence [1, 1]
    ///     Choice [1, 1]
    ///         CircPipe [1, 1]
    ///         EggPipe [1, 1]
    ///         ElliPipe [1, 1]
    ///         RectPipe [1, 1]
    ///         Channel [1, 1]
    ///     PipeFlow [0, 1]
    ///     Center [0, 1]
    ///     Feature [0, *]
    /// </summary>

    public class Pipe : XsdBaseReader
    {
        public Pipe(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.RefEnd = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("refEnd"));

            this.RefStart = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("refStart"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Length = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("length"));

            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));

            this.Slope = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("slope"));

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

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.RefEnd != null)
            {
                buff.AppendFormat("refEnd = {0}", this.RefEnd).AppendLine();
            }
            if ((object)this.RefStart != null)
            {
                buff.AppendFormat("refStart = {0}", this.RefStart).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Length != null)
            {
                buff.AppendFormat("length = {0}", this.Length).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.Slope != null)
            {
                buff.AppendFormat("slope = {0}", this.Slope).AppendLine();
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

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.RefEnd != null)
            {
                buff.Append("refEnd", this.RefEnd);
            }
            if ((object)this.RefStart != null)
            {
                buff.Append("refStart", this.RefStart);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Length != null)
            {
                buff.Append("length", this.Length);
            }
            if ((object)this.OID != null)
            {
                buff.Append("oID", this.OID);
            }
            if ((object)this.Slope != null)
            {
                buff.Append("slope", this.Slope);
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

        public string Name;
        /// <summary>
        /// A reference name value referring to Struct.name attribute.
        /// </summary>

        public string RefEnd;
        /// <summary>
        /// A reference name value referring to Struct.name attribute.
        /// </summary>

        public string RefStart;

        public string Desc;

        public double? Length;

        public string OID;

        public double? Slope;

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
            if (name.EqualsIgnoreCase("Center"))
            {
                return Tuple.Create("Center", this.NewReader<PointType>());
            }
            if (name.EqualsIgnoreCase("PipeFlow"))
            {
                return Tuple.Create("PipeFlow", this.NewReader<PipeFlow>());
            }
            if (name.EqualsIgnoreCase("Channel"))
            {
                return Tuple.Create("Channel", this.NewReader<Channel>());
            }
            if (name.EqualsIgnoreCase("RectPipe"))
            {
                return Tuple.Create("RectPipe", this.NewReader<RectPipe>());
            }
            if (name.EqualsIgnoreCase("ElliPipe"))
            {
                return Tuple.Create("ElliPipe", this.NewReader<ElliPipe>());
            }
            if (name.EqualsIgnoreCase("EggPipe"))
            {
                return Tuple.Create("EggPipe", this.NewReader<EggPipe>());
            }
            if (name.EqualsIgnoreCase("CircPipe"))
            {
                return Tuple.Create("CircPipe", this.NewReader<CircPipe>());
            }

            return null;
        }
    }
}
#endif

