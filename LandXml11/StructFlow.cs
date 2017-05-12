#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Sequence [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class StructFlow : XsdBaseReader
    {
        public StructFlow(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public double LossIn;

        public double LossOut;

        public string Desc;

        public double? HglIn;

        public double? HglOut;

        public double? LocalDepression;

        public double? SlopeSurf;

        public double? SlopeGutter;

        public double? WidthGutter;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.LossIn = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("lossIn"));

            this.LossOut = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("lossOut"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.HglIn = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("hglIn"));

            this.HglOut = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("hglOut"));

            this.LocalDepression = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("localDepression"));

            this.SlopeSurf = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("slopeSurf"));

            this.SlopeGutter = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("slopeGutter"));

            this.WidthGutter = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("widthGutter"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.LossIn != null)
            {
                buff.Append("lossIn", this.LossIn);
            }
            if ((object)this.LossOut != null)
            {
                buff.Append("lossOut", this.LossOut);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.HglIn != null)
            {
                buff.Append("hglIn", this.HglIn);
            }
            if ((object)this.HglOut != null)
            {
                buff.Append("hglOut", this.HglOut);
            }
            if ((object)this.LocalDepression != null)
            {
                buff.Append("localDepression", this.LocalDepression);
            }
            if ((object)this.SlopeSurf != null)
            {
                buff.Append("slopeSurf", this.SlopeSurf);
            }
            if ((object)this.SlopeGutter != null)
            {
                buff.Append("slopeGutter", this.SlopeGutter);
            }
            if ((object)this.WidthGutter != null)
            {
                buff.Append("widthGutter", this.WidthGutter);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.LossIn != null)
            {
                buff.AppendFormat("lossIn = {0}", this.LossIn).AppendLine();
            }
            if ((object)this.LossOut != null)
            {
                buff.AppendFormat("lossOut = {0}", this.LossOut).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.HglIn != null)
            {
                buff.AppendFormat("hglIn = {0}", this.HglIn).AppendLine();
            }
            if ((object)this.HglOut != null)
            {
                buff.AppendFormat("hglOut = {0}", this.HglOut).AppendLine();
            }
            if ((object)this.LocalDepression != null)
            {
                buff.AppendFormat("localDepression = {0}", this.LocalDepression).AppendLine();
            }
            if ((object)this.SlopeSurf != null)
            {
                buff.AppendFormat("slopeSurf = {0}", this.SlopeSurf).AppendLine();
            }
            if ((object)this.SlopeGutter != null)
            {
                buff.AppendFormat("slopeGutter = {0}", this.SlopeGutter).AppendLine();
            }
            if ((object)this.WidthGutter != null)
            {
                buff.AppendFormat("widthGutter = {0}", this.WidthGutter).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

