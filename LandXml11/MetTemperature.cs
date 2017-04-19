#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum MetTemperature
    {
        [StringValue("celsius")]
        Celsius,
        [StringValue("kelvin")]
        Kelvin,

    }
}
#endif

