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

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Sequence [1, 1]
    ///     TargetPoint [1, 1]
    ///     GPSQCInfoLevel1 [0, 1]
    ///     GPSQCInfoLevel2 [0, 1]
    ///     Choice [0, *]
    ///         FieldNote [0, *]
    ///         Feature [0, *]
    /// </summary>

    public class GPSVector : XsdBaseReader
    {
        public GPSVector(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public double DX;

        public double DY;

        public double DZ;

        public string SetupID_A;

        public string SetupID_B;

        public DateTime? StartTime;

        public DateTime? EndTime;

        public double? HorizontalPrecision;

        public double? VerticalPrecision;
        /// <summary>
        /// Used by many of the Survey elements
        /// </summary>

        public PurposeType? Purpose;

        public string SetID;

        public string SolutionDataLink;
        /// <summary>
        /// A list of reference names values refering to one or more CoordGeom.name attributes.
        /// </summary>

        public IList<string> CoordGeomRefs;

        #region XsdBaseReader

        protected override bool NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                this.SetCurrent("Feature", this.NewReader<Feature>());
                return true;
            }
            if (name.EqualsIgnoreCase("FieldNote"))
            {
                this.SetCurrent("FieldNote", this.NewReader<FieldNote>());
                return true;
            }
            if (name.EqualsIgnoreCase("GPSQCInfoLevel2"))
            {
                this.SetCurrent("GPSQCInfoLevel2", this.NewReader<GPSQCInfoLevel2>());
                return true;
            }
            if (name.EqualsIgnoreCase("GPSQCInfoLevel1"))
            {
                this.SetCurrent("GPSQCInfoLevel1", this.NewReader<GPSQCInfoLevel1>());
                return true;
            }
            if (name.EqualsIgnoreCase("TargetPoint"))
            {
                this.SetCurrent("TargetPoint", this.NewReader<PointType>());
                return true;
            }

            return base.NewReader(namespaceURI, name);
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.DX = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("dX"));

            this.DY = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("dY"));

            this.DZ = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("dZ"));

            this.SetupID_A = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID_A"));

            this.SetupID_B = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID_B"));

            this.StartTime = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("startTime"));

            this.EndTime = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("endTime"));

            this.HorizontalPrecision = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("horizontalPrecision"));

            this.VerticalPrecision = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("verticalPrecision"));

            this.Purpose = XsdConverter.Instance.Convert<PurposeType?>(
                    attributes.GetSafe("purpose"));

            this.SetID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setID"));

            this.SolutionDataLink = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("solutionDataLink"));

            this.CoordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(
                    attributes.GetSafe("coordGeomRefs"));

            return true;
        }

        public override string ToAttributes()
        {
            AttributesBuilder buff = new AttributesBuilder(base.ToAttributes());

            if ((object)this.DX != null)
            {
                buff.Append("dX", this.DX);
            }
            if ((object)this.DY != null)
            {
                buff.Append("dY", this.DY);
            }
            if ((object)this.DZ != null)
            {
                buff.Append("dZ", this.DZ);
            }
            if ((object)this.SetupID_A != null)
            {
                buff.Append("setupID_A", this.SetupID_A);
            }
            if ((object)this.SetupID_B != null)
            {
                buff.Append("setupID_B", this.SetupID_B);
            }
            if ((object)this.StartTime != null)
            {
                buff.Append("startTime", this.StartTime);
            }
            if ((object)this.EndTime != null)
            {
                buff.Append("endTime", this.EndTime);
            }
            if ((object)this.HorizontalPrecision != null)
            {
                buff.Append("horizontalPrecision", this.HorizontalPrecision);
            }
            if ((object)this.VerticalPrecision != null)
            {
                buff.Append("verticalPrecision", this.VerticalPrecision);
            }
            if ((object)this.Purpose != null)
            {
                buff.Append("purpose", this.Purpose);
            }
            if ((object)this.SetID != null)
            {
                buff.Append("setID", this.SetID);
            }
            if ((object)this.SolutionDataLink != null)
            {
                buff.Append("solutionDataLink", this.SolutionDataLink);
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.Append("coordGeomRefs", this.CoordGeomRefs);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder(base.ToString());

            if ((object)this.DX != null)
            {
                buff.AppendFormat("dX = {0}", this.DX).AppendLine();
            }
            if ((object)this.DY != null)
            {
                buff.AppendFormat("dY = {0}", this.DY).AppendLine();
            }
            if ((object)this.DZ != null)
            {
                buff.AppendFormat("dZ = {0}", this.DZ).AppendLine();
            }
            if ((object)this.SetupID_A != null)
            {
                buff.AppendFormat("setupID_A = {0}", this.SetupID_A).AppendLine();
            }
            if ((object)this.SetupID_B != null)
            {
                buff.AppendFormat("setupID_B = {0}", this.SetupID_B).AppendLine();
            }
            if ((object)this.StartTime != null)
            {
                buff.AppendFormat("startTime = {0}", this.StartTime).AppendLine();
            }
            if ((object)this.EndTime != null)
            {
                buff.AppendFormat("endTime = {0}", this.EndTime).AppendLine();
            }
            if ((object)this.HorizontalPrecision != null)
            {
                buff.AppendFormat("horizontalPrecision = {0}", this.HorizontalPrecision).AppendLine();
            }
            if ((object)this.VerticalPrecision != null)
            {
                buff.AppendFormat("verticalPrecision = {0}", this.VerticalPrecision).AppendLine();
            }
            if ((object)this.Purpose != null)
            {
                buff.AppendFormat("purpose = {0}", this.Purpose).AppendLine();
            }
            if ((object)this.SetID != null)
            {
                buff.AppendFormat("setID = {0}", this.SetID).AppendLine();
            }
            if ((object)this.SolutionDataLink != null)
            {
                buff.AppendFormat("solutionDataLink = {0}", this.SolutionDataLink).AppendLine();
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.AppendFormat("coordGeomRefs = {0}", this.CoordGeomRefs).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif
