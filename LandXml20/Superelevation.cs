#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Choice [1, *]
    ///     BeginRunoutSta [0, *]
    ///     BeginRunoffSta [0, *]
    ///     FullSuperSta [0, *]
    ///     FullSuperelev [1, *]
    ///     RunoffSta [0, *]
    ///     StartofRunoutSta [0, *]
    ///     EndofRunoutSta [0, *]
    ///     AdverseSE [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Superelevation : XsdBaseReader
    {
        public Superelevation(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? StaStart;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? StaEnd;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("AdverseSE"))
            {
                return Tuple.Create("AdverseSE", this.NewReader<AdverseSEType>());
            }
            if (name.EqualsIgnoreCase("EndofRunoutSta"))
            {
                return Tuple.Create("EndofRunoutSta", this.NewReader<double>());
            }
            if (name.EqualsIgnoreCase("StartofRunoutSta"))
            {
                return Tuple.Create("StartofRunoutSta", this.NewReader<double>());
            }
            if (name.EqualsIgnoreCase("RunoffSta"))
            {
                return Tuple.Create("RunoffSta", this.NewReader<double>());
            }
            if (name.EqualsIgnoreCase("FullSuperelev"))
            {
                return Tuple.Create("FullSuperelev", this.NewReader<double>());
            }
            if (name.EqualsIgnoreCase("FullSuperSta"))
            {
                return Tuple.Create("FullSuperSta", this.NewReader<double>());
            }
            if (name.EqualsIgnoreCase("BeginRunoffSta"))
            {
                return Tuple.Create("BeginRunoffSta", this.NewReader<double>());
            }
            if (name.EqualsIgnoreCase("BeginRunoutSta"))
            {
                return Tuple.Create("BeginRunoutSta", this.NewReader<double>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.StaStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staStart"));

            this.StaEnd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staEnd"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.StaEnd != null)
            {
                buff.Append("staEnd", this.StaEnd);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat("staEnd = {0}", this.StaEnd).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

