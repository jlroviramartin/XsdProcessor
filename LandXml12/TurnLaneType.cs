#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum TurnLaneType
    {
        [StringValue("left")]
        Left,
        [StringValue("right")]
        Right,

    }
}
#endif

