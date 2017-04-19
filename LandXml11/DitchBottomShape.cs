#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum DitchBottomShape
    {
        [StringValue("true-V")]
        TrueV,
        [StringValue("rounded-V")]
        RoundedV,
        [StringValue("rounded-trapezoidal")]
        RoundedTrapezoidal,
        [StringValue("flat-trapezoidal")]
        FlatTrapezoidal,

    }
}
#endif

