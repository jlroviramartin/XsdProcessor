//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime: <..>
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using XmlSchemaProcessor.Common;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Choice [1, *]
    ///     Units [1, 1]
    ///     CoordinateSystem [0, 1]
    ///     Project [0, 1]
    ///     Application [0, *]
    ///     Alignments [0, *]
    ///     CgPoints [0, *]
    ///     Amendment [0, *]
    ///     GradeModel [0, *]
    ///     Monuments [0, *]
    ///     Parcels [0, *]
    ///     PlanFeatures [0, *]
    ///     PipeNetworks [0, *]
    ///     Roadways [0, *]
    ///     Surfaces [0, *]
    ///     Survey [0, *]
    ///     FeatureDictionary [0, *]
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

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("FeatureDictionary"))
            {
                this.SetCurrent("FeatureDictionary", this.NewReader<FeatureDictionary>());
                return true;
            }
            if (name.EqualsIgnoreCase("Survey"))
            {
                this.SetCurrent("Survey", this.NewReader<Survey>());
                return true;
            }
            if (name.EqualsIgnoreCase("Surfaces"))
            {
                this.SetCurrent("Surfaces", this.NewReader<Surfaces>());
                return true;
            }
            if (name.EqualsIgnoreCase("Roadways"))
            {
                this.SetCurrent("Roadways", this.NewReader<Roadways>());
                return true;
            }
            if (name.EqualsIgnoreCase("PipeNetworks"))
            {
                this.SetCurrent("PipeNetworks", this.NewReader<PipeNetworks>());
                return true;
            }
            if (name.EqualsIgnoreCase("PlanFeatures"))
            {
                this.SetCurrent("PlanFeatures", this.NewReader<PlanFeatures>());
                return true;
            }
            if (name.EqualsIgnoreCase("Parcels"))
            {
                this.SetCurrent("Parcels", this.NewReader<Parcels>());
                return true;
            }
            if (name.EqualsIgnoreCase("Monuments"))
            {
                this.SetCurrent("Monuments", this.NewReader<Monuments>());
                return true;
            }
            if (name.EqualsIgnoreCase("GradeModel"))
            {
                this.SetCurrent("GradeModel", this.NewReader<GradeModel>());
                return true;
            }
            if (name.EqualsIgnoreCase("Amendment"))
            {
                this.SetCurrent("Amendment", this.NewReader<Amendment>());
                return true;
            }
            if (name.EqualsIgnoreCase("CgPoints"))
            {
                this.SetCurrent("CgPoints", this.NewReader<CgPoints>());
                return true;
            }
            if (name.EqualsIgnoreCase("Alignments"))
            {
                this.SetCurrent("Alignments", this.NewReader<Alignments>());
                return true;
            }
            if (name.EqualsIgnoreCase("Application"))
            {
                this.SetCurrent("Application", this.NewReader<Application>());
                return true;
            }
            if (name.EqualsIgnoreCase("Project"))
            {
                this.SetCurrent("Project", this.NewReader<Project>());
                return true;
            }
            if (name.EqualsIgnoreCase("CoordinateSystem"))
            {
                this.SetCurrent("CoordinateSystem", this.NewReader<CoordinateSystem>());
                return true;
            }
            if (name.EqualsIgnoreCase("Units"))
            {
                this.SetCurrent("Units", this.NewReader<Units>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
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
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

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
            StringBuilder buff = new StringBuilder(base.ToString());

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
