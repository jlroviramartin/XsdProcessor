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
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// This is an extension of the LandXML state type, but is specific to parcels
    /// </summary>

    public enum ParcelStateType
    {
        [StringValue("affected")]
        Affected,
        [StringValue("created")]
        Created,
        [StringValue("encroached")]
        Encroached,
        [StringValue("extinguished")]
        Extinguished,
        [StringValue("referenced")]
        Referenced,
        [StringValue("proposed")]
        Proposed,
        [StringValue("existing")]
        Existing,

    }
}
#endif
