#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// I've added state here as a safety net
    /// Sequence [1, 1]
    ///     SurveyHeader [1, 1]
    ///     Equipment [1, 1]
    ///     SurveyMonument [0, *]
    ///     CgPoints [0, *]
    ///     Choice [0, *]
    ///         InstrumentSetup [0, *]
    ///         LaserSetup [0, *]
    ///         GPSSetup [0, *]
    ///         TargetSetup [0, *]
    ///     Choice [0, *]
    ///         GPSVector [1, 1]
    ///         GPSPosition [1, 1]
    ///         ObservationGroup [1, 1]
    ///         ControlChecks [1, 1]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class Survey : XsdBaseReader
    {
        public Survey(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Desc;

        public DateTime? Date;

        public DateTime? StartTime;

        public DateTime? EndTime;

        public StateType? State;

        public string HorizontalAccuracy;

        public string VerticalAccuracy;

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
            if (name.EqualsIgnoreCase("GPSPosition"))
            {
                return Tuple.Create("GPSPosition", this.NewReader<GPSPosition>());
            }
            if (name.EqualsIgnoreCase("GPSVector"))
            {
                return Tuple.Create("GPSVector", this.NewReader<GPSVector>());
            }
            if (name.EqualsIgnoreCase("TargetSetup"))
            {
                return Tuple.Create("TargetSetup", this.NewReader<TargetSetup>());
            }
            if (name.EqualsIgnoreCase("GPSSetup"))
            {
                return Tuple.Create("GPSSetup", this.NewReader<GPSSetup>());
            }
            if (name.EqualsIgnoreCase("LaserSetup"))
            {
                return Tuple.Create("LaserSetup", this.NewReader<LaserSetup>());
            }
            if (name.EqualsIgnoreCase("InstrumentSetup"))
            {
                return Tuple.Create("InstrumentSetup", this.NewReader<InstrumentSetup>());
            }
            if (name.EqualsIgnoreCase("CgPoints"))
            {
                return Tuple.Create("CgPoints", this.NewReader<CgPoints>());
            }
            if (name.EqualsIgnoreCase("SurveyMonument"))
            {
                return Tuple.Create("SurveyMonument", this.NewReader<SurveyMonument>());
            }
            if (name.EqualsIgnoreCase("Equipment"))
            {
                return Tuple.Create("Equipment", this.NewReader<Equipment>());
            }
            if (name.EqualsIgnoreCase("SurveyHeader"))
            {
                return Tuple.Create("SurveyHeader", this.NewReader<SurveyHeader>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Date = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("date"));

            this.StartTime = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("startTime"));

            this.EndTime = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("endTime"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.HorizontalAccuracy = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("horizontalAccuracy"));

            this.VerticalAccuracy = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("verticalAccuracy"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Date != null)
            {
                buff.Append("date", this.Date);
            }
            if ((object)this.StartTime != null)
            {
                buff.Append("startTime", this.StartTime);
            }
            if ((object)this.EndTime != null)
            {
                buff.Append("endTime", this.EndTime);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.HorizontalAccuracy != null)
            {
                buff.Append("horizontalAccuracy", this.HorizontalAccuracy);
            }
            if ((object)this.VerticalAccuracy != null)
            {
                buff.Append("verticalAccuracy", this.VerticalAccuracy);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Date != null)
            {
                buff.AppendFormat("date = {0}", this.Date).AppendLine();
            }
            if ((object)this.StartTime != null)
            {
                buff.AppendFormat("startTime = {0}", this.StartTime).AppendLine();
            }
            if ((object)this.EndTime != null)
            {
                buff.AppendFormat("endTime = {0}", this.EndTime).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.HorizontalAccuracy != null)
            {
                buff.AppendFormat("horizontalAccuracy = {0}", this.HorizontalAccuracy).AppendLine();
            }
            if ((object)this.VerticalAccuracy != null)
            {
                buff.AppendFormat("verticalAccuracy = {0}", this.VerticalAccuracy).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

