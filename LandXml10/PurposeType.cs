//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime: <..>
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using XmlSchemaProcessor.Common;

namespace XmlSchemaProcessor.LandXml10
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
