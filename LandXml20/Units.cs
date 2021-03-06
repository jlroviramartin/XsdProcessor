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
    /// All angular and direction values default to radians unless otherwise noted. Angular values, expressed in the specified Units.angleUnit are measured counter-clockwise from east=0. Horizontal directions, expressed in the specified Units.directionUnit are measured counter-clockwise from 0 degrees = north
    /// Choice [1, 1]
    ///     Metric [1, 1]
    ///     Imperial [1, 1]
    /// </summary>

    public class Units : XsdBaseReader
    {
        public Units(System.Xml.XmlReader reader) : base(reader)
        {
        }

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Imperial"))
            {
                this.SetCurrent("Imperial", this.NewReader<Imperial>());
                return true;
            }
            if (name.EqualsIgnoreCase("Metric"))
            {
                this.SetCurrent("Metric", this.NewReader<Metric>());
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
