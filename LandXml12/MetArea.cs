#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum MetArea
    {
        [StringValue("hectare")]
        Hectare,
        [StringValue("squareMeter")]
        SquareMeter,
        [StringValue("squareMillimeter")]
        SquareMillimeter,
        [StringValue("squareCentimeter")]
        SquareCentimeter,

    }
}
#endif

