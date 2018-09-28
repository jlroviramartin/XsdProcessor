using System.Collections.Generic;
using System.Linq;

namespace XmlSchemaProcessor.Xsd
{
    public sealed class XsdSimpleUnionType : XsdSimpleType
    {
        public XsdSimpleUnionType()
        {
            this.MemberTypes = new List<XsdSimpleType>();
        }

        public IList<XsdSimpleType> MemberTypes { get; set; }

        #region object

        public override string ToString()
        {
            return this.Name + " Union of " + this.MemberTypes.Select(x => x.Name).Aggregate(string.Empty, (a, b) => ((a != string.Empty) ? (a + " , " + b) : b));
        }

        #endregion
    }
}