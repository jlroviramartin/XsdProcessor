#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
{

    public enum SurveyRoleType
    {
        [StringValue("measured")]
        Measured,
        [StringValue("to stake out")]
        ToStakeOut,
        [StringValue("staked out")]
        StakedOut,
        [StringValue("calculated")]
        Calculated,
        [StringValue("assistance point")]
        AssistancePoint,
        [StringValue("user entered point")]
        UserEnteredPoint,
        [StringValue("control point")]
        ControlPoint,

    }
}
#endif

