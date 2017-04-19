#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum MetVolume
    {
        [StringValue("cubicMeter")]
        CubicMeter,
        [StringValue("liter")]
        Liter,
        [StringValue("hectareMeter")]
        HectareMeter,

    }
}
#endif

