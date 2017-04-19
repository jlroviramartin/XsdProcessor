#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// The GPS solution type indicates the type of computed solution for a GPS vector or position
    /// </summary>

    public enum GPSSolutionTypeEnum
    {
        [StringValue("Unknown")]
        Unknown,
        [StringValue("Code")]
        Code,
        [StringValue("Float")]
        Float,
        [StringValue("Fixed")]
        Fixed,
        [StringValue("Network Float")]
        NetworkFloat,
        [StringValue("Network Fixed")]
        NetworkFixed,
        [StringValue("WAAS Float")]
        WAASFloat,
        [StringValue("WAAS Fixed")]
        WAASFixed,

    }
}
#endif

