#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum ZoneSurfaceType
    {
        [StringValue("finalSurface")]
        FinalSurface,
        [StringValue("subgrade")]
        Subgrade,

    }
}
#endif
