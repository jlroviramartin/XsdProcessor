#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public class TestObservation : RawObservationType
    {
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

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

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

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Setup1RodA != null)
            {
                buff.AppendFormat(" setup1RodA=\"{0}\"", this.Setup1RodA);
            }
            if ((object)this.Setup1RodB != null)
            {
                buff.AppendFormat(" setup1RodB=\"{0}\"", this.Setup1RodB);
            }
            if ((object)this.Setup2RodA != null)
            {
                buff.AppendFormat(" setup2RodA=\"{0}\"", this.Setup2RodA);
            }
            if ((object)this.Setup2RodB != null)
            {
                buff.AppendFormat(" setup2RodB=\"{0}\"", this.Setup2RodB);
            }


            return buff.ToString();
        }

        public double? Setup1RodA;

        public double? Setup1RodB;

        public double? Setup2RodA;

        public double? Setup2RodB;


    }
}
#endif
