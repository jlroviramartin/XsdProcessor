#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Choice [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class TrafficControl : XsdBaseReader
    {
        public TrafficControl(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? Station;

        public double? SignalPeriod;

        public TrafficControlPosition? ControlPosition;

        public TrafficControlType? ControlType;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Station = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("station"));

            this.SignalPeriod = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("signalPeriod"));

            this.ControlPosition = XsdConverter.Instance.Convert<TrafficControlPosition?>(
                    attributes.GetSafe("controlPosition"));

            this.ControlType = XsdConverter.Instance.Convert<TrafficControlType?>(
                    attributes.GetSafe("controlType"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Station != null)
            {
                buff.Append("station", this.Station);
            }
            if ((object)this.SignalPeriod != null)
            {
                buff.Append("signalPeriod", this.SignalPeriod);
            }
            if ((object)this.ControlPosition != null)
            {
                buff.Append("controlPosition", this.ControlPosition);
            }
            if ((object)this.ControlType != null)
            {
                buff.Append("controlType", this.ControlType);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Station != null)
            {
                buff.AppendFormat("station = {0}", this.Station).AppendLine();
            }
            if ((object)this.SignalPeriod != null)
            {
                buff.AppendFormat("signalPeriod = {0}", this.SignalPeriod).AppendLine();
            }
            if ((object)this.ControlPosition != null)
            {
                buff.AppendFormat("controlPosition = {0}", this.ControlPosition).AppendLine();
            }
            if ((object)this.ControlType != null)
            {
                buff.AppendFormat("controlType = {0}", this.ControlType).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

