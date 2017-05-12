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
    ///     Feature [0, *]
    /// </summary>

    public class Ditch : XsdBaseReader
    {
        public Ditch(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));

            this.StaEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staEnd"));

            this.BottomWidth = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("bottomWidth"));

            this.BottomShape = XsdConverter.Instance.Convert<DitchBottomShape?>(
                    attributes.GetSafe("bottomShape"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat("staEnd = {0}", this.StaEnd).AppendLine();
            }
            if ((object)this.BottomWidth != null)
            {
                buff.AppendFormat("bottomWidth = {0}", this.BottomWidth).AppendLine();
            }
            if ((object)this.BottomShape != null)
            {
                buff.AppendFormat("bottomShape = {0}", this.BottomShape).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.StaEnd != null)
            {
                buff.Append("staEnd", this.StaEnd);
            }
            if ((object)this.BottomWidth != null)
            {
                buff.Append("bottomWidth", this.BottomWidth);
            }
            if ((object)this.BottomShape != null)
            {
                buff.Append("bottomShape", this.BottomShape);
            }

            return buff.ToString();
        }

        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double StaStart;
        /// <summary>
        /// Represents a station value in decimal form expressed in length units
        /// </summary>

        public double StaEnd;

        public double BottomWidth;

        public DitchBottomShape? BottomShape;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }
    }
}
#endif

