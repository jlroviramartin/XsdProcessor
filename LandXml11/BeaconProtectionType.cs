#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Indicates any structure that protects the
    ///   monument, these enumerations may need expanding
    /// </summary>

    public enum BeaconProtectionType
    {
        [StringValue("cover")]
        Cover,
        [StringValue("cover and box")]
        CoverAndBox,
        [StringValue("fence enclosure")]
        FenceEnclosure,
        [StringValue("marker post")]
        MarkerPost,
        [StringValue("no protection")]
        NoProtection,
        [StringValue("other")]
        Other,
        [StringValue("quadripod")]
        Quadripod,
        [StringValue("unknown")]
        Unknown,

    }
}
#endif

