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

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// The GPS solution type indicates the type of computed solution for a GPS vector or position
    /// </summary>

    public enum GPSSolutionTypeEnum
    {
        [StringValue("Unknown")]
        Unknown,
        [StringValue("Code")]
        Code,
        [StringValue("Float")]
        Float,
        [StringValue("Fixed")]
        Fixed,
        [StringValue("Network Float")]
        NetworkFloat,
        [StringValue("Network Fixed")]
        NetworkFixed,
        [StringValue("WAAS Float")]
        WAASFloat,
        [StringValue("WAAS Fixed")]
        WAASFixed,

    }
}
#endif
