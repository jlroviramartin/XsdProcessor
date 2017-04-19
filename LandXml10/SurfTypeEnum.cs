#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// TIN is the acronym for "triangulated irregular network", a surface comprised of 3 point faces
    /// grid is a surface comprised of 4 point faces.
    /// </summary>

    public enum SurfTypeEnum
    {
        [StringValue("TIN")]
        TIN,
        [StringValue("grid")]
        Grid,

    }
}
#endif

