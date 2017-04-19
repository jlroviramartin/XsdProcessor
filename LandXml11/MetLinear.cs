#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum MetLinear
    {
        [StringValue("millimeter")]
        Millimeter,
        [StringValue("centimeter")]
        Centimeter,
        [StringValue("meter")]
        Meter,
        [StringValue("kilometer")]
        Kilometer,

    }
}
#endif

