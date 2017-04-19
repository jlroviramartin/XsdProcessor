#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public enum ZoneMaterialType
    {
        [StringValue("pavement-high-type")]
        PavementHighType,
        [StringValue("pavement-intermediate-type")]
        PavementIntermediateType,
        [StringValue("pavement-low-type")]
        PavementLowType,
        [StringValue("soil")]
        Soil,
        [StringValue("concrete")]
        Concrete,
        [StringValue("stone")]
        Stone,
        [StringValue("riprap")]
        Riprap,
        [StringValue("turf")]
        Turf,
        [StringValue("gravel")]
        Gravel,
        [StringValue("paved")]
        Paved,
        [StringValue("metal")]
        Metal,
        [StringValue("metal grate")]
        MetalGrate,
        [StringValue("composite")]
        Composite,
        [StringValue("timber")]
        Timber,
        [StringValue("other")]
        Other,

    }
}
#endif

