#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// Optional COGO Point attribute to designate the survey point type.
    /// </summary>

    public enum SurvPntType
    {
        [StringValue("monument")]
        Monument,
        [StringValue("control")]
        Control,
        [StringValue("sideshot")]
        Sideshot,
        [StringValue("boundary")]
        Boundary,
        [StringValue("natural boundary")]
        NaturalBoundary,
        [StringValue("traverse")]
        Traverse,
        [StringValue("reference")]
        Reference,
        [StringValue("administrative")]
        Administrative,

    }
}
#endif

