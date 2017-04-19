#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// This indicates the category of a geodetic Monument
    /// </summary>

    public enum MonumentCategory
    {
        [StringValue("benchmark")]
        Benchmark,
        [StringValue("central")]
        Central,
        [StringValue("reference")]
        Reference,
        [StringValue("rural")]
        Rural,
        [StringValue("standard traverse")]
        StandardTraverse,
        [StringValue("urban standard traverse")]
        UrbanStandardTraverse,

    }
}
#endif

