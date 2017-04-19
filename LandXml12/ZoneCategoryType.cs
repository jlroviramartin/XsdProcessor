#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum ZoneCategoryType
    {
        [StringValue("road surface")]
        RoadSurface,
        [StringValue("road subsurface")]
        RoadSubsurface,
        [StringValue("road shoulder")]
        RoadShoulder,
        [StringValue("road foreSlope")]
        RoadForeSlope,
        [StringValue("road backSlope")]
        RoadBackSlope,
        [StringValue("road curb-gutter")]
        RoadCurbGutter,
        [StringValue("bridge surface")]
        BridgeSurface,
        [StringValue("bridge body")]
        BridgeBody,
        [StringValue("sidewalk")]
        Sidewalk,
        [StringValue("ground")]
        Ground,
        [StringValue("ditch")]
        Ditch,
        [StringValue("wall")]
        Wall,
        [StringValue("channel")]
        Channel,
        [StringValue("bike facilities")]
        BikeFacilities,
        [StringValue("obstruction offset")]
        ObstructionOffset,
        [StringValue("longitudinal barrier")]
        LongitudinalBarrier,
        [StringValue("sound barrier")]
        SoundBarrier,
        [StringValue("bridge abutment")]
        BridgeAbutment,
        [StringValue("vertical pillar")]
        VerticalPillar,

    }
}
#endif

