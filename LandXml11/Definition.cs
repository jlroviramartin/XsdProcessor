#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// The collection of faces and points that defined the surface.
    /// </summary>

    public class Definition : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.SurfType = XsdConverter.Instance.Convert<SurfTypeEnum>(
                    attributes.GetSafe("surfType"));



            this.Area2DSurf = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("area2DSurf"));



            this.Area3DSurf = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("area3DSurf"));



            this.ElevMax = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("elevMax"));



            this.ElevMin = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("elevMin"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.SurfType != null)
            {
                buff.AppendFormat("surfType = {0}", this.SurfType).AppendLine();
            }
            if ((object)this.Area2DSurf != null)
            {
                buff.AppendFormat("area2DSurf = {0}", this.Area2DSurf).AppendLine();
            }
            if ((object)this.Area3DSurf != null)
            {
                buff.AppendFormat("area3DSurf = {0}", this.Area3DSurf).AppendLine();
            }
            if ((object)this.ElevMax != null)
            {
                buff.AppendFormat("elevMax = {0}", this.ElevMax).AppendLine();
            }
            if ((object)this.ElevMin != null)
            {
                buff.AppendFormat("elevMin = {0}", this.ElevMin).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.SurfType != null)
            {
                buff.AppendFormat(" surfType=\"{0}\"", this.SurfType);
            }
            if ((object)this.Area2DSurf != null)
            {
                buff.AppendFormat(" area2DSurf=\"{0}\"", this.Area2DSurf);
            }
            if ((object)this.Area3DSurf != null)
            {
                buff.AppendFormat(" area3DSurf=\"{0}\"", this.Area3DSurf);
            }
            if ((object)this.ElevMax != null)
            {
                buff.AppendFormat(" elevMax=\"{0}\"", this.ElevMax);
            }
            if ((object)this.ElevMin != null)
            {
                buff.AppendFormat(" elevMin=\"{0}\"", this.ElevMin);
            }


            return buff.ToString();
        }

        /// <summary>
        /// TIN is the acronym for "triangulated irregular network", a surface comprised of 3 point faces
        /// grid is a surface comprised of 4 point faces.
        /// </summary>

        public SurfTypeEnum SurfType;

        public double? Area2DSurf;

        public double? Area3DSurf;

        public double? ElevMax;

        public double? ElevMin;


    }
}
#endif

