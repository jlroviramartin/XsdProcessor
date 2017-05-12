#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// A collection of COGO points. (Cg = COGO = Cordinate Geometry)
    /// Sequence [1, 1]
    ///     CgPoint [0, *]
    ///     CgPoints [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class CgPoints : XsdBaseReader
    {
        public CgPoints(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Desc;

        public string Name;

        public StateType? State;

        public string Code;

        public uint? ZoneNumber;

        public DTMAttributeType? DTMAttribute;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("CgPoints"))
            {
                return Tuple.Create("CgPoints", this.NewReader<CgPoints>());
            }
            if (name.EqualsIgnoreCase("CgPoint"))
            {
                return Tuple.Create("CgPoint", this.NewReader<CgPoint>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.Code = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("code"));

            this.ZoneNumber = XsdConverter.Instance.Convert<uint?>(
                    attributes.GetSafe("zoneNumber"));

            this.DTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(
                    attributes.GetSafe("DTMAttribute"));

            return true;
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
            if ((object)this.Code != null)
            {
                buff.Append("code", this.Code);
            }
            if ((object)this.ZoneNumber != null)
            {
                buff.Append("zoneNumber", this.ZoneNumber);
            }
            if ((object)this.DTMAttribute != null)
            {
                buff.Append("DTMAttribute", this.DTMAttribute);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

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
            if ((object)this.Code != null)
            {
                buff.AppendFormat("code = {0}", this.Code).AppendLine();
            }
            if ((object)this.ZoneNumber != null)
            {
                buff.AppendFormat("zoneNumber = {0}", this.ZoneNumber).AppendLine();
            }
            if ((object)this.DTMAttribute != null)
            {
                buff.AppendFormat("DTMAttribute = {0}", this.DTMAttribute).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

