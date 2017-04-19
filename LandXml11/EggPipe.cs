#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class EggPipe : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Height = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("height"));



            this.Span = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("span"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.HazenWilliams = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("hazenWilliams"));



            this.Mannings = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("mannings"));



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

            if ((object)this.Height != null)
            {
                buff.AppendFormat("height = {0}", this.Height).AppendLine();
            }
            if ((object)this.Span != null)
            {
                buff.AppendFormat("span = {0}", this.Span).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.HazenWilliams != null)
            {
                buff.AppendFormat("hazenWilliams = {0}", this.HazenWilliams).AppendLine();
            }
            if ((object)this.Mannings != null)
            {
                buff.AppendFormat("mannings = {0}", this.Mannings).AppendLine();
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

            if ((object)this.Height != null)
            {
                buff.AppendFormat(" height=\"{0}\"", this.Height);
            }
            if ((object)this.Span != null)
            {
                buff.AppendFormat(" span=\"{0}\"", this.Span);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.HazenWilliams != null)
            {
                buff.AppendFormat(" hazenWilliams=\"{0}\"", this.HazenWilliams);
            }
            if ((object)this.Mannings != null)
            {
                buff.AppendFormat(" mannings=\"{0}\"", this.Mannings);
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

        public double Height;

        public double Span;

        public string Desc;

        public double? HazenWilliams;

        public double? Mannings;

        public string Material;

        public double? Thickness;


    }
}
#endif

