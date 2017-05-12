#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Sequence [1, 1]
    ///     Feature [0, *]
    /// </summary>

    public class PipeFlow : XsdBaseReader
    {
        public PipeFlow(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public double FlowIn;

        public double? AreaCatchment;

        public string Desc;

        public double? DepthCritical;

        public double? HglDown;

        public double? HglUp;

        public double? Intensity;

        public double? RunoffCoeff;

        public double? SlopeCritical;

        public double? TimeInlet;

        public double? VelocityCritical;

        #region XsdBaseReader

        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }

            return null;
        }

        #endregion

        #region XsdBaseObject

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.FlowIn = XsdConverter.Instance.Convert<double>(
                    attributes.GetSafe("flowIn"));

            this.AreaCatchment = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("areaCatchment"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.DepthCritical = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("depthCritical"));

            this.HglDown = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("hglDown"));

            this.HglUp = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("hglUp"));

            this.Intensity = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("intensity"));

            this.RunoffCoeff = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("runoffCoeff"));

            this.SlopeCritical = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("slopeCritical"));

            this.TimeInlet = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("timeInlet"));

            this.VelocityCritical = XsdConverter.Instance.Convert<double?>(
                    attributes.GetSafe("velocityCritical"));

            return true;
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.FlowIn != null)
            {
                buff.Append("flowIn", this.FlowIn);
            }
            if ((object)this.AreaCatchment != null)
            {
                buff.Append("areaCatchment", this.AreaCatchment);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.DepthCritical != null)
            {
                buff.Append("depthCritical", this.DepthCritical);
            }
            if ((object)this.HglDown != null)
            {
                buff.Append("hglDown", this.HglDown);
            }
            if ((object)this.HglUp != null)
            {
                buff.Append("hglUp", this.HglUp);
            }
            if ((object)this.Intensity != null)
            {
                buff.Append("intensity", this.Intensity);
            }
            if ((object)this.RunoffCoeff != null)
            {
                buff.Append("runoffCoeff", this.RunoffCoeff);
            }
            if ((object)this.SlopeCritical != null)
            {
                buff.Append("slopeCritical", this.SlopeCritical);
            }
            if ((object)this.TimeInlet != null)
            {
                buff.Append("timeInlet", this.TimeInlet);
            }
            if ((object)this.VelocityCritical != null)
            {
                buff.Append("velocityCritical", this.VelocityCritical);
            }

            return buff.ToString();
        }

        #endregion

        #region object

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder(base.ToString());

            if ((object)this.FlowIn != null)
            {
                buff.AppendFormat("flowIn = {0}", this.FlowIn).AppendLine();
            }
            if ((object)this.AreaCatchment != null)
            {
                buff.AppendFormat("areaCatchment = {0}", this.AreaCatchment).AppendLine();
            }
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.DepthCritical != null)
            {
                buff.AppendFormat("depthCritical = {0}", this.DepthCritical).AppendLine();
            }
            if ((object)this.HglDown != null)
            {
                buff.AppendFormat("hglDown = {0}", this.HglDown).AppendLine();
            }
            if ((object)this.HglUp != null)
            {
                buff.AppendFormat("hglUp = {0}", this.HglUp).AppendLine();
            }
            if ((object)this.Intensity != null)
            {
                buff.AppendFormat("intensity = {0}", this.Intensity).AppendLine();
            }
            if ((object)this.RunoffCoeff != null)
            {
                buff.AppendFormat("runoffCoeff = {0}", this.RunoffCoeff).AppendLine();
            }
            if ((object)this.SlopeCritical != null)
            {
                buff.AppendFormat("slopeCritical = {0}", this.SlopeCritical).AppendLine();
            }
            if ((object)this.TimeInlet != null)
            {
                buff.AppendFormat("timeInlet = {0}", this.TimeInlet).AppendLine();
            }
            if ((object)this.VelocityCritical != null)
            {
                buff.AppendFormat("velocityCritical = {0}", this.VelocityCritical).AppendLine();
            }

            return buff.ToString();
        }

        #endregion
    }
}
#endif

