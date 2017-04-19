#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public enum PointGeometryType
    {
        [StringValue("point")]
        Point,
        [StringValue("curve")]
        Curve,

    }
}
#endif

