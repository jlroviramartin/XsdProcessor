#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    /// <summary>
    /// This is an extension of the LandXML state type, but is specific to parcels
    /// </summary>

    public enum ParcelStateType
    {
        [StringValue("affected")]
        Affected,
        [StringValue("created")]
        Created,
        [StringValue("encroached")]
        Encroached,
        [StringValue("extinguished")]
        Extinguished,
        [StringValue("referenced")]
        Referenced,
        [StringValue("proposed")]
        Proposed,
        [StringValue("existing")]
        Existing,
        [StringValue("adjoining")]
        Adjoining,

    }
}
#endif

