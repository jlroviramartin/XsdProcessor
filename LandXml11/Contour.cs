#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// The contour is defined by an elevation attribute and a 2D north/east list of points that define the geometry.
    /// is identified by the "name" attribute.
    /// Sequence [1, 1]
    ///     PntList2D [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class Contour : XsdBaseReader
    {
        public Contour(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public double Elev;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("PntList2D"))
            {
                return Tuple.Create("PntList2D", this.NewReader<IList<double>>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Elev = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("elev"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Elev != null)
            {
                buff.Append("elev", this.Elev);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Elev != null)
            {
                buff.AppendFormat("elev = {0}", this.Elev).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

