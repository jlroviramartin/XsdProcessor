#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// This element represents graphical and material characteristics for elements, such as Surface faces groups, individual surface face elements, CgPoints groups, CgPoint, CoordGeom, Pipe, Struct, Parcel and planFeature elements
    /// Attribute values:
    /// name = the textual name of the element.
    /// index = the positive integer table index value of the element. All indice values begin at 1 in the LandXML schema.
    /// layerName = the textual name of the layer (or organizational catergory) element.
    /// color = RGB color string in the form of Red, Green, Blue each an integer value from 0 to 255. Example
    ///                                  color="255,0,0" is the RGB color value of Red
    /// textureImageRef = references a named TextImage element that contains the texture binary image in a hex encoded string
    /// symbolRef = references a named Symbol element that contains a 2D or 3D DXF graphics symbol
    /// symbolXScale = the X scale value applied to the Symbol element
    /// symbolYScale = the Y scale value applied to the Symbol element
    /// symbolZScale = the Z scale value applied to the Symbol element
    /// symbolRotation = the rotation angle value applied to the Symbol element
    /// </summary>

    public class Material : XsdBaseReader
    {
        public Material(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public int Index;

        public string LayerName;

        public string Desc;

        public string Color;
        /// <summary>
        /// basic CAD style line types
        /// </summary>

        public LineTypes? LineType;

        public string TextureImageRef;

        public double? TextureImageScale;

        public double? SymbolXScale;

        public double? SymbolYScale;

        public double? SymbolZScale;
        /// <summary>
        /// Represents a normalized angular value in the specified Angular units. Assume 0 degrees = east
        /// </summary>

        public double? SymbolRotation;

        public string SymbolRef;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Index = XsdConverter.Instance.Convert<int>(
                    attributes.GetSafe("index"));

            this.LayerName = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("layerName"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Color = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("color"));

            this.LineType = XsdConverter.Instance.Convert<LineTypes?>(
                    attributes.GetSafe("lineType"));

            this.TextureImageRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("textureImageRef"));

            this.TextureImageScale = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("textureImageScale"));

            this.SymbolXScale = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("symbolXScale"));

            this.SymbolYScale = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("symbolYScale"));

            this.SymbolZScale = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("symbolZScale"));

            this.SymbolRotation = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("symbolRotation"));

            this.SymbolRef = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("symbolRef"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Index != null)
            {
                buff.Append("index", this.Index);
            }
            if ((object)this.LayerName != null)
            {
                buff.Append("layerName", this.LayerName);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Color != null)
            {
                buff.Append("color", this.Color);
            }
            if ((object)this.LineType != null)
            {
                buff.Append("lineType", this.LineType);
            }
            if ((object)this.TextureImageRef != null)
            {
                buff.Append("textureImageRef", this.TextureImageRef);
            }
            if ((object)this.TextureImageScale != null)
            {
                buff.Append("textureImageScale", this.TextureImageScale);
            }
            if ((object)this.SymbolXScale != null)
            {
                buff.Append("symbolXScale", this.SymbolXScale);
            }
            if ((object)this.SymbolYScale != null)
            {
                buff.Append("symbolYScale", this.SymbolYScale);
            }
            if ((object)this.SymbolZScale != null)
            {
                buff.Append("symbolZScale", this.SymbolZScale);
            }
            if ((object)this.SymbolRotation != null)
            {
                buff.Append("symbolRotation", this.SymbolRotation);
            }
            if ((object)this.SymbolRef != null)
            {
                buff.Append("symbolRef", this.SymbolRef);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.Index != null)
            {
                buff.AppendFormat("index = {0}", this.Index).AppendLine();
            }
            if ((object)this.LayerName != null)
            {
                buff.AppendFormat("layerName = {0}", this.LayerName).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Color != null)
            {
                buff.AppendFormat("color = {0}", this.Color).AppendLine();
            }
            if ((object)this.LineType != null)
            {
                buff.AppendFormat("lineType = {0}", this.LineType).AppendLine();
            }
            if ((object)this.TextureImageRef != null)
            {
                buff.AppendFormat("textureImageRef = {0}", this.TextureImageRef).AppendLine();
            }
            if ((object)this.TextureImageScale != null)
            {
                buff.AppendFormat("textureImageScale = {0}", this.TextureImageScale).AppendLine();
            }
            if ((object)this.SymbolXScale != null)
            {
                buff.AppendFormat("symbolXScale = {0}", this.SymbolXScale).AppendLine();
            }
            if ((object)this.SymbolYScale != null)
            {
                buff.AppendFormat("symbolYScale = {0}", this.SymbolYScale).AppendLine();
            }
            if ((object)this.SymbolZScale != null)
            {
                buff.AppendFormat("symbolZScale = {0}", this.SymbolZScale).AppendLine();
            }
            if ((object)this.SymbolRotation != null)
            {
                buff.AppendFormat("symbolRotation = {0}", this.SymbolRotation).AppendLine();
            }
            if ((object)this.SymbolRef != null)
            {
                buff.AppendFormat("symbolRef = {0}", this.SymbolRef).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

