#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// A cant station.
    ///             The “station” is a required double that is internal station value.
    /// The “equilibriumCant” is an optional double that is the equilibrium cant.  This value is expressed in millimeters or inches depending upon the units
    /// The “appliedCant” is a required double that is the applied cant.  This value is expressed in millimeters or inches depending upon the units.
    /// The “deficiencyCant” is an optional double that is the cant deficiency.  This value is expressed in millimeters or inches depending upon the units.
    /// The “cantExcess” is an optional double that is the cant excess.  This value is expressed in millimeters or inches upon the units.
    /// The “rateOfChangeOfAppliedCantOverTime” is an optional double that is the rate of change of applied cant as a function of time.  This value is in millimeters /seconds or inches/seconds depending upon the units.
    /// The “rateOfChangeOfAppliedCantOverLength” is an optional double that is the rate of change of applied cant as a function of length.  This value is in millimeters /meters or inches/feet depending upon the units.
    /// The “rateOfChangeOfCantDeficiencyOverTime” is an optional double that is the rate of change of cant deficiency as a function of time.  This value is in millimeters /seconds or inches/seconds depending upon the units.
    /// The “cantGradient” is an optional double that is the cant gradient.  This value is unitless.
    /// The “speed” is an optional double that is the design speed.  This value is in kmph or mph depending upon the units.
    /// The “transitionType” is an optional enumerated type.
    /// The “curvature” is a required enumerated type.
    /// The “adverse” is an optional Boolean that indicates whether the cant is adverse.
    /// </summary>

    public class CantStation : XsdBaseReader
    {
        public CantStation(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Station = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("station"));

            this.EquilibriumCant = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("equilibriumCant"));

            this.AppliedCant = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("appliedCant"));

            this.CantDeficiency = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("cantDeficiency"));

            this.CantExcess = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("cantExcess"));

            this.RateOfChangeOfAppliedCantOverTime = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("rateOfChangeOfAppliedCantOverTime"));

            this.RateOfChangeOfAppliedCantOverLength = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("rateOfChangeOfAppliedCantOverLength"));

            this.RateOfChangeOfCantDeficiencyOverTime = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("rateOfChangeOfCantDeficiencyOverTime"));

            this.CantGradient = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("cantGradient"));

            this.Speed = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("speed"));

            this.TransitionType = XsdConverter.Instance.Convert<SpiralType?>(
                    attributes.GetSafe("transitionType"));

            this.Curvature = XsdConverter.Instance.Convert<Clockwise>(
                    attributes.GetSafe("curvature"));

            this.Adverse = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("adverse"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Station != null)
            {
                buff.AppendFormat("station = {0}", this.Station).AppendLine();
            }
            if ((object)this.EquilibriumCant != null)
            {
                buff.AppendFormat("equilibriumCant = {0}", this.EquilibriumCant).AppendLine();
            }
            if ((object)this.AppliedCant != null)
            {
                buff.AppendFormat("appliedCant = {0}", this.AppliedCant).AppendLine();
            }
            if ((object)this.CantDeficiency != null)
            {
                buff.AppendFormat("cantDeficiency = {0}", this.CantDeficiency).AppendLine();
            }
            if ((object)this.CantExcess != null)
            {
                buff.AppendFormat("cantExcess = {0}", this.CantExcess).AppendLine();
            }
            if ((object)this.RateOfChangeOfAppliedCantOverTime != null)
            {
                buff.AppendFormat("rateOfChangeOfAppliedCantOverTime = {0}", this.RateOfChangeOfAppliedCantOverTime).AppendLine();
            }
            if ((object)this.RateOfChangeOfAppliedCantOverLength != null)
            {
                buff.AppendFormat("rateOfChangeOfAppliedCantOverLength = {0}", this.RateOfChangeOfAppliedCantOverLength).AppendLine();
            }
            if ((object)this.RateOfChangeOfCantDeficiencyOverTime != null)
            {
                buff.AppendFormat("rateOfChangeOfCantDeficiencyOverTime = {0}", this.RateOfChangeOfCantDeficiencyOverTime).AppendLine();
            }
            if ((object)this.CantGradient != null)
            {
                buff.AppendFormat("cantGradient = {0}", this.CantGradient).AppendLine();
            }
            if ((object)this.Speed != null)
            {
                buff.AppendFormat("speed = {0}", this.Speed).AppendLine();
            }
            if ((object)this.TransitionType != null)
            {
                buff.AppendFormat("transitionType = {0}", this.TransitionType).AppendLine();
            }
            if ((object)this.Curvature != null)
            {
                buff.AppendFormat("curvature = {0}", this.Curvature).AppendLine();
            }
            if ((object)this.Adverse != null)
            {
                buff.AppendFormat("adverse = {0}", this.Adverse).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Station != null)
            {
                buff.Append("station", this.Station);
            }
            if ((object)this.EquilibriumCant != null)
            {
                buff.Append("equilibriumCant", this.EquilibriumCant);
            }
            if ((object)this.AppliedCant != null)
            {
                buff.Append("appliedCant", this.AppliedCant);
            }
            if ((object)this.CantDeficiency != null)
            {
                buff.Append("cantDeficiency", this.CantDeficiency);
            }
            if ((object)this.CantExcess != null)
            {
                buff.Append("cantExcess", this.CantExcess);
            }
            if ((object)this.RateOfChangeOfAppliedCantOverTime != null)
            {
                buff.Append("rateOfChangeOfAppliedCantOverTime", this.RateOfChangeOfAppliedCantOverTime);
            }
            if ((object)this.RateOfChangeOfAppliedCantOverLength != null)
            {
                buff.Append("rateOfChangeOfAppliedCantOverLength", this.RateOfChangeOfAppliedCantOverLength);
            }
            if ((object)this.RateOfChangeOfCantDeficiencyOverTime != null)
            {
                buff.Append("rateOfChangeOfCantDeficiencyOverTime", this.RateOfChangeOfCantDeficiencyOverTime);
            }
            if ((object)this.CantGradient != null)
            {
                buff.Append("cantGradient", this.CantGradient);
            }
            if ((object)this.Speed != null)
            {
                buff.Append("speed", this.Speed);
            }
            if ((object)this.TransitionType != null)
            {
                buff.Append("transitionType", this.TransitionType);
            }
            if ((object)this.Curvature != null)
            {
                buff.Append("curvature", this.Curvature);
            }
            if ((object)this.Adverse != null)
            {
                buff.Append("adverse", this.Adverse);
            }

            return buff.ToString();
        }

        public double Station;

        public double? EquilibriumCant;

        public double AppliedCant;

        public double? CantDeficiency;

        public double? CantExcess;

        public double? RateOfChangeOfAppliedCantOverTime;

        public double? RateOfChangeOfAppliedCantOverLength;

        public double? RateOfChangeOfCantDeficiencyOverTime;

        public double? CantGradient;

        public double? Speed;

        public SpiralType? TransitionType;

        public Clockwise Curvature;

        public bool? Adverse;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

