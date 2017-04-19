#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    ///        Simplified coordinate systems definitions to reuse work done by
    ///     EPSG (European Petroleum Survey Group)
    ///     EPSG Code: EPSG has reserved the integer range 0 to 32767 for use as codes for coordinate systems.
    ///                     Example: Represents Australian Map Grid Zone 52
    ///                      name="AGD66 - AMG Zone 52" , epsgCode="20252" 
    ///                     Example: Represents Colorado CS27 South Zone
    ///                      name="NAD27-Colorado South" , epsgCode="26755" 
    /// </summary>

    public class CoordinateSystem : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.EpsgCode = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("epsgCode"));



            this.OgcWktCode = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("ogcWktCode"));



            this.HorizontalDatum = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("horizontalDatum"));



            this.VerticalDatum = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("verticalDatum"));



            this.EllipsoidName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("ellipsoidName"));



            this.HorizontalCoordinateSystemName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("horizontalCoordinateSystemName"));



            this.GeocentricCoordinateSystemName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("geocentricCoordinateSystemName"));



            this.FileLocation = XsdConverter.Instance.Convert<Uri>(
                    attributes.GetSafe("fileLocation"));



            this.RotationAngle = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("rotationAngle"));



            this.Datum = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("datum"));



            this.FittedCoordinateSystemName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("fittedCoordinateSystemName"));



            this.CompoundCoordinateSystemName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("compoundCoordinateSystemName"));



            this.LocalCoordinateSystemName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("localCoordinateSystemName"));



            this.GeographicCoordinateSystemName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("geographicCoordinateSystemName"));



            this.ProjectedCoordinateSystemName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("projectedCoordinateSystemName"));



            this.VerticalCoordinateSystemName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("verticalCoordinateSystemName"));



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
            if ((object)this.EpsgCode != null)
            {
                buff.AppendFormat("epsgCode = {0}", this.EpsgCode).AppendLine();
            }
            if ((object)this.OgcWktCode != null)
            {
                buff.AppendFormat("ogcWktCode = {0}", this.OgcWktCode).AppendLine();
            }
            if ((object)this.HorizontalDatum != null)
            {
                buff.AppendFormat("horizontalDatum = {0}", this.HorizontalDatum).AppendLine();
            }
            if ((object)this.VerticalDatum != null)
            {
                buff.AppendFormat("verticalDatum = {0}", this.VerticalDatum).AppendLine();
            }
            if ((object)this.EllipsoidName != null)
            {
                buff.AppendFormat("ellipsoidName = {0}", this.EllipsoidName).AppendLine();
            }
            if ((object)this.HorizontalCoordinateSystemName != null)
            {
                buff.AppendFormat("horizontalCoordinateSystemName = {0}", this.HorizontalCoordinateSystemName).AppendLine();
            }
            if ((object)this.GeocentricCoordinateSystemName != null)
            {
                buff.AppendFormat("geocentricCoordinateSystemName = {0}", this.GeocentricCoordinateSystemName).AppendLine();
            }
            if ((object)this.FileLocation != null)
            {
                buff.AppendFormat("fileLocation = {0}", this.FileLocation).AppendLine();
            }
            if ((object)this.RotationAngle != null)
            {
                buff.AppendFormat("rotationAngle = {0}", this.RotationAngle).AppendLine();
            }
            if ((object)this.Datum != null)
            {
                buff.AppendFormat("datum = {0}", this.Datum).AppendLine();
            }
            if ((object)this.FittedCoordinateSystemName != null)
            {
                buff.AppendFormat("fittedCoordinateSystemName = {0}", this.FittedCoordinateSystemName).AppendLine();
            }
            if ((object)this.CompoundCoordinateSystemName != null)
            {
                buff.AppendFormat("compoundCoordinateSystemName = {0}", this.CompoundCoordinateSystemName).AppendLine();
            }
            if ((object)this.LocalCoordinateSystemName != null)
            {
                buff.AppendFormat("localCoordinateSystemName = {0}", this.LocalCoordinateSystemName).AppendLine();
            }
            if ((object)this.GeographicCoordinateSystemName != null)
            {
                buff.AppendFormat("geographicCoordinateSystemName = {0}", this.GeographicCoordinateSystemName).AppendLine();
            }
            if ((object)this.ProjectedCoordinateSystemName != null)
            {
                buff.AppendFormat("projectedCoordinateSystemName = {0}", this.ProjectedCoordinateSystemName).AppendLine();
            }
            if ((object)this.VerticalCoordinateSystemName != null)
            {
                buff.AppendFormat("verticalCoordinateSystemName = {0}", this.VerticalCoordinateSystemName).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.EpsgCode != null)
            {
                buff.AppendFormat(" epsgCode=\"{0}\"", this.EpsgCode);
            }
            if ((object)this.OgcWktCode != null)
            {
                buff.AppendFormat(" ogcWktCode=\"{0}\"", this.OgcWktCode);
            }
            if ((object)this.HorizontalDatum != null)
            {
                buff.AppendFormat(" horizontalDatum=\"{0}\"", this.HorizontalDatum);
            }
            if ((object)this.VerticalDatum != null)
            {
                buff.AppendFormat(" verticalDatum=\"{0}\"", this.VerticalDatum);
            }
            if ((object)this.EllipsoidName != null)
            {
                buff.AppendFormat(" ellipsoidName=\"{0}\"", this.EllipsoidName);
            }
            if ((object)this.HorizontalCoordinateSystemName != null)
            {
                buff.AppendFormat(" horizontalCoordinateSystemName=\"{0}\"", this.HorizontalCoordinateSystemName);
            }
            if ((object)this.GeocentricCoordinateSystemName != null)
            {
                buff.AppendFormat(" geocentricCoordinateSystemName=\"{0}\"", this.GeocentricCoordinateSystemName);
            }
            if ((object)this.FileLocation != null)
            {
                buff.AppendFormat(" fileLocation=\"{0}\"", this.FileLocation);
            }
            if ((object)this.RotationAngle != null)
            {
                buff.AppendFormat(" rotationAngle=\"{0}\"", this.RotationAngle);
            }
            if ((object)this.Datum != null)
            {
                buff.AppendFormat(" datum=\"{0}\"", this.Datum);
            }
            if ((object)this.FittedCoordinateSystemName != null)
            {
                buff.AppendFormat(" fittedCoordinateSystemName=\"{0}\"", this.FittedCoordinateSystemName);
            }
            if ((object)this.CompoundCoordinateSystemName != null)
            {
                buff.AppendFormat(" compoundCoordinateSystemName=\"{0}\"", this.CompoundCoordinateSystemName);
            }
            if ((object)this.LocalCoordinateSystemName != null)
            {
                buff.AppendFormat(" localCoordinateSystemName=\"{0}\"", this.LocalCoordinateSystemName);
            }
            if ((object)this.GeographicCoordinateSystemName != null)
            {
                buff.AppendFormat(" geographicCoordinateSystemName=\"{0}\"", this.GeographicCoordinateSystemName);
            }
            if ((object)this.ProjectedCoordinateSystemName != null)
            {
                buff.AppendFormat(" projectedCoordinateSystemName=\"{0}\"", this.ProjectedCoordinateSystemName);
            }
            if ((object)this.VerticalCoordinateSystemName != null)
            {
                buff.AppendFormat(" verticalCoordinateSystemName=\"{0}\"", this.VerticalCoordinateSystemName);
            }


            return buff.ToString();
        }

        public string Desc;

        public string Name;

        public string EpsgCode;

        public string OgcWktCode;

        public string HorizontalDatum;

        public string VerticalDatum;

        public string EllipsoidName;

        public string HorizontalCoordinateSystemName;

        public string GeocentricCoordinateSystemName;

        public Uri FileLocation;
        /// <summary>
        /// Represents a normalized angular value in the specified Angular units. Assume 0 degrees = east
        /// </summary>

        public double? RotationAngle;

        public string Datum;

        public string FittedCoordinateSystemName;

        public string CompoundCoordinateSystemName;

        public string LocalCoordinateSystemName;

        public string GeographicCoordinateSystemName;

        public string ProjectedCoordinateSystemName;

        public string VerticalCoordinateSystemName;


    }
}
#endif
