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

namespace XmlSchemaProcessor.LandXml12
{

    public class TestObservation : RawObservationType
    {
        public TestObservation(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public double? Setup1RodA;

        public double? Setup1RodB;

        public double? Setup2RodA;

        public double? Setup2RodB;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Setup1RodA = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("setup1RodA"));

            this.Setup1RodB = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("setup1RodB"));

            this.Setup2RodA = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("setup2RodA"));

            this.Setup2RodB = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("setup2RodB"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.Setup1RodA != null)
            {
                buff.Append("setup1RodA", this.Setup1RodA);
            }
            if ((object)this.Setup1RodB != null)
            {
                buff.Append("setup1RodB", this.Setup1RodB);
            }
            if ((object)this.Setup2RodA != null)
            {
                buff.Append("setup2RodA", this.Setup2RodA);
            }
            if ((object)this.Setup2RodB != null)
            {
                buff.Append("setup2RodB", this.Setup2RodB);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            if ((object)this.Setup1RodA != null)
            {
                buff.AppendFormat("setup1RodA = {0}", this.Setup1RodA).AppendLine();
            }
            if ((object)this.Setup1RodB != null)
            {
                buff.AppendFormat("setup1RodB = {0}", this.Setup1RodB).AppendLine();
            }
            if ((object)this.Setup2RodA != null)
            {
                buff.AppendFormat("setup2RodA = {0}", this.Setup2RodA).AppendLine();
            }
            if ((object)this.Setup2RodB != null)
            {
                buff.AppendFormat("setup2RodB = {0}", this.Setup2RodB).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
