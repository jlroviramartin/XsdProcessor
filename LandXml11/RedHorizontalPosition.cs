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
    /// This element is used to define the Reduced Horizontal Position. The coordinates given in Geographical Coordinates may come in variety of means.     
    /// Choice [0, *]
    ///     FieldNote [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class RedHorizontalPosition : XsdBaseReader
    {
        public RedHorizontalPosition(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.State = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("state"));

            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));

            this.Purpose = XsdConverter.Instance.Convert<PurposeType?>(
                    attributes.GetSafe("purpose"));

            this.SetupID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("setupID"));

            this.Date = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("date"));

            this.EquipmentUsed = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("equipmentUsed"));

            this.HorizontalDatum = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("horizontalDatum"));

            this.HorizontalAdjustment = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("horizontalAdjustment"));

            this.Latitude = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("latitude"));

            this.Longitude = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("longitude"));

            this.HorizontalFix = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("horizontalFix"));

            this.CurrencyDate = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("currencyDate"));

            this.LocalUncertainity = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("localUncertainity"));

            this.Class = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("class"));

            this.Order = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("order"));

            this.PositionalUncertainity = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("positionalUncertainity"));

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
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.Purpose != null)
            {
                buff.AppendFormat("purpose = {0}", this.Purpose).AppendLine();
            }
            if ((object)this.SetupID != null)
            {
                buff.AppendFormat("setupID = {0}", this.SetupID).AppendLine();
            }
            if ((object)this.Date != null)
            {
                buff.AppendFormat("date = {0}", this.Date).AppendLine();
            }
            if ((object)this.EquipmentUsed != null)
            {
                buff.AppendFormat("equipmentUsed = {0}", this.EquipmentUsed).AppendLine();
            }
            if ((object)this.HorizontalDatum != null)
            {
                buff.AppendFormat("horizontalDatum = {0}", this.HorizontalDatum).AppendLine();
            }
            if ((object)this.HorizontalAdjustment != null)
            {
                buff.AppendFormat("horizontalAdjustment = {0}", this.HorizontalAdjustment).AppendLine();
            }
            if ((object)this.Latitude != null)
            {
                buff.AppendFormat("latitude = {0}", this.Latitude).AppendLine();
            }
            if ((object)this.Longitude != null)
            {
                buff.AppendFormat("longitude = {0}", this.Longitude).AppendLine();
            }
            if ((object)this.HorizontalFix != null)
            {
                buff.AppendFormat("horizontalFix = {0}", this.HorizontalFix).AppendLine();
            }
            if ((object)this.CurrencyDate != null)
            {
                buff.AppendFormat("currencyDate = {0}", this.CurrencyDate).AppendLine();
            }
            if ((object)this.LocalUncertainity != null)
            {
                buff.AppendFormat("localUncertainity = {0}", this.LocalUncertainity).AppendLine();
            }
            if ((object)this.Class != null)
            {
                buff.AppendFormat("class = {0}", this.Class).AppendLine();
            }
            if ((object)this.Order != null)
            {
                buff.AppendFormat("order = {0}", this.Order).AppendLine();
            }
            if ((object)this.PositionalUncertainity != null)
            {
                buff.AppendFormat("positionalUncertainity = {0}", this.PositionalUncertainity).AppendLine();
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
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.OID != null)
            {
                buff.Append("oID", this.OID);
            }
            if ((object)this.Purpose != null)
            {
                buff.Append("purpose", this.Purpose);
            }
            if ((object)this.SetupID != null)
            {
                buff.Append("setupID", this.SetupID);
            }
            if ((object)this.Date != null)
            {
                buff.Append("date", this.Date);
            }
            if ((object)this.EquipmentUsed != null)
            {
                buff.Append("equipmentUsed", this.EquipmentUsed);
            }
            if ((object)this.HorizontalDatum != null)
            {
                buff.Append("horizontalDatum", this.HorizontalDatum);
            }
            if ((object)this.HorizontalAdjustment != null)
            {
                buff.Append("horizontalAdjustment", this.HorizontalAdjustment);
            }
            if ((object)this.Latitude != null)
            {
                buff.Append("latitude", this.Latitude);
            }
            if ((object)this.Longitude != null)
            {
                buff.Append("longitude", this.Longitude);
            }
            if ((object)this.HorizontalFix != null)
            {
                buff.Append("horizontalFix", this.HorizontalFix);
            }
            if ((object)this.CurrencyDate != null)
            {
                buff.Append("currencyDate", this.CurrencyDate);
            }
            if ((object)this.LocalUncertainity != null)
            {
                buff.Append("localUncertainity", this.LocalUncertainity);
            }
            if ((object)this.Class != null)
            {
                buff.Append("class", this.Class);
            }
            if ((object)this.Order != null)
            {
                buff.Append("order", this.Order);
            }
            if ((object)this.PositionalUncertainity != null)
            {
                buff.Append("positionalUncertainity", this.PositionalUncertainity);
            }

            return buff.ToString();
        }

        public string Desc;

        public string Name;

        public string State;

        public string OID;
        /// <summary>
        /// Used by many of the Survey elements
        /// </summary>

        public PurposeType? Purpose;

        public string SetupID;

        public DateTime? Date;
        /// <summary>
        /// This gives a list of equipment used for the observation this list of equipment is used to estimate the accuracy of the observation.. 
        /// </summary>

        public string EquipmentUsed;

        public string HorizontalDatum;

        public string HorizontalAdjustment;

        public string Latitude;

        public string Longitude;

        public string HorizontalFix;

        public string CurrencyDate;

        public double? LocalUncertainity;

        public string Class;

        public string Order;

        public double? PositionalUncertainity;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("FieldNote"))
            {
                return Tuple.Create("FieldNote", this.NewReader<FieldNote>());
            }

            return null;
        }
    }
}
#endif

