#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum LaneTaperType
    {
        [StringValue("straight-line")]
        StraightLine,
        [StringValue("partial-tangent")]
        PartialTangent,
        [StringValue("symmetrical-reverse-curve")]
        SymmetricalReverseCurve,
        [StringValue("asymmetrical-reverse-curve")]
        AsymmetricalReverseCurve,

    }
}
#endif

