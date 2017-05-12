#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// A Single Alignment PI Definition
    /// Choice [1, *]
    ///     Station [1, 1]
    ///     PI [1, 1]
    ///     InSpiral [0, 1]
    ///     Curve1 [0, 1]
    ///     ConnSpiral [0, 1]
    ///     Curve2 [0, 1]
    ///     OutSpiral [0, 1]
    /// </summary>

    public class AlignPI : XsdBaseReader
    {
        public AlignPI(System.Xml.XmlReader reader) : base(reader)
        {
        }

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("OutSpiral"))
            {
                return Tuple.Create("OutSpiral", this.NewReader<OutSpiral>());
            }
            if (name.EqualsIgnoreCase("Curve2"))
            {
                return Tuple.Create("Curve2", this.NewReader<Curve2>());
            }
            if (name.EqualsIgnoreCase("ConnSpiral"))
            {
                return Tuple.Create("ConnSpiral", this.NewReader<ConnSpiral>());
            }
            if (name.EqualsIgnoreCase("Curve1"))
            {
                return Tuple.Create("Curve1", this.NewReader<Curve1>());
            }
            if (name.EqualsIgnoreCase("InSpiral"))
            {
                return Tuple.Create("InSpiral", this.NewReader<InSpiral>());
            }
            if (name.EqualsIgnoreCase("PI"))
            {
                return Tuple.Create("PI", this.NewReader<PointType>());
            }
            if (name.EqualsIgnoreCase("Station"))
            {
                return Tuple.Create("Station", this.NewReader<double>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            return buff.ToString();
        }

        #endregion
    }
}
#endif

