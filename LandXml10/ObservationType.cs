#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// This enumeration indicates whether the reduced observation information provided was actually measured (observed), calculated or deduced from observations, or adopted from another survey
    /// </summary>

    public enum ObservationType
    {
        [StringValue("measured")]
        Measured,
        [StringValue("calculated")]
        Calculated,
        [StringValue("scaled")]
        Scaled,
        [StringValue("adopted")]
        Adopted,

    }
}
#endif

