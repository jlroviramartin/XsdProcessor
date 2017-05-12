#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Choice [0, *]
    ///     ZoneWidth [0, *]
    ///     ZoneSlope [0, *]
    ///     ZoneCutFill [0, *]
    ///     ZoneMaterial [0, *]
    ///     ZoneCrossSectStructure [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Zone : XsdBaseReader
    {
        public Zone(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.Priority = XsdConverter.Instance.Convert<int>(
                    attributes.GetSafe("priority"));

            this.Category = XsdConverter.Instance.Convert<ZoneCategoryType>(
                    attributes.GetSafe("category"));

            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));

            this.StaEnd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staEnd"));

            this.StartWidth = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("startWidth"));

            this.StartVertValue = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("startVertValue"));

            this.StartVertType = XsdConverter.Instance.Convert<ZoneVertType>(
                    attributes.GetSafe("startVertType"));

            this.EndWidth = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("endWidth"));

            this.EndVertValue = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("endVertValue"));

            this.EndVertType = XsdConverter.Instance.Convert<ZoneVertType?>(
                    attributes.GetSafe("endVertType"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.Priority != null)
            {
                buff.AppendFormat("priority = {0}", this.Priority).AppendLine();
            }
            if ((object)this.Category != null)
            {
                buff.AppendFormat("category = {0}", this.Category).AppendLine();
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat("staEnd = {0}", this.StaEnd).AppendLine();
            }
            if ((object)this.StartWidth != null)
            {
                buff.AppendFormat("startWidth = {0}", this.StartWidth).AppendLine();
            }
            if ((object)this.StartVertValue != null)
            {
                buff.AppendFormat("startVertValue = {0}", this.StartVertValue).AppendLine();
            }
            if ((object)this.StartVertType != null)
            {
                buff.AppendFormat("startVertType = {0}", this.StartVertType).AppendLine();
            }
            if ((object)this.EndWidth != null)
            {
                buff.AppendFormat("endWidth = {0}", this.EndWidth).AppendLine();
            }
            if ((object)this.EndVertValue != null)
            {
                buff.AppendFormat("endVertValue = {0}", this.EndVertValue).AppendLine();
            }
            if ((object)this.EndVertType != null)
            {
                buff.AppendFormat("endVertType = {0}", this.EndVertType).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.Priority != null)
            {
                buff.Append("priority", this.Priority);
            }
            if ((object)this.Category != null)
            {
                buff.Append("category", this.Category);
            }
            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.StaEnd != null)
            {
                buff.Append("staEnd", this.StaEnd);
            }
            if ((object)this.StartWidth != null)
            {
                buff.Append("startWidth", this.StartWidth);
            }
            if ((object)this.StartVertValue != null)
            {
                buff.Append("startVertValue", this.StartVertValue);
            }
            if ((object)this.StartVertType != null)
            {
                buff.Append("startVertType", this.StartVertType);
            }
            if ((object)this.EndWidth != null)
            {
                buff.Append("endWidth", this.EndWidth);
            }
            if ((object)this.EndVertValue != null)
            {
                buff.Append("endVertValue", this.EndVertValue);
            }
            if ((object)this.EndVertType != null)
            {
                buff.Append("endVertType", this.EndVertType);
            }

            return buff.ToString();
        }

        public string Desc;

        public string Name;

        public StateType? State;

        public int Priority;

        public ZoneCategoryType Category;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double StaStart;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double? StaEnd;

        public double StartWidth;

        public double StartVertValue;

        public ZoneVertType StartVertType;

        public double? EndWidth;

        public double? EndVertValue;

        public ZoneVertType? EndVertType;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("ZoneCrossSectStructure"))
            {
                return Tuple.Create("ZoneCrossSectStructure", this.NewReader<ZoneCrossSectStructure>());
            }
            if (name.EqualsIgnoreCase("ZoneMaterial"))
            {
                return Tuple.Create("ZoneMaterial", this.NewReader<ZoneMaterial>());
            }
            if (name.EqualsIgnoreCase("ZoneCutFill"))
            {
                return Tuple.Create("ZoneCutFill", this.NewReader<ZoneCutFill>());
            }
            if (name.EqualsIgnoreCase("ZoneSlope"))
            {
                return Tuple.Create("ZoneSlope", this.NewReader<ZoneSlope>());
            }
            if (name.EqualsIgnoreCase("ZoneWidth"))
            {
                return Tuple.Create("ZoneWidth", this.NewReader<ZoneWidth>());
            }

            return null;
        }
    }
}
#endif

