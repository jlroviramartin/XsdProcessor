#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum ZoneOffsetType
    {
        [StringValue("centerline")]
        Centerline,
        [StringValue("zone")]
        Zone,

    }
}
#endif
