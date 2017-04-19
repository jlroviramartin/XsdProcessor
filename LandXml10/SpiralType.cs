#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public enum SpiralType
    {
        [StringValue("biquadratic")]
        Biquadratic,
        [StringValue("bloss")]
        Bloss,
        [StringValue("clothoid")]
        Clothoid,
        [StringValue("cosine")]
        Cosine,
        [StringValue("cubic")]
        Cubic,
        [StringValue("sinusoid")]
        Sinusoid,
        [StringValue("revBiquadratic")]
        RevBiquadratic,
        [StringValue("revBloss")]
        RevBloss,
        [StringValue("revCosine")]
        RevCosine,
        [StringValue("revSinusoid")]
        RevSinusoid,

    }
}
#endif

