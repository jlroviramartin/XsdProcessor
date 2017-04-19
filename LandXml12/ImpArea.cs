#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public enum ImpArea
    {
        [StringValue("acre")]
        Acre,
        [StringValue("squareFoot")]
        SquareFoot,
        [StringValue("squareInch")]
        SquareInch,
        [StringValue("squareMiles")]
        SquareMiles,

    }
}
#endif

