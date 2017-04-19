#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public class CrossSects : XsdBaseObject
    {
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

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());

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

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());

            if ((object)this.Desc != null)
            {
                buff.AppendFormat(" desc=\"{0}\"", this.Desc);
            }
            if ((object)this.Name != null)
            {
                buff.AppendFormat(" name=\"{0}\"", this.Name);
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat(" state=\"{0}\"", this.State);
            }
            if ((object)this.CalcMethod != null)
            {
                buff.AppendFormat(" calcMethod=\"{0}\"", this.CalcMethod);
            }
            if ((object)this.CurveCorrection != null)
            {
                buff.AppendFormat(" curveCorrection=\"{0}\"", this.CurveCorrection);
            }
            if ((object)this.SwellFactor != null)
            {
                buff.AppendFormat(" swellFactor=\"{0}\"", this.SwellFactor);
            }
            if ((object)this.ShrinkFactor != null)
            {
                buff.AppendFormat(" shrinkFactor=\"{0}\"", this.ShrinkFactor);
            }


            return buff.ToString();
        }

        public string Desc;

        public string Name;

        public StateType? State;

        public XsVolCalcMethodType? CalcMethod;

        public bool? CurveCorrection;

        public double? SwellFactor;

        public double? ShrinkFactor;


    }
}
#endif

