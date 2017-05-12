#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// Choice [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class CrashHistory : XsdBaseReader
    {
        public CrashHistory(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Year = XsdConverter.Instance.Convert<DateTime?>(
                    attributes.GetSafe("year"));

            this.Location1 = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("location-1"));

            this.Location2 = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("location-2"));

            this.Severity = XsdConverter.Instance.Convert<CrashSeverityType?>(
                    attributes.GetSafe("severity"));

            this.IntersectionRelation = XsdConverter.Instance.Convert<CrashIntersectionRelation?>(
                    attributes.GetSafe("intersectionRelation"));

            this.IntersectionLocation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("intersectionLocation"));

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Year != null)
            {
                buff.AppendFormat("year = {0}", this.Year).AppendLine();
            }
            if ((object)this.Location1 != null)
            {
                buff.AppendFormat("location-1 = {0}", this.Location1).AppendLine();
            }
            if ((object)this.Location2 != null)
            {
                buff.AppendFormat("location-2 = {0}", this.Location2).AppendLine();
            }
            if ((object)this.Severity != null)
            {
                buff.AppendFormat("severity = {0}", this.Severity).AppendLine();
            }
            if ((object)this.IntersectionRelation != null)
            {
                buff.AppendFormat("intersectionRelation = {0}", this.IntersectionRelation).AppendLine();
            }
            if ((object)this.IntersectionLocation != null)
            {
                buff.AppendFormat("intersectionLocation = {0}", this.IntersectionLocation).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Year != null)
            {
                buff.Append("year", this.Year);
            }
            if ((object)this.Location1 != null)
            {
                buff.Append("location-1", this.Location1);
            }
            if ((object)this.Location2 != null)
            {
                buff.Append("location-2", this.Location2);
            }
            if ((object)this.Severity != null)
            {
                buff.Append("severity", this.Severity);
            }
            if ((object)this.IntersectionRelation != null)
            {
                buff.Append("intersectionRelation", this.IntersectionRelation);
            }
            if ((object)this.IntersectionLocation != null)
            {
                buff.Append("intersectionLocation", this.IntersectionLocation);
            }

            return buff.ToString();
        }

        public DateTime? Year;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? Location1;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? Location2;

        public CrashSeverityType? Severity;

        public CrashIntersectionRelation? IntersectionRelation;
        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? IntersectionLocation;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }
    }
}
#endif

