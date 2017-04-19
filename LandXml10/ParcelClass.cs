#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// The parcel class combines both parcel intent and topology class.
    /// </summary>

    public enum ParcelClass
    {
        [StringValue("accessory building")]
        AccessoryBuilding,
        [StringValue("accretion")]
        Accretion,
        [StringValue("allotment")]
        Allotment,
        [StringValue("building")]
        Building,
        [StringValue("covenant")]
        Covenant,
        [StringValue("cross parcel easement")]
        CrossParcelEasement,
        [StringValue("cross parcel easement centerline")]
        CrossParcelEasementCenterline,
        [StringValue("easement")]
        Easement,
        [StringValue("easement centerline")]
        EasementCenterline,
        [StringValue("erosion")]
        Erosion,
        [StringValue("hydrography")]
        Hydrography,
        [StringValue("lease")]
        Lease,
        [StringValue("legalisation")]
        Legalisation,
        [StringValue("other")]
        Other,
        [StringValue("railway")]
        Railway,
        [StringValue("reclamation")]
        Reclamation,
        [StringValue("reserve")]
        Reserve,
        [StringValue("road")]
        Road,
        [StringValue("strata")]
        Strata,

    }
}
#endif

