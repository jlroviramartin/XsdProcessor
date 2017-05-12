#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Sequence [1, 1]
    ///     CrossSectPnt [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class DesignCrossSectSurf : XsdBaseReader
    {
        public DesignCrossSectSurf(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.Side = XsdConverter.Instance.Convert<SideofRoadType?>(
                    attributes.GetSafe("side"));

            this.Material = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("material"));

            this.ClosedArea = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("closedArea"));

            this.TypicalThickness = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("typicalThickness"));

            this.TypicalWidth = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("typicalWidth"));

            this.Area = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("area"));

            this.Volume = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("volume"));

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
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.Side != null)
            {
                buff.AppendFormat("side = {0}", this.Side).AppendLine();
            }
            if ((object)this.Material != null)
            {
                buff.AppendFormat("material = {0}", this.Material).AppendLine();
            }
            if ((object)this.ClosedArea != null)
            {
                buff.AppendFormat("closedArea = {0}", this.ClosedArea).AppendLine();
            }
            if ((object)this.TypicalThickness != null)
            {
                buff.AppendFormat("typicalThickness = {0}", this.TypicalThickness).AppendLine();
            }
            if ((object)this.TypicalWidth != null)
            {
                buff.AppendFormat("typicalWidth = {0}", this.TypicalWidth).AppendLine();
            }
            if ((object)this.Area != null)
            {
                buff.AppendFormat("area = {0}", this.Area).AppendLine();
            }
            if ((object)this.Volume != null)
            {
                buff.AppendFormat("volume = {0}", this.Volume).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.Side != null)
            {
                buff.Append("side", this.Side);
            }
            if ((object)this.Material != null)
            {
                buff.Append("material", this.Material);
            }
            if ((object)this.ClosedArea != null)
            {
                buff.Append("closedArea", this.ClosedArea);
            }
            if ((object)this.TypicalThickness != null)
            {
                buff.Append("typicalThickness", this.TypicalThickness);
            }
            if ((object)this.TypicalWidth != null)
            {
                buff.Append("typicalWidth", this.TypicalWidth);
            }
            if ((object)this.Area != null)
            {
                buff.Append("area", this.Area);
            }
            if ((object)this.Volume != null)
            {
                buff.Append("volume", this.Volume);
            }

            return buff.ToString();
        }

        public string Name;

        public string Desc;

        public StateType? State;

        public SideofRoadType? Side;

        public string Material;

        public bool? ClosedArea;

        public double? TypicalThickness;

        public double? TypicalWidth;
        /// <summary>
        /// Represents the cross sectional surface area in numeric decimal form expressed in area units
        /// </summary>

        public double? Area;
        /// <summary>
        /// Represents the cross section surface volume from the previous station to the current station in numeric decimal form expressed in volume units
        /// </summary>

        public double? Volume;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("CrossSectPnt"))
            {
                return Tuple.Create("CrossSectPnt", this.NewReader<CrossSectPnt>());
            }

            return null;
        }
    }
}
#endif

