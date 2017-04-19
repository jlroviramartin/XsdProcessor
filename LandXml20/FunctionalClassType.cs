#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum FunctionalClassType
    {
        [StringValue("arterial")]
        Arterial,
        [StringValue("collector ")]
        Collector,
        [StringValue("local")]
        Local,

    }
}
#endif

