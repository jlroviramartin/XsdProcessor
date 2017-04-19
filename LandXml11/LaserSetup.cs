#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public class LaserSetup : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Id = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("id"));



            this.StationName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("stationName"));



            this.InstrumentHeight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("instrumentHeight"));



            this.LaserDetailsID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("laserDetailsID"));



            this.MagDeclination = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("magDeclination"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Id != null)
            {
                buff.AppendFormat("id = {0}", this.Id).AppendLine();
            }
            if ((object)this.StationName != null)
            {
                buff.AppendFormat("stationName = {0}", this.StationName).AppendLine();
            }
            if ((object)this.InstrumentHeight != null)
            {
                buff.AppendFormat("instrumentHeight = {0}", this.InstrumentHeight).AppendLine();
            }
            if ((object)this.LaserDetailsID != null)
            {
                buff.AppendFormat("laserDetailsID = {0}", this.LaserDetailsID).AppendLine();
            }
            if ((object)this.MagDeclination != null)
            {
                buff.AppendFormat("magDeclination = {0}", this.MagDeclination).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Id != null)
            {
                buff.AppendFormat(" id=\"{0}\"", this.Id);
            }
            if ((object)this.StationName != null)
            {
                buff.AppendFormat(" stationName=\"{0}\"", this.StationName);
            }
            if ((object)this.InstrumentHeight != null)
            {
                buff.AppendFormat(" instrumentHeight=\"{0}\"", this.InstrumentHeight);
            }
            if ((object)this.LaserDetailsID != null)
            {
                buff.AppendFormat(" laserDetailsID=\"{0}\"", this.LaserDetailsID);
            }
            if ((object)this.MagDeclination != null)
            {
                buff.AppendFormat(" magDeclination=\"{0}\"", this.MagDeclination);
            }


            return buff.ToString();
        }

        public string Id;

        public string StationName;

        public double? InstrumentHeight;

        public string LaserDetailsID;

        public double? MagDeclination;


    }
}
#endif

