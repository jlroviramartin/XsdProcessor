#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Represents the elevation unit for elevation attribute values, such as ellipsoidElevation
    /// </summary>

    public enum ElevationType
    {
        [StringValue("meter")]
        Meter,
        [StringValue("kilometer")]
        Kilometer,
        [StringValue("feet")]
        Feet,
        [StringValue("miles")]
        Miles,

    }
}
#endif

