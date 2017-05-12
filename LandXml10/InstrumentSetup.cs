#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// The Instrument setup location is defined by either a coordinate text value ("north east" or "north east elev") or a CgPoint number reference "pntRef" attribute.
    /// Sequence [1, 1]
    ///     Choice [0, *]
    ///         InstrumentPoint [0, 1]
    ///         Backsight [0, *]
    ///         TargetSetup [0, *]
    ///         RawObservation [0, *]
    ///         ObservationGroup [0, *]
    ///         ControlChecks [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class InstrumentSetup : XsdBaseReader
    {
        public InstrumentSetup(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Id;

        public string InstrumentDetailsID;

        public string StationName;

        public double InstrumentHeight;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
        /// </summary>

        public double? OrientationAzimuth;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
        /// </summary>

        public double? CircleAzimuth;

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
            if (name.EqualsIgnoreCase("ControlChecks"))
            {
                return Tuple.Create("ControlChecks", this.NewReader<ControlChecks>());
            }
            if (name.EqualsIgnoreCase("ObservationGroup"))
            {
                return Tuple.Create("ObservationGroup", this.NewReader<ObservationGroup>());
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

            this.InstrumentDetailsID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("instrumentDetailsID"));

            this.StationName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("stationName"));

            this.InstrumentHeight = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("instrumentHeight"));

            this.OrientationAzimuth = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("orientationAzimuth"));

            this.CircleAzimuth = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("circleAzimuth"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.Append("id", this.Id);
            }
            if ((object)this.InstrumentDetailsID != null)
            {
                buff.Append("instrumentDetailsID", this.InstrumentDetailsID);
            }
            if ((object)this.StationName != null)
            {
                buff.Append("stationName", this.StationName);
            }
            if ((object)this.InstrumentHeight != null)
            {
                buff.Append("instrumentHeight", this.InstrumentHeight);
            }
            if ((object)this.OrientationAzimuth != null)
            {
                buff.Append("orientationAzimuth", this.OrientationAzimuth);
            }
            if ((object)this.CircleAzimuth != null)
            {
                buff.Append("circleAzimuth", this.CircleAzimuth);
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
            if ((object)this.InstrumentDetailsID != null)
            {
                buff.AppendFormat("instrumentDetailsID = {0}", this.InstrumentDetailsID).AppendLine();
            }
            if ((object)this.StationName != null)
            {
                buff.AppendFormat("stationName = {0}", this.StationName).AppendLine();
            }
            if ((object)this.InstrumentHeight != null)
            {
                buff.AppendFormat("instrumentHeight = {0}", this.InstrumentHeight).AppendLine();
            }
            if ((object)this.OrientationAzimuth != null)
            {
                buff.AppendFormat("orientationAzimuth = {0}", this.OrientationAzimuth).AppendLine();
            }
            if ((object)this.CircleAzimuth != null)
            {
                buff.AppendFormat("circleAzimuth = {0}", this.CircleAzimuth).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

