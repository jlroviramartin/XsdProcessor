#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum PipeNetworkType
    {
        [StringValue("sanitary")]
        Sanitary,
        [StringValue("storm")]
        Storm,
        [StringValue("water")]
        Water,
        [StringValue("other")]
        Other,

    }
}
#endif

