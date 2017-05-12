#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Sequence [1, 1]
    ///     Choice [0, *]
    ///         TargetSetup [0, *]
    ///         GPSPosition [1, 1]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class GPSSetup : XsdBaseReader
    {
        public GPSSetup(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));

            this.AntennaHeight = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("antennaHeight"));

            this.StationName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("stationName"));

            this.GPSAntennaDetailsID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("GPSAntennaDetailsID"));

            this.GPSReceiverDetailsID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("GPSReceiverDetailsID"));

            this.ObservationDataLink = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("observationDataLink"));

            this.StationDescription = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("stationDescription"));

            this.StartTime = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("startTime"));

            this.StopTime = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("stopTime"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Id != null)
            {
                buff.AppendFormat("id = {0}", this.Id).AppendLine();
            }
            if ((object)this.AntennaHeight != null)
            {
                buff.AppendFormat("antennaHeight = {0}", this.AntennaHeight).AppendLine();
            }
            if ((object)this.StationName != null)
            {
                buff.AppendFormat("stationName = {0}", this.StationName).AppendLine();
            }
            if ((object)this.GPSAntennaDetailsID != null)
            {
                buff.AppendFormat("GPSAntennaDetailsID = {0}", this.GPSAntennaDetailsID).AppendLine();
            }
            if ((object)this.GPSReceiverDetailsID != null)
            {
                buff.AppendFormat("GPSReceiverDetailsID = {0}", this.GPSReceiverDetailsID).AppendLine();
            }
            if ((object)this.ObservationDataLink != null)
            {
                buff.AppendFormat("observationDataLink = {0}", this.ObservationDataLink).AppendLine();
            }
            if ((object)this.StationDescription != null)
            {
                buff.AppendFormat("stationDescription = {0}", this.StationDescription).AppendLine();
            }
            if ((object)this.StartTime != null)
            {
                buff.AppendFormat("startTime = {0}", this.StartTime).AppendLine();
            }
            if ((object)this.StopTime != null)
            {
                buff.AppendFormat("stopTime = {0}", this.StopTime).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.Append("id", this.Id);
            }
            if ((object)this.AntennaHeight != null)
            {
                buff.Append("antennaHeight", this.AntennaHeight);
            }
            if ((object)this.StationName != null)
            {
                buff.Append("stationName", this.StationName);
            }
            if ((object)this.GPSAntennaDetailsID != null)
            {
                buff.Append("GPSAntennaDetailsID", this.GPSAntennaDetailsID);
            }
            if ((object)this.GPSReceiverDetailsID != null)
            {
                buff.Append("GPSReceiverDetailsID", this.GPSReceiverDetailsID);
            }
            if ((object)this.ObservationDataLink != null)
            {
                buff.Append("observationDataLink", this.ObservationDataLink);
            }
            if ((object)this.StationDescription != null)
            {
                buff.Append("stationDescription", this.StationDescription);
            }
            if ((object)this.StartTime != null)
            {
                buff.Append("startTime", this.StartTime);
            }
            if ((object)this.StopTime != null)
            {
                buff.Append("stopTime", this.StopTime);
            }

            return buff.ToString();
        }

        public string Id;

        public double AntennaHeight;

        public string StationName;

        public string GPSAntennaDetailsID;

        public string GPSReceiverDetailsID;

        public string ObservationDataLink;

        public string StationDescription;
        /// <summary>
        ///  GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week.
        /// </summary>

        public double? StartTime;
        /// <summary>
        ///  GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week.
        /// </summary>

        public double? StopTime;


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
            if (name.EqualsIgnoreCase("GPSPosition"))
            {
                return Tuple.Create("GPSPosition", this.NewReader<GPSPosition>());
            }
            if (name.EqualsIgnoreCase("TargetSetup"))
            {
                return Tuple.Create("TargetSetup", this.NewReader<TargetSetup>());
            }

            return null;
        }
    }
}
#endif

