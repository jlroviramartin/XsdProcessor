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
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week     
    /// </summary>

    public class GPSQCInfoLevel1 : XsdBaseReader
    {
        public GPSQCInfoLevel1(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// The GPS solution type indicates the type of computed solution for a GPS vector or position
        /// </summary>

        public GPSSolutionTypeEnum? GPSSolnType;
        /// <summary>
        /// The GPS solution frequency indicates the GPS frequencies used in the computed solution for a GPS vector or position 
        /// </summary>

        public GPSSolutionFrequencyEnum? GPSSolnFreq;

        public int? NbrSatellites;

        public double? RDOP;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.GPSSolnType = XsdConverter.Instance.Convert<GPSSolutionTypeEnum?>(
                    attributes.GetSafe("GPSSolnType"));

            this.GPSSolnFreq = XsdConverter.Instance.Convert<GPSSolutionFrequencyEnum?>(
                    attributes.GetSafe("GPSSolnFreq"));

            this.NbrSatellites = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("nbrSatellites"));

            this.RDOP = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("RDOP"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.GPSSolnType != null)
            {
                buff.Append("GPSSolnType", this.GPSSolnType);
            }
            if ((object)this.GPSSolnFreq != null)
            {
                buff.Append("GPSSolnFreq", this.GPSSolnFreq);
            }
            if ((object)this.NbrSatellites != null)
            {
                buff.Append("nbrSatellites", this.NbrSatellites);
            }
            if ((object)this.RDOP != null)
            {
                buff.Append("RDOP", this.RDOP);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.GPSSolnType != null)
            {
                buff.AppendFormat("GPSSolnType = {0}", this.GPSSolnType).AppendLine();
            }
            if ((object)this.GPSSolnFreq != null)
            {
                buff.AppendFormat("GPSSolnFreq = {0}", this.GPSSolnFreq).AppendLine();
            }
            if ((object)this.NbrSatellites != null)
            {
                buff.AppendFormat("nbrSatellites = {0}", this.NbrSatellites).AppendLine();
            }
            if ((object)this.RDOP != null)
            {
                buff.AppendFormat("RDOP = {0}", this.RDOP).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
