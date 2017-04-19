#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml11
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
        [StringValue("sineHalfWave")]
        SineHalfWave,
        [StringValue("biquadraticParabola")]
        BiquadraticParabola,
        [StringValue("cubicParabola")]
        CubicParabola,
        [StringValue("japaneseCubic")]
        JapaneseCubic,
        [StringValue("radioid")]
        Radioid,
        [StringValue("weinerBogen")]
        WeinerBogen,

    }
}
#endif

