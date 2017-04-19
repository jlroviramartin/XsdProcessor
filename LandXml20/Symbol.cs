#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// This element value contains a OBJ or DXF ascii or hex encoded string that represents a 2D or 3D CAD symbol
    /// type = format type of symbol, values are dxf or obj
    /// SymbolHexString = hex encoded symbol definiton of either zip compressed DXF or zip compressed OBJ file
    /// TextureImageNameRef = texture image reference(s) used by material definition
    /// </summary>

    public class Symbol : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));



            this.Type = XsdConverter.Instance.Convert<SymbolType>(
                    attributes.GetSafe("type"));



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
            if ((object)this.Type != null)
            {
                buff.AppendFormat("type = {0}", this.Type).AppendLine();
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
            if ((object)this.Type != null)
            {
                buff.AppendFormat(" type=\"{0}\"", this.Type);
            }


            return buff.ToString();
        }

        public string Name;

        public SymbolType Type;


    }
}
#endif

