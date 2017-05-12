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
    /// A collection of surface volume data
    /// Sequence [1, 1]
    ///     SurfVolume [1, *]
    ///     Feature [0, *]
    /// </summary>

    public class SurfVolumes : XsdBaseReader
    {
        public SurfVolumes(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.SurfVolCalcMethod = XsdConverter.Instance.Convert<SurfVolCMethodType>(
                    attributes.GetSafe("surfVolCalcMethod"));

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
            if ((object)this.SurfVolCalcMethod != null)
            {
                buff.AppendFormat("surfVolCalcMethod = {0}", this.SurfVolCalcMethod).AppendLine();
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
            if ((object)this.SurfVolCalcMethod != null)
            {
                buff.Append("surfVolCalcMethod", this.SurfVolCalcMethod);
            }

            return buff.ToString();
        }

        public string Desc;

        public string Name;

        public SurfVolCMethodType SurfVolCalcMethod;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("SurfVolume"))
            {
                return Tuple.Create("SurfVolume", this.NewReader<SurfVolume>());
            }

            return null;
        }
    }
}
#endif

