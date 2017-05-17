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
    /// Sequence [1, 1]
    ///     Choice [1, 1]
    ///         InstrumentDetails [1, 1]
    ///         LaserDetails [1, 1]
    ///         GPSReceiverDetails [1, 1]
    ///         GPSAntennaDetails [1, 1]
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class Equipment : XsdBaseReader
    {
        public Equipment(System.Xml.XmlReader reader) : base(reader)
        {
        }

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
            if (name.EqualsIgnoreCase("GPSAntennaDetails"))
            {
                this.SetCurrent("GPSAntennaDetails", this.NewReader<GPSAntennaDetails>());
                return true;
            }
            if (name.EqualsIgnoreCase("GPSReceiverDetails"))
            {
                this.SetCurrent("GPSReceiverDetails", this.NewReader<GPSReceiverDetails>());
                return true;
            }
            if (name.EqualsIgnoreCase("LaserDetails"))
            {
                this.SetCurrent("LaserDetails", this.NewReader<LaserDetails>());
                return true;
            }
            if (name.EqualsIgnoreCase("InstrumentDetails"))
            {
                this.SetCurrent("InstrumentDetails", this.NewReader<InstrumentDetails>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            return buff.ToString();
        }

        #endregion
    }
}
#endif
