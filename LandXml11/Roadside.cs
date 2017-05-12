#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Choice [0, *]
    ///     ObstructionOffset [0, *]
    ///     BikeFacilities [0, *]
    ///     RoadSign [0, *]
    ///     DrivewayDensity [0, *]
    ///     HazardRating [0, *]
    ///     Ditch [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Roadside : XsdBaseReader
    {
        public Roadside(System.Xml.XmlReader reader) : base(reader)
        {
        }

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("Ditch"))
            {
                return Tuple.Create("Ditch", this.NewReader<Ditch>());
            }
            if (name.EqualsIgnoreCase("HazardRating"))
            {
                return Tuple.Create("HazardRating", this.NewReader<HazardRating>());
            }
            if (name.EqualsIgnoreCase("DrivewayDensity"))
            {
                return Tuple.Create("DrivewayDensity", this.NewReader<DrivewayDensity>());
            }
            if (name.EqualsIgnoreCase("RoadSign"))
            {
                return Tuple.Create("RoadSign", this.NewReader<RoadSign>());
            }
            if (name.EqualsIgnoreCase("BikeFacilities"))
            {
                return Tuple.Create("BikeFacilities", this.NewReader<BikeFacilities>());
            }
            if (name.EqualsIgnoreCase("ObstructionOffset"))
            {
                return Tuple.Create("ObstructionOffset", this.NewReader<ObstructionOffset>());
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

