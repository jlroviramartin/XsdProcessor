#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Sequence [1, 1]
    ///     BacksightPoint [0, 1]
    ///     Choice [1, 1]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class Backsight : XsdBaseReader
    {
        public Backsight(System.Xml.XmlReader reader) : base(reader)
        {
        }

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
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.Append("id", this.Id);
            }
            if ((object)this.Azimuth != null)
            {
                buff.Append("azimuth", this.Azimuth);
            }
            if ((object)this.TargetHeight != null)
            {
                buff.Append("targetHeight", this.TargetHeight);
            }
            if ((object)this.Circle != null)
            {
                buff.Append("circle", this.Circle);
            }
            if ((object)this.SetupID != null)
            {
                buff.Append("setupID", this.SetupID);
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


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("FieldNote"))
            {
                return Tuple.Create("FieldNote", this.NewReader<FieldNote>());
            }
            if (name.EqualsIgnoreCase("BacksightPoint"))
            {
                return Tuple.Create("BacksightPoint", this.NewReader<PointType>());
            }

            return null;
        }
    }
}
#endif

