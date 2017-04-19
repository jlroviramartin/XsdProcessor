#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public enum RoadSignType
    {
        [StringValue("regulatory")]
        Regulatory,
        [StringValue("guide")]
        Guide,
        [StringValue("warning")]
        Warning,
        [StringValue("specificService")]
        SpecificService,
        [StringValue("tourist")]
        Tourist,
        [StringValue("recreation-cultural")]
        RecreationCultural,
        [StringValue("emergencyManagement")]
        EmergencyManagement,

    }
}
#endif

