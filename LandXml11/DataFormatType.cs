#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum DataFormatType
    {
        [StringValue("Offset Elevation")]
        OffsetElevation,
        [StringValue("Slope Distance")]
        SlopeDistance,

    }
}
#endif
