#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Choice [1, *]
    ///     Units [1, 1]
    ///     CoordinateSystem [0, 1]
    ///     Project [0, 1]
    ///     Application [0, *]
    ///     Alignments [0, *]
    ///     CgPoints [0, *]
    ///     GradeModel [0, *]
    ///     Monuments [0, *]
    ///     Parcels [0, *]
    ///     PlanFeatures [0, *]
    ///     PipeNetworks [0, *]
    ///     Roadways [0, *]
    ///     Surfaces [0, *]
    ///     Survey [0, *]
    ///     XmlSchemaProcessor.Xsd.XsdParticleAny
    /// </summary>

    public class LandXML : XsdBaseReader
    {
        public static LandXML Process(System.Xml.XmlReader xmlReader)
        {
            while (xmlReader.Read() && (xmlReader.NodeType != System.Xml.XmlNodeType.Element))
            {
            }

            if (xmlReader.NodeType != System.Xml.XmlNodeType.Element || !"LandXML".EqualsIgnoreCase(xmlReader.Name))
            {
                throw new Exception("Fichero Xml mal construido.");
            }

            LandXML node = new LandXML(xmlReader);
            node.ReadAttributes();
            return node;
        }

        public LandXML(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public DateTime Date;

        public DateTime Time;

        public string Version;

        public string Language;

        public bool? ReadOnly;

        public int? LandXMLId;

        public int? Crc;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Survey"))
            {
                return Tuple.Create("Survey", this.NewReader<Survey>());
            }
            if (name.EqualsIgnoreCase("Surfaces"))
            {
                return Tuple.Create("Surfaces", this.NewReader<Surfaces>());
            }
            if (name.EqualsIgnoreCase("Roadways"))
            {
                return Tuple.Create("Roadways", this.NewReader<Roadways>());
            }
            if (name.EqualsIgnoreCase("PipeNetworks"))
            {
                return Tuple.Create("PipeNetworks", this.NewReader<PipeNetworks>());
            }
            if (name.EqualsIgnoreCase("PlanFeatures"))
            {
                return Tuple.Create("PlanFeatures", this.NewReader<PlanFeatures>());
            }
            if (name.EqualsIgnoreCase("Parcels"))
            {
                return Tuple.Create("Parcels", this.NewReader<Parcels>());
            }
            if (name.EqualsIgnoreCase("Monuments"))
            {
                return Tuple.Create("Monuments", this.NewReader<Monuments>());
            }
            if (name.EqualsIgnoreCase("GradeModel"))
            {
                return Tuple.Create("GradeModel", this.NewReader<GradeModel>());
            }
            if (name.EqualsIgnoreCase("CgPoints"))
            {
                return Tuple.Create("CgPoints", this.NewReader<CgPoints>());
            }
            if (name.EqualsIgnoreCase("Alignments"))
            {
                return Tuple.Create("Alignments", this.NewReader<Alignments>());
            }
            if (name.EqualsIgnoreCase("Application"))
            {
                return Tuple.Create("Application", this.NewReader<Application>());
            }
            if (name.EqualsIgnoreCase("Project"))
            {
                return Tuple.Create("Project", this.NewReader<Project>());
            }
            if (name.EqualsIgnoreCase("CoordinateSystem"))
            {
                return Tuple.Create("CoordinateSystem", this.NewReader<CoordinateSystem>());
            }
            if (name.EqualsIgnoreCase("Units"))
            {
                return Tuple.Create("Units", this.NewReader<Units>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Date = XsdConverter.Instance.Convert<DateTime>(
                    attributes.GetSafe("date"));

            this.Time = XsdConverter.Instance.Convert<DateTime>(
                    attributes.GetSafe("time"));

            this.Version = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("version"));

            this.Language = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("language"));

            this.ReadOnly = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("readOnly"));

            this.LandXMLId = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("LandXMLId"));

            this.Crc = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("crc"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Date != null)
            {
                buff.Append("date", this.Date);
            }
            if ((object)this.Time != null)
            {
                buff.Append("time", this.Time);
            }
            if ((object)this.Version != null)
            {
                buff.Append("version", this.Version);
            }
            if ((object)this.Language != null)
            {
                buff.Append("language", this.Language);
            }
            if ((object)this.ReadOnly != null)
            {
                buff.Append("readOnly", this.ReadOnly);
            }
            if ((object)this.LandXMLId != null)
            {
                buff.Append("LandXMLId", this.LandXMLId);
            }
            if ((object)this.Crc != null)
            {
                buff.Append("crc", this.Crc);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Date != null)
            {
                buff.AppendFormat("date = {0}", this.Date).AppendLine();
            }
            if ((object)this.Time != null)
            {
                buff.AppendFormat("time = {0}", this.Time).AppendLine();
            }
            if ((object)this.Version != null)
            {
                buff.AppendFormat("version = {0}", this.Version).AppendLine();
            }
            if ((object)this.Language != null)
            {
                buff.AppendFormat("language = {0}", this.Language).AppendLine();
            }
            if ((object)this.ReadOnly != null)
            {
                buff.AppendFormat("readOnly = {0}", this.ReadOnly).AppendLine();
            }
            if ((object)this.LandXMLId != null)
            {
                buff.AppendFormat("LandXMLId = {0}", this.LandXMLId).AppendLine();
            }
            if ((object)this.Crc != null)
            {
                buff.AppendFormat("crc = {0}", this.Crc).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

