#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class Metric : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.AreaUnit = XsdConverter.Instance.Convert<MetArea>(
                    attributes.GetSafe("areaUnit"));



            this.LinearUnit = XsdConverter.Instance.Convert<MetLinear>(
                    attributes.GetSafe("linearUnit"));



            this.VolumeUnit = XsdConverter.Instance.Convert<MetVolume>(
                    attributes.GetSafe("volumeUnit"));



            this.TemperatureUnit = XsdConverter.Instance.Convert<MetTemperature>(
                    attributes.GetSafe("temperatureUnit"));



            this.PressureUnit = XsdConverter.Instance.Convert<MetPressure>(
                    attributes.GetSafe("pressureUnit"));



            this.DiameterUnit = XsdConverter.Instance.Convert<MetDiameter?>(
                    attributes.GetSafe("diameterUnit"));



            this.WidthUnit = XsdConverter.Instance.Convert<MetWidth?>(
                    attributes.GetSafe("widthUnit"));



            this.HeightUnit = XsdConverter.Instance.Convert<MetHeight?>(
                    attributes.GetSafe("heightUnit"));



            this.VelocityUnit = XsdConverter.Instance.Convert<MetVelocity?>(
                    attributes.GetSafe("velocityUnit"));



            this.FlowUnit = XsdConverter.Instance.Convert<MetFlow?>(
                    attributes.GetSafe("flowUnit"));



            this.AngularUnit = XsdConverter.Instance.Convert<AngularType?>(
                    attributes.GetSafe("angularUnit"),
                    XsdConverter.Instance.Convert<AngularType?>("radians"));


            this.DirectionUnit = XsdConverter.Instance.Convert<AngularType?>(
                    attributes.GetSafe("directionUnit"),
                    XsdConverter.Instance.Convert<AngularType?>("radians"));


            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.AreaUnit != null)
            {
                buff.AppendFormat("areaUnit = {0}", this.AreaUnit).AppendLine();
            }
            if ((object)this.LinearUnit != null)
            {
                buff.AppendFormat("linearUnit = {0}", this.LinearUnit).AppendLine();
            }
            if ((object)this.VolumeUnit != null)
            {
                buff.AppendFormat("volumeUnit = {0}", this.VolumeUnit).AppendLine();
            }
            if ((object)this.TemperatureUnit != null)
            {
                buff.AppendFormat("temperatureUnit = {0}", this.TemperatureUnit).AppendLine();
            }
            if ((object)this.PressureUnit != null)
            {
                buff.AppendFormat("pressureUnit = {0}", this.PressureUnit).AppendLine();
            }
            if ((object)this.DiameterUnit != null)
            {
                buff.AppendFormat("diameterUnit = {0}", this.DiameterUnit).AppendLine();
            }
            if ((object)this.WidthUnit != null)
            {
                buff.AppendFormat("widthUnit = {0}", this.WidthUnit).AppendLine();
            }
            if ((object)this.HeightUnit != null)
            {
                buff.AppendFormat("heightUnit = {0}", this.HeightUnit).AppendLine();
            }
            if ((object)this.VelocityUnit != null)
            {
                buff.AppendFormat("velocityUnit = {0}", this.VelocityUnit).AppendLine();
            }
            if ((object)this.FlowUnit != null)
            {
                buff.AppendFormat("flowUnit = {0}", this.FlowUnit).AppendLine();
            }
            if ((object)this.AngularUnit != null)
            {
                buff.AppendFormat("angularUnit = {0} defvalue = {1}", this.AngularUnit, "radians").AppendLine();
            }
            if ((object)this.DirectionUnit != null)
            {
                buff.AppendFormat("directionUnit = {0} defvalue = {1}", this.DirectionUnit, "radians").AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.AreaUnit != null)
            {
                buff.AppendFormat(" areaUnit=\"{0}\"", this.AreaUnit);
            }
            if ((object)this.LinearUnit != null)
            {
                buff.AppendFormat(" linearUnit=\"{0}\"", this.LinearUnit);
            }
            if ((object)this.VolumeUnit != null)
            {
                buff.AppendFormat(" volumeUnit=\"{0}\"", this.VolumeUnit);
            }
            if ((object)this.TemperatureUnit != null)
            {
                buff.AppendFormat(" temperatureUnit=\"{0}\"", this.TemperatureUnit);
            }
            if ((object)this.PressureUnit != null)
            {
                buff.AppendFormat(" pressureUnit=\"{0}\"", this.PressureUnit);
            }
            if ((object)this.DiameterUnit != null)
            {
                buff.AppendFormat(" diameterUnit=\"{0}\"", this.DiameterUnit);
            }
            if ((object)this.WidthUnit != null)
            {
                buff.AppendFormat(" widthUnit=\"{0}\"", this.WidthUnit);
            }
            if ((object)this.HeightUnit != null)
            {
                buff.AppendFormat(" heightUnit=\"{0}\"", this.HeightUnit);
            }
            if ((object)this.VelocityUnit != null)
            {
                buff.AppendFormat(" velocityUnit=\"{0}\"", this.VelocityUnit);
            }
            if ((object)this.FlowUnit != null)
            {
                buff.AppendFormat(" flowUnit=\"{0}\"", this.FlowUnit);
            }
            if ((object)this.AngularUnit != null)
            {
                buff.AppendFormat(" angularUnit=\"{0}\"", this.AngularUnit);
            }
            if ((object)this.DirectionUnit != null)
            {
                buff.AppendFormat(" directionUnit=\"{0}\"", this.DirectionUnit);
            }


            return buff.ToString();
        }

        public MetArea AreaUnit;

        public MetLinear LinearUnit;

        public MetVolume VolumeUnit;

        public MetTemperature TemperatureUnit;

        public MetPressure PressureUnit;

        public MetDiameter? DiameterUnit;

        public MetWidth? WidthUnit;

        public MetHeight? HeightUnit;

        public MetVelocity? VelocityUnit;

        public MetFlow? FlowUnit;
        /// <summary>
        /// angular values expressed in "decimal dd.mm.ss" units have the numeric
        ///    format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
        /// </summary>

        public AngularType? AngularUnit;
        /// <summary>
        /// angular values expressed in "decimal dd.mm.ss" units have the numeric
        ///    format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
        /// </summary>

        public AngularType? DirectionUnit;


    }
}
#endif

