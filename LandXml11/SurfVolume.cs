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
    /// volume calculation results between two surfaces
    /// Sequence [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class SurfVolume : XsdBaseReader
    {
        public SurfVolume(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.SurfBase = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surfBase"));

            this.SurfCompare = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("surfCompare"));

            this.VolCut = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("volCut"));

            this.VolFill = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("volFill"));

            this.VolTotal = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("volTotal"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.SurfBase != null)
            {
                buff.AppendFormat("surfBase = {0}", this.SurfBase).AppendLine();
            }
            if ((object)this.SurfCompare != null)
            {
                buff.AppendFormat("surfCompare = {0}", this.SurfCompare).AppendLine();
            }
            if ((object)this.VolCut != null)
            {
                buff.AppendFormat("volCut = {0}", this.VolCut).AppendLine();
            }
            if ((object)this.VolFill != null)
            {
                buff.AppendFormat("volFill = {0}", this.VolFill).AppendLine();
            }
            if ((object)this.VolTotal != null)
            {
                buff.AppendFormat("volTotal = {0}", this.VolTotal).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.SurfBase != null)
            {
                buff.Append("surfBase", this.SurfBase);
            }
            if ((object)this.SurfCompare != null)
            {
                buff.Append("surfCompare", this.SurfCompare);
            }
            if ((object)this.VolCut != null)
            {
                buff.Append("volCut", this.VolCut);
            }
            if ((object)this.VolFill != null)
            {
                buff.Append("volFill", this.VolFill);
            }
            if ((object)this.VolTotal != null)
            {
                buff.Append("volTotal", this.VolTotal);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }

            return buff.ToString();
        }

        /// <summary>
        /// A reference name value referring to Surface.name attribute.
        /// </summary>

        public string SurfBase;
        /// <summary>
        /// A reference name value referring to Surface.name attribute.
        /// </summary>

        public string SurfCompare;

        public double VolCut;

        public double VolFill;

        public double VolTotal;

        public string Desc;

        public string Name;


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

