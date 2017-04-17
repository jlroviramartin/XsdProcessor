#if !BUILD_LAND_XML
using System;
using System.Collections.Generic;
using XmlSchemaProcessor;
using XmlSchemaProcessor.LandXml;
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
	public enum SurfBndType
	{
		[StringValue("outer")]
		Outer,
		[StringValue("void")]
		Void,
		[StringValue("island")]
		Island,
	}
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
	public enum SurveyType
	{
		[StringValue("compiled")]
		Compiled,
		[StringValue("computed")]
		Computed,
		[StringValue("surveyed")]
		Surveyed,
	}
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
	public class PointType : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.pntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("pntRef"));
			this.pointGeometry = XsdConverter.Instance.Convert<PointGeometryType>(attributes.GetSafe("pointGeometry"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType>(attributes.GetSafe("DTMAttribute"));
			this.timeStamp = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("timeStamp"));
			this.role = XsdConverter.Instance.Convert<SurveyRoleType>(attributes.GetSafe("role"));
			this.content = XsdConverter.Instance.Convert<IList<double>>(text);
			return true;
		}
		public string name;
		public string desc;
		public string code;
		public StateType state;
		public string pntRef;
		public PointGeometryType pointGeometry;
		public DTMAttributeType dTMAttribute;
		public System.DateTime timeStamp;
		public SurveyRoleType role;
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
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.pntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("pntRef"));
			this.pointGeometry = XsdConverter.Instance.Convert<PointGeometryType>(attributes.GetSafe("pointGeometry"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType>(attributes.GetSafe("DTMAttribute"));
			this.timeStamp = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("timeStamp"));
			this.role = XsdConverter.Instance.Convert<SurveyRoleType>(attributes.GetSafe("role"));
			this.content = XsdConverter.Instance.Convert<IList<double>>(text);
			return true;
		}
		public string name;
		public string desc;
		public string code;
		public StateType state;
		public string pntRef;
		public PointGeometryType pointGeometry;
		public DTMAttributeType dTMAttribute;
		public System.DateTime timeStamp;
		public SurveyRoleType role;
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
			this.date = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("date"));
			this.time = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("time"));
			this.version = XsdConverter.Instance.Convert<string>(attributes.GetSafe("version"));
			this.language = XsdConverter.Instance.Convert<string>(attributes.GetSafe("language"));
			this.readOnly = XsdConverter.Instance.Convert<bool>(attributes.GetSafe("readOnly"));
			this.landXMLId = XsdConverter.Instance.Convert<int>(attributes.GetSafe("LandXMLId"));
			this.crc = XsdConverter.Instance.Convert<int>(attributes.GetSafe("crc"));
			return true;
		}
		public System.DateTime date;
		public System.DateTime time;
		public string version;
		public string language;
		public bool readOnly;
		public int landXMLId;
		public int crc;
	}
	
	public class CgPoints : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.zoneNumber = XsdConverter.Instance.Convert<uint>(attributes.GetSafe("zoneNumber"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType>(attributes.GetSafe("DTMAttribute"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
		public string code;
		public uint zoneNumber;
		public DTMAttributeType dTMAttribute;
	}
	
	public class CgPoint : PointType
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.surveyOrder = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyOrder"));
			this.pntSurv = XsdConverter.Instance.Convert<SurvPntType>(attributes.GetSafe("pntSurv"));
			this.zoneNumber = XsdConverter.Instance.Convert<uint>(attributes.GetSafe("zoneNumber"));
			this.surveyHorizontalOrder = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyHorizontalOrder"));
			this.surveyVerticalOrder = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyVerticalOrder"));
			return true;
		}
		public string oID;
		public string surveyOrder;
		public SurvPntType pntSurv;
		public uint zoneNumber;
		public string surveyHorizontalOrder;
		public string surveyVerticalOrder;
	}
	
	public class DocFileRef : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.location = XsdConverter.Instance.Convert<System.Uri>(attributes.GetSafe("location"));
			this.fileType = XsdConverter.Instance.Convert<string>(attributes.GetSafe("fileType"));
			this.fileFormat = XsdConverter.Instance.Convert<string>(attributes.GetSafe("fileFormat"));
			return true;
		}
		public string name;
		public System.Uri location;
		public string fileType;
		public string fileFormat;
	}
	
	public class Feature : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.source = XsdConverter.Instance.Convert<string>(attributes.GetSafe("source"));
			return true;
		}
		public string code;
		public string source;
	}
	
	public class Property : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.label = XsdConverter.Instance.Convert<string>(attributes.GetSafe("label"));
			this.value = XsdConverter.Instance.Convert<string>(attributes.GetSafe("value"));
			return true;
		}
		public string label;
		public string value;
	}
	
	public class IrregularLine : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dir = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dir"));
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public string desc;
		public double dir;
		public double length;
		public string name;
		public double staStart;
		public StateType state;
		public string oID;
	}
	
	public class Chain : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.pointGeometry = XsdConverter.Instance.Convert<PointGeometryType>(attributes.GetSafe("pointGeometry"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType>(attributes.GetSafe("DTMAttribute"));
			this.timeStamp = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("timeStamp"));
			this.role = XsdConverter.Instance.Convert<SurveyRoleType>(attributes.GetSafe("role"));
			this.content = XsdConverter.Instance.Convert<IList<string>>(text);
			return true;
		}
		public string name;
		public string desc;
		public string code;
		public StateType state;
		public PointGeometryType pointGeometry;
		public DTMAttributeType dTMAttribute;
		public System.DateTime timeStamp;
		public SurveyRoleType role;
		public IList<string> content;
	}
	
	public class Curve : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.rot = XsdConverter.Instance.Convert<Clockwise>(attributes.GetSafe("rot"));
			this.chord = XsdConverter.Instance.Convert<double>(attributes.GetSafe("chord"));
			this.crvType = XsdConverter.Instance.Convert<CurveType>(attributes.GetSafe("crvType"));
			this.delta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("delta"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dirEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dirEnd"));
			this.dirStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dirStart"));
			this.external = XsdConverter.Instance.Convert<double>(attributes.GetSafe("external"));
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.midOrd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("midOrd"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.radius = XsdConverter.Instance.Convert<double>(attributes.GetSafe("radius"));
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.tangent = XsdConverter.Instance.Convert<double>(attributes.GetSafe("tangent"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public Clockwise rot;
		public double chord;
		public CurveType crvType;
		public double delta;
		public string desc;
		public double dirEnd;
		public double dirStart;
		public double external;
		public double length;
		public double midOrd;
		public string name;
		public double radius;
		public double staStart;
		public StateType state;
		public double tangent;
		public string oID;
	}
	
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
			this.chord = XsdConverter.Instance.Convert<double>(attributes.GetSafe("chord"));
			this.constant = XsdConverter.Instance.Convert<double>(attributes.GetSafe("constant"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dirEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dirEnd"));
			this.dirStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dirStart"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.theta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("theta"));
			this.totalY = XsdConverter.Instance.Convert<double>(attributes.GetSafe("totalY"));
			this.totalX = XsdConverter.Instance.Convert<double>(attributes.GetSafe("totalX"));
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.tanLong = XsdConverter.Instance.Convert<double>(attributes.GetSafe("tanLong"));
			this.tanShort = XsdConverter.Instance.Convert<double>(attributes.GetSafe("tanShort"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public double length;
		public double radiusEnd;
		public double radiusStart;
		public Clockwise rot;
		public SpiralType spiType;
		public double chord;
		public double constant;
		public string desc;
		public double dirEnd;
		public double dirStart;
		public string name;
		public double theta;
		public double totalY;
		public double totalX;
		public double staStart;
		public StateType state;
		public double tanLong;
		public double tanShort;
		public string oID;
	}
	
	public class CoordGeom : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class Line : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dir = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dir"));
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public string desc;
		public double dir;
		public double length;
		public string name;
		public double staStart;
		public StateType state;
		public string oID;
	}
	
	public class CrossSects : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.calcMethod = XsdConverter.Instance.Convert<XsVolCalcMethodType>(attributes.GetSafe("calcMethod"));
			this.curveCorrection = XsdConverter.Instance.Convert<bool>(attributes.GetSafe("curveCorrection"));
			this.swellFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("swellFactor"));
			this.shrinkFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("shrinkFactor"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
		public XsVolCalcMethodType calcMethod;
		public bool curveCorrection;
		public double swellFactor;
		public double shrinkFactor;
	}
	
	public class CrossSect : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.sta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("sta"));
			this.angleSkew = XsdConverter.Instance.Convert<double>(attributes.GetSafe("angleSkew"));
			this.areaCut = XsdConverter.Instance.Convert<double>(attributes.GetSafe("areaCut"));
			this.areaFill = XsdConverter.Instance.Convert<double>(attributes.GetSafe("areaFill"));
			this.centroidCut = XsdConverter.Instance.Convert<double>(attributes.GetSafe("centroidCut"));
			this.centroidFill = XsdConverter.Instance.Convert<double>(attributes.GetSafe("centroidFill"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.sectType = XsdConverter.Instance.Convert<string>(attributes.GetSafe("sectType"));
			this.volumeCut = XsdConverter.Instance.Convert<double>(attributes.GetSafe("volumeCut"));
			this.volumeFill = XsdConverter.Instance.Convert<double>(attributes.GetSafe("volumeFill"));
			return true;
		}
		public double sta;
		public double angleSkew;
		public double areaCut;
		public double areaFill;
		public double centroidCut;
		public double centroidFill;
		public string desc;
		public string name;
		public string sectType;
		public double volumeCut;
		public double volumeFill;
	}
	
	public class CrossSectSurf : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public string desc;
		public StateType state;
	}
	
	public class Project : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public string desc;
		public StateType state;
	}
	
	public class Units : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
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
			this.diameterUnit = XsdConverter.Instance.Convert<MetDiameter>(attributes.GetSafe("diameterUnit"));
			this.widthUnit = XsdConverter.Instance.Convert<MetWidth>(attributes.GetSafe("widthUnit"));
			this.heightUnit = XsdConverter.Instance.Convert<MetHeight>(attributes.GetSafe("heightUnit"));
			this.velocityUnit = XsdConverter.Instance.Convert<MetVelocity>(attributes.GetSafe("velocityUnit"));
			this.flowUnit = XsdConverter.Instance.Convert<MetFlow>(attributes.GetSafe("flowUnit"));
			this.angularUnit = XsdConverter.Instance.Convert<AngularType>(attributes.GetSafe("angularUnit"), XsdConverter.Instance.Convert<AngularType>("radians"));
			this.directionUnit = XsdConverter.Instance.Convert<AngularType>(attributes.GetSafe("directionUnit"), XsdConverter.Instance.Convert<AngularType>("radians"));
			return true;
		}
		public MetArea areaUnit;
		public MetLinear linearUnit;
		public MetVolume volumeUnit;
		public MetTemperature temperatureUnit;
		public MetPressure pressureUnit;
		public MetDiameter diameterUnit;
		public MetWidth widthUnit;
		public MetHeight heightUnit;
		public MetVelocity velocityUnit;
		public MetFlow flowUnit;
		public AngularType angularUnit;
		public AngularType directionUnit;
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
			this.diameterUnit = XsdConverter.Instance.Convert<ImpDiameter>(attributes.GetSafe("diameterUnit"));
			this.widthUnit = XsdConverter.Instance.Convert<ImpWidth>(attributes.GetSafe("widthUnit"));
			this.heightUnit = XsdConverter.Instance.Convert<ImpHeight>(attributes.GetSafe("heightUnit"));
			this.velocityUnit = XsdConverter.Instance.Convert<ImpVelocity>(attributes.GetSafe("velocityUnit"));
			this.flowUnit = XsdConverter.Instance.Convert<ImpFlow>(attributes.GetSafe("flowUnit"));
			this.angularUnit = XsdConverter.Instance.Convert<AngularType>(attributes.GetSafe("angularUnit"), XsdConverter.Instance.Convert<AngularType>("radians"));
			this.directionUnit = XsdConverter.Instance.Convert<AngularType>(attributes.GetSafe("directionUnit"), XsdConverter.Instance.Convert<AngularType>("radians"));
			return true;
		}
		public ImpArea areaUnit;
		public ImpLinear linearUnit;
		public ImpVolume volumeUnit;
		public ImpTemperature temperatureUnit;
		public ImpPressure pressureUnit;
		public ImpDiameter diameterUnit;
		public ImpWidth widthUnit;
		public ImpHeight heightUnit;
		public ImpVelocity velocityUnit;
		public ImpFlow flowUnit;
		public AngularType angularUnit;
		public AngularType directionUnit;
	}
	
	public class CoordinateSystem : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.rotationAngle = XsdConverter.Instance.Convert<double>(attributes.GetSafe("rotationAngle"));
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
			this.fileLocation = XsdConverter.Instance.Convert<System.Uri>(attributes.GetSafe("fileLocation"));
			return true;
		}
		public string desc;
		public string name;
		public double rotationAngle;
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
		public System.Uri fileLocation;
	}
	
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
			this.timeStamp = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("timeStamp"));
			return true;
		}
		public string name;
		public string desc;
		public string manufacturer;
		public string version;
		public string manufacturerURL;
		public System.DateTime timeStamp;
	}
	
	public class Author : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.createdBy = XsdConverter.Instance.Convert<string>(attributes.GetSafe("createdBy"));
			this.createdByEmail = XsdConverter.Instance.Convert<string>(attributes.GetSafe("createdByEmail"));
			this.company = XsdConverter.Instance.Convert<string>(attributes.GetSafe("company"));
			this.companyURL = XsdConverter.Instance.Convert<string>(attributes.GetSafe("companyURL"));
			this.timeStamp = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("timeStamp"));
			return true;
		}
		public string createdBy;
		public string createdByEmail;
		public string company;
		public string companyURL;
		public System.DateTime timeStamp;
	}
	
	public class Survey : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.date = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("date"));
			this.startTime = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("startTime"));
			this.endTime = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("endTime"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.horizontalAccuracy = XsdConverter.Instance.Convert<string>(attributes.GetSafe("horizontalAccuracy"));
			this.verticalAccuracy = XsdConverter.Instance.Convert<string>(attributes.GetSafe("verticalAccuracy"));
			return true;
		}
		public string desc;
		public System.DateTime date;
		public System.DateTime startTime;
		public System.DateTime endTime;
		public StateType state;
		public string horizontalAccuracy;
		public string verticalAccuracy;
	}
	
	public class SurveyHeader : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.purpose = XsdConverter.Instance.Convert<PurposeType>(attributes.GetSafe("purpose"));
			this.startTime = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("startTime"));
			this.endTime = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("endTime"));
			this.surveyor = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyor"));
			this.surveyorFirm = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyorFirm"));
			this.surveyorReference = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyorReference"));
			this.surveyorRegistration = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyorRegistration"));
			this.surveyPurpose = XsdConverter.Instance.Convert<string>(attributes.GetSafe("surveyPurpose"));
			this.type = XsdConverter.Instance.Convert<SurveyType>(attributes.GetSafe("type"));
			this.@class = XsdConverter.Instance.Convert<string>(attributes.GetSafe("class"));
			this.county = XsdConverter.Instance.Convert<string>(attributes.GetSafe("county"));
			this.applyAtmosphericCorrection = XsdConverter.Instance.Convert<bool>(attributes.GetSafe("applyAtmosphericCorrection"));
			this.pressure = XsdConverter.Instance.Convert<double>(attributes.GetSafe("pressure"));
			this.temperature = XsdConverter.Instance.Convert<double>(attributes.GetSafe("temperature"));
			this.applySeaLevelCorrection = XsdConverter.Instance.Convert<bool>(attributes.GetSafe("applySeaLevelCorrection"));
			this.scaleFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("scaleFactor"));
			this.seaLevelCorrectionFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("seaLevelCorrectionFactor"));
			this.combinedFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("combinedFactor"));
			return true;
		}
		public string name;
		public string desc;
		public PurposeType purpose;
		public System.DateTime startTime;
		public System.DateTime endTime;
		public string surveyor;
		public string surveyorFirm;
		public string surveyorReference;
		public string surveyorRegistration;
		public string surveyPurpose;
		public SurveyType type;
		public string @class;
		public string county;
		public bool applyAtmosphericCorrection;
		public double pressure;
		public double temperature;
		public bool applySeaLevelCorrection;
		public double scaleFactor;
		public double seaLevelCorrectionFactor;
		public double combinedFactor;
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
		public string name;
		public string role;
	}
	
	public class FieldNote : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Equipment : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class InstrumentDetails : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.edmAccuracyConstant = XsdConverter.Instance.Convert<double>(attributes.GetSafe("edmAccuracyConstant"));
			this.edmAccuracyppm = XsdConverter.Instance.Convert<double>(attributes.GetSafe("edmAccuracyppm"));
			this.edmVertOffset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("edmVertOffset"));
			this.horizAnglePrecision = XsdConverter.Instance.Convert<double>(attributes.GetSafe("horizAnglePrecision"));
			this.manufacturer = XsdConverter.Instance.Convert<string>(attributes.GetSafe("manufacturer"));
			this.model = XsdConverter.Instance.Convert<string>(attributes.GetSafe("model"));
			this.serialNumber = XsdConverter.Instance.Convert<string>(attributes.GetSafe("serialNumber"));
			this.zenithAnglePrecision = XsdConverter.Instance.Convert<double>(attributes.GetSafe("zenithAnglePrecision"));
			this.carrierWavelength = XsdConverter.Instance.Convert<double>(attributes.GetSafe("carrierWavelength"));
			this.refractiveIndex = XsdConverter.Instance.Convert<double>(attributes.GetSafe("refractiveIndex"));
			this.horizCollimation = XsdConverter.Instance.Convert<double>(attributes.GetSafe("horizCollimation"));
			this.vertCollimation = XsdConverter.Instance.Convert<double>(attributes.GetSafe("vertCollimation"));
			return true;
		}
		public string id;
		public double edmAccuracyConstant;
		public double edmAccuracyppm;
		public double edmVertOffset;
		public double horizAnglePrecision;
		public string manufacturer;
		public string model;
		public string serialNumber;
		public double zenithAnglePrecision;
		public double carrierWavelength;
		public double refractiveIndex;
		public double horizCollimation;
		public double vertCollimation;
	}
	
	public class LaserDetails : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.laserVertOffset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("laserVertOffset"));
			this.manufacturer = XsdConverter.Instance.Convert<string>(attributes.GetSafe("manufacturer"));
			this.model = XsdConverter.Instance.Convert<string>(attributes.GetSafe("model"));
			this.serialNumber = XsdConverter.Instance.Convert<string>(attributes.GetSafe("serialNumber"));
			return true;
		}
		public string id;
		public double laserVertOffset;
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
			this.latitude = XsdConverter.Instance.Convert<double>(attributes.GetSafe("latitude"));
			this.longitude = XsdConverter.Instance.Convert<double>(attributes.GetSafe("longitude"));
			this.altitude = XsdConverter.Instance.Convert<double>(attributes.GetSafe("altitude"));
			this.ellipsiodnalHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("ellipsiodnalHeight"));
			this.orthometricHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("orthometricHeight"));
			return true;
		}
		public string id;
		public string manufacturer;
		public string model;
		public string serialNumber;
		public double latitude;
		public double longitude;
		public double altitude;
		public double ellipsiodnalHeight;
		public double orthometricHeight;
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
			this.refractionCoefficient = XsdConverter.Instance.Convert<double>(attributes.GetSafe("refractionCoefficient"));
			this.applyRefractionCoefficient = XsdConverter.Instance.Convert<bool>(attributes.GetSafe("applyRefractionCoefficient"));
			this.sphericity = XsdConverter.Instance.Convert<double>(attributes.GetSafe("sphericity"));
			this.prismEccentricity = XsdConverter.Instance.Convert<double>(attributes.GetSafe("prismEccentricity"));
			return true;
		}
		public double refractionCoefficient;
		public bool applyRefractionCoefficient;
		public double sphericity;
		public double prismEccentricity;
	}
	
	public class SurveyMonument : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.mntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("mntRef"));
			this.purpose = XsdConverter.Instance.Convert<IList<MonumentPurpose_anonymous>>(attributes.GetSafe("purpose"));
			this.state = XsdConverter.Instance.Convert<MonumentState>(attributes.GetSafe("state"));
			this.adoptedSurvey = XsdConverter.Instance.Convert<string>(attributes.GetSafe("adoptedSurvey"));
			this.disturbedMonument = XsdConverter.Instance.Convert<string>(attributes.GetSafe("disturbedMonument"));
			this.disturbedDate = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("disturbedDate"));
			this.disturbedAnnotation = XsdConverter.Instance.Convert<string>(attributes.GetSafe("disturbedAnnotation"));
			this.replacedMonument = XsdConverter.Instance.Convert<string>(attributes.GetSafe("replacedMonument"));
			this.replacedDate = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("replacedDate"));
			this.replacedAnnotation = XsdConverter.Instance.Convert<string>(attributes.GetSafe("replacedAnnotation"));
			return true;
		}
		public string mntRef;
		public IList<MonumentPurpose_anonymous> purpose;
		public MonumentState state;
		public string adoptedSurvey;
		public string disturbedMonument;
		public System.DateTime disturbedDate;
		public string disturbedAnnotation;
		public string replacedMonument;
		public System.DateTime replacedDate;
		public string replacedAnnotation;
	}
	
	public class InstrumentSetup : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.instrumentDetailsID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("instrumentDetailsID"));
			this.stationName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("stationName"));
			this.instrumentHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("instrumentHeight"));
			this.orientationAzimuth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("orientationAzimuth"));
			this.circleAzimuth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("circleAzimuth"));
			return true;
		}
		public string id;
		public string instrumentDetailsID;
		public string stationName;
		public double instrumentHeight;
		public double orientationAzimuth;
		public double circleAzimuth;
	}
	
	public class LaserSetup : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.stationName = XsdConverter.Instance.Convert<string>(attributes.GetSafe("stationName"));
			this.instrumentHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("instrumentHeight"));
			this.laserDetailsID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("laserDetailsID"));
			this.magDeclination = XsdConverter.Instance.Convert<double>(attributes.GetSafe("magDeclination"));
			return true;
		}
		public string id;
		public string stationName;
		public double instrumentHeight;
		public string laserDetailsID;
		public double magDeclination;
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
			this.startTime = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startTime"));
			this.stopTime = XsdConverter.Instance.Convert<double>(attributes.GetSafe("stopTime"));
			return true;
		}
		public string id;
		public double antennaHeight;
		public string stationName;
		public string gPSAntennaDetailsID;
		public string gPSReceiverDetailsID;
		public string observationDataLink;
		public string stationDescription;
		public double startTime;
		public double stopTime;
	}
	
	public class TargetSetup : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.targetHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("targetHeight"));
			this.edmTargetVertOffset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("edmTargetVertOffset"));
			this.prismConstant = XsdConverter.Instance.Convert<double>(attributes.GetSafe("prismConstant"));
			return true;
		}
		public string id;
		public double targetHeight;
		public double edmTargetVertOffset;
		public double prismConstant;
	}
	
	public class Backsight : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.azimuth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("azimuth"));
			this.targetHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("targetHeight"));
			this.circle = XsdConverter.Instance.Convert<double>(attributes.GetSafe("circle"));
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			return true;
		}
		public string id;
		public double azimuth;
		public double targetHeight;
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
			this.purpose = XsdConverter.Instance.Convert<PurposeType>(attributes.GetSafe("purpose"));
			this.targetHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("targetHeight"));
			this.horizAngle = XsdConverter.Instance.Convert<double>(attributes.GetSafe("horizAngle"));
			this.slopeDistance = XsdConverter.Instance.Convert<double>(attributes.GetSafe("slopeDistance"));
			this.zenithAngle = XsdConverter.Instance.Convert<double>(attributes.GetSafe("zenithAngle"));
			this.horizDistance = XsdConverter.Instance.Convert<double>(attributes.GetSafe("horizDistance"));
			this.vertDistance = XsdConverter.Instance.Convert<double>(attributes.GetSafe("vertDistance"));
			this.azimuth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("azimuth"));
			this.unused = XsdConverter.Instance.Convert<bool>(attributes.GetSafe("unused"));
			this.directFace = XsdConverter.Instance.Convert<bool>(attributes.GetSafe("directFace"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			this.timeStamp = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("timeStamp"));
			return true;
		}
		public string setupID;
		public string targetSetupID;
		public string setID;
		public PurposeType purpose;
		public double targetHeight;
		public double horizAngle;
		public double slopeDistance;
		public double zenithAngle;
		public double horizDistance;
		public double vertDistance;
		public double azimuth;
		public bool unused;
		public bool directFace;
		public IList<string> coordGeomRefs;
		public System.DateTime timeStamp;
	}
	
	public class OffsetVals : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.offsetInOut = XsdConverter.Instance.Convert<double>(attributes.GetSafe("offsetInOut"));
			this.offsetLeftRight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("offsetLeftRight"));
			this.offsetUpDown = XsdConverter.Instance.Convert<double>(attributes.GetSafe("offsetUpDown"));
			return true;
		}
		public double offsetInOut;
		public double offsetLeftRight;
		public double offsetUpDown;
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
			this.startTime = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("startTime"));
			this.endTime = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("endTime"));
			this.horizontalPrecision = XsdConverter.Instance.Convert<double>(attributes.GetSafe("horizontalPrecision"));
			this.verticalPrecision = XsdConverter.Instance.Convert<double>(attributes.GetSafe("verticalPrecision"));
			this.purpose = XsdConverter.Instance.Convert<PurposeType>(attributes.GetSafe("purpose"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.solutionDataLink = XsdConverter.Instance.Convert<string>(attributes.GetSafe("solutionDataLink"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			return true;
		}
		public double dX;
		public double dY;
		public double dZ;
		public string setupID_A;
		public string setupID_B;
		public System.DateTime startTime;
		public System.DateTime endTime;
		public double horizontalPrecision;
		public double verticalPrecision;
		public PurposeType purpose;
		public string setID;
		public string solutionDataLink;
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
		public string setupID;
		public string setID;
		public double wgsHeight;
		public double wgsLatitude;
		public double wgsLongitude;
		public string purpose;
		public IList<string> coordGeomRefs;
		public string pntRef;
	}
	
	public class GPSQCInfoLevel1 : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.gPSSolnType = XsdConverter.Instance.Convert<GPSSolutionTypeEnum>(attributes.GetSafe("GPSSolnType"));
			this.gPSSolnFreq = XsdConverter.Instance.Convert<GPSSolutionFrequencyEnum>(attributes.GetSafe("GPSSolnFreq"));
			this.nbrSatellites = XsdConverter.Instance.Convert<int>(attributes.GetSafe("nbrSatellites"));
			this.rDOP = XsdConverter.Instance.Convert<double>(attributes.GetSafe("RDOP"));
			return true;
		}
		public GPSSolutionTypeEnum gPSSolnType;
		public GPSSolutionFrequencyEnum gPSSolnFreq;
		public int nbrSatellites;
		public double rDOP;
	}
	
	public class GPSQCInfoLevel2 : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.covarianceXX = XsdConverter.Instance.Convert<double>(attributes.GetSafe("covarianceXX"));
			this.covarianceXY = XsdConverter.Instance.Convert<double>(attributes.GetSafe("covarianceXY"));
			this.covarianceXZ = XsdConverter.Instance.Convert<double>(attributes.GetSafe("covarianceXZ"));
			this.covarianceYY = XsdConverter.Instance.Convert<double>(attributes.GetSafe("covarianceYY"));
			this.covarianceYZ = XsdConverter.Instance.Convert<double>(attributes.GetSafe("covarianceYZ"));
			this.covarianceZZ = XsdConverter.Instance.Convert<double>(attributes.GetSafe("covarianceZZ"));
			this.gPSSolnType = XsdConverter.Instance.Convert<GPSSolutionTypeEnum>(attributes.GetSafe("GPSSolnType"));
			this.gPSSolnFreq = XsdConverter.Instance.Convert<GPSSolutionFrequencyEnum>(attributes.GetSafe("GPSSolnFreq"));
			this.rMS = XsdConverter.Instance.Convert<double>(attributes.GetSafe("RMS"));
			this.ratio = XsdConverter.Instance.Convert<double>(attributes.GetSafe("ratio"));
			this.referenceVariance = XsdConverter.Instance.Convert<double>(attributes.GetSafe("referenceVariance"));
			this.nbrSatellites = XsdConverter.Instance.Convert<int>(attributes.GetSafe("nbrSatellites"));
			this.startTime = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startTime"));
			this.stopTime = XsdConverter.Instance.Convert<double>(attributes.GetSafe("stopTime"));
			return true;
		}
		public double covarianceXX;
		public double covarianceXY;
		public double covarianceXZ;
		public double covarianceYY;
		public double covarianceYZ;
		public double covarianceZZ;
		public GPSSolutionTypeEnum gPSSolnType;
		public GPSSolutionFrequencyEnum gPSSolnFreq;
		public double rMS;
		public double ratio;
		public double referenceVariance;
		public int nbrSatellites;
		public double startTime;
		public double stopTime;
	}
	
	public class ObservationGroup : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<string>(attributes.GetSafe("id"));
			this.purpose = XsdConverter.Instance.Convert<PurposeType>(attributes.GetSafe("purpose"));
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.targetSetupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("targetSetupID"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			return true;
		}
		public string id;
		public PurposeType purpose;
		public string setupID;
		public string targetSetupID;
		public string setID;
		public IList<string> coordGeomRefs;
	}
	
	public class ControlChecks : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class PointResults : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.targetSetupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("targetSetupID"));
			this.meanHorizAngle = XsdConverter.Instance.Convert<double>(attributes.GetSafe("meanHorizAngle"));
			this.horizStdDeviation = XsdConverter.Instance.Convert<double>(attributes.GetSafe("horizStdDeviation"));
			this.meanzenithAngle = XsdConverter.Instance.Convert<double>(attributes.GetSafe("meanzenithAngle"));
			this.vertStdDeviation = XsdConverter.Instance.Convert<double>(attributes.GetSafe("vertStdDeviation"));
			this.meanSlopeDistance = XsdConverter.Instance.Convert<double>(attributes.GetSafe("meanSlopeDistance"));
			this.slopeDistanceStdDeviation = XsdConverter.Instance.Convert<double>(attributes.GetSafe("slopeDistanceStdDeviation"));
			return true;
		}
		public string setupID;
		public string targetSetupID;
		public double meanHorizAngle;
		public double horizStdDeviation;
		public double meanzenithAngle;
		public double vertStdDeviation;
		public double meanSlopeDistance;
		public double slopeDistanceStdDeviation;
	}
	
	public class ReducedObservation : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.purpose = XsdConverter.Instance.Convert<PurposeType>(attributes.GetSafe("purpose"));
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.targetSetupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("targetSetupID"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.targetHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("targetHeight"));
			this.azimuth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("azimuth"));
			this.horizDistance = XsdConverter.Instance.Convert<double>(attributes.GetSafe("horizDistance"));
			this.vertDistance = XsdConverter.Instance.Convert<double>(attributes.GetSafe("vertDistance"));
			this.horizAngle = XsdConverter.Instance.Convert<double>(attributes.GetSafe("horizAngle"));
			this.slopeDistance = XsdConverter.Instance.Convert<double>(attributes.GetSafe("slopeDistance"));
			this.zenithAngle = XsdConverter.Instance.Convert<double>(attributes.GetSafe("zenithAngle"));
			this.equipmentUsed = XsdConverter.Instance.Convert<EquipmentType>(attributes.GetSafe("equipmentUsed"));
			this.azimuthAccuracy = XsdConverter.Instance.Convert<double>(attributes.GetSafe("azimuthAccuracy"));
			this.distanceAccuracy = XsdConverter.Instance.Convert<double>(attributes.GetSafe("distanceAccuracy"));
			this.date = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("date"));
			this.distanceType = XsdConverter.Instance.Convert<ObservationType>(attributes.GetSafe("distanceType"));
			this.azimuthType = XsdConverter.Instance.Convert<ObservationType>(attributes.GetSafe("azimuthType"));
			this.adoptedAzimuthSurvey = XsdConverter.Instance.Convert<string>(attributes.GetSafe("adoptedAzimuthSurvey"));
			this.adoptedDistanceSurvey = XsdConverter.Instance.Convert<string>(attributes.GetSafe("adoptedDistanceSurvey"));
			this.distanceAccClass = XsdConverter.Instance.Convert<string>(attributes.GetSafe("distanceAccClass"));
			this.azimuthAccClass = XsdConverter.Instance.Convert<string>(attributes.GetSafe("azimuthAccClass"));
			this.azimuthAdoptionFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("azimuthAdoptionFactor"));
			this.distanceAdoptionFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("distanceAdoptionFactor"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			return true;
		}
		public PurposeType purpose;
		public string setupID;
		public string targetSetupID;
		public string setID;
		public double targetHeight;
		public double azimuth;
		public double horizDistance;
		public double vertDistance;
		public double horizAngle;
		public double slopeDistance;
		public double zenithAngle;
		public EquipmentType equipmentUsed;
		public double azimuthAccuracy;
		public double distanceAccuracy;
		public System.DateTime date;
		public ObservationType distanceType;
		public ObservationType azimuthType;
		public string adoptedAzimuthSurvey;
		public string adoptedDistanceSurvey;
		public string distanceAccClass;
		public string azimuthAccClass;
		public double azimuthAdoptionFactor;
		public double distanceAdoptionFactor;
		public IList<string> coordGeomRefs;
	}
	
	public class ReducedArcObservation : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.purpose = XsdConverter.Instance.Convert<PurposeType>(attributes.GetSafe("purpose"));
			this.setupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setupID"));
			this.targetSetupID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("targetSetupID"));
			this.setID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("setID"));
			this.chordAzimuth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("chordAzimuth"));
			this.radius = XsdConverter.Instance.Convert<double>(attributes.GetSafe("radius"));
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.rot = XsdConverter.Instance.Convert<Clockwise>(attributes.GetSafe("rot"));
			this.equipmentUsed = XsdConverter.Instance.Convert<EquipmentType>(attributes.GetSafe("equipmentUsed"));
			this.arcAzimuthAccuracy = XsdConverter.Instance.Convert<double>(attributes.GetSafe("arcAzimuthAccuracy"));
			this.arcLengthAccuracy = XsdConverter.Instance.Convert<double>(attributes.GetSafe("arcLengthAccuracy"));
			this.date = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("date"));
			this.arcType = XsdConverter.Instance.Convert<ObservationType>(attributes.GetSafe("arcType"));
			this.adoptedSurvey = XsdConverter.Instance.Convert<string>(attributes.GetSafe("adoptedSurvey"));
			this.lengthAccClass = XsdConverter.Instance.Convert<string>(attributes.GetSafe("lengthAccClass"));
			this.azimuthAccClass = XsdConverter.Instance.Convert<string>(attributes.GetSafe("azimuthAccClass"));
			this.azimuthAdoptionFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("azimuthAdoptionFactor"));
			this.lengthAdoptionFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("lengthAdoptionFactor"));
			this.coordGeomRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("coordGeomRefs"));
			return true;
		}
		public PurposeType purpose;
		public string setupID;
		public string targetSetupID;
		public string setID;
		public double chordAzimuth;
		public double radius;
		public double length;
		public Clockwise rot;
		public EquipmentType equipmentUsed;
		public double arcAzimuthAccuracy;
		public double arcLengthAccuracy;
		public System.DateTime date;
		public ObservationType arcType;
		public string adoptedSurvey;
		public string lengthAccClass;
		public string azimuthAccClass;
		public double azimuthAdoptionFactor;
		public double lengthAdoptionFactor;
		public IList<string> coordGeomRefs;
	}
	
	public class Monuments : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class Monument : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.pntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("pntRef"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.type = XsdConverter.Instance.Convert<MonumentType>(attributes.GetSafe("type"));
			this.condition = XsdConverter.Instance.Convert<MonumentCondition>(attributes.GetSafe("condition"));
			this.category = XsdConverter.Instance.Convert<MonumentCategory>(attributes.GetSafe("category"));
			this.beacon = XsdConverter.Instance.Convert<BeaconType>(attributes.GetSafe("beacon"));
			this.beaconProtection = XsdConverter.Instance.Convert<BeaconProtectionType>(attributes.GetSafe("beaconProtection"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			return true;
		}
		public string name;
		public string pntRef;
		public string desc;
		public StateType state;
		public MonumentType type;
		public MonumentCondition condition;
		public MonumentCategory category;
		public BeaconType beacon;
		public BeaconProtectionType beaconProtection;
		public string oID;
	}
	
	public class Surfaces : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class Surface : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("OID"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public string desc;
		public string oID;
		public StateType state;
	}
	
	public class SourceData : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class DataPoints : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.code = XsdConverter.Instance.Convert<string>(attributes.GetSafe("code"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.pntRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("pntRef"));
			this.pointGeometry = XsdConverter.Instance.Convert<PointGeometryType>(attributes.GetSafe("pointGeometry"));
			this.dTMAttribute = XsdConverter.Instance.Convert<DTMAttributeType>(attributes.GetSafe("DTMAttribute"));
			return true;
		}
		public string name;
		public string desc;
		public string code;
		public StateType state;
		public string pntRef;
		public PointGeometryType pointGeometry;
		public DTMAttributeType dTMAttribute;
	}
	
	public class PointFiles : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
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
		public string fileName;
		public string fileType;
		public string fileFormat;
	}
	
	public class Boundaries : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Boundary : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.bndType = XsdConverter.Instance.Convert<SurfBndType>(attributes.GetSafe("bndType"));
			this.edgeTrim = XsdConverter.Instance.Convert<bool>(attributes.GetSafe("edgeTrim"));
			this.area = XsdConverter.Instance.Convert<double>(attributes.GetSafe("area"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public SurfBndType bndType;
		public bool edgeTrim;
		public double area;
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class Breaklines : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Breakline : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.brkType = XsdConverter.Instance.Convert<string>(attributes.GetSafe("brkType"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string brkType;
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class RetWall : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class RetWallPnt : PointType3dReq
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.height = XsdConverter.Instance.Convert<double>(attributes.GetSafe("height"));
			this.offset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("offset"));
			return true;
		}
		public double height;
		public double offset;
	}
	
	public class Contours : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Contour : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.elev = XsdConverter.Instance.Convert<double>(attributes.GetSafe("elev"));
			return true;
		}
		public double elev;
	}
	
	public class Definition : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.surfType = XsdConverter.Instance.Convert<SurfTypeEnum>(attributes.GetSafe("surfType"));
			this.area2DSurf = XsdConverter.Instance.Convert<double>(attributes.GetSafe("area2DSurf"));
			this.area3DSurf = XsdConverter.Instance.Convert<double>(attributes.GetSafe("area3DSurf"));
			this.elevMax = XsdConverter.Instance.Convert<double>(attributes.GetSafe("elevMax"));
			this.elevMin = XsdConverter.Instance.Convert<double>(attributes.GetSafe("elevMin"));
			return true;
		}
		public SurfTypeEnum surfType;
		public double area2DSurf;
		public double area3DSurf;
		public double elevMax;
		public double elevMin;
	}
	
	public class Pnts : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class P : PointType
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.id = XsdConverter.Instance.Convert<uint>(attributes.GetSafe("id"));
			return true;
		}
		public uint id;
	}
	
	public class Faces : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class Watersheds : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Watershed : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.area = XsdConverter.Instance.Convert<double>(attributes.GetSafe("area"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			return true;
		}
		public string name;
		public double area;
		public string desc;
	}
	
	public class Outlet : PointType3dReq
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.refWS = XsdConverter.Instance.Convert<string>(attributes.GetSafe("refWS"));
			return true;
		}
		public string refWS;
	}
	
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
		public string desc;
		public string name;
		public SurfVolCMethodType surfVolCalcMethod;
	}
	
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
		public string surfBase;
		public string surfCompare;
		public double volCut;
		public double volFill;
		public double volTotal;
		public string desc;
		public string name;
	}
	
	public class Parcels : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class Parcel : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.area = XsdConverter.Instance.Convert<double>(attributes.GetSafe("area"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.dirClosure = XsdConverter.Instance.Convert<double>(attributes.GetSafe("dirClosure"));
			this.distClosure = XsdConverter.Instance.Convert<double>(attributes.GetSafe("distClosure"));
			this.owner = XsdConverter.Instance.Convert<string>(attributes.GetSafe("owner"));
			this.parcelType = XsdConverter.Instance.Convert<string>(attributes.GetSafe("parcelType"));
			this.setbackFront = XsdConverter.Instance.Convert<double>(attributes.GetSafe("setbackFront"));
			this.setbackRear = XsdConverter.Instance.Convert<double>(attributes.GetSafe("setbackRear"));
			this.setbackSide = XsdConverter.Instance.Convert<double>(attributes.GetSafe("setbackSide"));
			this.state = XsdConverter.Instance.Convert<ParcelStateType>(attributes.GetSafe("state"));
			this.taxId = XsdConverter.Instance.Convert<string>(attributes.GetSafe("taxId"));
			this.@class = XsdConverter.Instance.Convert<ParcelClass>(attributes.GetSafe("class"));
			return true;
		}
		public string name;
		public string oID;
		public double area;
		public string desc;
		public double dirClosure;
		public double distClosure;
		public string owner;
		public string parcelType;
		public double setbackFront;
		public double setbackRear;
		public double setbackSide;
		public ParcelStateType state;
		public string taxId;
		public ParcelClass @class;
	}
	
	public class Title : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			return true;
		}
		public string name;
	}
	
	public class Alignments : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
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
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public double length;
		public double staStart;
		public string desc;
		public string oID;
		public StateType state;
	}
	
	public class StaEquation : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staAhead = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staAhead"));
			this.staBack = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staBack"));
			this.staInternal = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staInternal"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			return true;
		}
		public double staAhead;
		public double staBack;
		public double staInternal;
		public string desc;
	}
	
	public class Profile : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public double staStart;
		public StateType state;
	}
	
	public class ProfSurf : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public string desc;
		public StateType state;
	}
	
	public class ProfAlign : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public string desc;
		public StateType state;
	}
	
	public class PVI : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.content = XsdConverter.Instance.Convert<IList<double>>(text);
			return true;
		}
		public string desc;
		public IList<double> content;
	}
	
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
		public double length;
		public string desc;
		public IList<double> content;
	}
	
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
		public double lengthIn;
		public double lengthOut;
		public string desc;
		public IList<double> content;
	}
	
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
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
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
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public PipeNetworkType pipeNetType;
		public string alignmentRef;
		public string desc;
		public string oID;
		public StateType state;
	}
	
	public class Pipes : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Pipe : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.refEnd = XsdConverter.Instance.Convert<string>(attributes.GetSafe("refEnd"));
			this.refStart = XsdConverter.Instance.Convert<string>(attributes.GetSafe("refStart"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.slope = XsdConverter.Instance.Convert<double>(attributes.GetSafe("slope"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public string refEnd;
		public string refStart;
		public string desc;
		public double length;
		public string oID;
		public double slope;
		public StateType state;
	}
	
	public class CircPipe : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.diameter = XsdConverter.Instance.Convert<double>(attributes.GetSafe("diameter"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.hazenWilliams = XsdConverter.Instance.Convert<double>(attributes.GetSafe("hazenWilliams"));
			this.mannings = XsdConverter.Instance.Convert<double>(attributes.GetSafe("mannings"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double>(attributes.GetSafe("thickness"));
			return true;
		}
		public double diameter;
		public string desc;
		public double hazenWilliams;
		public double mannings;
		public string material;
		public double thickness;
	}
	
	public class ElliPipe : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.height = XsdConverter.Instance.Convert<double>(attributes.GetSafe("height"));
			this.span = XsdConverter.Instance.Convert<double>(attributes.GetSafe("span"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.hazenWilliams = XsdConverter.Instance.Convert<double>(attributes.GetSafe("hazenWilliams"));
			this.mannings = XsdConverter.Instance.Convert<double>(attributes.GetSafe("mannings"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double>(attributes.GetSafe("thickness"));
			return true;
		}
		public double height;
		public double span;
		public string desc;
		public double hazenWilliams;
		public double mannings;
		public string material;
		public double thickness;
	}
	
	public class RectPipe : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.height = XsdConverter.Instance.Convert<double>(attributes.GetSafe("height"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.hazenWilliams = XsdConverter.Instance.Convert<double>(attributes.GetSafe("hazenWilliams"));
			this.mannings = XsdConverter.Instance.Convert<double>(attributes.GetSafe("mannings"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double>(attributes.GetSafe("thickness"));
			return true;
		}
		public double height;
		public double width;
		public string desc;
		public double hazenWilliams;
		public double mannings;
		public string material;
		public double thickness;
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
			this.hazenWilliams = XsdConverter.Instance.Convert<double>(attributes.GetSafe("hazenWilliams"));
			this.mannings = XsdConverter.Instance.Convert<double>(attributes.GetSafe("mannings"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double>(attributes.GetSafe("thickness"));
			return true;
		}
		public double height;
		public double widthTop;
		public double widthBottom;
		public string desc;
		public double hazenWilliams;
		public double mannings;
		public string material;
		public double thickness;
	}
	
	public class PipeFlow : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.flowIn = XsdConverter.Instance.Convert<double>(attributes.GetSafe("flowIn"));
			this.areaCatchment = XsdConverter.Instance.Convert<double>(attributes.GetSafe("areaCatchment"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.depthCritical = XsdConverter.Instance.Convert<double>(attributes.GetSafe("depthCritical"));
			this.hglDown = XsdConverter.Instance.Convert<double>(attributes.GetSafe("hglDown"));
			this.hglUp = XsdConverter.Instance.Convert<double>(attributes.GetSafe("hglUp"));
			this.intensity = XsdConverter.Instance.Convert<double>(attributes.GetSafe("intensity"));
			this.runoffCoeff = XsdConverter.Instance.Convert<double>(attributes.GetSafe("runoffCoeff"));
			this.slopeCritical = XsdConverter.Instance.Convert<double>(attributes.GetSafe("slopeCritical"));
			this.timeInlet = XsdConverter.Instance.Convert<double>(attributes.GetSafe("timeInlet"));
			this.velocityCritical = XsdConverter.Instance.Convert<double>(attributes.GetSafe("velocityCritical"));
			return true;
		}
		public double flowIn;
		public double areaCatchment;
		public string desc;
		public double depthCritical;
		public double hglDown;
		public double hglUp;
		public double intensity;
		public double runoffCoeff;
		public double slopeCritical;
		public double timeInlet;
		public double velocityCritical;
	}
	
	public class Structs : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Struct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.elevRim = XsdConverter.Instance.Convert<double>(attributes.GetSafe("elevRim"));
			this.elevSump = XsdConverter.Instance.Convert<double>(attributes.GetSafe("elevSump"));
			this.oID = XsdConverter.Instance.Convert<string>(attributes.GetSafe("oID"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public string desc;
		public double elevRim;
		public double elevSump;
		public string oID;
		public StateType state;
	}
	
	public class CircStruct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.diameter = XsdConverter.Instance.Convert<double>(attributes.GetSafe("diameter"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.inletCase = XsdConverter.Instance.Convert<string>(attributes.GetSafe("inletCase"));
			this.lossCoeff = XsdConverter.Instance.Convert<double>(attributes.GetSafe("lossCoeff"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double>(attributes.GetSafe("thickness"));
			return true;
		}
		public double diameter;
		public string desc;
		public string inletCase;
		public double lossCoeff;
		public string material;
		public double thickness;
	}
	
	public class RectStruct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.length = XsdConverter.Instance.Convert<double>(attributes.GetSafe("length"));
			this.lengthDir = XsdConverter.Instance.Convert<double>(attributes.GetSafe("lengthDir"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.inletCase = XsdConverter.Instance.Convert<string>(attributes.GetSafe("inletCase"));
			this.lossCoeff = XsdConverter.Instance.Convert<double>(attributes.GetSafe("lossCoeff"));
			this.material = XsdConverter.Instance.Convert<string>(attributes.GetSafe("material"));
			this.thickness = XsdConverter.Instance.Convert<double>(attributes.GetSafe("thickness"));
			return true;
		}
		public double length;
		public double lengthDir;
		public double width;
		public string desc;
		public string inletCase;
		public double lossCoeff;
		public string material;
		public double thickness;
	}
	
	public class InletStruct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class OutletStruct : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Connection : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
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
		public string desc;
		public double elev;
		public InOut flowDir;
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
			this.hglIn = XsdConverter.Instance.Convert<double>(attributes.GetSafe("hglIn"));
			this.hglOut = XsdConverter.Instance.Convert<double>(attributes.GetSafe("hglOut"));
			this.localDepression = XsdConverter.Instance.Convert<double>(attributes.GetSafe("localDepression"));
			this.slopeSurf = XsdConverter.Instance.Convert<double>(attributes.GetSafe("slopeSurf"));
			this.slopeGutter = XsdConverter.Instance.Convert<double>(attributes.GetSafe("slopeGutter"));
			this.widthGutter = XsdConverter.Instance.Convert<double>(attributes.GetSafe("widthGutter"));
			return true;
		}
		public double lossIn;
		public double lossOut;
		public string desc;
		public double hglIn;
		public double hglOut;
		public double localDepression;
		public double slopeSurf;
		public double slopeGutter;
		public double widthGutter;
	}
	
	public class PlanFeatures : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class PlanFeature : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class GradeModel : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
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
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string alignmentRef;
		public string stationAlignmentRef;
		public ZoneSurfaceType surfaceType;
		public string surfaceRef;
		public IList<string> surfaceRefs;
		public IList<string> cgPointRefs;
		public string name;
		public string desc;
		public StateType state;
	}
	
	public class Zones : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.side = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("side"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public SideofRoadType side;
		public string desc;
		public string name;
		public StateType state;
	}
	
	public class Zone : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			this.priority = XsdConverter.Instance.Convert<int>(attributes.GetSafe("priority"));
			this.category = XsdConverter.Instance.Convert<ZoneCategoryType>(attributes.GetSafe("category"));
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.startWidth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startWidth"));
			this.startVertValue = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startVertValue"));
			this.startVertType = XsdConverter.Instance.Convert<ZoneVertType>(attributes.GetSafe("startVertType"));
			this.endWidth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endWidth"));
			this.endVertValue = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endVertValue"));
			this.endVertType = XsdConverter.Instance.Convert<ZoneVertType>(attributes.GetSafe("endVertType"));
			return true;
		}
		public string desc;
		public string name;
		public StateType state;
		public int priority;
		public ZoneCategoryType category;
		public double staStart;
		public double staEnd;
		public double startWidth;
		public double startVertValue;
		public ZoneVertType startVertType;
		public double endWidth;
		public double endVertValue;
		public ZoneVertType endVertType;
	}
	
	public class ZoneWidth : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.startWidth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startWidth"));
			this.endWidth = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endWidth"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double startWidth;
		public double endWidth;
	}
	
	public class ZoneSlope : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.startVertValue = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startVertValue"));
			this.startVertType = XsdConverter.Instance.Convert<ZoneVertType>(attributes.GetSafe("startVertType"));
			this.endVertValue = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endVertValue"));
			this.endVertType = XsdConverter.Instance.Convert<ZoneVertType>(attributes.GetSafe("endVertType"));
			this.parabolicStartStation = XsdConverter.Instance.Convert<double>(attributes.GetSafe("parabolicStartStation"));
			this.parabolicEndStation = XsdConverter.Instance.Convert<double>(attributes.GetSafe("parabolicEndStation"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double startVertValue;
		public ZoneVertType startVertType;
		public double endVertValue;
		public ZoneVertType endVertType;
		public double parabolicStartStation;
		public double parabolicEndStation;
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
		public double staStart;
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
			this.cutSlope = XsdConverter.Instance.Convert<double>(attributes.GetSafe("cutSlope"));
			this.fillSlope = XsdConverter.Instance.Convert<double>(attributes.GetSafe("fillSlope"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double cutSlope;
		public double fillSlope;
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
		public double staStart;
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
			this.offsetMode = XsdConverter.Instance.Convert<ZoneOffsetType>(attributes.GetSafe("offsetMode"), XsdConverter.Instance.Convert<ZoneOffsetType>("zone"));
			this.startOffset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startOffset"), XsdConverter.Instance.Convert<double>("0.0"));
			this.startOffsetElev = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startOffsetElev"), XsdConverter.Instance.Convert<double>("0.0"));
			this.endOffset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endOffset"), XsdConverter.Instance.Convert<double>("0.0"));
			this.endOffsetElev = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endOffsetElev"), XsdConverter.Instance.Convert<double>("0.0"));
			this.transition = XsdConverter.Instance.Convert<ZoneTransitionType>(attributes.GetSafe("transition"), XsdConverter.Instance.Convert<ZoneTransitionType>("parallel"));
			this.placement = XsdConverter.Instance.Convert<ZonePlacementType>(attributes.GetSafe("placement"), XsdConverter.Instance.Convert<ZonePlacementType>("dependent"));
			this.catalogReference = XsdConverter.Instance.Convert<System.Uri>(attributes.GetSafe("catalogReference"));
			return true;
		}
		public string name;
		public IList<double> innerConnectPnt;
		public IList<double> outerConnectPnt;
		public ZoneOffsetType offsetMode;
		public double startOffset;
		public double startOffsetElev;
		public double endOffset;
		public double endOffsetElev;
		public ZoneTransitionType transition;
		public ZonePlacementType placement;
		public System.Uri catalogReference;
	}
	
	public class Roadways : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public string desc;
		public StateType state;
	}
	
	public class Roadway : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.name = XsdConverter.Instance.Convert<string>(attributes.GetSafe("name"));
			this.alignmentRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("alignmentRefs"));
			this.gradeModelRefs = XsdConverter.Instance.Convert<IList<string>>(attributes.GetSafe("gradeModelRefs"));
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.desc = XsdConverter.Instance.Convert<string>(attributes.GetSafe("desc"));
			this.roadTerrain = XsdConverter.Instance.Convert<RoadTerrainType>(attributes.GetSafe("roadTerrain"));
			this.state = XsdConverter.Instance.Convert<StateType>(attributes.GetSafe("state"));
			return true;
		}
		public string name;
		public IList<string> alignmentRefs;
		public IList<string> gradeModelRefs;
		public double staStart;
		public double staEnd;
		public string desc;
		public RoadTerrainType roadTerrain;
		public StateType state;
	}
	
	public class Classification : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.functionalClass = XsdConverter.Instance.Convert<FunctionalClassType>(attributes.GetSafe("functionalClass"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public FunctionalClassType functionalClass;
	}
	
	public class DesignSpeed : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.speed = XsdConverter.Instance.Convert<double>(attributes.GetSafe("speed"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double speed;
	}
	
	public class DesignSpeed85th : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			this.speed = XsdConverter.Instance.Convert<double>(attributes.GetSafe("speed"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public SideofRoadType sideofRoad;
		public double speed;
	}
	
	public class Speeds : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class DailyTrafficVolume : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.aDT = XsdConverter.Instance.Convert<double>(attributes.GetSafe("ADT"));
			this.year = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("year"));
			this.escFactor = XsdConverter.Instance.Convert<double>(attributes.GetSafe("escFactor"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double aDT;
		public System.DateTime year;
		public double escFactor;
	}
	
	public class DesignHour : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.volume = XsdConverter.Instance.Convert<double>(attributes.GetSafe("volume"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double volume;
	}
	
	public class PeakHour : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			this.volume = XsdConverter.Instance.Convert<double>(attributes.GetSafe("volume"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public SideofRoadType sideofRoad;
		public double volume;
	}
	
	public class TrafficVolume : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Superelevation : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			return true;
		}
		public double staStart;
		public double staEnd;
	}
	
	public class Lanes : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class ThruLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double width;
		public SideofRoadType sideofRoad;
	}
	
	public class PassingLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endFullWidthSta"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double beginFullWidthSta;
		public double endFullWidthSta;
		public double width;
		public SideofRoadType sideofRoad;
	}
	
	public class TurnLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("beginFullWidthSta"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			this.type = XsdConverter.Instance.Convert<TurnLaneType>(attributes.GetSafe("type"));
			this.taperType = XsdConverter.Instance.Convert<LaneTaperType>(attributes.GetSafe("taperType"));
			this.taperTangentLength = XsdConverter.Instance.Convert<double>(attributes.GetSafe("taperTangentLength"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double beginFullWidthSta;
		public double width;
		public SideofRoadType sideofRoad;
		public TurnLaneType type;
		public LaneTaperType taperType;
		public double taperTangentLength;
	}
	
	public class TwoWayLeftTurnLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endFullWidthSta"));
			this.startOffset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("startOffset"));
			this.endOffset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endOffset"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double beginFullWidthSta;
		public double endFullWidthSta;
		public double startOffset;
		public double endOffset;
		public double width;
		public SideofRoadType sideofRoad;
	}
	
	public class ClimbLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endFullWidthSta"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double beginFullWidthSta;
		public double endFullWidthSta;
		public double width;
		public SideofRoadType sideofRoad;
	}
	
	public class OffsetLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endFullWidthSta"));
			this.fullOffset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("fullOffset"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double beginFullWidthSta;
		public double endFullWidthSta;
		public double fullOffset;
		public double width;
		public SideofRoadType sideofRoad;
	}
	
	public class WideningLane : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.beginFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("beginFullWidthSta"));
			this.endFullWidthSta = XsdConverter.Instance.Convert<double>(attributes.GetSafe("endFullWidthSta"));
			this.offset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("offset"));
			this.widening = XsdConverter.Instance.Convert<double>(attributes.GetSafe("widening"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double beginFullWidthSta;
		public double endFullWidthSta;
		public double offset;
		public double widening;
		public double width;
		public SideofRoadType sideofRoad;
	}
	
	public class Roadside : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
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
			this.bottomShape = XsdConverter.Instance.Convert<DitchBottomShape>(attributes.GetSafe("bottomShape"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double bottomWidth;
		public DitchBottomShape bottomShape;
	}
	
	public class ObstructionOffset : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.offset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("offset"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double offset;
		public SideofRoadType sideofRoad;
	}
	
	public class BikeFacilities : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double width;
		public SideofRoadType sideofRoad;
	}
	
	public class RoadSign : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.mUTCDCode = XsdConverter.Instance.Convert<string>(attributes.GetSafe("MUTCDCode"));
			this.station = XsdConverter.Instance.Convert<double>(attributes.GetSafe("station"));
			this.offset = XsdConverter.Instance.Convert<double>(attributes.GetSafe("offset"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			this.type = XsdConverter.Instance.Convert<RoadSignType>(attributes.GetSafe("type"));
			this.mountHeight = XsdConverter.Instance.Convert<double>(attributes.GetSafe("mountHeight"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.height = XsdConverter.Instance.Convert<double>(attributes.GetSafe("height"));
			return true;
		}
		public string mUTCDCode;
		public double station;
		public double offset;
		public SideofRoadType sideofRoad;
		public RoadSignType type;
		public double mountHeight;
		public double width;
		public double height;
	}
	
	public class DrivewayDensity : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.density = XsdConverter.Instance.Convert<int>(attributes.GetSafe("density"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public int density;
	}
	
	public class HazardRating : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.rating = XsdConverter.Instance.Convert<int>(attributes.GetSafe("rating"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public int rating;
	}
	
	public class Intersections : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class Intersection : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.roadwayRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("roadwayRef"));
			this.roadwayPI = XsdConverter.Instance.Convert<double>(attributes.GetSafe("roadwayPI"));
			this.intersectingRoadwayRef = XsdConverter.Instance.Convert<string>(attributes.GetSafe("intersectingRoadwayRef"));
			this.intersectRoadwayPI = XsdConverter.Instance.Convert<double>(attributes.GetSafe("intersectRoadwayPI"));
			this.contructionType = XsdConverter.Instance.Convert<IntersectionConstructionType>(attributes.GetSafe("contructionType"));
			return true;
		}
		public string roadwayRef;
		public double roadwayPI;
		public string intersectingRoadwayRef;
		public double intersectRoadwayPI;
		public IntersectionConstructionType contructionType;
	}
	
	public class TrafficControl : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double>(attributes.GetSafe("station"));
			this.signalPeriod = XsdConverter.Instance.Convert<double>(attributes.GetSafe("signalPeriod"));
			this.controlPosition = XsdConverter.Instance.Convert<TrafficControlPosition>(attributes.GetSafe("controlPosition"));
			this.controlType = XsdConverter.Instance.Convert<TrafficControlType>(attributes.GetSafe("controlType"));
			return true;
		}
		public double station;
		public double signalPeriod;
		public TrafficControlPosition controlPosition;
		public TrafficControlType controlType;
	}
	
	public class Timing : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double>(attributes.GetSafe("station"));
			this.legNumber = XsdConverter.Instance.Convert<int>(attributes.GetSafe("legNumber"));
			this.protectedTurnPercent = XsdConverter.Instance.Convert<double>(attributes.GetSafe("protectedTurnPercent"));
			this.unprotectedTurnPercent = XsdConverter.Instance.Convert<double>(attributes.GetSafe("unprotectedTurnPercent"));
			return true;
		}
		public double station;
		public int legNumber;
		public double protectedTurnPercent;
		public double unprotectedTurnPercent;
	}
	
	public class Volume : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double>(attributes.GetSafe("station"));
			this.legNumber = XsdConverter.Instance.Convert<int>(attributes.GetSafe("legNumber"));
			this.turnPercent = XsdConverter.Instance.Convert<double>(attributes.GetSafe("turnPercent"));
			this.percentTrucks = XsdConverter.Instance.Convert<double>(attributes.GetSafe("percentTrucks"));
			return true;
		}
		public double station;
		public int legNumber;
		public double turnPercent;
		public double percentTrucks;
	}
	
	public class TurnSpeed : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double>(attributes.GetSafe("station"));
			this.legNumber = XsdConverter.Instance.Convert<int>(attributes.GetSafe("legNumber"));
			this.speed = XsdConverter.Instance.Convert<double>(attributes.GetSafe("speed"));
			return true;
		}
		public double station;
		public int legNumber;
		public double speed;
	}
	
	public class TurnRestriction : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double>(attributes.GetSafe("station"));
			this.legNumber = XsdConverter.Instance.Convert<int>(attributes.GetSafe("legNumber"));
			this.type = XsdConverter.Instance.Convert<TrafficTurnRestriction>(attributes.GetSafe("type"));
			return true;
		}
		public double station;
		public int legNumber;
		public TrafficTurnRestriction type;
	}
	
	public class Curb : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			this.type = XsdConverter.Instance.Convert<CurbType>(attributes.GetSafe("type"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public SideofRoadType sideofRoad;
		public CurbType type;
	}
	
	public class Corner : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.type = XsdConverter.Instance.Convert<CornerType>(attributes.GetSafe("type"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public CornerType type;
	}
	
	public class CrashData : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			return true;
		}
	}
	
	public class CrashHistory : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.year = XsdConverter.Instance.Convert<System.DateTime>(attributes.GetSafe("year"));
			this.location1 = XsdConverter.Instance.Convert<double>(attributes.GetSafe("location-1"));
			this.location2 = XsdConverter.Instance.Convert<double>(attributes.GetSafe("location-2"));
			this.severity = XsdConverter.Instance.Convert<CrashSeverityType>(attributes.GetSafe("severity"));
			this.intersectionRelation = XsdConverter.Instance.Convert<CrashIntersectionRelation>(attributes.GetSafe("intersectionRelation"));
			this.intersectionLocation = XsdConverter.Instance.Convert<double>(attributes.GetSafe("intersectionLocation"));
			return true;
		}
		public System.DateTime year;
		public double location1;
		public double location2;
		public CrashSeverityType severity;
		public CrashIntersectionRelation intersectionRelation;
		public double intersectionLocation;
	}
	
	public class PostedSpeed : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			this.speedLimit = XsdConverter.Instance.Convert<double>(attributes.GetSafe("speedLimit"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public SideofRoadType sideofRoad;
		public double speedLimit;
	}
	
	public class NoPassingZone : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.sideofRoad = XsdConverter.Instance.Convert<SideofRoadType>(attributes.GetSafe("sideofRoad"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public SideofRoadType sideofRoad;
	}
	
	public class DecisionSightDistance : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.station = XsdConverter.Instance.Convert<double>(attributes.GetSafe("station"));
			this.maneuver = XsdConverter.Instance.Convert<ManeuverType>(attributes.GetSafe("maneuver"));
			return true;
		}
		public double station;
		public ManeuverType maneuver;
	}
	
	public class BridgeElement : XsdBaseObject
	{
		public override bool Read(IDictionary<string, string> attributes, string text)
		{
			base.Read(attributes, text);
			this.staStart = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staStart"));
			this.staEnd = XsdConverter.Instance.Convert<double>(attributes.GetSafe("staEnd"));
			this.width = XsdConverter.Instance.Convert<double>(attributes.GetSafe("width"));
			this.projectType = XsdConverter.Instance.Convert<BridgeProjectType>(attributes.GetSafe("projectType"));
			return true;
		}
		public double staStart;
		public double staEnd;
		public double width;
		public BridgeProjectType projectType;
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
