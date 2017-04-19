#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// The "Cant" element will typically represent a proposed railway cant / superelevation alignment.
    /// It is defined by a sequential series of any combination of the cant stations and speed-only stations.
    /// The “name”, “desc” and “state” attributes are typical LandXML “alignment” attributes.
    /// The “equilibriumConstant” is a unitless optional double that is used as the equilibrium constant in the cant equilibrium equation (cant = constant * speed * speed / radius).
    /// The “appliedCantConstant” is a unitless optional double that is used as the applied cant constant in the cant equilibrium equation (cant = constant * speed * speed / radius).
    /// The “gauge” is a required double that is the rail to rail distance.  This value is expressed in meters or feet depending upon the units.
    /// The “rotationPoint” is an optional string that defines the rotation point.  Valid values are “insideRail”, “outsideRail”, “center”, “leftRail” and “rightRail”.
    /// </summary>

    public class Cant : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));



            this.EquilibriumConstant = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("equilibriumConstant"));



            this.AppliedCantConstant = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("appliedCantConstant"));



            this.Gauge = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("gauge"));



            this.RotationPoint = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("rotationPoint"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.EquilibriumConstant != null)
            {
                buff.AppendFormat("equilibriumConstant = {0}", this.EquilibriumConstant).AppendLine();
            }
            if ((object)this.AppliedCantConstant != null)
            {
                buff.AppendFormat("appliedCantConstant = {0}", this.AppliedCantConstant).AppendLine();
            }
            if ((object)this.Gauge != null)
            {
                buff.AppendFormat("gauge = {0}", this.Gauge).AppendLine();
            }
            if ((object)this.RotationPoint != null)
            {
                buff.AppendFormat("rotationPoint = {0}", this.RotationPoint).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.EquilibriumConstant != null)
            {
                buff.AppendFormat(" equilibriumConstant=\"{0}\"", this.EquilibriumConstant);
            }
            if ((object)this.AppliedCantConstant != null)
            {
                buff.AppendFormat(" appliedCantConstant=\"{0}\"", this.AppliedCantConstant);
            }
            if ((object)this.Gauge != null)
            {
                buff.AppendFormat(" gauge=\"{0}\"", this.Gauge);
            }
            if ((object)this.RotationPoint != null)
            {
                buff.AppendFormat(" rotationPoint=\"{0}\"", this.RotationPoint);
            }


            return buff.ToString();
        }

        public string Name;

        public string Desc;

        public StateType? State;

        public double? EquilibriumConstant;

        public double? AppliedCantConstant;

        public double Gauge;

        public string RotationPoint;


    }
}
#endif
