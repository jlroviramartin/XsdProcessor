#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// basic CAD style line types
    /// </summary>

    public enum LineTypes
    {
        [StringValue("Dashed")]
        Dashed,
        [StringValue("Dot")]
        Dot,
        [StringValue("Center")]
        Center,
        [StringValue("Divide")]
        Divide,
        [StringValue("Hidden")]
        Hidden,
        [StringValue("Phantom")]
        Phantom,

    }
}
#endif

