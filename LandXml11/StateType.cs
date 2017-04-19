#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum StateType
    {
        [StringValue("abandoned")]
        Abandoned,
        [StringValue("destroyed")]
        Destroyed,
        [StringValue("existing")]
        Existing,
        [StringValue("proposed")]
        Proposed,

    }
}
#endif

