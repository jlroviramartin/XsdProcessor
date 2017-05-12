#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// offsetInOut:   -ve = offset in towards inst, +ve = offset away from inst 
    /// offsetLeftRight:   -ve = left, +ve = right (as viewed from instrument) 
    /// offsetUpDown:   -ve = down, +ve = up
    /// </summary>

    public class OffsetVals : XsdBaseReader
    {
        public OffsetVals(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public double? OffsetInOut;

        public double? OffsetLeftRight;

        public double? OffsetUpDown;

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

            this.OffsetInOut = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("offsetInOut"));

            this.OffsetLeftRight = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("offsetLeftRight"));

            this.OffsetUpDown = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("offsetUpDown"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.OffsetInOut != null)
            {
                buff.Append("offsetInOut", this.OffsetInOut);
            }
            if ((object)this.OffsetLeftRight != null)
            {
                buff.Append("offsetLeftRight", this.OffsetLeftRight);
            }
            if ((object)this.OffsetUpDown != null)
            {
                buff.Append("offsetUpDown", this.OffsetUpDown);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.OffsetInOut != null)
            {
                buff.AppendFormat("offsetInOut = {0}", this.OffsetInOut).AppendLine();
            }
            if ((object)this.OffsetLeftRight != null)
            {
                buff.AppendFormat("offsetLeftRight = {0}", this.OffsetLeftRight).AppendLine();
            }
            if ((object)this.OffsetUpDown != null)
            {
                buff.AppendFormat("offsetUpDown = {0}", this.OffsetUpDown).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

