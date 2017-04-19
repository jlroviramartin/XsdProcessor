#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Indicates how the mark is sourced for the survey and whether it replaces any other marks
    /// </summary>

    public enum MonumentState
    {
        [StringValue("adopted")]
        Adopted,
        [StringValue("disturbed")]
        Disturbed,
        [StringValue("replaced")]
        Replaced,
        [StringValue("original")]
        Original,
        [StringValue("new")]
        New,

    }
}
#endif

