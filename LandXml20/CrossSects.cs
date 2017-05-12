#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Sequence [1, 1]
    ///     CrossSect [1, *]
    ///     Feature [0, *]
    /// </summary>

    public class CrossSects : XsdBaseReader
    {
        public CrossSects(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public string Desc;

        public string Name;

        public StateType? State;

        public XsVolCalcMethodType? CalcMethod;

        public bool? CurveCorrection;

        public double? SwellFactor;

        public double? ShrinkFactor;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("CrossSect"))
            {
                return Tuple.Create("CrossSect", this.NewReader<CrossSect>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

            this.CalcMethod = XsdConverter.Instance.Convert<XsVolCalcMethodType?>(
                    attributes.GetSafe("calcMethod"));

            this.CurveCorrection = XsdConverter.Instance.Convert<bool?>(
                    attributes.GetSafe("curveCorrection"));

            this.SwellFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("swellFactor"));

            this.ShrinkFactor = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("shrinkFactor"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }
            if ((object)this.CalcMethod != null)
            {
                buff.Append("calcMethod", this.CalcMethod);
            }
            if ((object)this.CurveCorrection != null)
            {
                buff.Append("curveCorrection", this.CurveCorrection);
            }
            if ((object)this.SwellFactor != null)
            {
                buff.Append("swellFactor", this.SwellFactor);
            }
            if ((object)this.ShrinkFactor != null)
            {
                buff.Append("shrinkFactor", this.ShrinkFactor);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat("name = {0}", this.Name).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }
            if ((object)this.CalcMethod != null)
            {
                buff.AppendFormat("calcMethod = {0}", this.CalcMethod).AppendLine();
            }
            if ((object)this.CurveCorrection != null)
            {
                buff.AppendFormat("curveCorrection = {0}", this.CurveCorrection).AppendLine();
            }
            if ((object)this.SwellFactor != null)
            {
                buff.AppendFormat("swellFactor = {0}", this.SwellFactor).AppendLine();
            }
            if ((object)this.ShrinkFactor != null)
            {
                buff.AppendFormat("shrinkFactor = {0}", this.ShrinkFactor).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

