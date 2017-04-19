#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class CrossSect : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Sta = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("sta"));



            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.AngleSkew = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("angleSkew"));



            this.AreaCut = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("areaCut"));



            this.AreaFill = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("areaFill"));



            this.CentroidCut = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("centroidCut"));



            this.CentroidFill = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("centroidFill"));



            this.SectType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("sectType"));



            this.VolumeCut = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("volumeCut"));



            this.VolumeFill = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("volumeFill"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Sta != null)
            {
                buff.AppendFormat("sta = {0}", this.Sta).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.AngleSkew != null)
            {
                buff.AppendFormat("angleSkew = {0}", this.AngleSkew).AppendLine();
            }
            if ((object)this.AreaCut != null)
            {
                buff.AppendFormat("areaCut = {0}", this.AreaCut).AppendLine();
            }
            if ((object)this.AreaFill != null)
            {
                buff.AppendFormat("areaFill = {0}", this.AreaFill).AppendLine();
            }
            if ((object)this.CentroidCut != null)
            {
                buff.AppendFormat("centroidCut = {0}", this.CentroidCut).AppendLine();
            }
            if ((object)this.CentroidFill != null)
            {
                buff.AppendFormat("centroidFill = {0}", this.CentroidFill).AppendLine();
            }
            if ((object)this.SectType != null)
            {
                buff.AppendFormat("sectType = {0}", this.SectType).AppendLine();
            }
            if ((object)this.VolumeCut != null)
            {
                buff.AppendFormat("volumeCut = {0}", this.VolumeCut).AppendLine();
            }
            if ((object)this.VolumeFill != null)
            {
                buff.AppendFormat("volumeFill = {0}", this.VolumeFill).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Sta != null)
            {
                buff.AppendFormat(" sta=\"{0}\"", this.Sta);
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.AngleSkew != null)
            {
                buff.AppendFormat(" angleSkew=\"{0}\"", this.AngleSkew);
            }
            if ((object)this.AreaCut != null)
            {
                buff.AppendFormat(" areaCut=\"{0}\"", this.AreaCut);
            }
            if ((object)this.AreaFill != null)
            {
                buff.AppendFormat(" areaFill=\"{0}\"", this.AreaFill);
            }
            if ((object)this.CentroidCut != null)
            {
                buff.AppendFormat(" centroidCut=\"{0}\"", this.CentroidCut);
            }
            if ((object)this.CentroidFill != null)
            {
                buff.AppendFormat(" centroidFill=\"{0}\"", this.CentroidFill);
            }
            if ((object)this.SectType != null)
            {
                buff.AppendFormat(" sectType=\"{0}\"", this.SectType);
            }
            if ((object)this.VolumeCut != null)
            {
                buff.AppendFormat(" volumeCut=\"{0}\"", this.VolumeCut);
            }
            if ((object)this.VolumeFill != null)
            {
                buff.AppendFormat(" volumeFill=\"{0}\"", this.VolumeFill);
            }


            return buff.ToString();
        }

        public double Sta;

        public string Name;

        public string Desc;
        /// <summary>
        /// Represents a normalized angular value in the specified Angular units. Assume 0 degrees = east
        /// </summary>

        public double? AngleSkew;
        /// <summary>
        /// Represents the cross sectional surface area in numeric decimal form expressed in area units
        /// </summary>

        public double? AreaCut;
        /// <summary>
        /// Represents the cross sectional surface area in numeric decimal form expressed in area units
        /// </summary>

        public double? AreaFill;

        public double? CentroidCut;

        public double? CentroidFill;

        public string SectType;
        /// <summary>
        /// Represents the cross section surface volume from the previous station to the current station in numeric decimal form expressed in volume units
        /// </summary>

        public double? VolumeCut;
        /// <summary>
        /// Represents the cross section surface volume from the previous station to the current station in numeric decimal form expressed in volume units
        /// </summary>

        public double? VolumeFill;


    }
}
#endif
