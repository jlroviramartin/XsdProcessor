#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum DesignLocationType
    {
        [StringValue("Final Surface")]
        FinalSurface,
        [StringValue("Datum")]
        Datum,
        [StringValue("Intermediate")]
        Intermediate,

    }
}
#endif
