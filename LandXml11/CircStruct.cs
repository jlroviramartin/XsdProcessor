#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class CircStruct : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Diameter = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("diameter"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.InletCase = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("inletCase"));



            this.LossCoeff = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("lossCoeff"));



            this.Material = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("material"));



            this.Thickness = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("thickness"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Diameter != null)
            {
                buff.AppendFormat("diameter = {0}", this.Diameter).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.InletCase != null)
            {
                buff.AppendFormat("inletCase = {0}", this.InletCase).AppendLine();
            }
            if ((object)this.LossCoeff != null)
            {
                buff.AppendFormat("lossCoeff = {0}", this.LossCoeff).AppendLine();
            }
            if ((object)this.Material != null)
            {
                buff.AppendFormat("material = {0}", this.Material).AppendLine();
            }
            if ((object)this.Thickness != null)
            {
                buff.AppendFormat("thickness = {0}", this.Thickness).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Diameter != null)
            {
                buff.AppendFormat(" diameter=\"{0}\"", this.Diameter);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.InletCase != null)
            {
                buff.AppendFormat(" inletCase=\"{0}\"", this.InletCase);
            }
            if ((object)this.LossCoeff != null)
            {
                buff.AppendFormat(" lossCoeff=\"{0}\"", this.LossCoeff);
            }
            if ((object)this.Material != null)
            {
                buff.AppendFormat(" material=\"{0}\"", this.Material);
            }
            if ((object)this.Thickness != null)
            {
                buff.AppendFormat(" thickness=\"{0}\"", this.Thickness);
            }


            return buff.ToString();
        }

        public double Diameter;

        public string Desc;

        public string InletCase;

        public double? LossCoeff;

        public string Material;

        public double? Thickness;


    }
}
#endif

