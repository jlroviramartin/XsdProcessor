using System.Collections.Generic;
using System.Text;

namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdParticleGroup : XsdParticle
    {
        public IList<XsdParticle> Items
        {
            get { return this.items; }
        }

        public ParticleGroupType GroupType { get; set; }

        private readonly List<XsdParticle> items = new List<XsdParticle>();

        public override string ToString()
        {
            StringBuilder buff = new StringBuilder();

            buff.Append(this.GroupType + " " + this.PrintOccurs());

            foreach (XsdParticle particle in this.Items)
            {
                buff.AppendLineSafe();
                buff.AppendIndent(particle);
            }

            return buff.ToString();
        }
    }
}