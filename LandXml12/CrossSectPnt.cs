#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    // needContent    : true
    // includeContent : false
    public class CrossSectPnt : PointType
    {
        public CrossSectPnt(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.DataFormat = XsdConverter.Instance.Convert<DataFormatType?>(
                    attributes.GetSafe("dataFormat"),
                    XsdConverter.Instance.Convert<DataFormatType?>("Offset Elevation"));

            this.AlignRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("alignRef"));

            this.AlignRefStation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("alignRefStation"));

            this.PlanFeatureRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("planFeatureRef"));

            this.PlanFeatureRefStation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("planFeatureRefStation"));

            this.ParcelRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("parcelRef"));

            this.ParcelRefStation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("parcelRefStation"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.DataFormat != null)
            {
                buff.AppendFormat("dataFormat = {0} defvalue = {1}", this.DataFormat, "Offset Elevation").AppendLine();
            }
            if ((object)this.AlignRef != null)
            {
                buff.AppendFormat("alignRef = {0}", this.AlignRef).AppendLine();
            }
            if ((object)this.AlignRefStation != null)
            {
                buff.AppendFormat("alignRefStation = {0}", this.AlignRefStation).AppendLine();
            }
            if ((object)this.PlanFeatureRef != null)
            {
                buff.AppendFormat("planFeatureRef = {0}", this.PlanFeatureRef).AppendLine();
            }
            if ((object)this.PlanFeatureRefStation != null)
            {
                buff.AppendFormat("planFeatureRefStation = {0}", this.PlanFeatureRefStation).AppendLine();
            }
            if ((object)this.ParcelRef != null)
            {
                buff.AppendFormat("parcelRef = {0}", this.ParcelRef).AppendLine();
            }
            if ((object)this.ParcelRefStation != null)
            {
                buff.AppendFormat("parcelRefStation = {0}", this.ParcelRefStation).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.DataFormat != null)
            {
                buff.Append("dataFormat", this.DataFormat);
            }
            if ((object)this.AlignRef != null)
            {
                buff.Append("alignRef", this.AlignRef);
            }
            if ((object)this.AlignRefStation != null)
            {
                buff.Append("alignRefStation", this.AlignRefStation);
            }
            if ((object)this.PlanFeatureRef != null)
            {
                buff.Append("planFeatureRef", this.PlanFeatureRef);
            }
            if ((object)this.PlanFeatureRefStation != null)
            {
                buff.Append("planFeatureRefStation", this.PlanFeatureRefStation);
            }
            if ((object)this.ParcelRef != null)
            {
                buff.Append("parcelRef", this.ParcelRef);
            }
            if ((object)this.ParcelRefStation != null)
            {
                buff.Append("parcelRefStation", this.ParcelRefStation);
            }

            return buff.ToString();
        }

        public DataFormatType? DataFormat;
        /// <summary>
        /// A reference name value referring to Alignment.name attribute.
        /// </summary>

        public string AlignRef;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? AlignRefStation;
        /// <summary>
        /// A reference name value referring to PlanFeature.name attribute.
        /// </summary>

        public string PlanFeatureRef;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? PlanFeatureRefStation;
        /// <summary>
        /// A reference name value referring to Parcel.name attribute.
        /// </summary>

        public string ParcelRef;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? ParcelRefStation;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }
    }
}
#endif

