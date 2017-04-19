#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    /// <summary>
    /// Latitude/Longitude coordinate angular values. Latitude (range -90 to +90) positive values for the northern hemispher, negative indicate the southern. Longitude (range -180 to +180) positive values are to the east of the prime meridian, negative values are to the west. Values expressed in "decimal dd.mm.ss" units have the numeric format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
    /// </summary>

    public enum LatLongAngularType
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

