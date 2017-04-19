#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// SourceData is an optional collection of the points, contours, breaklines and boundaries that were used to create the surface.
    /// Definition is a collection of points and faces that define the surface.
    /// Watersheds is a collection the watershed boundaries for the surface.
    /// </summary>

    public class Surface : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("OID"));



            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("OID = {0}", this.OID).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat(" OID=\"{0}\"", this.OID);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }


            return buff.ToString();
        }

        public string Name;

        public string Desc;

        public string OID;

        public StateType? State;


    }
}
#endif

