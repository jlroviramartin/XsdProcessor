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

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// Indicates any structure that protects the
    ///   monument, these enumerations may need expanding
    /// </summary>

    public enum BeaconProtectionType
    {
        [StringValue("cover")]
        Cover,
        [StringValue("cover and box")]
        CoverAndBox,
        [StringValue("fence enclosure")]
        FenceEnclosure,
        [StringValue("marker post")]
        MarkerPost,
        [StringValue("no protection")]
        NoProtection,
        [StringValue("other")]
        Other,
        [StringValue("quadripod")]
        Quadripod,
        [StringValue("unknown")]
        Unknown,

    }
}
#endif
