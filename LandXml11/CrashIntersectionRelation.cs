#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum CrashIntersectionRelation
    {
        [StringValue("unknown")]
        Unknown,
        [StringValue("non-intersection-related")]
        NonIntersectionRelated,
        [StringValue("intersection-related")]
        IntersectionRelated,

    }
}
#endif

