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
    /// angular values expressed in "decimal dd.mm.ss" units have the numeric
    ///    format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
    /// </summary>

    public enum AngularType
    {
        [StringValue("radians")]
        Radians,
        [StringValue("grads")]
        Grads,
        [StringValue("decimal degrees")]
        DecimalDegrees,
        [StringValue("decimal dd.mm.ss")]
        DecimalDdMmSs,

    }
}
#endif
