#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum ManeuverType
    {
        [StringValue("A-stop-on-rural-road")]
        AStopOnRuralRoad,
        [StringValue("C-speed-path-direction-change-on-rural-road")]
        CSpeedPathDirectionChangeOnRuralRoad,

    }
}
#endif

