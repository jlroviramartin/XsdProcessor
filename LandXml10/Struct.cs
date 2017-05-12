#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Each Struct within a Structs collection element must have a unique  "name" attribute.
    /// The structure type is determined by the existance of one of the following elements: CircStruct or RectStruct.
    /// The Center element will contain the "north east" coordinate text value or a CgPoint "refPnt" attribute.
    /// Each Invert element contains a "refPipe" attribute to reference a Pipe element  "name"
    /// Sequence [1, 1]
    ///     Center [1, 1]
    ///     Choice [1, 1]
    ///         CircStruct [1, 1]
    ///         RectStruct [1, 1]
    ///         InletStruct [1, 1]
    ///         OutletStruct [1, 1]
    ///         Connection [1, 1]
    ///     Invert [1, *]
    ///     StructFlow [0, 1]
    ///     Feature [0, *]
    /// </summary>

    public class Struct : XsdBaseReader
    {
        public Struct(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public string Desc;

        public double? ElevRim;

        public double? ElevSump;

        public string OID;

        public StateType? State;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("StructFlow"))
            {
                return Tuple.Create("StructFlow", this.NewReader<StructFlow>());
            }
            if (name.EqualsIgnoreCase("Invert"))
            {
                return Tuple.Create("Invert", this.NewReader<Invert>());
            }
            if (name.EqualsIgnoreCase("Connection"))
            {
                return Tuple.Create("Connection", this.NewReader<Connection>());
            }
            if (name.EqualsIgnoreCase("OutletStruct"))
            {
                return Tuple.Create("OutletStruct", this.NewReader<OutletStruct>());
            }
            if (name.EqualsIgnoreCase("InletStruct"))
            {
                return Tuple.Create("InletStruct", this.NewReader<InletStruct>());
            }
            if (name.EqualsIgnoreCase("RectStruct"))
            {
                return Tuple.Create("RectStruct", this.NewReader<RectStruct>());
            }
            if (name.EqualsIgnoreCase("CircStruct"))
            {
                return Tuple.Create("CircStruct", this.NewReader<CircStruct>());
            }
            if (name.EqualsIgnoreCase("Center"))
            {
                return Tuple.Create("Center", this.NewReader<PointType>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.ElevRim = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("elevRim"));

            this.ElevSump = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("elevSump"));

            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.ElevRim != null)
            {
                buff.Append("elevRim", this.ElevRim);
            }
            if ((object)this.ElevSump != null)
            {
                buff.Append("elevSump", this.ElevSump);
            }
            if ((object)this.OID != null)
            {
                buff.Append("oID", this.OID);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.ElevRim != null)
            {
                buff.AppendFormat("elevRim = {0}", this.ElevRim).AppendLine();
            }
            if ((object)this.ElevSump != null)
            {
                buff.AppendFormat("elevSump = {0}", this.ElevSump).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

