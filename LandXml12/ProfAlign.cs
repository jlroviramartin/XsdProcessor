#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    // needContent    : false
    // includeContent : false
    /// <summary>
    /// The "ProfAlign" element will typically represent a proposed vertical alignment for a profile.
    /// It is defined by a sequential series of any combination of the four "PVI" element types.
    /// Sequence [1, 1]
    ///     Choice [1, *]
    ///         PVI [0, *]
    ///         ParaCurve [0, *]
    ///         UnsymParaCurve [0, *]
    ///         CircCurve [0, *]
    ///     Feature [0, *]
    /// </summary>

    public class ProfAlign : XsdBaseReader
    {
        public ProfAlign(System.Xml.XmlReader reader) : base(reader)
        {
        }

        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);

            this.Name = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("name"));

            this.Desc = XsdConverter.Instance.Convert<string>(
                    attributes.GetSafe("desc"));

            this.State = XsdConverter.Instance.Convert<StateType?>(
                    attributes.GetSafe("state"));

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
            if ((object)this.Desc != null)
            {
                buff.AppendFormat("desc = {0}", this.Desc).AppendLine();
            }
            if ((object)this.State != null)
            {
                buff.AppendFormat("state = {0}", this.State).AppendLine();
            }

            return buff.ToString();
        }

        public override string ToAttributes()
        {
            XmlSchemaProcessor.Processors.AttributesBuilder buff = new XmlSchemaProcessor.Processors.AttributesBuilder(base.ToAttributes());

            if ((object)this.Name != null)
            {
                buff.Append("name", this.Name);
            }
            if ((object)this.Desc != null)
            {
                buff.Append("desc", this.Desc);
            }
            if ((object)this.State != null)
            {
                buff.Append("state", this.State);
            }

            return buff.ToString();
        }

        public string Name;

        public string Desc;

        public StateType? State;


        protected override Tuple<string, object> NewReader(string namespaceURI, string name)
        {
            if (name.EqualsIgnoreCase("Feature"))
            {
                return Tuple.Create("Feature", this.NewReader<Feature>());
            }
            if (name.EqualsIgnoreCase("CircCurve"))
            {
                return Tuple.Create("CircCurve", this.NewReader<CircCurve>());
            }
            if (name.EqualsIgnoreCase("UnsymParaCurve"))
            {
                return Tuple.Create("UnsymParaCurve", this.NewReader<UnsymParaCurve>());
            }
            if (name.EqualsIgnoreCase("ParaCurve"))
            {
                return Tuple.Create("ParaCurve", this.NewReader<ParaCurve>());
            }
            if (name.EqualsIgnoreCase("PVI"))
            {
                return Tuple.Create("PVI", this.NewReader<PVI>());
            }

            return null;
        }
    }
}
#endif

