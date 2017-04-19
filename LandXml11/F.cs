#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// A surface face. It contains a space delimited list of "id" references for 3 (TIN) or 4 (grid) surface "P" points. 
    /// The 3 or 4 numbers represent the vertices on the face. Each number is a reference to the ID value of a surface point "P" for the face coordinates.
    /// Attribute "i" is optional, where a value of "1" indicating the face is part of the triangulation but is invisible.
    /// Attribute "n" is optional, space delimited face index values indicating the adjacent face index for each face edge, where a value of "0" (an invalid face index value) indicates the edge has NO neighboring face. The face index value is implied and defined from 1 to n number of F elements in a a single Faces collection. 
    /// Example:
    /// <!-- 
    /// <Faces>
    ///      <F>5 10 20</F>  Implied face index = 1
    ///    <F>5 10 20</F>  Implied face index = 2
    ///    <F>5 10 20</F>  Implied face index = 3
    ///    <F n="2 0 3" i="1">10 20 30</F>   Implied face index = 4
    ///   ...
    /// </Faces>
    /// -->
    /// Where 2 is the neighboring face index for the edge 10 to 20, 0 means no 
    /// neighbor between 20 and 30 and 3 is the neighbor index for 30 to 10. 
    /// </summary>

    public class F : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.I = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("i"));



            this.N = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("n"));



            this.Content = XsdConverter.Instance.Convert<IList<int>>(text);

            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

            if ((object)this.I != null)
            {
                buff.AppendFormat("i = {0}", this.I).AppendLine();
            }
            if ((object)this.N != null)
            {
                buff.AppendFormat("n = {0}", this.N).AppendLine();
            }


            if ((object)this.Content != null)
            {
                buff.AppendFormat("content = {0}", this.Content).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.I != null)
            {
                buff.AppendFormat(" i=\"{0}\"", this.I);
            }
            if ((object)this.N != null)
            {
                buff.AppendFormat(" n=\"{0}\"", this.N);
            }


            if ((object)this.Content != null)
            {
                buff.AppendFormat(" content = \"{0}\"", this.Content);
            }

            return buff.ToString();
        }

        public int? I;

        public IList<int?> N;


        public IList<int> Content;
    }
}
#endif

