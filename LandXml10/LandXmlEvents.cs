#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    public class LandXmlEvents : ILandXmlEvents
    {
        public virtual void BeginReadPntList2D( IList<double> value ) { }
        public virtual void EndReadPntList2D() { }
        public virtual void BeginReadPntList3D( IList<double> value ) { }
        public virtual void EndReadPntList3D() { }
        public virtual void BeginReadF( IList<int> value ) { }
        public virtual void EndReadF() { }
        public virtual void BeginReadBeginRunoutSta( double value ) { }
        public virtual void EndReadBeginRunoutSta() { }
        public virtual void BeginReadBeginRunoffSta( double value ) { }
        public virtual void EndReadBeginRunoffSta() { }
        public virtual void BeginReadFullSuperSta( double value ) { }
        public virtual void EndReadFullSuperSta() { }
        public virtual void BeginReadFullSuperelev( double value ) { }
        public virtual void EndReadFullSuperelev() { }
        public virtual void BeginReadRunoffSta( double value ) { }
        public virtual void EndReadRunoffSta() { }
        public virtual void BeginReadStartofRunoutSta( double value ) { }
        public virtual void EndReadStartofRunoutSta() { }
        public virtual void BeginReadEndofRunoutSta( double value ) { }
        public virtual void EndReadEndofRunoutSta() { }
        public virtual void BeginReadAdverseSE( AdverseSEType value ) { }
        public virtual void EndReadAdverseSE() { }
        public virtual void BeginReadLandXML( LandXML value ) { }
        public virtual void EndReadLandXML() { }
        public virtual void BeginReadCgPoints( CgPoints value ) { }
        public virtual void EndReadCgPoints() { }
        public virtual void BeginReadCgPoint( CgPoint value ) { }
        public virtual void EndReadCgPoint() { }
        public virtual void BeginReadDocFileRef( DocFileRef value ) { }
        public virtual void EndReadDocFileRef() { }
        public virtual void BeginReadFeature( Feature value ) { }
        public virtual void EndReadFeature() { }
        public virtual void BeginReadProperty( Property value ) { }
        public virtual void EndReadProperty() { }
        public virtual void BeginReadStart( PointType value ) { }
        public virtual void EndReadStart() { }
        public virtual void BeginReadEnd( PointType value ) { }
        public virtual void EndReadEnd() { }
        public virtual void BeginReadCenter( PointType value ) { }
        public virtual void EndReadCenter() { }
        public virtual void BeginReadPI( PointType value ) { }
        public virtual void EndReadPI() { }
        public virtual void BeginReadMapPoint( PointType value ) { }
        public virtual void EndReadMapPoint() { }
        public virtual void BeginReadInstrumentPoint( PointType value ) { }
        public virtual void EndReadInstrumentPoint() { }
        public virtual void BeginReadLocation( PointType value ) { }
        public virtual void EndReadLocation() { }
        public virtual void BeginReadIrregularLine( IrregularLine value ) { }
        public virtual void EndReadIrregularLine() { }
        public virtual void BeginReadChain( Chain value ) { }
        public virtual void EndReadChain() { }
        public virtual void BeginReadCurve( Curve value ) { }
        public virtual void EndReadCurve() { }
        public virtual void BeginReadSpiral( Spiral value ) { }
        public virtual void EndReadSpiral() { }
        public virtual void BeginReadCoordGeom( CoordGeom value ) { }
        public virtual void EndReadCoordGeom() { }
        public virtual void BeginReadLine( Line value ) { }
        public virtual void EndReadLine() { }
        public virtual void BeginReadCrossSects( CrossSects value ) { }
        public virtual void EndReadCrossSects() { }
        public virtual void BeginReadCrossSect( CrossSect value ) { }
        public virtual void EndReadCrossSect() { }
        public virtual void BeginReadCrossSectSurf( CrossSectSurf value ) { }
        public virtual void EndReadCrossSectSurf() { }
        public virtual void BeginReadProject( Project value ) { }
        public virtual void EndReadProject() { }
        public virtual void BeginReadUnits( Units value ) { }
        public virtual void EndReadUnits() { }
        public virtual void BeginReadMetric( Metric value ) { }
        public virtual void EndReadMetric() { }
        public virtual void BeginReadImperial( Imperial value ) { }
        public virtual void EndReadImperial() { }
        public virtual void BeginReadCoordinateSystem( CoordinateSystem value ) { }
        public virtual void EndReadCoordinateSystem() { }
        public virtual void BeginReadApplication( Application value ) { }
        public virtual void EndReadApplication() { }
        public virtual void BeginReadAuthor( Author value ) { }
        public virtual void EndReadAuthor() { }
        public virtual void BeginReadSurvey( Survey value ) { }
        public virtual void EndReadSurvey() { }
        public virtual void BeginReadSurveyHeader( SurveyHeader value ) { }
        public virtual void EndReadSurveyHeader() { }
        public virtual void BeginReadPersonnel( Personnel value ) { }
        public virtual void EndReadPersonnel() { }
        public virtual void BeginReadFieldNote( FieldNote value ) { }
        public virtual void EndReadFieldNote() { }
        public virtual void BeginReadEquipment( Equipment value ) { }
        public virtual void EndReadEquipment() { }
        public virtual void BeginReadInstrumentDetails( InstrumentDetails value ) { }
        public virtual void EndReadInstrumentDetails() { }
        public virtual void BeginReadLaserDetails( LaserDetails value ) { }
        public virtual void EndReadLaserDetails() { }
        public virtual void BeginReadGPSAntennaDetails( GPSAntennaDetails value ) { }
        public virtual void EndReadGPSAntennaDetails() { }
        public virtual void BeginReadGPSReceiverDetails( GPSReceiverDetails value ) { }
        public virtual void EndReadGPSReceiverDetails() { }
        public virtual void BeginReadCorrections( Corrections value ) { }
        public virtual void EndReadCorrections() { }
        public virtual void BeginReadSurveyMonument( SurveyMonument value ) { }
        public virtual void EndReadSurveyMonument() { }
        public virtual void BeginReadInstrumentSetup( InstrumentSetup value ) { }
        public virtual void EndReadInstrumentSetup() { }
        public virtual void BeginReadLaserSetup( LaserSetup value ) { }
        public virtual void EndReadLaserSetup() { }
        public virtual void BeginReadGPSSetup( GPSSetup value ) { }
        public virtual void EndReadGPSSetup() { }
        public virtual void BeginReadTargetSetup( TargetSetup value ) { }
        public virtual void EndReadTargetSetup() { }
        public virtual void BeginReadBacksight( Backsight value ) { }
        public virtual void EndReadBacksight() { }
        public virtual void BeginReadRawObservation( RawObservation value ) { }
        public virtual void EndReadRawObservation() { }
        public virtual void BeginReadTargetPoint( PointType value ) { }
        public virtual void EndReadTargetPoint() { }
        public virtual void BeginReadBacksightPoint( PointType value ) { }
        public virtual void EndReadBacksightPoint() { }
        public virtual void BeginReadOffsetVals( OffsetVals value ) { }
        public virtual void EndReadOffsetVals() { }
        public virtual void BeginReadGPSVector( GPSVector value ) { }
        public virtual void EndReadGPSVector() { }
        public virtual void BeginReadGPSPosition( GPSPosition value ) { }
        public virtual void EndReadGPSPosition() { }
        public virtual void BeginReadGPSQCInfoLevel1( GPSQCInfoLevel1 value ) { }
        public virtual void EndReadGPSQCInfoLevel1() { }
        public virtual void BeginReadGPSQCInfoLevel2( GPSQCInfoLevel2 value ) { }
        public virtual void EndReadGPSQCInfoLevel2() { }
        public virtual void BeginReadObservationGroup( ObservationGroup value ) { }
        public virtual void EndReadObservationGroup() { }
        public virtual void BeginReadControlChecks( ControlChecks value ) { }
        public virtual void EndReadControlChecks() { }
        public virtual void BeginReadPointResults( PointResults value ) { }
        public virtual void EndReadPointResults() { }
        public virtual void BeginReadReducedObservation( ReducedObservation value ) { }
        public virtual void EndReadReducedObservation() { }
        public virtual void BeginReadReducedArcObservation( ReducedArcObservation value ) { }
        public virtual void EndReadReducedArcObservation() { }
        public virtual void BeginReadMonuments( Monuments value ) { }
        public virtual void EndReadMonuments() { }
        public virtual void BeginReadMonument( Monument value ) { }
        public virtual void EndReadMonument() { }
        public virtual void BeginReadSurfaces( Surfaces value ) { }
        public virtual void EndReadSurfaces() { }
        public virtual void BeginReadSurface( Surface value ) { }
        public virtual void EndReadSurface() { }
        public virtual void BeginReadSourceData( SourceData value ) { }
        public virtual void EndReadSourceData() { }
        public virtual void BeginReadDataPoints( DataPoints value ) { }
        public virtual void EndReadDataPoints() { }
        public virtual void BeginReadPointFiles( PointFiles value ) { }
        public virtual void EndReadPointFiles() { }
        public virtual void BeginReadPointFile( PointFile value ) { }
        public virtual void EndReadPointFile() { }
        public virtual void BeginReadBoundaries( Boundaries value ) { }
        public virtual void EndReadBoundaries() { }
        public virtual void BeginReadBoundary( Boundary value ) { }
        public virtual void EndReadBoundary() { }
        public virtual void BeginReadBreaklines( Breaklines value ) { }
        public virtual void EndReadBreaklines() { }
        public virtual void BeginReadBreakline( Breakline value ) { }
        public virtual void EndReadBreakline() { }
        public virtual void BeginReadRetWall( RetWall value ) { }
        public virtual void EndReadRetWall() { }
        public virtual void BeginReadRetWallPnt( RetWallPnt value ) { }
        public virtual void EndReadRetWallPnt() { }
        public virtual void BeginReadContours( Contours value ) { }
        public virtual void EndReadContours() { }
        public virtual void BeginReadContour( Contour value ) { }
        public virtual void EndReadContour() { }
        public virtual void BeginReadDefinition( Definition value ) { }
        public virtual void EndReadDefinition() { }
        public virtual void BeginReadPnts( Pnts value ) { }
        public virtual void EndReadPnts() { }
        public virtual void BeginReadP( P value ) { }
        public virtual void EndReadP() { }
        public virtual void BeginReadFaces( Faces value ) { }
        public virtual void EndReadFaces() { }
        public virtual void BeginReadWatersheds( Watersheds value ) { }
        public virtual void EndReadWatersheds() { }
        public virtual void BeginReadWatershed( Watershed value ) { }
        public virtual void EndReadWatershed() { }
        public virtual void BeginReadOutlet( Outlet value ) { }
        public virtual void EndReadOutlet() { }
        public virtual void BeginReadSurfVolumes( SurfVolumes value ) { }
        public virtual void EndReadSurfVolumes() { }
        public virtual void BeginReadSurfVolume( SurfVolume value ) { }
        public virtual void EndReadSurfVolume() { }
        public virtual void BeginReadParcels( Parcels value ) { }
        public virtual void EndReadParcels() { }
        public virtual void BeginReadParcel( Parcel value ) { }
        public virtual void EndReadParcel() { }
        public virtual void BeginReadTitle( Title value ) { }
        public virtual void EndReadTitle() { }
        public virtual void BeginReadAlignments( Alignments value ) { }
        public virtual void EndReadAlignments() { }
        public virtual void BeginReadAlignment( Alignment value ) { }
        public virtual void EndReadAlignment() { }
        public virtual void BeginReadStaEquation( StaEquation value ) { }
        public virtual void EndReadStaEquation() { }
        public virtual void BeginReadProfile( Profile value ) { }
        public virtual void EndReadProfile() { }
        public virtual void BeginReadProfSurf( ProfSurf value ) { }
        public virtual void EndReadProfSurf() { }
        public virtual void BeginReadProfAlign( ProfAlign value ) { }
        public virtual void EndReadProfAlign() { }
        public virtual void BeginReadPVI( PVI value ) { }
        public virtual void EndReadPVI() { }
        public virtual void BeginReadParaCurve( ParaCurve value ) { }
        public virtual void EndReadParaCurve() { }
        public virtual void BeginReadUnsymParaCurve( UnsymParaCurve value ) { }
        public virtual void EndReadUnsymParaCurve() { }
        public virtual void BeginReadCircCurve( CircCurve value ) { }
        public virtual void EndReadCircCurve() { }
        public virtual void BeginReadPipeNetworks( PipeNetworks value ) { }
        public virtual void EndReadPipeNetworks() { }
        public virtual void BeginReadPipeNetwork( PipeNetwork value ) { }
        public virtual void EndReadPipeNetwork() { }
        public virtual void BeginReadPipes( Pipes value ) { }
        public virtual void EndReadPipes() { }
        public virtual void BeginReadPipe( Pipe value ) { }
        public virtual void EndReadPipe() { }
        public virtual void BeginReadCircPipe( CircPipe value ) { }
        public virtual void EndReadCircPipe() { }
        public virtual void BeginReadElliPipe( ElliPipe value ) { }
        public virtual void EndReadElliPipe() { }
        public virtual void BeginReadRectPipe( RectPipe value ) { }
        public virtual void EndReadRectPipe() { }
        public virtual void BeginReadChannel( Channel value ) { }
        public virtual void EndReadChannel() { }
        public virtual void BeginReadPipeFlow( PipeFlow value ) { }
        public virtual void EndReadPipeFlow() { }
        public virtual void BeginReadStructs( Structs value ) { }
        public virtual void EndReadStructs() { }
        public virtual void BeginReadStruct( Struct value ) { }
        public virtual void EndReadStruct() { }
        public virtual void BeginReadCircStruct( CircStruct value ) { }
        public virtual void EndReadCircStruct() { }
        public virtual void BeginReadRectStruct( RectStruct value ) { }
        public virtual void EndReadRectStruct() { }
        public virtual void BeginReadInletStruct( InletStruct value ) { }
        public virtual void EndReadInletStruct() { }
        public virtual void BeginReadOutletStruct( OutletStruct value ) { }
        public virtual void EndReadOutletStruct() { }
        public virtual void BeginReadConnection( Connection value ) { }
        public virtual void EndReadConnection() { }
        public virtual void BeginReadInvert( Invert value ) { }
        public virtual void EndReadInvert() { }
        public virtual void BeginReadStructFlow( StructFlow value ) { }
        public virtual void EndReadStructFlow() { }
        public virtual void BeginReadPlanFeatures( PlanFeatures value ) { }
        public virtual void EndReadPlanFeatures() { }
        public virtual void BeginReadPlanFeature( PlanFeature value ) { }
        public virtual void EndReadPlanFeature() { }
        public virtual void BeginReadGradeModel( GradeModel value ) { }
        public virtual void EndReadGradeModel() { }
        public virtual void BeginReadGradeSurface( GradeSurface value ) { }
        public virtual void EndReadGradeSurface() { }
        public virtual void BeginReadZones( Zones value ) { }
        public virtual void EndReadZones() { }
        public virtual void BeginReadZone( Zone value ) { }
        public virtual void EndReadZone() { }
        public virtual void BeginReadZoneWidth( ZoneWidth value ) { }
        public virtual void EndReadZoneWidth() { }
        public virtual void BeginReadZoneSlope( ZoneSlope value ) { }
        public virtual void EndReadZoneSlope() { }
        public virtual void BeginReadZoneHinge( ZoneHinge value ) { }
        public virtual void EndReadZoneHinge() { }
        public virtual void BeginReadZoneCutFill( ZoneCutFill value ) { }
        public virtual void EndReadZoneCutFill() { }
        public virtual void BeginReadZoneMaterial( ZoneMaterial value ) { }
        public virtual void EndReadZoneMaterial() { }
        public virtual void BeginReadZoneCrossSectStructure( ZoneCrossSectStructure value ) { }
        public virtual void EndReadZoneCrossSectStructure() { }
        public virtual void BeginReadRoadways( Roadways value ) { }
        public virtual void EndReadRoadways() { }
        public virtual void BeginReadRoadway( Roadway value ) { }
        public virtual void EndReadRoadway() { }
        public virtual void BeginReadClassification( Classification value ) { }
        public virtual void EndReadClassification() { }
        public virtual void BeginReadDesignSpeed( DesignSpeed value ) { }
        public virtual void EndReadDesignSpeed() { }
        public virtual void BeginReadDesignSpeed85th( DesignSpeed85th value ) { }
        public virtual void EndReadDesignSpeed85th() { }
        public virtual void BeginReadSpeeds( Speeds value ) { }
        public virtual void EndReadSpeeds() { }
        public virtual void BeginReadDailyTrafficVolume( DailyTrafficVolume value ) { }
        public virtual void EndReadDailyTrafficVolume() { }
        public virtual void BeginReadDesignHour( DesignHour value ) { }
        public virtual void EndReadDesignHour() { }
        public virtual void BeginReadPeakHour( PeakHour value ) { }
        public virtual void EndReadPeakHour() { }
        public virtual void BeginReadTrafficVolume( TrafficVolume value ) { }
        public virtual void EndReadTrafficVolume() { }
        public virtual void BeginReadSuperelevation( Superelevation value ) { }
        public virtual void EndReadSuperelevation() { }
        public virtual void BeginReadLanes( Lanes value ) { }
        public virtual void EndReadLanes() { }
        public virtual void BeginReadThruLane( ThruLane value ) { }
        public virtual void EndReadThruLane() { }
        public virtual void BeginReadPassingLane( PassingLane value ) { }
        public virtual void EndReadPassingLane() { }
        public virtual void BeginReadTurnLane( TurnLane value ) { }
        public virtual void EndReadTurnLane() { }
        public virtual void BeginReadTwoWayLeftTurnLane( TwoWayLeftTurnLane value ) { }
        public virtual void EndReadTwoWayLeftTurnLane() { }
        public virtual void BeginReadClimbLane( ClimbLane value ) { }
        public virtual void EndReadClimbLane() { }
        public virtual void BeginReadOffsetLane( OffsetLane value ) { }
        public virtual void EndReadOffsetLane() { }
        public virtual void BeginReadWideningLane( WideningLane value ) { }
        public virtual void EndReadWideningLane() { }
        public virtual void BeginReadRoadside( Roadside value ) { }
        public virtual void EndReadRoadside() { }
        public virtual void BeginReadDitch( Ditch value ) { }
        public virtual void EndReadDitch() { }
        public virtual void BeginReadObstructionOffset( ObstructionOffset value ) { }
        public virtual void EndReadObstructionOffset() { }
        public virtual void BeginReadBikeFacilities( BikeFacilities value ) { }
        public virtual void EndReadBikeFacilities() { }
        public virtual void BeginReadRoadSign( RoadSign value ) { }
        public virtual void EndReadRoadSign() { }
        public virtual void BeginReadDrivewayDensity( DrivewayDensity value ) { }
        public virtual void EndReadDrivewayDensity() { }
        public virtual void BeginReadHazardRating( HazardRating value ) { }
        public virtual void EndReadHazardRating() { }
        public virtual void BeginReadIntersections( Intersections value ) { }
        public virtual void EndReadIntersections() { }
        public virtual void BeginReadIntersection( Intersection value ) { }
        public virtual void EndReadIntersection() { }
        public virtual void BeginReadTrafficControl( TrafficControl value ) { }
        public virtual void EndReadTrafficControl() { }
        public virtual void BeginReadTiming( Timing value ) { }
        public virtual void EndReadTiming() { }
        public virtual void BeginReadVolume( Volume value ) { }
        public virtual void EndReadVolume() { }
        public virtual void BeginReadTurnSpeed( TurnSpeed value ) { }
        public virtual void EndReadTurnSpeed() { }
        public virtual void BeginReadTurnRestriction( TurnRestriction value ) { }
        public virtual void EndReadTurnRestriction() { }
        public virtual void BeginReadCurb( Curb value ) { }
        public virtual void EndReadCurb() { }
        public virtual void BeginReadCorner( Corner value ) { }
        public virtual void EndReadCorner() { }
        public virtual void BeginReadCrashData( CrashData value ) { }
        public virtual void EndReadCrashData() { }
        public virtual void BeginReadCrashHistory( CrashHistory value ) { }
        public virtual void EndReadCrashHistory() { }
        public virtual void BeginReadPostedSpeed( PostedSpeed value ) { }
        public virtual void EndReadPostedSpeed() { }
        public virtual void BeginReadNoPassingZone( NoPassingZone value ) { }
        public virtual void EndReadNoPassingZone() { }
        public virtual void BeginReadDecisionSightDistance( DecisionSightDistance value ) { }
        public virtual void EndReadDecisionSightDistance() { }
        public virtual void BeginReadBridgeElement( BridgeElement value ) { }
        public virtual void EndReadBridgeElement() { }

    }
}
#endif

