#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum PavementSurfaceType
    {
        [StringValue("high-type")]
        HighType,
        [StringValue("intermediate-type")]
        IntermediateType,
        [StringValue("low-type")]
        LowType,

    }
}
#endif

