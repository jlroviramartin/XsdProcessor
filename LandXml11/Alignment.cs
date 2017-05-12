#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// geometric horizontal alignment, PGL or chain typically representing a road design center line
    /// Choice [1, *]
    ///     Choice [1, 1]
    ///         Start [0, 1]
    ///         CoordGeom [1, 1]
    ///         AlignPIs [0, 1]
    ///         Cant [0, 1]
    ///     StaEquation [0, *]
    ///     Profile [0, *]
    ///     CrossSects [0, 1]
    ///     Superelevation [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Alignment : XsdBaseReader
    {
        public Alignment(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public double Length;

        public double StaStart;

        public string Desc;

        public string OID;

        public StateType? State;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("Superelevation"))
            {
                return Tuple.Create("Superelevation", this.NewReader<Superelevation>());
            }
            if (name.EqualsIgnoreCase("CrossSects"))
            {
                return Tuple.Create("CrossSects", this.NewReader<CrossSects>());
            }
            if (name.EqualsIgnoreCase("Profile"))
            {
                return Tuple.Create("Profile", this.NewReader<Profile>());
            }
            if (name.EqualsIgnoreCase("StaEquation"))
            {
                return Tuple.Create("StaEquation", this.NewReader<StaEquation>());
            }
            if (name.EqualsIgnoreCase("Cant"))
            {
                return Tuple.Create("Cant", this.NewReader<Cant>());
            }
            if (name.EqualsIgnoreCase("AlignPIs"))
            {
                return Tuple.Create("AlignPIs", this.NewReader<AlignPIs>());
            }
            if (name.EqualsIgnoreCase("CoordGeom"))
            {
                return Tuple.Create("CoordGeom", this.NewReader<CoordGeom>());
            }
            if (name.EqualsIgnoreCase("Start"))
            {
                return Tuple.Create("Start", this.NewReader<PointType>());
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

            this.Length = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("length"));

            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

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
            if ((object)this.Length != null)
            {
                buff.Append("length", this.Length);
            }
            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
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
            if ((object)this.Length != null)
            {
                buff.AppendFormat("length = {0}", this.Length).AppendLine();
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
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

