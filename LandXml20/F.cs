#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// A surface face. It contains a space delimited list of "id" references for 3 (TIN) or 4 (grid) surface "P" points. 
    /// The 3 or 4 numbers represent the vertices on the face. Each number is a reference to the ID value of a surface point "P" for the face coordinates.
    /// Attribute "i" is optional, where a value of "1" indicating the face is part of the triangulation but is invisible.
    /// Attribute "n" is optional, space delimited face index values indicating the adjacent face index for each face edge, where a value of "0" (an invalid face index value) indicates the edge has NO neighboring face. The face index value is implied and defined from 1 to n number of F elements in a a single Faces collection. 
    /// Example:
    /// <!--
    /// <Faces>
    ///    <F>5 10 20</F>  Implied face index = 1
    ///    <F>5 10 20</F>  Implied face index = 2
    ///    <F>5 10 20</F>  Implied face index = 3
    ///    <F n="2 0 3" i="1">10 20 30</F>   Implied face index = 4
    ///   ...
    /// </Faces>
    /// -->
    /// Where 2 is the neighboring face index for the edge 10 to 20, 0 means no 
    /// neighbor between 20 and 30 and 3 is the neighbor index for 30 to 10. 
    /// Attribute “b” is used to indicate the edges of the face that coincide with breakline data.
    /// b=an integer bitmask sum of the sides of the face that had breaklines in the original data.
    /// This gives a valid integer range of 0 to 7 for each TIN face: 
    /// 1 = side 1
    /// 2 = side 2
    /// 4 = side 3
    /// For example b="5" has breakline data on TIN face sides 1 and 3.
    /// Attribute "m" is the index value from the SurfaceMaterial table that indicates the material, color and texture for the face.
    /// m is the index attribute value for a SurfaceMaterial element in the SurfacematerialTable element.
    /// example:
    /// <!--
    /// <Faces>
    ///    <F m="1">5 10 20</F>  material index = 1
    ///    <F m="2">5 10 20</F>  material index = 2
    ///    <F m="1">5 10 20</F>  material index = 1
    /// -->
    /// </summary>

    public class F : XsdBaseReader
    {
        public F(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public int? I;

        public IList<int?> N;

        public uint? B;
        /// <summary>
        /// A integer based index value to a table item in the material table.
        /// </summary>

        public IList<int?> M;

        public IList<int> Content;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }

        protected override bool NeedContent { get { return true; } }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.I = XsdConverter.Instance.Convert<int?>(
                    attributes.GetSafe("i"));

            this.N = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("n"));

            this.B = XsdConverter.Instance.Convert<uint?>(
                    attributes.GetSafe("b"));

            this.M = XsdConverter.Instance.Convert<IList<int?>>(
                    attributes.GetSafe("m"));

            this.Content = XsdConverter.Instance.Convert<IList<int>>(text);
            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.I != null)
            {
                buff.Append("i", this.I);
            }
            if ((object)this.N != null)
            {
                buff.Append("n", this.N);
            }
            if ((object)this.B != null)
            {
                buff.Append("b", this.B);
            }
            if ((object)this.M != null)
            {
                buff.Append("m", this.M);
            }

            if ((object)this.Content != null)
            {
                buff.Append("content", this.Content);
            }
            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.I != null)
            {
                buff.AppendFormat("i = {0}", this.I).AppendLine();
            }
            if ((object)this.N != null)
            {
                buff.AppendFormat("n = {0}", this.N).AppendLine();
            }
            if ((object)this.B != null)
            {
                buff.AppendFormat("b = {0}", this.B).AppendLine();
            }
            if ((object)this.M != null)
            {
                buff.AppendFormat("m = {0}", this.M).AppendLine();
            }

            if ((object)this.Content != null)
            {
                buff.AppendFormat("content = {0}", this.Content).AppendLine();
            }
            return buff.ToString();
        }

        #endregion
    }
}
#endif

