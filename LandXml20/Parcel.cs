#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Modified to include parcel class and an official ID
    /// Sequence [1, 1]
    ///     Choice [1, *]
    ///         Center [0, 1]
    ///         CoordGeom [1, 1]
    ///         VolumeGeom [0, *]
    ///         Parcels [0, *]
    ///         Title [0, *]
    ///         Exclusions [0, *]
    ///         LocationAddress [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class Parcel : XsdBaseReader
    {
        public Parcel(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public string OID;

        public double? Area;

        public string Desc;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? DirClosure;

        public double? DistClosure;

        public string Owner;

        public string ParcelType;

        public double? SetbackFront;

        public double? SetbackRear;

        public double? SetbackSide;
        /// <summary>
        /// This is an extension of the LandXML state type, but is specific to parcels
        /// </summary>

        public ParcelStateType? State;

        public string TaxId;
        /// <summary>
        /// This is a list of parcel classes which may be jurisdictionally specific defined by regulation and legislation.
        /// </summary>

        public string Class;
        /// <summary>
        /// Describes what the parcel is used for.  This would be a jurisdictionally specific list.
        /// </summary>

        public string UseOfParcel;
        /// <summary>
        /// Parcel Format describes how the parcel is described , ie Standard (2D), Volumertric (3D)
        /// </summary>

        public string ParcelFormat;

        public string BuildingNo;

        public string BuildingLevelNo;

        public string Volume;
        /// <summary>
        /// A reference name value referring to Parcel.name attribute.
        /// </summary>

        public string PclRef;

        public string LotEntitlements;

        public string LiabilityApportionment;
        /// <summary>
        /// A integer based index value to a table item in the material table.
        /// </summary>

        public IList<int?> M;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("LocationAddress"))
            {
                return Tuple.Create("LocationAddress", this.NewReader<LocationAddress>());
            }
            if (name.EqualsIgnoreCase("Exclusions"))
            {
                return Tuple.Create("Exclusions", this.NewReader<Exclusions>());
            }
            if (name.EqualsIgnoreCase("Title"))
            {
                return Tuple.Create("Title", this.NewReader<Title>());
            }
            if (name.EqualsIgnoreCase("Parcels"))
            {
                return Tuple.Create("Parcels", this.NewReader<Parcels>());
            }
            if (name.EqualsIgnoreCase("VolumeGeom"))
            {
                return Tuple.Create("VolumeGeom", this.NewReader<VolumeGeom>());
            }
            if (name.EqualsIgnoreCase("CoordGeom"))
            {
                return Tuple.Create("CoordGeom", this.NewReader<CoordGeom>());
            }
            if (name.EqualsIgnoreCase("Center"))
            {
                return Tuple.Create("Center", this.NewReader<PointType>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));

            this.Area = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("area"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.DirClosure = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("dirClosure"));

            this.DistClosure = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("distClosure"));

            this.Owner = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("owner"));

            this.ParcelType = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("parcelType"));

            this.SetbackFront = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("setbackFront"));

            this.SetbackRear = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("setbackRear"));

            this.SetbackSide = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("setbackSide"));

            this.State = XsdConverter.Instance.Convert<ParcelStateType?>(
                    attributes.GetSafe("state"));

            this.TaxId = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("taxId"));

            this.Class = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("class"));

            this.UseOfParcel = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("useOfParcel"));

            this.ParcelFormat = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("parcelFormat"));

            this.BuildingNo = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("buildingNo"));

            this.BuildingLevelNo = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("buildingLevelNo"));

            this.Volume = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("volume"));

            this.PclRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("pclRef"));

            this.LotEntitlements = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("lotEntitlements"));

            this.LiabilityApportionment = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("liabilityApportionment"));

            this.M = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("m"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.OID != null)
            {
                buff.Append("oID", this.OID);
            }
            if ((object)this.Area != null)
            {
                buff.Append("area", this.Area);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.DirClosure != null)
            {
                buff.Append("dirClosure", this.DirClosure);
            }
            if ((object)this.DistClosure != null)
            {
                buff.Append("distClosure", this.DistClosure);
            }
            if ((object)this.Owner != null)
            {
                buff.Append("owner", this.Owner);
            }
            if ((object)this.ParcelType != null)
            {
                buff.Append("parcelType", this.ParcelType);
            }
            if ((object)this.SetbackFront != null)
            {
                buff.Append("setbackFront", this.SetbackFront);
            }
            if ((object)this.SetbackRear != null)
            {
                buff.Append("setbackRear", this.SetbackRear);
            }
            if ((object)this.SetbackSide != null)
            {
                buff.Append("setbackSide", this.SetbackSide);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.TaxId != null)
            {
                buff.Append("taxId", this.TaxId);
            }
            if ((object)this.Class != null)
            {
                buff.Append("class", this.Class);
            }
            if ((object)this.UseOfParcel != null)
            {
                buff.Append("useOfParcel", this.UseOfParcel);
            }
            if ((object)this.ParcelFormat != null)
            {
                buff.Append("parcelFormat", this.ParcelFormat);
            }
            if ((object)this.BuildingNo != null)
            {
                buff.Append("buildingNo", this.BuildingNo);
            }
            if ((object)this.BuildingLevelNo != null)
            {
                buff.Append("buildingLevelNo", this.BuildingLevelNo);
            }
            if ((object)this.Volume != null)
            {
                buff.Append("volume", this.Volume);
            }
            if ((object)this.PclRef != null)
            {
                buff.Append("pclRef", this.PclRef);
            }
            if ((object)this.LotEntitlements != null)
            {
                buff.Append("lotEntitlements", this.LotEntitlements);
            }
            if ((object)this.LiabilityApportionment != null)
            {
                buff.Append("liabilityApportionment", this.LiabilityApportionment);
            }
            if ((object)this.M != null)
            {
                buff.Append("m", this.M);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.Area != null)
            {
                buff.AppendFormat("area = {0}", this.Area).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.DirClosure != null)
            {
                buff.AppendFormat("dirClosure = {0}", this.DirClosure).AppendLine();
            }
            if ((object)this.DistClosure != null)
            {
                buff.AppendFormat("distClosure = {0}", this.DistClosure).AppendLine();
            }
            if ((object)this.Owner != null)
            {
                buff.AppendFormat("owner = {0}", this.Owner).AppendLine();
            }
            if ((object)this.ParcelType != null)
            {
                buff.AppendFormat("parcelType = {0}", this.ParcelType).AppendLine();
            }
            if ((object)this.SetbackFront != null)
            {
                buff.AppendFormat("setbackFront = {0}", this.SetbackFront).AppendLine();
            }
            if ((object)this.SetbackRear != null)
            {
                buff.AppendFormat("setbackRear = {0}", this.SetbackRear).AppendLine();
            }
            if ((object)this.SetbackSide != null)
            {
                buff.AppendFormat("setbackSide = {0}", this.SetbackSide).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.TaxId != null)
            {
                buff.AppendFormat("taxId = {0}", this.TaxId).AppendLine();
            }
            if ((object)this.Class != null)
            {
                buff.AppendFormat("class = {0}", this.Class).AppendLine();
            }
            if ((object)this.UseOfParcel != null)
            {
                buff.AppendFormat("useOfParcel = {0}", this.UseOfParcel).AppendLine();
            }
            if ((object)this.ParcelFormat != null)
            {
                buff.AppendFormat("parcelFormat = {0}", this.ParcelFormat).AppendLine();
            }
            if ((object)this.BuildingNo != null)
            {
                buff.AppendFormat("buildingNo = {0}", this.BuildingNo).AppendLine();
            }
            if ((object)this.BuildingLevelNo != null)
            {
                buff.AppendFormat("buildingLevelNo = {0}", this.BuildingLevelNo).AppendLine();
            }
            if ((object)this.Volume != null)
            {
                buff.AppendFormat("volume = {0}", this.Volume).AppendLine();
            }
            if ((object)this.PclRef != null)
            {
                buff.AppendFormat("pclRef = {0}", this.PclRef).AppendLine();
            }
            if ((object)this.LotEntitlements != null)
            {
                buff.AppendFormat("lotEntitlements = {0}", this.LotEntitlements).AppendLine();
            }
            if ((object)this.LiabilityApportionment != null)
            {
                buff.AppendFormat("liabilityApportionment = {0}", this.LiabilityApportionment).AppendLine();
            }
            if ((object)this.M != null)
            {
                buff.AppendFormat("m = {0}", this.M).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

