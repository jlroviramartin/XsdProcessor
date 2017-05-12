#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Choice [0, *]
    ///     FieldNote [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class RedVerticalObservation : XsdBaseReader
    {
        public RedVerticalObservation(System.Xml.XmlReader reader) : base(reader)
        {
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

        public double? Height;

        public string VerticalAdjustment;

        public string VerticalFix;

        public double? Geosphoid;

        public string GsDatum;

        public string GsModel;

        public string GsMethod;

        public string OriginMark;

        public string VerticalDatum;

        public double? LocalUncertainity;

        public string Class;

        public string Order;

        public double? PositionalUncertainity;

        #region XsdBaseReader

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

        #endregion

        #region XsdBaseObject

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

            this.Height = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("height"));

            this.VerticalAdjustment = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("verticalAdjustment"));

            this.VerticalFix = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("verticalFix"));

            this.Geosphoid = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("geosphoid"));

            this.GsDatum = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("gsDatum"));

            this.GsModel = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("gsModel"));

            this.GsMethod = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("gsMethod"));

            this.OriginMark = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("originMark"));

            this.VerticalDatum = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("verticalDatum"));

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
            if ((object)this.Height != null)
            {
                buff.Append("height", this.Height);
            }
            if ((object)this.VerticalAdjustment != null)
            {
                buff.Append("verticalAdjustment", this.VerticalAdjustment);
            }
            if ((object)this.VerticalFix != null)
            {
                buff.Append("verticalFix", this.VerticalFix);
            }
            if ((object)this.Geosphoid != null)
            {
                buff.Append("geosphoid", this.Geosphoid);
            }
            if ((object)this.GsDatum != null)
            {
                buff.Append("gsDatum", this.GsDatum);
            }
            if ((object)this.GsModel != null)
            {
                buff.Append("gsModel", this.GsModel);
            }
            if ((object)this.GsMethod != null)
            {
                buff.Append("gsMethod", this.GsMethod);
            }
            if ((object)this.OriginMark != null)
            {
                buff.Append("originMark", this.OriginMark);
            }
            if ((object)this.VerticalDatum != null)
            {
                buff.Append("verticalDatum", this.VerticalDatum);
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

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

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
            if ((object)this.Height != null)
            {
                buff.AppendFormat("height = {0}", this.Height).AppendLine();
            }
            if ((object)this.VerticalAdjustment != null)
            {
                buff.AppendFormat("verticalAdjustment = {0}", this.VerticalAdjustment).AppendLine();
            }
            if ((object)this.VerticalFix != null)
            {
                buff.AppendFormat("verticalFix = {0}", this.VerticalFix).AppendLine();
            }
            if ((object)this.Geosphoid != null)
            {
                buff.AppendFormat("geosphoid = {0}", this.Geosphoid).AppendLine();
            }
            if ((object)this.GsDatum != null)
            {
                buff.AppendFormat("gsDatum = {0}", this.GsDatum).AppendLine();
            }
            if ((object)this.GsModel != null)
            {
                buff.AppendFormat("gsModel = {0}", this.GsModel).AppendLine();
            }
            if ((object)this.GsMethod != null)
            {
                buff.AppendFormat("gsMethod = {0}", this.GsMethod).AppendLine();
            }
            if ((object)this.OriginMark != null)
            {
                buff.AppendFormat("originMark = {0}", this.OriginMark).AppendLine();
            }
            if ((object)this.VerticalDatum != null)
            {
                buff.AppendFormat("verticalDatum = {0}", this.VerticalDatum).AppendLine();
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

        #endregion
    }
}
#endif

