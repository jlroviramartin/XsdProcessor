#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// This enumeration indicates whether the survey was acutally performed in the field, compiled from a series of existing surveys, or simply computed using known observations and maths
    /// </summary>

    public enum SurveyType
    {
        [StringValue("compiled")]
        Compiled,
        [StringValue("computed")]
        Computed,
        [StringValue("surveyed")]
        Surveyed,

    }
}
#endif

