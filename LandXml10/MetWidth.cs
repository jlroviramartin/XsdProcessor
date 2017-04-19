#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public enum MetWidth
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

