#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public class Backsight : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));



            this.Azimuth = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("azimuth"));



            this.TargetHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("targetHeight"));



            this.Circle = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("circle"));



            this.SetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Id != null)
            {
                buff.AppendFormat("id = {0}", this.Id).AppendLine();
            }
            if ((object)this.Azimuth != null)
            {
                buff.AppendFormat("azimuth = {0}", this.Azimuth).AppendLine();
            }
            if ((object)this.TargetHeight != null)
            {
                buff.AppendFormat("targetHeight = {0}", this.TargetHeight).AppendLine();
            }
            if ((object)this.Circle != null)
            {
                buff.AppendFormat("circle = {0}", this.Circle).AppendLine();
            }
            if ((object)this.SetupID != null)
            {
                buff.AppendFormat("setupID = {0}", this.SetupID).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.AppendFormat(" id=\"{0}\"", this.Id);
            }
            if ((object)this.Azimuth != null)
            {
                buff.AppendFormat(" azimuth=\"{0}\"", this.Azimuth);
            }
            if ((object)this.TargetHeight != null)
            {
                buff.AppendFormat(" targetHeight=\"{0}\"", this.TargetHeight);
            }
            if ((object)this.Circle != null)
            {
                buff.AppendFormat(" circle=\"{0}\"", this.Circle);
            }
            if ((object)this.SetupID != null)
            {
                buff.AppendFormat(" setupID=\"{0}\"", this.SetupID);
            }


            return buff.ToString();
        }

        public string Id;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? Azimuth;

        public double? TargetHeight;
        /// <summary>
        /// Represents a normalized angular value in the specified Angular units. Assume 0 degrees = east
        /// </summary>

        public double Circle;

        public string SetupID;


    }
}
#endif

