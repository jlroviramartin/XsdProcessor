#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public enum DTMAttributeType
    {
        [StringValue("determinebyfeature")]
        Determinebyfeature,
        [StringValue("donotinclude")]
        Donotinclude,
        [StringValue("spot")]
        Spot,
        [StringValue("spotandbreak")]
        Spotandbreak,
        [StringValue("void")]
        Void,
        [StringValue("drapevoid")]
        Drapevoid,
        [StringValue("breakvoid")]
        Breakvoid,
        [StringValue("island")]
        Island,
        [StringValue("boundary")]
        Boundary,
        [StringValue("contour")]
        Contour,
        [StringValue("feature")]
        Feature,
        [StringValue("ground")]
        Ground,
        [StringValue("xsection")]
        Xsection,
        [StringValue("user")]
        User,

    }
}
#endif

