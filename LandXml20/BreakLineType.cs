#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum BreakLineType
    {
        [StringValue("standard")]
        Standard,
        [StringValue("wall")]
        Wall,
        [StringValue("proximity")]
        Proximity,
        [StringValue("nondestructive")]
        Nondestructive,

    }
}
#endif

