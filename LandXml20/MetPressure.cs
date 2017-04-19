#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum MetPressure
    {
        [StringValue("HPA")]
        HPA,
        [StringValue("milliBars")]
        MilliBars,
        [StringValue("mmHG")]
        MmHG,
        [StringValue("millimeterHG")]
        MillimeterHG,

    }
}
#endif

