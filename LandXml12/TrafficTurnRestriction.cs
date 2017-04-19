#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum TrafficTurnRestriction
    {
        [StringValue("none")]
        None,
        [StringValue("no-left-turn")]
        NoLeftTurn,
        [StringValue("no-right-turn")]
        NoRightTurn,
        [StringValue("no-U-turn ")]
        NoUTurn,
        [StringValue("no-turn ")]
        NoTurn,

    }
}
#endif

