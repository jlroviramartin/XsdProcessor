#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum SideofRoadType
    {
        [StringValue("right")]
        Right,
        [StringValue("left")]
        Left,
        [StringValue("both")]
        Both,

    }
}
#endif

