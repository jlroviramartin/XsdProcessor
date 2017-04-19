#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public enum ShoulderMaterialType
    {
        [StringValue("turf")]
        Turf,
        [StringValue("gravel")]
        Gravel,
        [StringValue("paved")]
        Paved,
        [StringValue("composite")]
        Composite,

    }
}
#endif

