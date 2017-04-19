#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Modified to include official ID, as with all CoordGeom elements
    /// </summary>

    public class Line : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.Dir = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("dir"));



            this.Length = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("length"));



            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.StaStart = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("staStart"));



            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));



            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));



            this.Note = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("note"));



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
            if ((object)this.Dir != null)
            {
                buff.AppendFormat("dir = {0}", this.Dir).AppendLine();
            }
            if ((object)this.Length != null)
            {
                buff.AppendFormat("length = {0}", this.Length).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat("staStart = {0}", this.StaStart).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.Note != null)
            {
                buff.AppendFormat("note = {0}", this.Note).AppendLine();
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
            if ((object)this.Dir != null)
            {
                buff.AppendFormat(" dir=\"{0}\"", this.Dir);
            }
            if ((object)this.Length != null)
            {
                buff.AppendFormat(" length=\"{0}\"", this.Length);
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.StaStart != null)
            {
                buff.AppendFormat(" staStart=\"{0}\"", this.StaStart);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat(" oID=\"{0}\"", this.OID);
            }
            if ((object)this.Note != null)
            {
                buff.AppendFormat(" note=\"{0}\"", this.Note);
            }


            return buff.ToString();
        }

        public string Desc;
        /// <summary>
        /// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees = north
        /// </summary>

        public double? Dir;

        public double? Length;

        public string Name;

        public double? StaStart;

        public StateType? State;

        public string OID;

        public string Note;


    }
}
#endif

