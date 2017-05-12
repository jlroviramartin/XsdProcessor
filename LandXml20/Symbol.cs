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
    /// Sequence [1, 1]
    ///     SymbolHexString [1, 1]
    ///     TextureImageNameRef [0, *]
    /// </summary>

    public class Symbol : XsdBaseReader
    {
        public Symbol(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Name;

        public SymbolType Type;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("TextureImageNameRef"))
            {
                return Tuple.Create("TextureImageNameRef", this.NewReader<string>());
            }
            if (name.EqualsIgnoreCase("SymbolHexString"))
            {
                return Tuple.Create("SymbolHexString", this.NewReader<byte[]>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Type = XsdConverter.Instance.Convert<SymbolType>(
                    attributes.GetSafe("type"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Type != null)
            {
                buff.Append("type", this.Type);
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
            if ((object)this.Type != null)
            {
                buff.AppendFormat("type = {0}", this.Type).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

