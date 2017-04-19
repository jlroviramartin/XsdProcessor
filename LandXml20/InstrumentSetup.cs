#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// The Instrument setup location is defined by either a coordinate text value ("north east" or "north east elev") or a CgPoint number reference "pntRef" attribute.
    /// </summary>

    public class InstrumentSetup : XsdBaseObject
    {
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



            this.Status = XsdConverter.Instance.Convert<ObservationStatusType?>(
                    attributes.GetSafe("status"));



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
            if ((object)this.Status != null)
            {
                buff.AppendFormat("status = {0}", this.Status).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.AppendFormat(" id=\"{0}\"", this.Id);
            }
            if ((object)this.InstrumentDetailsID != null)
            {
                buff.AppendFormat(" instrumentDetailsID=\"{0}\"", this.InstrumentDetailsID);
            }
            if ((object)this.StationName != null)
            {
                buff.AppendFormat(" stationName=\"{0}\"", this.StationName);
            }
            if ((object)this.InstrumentHeight != null)
            {
                buff.AppendFormat(" instrumentHeight=\"{0}\"", this.InstrumentHeight);
            }
            if ((object)this.OrientationAzimuth != null)
            {
                buff.AppendFormat(" orientationAzimuth=\"{0}\"", this.OrientationAzimuth);
            }
            if ((object)this.CircleAzimuth != null)
            {
                buff.AppendFormat(" circleAzimuth=\"{0}\"", this.CircleAzimuth);
            }
            if ((object)this.Status != null)
            {
                buff.AppendFormat(" status=\"{0}\"", this.Status);
            }


            return buff.ToString();
        }

        public string Id;

        public string InstrumentDetailsID;

        public string StationName;

        public double InstrumentHeight;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? OrientationAzimuth;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? CircleAzimuth;

        public ObservationStatusType? Status;


    }
}
#endif

