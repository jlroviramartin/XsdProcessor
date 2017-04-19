#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// This indicates the material makeup of the Monument
    /// </summary>

    public enum MonumentType
    {
        [StringValue("disk")]
        Disk,
        [StringValue("nail")]
        Nail,
        [StringValue("not monumented")]
        NotMonumented,
        [StringValue("other")]
        Other,
        [StringValue("peg")]
        Peg,
        [StringValue("pin")]
        Pin,
        [StringValue("plaque")]
        Plaque,
        [StringValue("plug")]
        Plug,
        [StringValue("post")]
        Post,
        [StringValue("spike")]
        Spike,
        [StringValue("tube")]
        Tube,
        [StringValue("unknown")]
        Unknown,

    }
}
#endif

