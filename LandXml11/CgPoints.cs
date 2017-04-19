#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// A collection of COGO points. (Cg = COGO = Cordinate Geometry)
    /// </summary>

    public class CgPoints : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));



            this.Code = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("code"));



            this.ZoneNumber = XsdConverter.Instance.Convert<uint?>(
                    attributes.GetSafe("zoneNumber"));



            this.DTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(
                    attributes.GetSafe("DTMAttribute"));



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
            if ((object)this.Code != null)
            {
                buff.AppendFormat("code = {0}", this.Code).AppendLine();
            }
            if ((object)this.ZoneNumber != null)
            {
                buff.AppendFormat("zoneNumber = {0}", this.ZoneNumber).AppendLine();
            }
            if ((object)this.DTMAttribute != null)
            {
                buff.AppendFormat("DTMAttribute = {0}", this.DTMAttribute).AppendLine();
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
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.Code != null)
            {
                buff.AppendFormat(" code=\"{0}\"", this.Code);
            }
            if ((object)this.ZoneNumber != null)
            {
                buff.AppendFormat(" zoneNumber=\"{0}\"", this.ZoneNumber);
            }
            if ((object)this.DTMAttribute != null)
            {
                buff.AppendFormat(" DTMAttribute=\"{0}\"", this.DTMAttribute);
            }


            return buff.ToString();
        }

        public string Desc;

        public string Name;

        public StateType? State;

        public string Code;

        public uint? ZoneNumber;

        public DTMAttributeType? DTMAttribute;


    }
}
#endif

