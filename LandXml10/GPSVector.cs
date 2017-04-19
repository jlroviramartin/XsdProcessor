#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class GPSVector : XsdBaseObject
    {
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

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

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

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.DX != null)
            {
                buff.AppendFormat(" dX=\"{0}\"", this.DX);
            }
            if ((object)this.DY != null)
            {
                buff.AppendFormat(" dY=\"{0}\"", this.DY);
            }
            if ((object)this.DZ != null)
            {
                buff.AppendFormat(" dZ=\"{0}\"", this.DZ);
            }
            if ((object)this.SetupID_A != null)
            {
                buff.AppendFormat(" setupID_A=\"{0}\"", this.SetupID_A);
            }
            if ((object)this.SetupID_B != null)
            {
                buff.AppendFormat(" setupID_B=\"{0}\"", this.SetupID_B);
            }
            if ((object)this.StartTime != null)
            {
                buff.AppendFormat(" startTime=\"{0}\"", this.StartTime);
            }
            if ((object)this.EndTime != null)
            {
                buff.AppendFormat(" endTime=\"{0}\"", this.EndTime);
            }
            if ((object)this.HorizontalPrecision != null)
            {
                buff.AppendFormat(" horizontalPrecision=\"{0}\"", this.HorizontalPrecision);
            }
            if ((object)this.VerticalPrecision != null)
            {
                buff.AppendFormat(" verticalPrecision=\"{0}\"", this.VerticalPrecision);
            }
            if ((object)this.Purpose != null)
            {
                buff.AppendFormat(" purpose=\"{0}\"", this.Purpose);
            }
            if ((object)this.SetID != null)
            {
                buff.AppendFormat(" setID=\"{0}\"", this.SetID);
            }
            if ((object)this.SolutionDataLink != null)
            {
                buff.AppendFormat(" solutionDataLink=\"{0}\"", this.SolutionDataLink);
            }
            if ((object)this.CoordGeomRefs != null)
            {
                buff.AppendFormat(" coordGeomRefs=\"{0}\"", this.CoordGeomRefs);
            }


            return buff.ToString();
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


    }
}
#endif

