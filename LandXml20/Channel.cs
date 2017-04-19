#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public class Channel : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.AlignmentRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("alignmentRef"));



            this.SurfaceRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surfaceRef"));



            this.Height = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("height"));



            this.WidthTop = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("widthTop"));



            this.WidthBottom = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("widthBottom"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.HazenWilliams = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("hazenWilliams"));



            this.Mannings = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("mannings"));



            this.M = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("m"));



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
            if ((object)this.AlignmentRef != null)
            {
                buff.AppendFormat("alignmentRef = {0}", this.AlignmentRef).AppendLine();
            }
            if ((object)this.SurfaceRef != null)
            {
                buff.AppendFormat("surfaceRef = {0}", this.SurfaceRef).AppendLine();
            }
            if ((object)this.Height != null)
            {
                buff.AppendFormat("height = {0}", this.Height).AppendLine();
            }
            if ((object)this.WidthTop != null)
            {
                buff.AppendFormat("widthTop = {0}", this.WidthTop).AppendLine();
            }
            if ((object)this.WidthBottom != null)
            {
                buff.AppendFormat("widthBottom = {0}", this.WidthBottom).AppendLine();
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
            if ((object)this.M != null)
            {
                buff.AppendFormat("m = {0}", this.M).AppendLine();
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
            if ((object)this.AlignmentRef != null)
            {
                buff.AppendFormat(" alignmentRef=\"{0}\"", this.AlignmentRef);
            }
            if ((object)this.SurfaceRef != null)
            {
                buff.AppendFormat(" surfaceRef=\"{0}\"", this.SurfaceRef);
            }
            if ((object)this.Height != null)
            {
                buff.AppendFormat(" height=\"{0}\"", this.Height);
            }
            if ((object)this.WidthTop != null)
            {
                buff.AppendFormat(" widthTop=\"{0}\"", this.WidthTop);
            }
            if ((object)this.WidthBottom != null)
            {
                buff.AppendFormat(" widthBottom=\"{0}\"", this.WidthBottom);
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
            if ((object)this.M != null)
            {
                buff.AppendFormat(" m=\"{0}\"", this.M);
            }


            return buff.ToString();
        }

        public string Name;
        /// <summary>
        /// A reference name value referring to Alignment.name attribute.
        /// </summary>

        public string AlignmentRef;
        /// <summary>
        /// A reference name value referring to Surface.name attribute.
        /// </summary>

        public string SurfaceRef;

        public double Height;

        public double WidthTop;

        public double WidthBottom;

        public string Desc;

        public double? HazenWilliams;

        public double? Mannings;
        /// <summary>
        /// A integer based index value to a table item in the material table.
        /// </summary>

        public IList<int?> M;


    }
}
#endif
