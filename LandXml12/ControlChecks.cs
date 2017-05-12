#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Records check shots to known locations during field observations
    /// Sequence [1, 1]
    ///     Choice [0, *]
    ///         TestObservation [0, *]
    ///         ObservationGroup [0, *]
    ///         PointResults [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class ControlChecks : XsdBaseReader
    {
        public ControlChecks(System.Xml.XmlReader reader) : base(reader)
        {
        }

        #region XsdBaseReader

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
            if (name.EqualsIgnoreCase("PointResults"))
            {
                return Tuple.Create("PointResults", this.NewReader<PointResults>());
            }
            if (name.EqualsIgnoreCase("ObservationGroup"))
            {
                return Tuple.Create("ObservationGroup", this.NewReader<ObservationGroup>());
            }
            if (name.EqualsIgnoreCase("TestObservation"))
            {
                return Tuple.Create("TestObservation", this.NewReader<TestObservation>());
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

