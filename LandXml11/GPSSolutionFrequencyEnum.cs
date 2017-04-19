#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// The GPS solution frequency indicates the GPS frequencies used in the computed solution for a GPS vector or position 
    /// </summary>

    public enum GPSSolutionFrequencyEnum
    {
        [StringValue("Unknown")]
        Unknown,
        [StringValue("L1")]
        L1,
        [StringValue("L2")]
        L2,
        [StringValue("L2 Squared")]
        L2Squared,
        [StringValue("Wide Lane")]
        WideLane,
        [StringValue("Narrow Lane")]
        NarrowLane,
        [StringValue("Iono Free")]
        IonoFree,

    }
}
#endif

