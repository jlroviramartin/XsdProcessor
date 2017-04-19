#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum ImpVolume
    {
        [StringValue("US_gallon")]
        US_gallon,
        [StringValue("IMP_gallon")]
        IMP_gallon,
        [StringValue("cubicInch")]
        CubicInch,
        [StringValue("cubicFeet")]
        CubicFeet,
        [StringValue("cubicYard")]
        CubicYard,
        [StringValue("acreFeet")]
        AcreFeet,

    }
}
#endif

