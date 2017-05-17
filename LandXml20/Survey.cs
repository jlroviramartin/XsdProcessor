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

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// I've added state here as a safety net
    /// Sequence [1, 1]
    ///     SurveyHeader [1, 1]
    ///     Equipment [0, 1]
    ///     Choice [0, *]
    ///         SurveyMonument [0, 1]
    ///         CgPoints [0, 1]
    ///         InstrumentSetup [0, 1]
    ///         LaserSetup [0, 1]
    ///         GPSSetup [0, 1]
    ///         TargetSetup [0, 1]
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
            if (name.EqualsIgnoreCase("GPSPosition"))
            {
                this.SetCurrent("GPSPosition", this.NewReader<GPSPosition>());
                return true;
            }
            if (name.EqualsIgnoreCase("GPSVector"))
            {
                this.SetCurrent("GPSVector", this.NewReader<GPSVector>());
                return true;
            }
            if (name.EqualsIgnoreCase("TargetSetup"))
            {
                this.SetCurrent("TargetSetup", this.NewReader<TargetSetup>());
                return true;
            }
            if (name.EqualsIgnoreCase("GPSSetup"))
            {
                this.SetCurrent("GPSSetup", this.NewReader<GPSSetup>());
                return true;
            }
            if (name.EqualsIgnoreCase("LaserSetup"))
            {
                this.SetCurrent("LaserSetup", this.NewReader<LaserSetup>());
                return true;
            }
            if (name.EqualsIgnoreCase("InstrumentSetup"))
            {
                this.SetCurrent("InstrumentSetup", this.NewReader<InstrumentSetup>());
                return true;
            }
            if (name.EqualsIgnoreCase("CgPoints"))
            {
                this.SetCurrent("CgPoints", this.NewReader<CgPoints>());
                return true;
            }
            if (name.EqualsIgnoreCase("SurveyMonument"))
            {
                this.SetCurrent("SurveyMonument", this.NewReader<SurveyMonument>());
                return true;
            }
            if (name.EqualsIgnoreCase("Equipment"))
            {
                this.SetCurrent("Equipment", this.NewReader<Equipment>());
                return true;
            }
            if (name.EqualsIgnoreCase("SurveyHeader"))
            {
                this.SetCurrent("SurveyHeader", this.NewReader<SurveyHeader>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
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
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

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
            StringBuilder buff = new StringBuilder(base.ToString());

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
