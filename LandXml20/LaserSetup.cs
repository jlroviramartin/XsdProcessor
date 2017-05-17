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
    /// Choice [0, *]
    ///     InstrumentPoint [0, 1]
    ///     Backsight [0, 1]
    ///     TargetSetup [0, *]
    ///     RawObservation [1, 1]
    ///     FieldNote [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class LaserSetup : XsdBaseReader
    {
        public LaserSetup(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Id;

        public string StationName;

        public double? InstrumentHeight;

        public string LaserDetailsID;

        public double? MagDeclination;

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

            this.StationName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("stationName"));

            this.InstrumentHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("instrumentHeight"));

            this.LaserDetailsID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("laserDetailsID"));

            this.MagDeclination = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("magDeclination"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.Append("id", this.Id);
            }
            if ((object)this.StationName != null)
            {
                buff.Append("stationName", this.StationName);
            }
            if ((object)this.InstrumentHeight != null)
            {
                buff.Append("instrumentHeight", this.InstrumentHeight);
            }
            if ((object)this.LaserDetailsID != null)
            {
                buff.Append("laserDetailsID", this.LaserDetailsID);
            }
            if ((object)this.MagDeclination != null)
            {
                buff.Append("magDeclination", this.MagDeclination);
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
            if ((object)this.StationName != null)
            {
                buff.AppendFormat("stationName = {0}", this.StationName).AppendLine();
            }
            if ((object)this.InstrumentHeight != null)
            {
                buff.AppendFormat("instrumentHeight = {0}", this.InstrumentHeight).AppendLine();
            }
            if ((object)this.LaserDetailsID != null)
            {
                buff.AppendFormat("laserDetailsID = {0}", this.LaserDetailsID).AppendLine();
            }
            if ((object)this.MagDeclination != null)
            {
                buff.AppendFormat("magDeclination = {0}", this.MagDeclination).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
