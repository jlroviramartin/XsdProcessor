#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum IntersectionConstructionType
    {
        [StringValue("existing")]
        Existing,
        [StringValue("improvement")]
        Improvement,
        [StringValue("new")]
        New,

    }
}
#endif

