#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// This is a rough indication of the type of equipment
    /// </summary>

    public enum EquipmentType
    {
        [StringValue("theodolite EDM")]
        TheodoliteEDM,
        [StringValue("theodolite tape")]
        TheodoliteTape,
        [StringValue("GPS")]
        GPS,
        [StringValue("scale")]
        Scale,
        [StringValue("other")]
        Other,
        [StringValue("unknown")]
        Unknown,

    }
}
#endif

