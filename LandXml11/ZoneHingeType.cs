#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum ZoneHingeType
    {
        [StringValue("center")]
        Center,
        [StringValue("left edge")]
        LeftEdge,
        [StringValue("right edge")]
        RightEdge,

    }
}
#endif

