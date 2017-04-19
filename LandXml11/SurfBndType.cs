#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Surface boundaries can be one of three types: outer, void, island
    /// </summary>

    public enum SurfBndType
    {
        [StringValue("outer")]
        Outer,
        [StringValue("void")]
        Void,
        [StringValue("island")]
        Island,

    }
}
#endif

