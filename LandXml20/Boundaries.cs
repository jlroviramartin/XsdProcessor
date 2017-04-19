#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// The collection of boundaries that were used to define the surface.
    /// Use is optional.
    /// </summary>

    public class Boundaries : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.M = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("m"));



            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

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

            if ((object)this.M != null)
            {
                buff.AppendFormat(" m=\"{0}\"", this.M);
            }


            return buff.ToString();
        }

        /// <summary>
        /// A integer based index value to a table item in the material table.
        /// </summary>

        public IList<int?> M;


    }
}
#endif

