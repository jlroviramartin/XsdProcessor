#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;
namespace XmlSchemaProcessor.LandXml10
{
	// Simple types
	// ------------
	public enum SurveyRoleType
	{
		[StringValue("measured")]
		Measured,
		[StringValue("to stake out")]
		ToStakeOut,
		[StringValue("staked out")]
		StakedOut,
		[StringValue("calculated")]
		Calculated,
		[StringValue("assistance point")]
		AssistancePoint,
		[StringValue("user entered point")]
		UserEnteredPoint,
		[StringValue("control point")]
		ControlPoint,
	}
	/// <summary>
	/// Indicates any structure that protects the
	/// 		monument, these enumerations may need expanding
	/// 
	/// 
	/// </summary>
	public enum BeaconProtectionType
	{
		[StringValue("cover")]
		Cover,
		[StringValue("cover and box")]
		CoverAndBox,
		[StringValue("fence enclosure")]
		FenceEnclosure,
		[StringValue("marker post")]
		MarkerPost,
		[StringValue("no protection")]
		NoProtection,
		[StringValue("other")]
		Other,
		[StringValue("quadripod")]
		Quadripod,
		[StringValue("unknown")]
		Unknown,
	}
	/// <summary>
	/// Indicates whether there is any physical structure
	/// 			for the monument - helps location, these enumerations may need expanding
	/// 			
	/// 
	/// 
	/// </summary>
	public enum BeaconType
	{
		[StringValue("cairn")]
		Cairn,
		[StringValue("chimney")]
		Chimney,
		[StringValue("large quadripod")]
		LargeQuadripod,
		[StringValue("lighthouse")]
		Lighthouse,
		[StringValue("marine beacon")]
		MarineBeacon,
		[StringValue("mast")]
		Mast,
		[StringValue("mast with targets")]
		MastWithTargets,
		[StringValue("no beacon")]
		NoBeacon,
		[StringValue("other")]
		Other,
		[StringValue("pillar")]
		Pillar,
		[StringValue("post")]
		Post,
		[StringValue("small quadripod")]
		SmallQuadripod,
		[StringValue("tower")]
		Tower,
		[StringValue("tripod")]
		Tripod,
		[StringValue("unknown")]
		Unknown,
	}
	public enum Clockwise
	{
		[StringValue("cw")]
		Cw,
		[StringValue("ccw")]
		Ccw,
	}
	public enum CurveType
	{
		[StringValue("arc")]
		Arc,
		[StringValue("chord")]
		Chord,
	}
	public enum DTMAttributeType
	{
		[StringValue("determinebyfeature")]
		Determinebyfeature,
		[StringValue("donotinclude")]
		Donotinclude,
		[StringValue("spot")]
		Spot,
		[StringValue("spotandbreak")]
		Spotandbreak,
		[StringValue("void")]
		Void,
		[StringValue("drapevoid")]
		Drapevoid,
		[StringValue("breakvoid")]
		Breakvoid,
		[StringValue("island")]
		Island,
		[StringValue("boundary")]
		Boundary,
		[StringValue("contour")]
		Contour,
		[StringValue("feature")]
		Feature,
		[StringValue("ground")]
		Ground,
		[StringValue("xsection")]
		Xsection,
		[StringValue("user")]
		User,
	}
	/// <summary>
	/// This is a rough indication of the type of equipment
	/// 
	/// 
	/// </summary>
	public enum EquipmentType
	{
		[StringValue("theodolite EDM")]
		TheodoliteEDM,
		[StringValue("theodolite tape")]
		TheodoliteTape,
		[StringValue("GPS")]
		GPS,
		[StringValue("scale")]
		Scale,
		[StringValue("other")]
		Other,
		[StringValue("unknown")]
		Unknown,
	}
	/// <summary>
	/// The GPS solution type indicates the type of computed solution for a GPS vector or position
	/// 
	/// 
	/// </summary>
	public enum GPSSolutionTypeEnum
	{
		[StringValue("Unknown")]
		Unknown,
		[StringValue("Code")]
		Code,
		[StringValue("Float")]
		Float,
		[StringValue("Fixed")]
		Fixed,
		[StringValue("Network Float")]
		NetworkFloat,
		[StringValue("Network Fixed")]
		NetworkFixed,
		[StringValue("WAAS Float")]
		WAASFloat,
		[StringValue("WAAS Fixed")]
		WAASFixed,
	}
	/// <summary>
	/// The GPS solution frequency indicates the GPS frequencies used in the computed solution for a GPS vector or position 
	/// 
	/// 
	/// </summary>
	public enum GPSSolutionFrequencyEnum
	{
		[StringValue("Unknown")]
		Unknown,
		[StringValue("L1")]
		L1,
		[StringValue("L2")]
		L2,
		[StringValue("L2 Squared")]
		L2Squared,
		[StringValue("Wide Lane")]
		WideLane,
		[StringValue("Narrow Lane")]
		NarrowLane,
		[StringValue("Iono Free")]
		IonoFree,
	}
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
	public enum ImpLinear
	{
		[StringValue("foot")]
		Foot,
		[StringValue("USSurveyFoot")]
		USSurveyFoot,
		[StringValue("inch")]
		Inch,
		[StringValue("mile")]
		Mile,
	}
	public enum ImpPressure
	{
		[StringValue("inchHG")]
		InchHG,
		[StringValue("inHG")]
		InHG,
	}
	public enum ImpTemperature
	{
		[StringValue("fahrenheit")]
		Fahrenheit,
		[StringValue("kelvin")]
		Kelvin,
	}
	public enum ImpDiameter
	{
		[StringValue("foot")]
		Foot,
		[StringValue("USSurveyFoot")]
		USSurveyFoot,
		[StringValue("inch")]
		Inch,
	}
	public enum ImpWidth
	{
		[StringValue("foot")]
		Foot,
		[StringValue("USSurveyFoot")]
		USSurveyFoot,
		[StringValue("inch")]
		Inch,
	}
	public enum ImpHeight
	{
		[StringValue("foot")]
		Foot,
		[StringValue("USSurveyFoot")]
		USSurveyFoot,
		[StringValue("inch")]
		Inch,
	}
	public enum ImpFlow
	{
		[StringValue("US_gallonPerDay")]
		US_gallonPerDay,
		[StringValue("IMP_gallonPerDay")]
		IMP_gallonPerDay,
		[StringValue("cubicFeetDay")]
		CubicFeetDay,
		[StringValue("US_gallonPerMinute")]
		US_gallonPerMinute,
		[StringValue("IMP_gallonPerMinute")]
		IMP_gallonPerMinute,
		[StringValue("acreFeetDay")]
		AcreFeetDay,
		[StringValue("cubicFeetSecond")]
		CubicFeetSecond,
	}
	public enum ImpVolume
	{
		[StringValue("US_gallon")]
		US_gallon,
		[StringValue("IMP_gallon")]
		IMP_gallon,
		[StringValue("cubicInch")]
		CubicInch,
		[StringValue("cubicFeet")]
		CubicFeet,
		[StringValue("cubicYard")]
		CubicYard,
		[StringValue("acreFeet")]
		AcreFeet,
	}
	public enum ImpVelocity
	{
		[StringValue("feetPerSecond")]
		FeetPerSecond,
		[StringValue("milesPerHour")]
		MilesPerHour,
	}
	public enum InOut
	{
		[StringValue("in")]
		In,
		[StringValue("out")]
		Out,
	}
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
	public enum MetLinear
	{
		[StringValue("millimeter")]
		Millimeter,
		[StringValue("centimeter")]
		Centimeter,
		[StringValue("meter")]
		Meter,
		[StringValue("kilometer")]
		Kilometer,
	}
	public enum MetDiameter
	{
		[StringValue("millimeter")]
		Millimeter,
		[StringValue("centimeter")]
		Centimeter,
		[StringValue("meter")]
		Meter,
		[StringValue("kilometer")]
		Kilometer,
	}
	public enum MetWidth
	{
		[StringValue("millimeter")]
		Millimeter,
		[StringValue("centimeter")]
		Centimeter,
		[StringValue("meter")]
		Meter,
		[StringValue("kilometer")]
		Kilometer,
	}
	public enum MetHeight
	{
		[StringValue("millimeter")]
		Millimeter,
		[StringValue("centimeter")]
		Centimeter,
		[StringValue("meter")]
		Meter,
		[StringValue("kilometer")]
		Kilometer,
	}
	public enum MetPressure
	{
		[StringValue("HPA")]
		HPA,
		[StringValue("milliBars")]
		MilliBars,
		[StringValue("mmHG")]
		MmHG,
		[StringValue("millimeterHG")]
		MillimeterHG,
	}
	public enum MetTemperature
	{
		[StringValue("celsius")]
		Celsius,
		[StringValue("kelvin")]
		Kelvin,
	}
	public enum MetVolume
	{
		[StringValue("cubicMeter")]
		CubicMeter,
		[StringValue("liter")]
		Liter,
		[StringValue("hectareMeter")]
		HectareMeter,
	}
	public enum MetVelocity
	{
		[StringValue("metersPerSecond")]
		MetersPerSecond,
		[StringValue("kilometersPerHour")]
		KilometersPerHour,
	}
	public enum MetFlow
	{
		[StringValue("cubicMeterSecond")]
		CubicMeterSecond,
		[StringValue("literPerSecond")]
		LiterPerSecond,
		[StringValue("literPerMinute")]
		LiterPerMinute,
	}
	/// <summary>
	/// This indicates the category of a geodetic Monument
	/// 
	/// 
	/// </summary>
	public enum MonumentCategory
	{
		[StringValue("benchmark")]
		Benchmark,
		[StringValue("central")]
		Central,
		[StringValue("reference")]
		Reference,
		[StringValue("rural")]
		Rural,
		[StringValue("standard traverse")]
		StandardTraverse,
		[StringValue("urban standard traverse")]
		UrbanStandardTraverse,
	}
	/// <summary>
	/// This gives a general indication of the condition of the monument
	/// 
	/// 
	/// </summary>
	public enum MonumentCondition
	{
		[StringValue("damaged")]
		Damaged,
		[StringValue("destroyed")]
		Destroyed,
		[StringValue("disturbed")]
		Disturbed,
		[StringValue("not accessible")]
		NotAccessible,
		[StringValue("not found")]
		NotFound,
		[StringValue("not specified")]
		NotSpecified,
		[StringValue("reliable")]
		Reliable,
		[StringValue("removed")]
		Removed,
		[StringValue("submerged")]
		Submerged,
		[StringValue("temporary")]
		Temporary,
		[StringValue("threatened")]
		Threatened,
		[StringValue("unstable")]
		Unstable,
	}
	/// <summary>
	/// Indicates how the mark is sourced for the survey and whether it replaces any other marks
	/// 
	/// 
	/// </summary>
	public enum MonumentState
	{
		[StringValue("adopted")]
		Adopted,
		[StringValue("disturbed")]
		Disturbed,
		[StringValue("replaced")]
		Replaced,
		[StringValue("original")]
		Original,
		[StringValue("new")]
		New,
	}
	/// <summary>
	/// This indicates the material makeup of the Monument
	/// 
	/// 
	/// </summary>
	public enum MonumentType
	{
		[StringValue("disk")]
		Disk,
		[StringValue("nail")]
		Nail,
		[StringValue("not monumented")]
		NotMonumented,
		[StringValue("other")]
		Other,
		[StringValue("peg")]
		Peg,
		[StringValue("pin")]
		Pin,
		[StringValue("plaque")]
		Plaque,
		[StringValue("plug")]
		Plug,
		[StringValue("post")]
		Post,
		[StringValue("spike")]
		Spike,
		[StringValue("tube")]
		Tube,
		[StringValue("unknown")]
		Unknown,
	}
	/// <summary>
	/// This enumeration indicates whether the reduced observation information provided was actually measured (observed), calculated or deduced from observations, or adopted from another survey
	/// 
	/// 
	/// </summary>
	public enum ObservationType
	{
		[StringValue("measured")]
		Measured,
		[StringValue("calculated")]
		Calculated,
		[StringValue("scaled")]
		Scaled,
		[StringValue("adopted")]
		Adopted,
	}
	/// <summary>
	/// The parcel class combines both parcel intent and topology class.
	/// 
	/// 
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
	/// <summary>
	/// This is an extension of the LandXML state type, but is specific to parcels
	/// 
	/// 
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
	}
	public enum PipeNetworkType
	{
		[StringValue("sanitary")]
		Sanitary,
		[StringValue("storm")]
		Storm,
		[StringValue("water")]
		Water,
		[StringValue("other")]
		Other,
	}
	/// <summary>
	/// Used by many of the Survey elements
	/// 
	/// 
	/// </summary>
	public enum PurposeType
	{
		[StringValue("normal")]
		Normal,
		[StringValue("check")]
		Check,
		[StringValue("backsight")]
		Backsight,
		[StringValue("foresight")]
		Foresight,
		[StringValue("traverse")]
		Traverse,
		[StringValue("sideshot")]
		Sideshot,
		[StringValue("resection")]
		Resection,
		[StringValue("levelLoop")]
		LevelLoop,
		[StringValue("digitalLevel")]
		DigitalLevel,
		[StringValue("remoteElevation")]
		RemoteElevation,
		[StringValue("recipricalObservation")]
		RecipricalObservation,
		[StringValue("topo")]
		Topo,
		[StringValue("cutSheets")]
		CutSheets,
		[StringValue("asbuilt")]
		Asbuilt,
	}
	public enum SideType
	{
		[StringValue("right")]
		Right,
		[StringValue("left")]
		Left,
	}
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
	public enum StateType
	{
		[StringValue("abandoned")]
		Abandoned,
		[StringValue("destroyed")]
		Destroyed,
		[StringValue("existing")]
		Existing,
		[StringValue("proposed")]
		Proposed,
	}
	/// <summary>
	/// Surface boundaries can be one of three types: outer, void, island
	/// 
	/// 
	/// </summary>
	public enum SurfBndType
	{
		[StringValue("outer")]
		Outer,
		[StringValue("void")]
		Void,
		[StringValue("island")]
		Island,
	}
	/// <summary>
	/// TIN is the acronym for "triangulated irregular network", a surface comprised of 3 point faces
	/// 
	/// grid is a surface comprised of 4 point faces.
	/// 
	/// 
	/// </summary>
	public enum SurfTypeEnum
	{
		[StringValue("TIN")]
		TIN,
		[StringValue("grid")]
		Grid,
	}
	public enum SurfVolCMethodType
	{
		[StringValue("grid")]
		Grid,
		[StringValue("composite")]
		Composite,
	}
	/// <summary>
	/// This enumeration indicates whether the survey was acutally performed in the field, compiled from a series of existing surveys, or simply computed using known observations and maths
	/// 
	/// 
	/// </summary>
	public enum SurveyType
	{
		[StringValue("compiled")]
		Compiled,
		[StringValue("computed")]
		Computed,
		[StringValue("surveyed")]
		Surveyed,
	}
	/// <summary>
	/// Optional COGO Point attribute to designate the survey point type.
	/// 
	/// 
	/// </summary>
	public enum SurvPntType
	{
		[StringValue("monument")]
		Monument,
		[StringValue("control")]
		Control,
		[StringValue("sideShot")]
		SideShot,
	}
	public enum XsVolCalcMethodType
	{
		[StringValue("AverageEndArea")]
		AverageEndArea,
		[StringValue("Prismoidal")]
		Prismoidal,
	}
	public enum PointGeometryType
	{
		[StringValue("point")]
		Point,
		[StringValue("curve")]
		Curve,
	}
	/// <summary>
	/// angular values expressed in "decimal dd.mm.ss" units have the numeric
	/// 			format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
	/// 			
	/// 
	/// 
	/// </summary>
	public enum AngularType
	{
		[StringValue("radians")]
		Radians,
		[StringValue("grads")]
		Grads,
		[StringValue("decimal degrees")]
		DecimalDegrees,
		[StringValue("decimal dd.mm.ss")]
		DecimalDdMmSs,
	}
	public enum ZoneCategoryType
	{
		[StringValue("road surface")]
		RoadSurface,
		[StringValue("road subsurface")]
		RoadSubsurface,
		[StringValue("road shoulder")]
		RoadShoulder,
		[StringValue("road foreSlope")]
		RoadForeSlope,
		[StringValue("road backSlope")]
		RoadBackSlope,
		[StringValue("road curb-gutter")]
		RoadCurbGutter,
		[StringValue("bridge surface")]
		BridgeSurface,
		[StringValue("bridge body")]
		BridgeBody,
		[StringValue("sidewalk")]
		Sidewalk,
		[StringValue("ground")]
		Ground,
		[StringValue("ditch")]
		Ditch,
		[StringValue("wall")]
		Wall,
		[StringValue("channel")]
		Channel,
		[StringValue("bike facilities")]
		BikeFacilities,
		[StringValue("obstruction offset")]
		ObstructionOffset,
		[StringValue("longitudinal barrier")]
		LongitudinalBarrier,
		[StringValue("sound barrier")]
		SoundBarrier,
		[StringValue("bridge abutment")]
		BridgeAbutment,
		[StringValue("vertical pillar")]
		VerticalPillar,
	}
	public enum ZoneVertType
	{
		[StringValue("slope")]
		Slope,
		[StringValue("vertical distance")]
		VerticalDistance,
	}
	public enum ZoneSurfaceType
	{
		[StringValue("finalSurface")]
		FinalSurface,
		[StringValue("subgrade")]
		Subgrade,
	}
	public enum ZoneHingeType
	{
		[StringValue("center")]
		Center,
		[StringValue("left edge")]
		LeftEdge,
		[StringValue("right edge")]
		RightEdge,
	}
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
	public enum ZoneTransitionType
	{
		[StringValue("parallel")]
		Parallel,
		[StringValue("linear")]
		Linear,
	}
	public enum ZoneOffsetType
	{
		[StringValue("centerline")]
		Centerline,
		[StringValue("zone")]
		Zone,
	}
	public enum ZonePlacementType
	{
		[StringValue("dependent")]
		Dependent,
		[StringValue("independent")]
		Independent,
	}
	public enum SideofRoadType
	{
		[StringValue("right")]
		Right,
		[StringValue("left")]
		Left,
		[StringValue("both")]
		Both,
	}
	public enum RoadTerrainType
	{
		[StringValue("flat")]
		Flat,
		[StringValue("rolling")]
		Rolling,
		[StringValue("mountainous")]
		Mountainous,
	}
	public enum FunctionalClassType
	{
		[StringValue("arterial")]
		Arterial,
		[StringValue("collector ")]
		Collector,
		[StringValue("local")]
		Local,
	}
	public enum AdverseSEType
	{
		[StringValue("non-adverse")]
		NonAdverse,
		[StringValue("adverse")]
		Adverse,
	}
	public enum PavementSurfaceType
	{
		[StringValue("high-type")]
		HighType,
		[StringValue("intermediate-type")]
		IntermediateType,
		[StringValue("low-type")]
		LowType,
	}
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
	public enum ShoulderCategoryType
	{
		[StringValue("usable")]
		Usable,
		[StringValue("graded")]
		Graded,
	}
	public enum LaneTaperType
	{
		[StringValue("straight-line")]
		StraightLine,
		[StringValue("partial-tangent")]
		PartialTangent,
		[StringValue("symmetrical-reverse-curve")]
		SymmetricalReverseCurve,
		[StringValue("asymmetrical-reverse-curve")]
		AsymmetricalReverseCurve,
	}
	public enum TurnLaneType
	{
		[StringValue("left")]
		Left,
		[StringValue("right")]
		Right,
	}
	public enum DitchBottomShape
	{
		[StringValue("true-V")]
		TrueV,
		[StringValue("rounded-V")]
		RoundedV,
		[StringValue("rounded-trapezoidal")]
		RoundedTrapezoidal,
		[StringValue("flat-trapezoidal")]
		FlatTrapezoidal,
	}
	public enum TrafficControlType
	{
		[StringValue("none")]
		None,
		[StringValue("signal")]
		Signal,
		[StringValue("stop")]
		Stop,
		[StringValue("yield")]
		Yield,
	}
	public enum TrafficControlPosition
	{
		[StringValue("side")]
		Side,
		[StringValue("overhead")]
		Overhead,
	}
	public enum TrafficTurnRestriction
	{
		[StringValue("none")]
		None,
		[StringValue("no-left-turn")]
		NoLeftTurn,
		[StringValue("no-right-turn")]
		NoRightTurn,
		[StringValue("no-U-turn ")]
		NoUTurn,
		[StringValue("no-turn ")]
		NoTurn,
	}
	public enum IntersectionConstructionType
	{
		[StringValue("existing")]
		Existing,
		[StringValue("improvement")]
		Improvement,
		[StringValue("new")]
		New,
	}
	public enum CurbType
	{
		[StringValue("unknown")]
		Unknown,
	}
	public enum CornerType
	{
		[StringValue("unknown")]
		Unknown,
	}
	public enum RoadSignType
	{
		[StringValue("regulatory")]
		Regulatory,
		[StringValue("guide")]
		Guide,
		[StringValue("warning")]
		Warning,
		[StringValue("specificService")]
		SpecificService,
		[StringValue("tourist")]
		Tourist,
		[StringValue("recreation-cultural")]
		RecreationCultural,
		[StringValue("emergencyManagement")]
		EmergencyManagement,
	}
	public enum CrashSeverityType
	{
		[StringValue("fatal")]
		Fatal,
		[StringValue("nonfatal ")]
		Nonfatal,
		[StringValue("propery-damage-only")]
		ProperyDamageOnly,
	}
	public enum CrashIntersectionRelation
	{
		[StringValue("unknown")]
		Unknown,
		[StringValue("non-intersection-related")]
		NonIntersectionRelated,
		[StringValue("intersection-related")]
		IntersectionRelated,
	}
	public enum ManeuverType
	{
		[StringValue("A-stop-on-rural-road")]
		AStopOnRuralRoad,
		[StringValue("C-speed-path-direction-change-on-rural-road")]
		CSpeedPathDirectionChangeOnRuralRoad,
	}
	public enum BridgeProjectType
	{
		[StringValue("new")]
		New,
		[StringValue("existing")]
		Existing,
	}
	public enum MonumentPurpose_anonymous
	{
		[StringValue("boundary")]
		Boundary,
		[StringValue("naturalBoundary")]
		NaturalBoundary,
		[StringValue("origin")]
		Origin,
		[StringValue("traverse")]
		Traverse,
		[StringValue("witness")]
		Witness,
	}
	
	// Complex types
	// -------------
	/// <summary>
	/// All elements derived from PointType will either contain a coordinate text value ( "north east" or "north east elev"), a "pntRef" attribute value, or both. The "pntRef" attribute contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data. If this element has a "pntRef" value, then it's coordinates will be retrieved from the referenced element. If an element contains both a coordinate value and a pntRef, the coordinate value should be used as the point location and the referenced point is either ignored or is used for point attributes such as number or desc.
	/// 
	/// 
	/// </summary>
	public class PointType : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.pntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("pntRef"));
			this.pointGeometry = XsdConverter.Instance.Convert<PointGeometryType?>(attributes.GetSafe("pointGeometry"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(attributes.GetSafe("DTMAttribute"));
			this.timeStamp = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("timeStamp"));
			this.role = XsdConverter.Instance.Convert<SurveyRoleType?>(attributes.GetSafe("role"));
			this.content = XsdConverter.Instance.Convert<IList<double>>(text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("code = ").AppendLine(this.code);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("pntRef = ").AppendLine(this.pntRef);
			buff.Append("pointGeometry = ").AppendLine(this.pointGeometry);
			buff.Append("dTMAttribute = ").AppendLine(this.dTMAttribute);
			buff.Append("timeStamp = ").AppendLine(this.timeStamp);
			buff.Append("role = ").AppendLine(this.role);
			buff.Append("content = ").AppendLine(this.content);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public string code;
		public StateType? state;
		/// <summary>
		/// A reference name value referring to a PointType derived name attribute. An attribute if this type contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data.
		/// 
		/// 
		/// </summary>
		public string pntRef;
		public PointGeometryType? pointGeometry;
		public DTMAttributeType? dTMAttribute;
		public DateTime? timeStamp;
		public SurveyRoleType? role;
		public IList<double> content;
	}
	
	public class PointType3dReq : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.pntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("pntRef"));
			this.pointGeometry = XsdConverter.Instance.Convert<PointGeometryType?>(attributes.GetSafe("pointGeometry"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(attributes.GetSafe("DTMAttribute"));
			this.timeStamp = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("timeStamp"));
			this.role = XsdConverter.Instance.Convert<SurveyRoleType?>(attributes.GetSafe("role"));
			this.content = XsdConverter.Instance.Convert<IList<double>>(text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("code = ").AppendLine(this.code);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("pntRef = ").AppendLine(this.pntRef);
			buff.Append("pointGeometry = ").AppendLine(this.pointGeometry);
			buff.Append("dTMAttribute = ").AppendLine(this.dTMAttribute);
			buff.Append("timeStamp = ").AppendLine(this.timeStamp);
			buff.Append("role = ").AppendLine(this.role);
			buff.Append("content = ").AppendLine(this.content);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public string code;
		public StateType? state;
		/// <summary>
		/// A reference name value referring to a PointType derived name attribute. An attribute if this type contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data.
		/// 
		/// 
		/// </summary>
		public string pntRef;
		public PointGeometryType? pointGeometry;
		public DTMAttributeType? dTMAttribute;
		public DateTime? timeStamp;
		public SurveyRoleType? role;
		public IList<double> content;
	}
	
	
	// Elements from simple types
	// --------------------------
	
	// Elements from complex types
	// ---------------------------
	public class LandXML : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.date = XsdConverter.Instance.Convert<DateTime>(attributes.GetSafe("date"));
			this.time = XsdConverter.Instance.Convert<DateTime>(attributes.GetSafe("time"));
			this.version = XsdConverter.Instance.Convert<string>(attributes.GetSafe("version"));
			this.language = XsdConverter.Instance.Convert<string>(attributes.GetSafe("language"));
			this.readOnly = XsdConverter.Instance.Convert<bool?>(attributes.GetSafe("readOnly"));
			this.landXMLId = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("LandXMLId"));
			this.crc = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("crc"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("date = ").AppendLine(this.date);
			buff.Append("time = ").AppendLine(this.time);
			buff.Append("version = ").AppendLine(this.version);
			buff.Append("language = ").AppendLine(this.language);
			buff.Append("readOnly = ").AppendLine(this.readOnly);
			buff.Append("landXMLId = ").AppendLine(this.landXMLId);
			buff.Append("crc = ").AppendLine(this.crc);
			return buff.ToString();
		}
		public DateTime date;
		public DateTime time;
		public string version;
		public string language;
		public bool? readOnly;
		public int? landXMLId;
		public int? crc;
	}
	
	/// <summary>
	/// A collection of COGO points. (Cg = COGO = Cordinate Geometry)
	/// 
	/// 
	/// </summary>
	public class CgPoints : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.zoneNumber = XsdConverter.Instance.Convert<uint?>(attributes.GetSafe("zoneNumber"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(attributes.GetSafe("DTMAttribute"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("code = ").AppendLine(this.code);
			buff.Append("zoneNumber = ").AppendLine(this.zoneNumber);
			buff.Append("dTMAttribute = ").AppendLine(this.dTMAttribute);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
		public string code;
		public uint? zoneNumber;
		public DTMAttributeType? dTMAttribute;
	}
	
	/// <summary>
	/// Represents a COrdinate GeOmetry Point. The Point is identified by the "name" attr and the data value will be a sequence of space delimented, two or three double numberic values: (Northing Easting) or (Northing Easting Elevation).
	/// 
	/// 
	/// </summary>
	public class CgPoint : PointType
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.surveyOrder = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyOrder"));
			this.pntSurv = XsdConverter.Instance.Convert<SurvPntType?>(attributes.GetSafe("pntSurv"));
			this.zoneNumber = XsdConverter.Instance.Convert<uint?>(attributes.GetSafe("zoneNumber"));
			this.surveyHorizontalOrder = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyHorizontalOrder"));
			this.surveyVerticalOrder = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyVerticalOrder"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("oID = ").AppendLine(this.oID);
			buff.Append("surveyOrder = ").AppendLine(this.surveyOrder);
			buff.Append("pntSurv = ").AppendLine(this.pntSurv);
			buff.Append("zoneNumber = ").AppendLine(this.zoneNumber);
			buff.Append("surveyHorizontalOrder = ").AppendLine(this.surveyHorizontalOrder);
			buff.Append("surveyVerticalOrder = ").AppendLine(this.surveyVerticalOrder);
			return buff.ToString();
		}
		public string oID;
		public string surveyOrder;
		/// <summary>
		/// Optional COGO Point attribute to designate the survey point type.
		/// 
		/// 
		/// </summary>
		public SurvPntType? pntSurv;
		public uint? zoneNumber;
		public string surveyHorizontalOrder;
		public string surveyVerticalOrder;
	}
	
	/// <summary>
	/// A reference to any external document file containing related information for the associated element.
	/// 
	/// 
	/// </summary>
	public class DocFileRef : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.location = XsdConverter.Instance.Convert<Uri>(attributes.GetSafe("location"));
			this.fileType = XsdConverter.Instance.Convert<string>(attributes.GetSafe("fileType"));
			this.fileFormat = XsdConverter.Instance.Convert<string>(attributes.GetSafe("fileFormat"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("location = ").AppendLine(this.location);
			buff.Append("fileType = ").AppendLine(this.fileType);
			buff.Append("fileFormat = ").AppendLine(this.fileFormat);
			return buff.ToString();
		}
		public string name;
		public Uri location;
		public string fileType;
		public string fileFormat;
	}
	
	/// <summary>
	/// Used to include additional information that is not explicitly defined by the LandXML schema, Feature may contain one or more Property, DocFileRef or nested Feature elements. 
	/// NOTE: to allow any valid content, the explicit definitions for Property, DocFileRef and Feature have been commented out, but are still expected in common use.
	/// 
	/// Each Property element defines one piece of data.
	/// 
	/// 
	/// </summary>
	public class Feature : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.source = XsdConverter.Instance.Convert<string>(attributes.GetSafe("source"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("code = ").AppendLine(this.code);
			buff.Append("source = ").AppendLine(this.source);
			return buff.ToString();
		}
		public string code;
		public string source;
	}
	
	/// <summary>
	/// Used to include additional information that is not explicitly defined by the LandXML schema. Each Property element defines one piece of data.
	/// 
	/// The "label" attribute defines the name of the value held in the "value" attribute.
	/// 
	/// 
	/// </summary>
	public class Property : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.label = XsdConverter.Instance.Convert<string>(attributes.GetSafe("label"));
			this.value = XsdConverter.Instance.Convert<string>(attributes.GetSafe("value"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("label = ").AppendLine(this.label);
			buff.Append("value = ").AppendLine(this.value);
			return buff.ToString();
		}
		public string label;
		public string value;
	}
	
	/// <summary>
	/// Used to record lines that are irregular such as river boudaries etc. It has Start and End point elements and a list of intermediate points. Point list should also include the start and end points.
	/// 
	/// 
	/// </summary>
	public class IrregularLine : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dir = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("dir"));
			this.length = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("length"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("dir = ").AppendLine(this.dir);
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("oID = ").AppendLine(this.oID);
			return buff.ToString();
		}
		public string desc;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? dir;
		public double? length;
		public string name;
		public double? staStart;
		public StateType? state;
		public string oID;
	}
	
	/// <summary>
	/// A text value that is a space delimited list of CgPoint names that form a linear connected chain. 
	/// 			example: 
	/// <Chain xmlns="http://www.landxml.org/schema/LandXML-1.0">1 23 45 34</Chain>
	/// 
	/// 			represents a linear connection between CgPoint name 1, 23, 45 and 34.
	/// 			
	/// 
	/// 
	/// </summary>
	public class Chain : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.pointGeometry = XsdConverter.Instance.Convert<PointGeometryType?>(attributes.GetSafe("pointGeometry"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(attributes.GetSafe("DTMAttribute"));
			this.timeStamp = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("timeStamp"));
			this.role = XsdConverter.Instance.Convert<SurveyRoleType?>(attributes.GetSafe("role"));
			this.content = XsdConverter.Instance.Convert<IList<string>>(text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("code = ").AppendLine(this.code);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("pointGeometry = ").AppendLine(this.pointGeometry);
			buff.Append("dTMAttribute = ").AppendLine(this.dTMAttribute);
			buff.Append("timeStamp = ").AppendLine(this.timeStamp);
			buff.Append("role = ").AppendLine(this.role);
			buff.Append("content = ").AppendLine(this.content);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public string code;
		public StateType? state;
		public PointGeometryType? pointGeometry;
		public DTMAttributeType? dTMAttribute;
		public DateTime? timeStamp;
		public SurveyRoleType? role;
		public IList<string> content;
	}
	
	/// <summary>
	/// The distance from the Start to the Center provides the radius value.
	/// 
	/// The rotation attribute "rot" defines whether the arc travels clockwise or counter-clockwise from the Start to End point.
	/// 
	/// 
	/// </summary>
	public class Curve : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.rot = XsdConverter.Instance.Convert<Clockwise>(attributes.GetSafe("rot"));
			this.chord = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("chord"));
			this.crvType = XsdConverter.Instance.Convert<CurveType?>(attributes.GetSafe("crvType"));
			this.delta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("delta"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dirEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("dirEnd"));
			this.dirStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("dirStart"));
			this.external = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("external"));
			this.length = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("length"));
			this.midOrd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("midOrd"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.radius = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("radius"));
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.tangent = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("tangent"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("rot = ").AppendLine(this.rot);
			buff.Append("chord = ").AppendLine(this.chord);
			buff.Append("crvType = ").AppendLine(this.crvType);
			buff.Append("delta = ").AppendLine(this.delta);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("dirEnd = ").AppendLine(this.dirEnd);
			buff.Append("dirStart = ").AppendLine(this.dirStart);
			buff.Append("external = ").AppendLine(this.external);
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("midOrd = ").AppendLine(this.midOrd);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("radius = ").AppendLine(this.radius);
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("tangent = ").AppendLine(this.tangent);
			buff.Append("oID = ").AppendLine(this.oID);
			return buff.ToString();
		}
		public Clockwise rot;
		public double? chord;
		public CurveType? crvType;
		/// <summary>
		/// Represents a normalized angular value in the specified Angular units.
		/// 
		/// 
		/// </summary>
		public double? delta;
		public string desc;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? dirEnd;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? dirStart;
		public double? external;
		public double? length;
		public double? midOrd;
		public string name;
		public double? radius;
		public double? staStart;
		public StateType? state;
		public double? tangent;
		public string oID;
	}
	
	/// <summary>
	/// An "infinite" spiral radius is denoted by the value "INF". 
	/// 
	/// This conforms to XML Schema which defines infinity as "INF" or "-INF" for all numeric datatypes 
	/// 
	/// 
	/// </summary>
	public class Spiral : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.radiusEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("radiusEnd"));
			this.radiusStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("radiusStart"));
			this.rot = XsdConverter.Instance.Convert<Clockwise>(attributes.GetSafe("rot"));
			this.spiType = XsdConverter.Instance.Convert<SpiralType>(attributes.GetSafe("spiType"));
			this.chord = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("chord"));
			this.constant = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("constant"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dirEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("dirEnd"));
			this.dirStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("dirStart"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.theta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("theta"));
			this.totalY = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("totalY"));
			this.totalX = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("totalX"));
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.tanLong = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("tanLong"));
			this.tanShort = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("tanShort"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("radiusEnd = ").AppendLine(this.radiusEnd);
			buff.Append("radiusStart = ").AppendLine(this.radiusStart);
			buff.Append("rot = ").AppendLine(this.rot);
			buff.Append("spiType = ").AppendLine(this.spiType);
			buff.Append("chord = ").AppendLine(this.chord);
			buff.Append("constant = ").AppendLine(this.constant);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("dirEnd = ").AppendLine(this.dirEnd);
			buff.Append("dirStart = ").AppendLine(this.dirStart);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("theta = ").AppendLine(this.theta);
			buff.Append("totalY = ").AppendLine(this.totalY);
			buff.Append("totalX = ").AppendLine(this.totalX);
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("tanLong = ").AppendLine(this.tanLong);
			buff.Append("tanShort = ").AppendLine(this.tanShort);
			buff.Append("oID = ").AppendLine(this.oID);
			return buff.ToString();
		}
		public double length;
		public double radiusEnd;
		public double radiusStart;
		public Clockwise rot;
		public SpiralType spiType;
		public double? chord;
		public double? constant;
		public string desc;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? dirEnd;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? dirStart;
		public string name;
		/// <summary>
		/// Represents a normalized angular value in the specified Angular units.
		/// 
		/// 
		/// </summary>
		public double? theta;
		public double? totalY;
		public double? totalX;
		public double? staStart;
		public StateType? state;
		public double? tanLong;
		public double? tanShort;
		public string oID;
	}
	
	/// <summary>
	/// A sequential list of Line and/or Curve and/or Spiral elements.
	/// 
	/// 
	/// </summary>
	public class CoordGeom : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// Modified to include official ID, as has all CoordGeom elements
	/// 
	/// 
	/// </summary>
	public class Line : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dir = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("dir"));
			this.length = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("length"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("dir = ").AppendLine(this.dir);
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("oID = ").AppendLine(this.oID);
			return buff.ToString();
		}
		public string desc;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? dir;
		public double? length;
		public string name;
		public double? staStart;
		public StateType? state;
		public string oID;
	}
	
	public class CrossSects : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.calcMethod = XsdConverter.Instance.Convert<XsVolCalcMethodType?>(attributes.GetSafe("calcMethod"));
			this.curveCorrection = XsdConverter.Instance.Convert<bool?>(attributes.GetSafe("curveCorrection"));
			this.swellFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("swellFactor"));
			this.shrinkFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("shrinkFactor"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("calcMethod = ").AppendLine(this.calcMethod);
			buff.Append("curveCorrection = ").AppendLine(this.curveCorrection);
			buff.Append("swellFactor = ").AppendLine(this.swellFactor);
			buff.Append("shrinkFactor = ").AppendLine(this.shrinkFactor);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
		public XsVolCalcMethodType? calcMethod;
		public bool? curveCorrection;
		public double? swellFactor;
		public double? shrinkFactor;
	}
	
	public class CrossSect : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.sta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("sta"));
			this.angleSkew = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("angleSkew"));
			this.areaCut = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("areaCut"));
			this.areaFill = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("areaFill"));
			this.centroidCut = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("centroidCut"));
			this.centroidFill = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("centroidFill"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.sectType = XsdConverter.Instance.Convert<string>(attributes.GetSafe("sectType"));
			this.volumeCut = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("volumeCut"));
			this.volumeFill = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("volumeFill"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("sta = ").AppendLine(this.sta);
			buff.Append("angleSkew = ").AppendLine(this.angleSkew);
			buff.Append("areaCut = ").AppendLine(this.areaCut);
			buff.Append("areaFill = ").AppendLine(this.areaFill);
			buff.Append("centroidCut = ").AppendLine(this.centroidCut);
			buff.Append("centroidFill = ").AppendLine(this.centroidFill);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("sectType = ").AppendLine(this.sectType);
			buff.Append("volumeCut = ").AppendLine(this.volumeCut);
			buff.Append("volumeFill = ").AppendLine(this.volumeFill);
			return buff.ToString();
		}
		public double sta;
		/// <summary>
		/// Represents a normalized angular value in the specified Angular units.
		/// 
		/// 
		/// </summary>
		public double? angleSkew;
		public double? areaCut;
		public double? areaFill;
		public double? centroidCut;
		public double? centroidFill;
		public string desc;
		public string name;
		public string sectType;
		public double? volumeCut;
		public double? volumeFill;
	}
	
	/// <summary>
	/// It is defined with a space delimited PntList2D of offset/elevations pairs that will represent either existing or proposed surfaces. 
	/// 
	/// Example: "-60.00 86.52 -36.26 86.89 12.41 87.01 60.00 87.83" 
	/// 
	/// Note: Gaps in the surface are handled by having 2 or more PntList2D elements.
	/// 
	/// 
	/// </summary>
	public class CrossSectSurf : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public StateType? state;
	}
	
	public class Project : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public StateType? state;
	}
	
	/// <summary>
	/// All angular and direction values default to radians unless otherwise noted. Direction values are measured counter-clockwise from east=0.
	/// 
	/// 
	/// </summary>
	public class Units : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class Metric : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.areaUnit = XsdConverter.Instance.Convert<MetArea>(attributes.GetSafe("areaUnit"));
			this.linearUnit = XsdConverter.Instance.Convert<MetLinear>(attributes.GetSafe("linearUnit"));
			this.volumeUnit = XsdConverter.Instance.Convert<MetVolume>(attributes.GetSafe("volumeUnit"));
			this.temperatureUnit = XsdConverter.Instance.Convert<MetTemperature>(attributes.GetSafe("temperatureUnit"));
			this.pressureUnit = XsdConverter.Instance.Convert<MetPressure>(attributes.GetSafe("pressureUnit"));
			this.diameterUnit = XsdConverter.Instance.Convert<MetDiameter?>(attributes.GetSafe("diameterUnit"));
			this.widthUnit = XsdConverter.Instance.Convert<MetWidth?>(attributes.GetSafe("widthUnit"));
			this.heightUnit = XsdConverter.Instance.Convert<MetHeight?>(attributes.GetSafe("heightUnit"));
			this.velocityUnit = XsdConverter.Instance.Convert<MetVelocity?>(attributes.GetSafe("velocityUnit"));
			this.flowUnit = XsdConverter.Instance.Convert<MetFlow?>(attributes.GetSafe("flowUnit"));
			this.angularUnit = XsdConverter.Instance.Convert<AngularType?>(attributes.GetSafe("angularUnit"), XsdConverter.Instance.Convert<AngularType?>("radians"));
			this.directionUnit = XsdConverter.Instance.Convert<AngularType?>(attributes.GetSafe("directionUnit"), XsdConverter.Instance.Convert<AngularType?>("radians"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("areaUnit = ").AppendLine(this.areaUnit);
			buff.Append("linearUnit = ").AppendLine(this.linearUnit);
			buff.Append("volumeUnit = ").AppendLine(this.volumeUnit);
			buff.Append("temperatureUnit = ").AppendLine(this.temperatureUnit);
			buff.Append("pressureUnit = ").AppendLine(this.pressureUnit);
			buff.Append("diameterUnit = ").AppendLine(this.diameterUnit);
			buff.Append("widthUnit = ").AppendLine(this.widthUnit);
			buff.Append("heightUnit = ").AppendLine(this.heightUnit);
			buff.Append("velocityUnit = ").AppendLine(this.velocityUnit);
			buff.Append("flowUnit = ").AppendLine(this.flowUnit);
			buff.Append("angularUnit = ").Append(this.angularUnit).AppendLine(" defvalue = radians");
			buff.Append("directionUnit = ").Append(this.directionUnit).AppendLine(" defvalue = radians");
			return buff.ToString();
		}
		public MetArea areaUnit;
		public MetLinear linearUnit;
		public MetVolume volumeUnit;
		public MetTemperature temperatureUnit;
		public MetPressure pressureUnit;
		public MetDiameter? diameterUnit;
		public MetWidth? widthUnit;
		public MetHeight? heightUnit;
		public MetVelocity? velocityUnit;
		public MetFlow? flowUnit;
		/// <summary>
		/// angular values expressed in "decimal dd.mm.ss" units have the numeric
		/// 			format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
		/// 			
		/// 
		/// 
		/// </summary>
		public AngularType? angularUnit;
		/// <summary>
		/// angular values expressed in "decimal dd.mm.ss" units have the numeric
		/// 			format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
		/// 			
		/// 
		/// 
		/// </summary>
		public AngularType? directionUnit;
	}
	
	public class Imperial : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.areaUnit = XsdConverter.Instance.Convert<ImpArea>(attributes.GetSafe("areaUnit"));
			this.linearUnit = XsdConverter.Instance.Convert<ImpLinear>(attributes.GetSafe("linearUnit"));
			this.volumeUnit = XsdConverter.Instance.Convert<ImpVolume>(attributes.GetSafe("volumeUnit"));
			this.temperatureUnit = XsdConverter.Instance.Convert<ImpTemperature>(attributes.GetSafe("temperatureUnit"));
			this.pressureUnit = XsdConverter.Instance.Convert<ImpPressure>(attributes.GetSafe("pressureUnit"));
			this.diameterUnit = XsdConverter.Instance.Convert<ImpDiameter?>(attributes.GetSafe("diameterUnit"));
			this.widthUnit = XsdConverter.Instance.Convert<ImpWidth?>(attributes.GetSafe("widthUnit"));
			this.heightUnit = XsdConverter.Instance.Convert<ImpHeight?>(attributes.GetSafe("heightUnit"));
			this.velocityUnit = XsdConverter.Instance.Convert<ImpVelocity?>(attributes.GetSafe("velocityUnit"));
			this.flowUnit = XsdConverter.Instance.Convert<ImpFlow?>(attributes.GetSafe("flowUnit"));
			this.angularUnit = XsdConverter.Instance.Convert<AngularType?>(attributes.GetSafe("angularUnit"), XsdConverter.Instance.Convert<AngularType?>("radians"));
			this.directionUnit = XsdConverter.Instance.Convert<AngularType?>(attributes.GetSafe("directionUnit"), XsdConverter.Instance.Convert<AngularType?>("radians"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("areaUnit = ").AppendLine(this.areaUnit);
			buff.Append("linearUnit = ").AppendLine(this.linearUnit);
			buff.Append("volumeUnit = ").AppendLine(this.volumeUnit);
			buff.Append("temperatureUnit = ").AppendLine(this.temperatureUnit);
			buff.Append("pressureUnit = ").AppendLine(this.pressureUnit);
			buff.Append("diameterUnit = ").AppendLine(this.diameterUnit);
			buff.Append("widthUnit = ").AppendLine(this.widthUnit);
			buff.Append("heightUnit = ").AppendLine(this.heightUnit);
			buff.Append("velocityUnit = ").AppendLine(this.velocityUnit);
			buff.Append("flowUnit = ").AppendLine(this.flowUnit);
			buff.Append("angularUnit = ").Append(this.angularUnit).AppendLine(" defvalue = radians");
			buff.Append("directionUnit = ").Append(this.directionUnit).AppendLine(" defvalue = radians");
			return buff.ToString();
		}
		public ImpArea areaUnit;
		public ImpLinear linearUnit;
		public ImpVolume volumeUnit;
		public ImpTemperature temperatureUnit;
		public ImpPressure pressureUnit;
		public ImpDiameter? diameterUnit;
		public ImpWidth? widthUnit;
		public ImpHeight? heightUnit;
		public ImpVelocity? velocityUnit;
		public ImpFlow? flowUnit;
		/// <summary>
		/// angular values expressed in "decimal dd.mm.ss" units have the numeric
		/// 			format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
		/// 			
		/// 
		/// 
		/// </summary>
		public AngularType? angularUnit;
		/// <summary>
		/// angular values expressed in "decimal dd.mm.ss" units have the numeric
		/// 			format "45.3025" representing 45 degrees 30 minutes and 25 seconds. Both the minutes and seconds must be two characters with a numeric range between 00 to 60.
		/// 			
		/// 
		/// 
		/// </summary>
		public AngularType? directionUnit;
	}
	
	/// <summary>
	/// The OpenGIS coordinate systems XML description may be appended to this element and still validate. Most of the "xxCoordinateSystemName" attributes were gather from the OpenGIS Coordinate System interface descriptions and the values of the names should be the OpenGIS common use name for the coordinate system."
	/// 
	/// 
	/// </summary>
	public class CoordinateSystem : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.rotationAngle = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("rotationAngle"));
			this.datum = XsdConverter.Instance.Convert<string>(attributes.GetSafe("datum"));
			this.horizontalDatum = XsdConverter.Instance.Convert<string>(attributes.GetSafe("horizontalDatum"));
			this.verticalDatum = XsdConverter.Instance.Convert<string>(attributes.GetSafe("verticalDatum"));
			this.ellipsoidName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("ellipsoidName"));
			this.fittedCoordinateSystemName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("fittedCoordinateSystemName"));
			this.horizontalCoordinateSystemName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("horizontalCoordinateSystemName"));
			this.compoundCoordinateSystemName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("compoundCoordinateSystemName"));
			this.localCoordinateSystemName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("localCoordinateSystemName"));
			this.geographicCoordinateSystemName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("geographicCoordinateSystemName"));
			this.projectedCoordinateSystemName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("projectedCoordinateSystemName"));
			this.geocentricCoordinateSystemName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("geocentricCoordinateSystemName"));
			this.verticalCoordinateSystemName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("verticalCoordinateSystemName"));
			this.fileLocation = XsdConverter.Instance.Convert<Uri>(attributes.GetSafe("fileLocation"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("rotationAngle = ").AppendLine(this.rotationAngle);
			buff.Append("datum = ").AppendLine(this.datum);
			buff.Append("horizontalDatum = ").AppendLine(this.horizontalDatum);
			buff.Append("verticalDatum = ").AppendLine(this.verticalDatum);
			buff.Append("ellipsoidName = ").AppendLine(this.ellipsoidName);
			buff.Append("fittedCoordinateSystemName = ").AppendLine(this.fittedCoordinateSystemName);
			buff.Append("horizontalCoordinateSystemName = ").AppendLine(this.horizontalCoordinateSystemName);
			buff.Append("compoundCoordinateSystemName = ").AppendLine(this.compoundCoordinateSystemName);
			buff.Append("localCoordinateSystemName = ").AppendLine(this.localCoordinateSystemName);
			buff.Append("geographicCoordinateSystemName = ").AppendLine(this.geographicCoordinateSystemName);
			buff.Append("projectedCoordinateSystemName = ").AppendLine(this.projectedCoordinateSystemName);
			buff.Append("geocentricCoordinateSystemName = ").AppendLine(this.geocentricCoordinateSystemName);
			buff.Append("verticalCoordinateSystemName = ").AppendLine(this.verticalCoordinateSystemName);
			buff.Append("fileLocation = ").AppendLine(this.fileLocation);
			return buff.ToString();
		}
		public string desc;
		public string name;
		/// <summary>
		/// Represents a normalized angular value in the specified Angular units.
		/// 
		/// 
		/// </summary>
		public double? rotationAngle;
		public string datum;
		public string horizontalDatum;
		public string verticalDatum;
		public string ellipsoidName;
		public string fittedCoordinateSystemName;
		public string horizontalCoordinateSystemName;
		public string compoundCoordinateSystemName;
		public string localCoordinateSystemName;
		public string geographicCoordinateSystemName;
		public string projectedCoordinateSystemName;
		public string geocentricCoordinateSystemName;
		public string verticalCoordinateSystemName;
		public Uri fileLocation;
	}
	
	/// <summary>
	/// Optional element to identify the software that was used to create the file.
	/// 
	/// 
	/// </summary>
	public class Application : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.manufacturer = XsdConverter.Instance.Convert<string>(attributes.GetSafe("manufacturer"));
			this.version = XsdConverter.Instance.Convert<string>(attributes.GetSafe("version"));
			this.manufacturerURL = XsdConverter.Instance.Convert<string>(attributes.GetSafe("manufacturerURL"));
			this.timeStamp = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("timeStamp"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("manufacturer = ").AppendLine(this.manufacturer);
			buff.Append("version = ").AppendLine(this.version);
			buff.Append("manufacturerURL = ").AppendLine(this.manufacturerURL);
			buff.Append("timeStamp = ").AppendLine(this.timeStamp);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public string manufacturer;
		public string version;
		public string manufacturerURL;
		public DateTime? timeStamp;
	}
	
	/// <summary>
	/// Optional element to identify the source of the file.
	/// 
	/// 
	/// </summary>
	public class Author : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.createdBy = XsdConverter.Instance.Convert<string>(attributes.GetSafe("createdBy"));
			this.createdByEmail = XsdConverter.Instance.Convert<string>(attributes.GetSafe("createdByEmail"));
			this.company = XsdConverter.Instance.Convert<string>(attributes.GetSafe("company"));
			this.companyURL = XsdConverter.Instance.Convert<string>(attributes.GetSafe("companyURL"));
			this.timeStamp = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("timeStamp"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("createdBy = ").AppendLine(this.createdBy);
			buff.Append("createdByEmail = ").AppendLine(this.createdByEmail);
			buff.Append("company = ").AppendLine(this.company);
			buff.Append("companyURL = ").AppendLine(this.companyURL);
			buff.Append("timeStamp = ").AppendLine(this.timeStamp);
			return buff.ToString();
		}
		public string createdBy;
		public string createdByEmail;
		public string company;
		public string companyURL;
		public DateTime? timeStamp;
	}
	
	/// <summary>
	/// I've added state here as a safety net
	/// 
	/// 
	/// </summary>
	public class Survey : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.date = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("date"));
			this.startTime = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("startTime"));
			this.endTime = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("endTime"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.horizontalAccuracy = XsdConverter.Instance.Convert<string>(attributes.GetSafe("horizontalAccuracy"));
			this.verticalAccuracy = XsdConverter.Instance.Convert<string>(attributes.GetSafe("verticalAccuracy"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("date = ").AppendLine(this.date);
			buff.Append("startTime = ").AppendLine(this.startTime);
			buff.Append("endTime = ").AppendLine(this.endTime);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("horizontalAccuracy = ").AppendLine(this.horizontalAccuracy);
			buff.Append("verticalAccuracy = ").AppendLine(this.verticalAccuracy);
			return buff.ToString();
		}
		public string desc;
		public DateTime? date;
		public DateTime? startTime;
		public DateTime? endTime;
		public StateType? state;
		public string horizontalAccuracy;
		public string verticalAccuracy;
	}
	
	/// <summary>
	/// We seemed to have doubled up on the survey purpose here, but the two are quite different - maybe need a different name
	/// 
	/// 
	/// </summary>
	public class SurveyHeader : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.purpose = XsdConverter.Instance.Convert<PurposeType?>(attributes.GetSafe("purpose"));
			this.startTime = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("startTime"));
			this.endTime = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("endTime"));
			this.surveyor = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyor"));
			this.surveyorFirm = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyorFirm"));
			this.surveyorReference = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyorReference"));
			this.surveyorRegistration = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyorRegistration"));
			this.surveyPurpose = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyPurpose"));
			this.type = XsdConverter.Instance.Convert<SurveyType?>(attributes.GetSafe("type"));
			this.@class = XsdConverter.Instance.Convert<string>(attributes.GetSafe("class"));
			this.county = XsdConverter.Instance.Convert<string>(attributes.GetSafe("county"));
			this.applyAtmosphericCorrection = XsdConverter.Instance.Convert<bool?>(attributes.GetSafe("applyAtmosphericCorrection"));
			this.pressure = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("pressure"));
			this.temperature = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("temperature"));
			this.applySeaLevelCorrection = XsdConverter.Instance.Convert<bool?>(attributes.GetSafe("applySeaLevelCorrection"));
			this.scaleFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("scaleFactor"));
			this.seaLevelCorrectionFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("seaLevelCorrectionFactor"));
			this.combinedFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("combinedFactor"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("purpose = ").AppendLine(this.purpose);
			buff.Append("startTime = ").AppendLine(this.startTime);
			buff.Append("endTime = ").AppendLine(this.endTime);
			buff.Append("surveyor = ").AppendLine(this.surveyor);
			buff.Append("surveyorFirm = ").AppendLine(this.surveyorFirm);
			buff.Append("surveyorReference = ").AppendLine(this.surveyorReference);
			buff.Append("surveyorRegistration = ").AppendLine(this.surveyorRegistration);
			buff.Append("surveyPurpose = ").AppendLine(this.surveyPurpose);
			buff.Append("type = ").AppendLine(this.type);
			buff.Append("@class = ").AppendLine(this.@class);
			buff.Append("county = ").AppendLine(this.county);
			buff.Append("applyAtmosphericCorrection = ").AppendLine(this.applyAtmosphericCorrection);
			buff.Append("pressure = ").AppendLine(this.pressure);
			buff.Append("temperature = ").AppendLine(this.temperature);
			buff.Append("applySeaLevelCorrection = ").AppendLine(this.applySeaLevelCorrection);
			buff.Append("scaleFactor = ").AppendLine(this.scaleFactor);
			buff.Append("seaLevelCorrectionFactor = ").AppendLine(this.seaLevelCorrectionFactor);
			buff.Append("combinedFactor = ").AppendLine(this.combinedFactor);
			return buff.ToString();
		}
		public string name;
		public string desc;
		/// <summary>
		/// Used by many of the Survey elements
		/// 
		/// 
		/// </summary>
		public PurposeType? purpose;
		public DateTime? startTime;
		public DateTime? endTime;
		public string surveyor;
		public string surveyorFirm;
		public string surveyorReference;
		public string surveyorRegistration;
		public string surveyPurpose;
		/// <summary>
		/// This enumeration indicates whether the survey was acutally performed in the field, compiled from a series of existing surveys, or simply computed using known observations and maths
		/// 
		/// 
		/// </summary>
		public SurveyType? type;
		public string @class;
		public string county;
		public bool? applyAtmosphericCorrection;
		public double? pressure;
		public double? temperature;
		public bool? applySeaLevelCorrection;
		public double? scaleFactor;
		public double? seaLevelCorrectionFactor;
		public double? combinedFactor;
	}
	
	public class Personnel : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.role = XsdConverter.Instance.Convert<string>(attributes.GetSafe("role"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("role = ").AppendLine(this.role);
			return buff.ToString();
		}
		public string name;
		public string role;
	}
	
	/// <summary>
	/// Place the note as a text value between the FieldNote element tags.
	/// 			You may also place any valid XML structure inside this tag.
	/// 
	/// 
	/// </summary>
	public class FieldNote : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class Equipment : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class InstrumentDetails : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.edmAccuracyConstant = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("edmAccuracyConstant"));
			this.edmAccuracyppm = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("edmAccuracyppm"));
			this.edmVertOffset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("edmVertOffset"));
			this.horizAnglePrecision = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("horizAnglePrecision"));
			this.manufacturer = XsdConverter.Instance.Convert<string>(attributes.GetSafe("manufacturer"));
			this.model = XsdConverter.Instance.Convert<string>(attributes.GetSafe("model"));
			this.serialNumber = XsdConverter.Instance.Convert<string>(attributes.GetSafe("serialNumber"));
			this.zenithAnglePrecision = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("zenithAnglePrecision"));
			this.carrierWavelength = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("carrierWavelength"));
			this.refractiveIndex = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("refractiveIndex"));
			this.horizCollimation = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("horizCollimation"));
			this.vertCollimation = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("vertCollimation"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("edmAccuracyConstant = ").AppendLine(this.edmAccuracyConstant);
			buff.Append("edmAccuracyppm = ").AppendLine(this.edmAccuracyppm);
			buff.Append("edmVertOffset = ").AppendLine(this.edmVertOffset);
			buff.Append("horizAnglePrecision = ").AppendLine(this.horizAnglePrecision);
			buff.Append("manufacturer = ").AppendLine(this.manufacturer);
			buff.Append("model = ").AppendLine(this.model);
			buff.Append("serialNumber = ").AppendLine(this.serialNumber);
			buff.Append("zenithAnglePrecision = ").AppendLine(this.zenithAnglePrecision);
			buff.Append("carrierWavelength = ").AppendLine(this.carrierWavelength);
			buff.Append("refractiveIndex = ").AppendLine(this.refractiveIndex);
			buff.Append("horizCollimation = ").AppendLine(this.horizCollimation);
			buff.Append("vertCollimation = ").AppendLine(this.vertCollimation);
			return buff.ToString();
		}
		public string id;
		public double? edmAccuracyConstant;
		public double? edmAccuracyppm;
		public double? edmVertOffset;
		public double? horizAnglePrecision;
		public string manufacturer;
		public string model;
		public string serialNumber;
		public double? zenithAnglePrecision;
		public double? carrierWavelength;
		public double? refractiveIndex;
		public double? horizCollimation;
		public double? vertCollimation;
	}
	
	public class LaserDetails : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.laserVertOffset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("laserVertOffset"));
			this.manufacturer = XsdConverter.Instance.Convert<string>(attributes.GetSafe("manufacturer"));
			this.model = XsdConverter.Instance.Convert<string>(attributes.GetSafe("model"));
			this.serialNumber = XsdConverter.Instance.Convert<string>(attributes.GetSafe("serialNumber"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("laserVertOffset = ").AppendLine(this.laserVertOffset);
			buff.Append("manufacturer = ").AppendLine(this.manufacturer);
			buff.Append("model = ").AppendLine(this.model);
			buff.Append("serialNumber = ").AppendLine(this.serialNumber);
			return buff.ToString();
		}
		public string id;
		public double? laserVertOffset;
		public string manufacturer;
		public string model;
		public string serialNumber;
	}
	
	public class GPSAntennaDetails : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.manufacturer = XsdConverter.Instance.Convert<string>(attributes.GetSafe("manufacturer"));
			this.model = XsdConverter.Instance.Convert<string>(attributes.GetSafe("model"));
			this.serialNumber = XsdConverter.Instance.Convert<string>(attributes.GetSafe("serialNumber"));
			this.latitude = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("latitude"));
			this.longitude = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("longitude"));
			this.altitude = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("altitude"));
			this.ellipsiodnalHeight = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("ellipsiodnalHeight"));
			this.orthometricHeight = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("orthometricHeight"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("manufacturer = ").AppendLine(this.manufacturer);
			buff.Append("model = ").AppendLine(this.model);
			buff.Append("serialNumber = ").AppendLine(this.serialNumber);
			buff.Append("latitude = ").AppendLine(this.latitude);
			buff.Append("longitude = ").AppendLine(this.longitude);
			buff.Append("altitude = ").AppendLine(this.altitude);
			buff.Append("ellipsiodnalHeight = ").AppendLine(this.ellipsiodnalHeight);
			buff.Append("orthometricHeight = ").AppendLine(this.orthometricHeight);
			return buff.ToString();
		}
		public string id;
		public string manufacturer;
		public string model;
		public string serialNumber;
		public double? latitude;
		public double? longitude;
		public double? altitude;
		public double? ellipsiodnalHeight;
		public double? orthometricHeight;
	}
	
	public class GPSReceiverDetails : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.manufacturer = XsdConverter.Instance.Convert<string>(attributes.GetSafe("manufacturer"));
			this.model = XsdConverter.Instance.Convert<string>(attributes.GetSafe("model"));
			this.serialNumber = XsdConverter.Instance.Convert<string>(attributes.GetSafe("serialNumber"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("manufacturer = ").AppendLine(this.manufacturer);
			buff.Append("model = ").AppendLine(this.model);
			buff.Append("serialNumber = ").AppendLine(this.serialNumber);
			return buff.ToString();
		}
		public string id;
		public string manufacturer;
		public string model;
		public string serialNumber;
	}
	
	public class Corrections : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.refractionCoefficient = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("refractionCoefficient"));
			this.applyRefractionCoefficient = XsdConverter.Instance.Convert<bool?>(attributes.GetSafe("applyRefractionCoefficient"));
			this.sphericity = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("sphericity"));
			this.prismEccentricity = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("prismEccentricity"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("refractionCoefficient = ").AppendLine(this.refractionCoefficient);
			buff.Append("applyRefractionCoefficient = ").AppendLine(this.applyRefractionCoefficient);
			buff.Append("sphericity = ").AppendLine(this.sphericity);
			buff.Append("prismEccentricity = ").AppendLine(this.prismEccentricity);
			return buff.ToString();
		}
		public double? refractionCoefficient;
		public bool? applyRefractionCoefficient;
		public double? sphericity;
		public double? prismEccentricity;
	}
	
	/// <summary>
	/// This relates the new monument element to a survey - indicating its purpose in the survey and distrubed / replaced info as well
	/// 
	/// 
	/// </summary>
	public class SurveyMonument : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.mntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("mntRef"));
			this.purpose = XsdConverter.Instance.Convert<IList<MonumentPurpose_anonymous>>(attributes.GetSafe("purpose"));
			this.state = XsdConverter.Instance.Convert<MonumentState?>(attributes.GetSafe("state"));
			this.adoptedSurvey = XsdConverter.Instance.Convert<string>(attributes.GetSafe("adoptedSurvey"));
			this.disturbedMonument = XsdConverter.Instance.Convert<string>(attributes.GetSafe("disturbedMonument"));
			this.disturbedDate = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("disturbedDate"));
			this.disturbedAnnotation = XsdConverter.Instance.Convert<string>(attributes.GetSafe("disturbedAnnotation"));
			this.replacedMonument = XsdConverter.Instance.Convert<string>(attributes.GetSafe("replacedMonument"));
			this.replacedDate = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("replacedDate"));
			this.replacedAnnotation = XsdConverter.Instance.Convert<string>(attributes.GetSafe("replacedAnnotation"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("mntRef = ").AppendLine(this.mntRef);
			buff.Append("purpose = ").AppendLine(this.purpose);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("adoptedSurvey = ").AppendLine(this.adoptedSurvey);
			buff.Append("disturbedMonument = ").AppendLine(this.disturbedMonument);
			buff.Append("disturbedDate = ").AppendLine(this.disturbedDate);
			buff.Append("disturbedAnnotation = ").AppendLine(this.disturbedAnnotation);
			buff.Append("replacedMonument = ").AppendLine(this.replacedMonument);
			buff.Append("replacedDate = ").AppendLine(this.replacedDate);
			buff.Append("replacedAnnotation = ").AppendLine(this.replacedAnnotation);
			return buff.ToString();
		}
		/// <summary>
		/// A reference name value referring to monument.name attribute.
		/// 
		/// 
		/// </summary>
		public string mntRef;
		/// <summary>
		/// This indicates the purpose of a monument within a survey
		/// 
		/// 
		/// </summary>
		public IList<MonumentPurpose_anonymous> purpose;
		/// <summary>
		/// Indicates how the mark is sourced for the survey and whether it replaces any other marks
		/// 
		/// 
		/// </summary>
		public MonumentState? state;
		public string adoptedSurvey;
		public string disturbedMonument;
		public DateTime? disturbedDate;
		public string disturbedAnnotation;
		public string replacedMonument;
		public DateTime? replacedDate;
		public string replacedAnnotation;
	}
	
	/// <summary>
	/// The Instrument setup location is defined by either a coordinate text value ("north east" or "north east elev") or a CgPoint number reference "pntRef" attribute.
	/// 
	/// 
	/// </summary>
	public class InstrumentSetup : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.instrumentDetailsID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("instrumentDetailsID"));
			this.stationName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("stationName"));
			this.instrumentHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("instrumentHeight"));
			this.orientationAzimuth = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("orientationAzimuth"));
			this.circleAzimuth = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("circleAzimuth"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("instrumentDetailsID = ").AppendLine(this.instrumentDetailsID);
			buff.Append("stationName = ").AppendLine(this.stationName);
			buff.Append("instrumentHeight = ").AppendLine(this.instrumentHeight);
			buff.Append("orientationAzimuth = ").AppendLine(this.orientationAzimuth);
			buff.Append("circleAzimuth = ").AppendLine(this.circleAzimuth);
			return buff.ToString();
		}
		public string id;
		public string instrumentDetailsID;
		public string stationName;
		public double instrumentHeight;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? orientationAzimuth;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? circleAzimuth;
	}
	
	public class LaserSetup : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.stationName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("stationName"));
			this.instrumentHeight = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("instrumentHeight"));
			this.laserDetailsID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("laserDetailsID"));
			this.magDeclination = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("magDeclination"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("stationName = ").AppendLine(this.stationName);
			buff.Append("instrumentHeight = ").AppendLine(this.instrumentHeight);
			buff.Append("laserDetailsID = ").AppendLine(this.laserDetailsID);
			buff.Append("magDeclination = ").AppendLine(this.magDeclination);
			return buff.ToString();
		}
		public string id;
		public string stationName;
		public double? instrumentHeight;
		public string laserDetailsID;
		public double? magDeclination;
	}
	
	public class GPSSetup : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.antennaHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("antennaHeight"));
			this.stationName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("stationName"));
			this.gPSAntennaDetailsID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("GPSAntennaDetailsID"));
			this.gPSReceiverDetailsID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("GPSReceiverDetailsID"));
			this.observationDataLink = XsdConverter.Instance.Convert<string>(attributes.GetSafe("observationDataLink"));
			this.stationDescription = XsdConverter.Instance.Convert<string>(attributes.GetSafe("stationDescription"));
			this.startTime = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("startTime"));
			this.stopTime = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("stopTime"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("antennaHeight = ").AppendLine(this.antennaHeight);
			buff.Append("stationName = ").AppendLine(this.stationName);
			buff.Append("gPSAntennaDetailsID = ").AppendLine(this.gPSAntennaDetailsID);
			buff.Append("gPSReceiverDetailsID = ").AppendLine(this.gPSReceiverDetailsID);
			buff.Append("observationDataLink = ").AppendLine(this.observationDataLink);
			buff.Append("stationDescription = ").AppendLine(this.stationDescription);
			buff.Append("startTime = ").AppendLine(this.startTime);
			buff.Append("stopTime = ").AppendLine(this.stopTime);
			return buff.ToString();
		}
		public string id;
		public double antennaHeight;
		public string stationName;
		public string gPSAntennaDetailsID;
		public string gPSReceiverDetailsID;
		public string observationDataLink;
		public string stationDescription;
		/// <summary>
		///  GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week.
		/// 
		/// 
		/// </summary>
		public double? startTime;
		/// <summary>
		///  GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week.
		/// 
		/// 
		/// </summary>
		public double? stopTime;
	}
	
	public class TargetSetup : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.targetHeight = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("targetHeight"));
			this.edmTargetVertOffset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("edmTargetVertOffset"));
			this.prismConstant = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("prismConstant"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("targetHeight = ").AppendLine(this.targetHeight);
			buff.Append("edmTargetVertOffset = ").AppendLine(this.edmTargetVertOffset);
			buff.Append("prismConstant = ").AppendLine(this.prismConstant);
			return buff.ToString();
		}
		public string id;
		public double? targetHeight;
		public double? edmTargetVertOffset;
		public double? prismConstant;
	}
	
	public class Backsight : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.azimuth = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("azimuth"));
			this.targetHeight = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("targetHeight"));
			this.circle = XsdConverter.Instance.Convert<double>(attributes.GetSafe("circle"));
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("azimuth = ").AppendLine(this.azimuth);
			buff.Append("targetHeight = ").AppendLine(this.targetHeight);
			buff.Append("circle = ").AppendLine(this.circle);
			buff.Append("setupID = ").AppendLine(this.setupID);
			return buff.ToString();
		}
		public string id;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? azimuth;
		public double? targetHeight;
		/// <summary>
		/// Represents a normalized angular value in the specified Angular units.
		/// 
		/// 
		/// </summary>
		public double circle;
		public string setupID;
	}
	
	public class RawObservation : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.targetSetupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("targetSetupID"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.purpose = XsdConverter.Instance.Convert<PurposeType?>(attributes.GetSafe("purpose"));
			this.targetHeight = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("targetHeight"));
			this.horizAngle = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("horizAngle"));
			this.slopeDistance = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("slopeDistance"));
			this.zenithAngle = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("zenithAngle"));
			this.horizDistance = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("horizDistance"));
			this.vertDistance = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("vertDistance"));
			this.azimuth = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("azimuth"));
			this.unused = XsdConverter.Instance.Convert<bool?>(attributes.GetSafe("unused"));
			this.directFace = XsdConverter.Instance.Convert<bool?>(attributes.GetSafe("directFace"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			this.timeStamp = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("timeStamp"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("setupID = ").AppendLine(this.setupID);
			buff.Append("targetSetupID = ").AppendLine(this.targetSetupID);
			buff.Append("setID = ").AppendLine(this.setID);
			buff.Append("purpose = ").AppendLine(this.purpose);
			buff.Append("targetHeight = ").AppendLine(this.targetHeight);
			buff.Append("horizAngle = ").AppendLine(this.horizAngle);
			buff.Append("slopeDistance = ").AppendLine(this.slopeDistance);
			buff.Append("zenithAngle = ").AppendLine(this.zenithAngle);
			buff.Append("horizDistance = ").AppendLine(this.horizDistance);
			buff.Append("vertDistance = ").AppendLine(this.vertDistance);
			buff.Append("azimuth = ").AppendLine(this.azimuth);
			buff.Append("unused = ").AppendLine(this.unused);
			buff.Append("directFace = ").AppendLine(this.directFace);
			buff.Append("coordGeomRefs = ").AppendLine(this.coordGeomRefs);
			buff.Append("timeStamp = ").AppendLine(this.timeStamp);
			return buff.ToString();
		}
		public string setupID;
		public string targetSetupID;
		public string setID;
		/// <summary>
		/// Used by many of the Survey elements
		/// 
		/// 
		/// </summary>
		public PurposeType? purpose;
		public double? targetHeight;
		/// <summary>
		/// Represents a normalized angular value in the specified Angular units.
		/// 
		/// 
		/// </summary>
		public double? horizAngle;
		public double? slopeDistance;
		/// <summary>
		/// Represents a normalized angular value in the specified Angular units.
		/// 
		/// 
		/// </summary>
		public double? zenithAngle;
		public double? horizDistance;
		public double? vertDistance;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? azimuth;
		public bool? unused;
		public bool? directFace;
		/// <summary>
		/// A list of reference names values refering to one or more CoordGeom.name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> coordGeomRefs;
		public DateTime? timeStamp;
	}
	
	/// <summary>
	/// offsetInOut:   -ve = offset in towards inst, +ve = offset away from inst 
	/// 
	/// offsetLeftRight:   -ve = left, +ve = right (as viewed from instrument) 
	/// 
	/// offsetUpDown:   -ve = down, +ve = up
	/// 
	/// 
	/// </summary>
	public class OffsetVals : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.offsetInOut = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("offsetInOut"));
			this.offsetLeftRight = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("offsetLeftRight"));
			this.offsetUpDown = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("offsetUpDown"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("offsetInOut = ").AppendLine(this.offsetInOut);
			buff.Append("offsetLeftRight = ").AppendLine(this.offsetLeftRight);
			buff.Append("offsetUpDown = ").AppendLine(this.offsetUpDown);
			return buff.ToString();
		}
		public double? offsetInOut;
		public double? offsetLeftRight;
		public double? offsetUpDown;
	}
	
	public class GPSVector : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.dX = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dX"));
			this.dY = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dY"));
			this.dZ = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dZ"));
			this.setupID_A = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID_A"));
			this.setupID_B = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID_B"));
			this.startTime = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("startTime"));
			this.endTime = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("endTime"));
			this.horizontalPrecision = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("horizontalPrecision"));
			this.verticalPrecision = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("verticalPrecision"));
			this.purpose = XsdConverter.Instance.Convert<PurposeType?>(attributes.GetSafe("purpose"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.solutionDataLink = XsdConverter.Instance.Convert<string>(attributes.GetSafe("solutionDataLink"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("dX = ").AppendLine(this.dX);
			buff.Append("dY = ").AppendLine(this.dY);
			buff.Append("dZ = ").AppendLine(this.dZ);
			buff.Append("setupID_A = ").AppendLine(this.setupID_A);
			buff.Append("setupID_B = ").AppendLine(this.setupID_B);
			buff.Append("startTime = ").AppendLine(this.startTime);
			buff.Append("endTime = ").AppendLine(this.endTime);
			buff.Append("horizontalPrecision = ").AppendLine(this.horizontalPrecision);
			buff.Append("verticalPrecision = ").AppendLine(this.verticalPrecision);
			buff.Append("purpose = ").AppendLine(this.purpose);
			buff.Append("setID = ").AppendLine(this.setID);
			buff.Append("solutionDataLink = ").AppendLine(this.solutionDataLink);
			buff.Append("coordGeomRefs = ").AppendLine(this.coordGeomRefs);
			return buff.ToString();
		}
		public double dX;
		public double dY;
		public double dZ;
		public string setupID_A;
		public string setupID_B;
		public DateTime? startTime;
		public DateTime? endTime;
		public double? horizontalPrecision;
		public double? verticalPrecision;
		/// <summary>
		/// Used by many of the Survey elements
		/// 
		/// 
		/// </summary>
		public PurposeType? purpose;
		public string setID;
		public string solutionDataLink;
		/// <summary>
		/// A list of reference names values refering to one or more CoordGeom.name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> coordGeomRefs;
	}
	
	public class GPSPosition : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.wgsHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("wgsHeight"));
			this.wgsLatitude = XsdConverter.Instance.Convert<double>(attributes.GetSafe("wgsLatitude"));
			this.wgsLongitude = XsdConverter.Instance.Convert<double>(attributes.GetSafe("wgsLongitude"));
			this.purpose = XsdConverter.Instance.Convert<string>(attributes.GetSafe("purpose"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			this.pntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("pntRef"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("setupID = ").AppendLine(this.setupID);
			buff.Append("setID = ").AppendLine(this.setID);
			buff.Append("wgsHeight = ").AppendLine(this.wgsHeight);
			buff.Append("wgsLatitude = ").AppendLine(this.wgsLatitude);
			buff.Append("wgsLongitude = ").AppendLine(this.wgsLongitude);
			buff.Append("purpose = ").AppendLine(this.purpose);
			buff.Append("coordGeomRefs = ").AppendLine(this.coordGeomRefs);
			buff.Append("pntRef = ").AppendLine(this.pntRef);
			return buff.ToString();
		}
		public string setupID;
		public string setID;
		public double wgsHeight;
		public double wgsLatitude;
		public double wgsLongitude;
		public string purpose;
		/// <summary>
		/// A list of reference names values refering to one or more CoordGeom.name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> coordGeomRefs;
		/// <summary>
		/// A reference name value referring to a PointType derived name attribute. An attribute if this type contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data.
		/// 
		/// 
		/// </summary>
		public string pntRef;
	}
	
	/// <summary>
	/// GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week  			
	/// 
	/// 
	/// </summary>
	public class GPSQCInfoLevel1 : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.gPSSolnType = XsdConverter.Instance.Convert<GPSSolutionTypeEnum?>(attributes.GetSafe("GPSSolnType"));
			this.gPSSolnFreq = XsdConverter.Instance.Convert<GPSSolutionFrequencyEnum?>(attributes.GetSafe("GPSSolnFreq"));
			this.nbrSatellites = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("nbrSatellites"));
			this.rDOP = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("RDOP"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("gPSSolnType = ").AppendLine(this.gPSSolnType);
			buff.Append("gPSSolnFreq = ").AppendLine(this.gPSSolnFreq);
			buff.Append("nbrSatellites = ").AppendLine(this.nbrSatellites);
			buff.Append("rDOP = ").AppendLine(this.rDOP);
			return buff.ToString();
		}
		/// <summary>
		/// The GPS solution type indicates the type of computed solution for a GPS vector or position
		/// 
		/// 
		/// </summary>
		public GPSSolutionTypeEnum? gPSSolnType;
		/// <summary>
		/// The GPS solution frequency indicates the GPS frequencies used in the computed solution for a GPS vector or position 
		/// 
		/// 
		/// </summary>
		public GPSSolutionFrequencyEnum? gPSSolnFreq;
		public int? nbrSatellites;
		public double? rDOP;
	}
	
	public class GPSQCInfoLevel2 : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.covarianceXX = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("covarianceXX"));
			this.covarianceXY = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("covarianceXY"));
			this.covarianceXZ = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("covarianceXZ"));
			this.covarianceYY = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("covarianceYY"));
			this.covarianceYZ = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("covarianceYZ"));
			this.covarianceZZ = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("covarianceZZ"));
			this.gPSSolnType = XsdConverter.Instance.Convert<GPSSolutionTypeEnum?>(attributes.GetSafe("GPSSolnType"));
			this.gPSSolnFreq = XsdConverter.Instance.Convert<GPSSolutionFrequencyEnum?>(attributes.GetSafe("GPSSolnFreq"));
			this.rMS = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("RMS"));
			this.ratio = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("ratio"));
			this.referenceVariance = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("referenceVariance"));
			this.nbrSatellites = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("nbrSatellites"));
			this.startTime = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("startTime"));
			this.stopTime = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("stopTime"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("covarianceXX = ").AppendLine(this.covarianceXX);
			buff.Append("covarianceXY = ").AppendLine(this.covarianceXY);
			buff.Append("covarianceXZ = ").AppendLine(this.covarianceXZ);
			buff.Append("covarianceYY = ").AppendLine(this.covarianceYY);
			buff.Append("covarianceYZ = ").AppendLine(this.covarianceYZ);
			buff.Append("covarianceZZ = ").AppendLine(this.covarianceZZ);
			buff.Append("gPSSolnType = ").AppendLine(this.gPSSolnType);
			buff.Append("gPSSolnFreq = ").AppendLine(this.gPSSolnFreq);
			buff.Append("rMS = ").AppendLine(this.rMS);
			buff.Append("ratio = ").AppendLine(this.ratio);
			buff.Append("referenceVariance = ").AppendLine(this.referenceVariance);
			buff.Append("nbrSatellites = ").AppendLine(this.nbrSatellites);
			buff.Append("startTime = ").AppendLine(this.startTime);
			buff.Append("stopTime = ").AppendLine(this.stopTime);
			return buff.ToString();
		}
		public double? covarianceXX;
		public double? covarianceXY;
		public double? covarianceXZ;
		public double? covarianceYY;
		public double? covarianceYZ;
		public double? covarianceZZ;
		/// <summary>
		/// The GPS solution type indicates the type of computed solution for a GPS vector or position
		/// 
		/// 
		/// </summary>
		public GPSSolutionTypeEnum? gPSSolnType;
		/// <summary>
		/// The GPS solution frequency indicates the GPS frequencies used in the computed solution for a GPS vector or position 
		/// 
		/// 
		/// </summary>
		public GPSSolutionFrequencyEnum? gPSSolnFreq;
		public double? rMS;
		public double? ratio;
		public double? referenceVariance;
		public int? nbrSatellites;
		/// <summary>
		///  GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week.
		/// 
		/// 
		/// </summary>
		public double? startTime;
		/// <summary>
		///  GPS Time = Nbr of GPS weeks * 604800 (seconds in a week) + seconds in GPS week.
		/// 
		/// 
		/// </summary>
		public double? stopTime;
	}
	
	/// <summary>
	/// All observations to the same point in a group should be averaged together (they have consistant orientation)
	/// 
	/// 
	/// </summary>
	public class ObservationGroup : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.purpose = XsdConverter.Instance.Convert<PurposeType?>(attributes.GetSafe("purpose"));
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.targetSetupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("targetSetupID"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			buff.Append("purpose = ").AppendLine(this.purpose);
			buff.Append("setupID = ").AppendLine(this.setupID);
			buff.Append("targetSetupID = ").AppendLine(this.targetSetupID);
			buff.Append("setID = ").AppendLine(this.setID);
			buff.Append("coordGeomRefs = ").AppendLine(this.coordGeomRefs);
			return buff.ToString();
		}
		public string id;
		/// <summary>
		/// Used by many of the Survey elements
		/// 
		/// 
		/// </summary>
		public PurposeType? purpose;
		public string setupID;
		public string targetSetupID;
		public string setID;
		/// <summary>
		/// A list of reference names values refering to one or more CoordGeom.name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> coordGeomRefs;
	}
	
	/// <summary>
	/// Records check shots to know locations during field observations
	/// 
	/// 
	/// </summary>
	public class ControlChecks : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class PointResults : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.targetSetupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("targetSetupID"));
			this.meanHorizAngle = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("meanHorizAngle"));
			this.horizStdDeviation = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("horizStdDeviation"));
			this.meanzenithAngle = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("meanzenithAngle"));
			this.vertStdDeviation = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("vertStdDeviation"));
			this.meanSlopeDistance = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("meanSlopeDistance"));
			this.slopeDistanceStdDeviation = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("slopeDistanceStdDeviation"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("setupID = ").AppendLine(this.setupID);
			buff.Append("targetSetupID = ").AppendLine(this.targetSetupID);
			buff.Append("meanHorizAngle = ").AppendLine(this.meanHorizAngle);
			buff.Append("horizStdDeviation = ").AppendLine(this.horizStdDeviation);
			buff.Append("meanzenithAngle = ").AppendLine(this.meanzenithAngle);
			buff.Append("vertStdDeviation = ").AppendLine(this.vertStdDeviation);
			buff.Append("meanSlopeDistance = ").AppendLine(this.meanSlopeDistance);
			buff.Append("slopeDistanceStdDeviation = ").AppendLine(this.slopeDistanceStdDeviation);
			return buff.ToString();
		}
		public string setupID;
		public string targetSetupID;
		public double? meanHorizAngle;
		public double? horizStdDeviation;
		public double? meanzenithAngle;
		public double? vertStdDeviation;
		public double? meanSlopeDistance;
		public double? slopeDistanceStdDeviation;
	}
	
	/// <summary>
	/// This has been modified to include new fields such as accuracy, date, class and adoption. I've added in bearing (azimuth is in terms of true north whereas bearing is the projection north) 
	/// 
	///  - maybe this doesn't matter, may need to discuss
	/// 
	/// 
	/// </summary>
	public class ReducedObservation : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.purpose = XsdConverter.Instance.Convert<PurposeType?>(attributes.GetSafe("purpose"));
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.targetSetupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("targetSetupID"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.targetHeight = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("targetHeight"));
			this.azimuth = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("azimuth"));
			this.horizDistance = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("horizDistance"));
			this.vertDistance = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("vertDistance"));
			this.horizAngle = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("horizAngle"));
			this.slopeDistance = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("slopeDistance"));
			this.zenithAngle = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("zenithAngle"));
			this.equipmentUsed = XsdConverter.Instance.Convert<EquipmentType?>(attributes.GetSafe("equipmentUsed"));
			this.azimuthAccuracy = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("azimuthAccuracy"));
			this.distanceAccuracy = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("distanceAccuracy"));
			this.date = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("date"));
			this.distanceType = XsdConverter.Instance.Convert<ObservationType?>(attributes.GetSafe("distanceType"));
			this.azimuthType = XsdConverter.Instance.Convert<ObservationType?>(attributes.GetSafe("azimuthType"));
			this.adoptedAzimuthSurvey = XsdConverter.Instance.Convert<string>(attributes.GetSafe("adoptedAzimuthSurvey"));
			this.adoptedDistanceSurvey = XsdConverter.Instance.Convert<string>(attributes.GetSafe("adoptedDistanceSurvey"));
			this.distanceAccClass = XsdConverter.Instance.Convert<string>(attributes.GetSafe("distanceAccClass"));
			this.azimuthAccClass = XsdConverter.Instance.Convert<string>(attributes.GetSafe("azimuthAccClass"));
			this.azimuthAdoptionFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("azimuthAdoptionFactor"));
			this.distanceAdoptionFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("distanceAdoptionFactor"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("purpose = ").AppendLine(this.purpose);
			buff.Append("setupID = ").AppendLine(this.setupID);
			buff.Append("targetSetupID = ").AppendLine(this.targetSetupID);
			buff.Append("setID = ").AppendLine(this.setID);
			buff.Append("targetHeight = ").AppendLine(this.targetHeight);
			buff.Append("azimuth = ").AppendLine(this.azimuth);
			buff.Append("horizDistance = ").AppendLine(this.horizDistance);
			buff.Append("vertDistance = ").AppendLine(this.vertDistance);
			buff.Append("horizAngle = ").AppendLine(this.horizAngle);
			buff.Append("slopeDistance = ").AppendLine(this.slopeDistance);
			buff.Append("zenithAngle = ").AppendLine(this.zenithAngle);
			buff.Append("equipmentUsed = ").AppendLine(this.equipmentUsed);
			buff.Append("azimuthAccuracy = ").AppendLine(this.azimuthAccuracy);
			buff.Append("distanceAccuracy = ").AppendLine(this.distanceAccuracy);
			buff.Append("date = ").AppendLine(this.date);
			buff.Append("distanceType = ").AppendLine(this.distanceType);
			buff.Append("azimuthType = ").AppendLine(this.azimuthType);
			buff.Append("adoptedAzimuthSurvey = ").AppendLine(this.adoptedAzimuthSurvey);
			buff.Append("adoptedDistanceSurvey = ").AppendLine(this.adoptedDistanceSurvey);
			buff.Append("distanceAccClass = ").AppendLine(this.distanceAccClass);
			buff.Append("azimuthAccClass = ").AppendLine(this.azimuthAccClass);
			buff.Append("azimuthAdoptionFactor = ").AppendLine(this.azimuthAdoptionFactor);
			buff.Append("distanceAdoptionFactor = ").AppendLine(this.distanceAdoptionFactor);
			buff.Append("coordGeomRefs = ").AppendLine(this.coordGeomRefs);
			return buff.ToString();
		}
		/// <summary>
		/// Used by many of the Survey elements
		/// 
		/// 
		/// </summary>
		public PurposeType? purpose;
		public string setupID;
		public string targetSetupID;
		public string setID;
		public double? targetHeight;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? azimuth;
		public double? horizDistance;
		public double? vertDistance;
		/// <summary>
		/// Represents a normalized angular value in the specified Angular units.
		/// 
		/// 
		/// </summary>
		public double? horizAngle;
		public double? slopeDistance;
		/// <summary>
		/// Represents a normalized angular value in the specified Angular units.
		/// 
		/// 
		/// </summary>
		public double? zenithAngle;
		/// <summary>
		/// This is a rough indication of the type of equipment
		/// 
		/// 
		/// </summary>
		public EquipmentType? equipmentUsed;
		public double? azimuthAccuracy;
		public double? distanceAccuracy;
		public DateTime? date;
		/// <summary>
		/// This enumeration indicates whether the reduced observation information provided was actually measured (observed), calculated or deduced from observations, or adopted from another survey
		/// 
		/// 
		/// </summary>
		public ObservationType? distanceType;
		/// <summary>
		/// This enumeration indicates whether the reduced observation information provided was actually measured (observed), calculated or deduced from observations, or adopted from another survey
		/// 
		/// 
		/// </summary>
		public ObservationType? azimuthType;
		public string adoptedAzimuthSurvey;
		public string adoptedDistanceSurvey;
		public string distanceAccClass;
		public string azimuthAccClass;
		public double? azimuthAdoptionFactor;
		public double? distanceAdoptionFactor;
		/// <summary>
		/// A list of reference names values refering to one or more CoordGeom.name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> coordGeomRefs;
	}
	
	/// <summary>
	/// As we discussed this element is used to provide measured information for calculating boundary arcs. The definition information required is quite different to the curve element
	/// 
	/// 
	/// </summary>
	public class ReducedArcObservation : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.purpose = XsdConverter.Instance.Convert<PurposeType?>(attributes.GetSafe("purpose"));
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.targetSetupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("targetSetupID"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.chordAzimuth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("chordAzimuth"));
			this.radius = XsdConverter.Instance.Convert<double>(attributes.GetSafe("radius"));
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.rot = XsdConverter.Instance.Convert<Clockwise>(attributes.GetSafe("rot"));
			this.equipmentUsed = XsdConverter.Instance.Convert<EquipmentType?>(attributes.GetSafe("equipmentUsed"));
			this.arcAzimuthAccuracy = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("arcAzimuthAccuracy"));
			this.arcLengthAccuracy = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("arcLengthAccuracy"));
			this.date = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("date"));
			this.arcType = XsdConverter.Instance.Convert<ObservationType?>(attributes.GetSafe("arcType"));
			this.adoptedSurvey = XsdConverter.Instance.Convert<string>(attributes.GetSafe("adoptedSurvey"));
			this.lengthAccClass = XsdConverter.Instance.Convert<string>(attributes.GetSafe("lengthAccClass"));
			this.azimuthAccClass = XsdConverter.Instance.Convert<string>(attributes.GetSafe("azimuthAccClass"));
			this.azimuthAdoptionFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("azimuthAdoptionFactor"));
			this.lengthAdoptionFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("lengthAdoptionFactor"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("purpose = ").AppendLine(this.purpose);
			buff.Append("setupID = ").AppendLine(this.setupID);
			buff.Append("targetSetupID = ").AppendLine(this.targetSetupID);
			buff.Append("setID = ").AppendLine(this.setID);
			buff.Append("chordAzimuth = ").AppendLine(this.chordAzimuth);
			buff.Append("radius = ").AppendLine(this.radius);
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("rot = ").AppendLine(this.rot);
			buff.Append("equipmentUsed = ").AppendLine(this.equipmentUsed);
			buff.Append("arcAzimuthAccuracy = ").AppendLine(this.arcAzimuthAccuracy);
			buff.Append("arcLengthAccuracy = ").AppendLine(this.arcLengthAccuracy);
			buff.Append("date = ").AppendLine(this.date);
			buff.Append("arcType = ").AppendLine(this.arcType);
			buff.Append("adoptedSurvey = ").AppendLine(this.adoptedSurvey);
			buff.Append("lengthAccClass = ").AppendLine(this.lengthAccClass);
			buff.Append("azimuthAccClass = ").AppendLine(this.azimuthAccClass);
			buff.Append("azimuthAdoptionFactor = ").AppendLine(this.azimuthAdoptionFactor);
			buff.Append("lengthAdoptionFactor = ").AppendLine(this.lengthAdoptionFactor);
			buff.Append("coordGeomRefs = ").AppendLine(this.coordGeomRefs);
			return buff.ToString();
		}
		/// <summary>
		/// Used by many of the Survey elements
		/// 
		/// 
		/// </summary>
		public PurposeType? purpose;
		public string setupID;
		public string targetSetupID;
		public string setID;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double chordAzimuth;
		public double radius;
		public double length;
		public Clockwise rot;
		/// <summary>
		/// This is a rough indication of the type of equipment
		/// 
		/// 
		/// </summary>
		public EquipmentType? equipmentUsed;
		public double? arcAzimuthAccuracy;
		public double? arcLengthAccuracy;
		public DateTime? date;
		/// <summary>
		/// This enumeration indicates whether the reduced observation information provided was actually measured (observed), calculated or deduced from observations, or adopted from another survey
		/// 
		/// 
		/// </summary>
		public ObservationType? arcType;
		public string adoptedSurvey;
		public string lengthAccClass;
		public string azimuthAccClass;
		public double? azimuthAdoptionFactor;
		public double? lengthAdoptionFactor;
		/// <summary>
		/// A list of reference names values refering to one or more CoordGeom.name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> coordGeomRefs;
	}
	
	/// <summary>
	/// This list of monuments allows them to be grouped at a file level like parcels and points etc
	/// 
	/// 
	/// </summary>
	public class Monuments : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// This is a new element that represents a physical monument placed to mark a CgPoint within a survey
	/// 
	/// 
	/// </summary>
	public class Monument : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.pntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("pntRef"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.type = XsdConverter.Instance.Convert<MonumentType?>(attributes.GetSafe("type"));
			this.condition = XsdConverter.Instance.Convert<MonumentCondition?>(attributes.GetSafe("condition"));
			this.category = XsdConverter.Instance.Convert<MonumentCategory?>(attributes.GetSafe("category"));
			this.beacon = XsdConverter.Instance.Convert<BeaconType?>(attributes.GetSafe("beacon"));
			this.beaconProtection = XsdConverter.Instance.Convert<BeaconProtectionType?>(attributes.GetSafe("beaconProtection"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("pntRef = ").AppendLine(this.pntRef);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("type = ").AppendLine(this.type);
			buff.Append("condition = ").AppendLine(this.condition);
			buff.Append("category = ").AppendLine(this.category);
			buff.Append("beacon = ").AppendLine(this.beacon);
			buff.Append("beaconProtection = ").AppendLine(this.beaconProtection);
			buff.Append("oID = ").AppendLine(this.oID);
			return buff.ToString();
		}
		public string name;
		/// <summary>
		/// A reference name value referring to a PointType derived name attribute. An attribute if this type contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data.
		/// 
		/// 
		/// </summary>
		public string pntRef;
		public string desc;
		public StateType? state;
		/// <summary>
		/// This indicates the material makeup of the Monument
		/// 
		/// 
		/// </summary>
		public MonumentType? type;
		/// <summary>
		/// This gives a general indication of the condition of the monument
		/// 
		/// 
		/// </summary>
		public MonumentCondition? condition;
		/// <summary>
		/// This indicates the category of a geodetic Monument
		/// 
		/// 
		/// </summary>
		public MonumentCategory? category;
		/// <summary>
		/// Indicates whether there is any physical structure
		/// 			for the monument - helps location, these enumerations may need expanding
		/// 			
		/// 
		/// 
		/// </summary>
		public BeaconType? beacon;
		/// <summary>
		/// Indicates any structure that protects the
		/// 		monument, these enumerations may need expanding
		/// 
		/// 
		/// </summary>
		public BeaconProtectionType? beaconProtection;
		public string oID;
	}
	
	/// <summary>
	/// A collection of surface models.
	/// 
	/// 
	/// </summary>
	public class Surfaces : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// SourceData is an optional collection of the points, contours, breaklines and boundaries that were used to create the surface.
	/// 
	/// Definition is a collection of points and faces that define the surface.
	/// 
	/// Watersheds is a collection the watershed boundaries for the surface.
	/// 
	/// 
	/// </summary>
	public class Surface : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("OID"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("oID = ").AppendLine(this.oID);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public string oID;
		public StateType? state;
	}
	
	/// <summary>
	/// The collection of data that was used to create the surface.
	/// 
	/// 
	/// </summary>
	public class SourceData : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	/// <summary>
	/// The sub element PntList3D is group of points is defined by a 3D
	/// 	north/east/elev list of points that define the geometry.
	/// 
	/// 
	/// </summary>
	public class DataPoints : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.pntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("pntRef"));
			this.pointGeometry = XsdConverter.Instance.Convert<PointGeometryType?>(attributes.GetSafe("pointGeometry"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType?>(attributes.GetSafe("DTMAttribute"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("code = ").AppendLine(this.code);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("pntRef = ").AppendLine(this.pntRef);
			buff.Append("pointGeometry = ").AppendLine(this.pointGeometry);
			buff.Append("dTMAttribute = ").AppendLine(this.dTMAttribute);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public string code;
		public StateType? state;
		/// <summary>
		/// A reference name value referring to a PointType derived name attribute. An attribute if this type contains the value of a PointType derived element "name" attribute that exists elsewhere the instance data.
		/// 
		/// 
		/// </summary>
		public string pntRef;
		public PointGeometryType? pointGeometry;
		public DTMAttributeType? dTMAttribute;
	}
	
	/// <summary>
	/// The collection of external point files that were used to define the surface.
	/// 
	/// Use is optional.
	/// 
	/// 
	/// </summary>
	public class PointFiles : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	/// <summary>
	/// A reference to an external file containing point information.
	/// 
	/// The format of the information is defined by the order and delimeter attributes.
	/// 
	/// 
	/// </summary>
	public class PointFile : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.fileName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("fileName"));
			this.fileType = XsdConverter.Instance.Convert<string>(attributes.GetSafe("fileType"));
			this.fileFormat = XsdConverter.Instance.Convert<string>(attributes.GetSafe("fileFormat"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("fileName = ").AppendLine(this.fileName);
			buff.Append("fileType = ").AppendLine(this.fileType);
			buff.Append("fileFormat = ").AppendLine(this.fileFormat);
			return buff.ToString();
		}
		public string fileName;
		public string fileType;
		public string fileFormat;
	}
	
	/// <summary>
	/// The collection of boundaries that were used to define the surface.
	/// 
	/// Use is optional.
	/// 
	/// 
	/// </summary>
	public class Boundaries : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	/// <summary>
	/// The boundary region contains a 2D north/east or 3D north/east/elev list of points that define the geometry.
	/// 
	/// is identified by the "name" attribute.
	/// 
	/// If the "edgeTrim" attribute is true the faces are trimmed at the boundary edge, otherwise faces are not trimmed
	/// 
	/// and must exist entirely within the boundary.
	/// 
	/// 
	/// </summary>
	public class Boundary : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.bndType = XsdConverter.Instance.Convert<SurfBndType>(attributes.GetSafe("bndType"));
			this.edgeTrim = XsdConverter.Instance.Convert<bool>(attributes.GetSafe("edgeTrim"));
			this.area = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("area"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("bndType = ").AppendLine(this.bndType);
			buff.Append("edgeTrim = ").AppendLine(this.edgeTrim);
			buff.Append("area = ").AppendLine(this.area);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		/// <summary>
		/// Surface boundaries can be one of three types: outer, void, island
		/// 
		/// 
		/// </summary>
		public SurfBndType bndType;
		public bool edgeTrim;
		public double? area;
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// The collection of breaklines that were used to define the surface.
	/// 
	/// Use is optional.
	/// 
	/// 
	/// </summary>
	public class Breaklines : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	/// <summary>
	/// The breakline is defined by a 2D north/east or 3D north/east/elev list of points that define the geometry.
	/// 
	/// is identified by the "name" attribute.
	/// 
	/// 
	/// </summary>
	public class Breakline : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.brkType = XsdConverter.Instance.Convert<string>(attributes.GetSafe("brkType"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("brkType = ").AppendLine(this.brkType);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string brkType;
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// The retaining wall is defined by a sequential collection of points along the wall.
	/// 
	/// Each point has a location (northing/easting/elevation),  height of wall and offset to the wall point.
	/// 
	/// 
	/// </summary>
	public class RetWall : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// A retaining wall point defined by a space delimited "northing easting elevation" text value with height and offset attributes to define the wall point
	/// 
	/// The height value is positive if the northing/easting/elevation point is at the bottom of the wall, negative if the point is at the top of the wall.
	/// 
	/// The offset value is negative for left and positive for right.
	/// 
	/// 
	/// </summary>
	public class RetWallPnt : PointType3dReq
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.height = XsdConverter.Instance.Convert<double>(attributes.GetSafe("height"));
			this.offset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("offset"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("height = ").AppendLine(this.height);
			buff.Append("offset = ").AppendLine(this.offset);
			return buff.ToString();
		}
		public double height;
		public double offset;
	}
	
	/// <summary>
	/// The collection of contours that were used to define the surface.
	/// 
	/// 
	/// </summary>
	public class Contours : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	/// <summary>
	/// The contour is defined by an elevation attribute and a 2D north/east list of points that define the geometry.
	/// 
	/// is identified by the "name" attribute.
	/// 
	/// 
	/// </summary>
	public class Contour : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.elev = XsdConverter.Instance.Convert<double>(attributes.GetSafe("elev"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("elev = ").AppendLine(this.elev);
			return buff.ToString();
		}
		public double elev;
	}
	
	/// <summary>
	/// The collection of faces and points that defined the surface.
	/// 
	/// 
	/// </summary>
	public class Definition : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.surfType = XsdConverter.Instance.Convert<SurfTypeEnum>(attributes.GetSafe("surfType"));
			this.area2DSurf = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("area2DSurf"));
			this.area3DSurf = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("area3DSurf"));
			this.elevMax = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("elevMax"));
			this.elevMin = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("elevMin"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("surfType = ").AppendLine(this.surfType);
			buff.Append("area2DSurf = ").AppendLine(this.area2DSurf);
			buff.Append("area3DSurf = ").AppendLine(this.area3DSurf);
			buff.Append("elevMax = ").AppendLine(this.elevMax);
			buff.Append("elevMin = ").AppendLine(this.elevMin);
			return buff.ToString();
		}
		/// <summary>
		/// TIN is the acronym for "triangulated irregular network", a surface comprised of 3 point faces
		/// 
		/// grid is a surface comprised of 4 point faces.
		/// 
		/// 
		/// </summary>
		public SurfTypeEnum surfType;
		public double? area2DSurf;
		public double? area3DSurf;
		public double? elevMax;
		public double? elevMin;
	}
	
	/// <summary>
	/// The collection of points that defined the surface. The "P" point id values are unique per surface.
	/// 
	/// The id values are referenced by the surface faces and breaklines.
	/// 
	/// 
	/// </summary>
	public class Pnts : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	/// <summary>
	/// A surface point. it contains an id attribute and a space delimited "northing easting elevation" text value.
	/// 
	/// The id values are referenced by the surface faces for the coordinate values.
	/// 
	/// 
	/// </summary>
	public class P : PointType
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<uint>(attributes.GetSafe("id"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("id = ").AppendLine(this.id);
			return buff.ToString();
		}
		public uint id;
	}
	
	/// <summary>
	/// The collection of faces that defined the surface.
	/// 
	/// The faces are defined by either 3 (TIN) or 4 (grid) points, as indicated by the "surfType" attribute
	/// 
	/// For the north/east/elev values, each point of the face references a "P"point element point in the SurfPnts collection.
	/// 
	/// 
	/// </summary>
	public class Faces : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// The collection of watershed regions for the surface.
	/// 
	/// 
	/// </summary>
	public class Watersheds : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	/// <summary>
	/// The watershed region contains a 2D north/east or 3D north/east/elev list of points that define the boundary.
	/// 
	/// A watershed is identified by the "name" attribute.
	/// 
	/// It may have 1 or more Outlet elements.
	/// 
	/// 
	/// </summary>
	public class Watershed : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.area = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("area"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("area = ").AppendLine(this.area);
			buff.Append("desc = ").AppendLine(this.desc);
			return buff.ToString();
		}
		public string name;
		public double? area;
		public string desc;
	}
	
	/// <summary>
	/// Identifies a drain point from the watershed with a space delimited "northing easting elevation" value.
	/// 
	/// If it drains to another known watershed, then the name of that watershed is identified by the "refWs" attribute.
	/// 
	/// 
	/// </summary>
	public class Outlet : PointType3dReq
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.refWS = XsdConverter.Instance.Convert<string>(attributes.GetSafe("refWS"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("refWS = ").AppendLine(this.refWS);
			return buff.ToString();
		}
		/// <summary>
		/// A reference name value referring to WaterShed.name attribute.
		/// 
		/// 
		/// </summary>
		public string refWS;
	}
	
	/// <summary>
	/// A collection of surface volume data
	/// 
	/// 
	/// </summary>
	public class SurfVolumes : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.surfVolCalcMethod = XsdConverter.Instance.Convert<SurfVolCMethodType>(attributes.GetSafe("surfVolCalcMethod"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("surfVolCalcMethod = ").AppendLine(this.surfVolCalcMethod);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public SurfVolCMethodType surfVolCalcMethod;
	}
	
	/// <summary>
	/// volume calculation results between two surfaces
	/// 
	/// 
	/// </summary>
	public class SurfVolume : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.surfBase = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surfBase"));
			this.surfCompare = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surfCompare"));
			this.volCut = XsdConverter.Instance.Convert<double>(attributes.GetSafe("volCut"));
			this.volFill = XsdConverter.Instance.Convert<double>(attributes.GetSafe("volFill"));
			this.volTotal = XsdConverter.Instance.Convert<double>(attributes.GetSafe("volTotal"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("surfBase = ").AppendLine(this.surfBase);
			buff.Append("surfCompare = ").AppendLine(this.surfCompare);
			buff.Append("volCut = ").AppendLine(this.volCut);
			buff.Append("volFill = ").AppendLine(this.volFill);
			buff.Append("volTotal = ").AppendLine(this.volTotal);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			return buff.ToString();
		}
		/// <summary>
		/// A reference name value referring to Surface.name attribute.
		/// 
		/// 
		/// </summary>
		public string surfBase;
		/// <summary>
		/// A reference name value referring to Surface.name attribute.
		/// 
		/// 
		/// </summary>
		public string surfCompare;
		public double volCut;
		public double volFill;
		public double volTotal;
		public string desc;
		public string name;
	}
	
	/// <summary>
	/// A collection of Parcels
	/// 
	/// 
	/// </summary>
	public class Parcels : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// Modified to include parcel class and an official ID
	/// 
	/// 
	/// </summary>
	public class Parcel : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.area = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("area"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dirClosure = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("dirClosure"));
			this.distClosure = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("distClosure"));
			this.owner = XsdConverter.Instance.Convert<string>(attributes.GetSafe("owner"));
			this.parcelType = XsdConverter.Instance.Convert<string>(attributes.GetSafe("parcelType"));
			this.setbackFront = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("setbackFront"));
			this.setbackRear = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("setbackRear"));
			this.setbackSide = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("setbackSide"));
			this.state = XsdConverter.Instance.Convert<ParcelStateType?>(attributes.GetSafe("state"));
			this.taxId = XsdConverter.Instance.Convert<string>(attributes.GetSafe("taxId"));
			this.@class = XsdConverter.Instance.Convert<ParcelClass?>(attributes.GetSafe("class"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("oID = ").AppendLine(this.oID);
			buff.Append("area = ").AppendLine(this.area);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("dirClosure = ").AppendLine(this.dirClosure);
			buff.Append("distClosure = ").AppendLine(this.distClosure);
			buff.Append("owner = ").AppendLine(this.owner);
			buff.Append("parcelType = ").AppendLine(this.parcelType);
			buff.Append("setbackFront = ").AppendLine(this.setbackFront);
			buff.Append("setbackRear = ").AppendLine(this.setbackRear);
			buff.Append("setbackSide = ").AppendLine(this.setbackSide);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("taxId = ").AppendLine(this.taxId);
			buff.Append("@class = ").AppendLine(this.@class);
			return buff.ToString();
		}
		public string name;
		public string oID;
		public double? area;
		public string desc;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? dirClosure;
		public double? distClosure;
		public string owner;
		public string parcelType;
		public double? setbackFront;
		public double? setbackRear;
		public double? setbackSide;
		/// <summary>
		/// This is an extension of the LandXML state type, but is specific to parcels
		/// 
		/// 
		/// </summary>
		public ParcelStateType? state;
		public string taxId;
		/// <summary>
		/// The parcel class combines both parcel intent and topology class.
		/// 
		/// 
		/// </summary>
		public ParcelClass? @class;
	}
	
	/// <summary>
	/// This may be expanded, but the LandXML schema is not really aimed at providing title information so I think name is sufficient
	/// 
	/// 
	/// </summary>
	public class Title : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			return buff.ToString();
		}
		public string name;
	}
	
	/// <summary>
	/// A collection of horizontal Alignments
	/// 
	/// 
	/// </summary>
	public class Alignments : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// geometric horizontal alignment, PGL or chain typically representing a road design center line
	/// 
	/// 
	/// </summary>
	public class Alignment : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("oID = ").AppendLine(this.oID);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		public double length;
		public double staStart;
		public string desc;
		public string oID;
		public StateType? state;
	}
	
	/// <summary>
	/// The "staInternal" value identifies the location of the station equation. It is the station value with no equations applied (staStart + dist).
	/// 
	/// 
	/// </summary>
	public class StaEquation : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staAhead = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staAhead"));
			this.staBack = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staBack"));
			this.staInternal = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staInternal"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staAhead = ").AppendLine(this.staAhead);
			buff.Append("staBack = ").AppendLine(this.staBack);
			buff.Append("staInternal = ").AppendLine(this.staInternal);
			buff.Append("desc = ").AppendLine(this.desc);
			return buff.ToString();
		}
		public double staAhead;
		public double? staBack;
		public double staInternal;
		public string desc;
	}
	
	/// <summary>
	/// A profile or long section
	/// 
	/// 
	/// </summary>
	public class Profile : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public double? staStart;
		public StateType? state;
	}
	
	/// <summary>
	/// The "ProfSurf" element will typically represent an existing ground surface for a profile. 
	/// 
	/// It is defined with a space delimited PntList2D of station/elevations pairs. 
	/// 
	/// Example: "0.000 86.52 6.267 86.89 12.413 87.01 26.020 87.83" 
	/// 
	/// Note: Gaps in the profile are handled by having 2 or more PntList2D elements.
	/// 
	/// 
	/// </summary>
	public class ProfSurf : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public StateType? state;
	}
	
	/// <summary>
	/// The "ProfAlign" element will typically represent a proposed vertical alignment for a profile.
	/// 
	/// It is defined by a sequential series of any combination of the four "PVI" element types.
	/// 
	/// 
	/// </summary>
	public class ProfAlign : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public StateType? state;
	}
	
	/// <summary>
	/// Represents a  Point of Vertical Intersection with a space delimited "station elevation" text value
	/// 
	/// 
	/// </summary>
	public class PVI : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.content = XsdConverter.Instance.Convert<IList<double>>(text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("content = ").AppendLine(this.content);
			return buff.ToString();
		}
		public string desc;
		public IList<double> content;
	}
	
	/// <summary>
	/// A  Point of Vertical Intersection with a space delimited "station elevation" text value and a parabolic vertical curve defined by the "length" attribute.
	/// 
	/// 
	/// </summary>
	public class ParaCurve : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.content = XsdConverter.Instance.Convert<IList<double>>(text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("content = ").AppendLine(this.content);
			return buff.ToString();
		}
		public double length;
		public string desc;
		public IList<double> content;
	}
	
	/// <summary>
	/// A  Point of Vertical Intersection with a space delimited "station elevation" text value.
	/// 
	/// with an unsymetrical parabolic vertical curve defined by "lengthIn and "lengthOut" attributes.
	/// 
	/// 
	/// </summary>
	public class UnsymParaCurve : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.lengthIn = XsdConverter.Instance.Convert<double>(attributes.GetSafe("lengthIn"));
			this.lengthOut = XsdConverter.Instance.Convert<double>(attributes.GetSafe("lengthOut"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.content = XsdConverter.Instance.Convert<IList<double>>(text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("lengthIn = ").AppendLine(this.lengthIn);
			buff.Append("lengthOut = ").AppendLine(this.lengthOut);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("content = ").AppendLine(this.content);
			return buff.ToString();
		}
		public double lengthIn;
		public double lengthOut;
		public string desc;
		public IList<double> content;
	}
	
	/// <summary>
	/// A  Point of Vertical Intersection with a space delimited "station elevation" text value
	/// 
	/// with a circular vertical curve defined by "length and "radius" attributes.
	/// 
	/// 
	/// </summary>
	public class CircCurve : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.radius = XsdConverter.Instance.Convert<double>(attributes.GetSafe("radius"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.content = XsdConverter.Instance.Convert<IList<double>>(text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("radius = ").AppendLine(this.radius);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("content = ").AppendLine(this.content);
			return buff.ToString();
		}
		public double length;
		public double radius;
		public string desc;
		public IList<double> content;
	}
	
	public class PipeNetworks : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// This element contains one "Structs" collection element and one "Pipes" collection element.
	/// 
	/// keyRef is a Schema validation mechanism that ensures that the "structRef" and "pipeRef" attribute values have corresponding Pipe and Struct "name" values"
	/// 
	/// 
	/// </summary>
	public class PipeNetwork : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.pipeNetType = XsdConverter.Instance.Convert<PipeNetworkType>(attributes.GetSafe("pipeNetType"));
			this.alignmentRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("alignmentRef"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("pipeNetType = ").AppendLine(this.pipeNetType);
			buff.Append("alignmentRef = ").AppendLine(this.alignmentRef);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("oID = ").AppendLine(this.oID);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		public PipeNetworkType pipeNetType;
		/// <summary>
		/// A reference name value referring to Alignment.name attribute.
		/// 
		/// 
		/// </summary>
		public string alignmentRef;
		public string desc;
		public string oID;
		public StateType? state;
	}
	
	public class Pipes : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	/// <summary>
	/// Each Pipe within a Pipes collection element will have a unique  "name" attribute.
	/// 
	/// The pipe type is determined by the existance of one of the following elements: CircPipe, ElliPipe or RectPipe.
	/// 
	/// The "startRef and "endRef" attributes reference Struct "name" values.
	/// 
	/// The start and end invert elevations for the pipe are defined in the Invert elements of referenced structures.
	/// 
	/// Since a struct may have more than one Invert element, the Invert "pipeRef" attribute is used to select the correct invert element.
	/// 
	/// 
	/// </summary>
	public class Pipe : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.refEnd = XsdConverter.Instance.Convert<string>(attributes.GetSafe("refEnd"));
			this.refStart = XsdConverter.Instance.Convert<string>(attributes.GetSafe("refStart"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.length = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("length"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.slope = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("slope"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("refEnd = ").AppendLine(this.refEnd);
			buff.Append("refStart = ").AppendLine(this.refStart);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("oID = ").AppendLine(this.oID);
			buff.Append("slope = ").AppendLine(this.slope);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		/// <summary>
		/// A reference name value referring to Struct.name attribute.
		/// 
		/// 
		/// </summary>
		public string refEnd;
		/// <summary>
		/// A reference name value referring to Struct.name attribute.
		/// 
		/// 
		/// </summary>
		public string refStart;
		public string desc;
		public double? length;
		public string oID;
		public double? slope;
		public StateType? state;
	}
	
	public class CircPipe : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.diameter = XsdConverter.Instance.Convert<double>(attributes.GetSafe("diameter"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.hazenWilliams = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("hazenWilliams"));
			this.mannings = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("mannings"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("thickness"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("diameter = ").AppendLine(this.diameter);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("hazenWilliams = ").AppendLine(this.hazenWilliams);
			buff.Append("mannings = ").AppendLine(this.mannings);
			buff.Append("material = ").AppendLine(this.material);
			buff.Append("thickness = ").AppendLine(this.thickness);
			return buff.ToString();
		}
		public double diameter;
		public string desc;
		public double? hazenWilliams;
		public double? mannings;
		public string material;
		public double? thickness;
	}
	
	public class ElliPipe : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.height = XsdConverter.Instance.Convert<double>(attributes.GetSafe("height"));
			this.span = XsdConverter.Instance.Convert<double>(attributes.GetSafe("span"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.hazenWilliams = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("hazenWilliams"));
			this.mannings = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("mannings"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("thickness"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("height = ").AppendLine(this.height);
			buff.Append("span = ").AppendLine(this.span);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("hazenWilliams = ").AppendLine(this.hazenWilliams);
			buff.Append("mannings = ").AppendLine(this.mannings);
			buff.Append("material = ").AppendLine(this.material);
			buff.Append("thickness = ").AppendLine(this.thickness);
			return buff.ToString();
		}
		public double height;
		public double span;
		public string desc;
		public double? hazenWilliams;
		public double? mannings;
		public string material;
		public double? thickness;
	}
	
	public class RectPipe : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.height = XsdConverter.Instance.Convert<double>(attributes.GetSafe("height"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.hazenWilliams = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("hazenWilliams"));
			this.mannings = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("mannings"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("thickness"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("height = ").AppendLine(this.height);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("hazenWilliams = ").AppendLine(this.hazenWilliams);
			buff.Append("mannings = ").AppendLine(this.mannings);
			buff.Append("material = ").AppendLine(this.material);
			buff.Append("thickness = ").AppendLine(this.thickness);
			return buff.ToString();
		}
		public double height;
		public double width;
		public string desc;
		public double? hazenWilliams;
		public double? mannings;
		public string material;
		public double? thickness;
	}
	
	public class Channel : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.height = XsdConverter.Instance.Convert<double>(attributes.GetSafe("height"));
			this.widthTop = XsdConverter.Instance.Convert<double>(attributes.GetSafe("widthTop"));
			this.widthBottom = XsdConverter.Instance.Convert<double>(attributes.GetSafe("widthBottom"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.hazenWilliams = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("hazenWilliams"));
			this.mannings = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("mannings"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("thickness"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("height = ").AppendLine(this.height);
			buff.Append("widthTop = ").AppendLine(this.widthTop);
			buff.Append("widthBottom = ").AppendLine(this.widthBottom);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("hazenWilliams = ").AppendLine(this.hazenWilliams);
			buff.Append("mannings = ").AppendLine(this.mannings);
			buff.Append("material = ").AppendLine(this.material);
			buff.Append("thickness = ").AppendLine(this.thickness);
			return buff.ToString();
		}
		public double height;
		public double widthTop;
		public double widthBottom;
		public string desc;
		public double? hazenWilliams;
		public double? mannings;
		public string material;
		public double? thickness;
	}
	
	public class PipeFlow : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.flowIn = XsdConverter.Instance.Convert<double>(attributes.GetSafe("flowIn"));
			this.areaCatchment = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("areaCatchment"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.depthCritical = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("depthCritical"));
			this.hglDown = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("hglDown"));
			this.hglUp = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("hglUp"));
			this.intensity = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("intensity"));
			this.runoffCoeff = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("runoffCoeff"));
			this.slopeCritical = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("slopeCritical"));
			this.timeInlet = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("timeInlet"));
			this.velocityCritical = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("velocityCritical"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("flowIn = ").AppendLine(this.flowIn);
			buff.Append("areaCatchment = ").AppendLine(this.areaCatchment);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("depthCritical = ").AppendLine(this.depthCritical);
			buff.Append("hglDown = ").AppendLine(this.hglDown);
			buff.Append("hglUp = ").AppendLine(this.hglUp);
			buff.Append("intensity = ").AppendLine(this.intensity);
			buff.Append("runoffCoeff = ").AppendLine(this.runoffCoeff);
			buff.Append("slopeCritical = ").AppendLine(this.slopeCritical);
			buff.Append("timeInlet = ").AppendLine(this.timeInlet);
			buff.Append("velocityCritical = ").AppendLine(this.velocityCritical);
			return buff.ToString();
		}
		public double flowIn;
		public double? areaCatchment;
		public string desc;
		public double? depthCritical;
		public double? hglDown;
		public double? hglUp;
		public double? intensity;
		public double? runoffCoeff;
		public double? slopeCritical;
		public double? timeInlet;
		public double? velocityCritical;
	}
	
	public class Structs : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	/// <summary>
	/// Each Struct within a Structs collection element must have a unique  "name" attribute.
	/// 
	/// The structure type is determined by the existance of one of the following elements: CircStruct or RectStruct.
	/// 
	/// The Center element will contain the "north east" coordinate text value or a CgPoint "refPnt" attribute.
	/// 
	/// Each Invert element contains a "refPipe" attribute to reference a Pipe element  "name"
	/// 
	/// 
	/// </summary>
	public class Struct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.elevRim = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("elevRim"));
			this.elevSump = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("elevSump"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("elevRim = ").AppendLine(this.elevRim);
			buff.Append("elevSump = ").AppendLine(this.elevSump);
			buff.Append("oID = ").AppendLine(this.oID);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public double? elevRim;
		public double? elevSump;
		public string oID;
		public StateType? state;
	}
	
	public class CircStruct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.diameter = XsdConverter.Instance.Convert<double>(attributes.GetSafe("diameter"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.inletCase = XsdConverter.Instance.Convert<string>(attributes.GetSafe("inletCase"));
			this.lossCoeff = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("lossCoeff"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("thickness"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("diameter = ").AppendLine(this.diameter);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("inletCase = ").AppendLine(this.inletCase);
			buff.Append("lossCoeff = ").AppendLine(this.lossCoeff);
			buff.Append("material = ").AppendLine(this.material);
			buff.Append("thickness = ").AppendLine(this.thickness);
			return buff.ToString();
		}
		public double diameter;
		public string desc;
		public string inletCase;
		public double? lossCoeff;
		public string material;
		public double? thickness;
	}
	
	public class RectStruct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.lengthDir = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("lengthDir"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.inletCase = XsdConverter.Instance.Convert<string>(attributes.GetSafe("inletCase"));
			this.lossCoeff = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("lossCoeff"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("thickness"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("length = ").AppendLine(this.length);
			buff.Append("lengthDir = ").AppendLine(this.lengthDir);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("inletCase = ").AppendLine(this.inletCase);
			buff.Append("lossCoeff = ").AppendLine(this.lossCoeff);
			buff.Append("material = ").AppendLine(this.material);
			buff.Append("thickness = ").AppendLine(this.thickness);
			return buff.ToString();
		}
		public double length;
		/// <summary>
		/// Represents a normalized angular value that indicates a horizontal direction, expressed in the specified Direction units. Assume 0 degrees =  north
		/// 
		/// 
		/// </summary>
		public double? lengthDir;
		public double width;
		public string desc;
		public string inletCase;
		public double? lossCoeff;
		public string material;
		public double? thickness;
	}
	
	public class InletStruct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class OutletStruct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class Connection : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class Invert : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.elev = XsdConverter.Instance.Convert<double>(attributes.GetSafe("elev"));
			this.flowDir = XsdConverter.Instance.Convert<InOut>(attributes.GetSafe("flowDir"));
			this.refPipe = XsdConverter.Instance.Convert<string>(attributes.GetSafe("refPipe"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("elev = ").AppendLine(this.elev);
			buff.Append("flowDir = ").AppendLine(this.flowDir);
			buff.Append("refPipe = ").AppendLine(this.refPipe);
			return buff.ToString();
		}
		public string desc;
		public double elev;
		public InOut flowDir;
		/// <summary>
		/// A reference name value referring to Pipe.name attribute.
		/// 
		/// 
		/// </summary>
		public string refPipe;
	}
	
	public class StructFlow : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.lossIn = XsdConverter.Instance.Convert<double>(attributes.GetSafe("lossIn"));
			this.lossOut = XsdConverter.Instance.Convert<double>(attributes.GetSafe("lossOut"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.hglIn = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("hglIn"));
			this.hglOut = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("hglOut"));
			this.localDepression = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("localDepression"));
			this.slopeSurf = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("slopeSurf"));
			this.slopeGutter = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("slopeGutter"));
			this.widthGutter = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("widthGutter"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("lossIn = ").AppendLine(this.lossIn);
			buff.Append("lossOut = ").AppendLine(this.lossOut);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("hglIn = ").AppendLine(this.hglIn);
			buff.Append("hglOut = ").AppendLine(this.hglOut);
			buff.Append("localDepression = ").AppendLine(this.localDepression);
			buff.Append("slopeSurf = ").AppendLine(this.slopeSurf);
			buff.Append("slopeGutter = ").AppendLine(this.slopeGutter);
			buff.Append("widthGutter = ").AppendLine(this.widthGutter);
			return buff.ToString();
		}
		public double lossIn;
		public double lossOut;
		public string desc;
		public double? hglIn;
		public double? hglOut;
		public double? localDepression;
		public double? slopeSurf;
		public double? slopeGutter;
		public double? widthGutter;
	}
	
	/// <summary>
	/// A collection of planimetric features not otherwise defined by the schema, such as building footprints, guard rails, tree lines, lightpoles or signage.
	/// 
	/// Typically a PlanFeatures element will contain a collection of similar items.
	/// 
	/// 
	/// </summary>
	public class PlanFeatures : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	/// <summary>
	/// A planimetric feature not otherwise defined by the schema, such as building footprints, guard rails, tree lines, lightpoles or signage.
	/// 
	/// 
	/// </summary>
	public class PlanFeature : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	public class GradeModel : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
	}
	
	public class GradeSurface : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.alignmentRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("alignmentRef"));
			this.stationAlignmentRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("stationAlignmentRef"));
			this.surfaceType = XsdConverter.Instance.Convert<ZoneSurfaceType>(attributes.GetSafe("surfaceType"));
			this.surfaceRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surfaceRef"));
			this.surfaceRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("surfaceRefs"));
			this.cgPointRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("cgPointRefs"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("alignmentRef = ").AppendLine(this.alignmentRef);
			buff.Append("stationAlignmentRef = ").AppendLine(this.stationAlignmentRef);
			buff.Append("surfaceType = ").AppendLine(this.surfaceType);
			buff.Append("surfaceRef = ").AppendLine(this.surfaceRef);
			buff.Append("surfaceRefs = ").AppendLine(this.surfaceRefs);
			buff.Append("cgPointRefs = ").AppendLine(this.cgPointRefs);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		/// <summary>
		/// A reference name value referring to Alignment.name attribute.
		/// 
		/// 
		/// </summary>
		public string alignmentRef;
		/// <summary>
		/// A reference name value referring to Alignment.name attribute.
		/// 
		/// 
		/// </summary>
		public string stationAlignmentRef;
		public ZoneSurfaceType surfaceType;
		/// <summary>
		/// A reference name value referring to Surface.name attribute.
		/// 
		/// 
		/// </summary>
		public string surfaceRef;
		/// <summary>
		/// A list of reference names values refering to one or more Surface.name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> surfaceRefs;
		/// <summary>
		/// A list of reference names values refering to one or more PointType derived name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> cgPointRefs;
		public string name;
		public string desc;
		public StateType? state;
	}
	
	public class Zones : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.side = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("side"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("side = ").AppendLine(this.side);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public SideofRoadType side;
		public string desc;
		public string name;
		public StateType? state;
	}
	
	public class Zone : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			this.priority = XsdConverter.Instance.Convert<int>(attributes.GetSafe("priority"));
			this.category = XsdConverter.Instance.Convert<ZoneCategoryType>(attributes.GetSafe("category"));
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.startWidth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startWidth"));
			this.startVertValue = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startVertValue"));
			this.startVertType = XsdConverter.Instance.Convert<ZoneVertType>(attributes.GetSafe("startVertType"));
			this.endWidth = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endWidth"));
			this.endVertValue = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endVertValue"));
			this.endVertType = XsdConverter.Instance.Convert<ZoneVertType?>(attributes.GetSafe("endVertType"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("state = ").AppendLine(this.state);
			buff.Append("priority = ").AppendLine(this.priority);
			buff.Append("category = ").AppendLine(this.category);
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("startWidth = ").AppendLine(this.startWidth);
			buff.Append("startVertValue = ").AppendLine(this.startVertValue);
			buff.Append("startVertType = ").AppendLine(this.startVertType);
			buff.Append("endWidth = ").AppendLine(this.endWidth);
			buff.Append("endVertValue = ").AppendLine(this.endVertValue);
			buff.Append("endVertType = ").AppendLine(this.endVertType);
			return buff.ToString();
		}
		public string desc;
		public string name;
		public StateType? state;
		public int priority;
		public ZoneCategoryType category;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public double startWidth;
		public double startVertValue;
		public ZoneVertType startVertType;
		public double? endWidth;
		public double? endVertValue;
		public ZoneVertType? endVertType;
	}
	
	public class ZoneWidth : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.startWidth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startWidth"));
			this.endWidth = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endWidth"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("startWidth = ").AppendLine(this.startWidth);
			buff.Append("endWidth = ").AppendLine(this.endWidth);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staEnd;
		public double startWidth;
		public double? endWidth;
	}
	
	public class ZoneSlope : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.startVertValue = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("startVertValue"));
			this.startVertType = XsdConverter.Instance.Convert<ZoneVertType?>(attributes.GetSafe("startVertType"));
			this.endVertValue = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endVertValue"));
			this.endVertType = XsdConverter.Instance.Convert<ZoneVertType>(attributes.GetSafe("endVertType"));
			this.parabolicStartStation = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("parabolicStartStation"));
			this.parabolicEndStation = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("parabolicEndStation"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("startVertValue = ").AppendLine(this.startVertValue);
			buff.Append("startVertType = ").AppendLine(this.startVertType);
			buff.Append("endVertValue = ").AppendLine(this.endVertValue);
			buff.Append("endVertType = ").AppendLine(this.endVertType);
			buff.Append("parabolicStartStation = ").AppendLine(this.parabolicStartStation);
			buff.Append("parabolicEndStation = ").AppendLine(this.parabolicEndStation);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staEnd;
		public double? startVertValue;
		public ZoneVertType? startVertType;
		public double endVertValue;
		public ZoneVertType endVertType;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? parabolicStartStation;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? parabolicEndStation;
	}
	
	public class ZoneHinge : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.hingeType = XsdConverter.Instance.Convert<ZoneHingeType>(attributes.GetSafe("hingeType"));
			this.zonePriorityRef = XsdConverter.Instance.Convert<int>(attributes.GetSafe("zonePriorityRef"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("hingeType = ").AppendLine(this.hingeType);
			buff.Append("zonePriorityRef = ").AppendLine(this.zonePriorityRef);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staEnd;
		public ZoneHingeType hingeType;
		public int zonePriorityRef;
	}
	
	public class ZoneCutFill : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.cutSlope = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("cutSlope"));
			this.fillSlope = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("fillSlope"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("cutSlope = ").AppendLine(this.cutSlope);
			buff.Append("fillSlope = ").AppendLine(this.fillSlope);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staEnd;
		/// <summary>
		/// This item is the cross slope, the slope of the traveled way as measure perpendicular to the horizontal alignment, negative when the shoulder has a lower elevation than the centerline. The unit of measure for this item is PERCENT %.
		/// 
		/// 
		/// </summary>
		public double? cutSlope;
		/// <summary>
		/// This item is the cross slope, the slope of the traveled way as measure perpendicular to the horizontal alignment, negative when the shoulder has a lower elevation than the centerline. The unit of measure for this item is PERCENT %.
		/// 
		/// 
		/// </summary>
		public double? fillSlope;
	}
	
	public class ZoneMaterial : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.material = XsdConverter.Instance.Convert<ZoneMaterialType>(attributes.GetSafe("material"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("material = ").AppendLine(this.material);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staEnd;
		public ZoneMaterialType material;
	}
	
	public class ZoneCrossSectStructure : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.innerConnectPnt = XsdConverter.Instance.Convert<IList<double>>(attributes.GetSafe("innerConnectPnt"));
			this.outerConnectPnt = XsdConverter.Instance.Convert<IList<double>>(attributes.GetSafe("outerConnectPnt"));
			this.offsetMode = XsdConverter.Instance.Convert<ZoneOffsetType?>(attributes.GetSafe("offsetMode"), XsdConverter.Instance.Convert<ZoneOffsetType?>("zone"));
			this.startOffset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("startOffset"), XsdConverter.Instance.Convert<double?>("0.0"));
			this.startOffsetElev = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("startOffsetElev"), XsdConverter.Instance.Convert<double?>("0.0"));
			this.endOffset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endOffset"), XsdConverter.Instance.Convert<double?>("0.0"));
			this.endOffsetElev = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endOffsetElev"), XsdConverter.Instance.Convert<double?>("0.0"));
			this.transition = XsdConverter.Instance.Convert<ZoneTransitionType?>(attributes.GetSafe("transition"), XsdConverter.Instance.Convert<ZoneTransitionType?>("parallel"));
			this.placement = XsdConverter.Instance.Convert<ZonePlacementType?>(attributes.GetSafe("placement"), XsdConverter.Instance.Convert<ZonePlacementType?>("dependent"));
			this.catalogReference = XsdConverter.Instance.Convert<Uri>(attributes.GetSafe("catalogReference"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("innerConnectPnt = ").AppendLine(this.innerConnectPnt);
			buff.Append("outerConnectPnt = ").AppendLine(this.outerConnectPnt);
			buff.Append("offsetMode = ").Append(this.offsetMode).AppendLine(" defvalue = zone");
			buff.Append("startOffset = ").Append(this.startOffset).AppendLine(" defvalue = 0.0");
			buff.Append("startOffsetElev = ").Append(this.startOffsetElev).AppendLine(" defvalue = 0.0");
			buff.Append("endOffset = ").Append(this.endOffset).AppendLine(" defvalue = 0.0");
			buff.Append("endOffsetElev = ").Append(this.endOffsetElev).AppendLine(" defvalue = 0.0");
			buff.Append("transition = ").Append(this.transition).AppendLine(" defvalue = parallel");
			buff.Append("placement = ").Append(this.placement).AppendLine(" defvalue = dependent");
			buff.Append("catalogReference = ").AppendLine(this.catalogReference);
			return buff.ToString();
		}
		public string name;
		/// <summary>
		/// Attribute that represents a space delimited, cross section offset/elevation pair. 
		///             Example: crossSectionPnt="12.0 723.3456"	
		///             
		/// 
		/// Restriction:
		/// Restriction:
		/// A text value that is a space delimited list of doubles. It is used as the base type to define point coordinates in the form of "northing easting" or "northing easting elevation" as well as point lists of 2D or 3D points with items such as surface boundaries or "station elevation", "station offset" lists for items such as profiles and cross sections: 
		/// Example, "1632.546 2391.045 240.30"
		/// 
		/// 
		/// 
		/// 
		/// </summary>
		public IList<double> innerConnectPnt;
		/// <summary>
		/// Attribute that represents a space delimited, cross section offset/elevation pair. 
		///             Example: crossSectionPnt="12.0 723.3456"	
		///             
		/// 
		/// Restriction:
		/// Restriction:
		/// A text value that is a space delimited list of doubles. It is used as the base type to define point coordinates in the form of "northing easting" or "northing easting elevation" as well as point lists of 2D or 3D points with items such as surface boundaries or "station elevation", "station offset" lists for items such as profiles and cross sections: 
		/// Example, "1632.546 2391.045 240.30"
		/// 
		/// 
		/// 
		/// 
		/// </summary>
		public IList<double> outerConnectPnt;
		public ZoneOffsetType? offsetMode;
		/// <summary>
		/// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? startOffset;
		/// <summary>
		/// Represents a vertical offset distance or elevational shift. In all cases a positive value indicates a vertical elevational shift above the origin and negative values indicate a vertical elevational shift below the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? startOffsetElev;
		/// <summary>
		/// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? endOffset;
		/// <summary>
		/// Represents a vertical offset distance or elevational shift. In all cases a positive value indicates a vertical elevational shift above the origin and negative values indicate a vertical elevational shift below the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? endOffsetElev;
		public ZoneTransitionType? transition;
		public ZonePlacementType? placement;
		public Uri catalogReference;
	}
	
	public class Roadways : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		public string desc;
		public StateType? state;
	}
	
	public class Roadway : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.alignmentRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("alignmentRefs"));
			this.gradeModelRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("gradeModelRefs"));
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.roadTerrain = XsdConverter.Instance.Convert<RoadTerrainType?>(attributes.GetSafe("roadTerrain"));
			this.state = XsdConverter.Instance.Convert<StateType?>(attributes.GetSafe("state"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("name = ").AppendLine(this.name);
			buff.Append("alignmentRefs = ").AppendLine(this.alignmentRefs);
			buff.Append("gradeModelRefs = ").AppendLine(this.gradeModelRefs);
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("desc = ").AppendLine(this.desc);
			buff.Append("roadTerrain = ").AppendLine(this.roadTerrain);
			buff.Append("state = ").AppendLine(this.state);
			return buff.ToString();
		}
		public string name;
		/// <summary>
		/// A list of reference names values refering to one or more Alignment.name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> alignmentRefs;
		/// <summary>
		/// A list of reference names values refering to one or more GradeModel.name attributes.
		/// 
		/// 
		/// </summary>
		public IList<string> gradeModelRefs;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public string desc;
		public RoadTerrainType? roadTerrain;
		public StateType? state;
	}
	
	public class Classification : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.functionalClass = XsdConverter.Instance.Convert<FunctionalClassType?>(attributes.GetSafe("functionalClass"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("functionalClass = ").AppendLine(this.functionalClass);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public FunctionalClassType? functionalClass;
	}
	
	public class DesignSpeed : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.speed = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("speed"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("speed = ").AppendLine(this.speed);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		/// <summary>
		/// This item is the speed or velocity of travel. The unit of measure for this item is kilometers/hour for Metric units and miles/hour for Imperial. 
		/// 
		/// 
		/// </summary>
		public double? speed;
	}
	
	public class DesignSpeed85th : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			this.speed = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("speed"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			buff.Append("speed = ").AppendLine(this.speed);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public SideofRoadType? sideofRoad;
		/// <summary>
		/// This item is the speed or velocity of travel. The unit of measure for this item is kilometers/hour for Metric units and miles/hour for Imperial. 
		/// 
		/// 
		/// </summary>
		public double? speed;
	}
	
	public class Speeds : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class DailyTrafficVolume : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.aDT = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("ADT"));
			this.year = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("year"));
			this.escFactor = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("escFactor"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("aDT = ").AppendLine(this.aDT);
			buff.Append("year = ").AppendLine(this.year);
			buff.Append("escFactor = ").AppendLine(this.escFactor);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public double? aDT;
		public DateTime? year;
		public double? escFactor;
	}
	
	public class DesignHour : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.volume = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("volume"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("volume = ").AppendLine(this.volume);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public double? volume;
	}
	
	public class PeakHour : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			this.volume = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("volume"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			buff.Append("volume = ").AppendLine(this.volume);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public SideofRoadType? sideofRoad;
		public double? volume;
	}
	
	public class TrafficVolume : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class Superelevation : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
	}
	
	public class Lanes : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class ThruLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public double? width;
		public SideofRoadType? sideofRoad;
	}
	
	public class PassingLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endFullWidthSta"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("beginFullWidthSta = ").AppendLine(this.beginFullWidthSta);
			buff.Append("endFullWidthSta = ").AppendLine(this.endFullWidthSta);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? beginFullWidthSta;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? endFullWidthSta;
		public double? width;
		public SideofRoadType? sideofRoad;
	}
	
	public class TurnLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("beginFullWidthSta"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			this.type = XsdConverter.Instance.Convert<TurnLaneType?>(attributes.GetSafe("type"));
			this.taperType = XsdConverter.Instance.Convert<LaneTaperType?>(attributes.GetSafe("taperType"));
			this.taperTangentLength = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("taperTangentLength"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("beginFullWidthSta = ").AppendLine(this.beginFullWidthSta);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			buff.Append("type = ").AppendLine(this.type);
			buff.Append("taperType = ").AppendLine(this.taperType);
			buff.Append("taperTangentLength = ").AppendLine(this.taperTangentLength);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? beginFullWidthSta;
		public double? width;
		public SideofRoadType? sideofRoad;
		public TurnLaneType? type;
		public LaneTaperType? taperType;
		public double? taperTangentLength;
	}
	
	public class TwoWayLeftTurnLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endFullWidthSta"));
			this.startOffset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("startOffset"));
			this.endOffset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endOffset"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("beginFullWidthSta = ").AppendLine(this.beginFullWidthSta);
			buff.Append("endFullWidthSta = ").AppendLine(this.endFullWidthSta);
			buff.Append("startOffset = ").AppendLine(this.startOffset);
			buff.Append("endOffset = ").AppendLine(this.endOffset);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? beginFullWidthSta;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? endFullWidthSta;
		/// <summary>
		/// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? startOffset;
		/// <summary>
		/// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? endOffset;
		public double? width;
		public SideofRoadType? sideofRoad;
	}
	
	public class ClimbLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endFullWidthSta"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("beginFullWidthSta = ").AppendLine(this.beginFullWidthSta);
			buff.Append("endFullWidthSta = ").AppendLine(this.endFullWidthSta);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? beginFullWidthSta;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? endFullWidthSta;
		public double? width;
		public SideofRoadType? sideofRoad;
	}
	
	public class OffsetLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endFullWidthSta"));
			this.fullOffset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("fullOffset"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("beginFullWidthSta = ").AppendLine(this.beginFullWidthSta);
			buff.Append("endFullWidthSta = ").AppendLine(this.endFullWidthSta);
			buff.Append("fullOffset = ").AppendLine(this.fullOffset);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? beginFullWidthSta;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? endFullWidthSta;
		/// <summary>
		/// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? fullOffset;
		public double? width;
		public SideofRoadType? sideofRoad;
	}
	
	public class WideningLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("endFullWidthSta"));
			this.offset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("offset"));
			this.widening = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("widening"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("beginFullWidthSta = ").AppendLine(this.beginFullWidthSta);
			buff.Append("endFullWidthSta = ").AppendLine(this.endFullWidthSta);
			buff.Append("offset = ").AppendLine(this.offset);
			buff.Append("widening = ").AppendLine(this.widening);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? beginFullWidthSta;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? endFullWidthSta;
		/// <summary>
		/// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? offset;
		public double? widening;
		public double? width;
		public SideofRoadType? sideofRoad;
	}
	
	public class Roadside : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class Ditch : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.bottomWidth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("bottomWidth"));
			this.bottomShape = XsdConverter.Instance.Convert<DitchBottomShape?>(attributes.GetSafe("bottomShape"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("bottomWidth = ").AppendLine(this.bottomWidth);
			buff.Append("bottomShape = ").AppendLine(this.bottomShape);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double staEnd;
		public double bottomWidth;
		public DitchBottomShape? bottomShape;
	}
	
	public class ObstructionOffset : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.offset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("offset"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("offset = ").AppendLine(this.offset);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		/// <summary>
		/// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? offset;
		public SideofRoadType? sideofRoad;
	}
	
	public class BikeFacilities : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public double? width;
		public SideofRoadType? sideofRoad;
	}
	
	public class RoadSign : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.mUTCDCode = XsdConverter.Instance.Convert<string>(attributes.GetSafe("MUTCDCode"));
			this.station = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("station"));
			this.offset = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("offset"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			this.type = XsdConverter.Instance.Convert<RoadSignType?>(attributes.GetSafe("type"));
			this.mountHeight = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("mountHeight"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.height = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("height"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("mUTCDCode = ").AppendLine(this.mUTCDCode);
			buff.Append("station = ").AppendLine(this.station);
			buff.Append("offset = ").AppendLine(this.offset);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			buff.Append("type = ").AppendLine(this.type);
			buff.Append("mountHeight = ").AppendLine(this.mountHeight);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("height = ").AppendLine(this.height);
			return buff.ToString();
		}
		public string mUTCDCode;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? station;
		/// <summary>
		/// Represents a linear offset distance. When associated with horizontal (planametric) road or coordinate geometry, the offset is a 2D distance measured perpendicular to the road centerline or coordinate geometry used as the origin. When used in cross sections of long section (profile) the offset is a 2d linear measurement from the origin of the cross section or long section. In all cases a positive value indicates an offset to the RIGHT of the origin and negative values indicate and offset to the LEFT of the origin. The value is in decimal form expressed in length units.
		/// 
		/// 
		/// </summary>
		public double? offset;
		public SideofRoadType? sideofRoad;
		public RoadSignType? type;
		public double? mountHeight;
		public double? width;
		public double? height;
	}
	
	public class DrivewayDensity : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.density = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("density"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("density = ").AppendLine(this.density);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public int? density;
	}
	
	public class HazardRating : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.rating = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("rating"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("rating = ").AppendLine(this.rating);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public int? rating;
	}
	
	public class Intersections : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class Intersection : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.roadwayRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("roadwayRef"));
			this.roadwayPI = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("roadwayPI"));
			this.intersectingRoadwayRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("intersectingRoadwayRef"));
			this.intersectRoadwayPI = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("intersectRoadwayPI"));
			this.contructionType = XsdConverter.Instance.Convert<IntersectionConstructionType?>(attributes.GetSafe("contructionType"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("roadwayRef = ").AppendLine(this.roadwayRef);
			buff.Append("roadwayPI = ").AppendLine(this.roadwayPI);
			buff.Append("intersectingRoadwayRef = ").AppendLine(this.intersectingRoadwayRef);
			buff.Append("intersectRoadwayPI = ").AppendLine(this.intersectRoadwayPI);
			buff.Append("contructionType = ").AppendLine(this.contructionType);
			return buff.ToString();
		}
		/// <summary>
		/// A reference name value referring to Raodway.name attribute.
		/// 
		/// 
		/// </summary>
		public string roadwayRef;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? roadwayPI;
		/// <summary>
		/// A reference name value referring to Raodway.name attribute.
		/// 
		/// 
		/// </summary>
		public string intersectingRoadwayRef;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? intersectRoadwayPI;
		public IntersectionConstructionType? contructionType;
	}
	
	public class TrafficControl : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("station"));
			this.signalPeriod = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("signalPeriod"));
			this.controlPosition = XsdConverter.Instance.Convert<TrafficControlPosition?>(attributes.GetSafe("controlPosition"));
			this.controlType = XsdConverter.Instance.Convert<TrafficControlType?>(attributes.GetSafe("controlType"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("station = ").AppendLine(this.station);
			buff.Append("signalPeriod = ").AppendLine(this.signalPeriod);
			buff.Append("controlPosition = ").AppendLine(this.controlPosition);
			buff.Append("controlType = ").AppendLine(this.controlType);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? station;
		public double? signalPeriod;
		public TrafficControlPosition? controlPosition;
		public TrafficControlType? controlType;
	}
	
	public class Timing : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("station"));
			this.legNumber = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("legNumber"));
			this.protectedTurnPercent = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("protectedTurnPercent"));
			this.unprotectedTurnPercent = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("unprotectedTurnPercent"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("station = ").AppendLine(this.station);
			buff.Append("legNumber = ").AppendLine(this.legNumber);
			buff.Append("protectedTurnPercent = ").AppendLine(this.protectedTurnPercent);
			buff.Append("unprotectedTurnPercent = ").AppendLine(this.unprotectedTurnPercent);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? station;
		public int? legNumber;
		public double? protectedTurnPercent;
		public double? unprotectedTurnPercent;
	}
	
	public class Volume : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("station"));
			this.legNumber = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("legNumber"));
			this.turnPercent = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("turnPercent"));
			this.percentTrucks = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("percentTrucks"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("station = ").AppendLine(this.station);
			buff.Append("legNumber = ").AppendLine(this.legNumber);
			buff.Append("turnPercent = ").AppendLine(this.turnPercent);
			buff.Append("percentTrucks = ").AppendLine(this.percentTrucks);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? station;
		public int? legNumber;
		public double? turnPercent;
		public double? percentTrucks;
	}
	
	public class TurnSpeed : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("station"));
			this.legNumber = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("legNumber"));
			this.speed = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("speed"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("station = ").AppendLine(this.station);
			buff.Append("legNumber = ").AppendLine(this.legNumber);
			buff.Append("speed = ").AppendLine(this.speed);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? station;
		public int? legNumber;
		public double? speed;
	}
	
	public class TurnRestriction : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("station"));
			this.legNumber = XsdConverter.Instance.Convert<int?>(attributes.GetSafe("legNumber"));
			this.type = XsdConverter.Instance.Convert<TrafficTurnRestriction?>(attributes.GetSafe("type"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("station = ").AppendLine(this.station);
			buff.Append("legNumber = ").AppendLine(this.legNumber);
			buff.Append("type = ").AppendLine(this.type);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? station;
		public int? legNumber;
		public TrafficTurnRestriction? type;
	}
	
	public class Curb : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			this.type = XsdConverter.Instance.Convert<CurbType?>(attributes.GetSafe("type"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			buff.Append("type = ").AppendLine(this.type);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public SideofRoadType? sideofRoad;
		public CurbType? type;
	}
	
	public class Corner : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.type = XsdConverter.Instance.Convert<CornerType?>(attributes.GetSafe("type"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("type = ").AppendLine(this.type);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public CornerType? type;
	}
	
	public class CrashData : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			return buff.ToString();
		}
	}
	
	public class CrashHistory : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.year = XsdConverter.Instance.Convert<DateTime?>(attributes.GetSafe("year"));
			this.location1 = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("location-1"));
			this.location2 = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("location-2"));
			this.severity = XsdConverter.Instance.Convert<CrashSeverityType?>(attributes.GetSafe("severity"));
			this.intersectionRelation = XsdConverter.Instance.Convert<CrashIntersectionRelation?>(attributes.GetSafe("intersectionRelation"));
			this.intersectionLocation = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("intersectionLocation"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("year = ").AppendLine(this.year);
			buff.Append("location1 = ").AppendLine(this.location1);
			buff.Append("location2 = ").AppendLine(this.location2);
			buff.Append("severity = ").AppendLine(this.severity);
			buff.Append("intersectionRelation = ").AppendLine(this.intersectionRelation);
			buff.Append("intersectionLocation = ").AppendLine(this.intersectionLocation);
			return buff.ToString();
		}
		public DateTime? year;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? location1;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? location2;
		public CrashSeverityType? severity;
		public CrashIntersectionRelation? intersectionRelation;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? intersectionLocation;
	}
	
	public class PostedSpeed : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			this.speedLimit = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("speedLimit"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			buff.Append("speedLimit = ").AppendLine(this.speedLimit);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public SideofRoadType? sideofRoad;
		/// <summary>
		/// This item is the speed or velocity of travel. The unit of measure for this item is kilometers/hour for Metric units and miles/hour for Imperial. 
		/// 
		/// 
		/// </summary>
		public double? speedLimit;
	}
	
	public class NoPassingZone : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType?>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("sideofRoad = ").AppendLine(this.sideofRoad);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public SideofRoadType? sideofRoad;
	}
	
	public class DecisionSightDistance : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("station"));
			this.maneuver = XsdConverter.Instance.Convert<ManeuverType?>(attributes.GetSafe("maneuver"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("station = ").AppendLine(this.station);
			buff.Append("maneuver = ").AppendLine(this.maneuver);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? station;
		public ManeuverType? maneuver;
	}
	
	public class BridgeElement : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("staEnd"));
			this.width = XsdConverter.Instance.Convert<double?>(attributes.GetSafe("width"));
			this.projectType = XsdConverter.Instance.Convert<BridgeProjectType?>(attributes.GetSafe("projectType"));
			return true;
		}
		public override string ToString()
		{
			System.Text.StringBuilder buff = new System.Text.StringBuilder();
			buff.AppendLine(base.ToString());
			buff.Append("staStart = ").AppendLine(this.staStart);
			buff.Append("staEnd = ").AppendLine(this.staEnd);
			buff.Append("width = ").AppendLine(this.width);
			buff.Append("projectType = ").AppendLine(this.projectType);
			return buff.ToString();
		}
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staStart;
		/// <summary>
		/// Represents a station value in decimal form expressed in length units
		/// 
		/// 
		/// </summary>
		public double? staEnd;
		public double? width;
		public BridgeProjectType? projectType;
	}
	
	
	// Elements others
	// ---------------
	
	public interface ILandXmlEvents
	{
		void BeginReadPntList2D( IList<double> value );
		void EndReadPntList2D();
		void BeginReadPntList3D( IList<double> value );
		void EndReadPntList3D();
		void BeginReadF( IList<int> value );
		void EndReadF();
		void BeginReadBeginRunoutSta( double value );
		void EndReadBeginRunoutSta();
		void BeginReadBeginRunoffSta( double value );
		void EndReadBeginRunoffSta();
		void BeginReadFullSuperSta( double value );
		void EndReadFullSuperSta();
		void BeginReadFullSuperelev( double value );
		void EndReadFullSuperelev();
		void BeginReadRunoffSta( double value );
		void EndReadRunoffSta();
		void BeginReadStartofRunoutSta( double value );
		void EndReadStartofRunoutSta();
		void BeginReadEndofRunoutSta( double value );
		void EndReadEndofRunoutSta();
		void BeginReadAdverseSE( AdverseSEType value );
		void EndReadAdverseSE();
		void BeginReadLandXML( LandXML value );
		void EndReadLandXML();
		void BeginReadCgPoints( CgPoints value );
		void EndReadCgPoints();
		void BeginReadCgPoint( CgPoint value );
		void EndReadCgPoint();
		void BeginReadDocFileRef( DocFileRef value );
		void EndReadDocFileRef();
		void BeginReadFeature( Feature value );
		void EndReadFeature();
		void BeginReadProperty( Property value );
		void EndReadProperty();
		void BeginReadStart( PointType value );
		void EndReadStart();
		void BeginReadEnd( PointType value );
		void EndReadEnd();
		void BeginReadCenter( PointType value );
		void EndReadCenter();
		void BeginReadPI( PointType value );
		void EndReadPI();
		void BeginReadMapPoint( PointType value );
		void EndReadMapPoint();
		void BeginReadInstrumentPoint( PointType value );
		void EndReadInstrumentPoint();
		void BeginReadLocation( PointType value );
		void EndReadLocation();
		void BeginReadIrregularLine( IrregularLine value );
		void EndReadIrregularLine();
		void BeginReadChain( Chain value );
		void EndReadChain();
		void BeginReadCurve( Curve value );
		void EndReadCurve();
		void BeginReadSpiral( Spiral value );
		void EndReadSpiral();
		void BeginReadCoordGeom( CoordGeom value );
		void EndReadCoordGeom();
		void BeginReadLine( Line value );
		void EndReadLine();
		void BeginReadCrossSects( CrossSects value );
		void EndReadCrossSects();
		void BeginReadCrossSect( CrossSect value );
		void EndReadCrossSect();
		void BeginReadCrossSectSurf( CrossSectSurf value );
		void EndReadCrossSectSurf();
		void BeginReadProject( Project value );
		void EndReadProject();
		void BeginReadUnits( Units value );
		void EndReadUnits();
		void BeginReadMetric( Metric value );
		void EndReadMetric();
		void BeginReadImperial( Imperial value );
		void EndReadImperial();
		void BeginReadCoordinateSystem( CoordinateSystem value );
		void EndReadCoordinateSystem();
		void BeginReadApplication( Application value );
		void EndReadApplication();
		void BeginReadAuthor( Author value );
		void EndReadAuthor();
		void BeginReadSurvey( Survey value );
		void EndReadSurvey();
		void BeginReadSurveyHeader( SurveyHeader value );
		void EndReadSurveyHeader();
		void BeginReadPersonnel( Personnel value );
		void EndReadPersonnel();
		void BeginReadFieldNote( FieldNote value );
		void EndReadFieldNote();
		void BeginReadEquipment( Equipment value );
		void EndReadEquipment();
		void BeginReadInstrumentDetails( InstrumentDetails value );
		void EndReadInstrumentDetails();
		void BeginReadLaserDetails( LaserDetails value );
		void EndReadLaserDetails();
		void BeginReadGPSAntennaDetails( GPSAntennaDetails value );
		void EndReadGPSAntennaDetails();
		void BeginReadGPSReceiverDetails( GPSReceiverDetails value );
		void EndReadGPSReceiverDetails();
		void BeginReadCorrections( Corrections value );
		void EndReadCorrections();
		void BeginReadSurveyMonument( SurveyMonument value );
		void EndReadSurveyMonument();
		void BeginReadInstrumentSetup( InstrumentSetup value );
		void EndReadInstrumentSetup();
		void BeginReadLaserSetup( LaserSetup value );
		void EndReadLaserSetup();
		void BeginReadGPSSetup( GPSSetup value );
		void EndReadGPSSetup();
		void BeginReadTargetSetup( TargetSetup value );
		void EndReadTargetSetup();
		void BeginReadBacksight( Backsight value );
		void EndReadBacksight();
		void BeginReadRawObservation( RawObservation value );
		void EndReadRawObservation();
		void BeginReadTargetPoint( PointType value );
		void EndReadTargetPoint();
		void BeginReadBacksightPoint( PointType value );
		void EndReadBacksightPoint();
		void BeginReadOffsetVals( OffsetVals value );
		void EndReadOffsetVals();
		void BeginReadGPSVector( GPSVector value );
		void EndReadGPSVector();
		void BeginReadGPSPosition( GPSPosition value );
		void EndReadGPSPosition();
		void BeginReadGPSQCInfoLevel1( GPSQCInfoLevel1 value );
		void EndReadGPSQCInfoLevel1();
		void BeginReadGPSQCInfoLevel2( GPSQCInfoLevel2 value );
		void EndReadGPSQCInfoLevel2();
		void BeginReadObservationGroup( ObservationGroup value );
		void EndReadObservationGroup();
		void BeginReadControlChecks( ControlChecks value );
		void EndReadControlChecks();
		void BeginReadPointResults( PointResults value );
		void EndReadPointResults();
		void BeginReadReducedObservation( ReducedObservation value );
		void EndReadReducedObservation();
		void BeginReadReducedArcObservation( ReducedArcObservation value );
		void EndReadReducedArcObservation();
		void BeginReadMonuments( Monuments value );
		void EndReadMonuments();
		void BeginReadMonument( Monument value );
		void EndReadMonument();
		void BeginReadSurfaces( Surfaces value );
		void EndReadSurfaces();
		void BeginReadSurface( Surface value );
		void EndReadSurface();
		void BeginReadSourceData( SourceData value );
		void EndReadSourceData();
		void BeginReadDataPoints( DataPoints value );
		void EndReadDataPoints();
		void BeginReadPointFiles( PointFiles value );
		void EndReadPointFiles();
		void BeginReadPointFile( PointFile value );
		void EndReadPointFile();
		void BeginReadBoundaries( Boundaries value );
		void EndReadBoundaries();
		void BeginReadBoundary( Boundary value );
		void EndReadBoundary();
		void BeginReadBreaklines( Breaklines value );
		void EndReadBreaklines();
		void BeginReadBreakline( Breakline value );
		void EndReadBreakline();
		void BeginReadRetWall( RetWall value );
		void EndReadRetWall();
		void BeginReadRetWallPnt( RetWallPnt value );
		void EndReadRetWallPnt();
		void BeginReadContours( Contours value );
		void EndReadContours();
		void BeginReadContour( Contour value );
		void EndReadContour();
		void BeginReadDefinition( Definition value );
		void EndReadDefinition();
		void BeginReadPnts( Pnts value );
		void EndReadPnts();
		void BeginReadP( P value );
		void EndReadP();
		void BeginReadFaces( Faces value );
		void EndReadFaces();
		void BeginReadWatersheds( Watersheds value );
		void EndReadWatersheds();
		void BeginReadWatershed( Watershed value );
		void EndReadWatershed();
		void BeginReadOutlet( Outlet value );
		void EndReadOutlet();
		void BeginReadSurfVolumes( SurfVolumes value );
		void EndReadSurfVolumes();
		void BeginReadSurfVolume( SurfVolume value );
		void EndReadSurfVolume();
		void BeginReadParcels( Parcels value );
		void EndReadParcels();
		void BeginReadParcel( Parcel value );
		void EndReadParcel();
		void BeginReadTitle( Title value );
		void EndReadTitle();
		void BeginReadAlignments( Alignments value );
		void EndReadAlignments();
		void BeginReadAlignment( Alignment value );
		void EndReadAlignment();
		void BeginReadStaEquation( StaEquation value );
		void EndReadStaEquation();
		void BeginReadProfile( Profile value );
		void EndReadProfile();
		void BeginReadProfSurf( ProfSurf value );
		void EndReadProfSurf();
		void BeginReadProfAlign( ProfAlign value );
		void EndReadProfAlign();
		void BeginReadPVI( PVI value );
		void EndReadPVI();
		void BeginReadParaCurve( ParaCurve value );
		void EndReadParaCurve();
		void BeginReadUnsymParaCurve( UnsymParaCurve value );
		void EndReadUnsymParaCurve();
		void BeginReadCircCurve( CircCurve value );
		void EndReadCircCurve();
		void BeginReadPipeNetworks( PipeNetworks value );
		void EndReadPipeNetworks();
		void BeginReadPipeNetwork( PipeNetwork value );
		void EndReadPipeNetwork();
		void BeginReadPipes( Pipes value );
		void EndReadPipes();
		void BeginReadPipe( Pipe value );
		void EndReadPipe();
		void BeginReadCircPipe( CircPipe value );
		void EndReadCircPipe();
		void BeginReadElliPipe( ElliPipe value );
		void EndReadElliPipe();
		void BeginReadRectPipe( RectPipe value );
		void EndReadRectPipe();
		void BeginReadChannel( Channel value );
		void EndReadChannel();
		void BeginReadPipeFlow( PipeFlow value );
		void EndReadPipeFlow();
		void BeginReadStructs( Structs value );
		void EndReadStructs();
		void BeginReadStruct( Struct value );
		void EndReadStruct();
		void BeginReadCircStruct( CircStruct value );
		void EndReadCircStruct();
		void BeginReadRectStruct( RectStruct value );
		void EndReadRectStruct();
		void BeginReadInletStruct( InletStruct value );
		void EndReadInletStruct();
		void BeginReadOutletStruct( OutletStruct value );
		void EndReadOutletStruct();
		void BeginReadConnection( Connection value );
		void EndReadConnection();
		void BeginReadInvert( Invert value );
		void EndReadInvert();
		void BeginReadStructFlow( StructFlow value );
		void EndReadStructFlow();
		void BeginReadPlanFeatures( PlanFeatures value );
		void EndReadPlanFeatures();
		void BeginReadPlanFeature( PlanFeature value );
		void EndReadPlanFeature();
		void BeginReadGradeModel( GradeModel value );
		void EndReadGradeModel();
		void BeginReadGradeSurface( GradeSurface value );
		void EndReadGradeSurface();
		void BeginReadZones( Zones value );
		void EndReadZones();
		void BeginReadZone( Zone value );
		void EndReadZone();
		void BeginReadZoneWidth( ZoneWidth value );
		void EndReadZoneWidth();
		void BeginReadZoneSlope( ZoneSlope value );
		void EndReadZoneSlope();
		void BeginReadZoneHinge( ZoneHinge value );
		void EndReadZoneHinge();
		void BeginReadZoneCutFill( ZoneCutFill value );
		void EndReadZoneCutFill();
		void BeginReadZoneMaterial( ZoneMaterial value );
		void EndReadZoneMaterial();
		void BeginReadZoneCrossSectStructure( ZoneCrossSectStructure value );
		void EndReadZoneCrossSectStructure();
		void BeginReadRoadways( Roadways value );
		void EndReadRoadways();
		void BeginReadRoadway( Roadway value );
		void EndReadRoadway();
		void BeginReadClassification( Classification value );
		void EndReadClassification();
		void BeginReadDesignSpeed( DesignSpeed value );
		void EndReadDesignSpeed();
		void BeginReadDesignSpeed85th( DesignSpeed85th value );
		void EndReadDesignSpeed85th();
		void BeginReadSpeeds( Speeds value );
		void EndReadSpeeds();
		void BeginReadDailyTrafficVolume( DailyTrafficVolume value );
		void EndReadDailyTrafficVolume();
		void BeginReadDesignHour( DesignHour value );
		void EndReadDesignHour();
		void BeginReadPeakHour( PeakHour value );
		void EndReadPeakHour();
		void BeginReadTrafficVolume( TrafficVolume value );
		void EndReadTrafficVolume();
		void BeginReadSuperelevation( Superelevation value );
		void EndReadSuperelevation();
		void BeginReadLanes( Lanes value );
		void EndReadLanes();
		void BeginReadThruLane( ThruLane value );
		void EndReadThruLane();
		void BeginReadPassingLane( PassingLane value );
		void EndReadPassingLane();
		void BeginReadTurnLane( TurnLane value );
		void EndReadTurnLane();
		void BeginReadTwoWayLeftTurnLane( TwoWayLeftTurnLane value );
		void EndReadTwoWayLeftTurnLane();
		void BeginReadClimbLane( ClimbLane value );
		void EndReadClimbLane();
		void BeginReadOffsetLane( OffsetLane value );
		void EndReadOffsetLane();
		void BeginReadWideningLane( WideningLane value );
		void EndReadWideningLane();
		void BeginReadRoadside( Roadside value );
		void EndReadRoadside();
		void BeginReadDitch( Ditch value );
		void EndReadDitch();
		void BeginReadObstructionOffset( ObstructionOffset value );
		void EndReadObstructionOffset();
		void BeginReadBikeFacilities( BikeFacilities value );
		void EndReadBikeFacilities();
		void BeginReadRoadSign( RoadSign value );
		void EndReadRoadSign();
		void BeginReadDrivewayDensity( DrivewayDensity value );
		void EndReadDrivewayDensity();
		void BeginReadHazardRating( HazardRating value );
		void EndReadHazardRating();
		void BeginReadIntersections( Intersections value );
		void EndReadIntersections();
		void BeginReadIntersection( Intersection value );
		void EndReadIntersection();
		void BeginReadTrafficControl( TrafficControl value );
		void EndReadTrafficControl();
		void BeginReadTiming( Timing value );
		void EndReadTiming();
		void BeginReadVolume( Volume value );
		void EndReadVolume();
		void BeginReadTurnSpeed( TurnSpeed value );
		void EndReadTurnSpeed();
		void BeginReadTurnRestriction( TurnRestriction value );
		void EndReadTurnRestriction();
		void BeginReadCurb( Curb value );
		void EndReadCurb();
		void BeginReadCorner( Corner value );
		void EndReadCorner();
		void BeginReadCrashData( CrashData value );
		void EndReadCrashData();
		void BeginReadCrashHistory( CrashHistory value );
		void EndReadCrashHistory();
		void BeginReadPostedSpeed( PostedSpeed value );
		void EndReadPostedSpeed();
		void BeginReadNoPassingZone( NoPassingZone value );
		void EndReadNoPassingZone();
		void BeginReadDecisionSightDistance( DecisionSightDistance value );
		void EndReadDecisionSightDistance();
		void BeginReadBridgeElement( BridgeElement value );
		void EndReadBridgeElement();
	}
	public class LandXmlEvents : ILandXmlEvents
	{
		public virtual void BeginReadPntList2D( IList<double> value ) {}
		public virtual void EndReadPntList2D() {}
		public virtual void BeginReadPntList3D( IList<double> value ) {}
		public virtual void EndReadPntList3D() {}
		public virtual void BeginReadF( IList<int> value ) {}
		public virtual void EndReadF() {}
		public virtual void BeginReadBeginRunoutSta( double value ) {}
		public virtual void EndReadBeginRunoutSta() {}
		public virtual void BeginReadBeginRunoffSta( double value ) {}
		public virtual void EndReadBeginRunoffSta() {}
		public virtual void BeginReadFullSuperSta( double value ) {}
		public virtual void EndReadFullSuperSta() {}
		public virtual void BeginReadFullSuperelev( double value ) {}
		public virtual void EndReadFullSuperelev() {}
		public virtual void BeginReadRunoffSta( double value ) {}
		public virtual void EndReadRunoffSta() {}
		public virtual void BeginReadStartofRunoutSta( double value ) {}
		public virtual void EndReadStartofRunoutSta() {}
		public virtual void BeginReadEndofRunoutSta( double value ) {}
		public virtual void EndReadEndofRunoutSta() {}
		public virtual void BeginReadAdverseSE( AdverseSEType value ) {}
		public virtual void EndReadAdverseSE() {}
		public virtual void BeginReadLandXML( LandXML value ) {}
		public virtual void EndReadLandXML() {}
		public virtual void BeginReadCgPoints( CgPoints value ) {}
		public virtual void EndReadCgPoints() {}
		public virtual void BeginReadCgPoint( CgPoint value ) {}
		public virtual void EndReadCgPoint() {}
		public virtual void BeginReadDocFileRef( DocFileRef value ) {}
		public virtual void EndReadDocFileRef() {}
		public virtual void BeginReadFeature( Feature value ) {}
		public virtual void EndReadFeature() {}
		public virtual void BeginReadProperty( Property value ) {}
		public virtual void EndReadProperty() {}
		public virtual void BeginReadStart( PointType value ) {}
		public virtual void EndReadStart() {}
		public virtual void BeginReadEnd( PointType value ) {}
		public virtual void EndReadEnd() {}
		public virtual void BeginReadCenter( PointType value ) {}
		public virtual void EndReadCenter() {}
		public virtual void BeginReadPI( PointType value ) {}
		public virtual void EndReadPI() {}
		public virtual void BeginReadMapPoint( PointType value ) {}
		public virtual void EndReadMapPoint() {}
		public virtual void BeginReadInstrumentPoint( PointType value ) {}
		public virtual void EndReadInstrumentPoint() {}
		public virtual void BeginReadLocation( PointType value ) {}
		public virtual void EndReadLocation() {}
		public virtual void BeginReadIrregularLine( IrregularLine value ) {}
		public virtual void EndReadIrregularLine() {}
		public virtual void BeginReadChain( Chain value ) {}
		public virtual void EndReadChain() {}
		public virtual void BeginReadCurve( Curve value ) {}
		public virtual void EndReadCurve() {}
		public virtual void BeginReadSpiral( Spiral value ) {}
		public virtual void EndReadSpiral() {}
		public virtual void BeginReadCoordGeom( CoordGeom value ) {}
		public virtual void EndReadCoordGeom() {}
		public virtual void BeginReadLine( Line value ) {}
		public virtual void EndReadLine() {}
		public virtual void BeginReadCrossSects( CrossSects value ) {}
		public virtual void EndReadCrossSects() {}
		public virtual void BeginReadCrossSect( CrossSect value ) {}
		public virtual void EndReadCrossSect() {}
		public virtual void BeginReadCrossSectSurf( CrossSectSurf value ) {}
		public virtual void EndReadCrossSectSurf() {}
		public virtual void BeginReadProject( Project value ) {}
		public virtual void EndReadProject() {}
		public virtual void BeginReadUnits( Units value ) {}
		public virtual void EndReadUnits() {}
		public virtual void BeginReadMetric( Metric value ) {}
		public virtual void EndReadMetric() {}
		public virtual void BeginReadImperial( Imperial value ) {}
		public virtual void EndReadImperial() {}
		public virtual void BeginReadCoordinateSystem( CoordinateSystem value ) {}
		public virtual void EndReadCoordinateSystem() {}
		public virtual void BeginReadApplication( Application value ) {}
		public virtual void EndReadApplication() {}
		public virtual void BeginReadAuthor( Author value ) {}
		public virtual void EndReadAuthor() {}
		public virtual void BeginReadSurvey( Survey value ) {}
		public virtual void EndReadSurvey() {}
		public virtual void BeginReadSurveyHeader( SurveyHeader value ) {}
		public virtual void EndReadSurveyHeader() {}
		public virtual void BeginReadPersonnel( Personnel value ) {}
		public virtual void EndReadPersonnel() {}
		public virtual void BeginReadFieldNote( FieldNote value ) {}
		public virtual void EndReadFieldNote() {}
		public virtual void BeginReadEquipment( Equipment value ) {}
		public virtual void EndReadEquipment() {}
		public virtual void BeginReadInstrumentDetails( InstrumentDetails value ) {}
		public virtual void EndReadInstrumentDetails() {}
		public virtual void BeginReadLaserDetails( LaserDetails value ) {}
		public virtual void EndReadLaserDetails() {}
		public virtual void BeginReadGPSAntennaDetails( GPSAntennaDetails value ) {}
		public virtual void EndReadGPSAntennaDetails() {}
		public virtual void BeginReadGPSReceiverDetails( GPSReceiverDetails value ) {}
		public virtual void EndReadGPSReceiverDetails() {}
		public virtual void BeginReadCorrections( Corrections value ) {}
		public virtual void EndReadCorrections() {}
		public virtual void BeginReadSurveyMonument( SurveyMonument value ) {}
		public virtual void EndReadSurveyMonument() {}
		public virtual void BeginReadInstrumentSetup( InstrumentSetup value ) {}
		public virtual void EndReadInstrumentSetup() {}
		public virtual void BeginReadLaserSetup( LaserSetup value ) {}
		public virtual void EndReadLaserSetup() {}
		public virtual void BeginReadGPSSetup( GPSSetup value ) {}
		public virtual void EndReadGPSSetup() {}
		public virtual void BeginReadTargetSetup( TargetSetup value ) {}
		public virtual void EndReadTargetSetup() {}
		public virtual void BeginReadBacksight( Backsight value ) {}
		public virtual void EndReadBacksight() {}
		public virtual void BeginReadRawObservation( RawObservation value ) {}
		public virtual void EndReadRawObservation() {}
		public virtual void BeginReadTargetPoint( PointType value ) {}
		public virtual void EndReadTargetPoint() {}
		public virtual void BeginReadBacksightPoint( PointType value ) {}
		public virtual void EndReadBacksightPoint() {}
		public virtual void BeginReadOffsetVals( OffsetVals value ) {}
		public virtual void EndReadOffsetVals() {}
		public virtual void BeginReadGPSVector( GPSVector value ) {}
		public virtual void EndReadGPSVector() {}
		public virtual void BeginReadGPSPosition( GPSPosition value ) {}
		public virtual void EndReadGPSPosition() {}
		public virtual void BeginReadGPSQCInfoLevel1( GPSQCInfoLevel1 value ) {}
		public virtual void EndReadGPSQCInfoLevel1() {}
		public virtual void BeginReadGPSQCInfoLevel2( GPSQCInfoLevel2 value ) {}
		public virtual void EndReadGPSQCInfoLevel2() {}
		public virtual void BeginReadObservationGroup( ObservationGroup value ) {}
		public virtual void EndReadObservationGroup() {}
		public virtual void BeginReadControlChecks( ControlChecks value ) {}
		public virtual void EndReadControlChecks() {}
		public virtual void BeginReadPointResults( PointResults value ) {}
		public virtual void EndReadPointResults() {}
		public virtual void BeginReadReducedObservation( ReducedObservation value ) {}
		public virtual void EndReadReducedObservation() {}
		public virtual void BeginReadReducedArcObservation( ReducedArcObservation value ) {}
		public virtual void EndReadReducedArcObservation() {}
		public virtual void BeginReadMonuments( Monuments value ) {}
		public virtual void EndReadMonuments() {}
		public virtual void BeginReadMonument( Monument value ) {}
		public virtual void EndReadMonument() {}
		public virtual void BeginReadSurfaces( Surfaces value ) {}
		public virtual void EndReadSurfaces() {}
		public virtual void BeginReadSurface( Surface value ) {}
		public virtual void EndReadSurface() {}
		public virtual void BeginReadSourceData( SourceData value ) {}
		public virtual void EndReadSourceData() {}
		public virtual void BeginReadDataPoints( DataPoints value ) {}
		public virtual void EndReadDataPoints() {}
		public virtual void BeginReadPointFiles( PointFiles value ) {}
		public virtual void EndReadPointFiles() {}
		public virtual void BeginReadPointFile( PointFile value ) {}
		public virtual void EndReadPointFile() {}
		public virtual void BeginReadBoundaries( Boundaries value ) {}
		public virtual void EndReadBoundaries() {}
		public virtual void BeginReadBoundary( Boundary value ) {}
		public virtual void EndReadBoundary() {}
		public virtual void BeginReadBreaklines( Breaklines value ) {}
		public virtual void EndReadBreaklines() {}
		public virtual void BeginReadBreakline( Breakline value ) {}
		public virtual void EndReadBreakline() {}
		public virtual void BeginReadRetWall( RetWall value ) {}
		public virtual void EndReadRetWall() {}
		public virtual void BeginReadRetWallPnt( RetWallPnt value ) {}
		public virtual void EndReadRetWallPnt() {}
		public virtual void BeginReadContours( Contours value ) {}
		public virtual void EndReadContours() {}
		public virtual void BeginReadContour( Contour value ) {}
		public virtual void EndReadContour() {}
		public virtual void BeginReadDefinition( Definition value ) {}
		public virtual void EndReadDefinition() {}
		public virtual void BeginReadPnts( Pnts value ) {}
		public virtual void EndReadPnts() {}
		public virtual void BeginReadP( P value ) {}
		public virtual void EndReadP() {}
		public virtual void BeginReadFaces( Faces value ) {}
		public virtual void EndReadFaces() {}
		public virtual void BeginReadWatersheds( Watersheds value ) {}
		public virtual void EndReadWatersheds() {}
		public virtual void BeginReadWatershed( Watershed value ) {}
		public virtual void EndReadWatershed() {}
		public virtual void BeginReadOutlet( Outlet value ) {}
		public virtual void EndReadOutlet() {}
		public virtual void BeginReadSurfVolumes( SurfVolumes value ) {}
		public virtual void EndReadSurfVolumes() {}
		public virtual void BeginReadSurfVolume( SurfVolume value ) {}
		public virtual void EndReadSurfVolume() {}
		public virtual void BeginReadParcels( Parcels value ) {}
		public virtual void EndReadParcels() {}
		public virtual void BeginReadParcel( Parcel value ) {}
		public virtual void EndReadParcel() {}
		public virtual void BeginReadTitle( Title value ) {}
		public virtual void EndReadTitle() {}
		public virtual void BeginReadAlignments( Alignments value ) {}
		public virtual void EndReadAlignments() {}
		public virtual void BeginReadAlignment( Alignment value ) {}
		public virtual void EndReadAlignment() {}
		public virtual void BeginReadStaEquation( StaEquation value ) {}
		public virtual void EndReadStaEquation() {}
		public virtual void BeginReadProfile( Profile value ) {}
		public virtual void EndReadProfile() {}
		public virtual void BeginReadProfSurf( ProfSurf value ) {}
		public virtual void EndReadProfSurf() {}
		public virtual void BeginReadProfAlign( ProfAlign value ) {}
		public virtual void EndReadProfAlign() {}
		public virtual void BeginReadPVI( PVI value ) {}
		public virtual void EndReadPVI() {}
		public virtual void BeginReadParaCurve( ParaCurve value ) {}
		public virtual void EndReadParaCurve() {}
		public virtual void BeginReadUnsymParaCurve( UnsymParaCurve value ) {}
		public virtual void EndReadUnsymParaCurve() {}
		public virtual void BeginReadCircCurve( CircCurve value ) {}
		public virtual void EndReadCircCurve() {}
		public virtual void BeginReadPipeNetworks( PipeNetworks value ) {}
		public virtual void EndReadPipeNetworks() {}
		public virtual void BeginReadPipeNetwork( PipeNetwork value ) {}
		public virtual void EndReadPipeNetwork() {}
		public virtual void BeginReadPipes( Pipes value ) {}
		public virtual void EndReadPipes() {}
		public virtual void BeginReadPipe( Pipe value ) {}
		public virtual void EndReadPipe() {}
		public virtual void BeginReadCircPipe( CircPipe value ) {}
		public virtual void EndReadCircPipe() {}
		public virtual void BeginReadElliPipe( ElliPipe value ) {}
		public virtual void EndReadElliPipe() {}
		public virtual void BeginReadRectPipe( RectPipe value ) {}
		public virtual void EndReadRectPipe() {}
		public virtual void BeginReadChannel( Channel value ) {}
		public virtual void EndReadChannel() {}
		public virtual void BeginReadPipeFlow( PipeFlow value ) {}
		public virtual void EndReadPipeFlow() {}
		public virtual void BeginReadStructs( Structs value ) {}
		public virtual void EndReadStructs() {}
		public virtual void BeginReadStruct( Struct value ) {}
		public virtual void EndReadStruct() {}
		public virtual void BeginReadCircStruct( CircStruct value ) {}
		public virtual void EndReadCircStruct() {}
		public virtual void BeginReadRectStruct( RectStruct value ) {}
		public virtual void EndReadRectStruct() {}
		public virtual void BeginReadInletStruct( InletStruct value ) {}
		public virtual void EndReadInletStruct() {}
		public virtual void BeginReadOutletStruct( OutletStruct value ) {}
		public virtual void EndReadOutletStruct() {}
		public virtual void BeginReadConnection( Connection value ) {}
		public virtual void EndReadConnection() {}
		public virtual void BeginReadInvert( Invert value ) {}
		public virtual void EndReadInvert() {}
		public virtual void BeginReadStructFlow( StructFlow value ) {}
		public virtual void EndReadStructFlow() {}
		public virtual void BeginReadPlanFeatures( PlanFeatures value ) {}
		public virtual void EndReadPlanFeatures() {}
		public virtual void BeginReadPlanFeature( PlanFeature value ) {}
		public virtual void EndReadPlanFeature() {}
		public virtual void BeginReadGradeModel( GradeModel value ) {}
		public virtual void EndReadGradeModel() {}
		public virtual void BeginReadGradeSurface( GradeSurface value ) {}
		public virtual void EndReadGradeSurface() {}
		public virtual void BeginReadZones( Zones value ) {}
		public virtual void EndReadZones() {}
		public virtual void BeginReadZone( Zone value ) {}
		public virtual void EndReadZone() {}
		public virtual void BeginReadZoneWidth( ZoneWidth value ) {}
		public virtual void EndReadZoneWidth() {}
		public virtual void BeginReadZoneSlope( ZoneSlope value ) {}
		public virtual void EndReadZoneSlope() {}
		public virtual void BeginReadZoneHinge( ZoneHinge value ) {}
		public virtual void EndReadZoneHinge() {}
		public virtual void BeginReadZoneCutFill( ZoneCutFill value ) {}
		public virtual void EndReadZoneCutFill() {}
		public virtual void BeginReadZoneMaterial( ZoneMaterial value ) {}
		public virtual void EndReadZoneMaterial() {}
		public virtual void BeginReadZoneCrossSectStructure( ZoneCrossSectStructure value ) {}
		public virtual void EndReadZoneCrossSectStructure() {}
		public virtual void BeginReadRoadways( Roadways value ) {}
		public virtual void EndReadRoadways() {}
		public virtual void BeginReadRoadway( Roadway value ) {}
		public virtual void EndReadRoadway() {}
		public virtual void BeginReadClassification( Classification value ) {}
		public virtual void EndReadClassification() {}
		public virtual void BeginReadDesignSpeed( DesignSpeed value ) {}
		public virtual void EndReadDesignSpeed() {}
		public virtual void BeginReadDesignSpeed85th( DesignSpeed85th value ) {}
		public virtual void EndReadDesignSpeed85th() {}
		public virtual void BeginReadSpeeds( Speeds value ) {}
		public virtual void EndReadSpeeds() {}
		public virtual void BeginReadDailyTrafficVolume( DailyTrafficVolume value ) {}
		public virtual void EndReadDailyTrafficVolume() {}
		public virtual void BeginReadDesignHour( DesignHour value ) {}
		public virtual void EndReadDesignHour() {}
		public virtual void BeginReadPeakHour( PeakHour value ) {}
		public virtual void EndReadPeakHour() {}
		public virtual void BeginReadTrafficVolume( TrafficVolume value ) {}
		public virtual void EndReadTrafficVolume() {}
		public virtual void BeginReadSuperelevation( Superelevation value ) {}
		public virtual void EndReadSuperelevation() {}
		public virtual void BeginReadLanes( Lanes value ) {}
		public virtual void EndReadLanes() {}
		public virtual void BeginReadThruLane( ThruLane value ) {}
		public virtual void EndReadThruLane() {}
		public virtual void BeginReadPassingLane( PassingLane value ) {}
		public virtual void EndReadPassingLane() {}
		public virtual void BeginReadTurnLane( TurnLane value ) {}
		public virtual void EndReadTurnLane() {}
		public virtual void BeginReadTwoWayLeftTurnLane( TwoWayLeftTurnLane value ) {}
		public virtual void EndReadTwoWayLeftTurnLane() {}
		public virtual void BeginReadClimbLane( ClimbLane value ) {}
		public virtual void EndReadClimbLane() {}
		public virtual void BeginReadOffsetLane( OffsetLane value ) {}
		public virtual void EndReadOffsetLane() {}
		public virtual void BeginReadWideningLane( WideningLane value ) {}
		public virtual void EndReadWideningLane() {}
		public virtual void BeginReadRoadside( Roadside value ) {}
		public virtual void EndReadRoadside() {}
		public virtual void BeginReadDitch( Ditch value ) {}
		public virtual void EndReadDitch() {}
		public virtual void BeginReadObstructionOffset( ObstructionOffset value ) {}
		public virtual void EndReadObstructionOffset() {}
		public virtual void BeginReadBikeFacilities( BikeFacilities value ) {}
		public virtual void EndReadBikeFacilities() {}
		public virtual void BeginReadRoadSign( RoadSign value ) {}
		public virtual void EndReadRoadSign() {}
		public virtual void BeginReadDrivewayDensity( DrivewayDensity value ) {}
		public virtual void EndReadDrivewayDensity() {}
		public virtual void BeginReadHazardRating( HazardRating value ) {}
		public virtual void EndReadHazardRating() {}
		public virtual void BeginReadIntersections( Intersections value ) {}
		public virtual void EndReadIntersections() {}
		public virtual void BeginReadIntersection( Intersection value ) {}
		public virtual void EndReadIntersection() {}
		public virtual void BeginReadTrafficControl( TrafficControl value ) {}
		public virtual void EndReadTrafficControl() {}
		public virtual void BeginReadTiming( Timing value ) {}
		public virtual void EndReadTiming() {}
		public virtual void BeginReadVolume( Volume value ) {}
		public virtual void EndReadVolume() {}
		public virtual void BeginReadTurnSpeed( TurnSpeed value ) {}
		public virtual void EndReadTurnSpeed() {}
		public virtual void BeginReadTurnRestriction( TurnRestriction value ) {}
		public virtual void EndReadTurnRestriction() {}
		public virtual void BeginReadCurb( Curb value ) {}
		public virtual void EndReadCurb() {}
		public virtual void BeginReadCorner( Corner value ) {}
		public virtual void EndReadCorner() {}
		public virtual void BeginReadCrashData( CrashData value ) {}
		public virtual void EndReadCrashData() {}
		public virtual void BeginReadCrashHistory( CrashHistory value ) {}
		public virtual void EndReadCrashHistory() {}
		public virtual void BeginReadPostedSpeed( PostedSpeed value ) {}
		public virtual void EndReadPostedSpeed() {}
		public virtual void BeginReadNoPassingZone( NoPassingZone value ) {}
		public virtual void EndReadNoPassingZone() {}
		public virtual void BeginReadDecisionSightDistance( DecisionSightDistance value ) {}
		public virtual void EndReadDecisionSightDistance() {}
		public virtual void BeginReadBridgeElement( BridgeElement value ) {}
		public virtual void EndReadBridgeElement() {}
	}
	public class TestLandXmlEvents : ILandXmlEvents
	{
		public bool AsXml { get; set; }
		public void DebugWrite(string outFile)
		{
			using (FileStream fstream = new FileInfo(outFile).Open(FileMode.Create, FileAccess.Write))
			using (StreamWriter stream = new StreamWriter(fstream))
			using (TextWriterEx writer = new TextWriterEx(stream))
			{
				writer.WriteLine(this.buff.Inner);
			}
		}
		private readonly TextWriterEx buff = new TextWriterEx(new StringWriter());
		public virtual void BeginReadPntList2D( IList<double> value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PntList2D>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPntList2D");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPntList2D()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PntList2D>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPntList2D");
			}
		}
		public virtual void BeginReadPntList3D( IList<double> value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PntList3D>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPntList3D");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPntList3D()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PntList3D>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPntList3D");
			}
		}
		public virtual void BeginReadF( IList<int> value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<F>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadF");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadF()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</F>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadF");
			}
		}
		public virtual void BeginReadBeginRunoutSta( double value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<BeginRunoutSta>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBeginRunoutSta");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBeginRunoutSta()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</BeginRunoutSta>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBeginRunoutSta");
			}
		}
		public virtual void BeginReadBeginRunoffSta( double value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<BeginRunoffSta>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBeginRunoffSta");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBeginRunoffSta()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</BeginRunoffSta>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBeginRunoffSta");
			}
		}
		public virtual void BeginReadFullSuperSta( double value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<FullSuperSta>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadFullSuperSta");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadFullSuperSta()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</FullSuperSta>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadFullSuperSta");
			}
		}
		public virtual void BeginReadFullSuperelev( double value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<FullSuperelev>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadFullSuperelev");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadFullSuperelev()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</FullSuperelev>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadFullSuperelev");
			}
		}
		public virtual void BeginReadRunoffSta( double value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<RunoffSta>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRunoffSta");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRunoffSta()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</RunoffSta>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRunoffSta");
			}
		}
		public virtual void BeginReadStartofRunoutSta( double value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<StartofRunoutSta>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadStartofRunoutSta");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadStartofRunoutSta()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</StartofRunoutSta>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadStartofRunoutSta");
			}
		}
		public virtual void BeginReadEndofRunoutSta( double value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<EndofRunoutSta>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadEndofRunoutSta");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadEndofRunoutSta()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</EndofRunoutSta>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadEndofRunoutSta");
			}
		}
		public virtual void BeginReadAdverseSE( AdverseSEType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<AdverseSE>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadAdverseSE");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadAdverseSE()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</AdverseSE>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadAdverseSE");
			}
		}
		public virtual void BeginReadLandXML( LandXML value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<LandXML>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadLandXML");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadLandXML()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</LandXML>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadLandXML");
			}
		}
		public virtual void BeginReadCgPoints( CgPoints value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CgPoints>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCgPoints");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCgPoints()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CgPoints>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCgPoints");
			}
		}
		public virtual void BeginReadCgPoint( CgPoint value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CgPoint>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCgPoint");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCgPoint()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CgPoint>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCgPoint");
			}
		}
		public virtual void BeginReadDocFileRef( DocFileRef value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<DocFileRef>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDocFileRef");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDocFileRef()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</DocFileRef>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDocFileRef");
			}
		}
		public virtual void BeginReadFeature( Feature value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Feature>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadFeature");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadFeature()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Feature>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadFeature");
			}
		}
		public virtual void BeginReadProperty( Property value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Property>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadProperty");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadProperty()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Property>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadProperty");
			}
		}
		public virtual void BeginReadStart( PointType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Start>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadStart");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadStart()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Start>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadStart");
			}
		}
		public virtual void BeginReadEnd( PointType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<End>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadEnd");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadEnd()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</End>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadEnd");
			}
		}
		public virtual void BeginReadCenter( PointType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Center>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCenter");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCenter()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Center>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCenter");
			}
		}
		public virtual void BeginReadPI( PointType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PI>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPI");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPI()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PI>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPI");
			}
		}
		public virtual void BeginReadMapPoint( PointType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<MapPoint>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadMapPoint");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadMapPoint()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</MapPoint>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadMapPoint");
			}
		}
		public virtual void BeginReadInstrumentPoint( PointType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<InstrumentPoint>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadInstrumentPoint");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadInstrumentPoint()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</InstrumentPoint>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadInstrumentPoint");
			}
		}
		public virtual void BeginReadLocation( PointType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Location>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadLocation");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadLocation()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Location>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadLocation");
			}
		}
		public virtual void BeginReadIrregularLine( IrregularLine value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<IrregularLine>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadIrregularLine");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadIrregularLine()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</IrregularLine>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadIrregularLine");
			}
		}
		public virtual void BeginReadChain( Chain value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Chain>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadChain");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadChain()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Chain>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadChain");
			}
		}
		public virtual void BeginReadCurve( Curve value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Curve>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCurve");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCurve()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Curve>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCurve");
			}
		}
		public virtual void BeginReadSpiral( Spiral value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Spiral>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSpiral");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSpiral()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Spiral>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSpiral");
			}
		}
		public virtual void BeginReadCoordGeom( CoordGeom value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CoordGeom>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCoordGeom");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCoordGeom()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CoordGeom>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCoordGeom");
			}
		}
		public virtual void BeginReadLine( Line value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Line>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadLine");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadLine()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Line>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadLine");
			}
		}
		public virtual void BeginReadCrossSects( CrossSects value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CrossSects>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCrossSects");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCrossSects()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CrossSects>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCrossSects");
			}
		}
		public virtual void BeginReadCrossSect( CrossSect value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CrossSect>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCrossSect");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCrossSect()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CrossSect>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCrossSect");
			}
		}
		public virtual void BeginReadCrossSectSurf( CrossSectSurf value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CrossSectSurf>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCrossSectSurf");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCrossSectSurf()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CrossSectSurf>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCrossSectSurf");
			}
		}
		public virtual void BeginReadProject( Project value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Project>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadProject");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadProject()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Project>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadProject");
			}
		}
		public virtual void BeginReadUnits( Units value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Units>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadUnits");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadUnits()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Units>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadUnits");
			}
		}
		public virtual void BeginReadMetric( Metric value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Metric>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadMetric");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadMetric()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Metric>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadMetric");
			}
		}
		public virtual void BeginReadImperial( Imperial value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Imperial>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadImperial");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadImperial()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Imperial>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadImperial");
			}
		}
		public virtual void BeginReadCoordinateSystem( CoordinateSystem value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CoordinateSystem>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCoordinateSystem");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCoordinateSystem()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CoordinateSystem>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCoordinateSystem");
			}
		}
		public virtual void BeginReadApplication( Application value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Application>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadApplication");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadApplication()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Application>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadApplication");
			}
		}
		public virtual void BeginReadAuthor( Author value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Author>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadAuthor");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadAuthor()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Author>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadAuthor");
			}
		}
		public virtual void BeginReadSurvey( Survey value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Survey>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSurvey");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSurvey()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Survey>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSurvey");
			}
		}
		public virtual void BeginReadSurveyHeader( SurveyHeader value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<SurveyHeader>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSurveyHeader");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSurveyHeader()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</SurveyHeader>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSurveyHeader");
			}
		}
		public virtual void BeginReadPersonnel( Personnel value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Personnel>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPersonnel");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPersonnel()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Personnel>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPersonnel");
			}
		}
		public virtual void BeginReadFieldNote( FieldNote value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<FieldNote>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadFieldNote");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadFieldNote()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</FieldNote>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadFieldNote");
			}
		}
		public virtual void BeginReadEquipment( Equipment value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Equipment>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadEquipment");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadEquipment()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Equipment>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadEquipment");
			}
		}
		public virtual void BeginReadInstrumentDetails( InstrumentDetails value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<InstrumentDetails>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadInstrumentDetails");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadInstrumentDetails()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</InstrumentDetails>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadInstrumentDetails");
			}
		}
		public virtual void BeginReadLaserDetails( LaserDetails value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<LaserDetails>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadLaserDetails");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadLaserDetails()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</LaserDetails>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadLaserDetails");
			}
		}
		public virtual void BeginReadGPSAntennaDetails( GPSAntennaDetails value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<GPSAntennaDetails>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadGPSAntennaDetails");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadGPSAntennaDetails()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</GPSAntennaDetails>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadGPSAntennaDetails");
			}
		}
		public virtual void BeginReadGPSReceiverDetails( GPSReceiverDetails value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<GPSReceiverDetails>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadGPSReceiverDetails");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadGPSReceiverDetails()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</GPSReceiverDetails>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadGPSReceiverDetails");
			}
		}
		public virtual void BeginReadCorrections( Corrections value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Corrections>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCorrections");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCorrections()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Corrections>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCorrections");
			}
		}
		public virtual void BeginReadSurveyMonument( SurveyMonument value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<SurveyMonument>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSurveyMonument");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSurveyMonument()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</SurveyMonument>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSurveyMonument");
			}
		}
		public virtual void BeginReadInstrumentSetup( InstrumentSetup value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<InstrumentSetup>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadInstrumentSetup");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadInstrumentSetup()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</InstrumentSetup>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadInstrumentSetup");
			}
		}
		public virtual void BeginReadLaserSetup( LaserSetup value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<LaserSetup>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadLaserSetup");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadLaserSetup()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</LaserSetup>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadLaserSetup");
			}
		}
		public virtual void BeginReadGPSSetup( GPSSetup value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<GPSSetup>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadGPSSetup");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadGPSSetup()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</GPSSetup>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadGPSSetup");
			}
		}
		public virtual void BeginReadTargetSetup( TargetSetup value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<TargetSetup>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTargetSetup");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTargetSetup()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</TargetSetup>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTargetSetup");
			}
		}
		public virtual void BeginReadBacksight( Backsight value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Backsight>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBacksight");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBacksight()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Backsight>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBacksight");
			}
		}
		public virtual void BeginReadRawObservation( RawObservation value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<RawObservation>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRawObservation");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRawObservation()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</RawObservation>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRawObservation");
			}
		}
		public virtual void BeginReadTargetPoint( PointType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<TargetPoint>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTargetPoint");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTargetPoint()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</TargetPoint>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTargetPoint");
			}
		}
		public virtual void BeginReadBacksightPoint( PointType value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<BacksightPoint>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBacksightPoint");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBacksightPoint()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</BacksightPoint>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBacksightPoint");
			}
		}
		public virtual void BeginReadOffsetVals( OffsetVals value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<OffsetVals>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadOffsetVals");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadOffsetVals()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</OffsetVals>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadOffsetVals");
			}
		}
		public virtual void BeginReadGPSVector( GPSVector value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<GPSVector>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadGPSVector");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadGPSVector()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</GPSVector>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadGPSVector");
			}
		}
		public virtual void BeginReadGPSPosition( GPSPosition value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<GPSPosition>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadGPSPosition");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadGPSPosition()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</GPSPosition>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadGPSPosition");
			}
		}
		public virtual void BeginReadGPSQCInfoLevel1( GPSQCInfoLevel1 value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<GPSQCInfoLevel1>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadGPSQCInfoLevel1");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadGPSQCInfoLevel1()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</GPSQCInfoLevel1>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadGPSQCInfoLevel1");
			}
		}
		public virtual void BeginReadGPSQCInfoLevel2( GPSQCInfoLevel2 value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<GPSQCInfoLevel2>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadGPSQCInfoLevel2");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadGPSQCInfoLevel2()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</GPSQCInfoLevel2>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadGPSQCInfoLevel2");
			}
		}
		public virtual void BeginReadObservationGroup( ObservationGroup value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ObservationGroup>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadObservationGroup");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadObservationGroup()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ObservationGroup>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadObservationGroup");
			}
		}
		public virtual void BeginReadControlChecks( ControlChecks value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ControlChecks>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadControlChecks");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadControlChecks()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ControlChecks>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadControlChecks");
			}
		}
		public virtual void BeginReadPointResults( PointResults value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PointResults>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPointResults");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPointResults()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PointResults>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPointResults");
			}
		}
		public virtual void BeginReadReducedObservation( ReducedObservation value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ReducedObservation>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadReducedObservation");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadReducedObservation()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ReducedObservation>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadReducedObservation");
			}
		}
		public virtual void BeginReadReducedArcObservation( ReducedArcObservation value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ReducedArcObservation>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadReducedArcObservation");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadReducedArcObservation()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ReducedArcObservation>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadReducedArcObservation");
			}
		}
		public virtual void BeginReadMonuments( Monuments value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Monuments>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadMonuments");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadMonuments()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Monuments>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadMonuments");
			}
		}
		public virtual void BeginReadMonument( Monument value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Monument>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadMonument");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadMonument()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Monument>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadMonument");
			}
		}
		public virtual void BeginReadSurfaces( Surfaces value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Surfaces>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSurfaces");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSurfaces()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Surfaces>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSurfaces");
			}
		}
		public virtual void BeginReadSurface( Surface value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Surface>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSurface");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSurface()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Surface>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSurface");
			}
		}
		public virtual void BeginReadSourceData( SourceData value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<SourceData>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSourceData");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSourceData()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</SourceData>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSourceData");
			}
		}
		public virtual void BeginReadDataPoints( DataPoints value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<DataPoints>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDataPoints");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDataPoints()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</DataPoints>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDataPoints");
			}
		}
		public virtual void BeginReadPointFiles( PointFiles value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PointFiles>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPointFiles");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPointFiles()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PointFiles>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPointFiles");
			}
		}
		public virtual void BeginReadPointFile( PointFile value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PointFile>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPointFile");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPointFile()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PointFile>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPointFile");
			}
		}
		public virtual void BeginReadBoundaries( Boundaries value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Boundaries>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBoundaries");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBoundaries()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Boundaries>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBoundaries");
			}
		}
		public virtual void BeginReadBoundary( Boundary value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Boundary>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBoundary");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBoundary()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Boundary>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBoundary");
			}
		}
		public virtual void BeginReadBreaklines( Breaklines value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Breaklines>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBreaklines");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBreaklines()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Breaklines>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBreaklines");
			}
		}
		public virtual void BeginReadBreakline( Breakline value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Breakline>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBreakline");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBreakline()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Breakline>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBreakline");
			}
		}
		public virtual void BeginReadRetWall( RetWall value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<RetWall>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRetWall");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRetWall()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</RetWall>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRetWall");
			}
		}
		public virtual void BeginReadRetWallPnt( RetWallPnt value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<RetWallPnt>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRetWallPnt");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRetWallPnt()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</RetWallPnt>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRetWallPnt");
			}
		}
		public virtual void BeginReadContours( Contours value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Contours>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadContours");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadContours()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Contours>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadContours");
			}
		}
		public virtual void BeginReadContour( Contour value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Contour>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadContour");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadContour()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Contour>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadContour");
			}
		}
		public virtual void BeginReadDefinition( Definition value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Definition>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDefinition");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDefinition()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Definition>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDefinition");
			}
		}
		public virtual void BeginReadPnts( Pnts value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Pnts>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPnts");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPnts()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Pnts>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPnts");
			}
		}
		public virtual void BeginReadP( P value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<P>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadP");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadP()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</P>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadP");
			}
		}
		public virtual void BeginReadFaces( Faces value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Faces>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadFaces");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadFaces()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Faces>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadFaces");
			}
		}
		public virtual void BeginReadWatersheds( Watersheds value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Watersheds>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadWatersheds");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadWatersheds()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Watersheds>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadWatersheds");
			}
		}
		public virtual void BeginReadWatershed( Watershed value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Watershed>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadWatershed");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadWatershed()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Watershed>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadWatershed");
			}
		}
		public virtual void BeginReadOutlet( Outlet value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Outlet>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadOutlet");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadOutlet()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Outlet>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadOutlet");
			}
		}
		public virtual void BeginReadSurfVolumes( SurfVolumes value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<SurfVolumes>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSurfVolumes");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSurfVolumes()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</SurfVolumes>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSurfVolumes");
			}
		}
		public virtual void BeginReadSurfVolume( SurfVolume value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<SurfVolume>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSurfVolume");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSurfVolume()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</SurfVolume>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSurfVolume");
			}
		}
		public virtual void BeginReadParcels( Parcels value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Parcels>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadParcels");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadParcels()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Parcels>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadParcels");
			}
		}
		public virtual void BeginReadParcel( Parcel value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Parcel>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadParcel");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadParcel()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Parcel>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadParcel");
			}
		}
		public virtual void BeginReadTitle( Title value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Title>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTitle");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTitle()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Title>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTitle");
			}
		}
		public virtual void BeginReadAlignments( Alignments value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Alignments>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadAlignments");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadAlignments()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Alignments>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadAlignments");
			}
		}
		public virtual void BeginReadAlignment( Alignment value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Alignment>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadAlignment");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadAlignment()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Alignment>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadAlignment");
			}
		}
		public virtual void BeginReadStaEquation( StaEquation value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<StaEquation>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadStaEquation");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadStaEquation()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</StaEquation>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadStaEquation");
			}
		}
		public virtual void BeginReadProfile( Profile value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Profile>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadProfile");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadProfile()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Profile>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadProfile");
			}
		}
		public virtual void BeginReadProfSurf( ProfSurf value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ProfSurf>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadProfSurf");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadProfSurf()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ProfSurf>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadProfSurf");
			}
		}
		public virtual void BeginReadProfAlign( ProfAlign value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ProfAlign>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadProfAlign");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadProfAlign()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ProfAlign>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadProfAlign");
			}
		}
		public virtual void BeginReadPVI( PVI value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PVI>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPVI");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPVI()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PVI>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPVI");
			}
		}
		public virtual void BeginReadParaCurve( ParaCurve value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ParaCurve>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadParaCurve");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadParaCurve()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ParaCurve>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadParaCurve");
			}
		}
		public virtual void BeginReadUnsymParaCurve( UnsymParaCurve value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<UnsymParaCurve>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadUnsymParaCurve");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadUnsymParaCurve()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</UnsymParaCurve>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadUnsymParaCurve");
			}
		}
		public virtual void BeginReadCircCurve( CircCurve value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CircCurve>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCircCurve");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCircCurve()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CircCurve>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCircCurve");
			}
		}
		public virtual void BeginReadPipeNetworks( PipeNetworks value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PipeNetworks>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPipeNetworks");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPipeNetworks()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PipeNetworks>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPipeNetworks");
			}
		}
		public virtual void BeginReadPipeNetwork( PipeNetwork value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PipeNetwork>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPipeNetwork");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPipeNetwork()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PipeNetwork>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPipeNetwork");
			}
		}
		public virtual void BeginReadPipes( Pipes value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Pipes>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPipes");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPipes()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Pipes>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPipes");
			}
		}
		public virtual void BeginReadPipe( Pipe value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Pipe>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPipe");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPipe()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Pipe>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPipe");
			}
		}
		public virtual void BeginReadCircPipe( CircPipe value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CircPipe>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCircPipe");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCircPipe()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CircPipe>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCircPipe");
			}
		}
		public virtual void BeginReadElliPipe( ElliPipe value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ElliPipe>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadElliPipe");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadElliPipe()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ElliPipe>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadElliPipe");
			}
		}
		public virtual void BeginReadRectPipe( RectPipe value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<RectPipe>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRectPipe");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRectPipe()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</RectPipe>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRectPipe");
			}
		}
		public virtual void BeginReadChannel( Channel value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Channel>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadChannel");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadChannel()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Channel>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadChannel");
			}
		}
		public virtual void BeginReadPipeFlow( PipeFlow value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PipeFlow>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPipeFlow");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPipeFlow()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PipeFlow>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPipeFlow");
			}
		}
		public virtual void BeginReadStructs( Structs value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Structs>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadStructs");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadStructs()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Structs>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadStructs");
			}
		}
		public virtual void BeginReadStruct( Struct value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Struct>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadStruct");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadStruct()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Struct>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadStruct");
			}
		}
		public virtual void BeginReadCircStruct( CircStruct value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CircStruct>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCircStruct");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCircStruct()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CircStruct>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCircStruct");
			}
		}
		public virtual void BeginReadRectStruct( RectStruct value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<RectStruct>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRectStruct");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRectStruct()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</RectStruct>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRectStruct");
			}
		}
		public virtual void BeginReadInletStruct( InletStruct value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<InletStruct>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadInletStruct");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadInletStruct()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</InletStruct>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadInletStruct");
			}
		}
		public virtual void BeginReadOutletStruct( OutletStruct value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<OutletStruct>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadOutletStruct");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadOutletStruct()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</OutletStruct>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadOutletStruct");
			}
		}
		public virtual void BeginReadConnection( Connection value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Connection>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadConnection");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadConnection()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Connection>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadConnection");
			}
		}
		public virtual void BeginReadInvert( Invert value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Invert>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadInvert");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadInvert()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Invert>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadInvert");
			}
		}
		public virtual void BeginReadStructFlow( StructFlow value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<StructFlow>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadStructFlow");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadStructFlow()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</StructFlow>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadStructFlow");
			}
		}
		public virtual void BeginReadPlanFeatures( PlanFeatures value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PlanFeatures>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPlanFeatures");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPlanFeatures()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PlanFeatures>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPlanFeatures");
			}
		}
		public virtual void BeginReadPlanFeature( PlanFeature value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PlanFeature>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPlanFeature");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPlanFeature()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PlanFeature>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPlanFeature");
			}
		}
		public virtual void BeginReadGradeModel( GradeModel value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<GradeModel>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadGradeModel");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadGradeModel()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</GradeModel>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadGradeModel");
			}
		}
		public virtual void BeginReadGradeSurface( GradeSurface value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<GradeSurface>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadGradeSurface");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadGradeSurface()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</GradeSurface>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadGradeSurface");
			}
		}
		public virtual void BeginReadZones( Zones value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Zones>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadZones");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadZones()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Zones>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadZones");
			}
		}
		public virtual void BeginReadZone( Zone value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Zone>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadZone");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadZone()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Zone>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadZone");
			}
		}
		public virtual void BeginReadZoneWidth( ZoneWidth value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ZoneWidth>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadZoneWidth");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadZoneWidth()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ZoneWidth>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadZoneWidth");
			}
		}
		public virtual void BeginReadZoneSlope( ZoneSlope value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ZoneSlope>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadZoneSlope");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadZoneSlope()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ZoneSlope>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadZoneSlope");
			}
		}
		public virtual void BeginReadZoneHinge( ZoneHinge value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ZoneHinge>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadZoneHinge");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadZoneHinge()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ZoneHinge>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadZoneHinge");
			}
		}
		public virtual void BeginReadZoneCutFill( ZoneCutFill value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ZoneCutFill>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadZoneCutFill");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadZoneCutFill()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ZoneCutFill>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadZoneCutFill");
			}
		}
		public virtual void BeginReadZoneMaterial( ZoneMaterial value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ZoneMaterial>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadZoneMaterial");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadZoneMaterial()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ZoneMaterial>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadZoneMaterial");
			}
		}
		public virtual void BeginReadZoneCrossSectStructure( ZoneCrossSectStructure value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ZoneCrossSectStructure>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadZoneCrossSectStructure");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadZoneCrossSectStructure()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ZoneCrossSectStructure>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadZoneCrossSectStructure");
			}
		}
		public virtual void BeginReadRoadways( Roadways value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Roadways>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRoadways");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRoadways()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Roadways>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRoadways");
			}
		}
		public virtual void BeginReadRoadway( Roadway value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Roadway>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRoadway");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRoadway()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Roadway>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRoadway");
			}
		}
		public virtual void BeginReadClassification( Classification value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Classification>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadClassification");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadClassification()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Classification>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadClassification");
			}
		}
		public virtual void BeginReadDesignSpeed( DesignSpeed value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<DesignSpeed>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDesignSpeed");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDesignSpeed()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</DesignSpeed>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDesignSpeed");
			}
		}
		public virtual void BeginReadDesignSpeed85th( DesignSpeed85th value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<DesignSpeed85th>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDesignSpeed85th");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDesignSpeed85th()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</DesignSpeed85th>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDesignSpeed85th");
			}
		}
		public virtual void BeginReadSpeeds( Speeds value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Speeds>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSpeeds");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSpeeds()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Speeds>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSpeeds");
			}
		}
		public virtual void BeginReadDailyTrafficVolume( DailyTrafficVolume value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<DailyTrafficVolume>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDailyTrafficVolume");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDailyTrafficVolume()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</DailyTrafficVolume>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDailyTrafficVolume");
			}
		}
		public virtual void BeginReadDesignHour( DesignHour value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<DesignHour>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDesignHour");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDesignHour()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</DesignHour>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDesignHour");
			}
		}
		public virtual void BeginReadPeakHour( PeakHour value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PeakHour>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPeakHour");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPeakHour()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PeakHour>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPeakHour");
			}
		}
		public virtual void BeginReadTrafficVolume( TrafficVolume value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<TrafficVolume>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTrafficVolume");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTrafficVolume()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</TrafficVolume>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTrafficVolume");
			}
		}
		public virtual void BeginReadSuperelevation( Superelevation value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Superelevation>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadSuperelevation");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadSuperelevation()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Superelevation>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadSuperelevation");
			}
		}
		public virtual void BeginReadLanes( Lanes value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Lanes>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadLanes");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadLanes()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Lanes>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadLanes");
			}
		}
		public virtual void BeginReadThruLane( ThruLane value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ThruLane>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadThruLane");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadThruLane()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ThruLane>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadThruLane");
			}
		}
		public virtual void BeginReadPassingLane( PassingLane value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PassingLane>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPassingLane");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPassingLane()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PassingLane>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPassingLane");
			}
		}
		public virtual void BeginReadTurnLane( TurnLane value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<TurnLane>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTurnLane");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTurnLane()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</TurnLane>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTurnLane");
			}
		}
		public virtual void BeginReadTwoWayLeftTurnLane( TwoWayLeftTurnLane value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<TwoWayLeftTurnLane>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTwoWayLeftTurnLane");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTwoWayLeftTurnLane()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</TwoWayLeftTurnLane>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTwoWayLeftTurnLane");
			}
		}
		public virtual void BeginReadClimbLane( ClimbLane value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ClimbLane>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadClimbLane");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadClimbLane()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ClimbLane>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadClimbLane");
			}
		}
		public virtual void BeginReadOffsetLane( OffsetLane value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<OffsetLane>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadOffsetLane");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadOffsetLane()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</OffsetLane>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadOffsetLane");
			}
		}
		public virtual void BeginReadWideningLane( WideningLane value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<WideningLane>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadWideningLane");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadWideningLane()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</WideningLane>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadWideningLane");
			}
		}
		public virtual void BeginReadRoadside( Roadside value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Roadside>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRoadside");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRoadside()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Roadside>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRoadside");
			}
		}
		public virtual void BeginReadDitch( Ditch value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Ditch>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDitch");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDitch()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Ditch>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDitch");
			}
		}
		public virtual void BeginReadObstructionOffset( ObstructionOffset value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<ObstructionOffset>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadObstructionOffset");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadObstructionOffset()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</ObstructionOffset>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadObstructionOffset");
			}
		}
		public virtual void BeginReadBikeFacilities( BikeFacilities value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<BikeFacilities>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBikeFacilities");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBikeFacilities()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</BikeFacilities>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBikeFacilities");
			}
		}
		public virtual void BeginReadRoadSign( RoadSign value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<RoadSign>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadRoadSign");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadRoadSign()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</RoadSign>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadRoadSign");
			}
		}
		public virtual void BeginReadDrivewayDensity( DrivewayDensity value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<DrivewayDensity>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDrivewayDensity");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDrivewayDensity()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</DrivewayDensity>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDrivewayDensity");
			}
		}
		public virtual void BeginReadHazardRating( HazardRating value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<HazardRating>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadHazardRating");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadHazardRating()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</HazardRating>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadHazardRating");
			}
		}
		public virtual void BeginReadIntersections( Intersections value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Intersections>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadIntersections");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadIntersections()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Intersections>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadIntersections");
			}
		}
		public virtual void BeginReadIntersection( Intersection value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Intersection>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadIntersection");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadIntersection()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Intersection>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadIntersection");
			}
		}
		public virtual void BeginReadTrafficControl( TrafficControl value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<TrafficControl>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTrafficControl");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTrafficControl()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</TrafficControl>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTrafficControl");
			}
		}
		public virtual void BeginReadTiming( Timing value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Timing>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTiming");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTiming()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Timing>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTiming");
			}
		}
		public virtual void BeginReadVolume( Volume value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Volume>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadVolume");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadVolume()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Volume>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadVolume");
			}
		}
		public virtual void BeginReadTurnSpeed( TurnSpeed value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<TurnSpeed>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTurnSpeed");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTurnSpeed()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</TurnSpeed>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTurnSpeed");
			}
		}
		public virtual void BeginReadTurnRestriction( TurnRestriction value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<TurnRestriction>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadTurnRestriction");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadTurnRestriction()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</TurnRestriction>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadTurnRestriction");
			}
		}
		public virtual void BeginReadCurb( Curb value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Curb>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCurb");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCurb()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Curb>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCurb");
			}
		}
		public virtual void BeginReadCorner( Corner value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<Corner>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCorner");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCorner()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</Corner>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCorner");
			}
		}
		public virtual void BeginReadCrashData( CrashData value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CrashData>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCrashData");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCrashData()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CrashData>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCrashData");
			}
		}
		public virtual void BeginReadCrashHistory( CrashHistory value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<CrashHistory>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadCrashHistory");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadCrashHistory()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</CrashHistory>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadCrashHistory");
			}
		}
		public virtual void BeginReadPostedSpeed( PostedSpeed value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<PostedSpeed>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadPostedSpeed");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadPostedSpeed()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</PostedSpeed>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadPostedSpeed");
			}
		}
		public virtual void BeginReadNoPassingZone( NoPassingZone value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<NoPassingZone>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadNoPassingZone");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadNoPassingZone()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</NoPassingZone>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadNoPassingZone");
			}
		}
		public virtual void BeginReadDecisionSightDistance( DecisionSightDistance value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<DecisionSightDistance>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadDecisionSightDistance");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadDecisionSightDistance()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</DecisionSightDistance>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadDecisionSightDistance");
			}
		}
		public virtual void BeginReadBridgeElement( BridgeElement value )
		{
			if (this.AsXml)
			{
				buff.WriteLine("<BridgeElement>");
				buff.Indent();
			}
			else
			{
				buff.WriteLine("BeginReadBridgeElement");
				buff.Indent();
				buff.WriteLine(value);
				buff.Indent();
			}
		}
		public virtual void EndReadBridgeElement()
		{
			if (this.AsXml)
			{
				buff.Unindent();
				buff.WriteLine("</BridgeElement>");
			}
			else
			{
				buff.Unindent();
				buff.Unindent();
				buff.WriteLine("EndReadBridgeElement");
			}
		}
	}
	public class LandXmlReader : SimpleReader
	{
		public LandXmlReader(ILandXmlEvents events)
			: base("http://www.landxml.org/schema/LandXML-1.0")
		{
			this.Register<IList<double>>("PntList2D", events.BeginReadPntList2D, events.EndReadPntList2D, true);
			this.Register<IList<double>>("PntList3D", events.BeginReadPntList3D, events.EndReadPntList3D, true);
			this.Register<IList<int>>("F", events.BeginReadF, events.EndReadF, true);
			this.Register<double>("BeginRunoutSta", events.BeginReadBeginRunoutSta, events.EndReadBeginRunoutSta, true);
			this.Register<double>("BeginRunoffSta", events.BeginReadBeginRunoffSta, events.EndReadBeginRunoffSta, true);
			this.Register<double>("FullSuperSta", events.BeginReadFullSuperSta, events.EndReadFullSuperSta, true);
			this.Register<double>("FullSuperelev", events.BeginReadFullSuperelev, events.EndReadFullSuperelev, true);
			this.Register<double>("RunoffSta", events.BeginReadRunoffSta, events.EndReadRunoffSta, true);
			this.Register<double>("StartofRunoutSta", events.BeginReadStartofRunoutSta, events.EndReadStartofRunoutSta, true);
			this.Register<double>("EndofRunoutSta", events.BeginReadEndofRunoutSta, events.EndReadEndofRunoutSta, true);
			this.Register<AdverseSEType>("AdverseSE", events.BeginReadAdverseSE, events.EndReadAdverseSE, true);
			this.Register<LandXML>("LandXML", events.BeginReadLandXML, events.EndReadLandXML, false);
			this.Register<CgPoints>("CgPoints", events.BeginReadCgPoints, events.EndReadCgPoints, false);
			this.Register<CgPoint>("CgPoint", events.BeginReadCgPoint, events.EndReadCgPoint, false);
			this.Register<DocFileRef>("DocFileRef", events.BeginReadDocFileRef, events.EndReadDocFileRef, false);
			this.Register<Feature>("Feature", events.BeginReadFeature, events.EndReadFeature, false);
			this.Register<Property>("Property", events.BeginReadProperty, events.EndReadProperty, false);
			this.Register<PointType>("Start", events.BeginReadStart, events.EndReadStart, false);
			this.Register<PointType>("End", events.BeginReadEnd, events.EndReadEnd, false);
			this.Register<PointType>("Center", events.BeginReadCenter, events.EndReadCenter, false);
			this.Register<PointType>("PI", events.BeginReadPI, events.EndReadPI, false);
			this.Register<PointType>("MapPoint", events.BeginReadMapPoint, events.EndReadMapPoint, false);
			this.Register<PointType>("InstrumentPoint", events.BeginReadInstrumentPoint, events.EndReadInstrumentPoint, false);
			this.Register<PointType>("Location", events.BeginReadLocation, events.EndReadLocation, false);
			this.Register<IrregularLine>("IrregularLine", events.BeginReadIrregularLine, events.EndReadIrregularLine, false);
			this.Register<Chain>("Chain", events.BeginReadChain, events.EndReadChain, false);
			this.Register<Curve>("Curve", events.BeginReadCurve, events.EndReadCurve, false);
			this.Register<Spiral>("Spiral", events.BeginReadSpiral, events.EndReadSpiral, false);
			this.Register<CoordGeom>("CoordGeom", events.BeginReadCoordGeom, events.EndReadCoordGeom, false);
			this.Register<Line>("Line", events.BeginReadLine, events.EndReadLine, false);
			this.Register<CrossSects>("CrossSects", events.BeginReadCrossSects, events.EndReadCrossSects, false);
			this.Register<CrossSect>("CrossSect", events.BeginReadCrossSect, events.EndReadCrossSect, false);
			this.Register<CrossSectSurf>("CrossSectSurf", events.BeginReadCrossSectSurf, events.EndReadCrossSectSurf, false);
			this.Register<Project>("Project", events.BeginReadProject, events.EndReadProject, false);
			this.Register<Units>("Units", events.BeginReadUnits, events.EndReadUnits, false);
			this.Register<Metric>("Metric", events.BeginReadMetric, events.EndReadMetric, false);
			this.Register<Imperial>("Imperial", events.BeginReadImperial, events.EndReadImperial, false);
			this.Register<CoordinateSystem>("CoordinateSystem", events.BeginReadCoordinateSystem, events.EndReadCoordinateSystem, false);
			this.Register<Application>("Application", events.BeginReadApplication, events.EndReadApplication, false);
			this.Register<Author>("Author", events.BeginReadAuthor, events.EndReadAuthor, false);
			this.Register<Survey>("Survey", events.BeginReadSurvey, events.EndReadSurvey, false);
			this.Register<SurveyHeader>("SurveyHeader", events.BeginReadSurveyHeader, events.EndReadSurveyHeader, false);
			this.Register<Personnel>("Personnel", events.BeginReadPersonnel, events.EndReadPersonnel, false);
			this.Register<FieldNote>("FieldNote", events.BeginReadFieldNote, events.EndReadFieldNote, false);
			this.Register<Equipment>("Equipment", events.BeginReadEquipment, events.EndReadEquipment, false);
			this.Register<InstrumentDetails>("InstrumentDetails", events.BeginReadInstrumentDetails, events.EndReadInstrumentDetails, false);
			this.Register<LaserDetails>("LaserDetails", events.BeginReadLaserDetails, events.EndReadLaserDetails, false);
			this.Register<GPSAntennaDetails>("GPSAntennaDetails", events.BeginReadGPSAntennaDetails, events.EndReadGPSAntennaDetails, false);
			this.Register<GPSReceiverDetails>("GPSReceiverDetails", events.BeginReadGPSReceiverDetails, events.EndReadGPSReceiverDetails, false);
			this.Register<Corrections>("Corrections", events.BeginReadCorrections, events.EndReadCorrections, false);
			this.Register<SurveyMonument>("SurveyMonument", events.BeginReadSurveyMonument, events.EndReadSurveyMonument, false);
			this.Register<InstrumentSetup>("InstrumentSetup", events.BeginReadInstrumentSetup, events.EndReadInstrumentSetup, false);
			this.Register<LaserSetup>("LaserSetup", events.BeginReadLaserSetup, events.EndReadLaserSetup, false);
			this.Register<GPSSetup>("GPSSetup", events.BeginReadGPSSetup, events.EndReadGPSSetup, false);
			this.Register<TargetSetup>("TargetSetup", events.BeginReadTargetSetup, events.EndReadTargetSetup, false);
			this.Register<Backsight>("Backsight", events.BeginReadBacksight, events.EndReadBacksight, false);
			this.Register<RawObservation>("RawObservation", events.BeginReadRawObservation, events.EndReadRawObservation, false);
			this.Register<PointType>("TargetPoint", events.BeginReadTargetPoint, events.EndReadTargetPoint, false);
			this.Register<PointType>("BacksightPoint", events.BeginReadBacksightPoint, events.EndReadBacksightPoint, false);
			this.Register<OffsetVals>("OffsetVals", events.BeginReadOffsetVals, events.EndReadOffsetVals, false);
			this.Register<GPSVector>("GPSVector", events.BeginReadGPSVector, events.EndReadGPSVector, false);
			this.Register<GPSPosition>("GPSPosition", events.BeginReadGPSPosition, events.EndReadGPSPosition, false);
			this.Register<GPSQCInfoLevel1>("GPSQCInfoLevel1", events.BeginReadGPSQCInfoLevel1, events.EndReadGPSQCInfoLevel1, false);
			this.Register<GPSQCInfoLevel2>("GPSQCInfoLevel2", events.BeginReadGPSQCInfoLevel2, events.EndReadGPSQCInfoLevel2, false);
			this.Register<ObservationGroup>("ObservationGroup", events.BeginReadObservationGroup, events.EndReadObservationGroup, false);
			this.Register<ControlChecks>("ControlChecks", events.BeginReadControlChecks, events.EndReadControlChecks, false);
			this.Register<PointResults>("PointResults", events.BeginReadPointResults, events.EndReadPointResults, false);
			this.Register<ReducedObservation>("ReducedObservation", events.BeginReadReducedObservation, events.EndReadReducedObservation, false);
			this.Register<ReducedArcObservation>("ReducedArcObservation", events.BeginReadReducedArcObservation, events.EndReadReducedArcObservation, false);
			this.Register<Monuments>("Monuments", events.BeginReadMonuments, events.EndReadMonuments, false);
			this.Register<Monument>("Monument", events.BeginReadMonument, events.EndReadMonument, false);
			this.Register<Surfaces>("Surfaces", events.BeginReadSurfaces, events.EndReadSurfaces, false);
			this.Register<Surface>("Surface", events.BeginReadSurface, events.EndReadSurface, false);
			this.Register<SourceData>("SourceData", events.BeginReadSourceData, events.EndReadSourceData, false);
			this.Register<DataPoints>("DataPoints", events.BeginReadDataPoints, events.EndReadDataPoints, false);
			this.Register<PointFiles>("PointFiles", events.BeginReadPointFiles, events.EndReadPointFiles, false);
			this.Register<PointFile>("PointFile", events.BeginReadPointFile, events.EndReadPointFile, false);
			this.Register<Boundaries>("Boundaries", events.BeginReadBoundaries, events.EndReadBoundaries, false);
			this.Register<Boundary>("Boundary", events.BeginReadBoundary, events.EndReadBoundary, false);
			this.Register<Breaklines>("Breaklines", events.BeginReadBreaklines, events.EndReadBreaklines, false);
			this.Register<Breakline>("Breakline", events.BeginReadBreakline, events.EndReadBreakline, false);
			this.Register<RetWall>("RetWall", events.BeginReadRetWall, events.EndReadRetWall, false);
			this.Register<RetWallPnt>("RetWallPnt", events.BeginReadRetWallPnt, events.EndReadRetWallPnt, false);
			this.Register<Contours>("Contours", events.BeginReadContours, events.EndReadContours, false);
			this.Register<Contour>("Contour", events.BeginReadContour, events.EndReadContour, false);
			this.Register<Definition>("Definition", events.BeginReadDefinition, events.EndReadDefinition, false);
			this.Register<Pnts>("Pnts", events.BeginReadPnts, events.EndReadPnts, false);
			this.Register<P>("P", events.BeginReadP, events.EndReadP, false);
			this.Register<Faces>("Faces", events.BeginReadFaces, events.EndReadFaces, false);
			this.Register<Watersheds>("Watersheds", events.BeginReadWatersheds, events.EndReadWatersheds, false);
			this.Register<Watershed>("Watershed", events.BeginReadWatershed, events.EndReadWatershed, false);
			this.Register<Outlet>("Outlet", events.BeginReadOutlet, events.EndReadOutlet, false);
			this.Register<SurfVolumes>("SurfVolumes", events.BeginReadSurfVolumes, events.EndReadSurfVolumes, false);
			this.Register<SurfVolume>("SurfVolume", events.BeginReadSurfVolume, events.EndReadSurfVolume, false);
			this.Register<Parcels>("Parcels", events.BeginReadParcels, events.EndReadParcels, false);
			this.Register<Parcel>("Parcel", events.BeginReadParcel, events.EndReadParcel, false);
			this.Register<Title>("Title", events.BeginReadTitle, events.EndReadTitle, false);
			this.Register<Alignments>("Alignments", events.BeginReadAlignments, events.EndReadAlignments, false);
			this.Register<Alignment>("Alignment", events.BeginReadAlignment, events.EndReadAlignment, false);
			this.Register<StaEquation>("StaEquation", events.BeginReadStaEquation, events.EndReadStaEquation, false);
			this.Register<Profile>("Profile", events.BeginReadProfile, events.EndReadProfile, false);
			this.Register<ProfSurf>("ProfSurf", events.BeginReadProfSurf, events.EndReadProfSurf, false);
			this.Register<ProfAlign>("ProfAlign", events.BeginReadProfAlign, events.EndReadProfAlign, false);
			this.Register<PVI>("PVI", events.BeginReadPVI, events.EndReadPVI, false);
			this.Register<ParaCurve>("ParaCurve", events.BeginReadParaCurve, events.EndReadParaCurve, false);
			this.Register<UnsymParaCurve>("UnsymParaCurve", events.BeginReadUnsymParaCurve, events.EndReadUnsymParaCurve, false);
			this.Register<CircCurve>("CircCurve", events.BeginReadCircCurve, events.EndReadCircCurve, false);
			this.Register<PipeNetworks>("PipeNetworks", events.BeginReadPipeNetworks, events.EndReadPipeNetworks, false);
			this.Register<PipeNetwork>("PipeNetwork", events.BeginReadPipeNetwork, events.EndReadPipeNetwork, false);
			this.Register<Pipes>("Pipes", events.BeginReadPipes, events.EndReadPipes, false);
			this.Register<Pipe>("Pipe", events.BeginReadPipe, events.EndReadPipe, false);
			this.Register<CircPipe>("CircPipe", events.BeginReadCircPipe, events.EndReadCircPipe, false);
			this.Register<ElliPipe>("ElliPipe", events.BeginReadElliPipe, events.EndReadElliPipe, false);
			this.Register<RectPipe>("RectPipe", events.BeginReadRectPipe, events.EndReadRectPipe, false);
			this.Register<Channel>("Channel", events.BeginReadChannel, events.EndReadChannel, false);
			this.Register<PipeFlow>("PipeFlow", events.BeginReadPipeFlow, events.EndReadPipeFlow, false);
			this.Register<Structs>("Structs", events.BeginReadStructs, events.EndReadStructs, false);
			this.Register<Struct>("Struct", events.BeginReadStruct, events.EndReadStruct, false);
			this.Register<CircStruct>("CircStruct", events.BeginReadCircStruct, events.EndReadCircStruct, false);
			this.Register<RectStruct>("RectStruct", events.BeginReadRectStruct, events.EndReadRectStruct, false);
			this.Register<InletStruct>("InletStruct", events.BeginReadInletStruct, events.EndReadInletStruct, false);
			this.Register<OutletStruct>("OutletStruct", events.BeginReadOutletStruct, events.EndReadOutletStruct, false);
			this.Register<Connection>("Connection", events.BeginReadConnection, events.EndReadConnection, false);
			this.Register<Invert>("Invert", events.BeginReadInvert, events.EndReadInvert, false);
			this.Register<StructFlow>("StructFlow", events.BeginReadStructFlow, events.EndReadStructFlow, false);
			this.Register<PlanFeatures>("PlanFeatures", events.BeginReadPlanFeatures, events.EndReadPlanFeatures, false);
			this.Register<PlanFeature>("PlanFeature", events.BeginReadPlanFeature, events.EndReadPlanFeature, false);
			this.Register<GradeModel>("GradeModel", events.BeginReadGradeModel, events.EndReadGradeModel, false);
			this.Register<GradeSurface>("GradeSurface", events.BeginReadGradeSurface, events.EndReadGradeSurface, false);
			this.Register<Zones>("Zones", events.BeginReadZones, events.EndReadZones, false);
			this.Register<Zone>("Zone", events.BeginReadZone, events.EndReadZone, false);
			this.Register<ZoneWidth>("ZoneWidth", events.BeginReadZoneWidth, events.EndReadZoneWidth, false);
			this.Register<ZoneSlope>("ZoneSlope", events.BeginReadZoneSlope, events.EndReadZoneSlope, false);
			this.Register<ZoneHinge>("ZoneHinge", events.BeginReadZoneHinge, events.EndReadZoneHinge, false);
			this.Register<ZoneCutFill>("ZoneCutFill", events.BeginReadZoneCutFill, events.EndReadZoneCutFill, false);
			this.Register<ZoneMaterial>("ZoneMaterial", events.BeginReadZoneMaterial, events.EndReadZoneMaterial, false);
			this.Register<ZoneCrossSectStructure>("ZoneCrossSectStructure", events.BeginReadZoneCrossSectStructure, events.EndReadZoneCrossSectStructure, false);
			this.Register<Roadways>("Roadways", events.BeginReadRoadways, events.EndReadRoadways, false);
			this.Register<Roadway>("Roadway", events.BeginReadRoadway, events.EndReadRoadway, false);
			this.Register<Classification>("Classification", events.BeginReadClassification, events.EndReadClassification, false);
			this.Register<DesignSpeed>("DesignSpeed", events.BeginReadDesignSpeed, events.EndReadDesignSpeed, false);
			this.Register<DesignSpeed85th>("DesignSpeed85th", events.BeginReadDesignSpeed85th, events.EndReadDesignSpeed85th, false);
			this.Register<Speeds>("Speeds", events.BeginReadSpeeds, events.EndReadSpeeds, false);
			this.Register<DailyTrafficVolume>("DailyTrafficVolume", events.BeginReadDailyTrafficVolume, events.EndReadDailyTrafficVolume, false);
			this.Register<DesignHour>("DesignHour", events.BeginReadDesignHour, events.EndReadDesignHour, false);
			this.Register<PeakHour>("PeakHour", events.BeginReadPeakHour, events.EndReadPeakHour, false);
			this.Register<TrafficVolume>("TrafficVolume", events.BeginReadTrafficVolume, events.EndReadTrafficVolume, false);
			this.Register<Superelevation>("Superelevation", events.BeginReadSuperelevation, events.EndReadSuperelevation, false);
			this.Register<Lanes>("Lanes", events.BeginReadLanes, events.EndReadLanes, false);
			this.Register<ThruLane>("ThruLane", events.BeginReadThruLane, events.EndReadThruLane, false);
			this.Register<PassingLane>("PassingLane", events.BeginReadPassingLane, events.EndReadPassingLane, false);
			this.Register<TurnLane>("TurnLane", events.BeginReadTurnLane, events.EndReadTurnLane, false);
			this.Register<TwoWayLeftTurnLane>("TwoWayLeftTurnLane", events.BeginReadTwoWayLeftTurnLane, events.EndReadTwoWayLeftTurnLane, false);
			this.Register<ClimbLane>("ClimbLane", events.BeginReadClimbLane, events.EndReadClimbLane, false);
			this.Register<OffsetLane>("OffsetLane", events.BeginReadOffsetLane, events.EndReadOffsetLane, false);
			this.Register<WideningLane>("WideningLane", events.BeginReadWideningLane, events.EndReadWideningLane, false);
			this.Register<Roadside>("Roadside", events.BeginReadRoadside, events.EndReadRoadside, false);
			this.Register<Ditch>("Ditch", events.BeginReadDitch, events.EndReadDitch, false);
			this.Register<ObstructionOffset>("ObstructionOffset", events.BeginReadObstructionOffset, events.EndReadObstructionOffset, false);
			this.Register<BikeFacilities>("BikeFacilities", events.BeginReadBikeFacilities, events.EndReadBikeFacilities, false);
			this.Register<RoadSign>("RoadSign", events.BeginReadRoadSign, events.EndReadRoadSign, false);
			this.Register<DrivewayDensity>("DrivewayDensity", events.BeginReadDrivewayDensity, events.EndReadDrivewayDensity, false);
			this.Register<HazardRating>("HazardRating", events.BeginReadHazardRating, events.EndReadHazardRating, false);
			this.Register<Intersections>("Intersections", events.BeginReadIntersections, events.EndReadIntersections, false);
			this.Register<Intersection>("Intersection", events.BeginReadIntersection, events.EndReadIntersection, false);
			this.Register<TrafficControl>("TrafficControl", events.BeginReadTrafficControl, events.EndReadTrafficControl, false);
			this.Register<Timing>("Timing", events.BeginReadTiming, events.EndReadTiming, false);
			this.Register<Volume>("Volume", events.BeginReadVolume, events.EndReadVolume, false);
			this.Register<TurnSpeed>("TurnSpeed", events.BeginReadTurnSpeed, events.EndReadTurnSpeed, false);
			this.Register<TurnRestriction>("TurnRestriction", events.BeginReadTurnRestriction, events.EndReadTurnRestriction, false);
			this.Register<Curb>("Curb", events.BeginReadCurb, events.EndReadCurb, false);
			this.Register<Corner>("Corner", events.BeginReadCorner, events.EndReadCorner, false);
			this.Register<CrashData>("CrashData", events.BeginReadCrashData, events.EndReadCrashData, false);
			this.Register<CrashHistory>("CrashHistory", events.BeginReadCrashHistory, events.EndReadCrashHistory, false);
			this.Register<PostedSpeed>("PostedSpeed", events.BeginReadPostedSpeed, events.EndReadPostedSpeed, false);
			this.Register<NoPassingZone>("NoPassingZone", events.BeginReadNoPassingZone, events.EndReadNoPassingZone, false);
			this.Register<DecisionSightDistance>("DecisionSightDistance", events.BeginReadDecisionSightDistance, events.EndReadDecisionSightDistance, false);
			this.Register<BridgeElement>("BridgeElement", events.BeginReadBridgeElement, events.EndReadBridgeElement, false);
		}
	}
}
#endif
