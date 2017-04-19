#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum AdverseSEType
    {
        [StringValue("non-adverse")]
        NonAdverse,
        [StringValue("adverse")]
        Adverse,

    }
}
#endif

