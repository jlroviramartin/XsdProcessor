#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum InOut
    {
        [StringValue("in")]
        In,
        [StringValue("out")]
        Out,
        [StringValue("both")]
        Both,

    }
}
#endif

