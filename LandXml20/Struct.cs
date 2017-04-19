#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Each Struct within a Structs collection element must have a unique  "name" attribute.
    /// The structure type is determined by the existance of one of the following elements: CircStruct or RectStruct.
    /// The Center element will contain the "north east" coordinate text value or a CgPoint "refPnt" attribute.
    /// Each Invert element contains a "refPipe" attribute to reference a Pipe element  "name"
    /// </summary>

    public class Struct : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));



            this.ElevRim = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("elevRim"));



            this.ElevSump = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("elevSump"));



            this.OID = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("oID"));



            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));



            this.M = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("m"));



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
            if ((object)this.ElevRim != null)
            {
                buff.AppendFormat("elevRim = {0}", this.ElevRim).AppendLine();
            }
            if ((object)this.ElevSump != null)
            {
                buff.AppendFormat("elevSump = {0}", this.ElevSump).AppendLine();
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat("oID = {0}", this.OID).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.M != null)
            {
                buff.AppendFormat("m = {0}", this.M).AppendLine();
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
            if ((object)this.ElevRim != null)
            {
                buff.AppendFormat(" elevRim=\"{0}\"", this.ElevRim);
            }
            if ((object)this.ElevSump != null)
            {
                buff.AppendFormat(" elevSump=\"{0}\"", this.ElevSump);
            }
            if ((object)this.OID != null)
            {
                buff.AppendFormat(" oID=\"{0}\"", this.OID);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.M != null)
            {
                buff.AppendFormat(" m=\"{0}\"", this.M);
            }


            return buff.ToString();
        }

        public string Name;

        public string Desc;

        public double? ElevRim;

        public double? ElevSump;

        public string OID;

        public StateType? State;
        /// <summary>
        /// A integer based index value to a table item in the material table.
        /// </summary>

        public IList<int?> M;


    }
}
#endif

