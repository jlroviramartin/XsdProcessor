#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    public enum ImpFlow
    {
        [StringValue("US_gallonPerDay")]
        US_gallonPerDay,
        [StringValue("IMP_gallonPerDay")]
        IMP_gallonPerDay,
        [StringValue("cubicFeetDay")]
        CubicFeetDay,
        [StringValue("US_gallonPerMinute")]
        US_gallonPerMinute,
        [StringValue("IMP_gallonPerMinute")]
        IMP_gallonPerMinute,
        [StringValue("acreFeetDay")]
        AcreFeetDay,
        [StringValue("cubicFeetSecond")]
        CubicFeetSecond,

    }
}
#endif

