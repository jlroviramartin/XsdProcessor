#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// This element contains one "Structs" collection element and one "Pipes" collection element.
    /// keyRef is a Schema validation mechanism that ensures that the "structRef" and "pipeRef" attribute values have corresponding Pipe and Struct "name" values"
    /// </summary>

    public class PipeNetwork : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.PipeNetType = XsdConverter.Instance.Convert<PipeNetworkType>(
                    attributes.GetSafe("pipeNetType"));



            this.AlignmentRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("alignmentRef"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));



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
            if ((object)this.PipeNetType != null)
            {
                buff.AppendFormat("pipeNetType = {0}", this.PipeNetType).AppendLine();
            }
            if ((object)this.AlignmentRef != null)
            {
                buff.AppendFormat("alignmentRef = {0}", this.AlignmentRef).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
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
            if ((object)this.PipeNetType != null)
            {
                buff.AppendFormat(" pipeNetType=\"{0}\"", this.PipeNetType);
            }
            if ((object)this.AlignmentRef != null)
            {
                buff.AppendFormat(" alignmentRef=\"{0}\"", this.AlignmentRef);
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat(" oID=\"{0}\"", this.OID);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }


            return buff.ToString();
        }

        public string Name;

        public PipeNetworkType PipeNetType;
        /// <summary>
        /// A reference name value referring to Alignment.name attribute.
        /// </summary>

        public string AlignmentRef;

        public string Desc;

        public string OID;

        public StateType? State;


    }
}
#endif

