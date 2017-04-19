#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum TrafficControlType
    {
        [StringValue("none")]
        None,
        [StringValue("signal")]
        Signal,
        [StringValue("stop")]
        Stop,
        [StringValue("yield")]
        Yield,

    }
}
#endif
