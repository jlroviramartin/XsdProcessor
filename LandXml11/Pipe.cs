#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Each Pipe within a Pipes collection element will have a unique  "name" attribute.
    /// The pipe type is determined by the existance of one of the following elements: CircPipe, ElliPipe or RectPipe.
    /// The "startRef and "endRef" attributes reference Struct "name" values.
    /// The start and end invert elevations for the pipe are defined in the Invert elements of referenced structures.
    /// Since a struct may have more than one Invert element, the Invert "pipeRef" attribute is used to select the correct invert element.
    /// </summary>

    public class Pipe : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.RefEnd = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("refEnd"));



            this.RefStart = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("refStart"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.Length = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("length"));



            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));



            this.Slope = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("slope"));



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
            if ((object)this.RefEnd != null)
            {
                buff.AppendFormat("refEnd = {0}", this.RefEnd).AppendLine();
            }
            if ((object)this.RefStart != null)
            {
                buff.AppendFormat("refStart = {0}", this.RefStart).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Length != null)
            {
                buff.AppendFormat("length = {0}", this.Length).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.Slope != null)
            {
                buff.AppendFormat("slope = {0}", this.Slope).AppendLine();
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
            if ((object)this.RefEnd != null)
            {
                buff.AppendFormat(" refEnd=\"{0}\"", this.RefEnd);
            }
            if ((object)this.RefStart != null)
            {
                buff.AppendFormat(" refStart=\"{0}\"", this.RefStart);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.Length != null)
            {
                buff.AppendFormat(" length=\"{0}\"", this.Length);
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat(" oID=\"{0}\"", this.OID);
            }
            if ((object)this.Slope != null)
            {
                buff.AppendFormat(" slope=\"{0}\"", this.Slope);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }


            return buff.ToString();
        }

        public string Name;
        /// <summary>
        /// A reference name value referring to Struct.name attribute.
        /// </summary>

        public string RefEnd;
        /// <summary>
        /// A reference name value referring to Struct.name attribute.
        /// </summary>

        public string RefStart;

        public string Desc;

        public double? Length;

        public string OID;

        public double? Slope;

        public StateType? State;


    }
}
#endif

