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
    /// Optional COGO Point attribute to designate the survey point type.
    /// </summary>

    public enum SurvPntType
    {
        [StringValue("monument")]
        Monument,
        [StringValue("control")]
        Control,
        [StringValue("sideshot")]
        Sideshot,
        [StringValue("boundary")]
        Boundary,
        [StringValue("natural boundary")]
        NaturalBoundary,
        [StringValue("traverse")]
        Traverse,
        [StringValue("reference")]
        Reference,
        [StringValue("administrative")]
        Administrative,

    }
}
#endif
