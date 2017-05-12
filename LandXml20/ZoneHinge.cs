#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Choice [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class ZoneHinge : XsdBaseReader
    {
        public ZoneHinge(System.Xml.XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double StaStart;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double StaEnd;

        public ZoneHingeType HingeType;

        public int ZonePriorityRef;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.StaStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staStart"));

            this.StaEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("staEnd"));

            this.HingeType = XsdConverter.Instance.Convert<ZoneHingeType>(
                    attributes.GetSafe("hingeType"));

            this.ZonePriorityRef = XsdConverter.Instance.Convert<int>(
                    attributes.GetSafe("zonePriorityRef"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.StaStart != null)
            {
                buff.Append("staStart", this.StaStart);
            }
            if ((object)this.StaEnd != null)
            {
                buff.Append("staEnd", this.StaEnd);
            }
            if ((object)this.HingeType != null)
            {
                buff.Append("hingeType", this.HingeType);
            }
            if ((object)this.ZonePriorityRef != null)
            {
                buff.Append("zonePriorityRef", this.ZonePriorityRef);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.StaEnd != null)
            {
                buff.AppendFormat("staEnd = {0}", this.StaEnd).AppendLine();
            }
            if ((object)this.HingeType != null)
            {
                buff.AppendFormat("hingeType = {0}", this.HingeType).AppendLine();
            }
            if ((object)this.ZonePriorityRef != null)
            {
                buff.AppendFormat("zonePriorityRef = {0}", this.ZonePriorityRef).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

