#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public enum ImpPressure
    {
        [StringValue("inchHG")]
        InchHG,
        [StringValue("inHG")]
        InHG,

    }
}
#endif

