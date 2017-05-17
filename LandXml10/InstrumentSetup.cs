//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime: <..>
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using XmlSchemaProcessor.Common;

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

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                this.SetCurrent("Feature", this.NewReader<Feature>());
                return true;
            }
            if (name.EqualsIgnoreCase("FieldNote"))
            {
                this.SetCurrent("FieldNote", this.NewReader<FieldNote>());
                return true;
            }
            if (name.EqualsIgnoreCase("ControlChecks"))
            {
                this.SetCurrent("ControlChecks", this.NewReader<ControlChecks>());
                return true;
            }
            if (name.EqualsIgnoreCase("ObservationGroup"))
            {
                this.SetCurrent("ObservationGroup", this.NewReader<ObservationGroup>());
                return true;
            }
            if (name.EqualsIgnoreCase("RawObservation"))
            {
                this.SetCurrent("RawObservation", this.NewReader<RawObservation>());
                return true;
            }
            if (name.EqualsIgnoreCase("TargetSetup"))
            {
                this.SetCurrent("TargetSetup", this.NewReader<TargetSetup>());
                return true;
            }
            if (name.EqualsIgnoreCase("Backsight"))
            {
                this.SetCurrent("Backsight", this.NewReader<Backsight>());
                return true;
            }
            if (name.EqualsIgnoreCase("InstrumentPoint"))
            {
                this.SetCurrent("InstrumentPoint", this.NewReader<PointType>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
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
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

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
            StringBuilder buff = new StringBuilder(base.ToString());

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
