#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Indicates whether there is any physical structure
    ///    for the monument - helps location, these enumerations may need expanding
    /// </summary>

    public enum BeaconType
    {
        [StringValue("cairn")]
        Cairn,
        [StringValue("chimney")]
        Chimney,
        [StringValue("large quadripod")]
        LargeQuadripod,
        [StringValue("lighthouse")]
        Lighthouse,
        [StringValue("marine beacon")]
        MarineBeacon,
        [StringValue("mast")]
        Mast,
        [StringValue("mast with targets")]
        MastWithTargets,
        [StringValue("no beacon")]
        NoBeacon,
        [StringValue("other")]
        Other,
        [StringValue("pillar")]
        Pillar,
        [StringValue("post")]
        Post,
        [StringValue("small quadripod")]
        SmallQuadripod,
        [StringValue("tower")]
        Tower,
        [StringValue("tripod")]
        Tripod,
        [StringValue("unknown")]
        Unknown,

    }
}
#endif

