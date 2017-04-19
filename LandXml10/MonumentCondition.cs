#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// This gives a general indication of the condition of the monument
    /// </summary>

    public enum MonumentCondition
    {
        [StringValue("damaged")]
        Damaged,
        [StringValue("destroyed")]
        Destroyed,
        [StringValue("disturbed")]
        Disturbed,
        [StringValue("not accessible")]
        NotAccessible,
        [StringValue("not found")]
        NotFound,
        [StringValue("not specified")]
        NotSpecified,
        [StringValue("reliable")]
        Reliable,
        [StringValue("removed")]
        Removed,
        [StringValue("submerged")]
        Submerged,
        [StringValue("temporary")]
        Temporary,
        [StringValue("threatened")]
        Threatened,
        [StringValue("unstable")]
        Unstable,

    }
}
#endif

