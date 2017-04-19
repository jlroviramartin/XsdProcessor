#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum CrashSeverityType
    {
        [StringValue("fatal")]
        Fatal,
        [StringValue("nonfatal ")]
        Nonfatal,
        [StringValue("propery-damage-only")]
        ProperyDamageOnly,

    }
}
#endif

