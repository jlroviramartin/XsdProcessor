#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// An "infinite" spiral radius is denoted by the value "INF". 
    /// This conforms to XML Schema which defines infinity as "INF" or "-INF" for all numeric datatypes 
    /// </summary>

    public class Spiral : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Length = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("length"));



            this.RadiusEnd = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("radiusEnd"));



            this.RadiusStart = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("radiusStart"));



            this.Rot = XsdConverter.Instance.Convert<Clockwise>(
                    attributes.GetSafe("rot"));



            this.SpiType = XsdConverter.Instance.Convert<SpiralType>(
                    attributes.GetSafe("spiType"));



            this.Chord = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("chord"));



            this.Constant = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("constant"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.DirEnd = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("dirEnd"));



            this.DirStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("dirStart"));



            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Theta = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("theta"));



            this.TotalY = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("totalY"));



            this.TotalX = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("totalX"));



            this.StaStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staStart"));



            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));



            this.TanLong = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("tanLong"));



            this.TanShort = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("tanShort"));



            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Length != null)
            {
                buff.AppendFormat("length = {0}", this.Length).AppendLine();
            }
            if ((object)this.RadiusEnd != null)
            {
                buff.AppendFormat("radiusEnd = {0}", this.RadiusEnd).AppendLine();
            }
            if ((object)this.RadiusStart != null)
            {
                buff.AppendFormat("radiusStart = {0}", this.RadiusStart).AppendLine();
            }
            if ((object)this.Rot != null)
            {
                buff.AppendFormat("rot = {0}", this.Rot).AppendLine();
            }
            if ((object)this.SpiType != null)
            {
                buff.AppendFormat("spiType = {0}", this.SpiType).AppendLine();
            }
            if ((object)this.Chord != null)
            {
                buff.AppendFormat("chord = {0}", this.Chord).AppendLine();
            }
            if ((object)this.Constant != null)
            {
                buff.AppendFormat("constant = {0}", this.Constant).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.DirEnd != null)
            {
                buff.AppendFormat("dirEnd = {0}", this.DirEnd).AppendLine();
            }
            if ((object)this.DirStart != null)
            {
                buff.AppendFormat("dirStart = {0}", this.DirStart).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Theta != null)
            {
                buff.AppendFormat("theta = {0}", this.Theta).AppendLine();
            }
            if ((object)this.TotalY != null)
            {
                buff.AppendFormat("totalY = {0}", this.TotalY).AppendLine();
            }
            if ((object)this.TotalX != null)
            {
                buff.AppendFormat("totalX = {0}", this.TotalX).AppendLine();
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.TanLong != null)
            {
                buff.AppendFormat("tanLong = {0}", this.TanLong).AppendLine();
            }
            if ((object)this.TanShort != null)
            {
                buff.AppendFormat("tanShort = {0}", this.TanShort).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Length != null)
            {
                buff.AppendFormat(" length=\"{0}\"", this.Length);
            }
            if ((object)this.RadiusEnd != null)
            {
                buff.AppendFormat(" radiusEnd=\"{0}\"", this.RadiusEnd);
            }
            if ((object)this.RadiusStart != null)
            {
                buff.AppendFormat(" radiusStart=\"{0}\"", this.RadiusStart);
            }
            if ((object)this.Rot != null)
            {
                buff.AppendFormat(" rot=\"{0}\"", this.Rot);
            }
            if ((object)this.SpiType != null)
            {
                buff.AppendFormat(" spiType=\"{0}\"", this.SpiType);
            }
            if ((object)this.Chord != null)
            {
                buff.AppendFormat(" chord=\"{0}\"", this.Chord);
            }
            if ((object)this.Constant != null)
            {
                buff.AppendFormat(" constant=\"{0}\"", this.Constant);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.DirEnd != null)
            {
                buff.AppendFormat(" dirEnd=\"{0}\"", this.DirEnd);
            }
            if ((object)this.DirStart != null)
            {
                buff.AppendFormat(" dirStart=\"{0}\"", this.DirStart);
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.Theta != null)
            {
                buff.AppendFormat(" theta=\"{0}\"", this.Theta);
            }
            if ((object)this.TotalY != null)
            {
                buff.AppendFormat(" totalY=\"{0}\"", this.TotalY);
            }
            if ((object)this.TotalX != null)
            {
                buff.AppendFormat(" totalX=\"{0}\"", this.TotalX);
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat(" staStart=\"{0}\"", this.StaStart);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.TanLong != null)
            {
                buff.AppendFormat(" tanLong=\"{0}\"", this.TanLong);
            }
            if ((object)this.TanShort != null)
            {
                buff.AppendFormat(" tanShort=\"{0}\"", this.TanShort);
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat(" oID=\"{0}\"", this.OID);
            }


            return buff.ToString();
        }

        public double Length;

        public double RadiusEnd;

        public double RadiusStart;

        public Clockwise Rot;

        public SpiralType SpiType;

        public double? Chord;

        public double? Constant;

        public string Desc;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? DirEnd;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? DirStart;

        public string Name;
        /// <summary>
        /// Represents a normalized angular value in the specified Angular units. Assume 0 degrees = east
        /// </summary>

        public double? Theta;

        public double? TotalY;

        public double? TotalX;

        public double? StaStart;

        public StateType? State;

        public double? TanLong;

        public double? TanShort;

        public string OID;


    }
}
#endif

