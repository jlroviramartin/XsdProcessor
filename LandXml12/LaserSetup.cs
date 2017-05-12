#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Choice [0, *]
    ///     InstrumentPoint [0, 1]
    ///     Backsight [0, 1]
    ///     TargetSetup [0, *]
    ///     RawObservation [1, 1]
    ///     FieldNote [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class LaserSetup : XsdBaseReader
    {
        public LaserSetup(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Id;

        public string StationName;

        public double? InstrumentHeight;

        public string LaserDetailsID;

        public double? MagDeclination;

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
            if (name.EqualsIgnoreCase("RawObservation"))
            {
                return Tuple.Create("RawObservation", this.NewReader<RawObservation>());
            }
            if (name.EqualsIgnoreCase("TargetSetup"))
            {
                return Tuple.Create("TargetSetup", this.NewReader<TargetSetup>());
            }
            if (name.EqualsIgnoreCase("Backsight"))
            {
                return Tuple.Create("Backsight", this.NewReader<Backsight>());
            }
            if (name.EqualsIgnoreCase("InstrumentPoint"))
            {
                return Tuple.Create("InstrumentPoint", this.NewReader<PointType>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));

            this.StationName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("stationName"));

            this.InstrumentHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("instrumentHeight"));

            this.LaserDetailsID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("laserDetailsID"));

            this.MagDeclination = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("magDeclination"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.Append("id", this.Id);
            }
            if ((object)this.StationName != null)
            {
                buff.Append("stationName", this.StationName);
            }
            if ((object)this.InstrumentHeight != null)
            {
                buff.Append("instrumentHeight", this.InstrumentHeight);
            }
            if ((object)this.LaserDetailsID != null)
            {
                buff.Append("laserDetailsID", this.LaserDetailsID);
            }
            if ((object)this.MagDeclination != null)
            {
                buff.Append("magDeclination", this.MagDeclination);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Id != null)
            {
                buff.AppendFormat("id = {0}", this.Id).AppendLine();
            }
            if ((object)this.StationName != null)
            {
                buff.AppendFormat("stationName = {0}", this.StationName).AppendLine();
            }
            if ((object)this.InstrumentHeight != null)
            {
                buff.AppendFormat("instrumentHeight = {0}", this.InstrumentHeight).AppendLine();
            }
            if ((object)this.LaserDetailsID != null)
            {
                buff.AppendFormat("laserDetailsID = {0}", this.LaserDetailsID).AppendLine();
            }
            if ((object)this.MagDeclination != null)
            {
                buff.AppendFormat("magDeclination = {0}", this.MagDeclination).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

