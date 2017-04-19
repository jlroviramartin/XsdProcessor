#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Used by many of the Survey elements
    /// </summary>

    public enum PurposeType
    {
        [StringValue("normal")]
        Normal,
        [StringValue("check")]
        Check,
        [StringValue("backsight")]
        Backsight,
        [StringValue("foresight")]
        Foresight,
        [StringValue("traverse")]
        Traverse,
        [StringValue("sideshot")]
        Sideshot,
        [StringValue("resection")]
        Resection,
        [StringValue("levelLoop")]
        LevelLoop,
        [StringValue("digitalLevel")]
        DigitalLevel,
        [StringValue("remoteElevation")]
        RemoteElevation,
        [StringValue("recipricalObservation")]
        RecipricalObservation,
        [StringValue("topo")]
        Topo,
        [StringValue("cutSheets")]
        CutSheets,
        [StringValue("asbuilt")]
        Asbuilt,

    }
}
#endif

