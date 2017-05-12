#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// The watershed region contains a 2D north/east or 3D north/east/elev list of points that define the boundary.
    /// A watershed is identified by the "name" attribute.
    /// It may have 1 or more Outlet elements.
    /// Sequence [1, 1]
    ///     Choice [1, 1]
    ///         PntList2D [1, 1]
    ///         PntList3D [1, 1]
    ///     Outlet [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Watershed : XsdBaseReader
    {
        public Watershed(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Area = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("area"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

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
            if ((object)this.Area != null)
            {
                buff.AppendFormat("area = {0}", this.Area).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
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
            if ((object)this.Area != null)
            {
                buff.Append("area", this.Area);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }

            return buff.ToString();
        }

        public string Name;

        public double? Area;

        public string Desc;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("Outlet"))
            {
                return Tuple.Create("Outlet", this.NewReader<Outlet>());
            }
            if (name.EqualsIgnoreCase("PntList3D"))
            {
                return Tuple.Create("PntList3D", this.NewReader<IList<double>>());
            }
            if (name.EqualsIgnoreCase("PntList2D"))
            {
                return Tuple.Create("PntList2D", this.NewReader<IList<double>>());
            }

            return null;
        }
    }
}
#endif

