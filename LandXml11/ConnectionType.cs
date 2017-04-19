#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum ConnectionType
    {
        [StringValue("inner")]
        Inner,
        [StringValue("outer")]
        Outer,
        [StringValue("dayLight")]
        DayLight,

    }
}
#endif

