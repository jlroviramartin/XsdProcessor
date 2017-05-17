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

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// The "Cant" element will typically represent a proposed railway cant / superelevation alignment.
    /// It is defined by a sequential series of any combination of the cant stations and speed-only stations.
    /// The “name”, “desc” and “state” attributes are typical LandXML “alignment” attributes.
    /// The “equilibriumConstant” is a unitless optional double that is used as the equilibrium constant in the cant equilibrium equation (cant = constant * speed * speed / radius).
    /// The “appliedCantConstant” is a unitless optional double that is used as the applied cant constant in the cant equilibrium equation (cant = constant * speed * speed / radius).
    /// The “gauge” is a required double that is the rail to rail distance.  This value is expressed in meters or feet depending upon the units.
    /// The “rotationPoint” is an optional string that defines the rotation point.  Valid values are “insideRail”, “outsideRail”, “center”, “leftRail” and “rightRail”.
    /// Sequence [1, 1]
    ///     Choice [1, *]
    ///         CantStation [0, *]
    ///         SpeedStation [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Cant : XsdBaseReader
    {
        public Cant(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public string Desc;

        public StateType? State;

        public double? EquilibriumConstant;

        public double? AppliedCantConstant;

        public double Gauge;

        public string RotationPoint;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                this.SetCurrent("Feature", this.NewReader<Feature>());
                return true;
            }
            if (name.EqualsIgnoreCase("SpeedStation"))
            {
                this.SetCurrent("SpeedStation", this.NewReader<SpeedStation>());
                return true;
            }
            if (name.EqualsIgnoreCase("CantStation"))
            {
                this.SetCurrent("CantStation", this.NewReader<CantStation>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

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

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.EquilibriumConstant != null)
            {
                buff.Append("equilibriumConstant", this.EquilibriumConstant);
            }
            if ((object)this.AppliedCantConstant != null)
            {
                buff.Append("appliedCantConstant", this.AppliedCantConstant);
            }
            if ((object)this.Gauge != null)
            {
                buff.Append("gauge", this.Gauge);
            }
            if ((object)this.RotationPoint != null)
            {
                buff.Append("rotationPoint", this.RotationPoint);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

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

        #endregion
    }
}
#endif
