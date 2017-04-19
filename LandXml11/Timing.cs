#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class Timing : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Station = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("station"));



            this.LegNumber = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("legNumber"));



            this.ProtectedTurnPercent = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("protectedTurnPercent"));



            this.UnprotectedTurnPercent = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("unprotectedTurnPercent"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Station != null)
            {
                buff.AppendFormat("station = {0}", this.Station).AppendLine();
            }
            if ((object)this.LegNumber != null)
            {
                buff.AppendFormat("legNumber = {0}", this.LegNumber).AppendLine();
            }
            if ((object)this.ProtectedTurnPercent != null)
            {
                buff.AppendFormat("protectedTurnPercent = {0}", this.ProtectedTurnPercent).AppendLine();
            }
            if ((object)this.UnprotectedTurnPercent != null)
            {
                buff.AppendFormat("unprotectedTurnPercent = {0}", this.UnprotectedTurnPercent).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Station != null)
            {
                buff.AppendFormat(" station=\"{0}\"", this.Station);
            }
            if ((object)this.LegNumber != null)
            {
                buff.AppendFormat(" legNumber=\"{0}\"", this.LegNumber);
            }
            if ((object)this.ProtectedTurnPercent != null)
            {
                buff.AppendFormat(" protectedTurnPercent=\"{0}\"", this.ProtectedTurnPercent);
            }
            if ((object)this.UnprotectedTurnPercent != null)
            {
                buff.AppendFormat(" unprotectedTurnPercent=\"{0}\"", this.UnprotectedTurnPercent);
            }


            return buff.ToString();
        }

        /// <summary>
        /// Represents the actual measured distance along the geometry in numeric decimal form expressed in linear units. Also known as the internal station value where no station equations are applied.
        /// </summary>

        public double? Station;

        public int? LegNumber;

        public double? ProtectedTurnPercent;

        public double? UnprotectedTurnPercent;


    }
}
#endif

