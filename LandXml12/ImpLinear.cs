#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum ImpLinear
    {
        [StringValue("foot")]
        Foot,
        [StringValue("USSurveyFoot")]
        USSurveyFoot,
        [StringValue("inch")]
        Inch,
        [StringValue("mile")]
        Mile,

    }
}
#endif

