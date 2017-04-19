#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml12
{

    public interface ILandXmlEvents
    {
        /// <summary>
        /// Element PntList2D
        /// {
        ///      Restrictions { [MinLength 2] } of Point
        /// }
        /// </summary>

        void BeginReadPntList2D( IList<double> value );
        void EndReadPntList2D();
        /// <summary>
        /// Element PntList3D
        /// {
        ///      Restrictions { [MinLength 3] } of Point
        /// }
        /// </summary>

        void BeginReadPntList3D( IList<double> value );
        void EndReadPntList3D();
        /// <summary>
        /// Element BeginRunoutSta of type station
        /// </summary>

        void BeginReadBeginRunoutSta( double value );
        void EndReadBeginRunoutSta();
        /// <summary>
        /// Element BeginRunoffSta of type station
        /// </summary>

        void BeginReadBeginRunoffSta( double value );
        void EndReadBeginRunoffSta();
        /// <summary>
        /// Element FullSuperSta of type station
        /// </summary>

        void BeginReadFullSuperSta( double value );
        void EndReadFullSuperSta();
        /// <summary>
        /// Element FullSuperelev of type slope
        /// </summary>

        void BeginReadFullSuperelev( double value );
        void EndReadFullSuperelev();
        /// <summary>
        /// Element RunoffSta of type station
        /// </summary>

        void BeginReadRunoffSta( double value );
        void EndReadRunoffSta();
        /// <summary>
        /// Element StartofRunoutSta of type station
        /// </summary>

        void BeginReadStartofRunoutSta( double value );
        void EndReadStartofRunoutSta();
        /// <summary>
        /// Element EndofRunoutSta of type station
        /// </summary>

        void BeginReadEndofRunoutSta( double value );
        void EndReadEndofRunoutSta();
        /// <summary>
        /// Element AdverseSE of type adverseSEType
        /// </summary>

        void BeginReadAdverseSE( AdverseSEType value );
        void EndReadAdverseSE();
        /// <summary>
        /// Element Station of type double
        /// </summary>

        void BeginReadStation( double value );
        void EndReadStation();
        /// <summary>
        /// Element LandXML
        /// {
        ///     Attribute date of type date
        ///      Attribute time of type time
        ///      Attribute version of type string
        ///      Attribute language of type string
        ///      Attribute readOnly of type boolean
        ///      Attribute LandXMLId of type int
        ///      Attribute crc of type integer
        ///      Choice [1, *]
        ///          Units [1, 1]
        ///          CoordinateSystem [0, 1]
        ///          Project [0, 1]
        ///          Application [0, *]
        ///          Alignments [0, *]
        ///          CgPoints [0, *]
        ///          Amendment [0, *]
        ///          GradeModel [0, *]
        ///          Monuments [0, *]
        ///          Parcels [0, *]
        ///          PlanFeatures [0, *]
        ///          PipeNetworks [0, *]
        ///          Roadways [0, *]
        ///          Surfaces [0, *]
        ///          Survey [0, *]
        ///          FeatureDictionary [0, *]
        ///          XmlSchemaProcessor.Xsd.XsdParticleAny
        /// }
        /// </summary>

        void BeginReadLandXML( LandXML value );
        void EndReadLandXML();
        /// <summary>
        /// Element CgPoints
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Attribute code of type string
        ///      Attribute zoneNumber of type zoneNumberType
        ///      Attribute DTMAttribute of type DTMAttributeType
        ///      Sequence [1, 1]
        ///          CgPoint [0, *]
        ///          CgPoints [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCgPoints( CgPoints value );
        void EndReadCgPoints();
        /// <summary>
        /// Element CgPoint
        /// {
        ///     <unnamed> Extension of PointType
        ///      Attribute oID of type string
        ///      Attribute surveyOrder of type string
        ///      Attribute pntSurv of type survPntType
        ///      Attribute zoneNumber of type zoneNumberType
        ///      Attribute surveyHorizontalOrder of type string
        ///      Attribute surveyVerticalOrder of type string
        ///      Attribute localUncertainity of type double
        ///      Attribute positionalUncertainity of type double
        /// }
        /// </summary>

        void BeginReadCgPoint( CgPoint value );
        void EndReadCgPoint();
        /// <summary>
        /// Element DocFileRef
        /// {
        ///     Attribute name
        ///      Attribute location of type anyURI
        ///      Attribute fileType of type string
        ///      Attribute fileFormat of type string
        /// }
        /// </summary>

        void BeginReadDocFileRef( DocFileRef value );
        void EndReadDocFileRef();
        /// <summary>
        /// Element Property
        /// {
        ///     Attribute label
        ///      Attribute value
        /// }
        /// </summary>

        void BeginReadProperty( Property value );
        void EndReadProperty();
        /// <summary>
        /// Element Feature
        /// {
        ///     Attribute name of type string
        ///      Attribute code of type string
        ///      Attribute source
        ///      Sequence [1, 1]
        ///          Property [0, *]
        ///          DocFileRef [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadFeature( Feature value );
        void EndReadFeature();
        /// <summary>
        /// Element FeatureDictionary
        /// {
        ///     Attribute name of type string
        ///      Attribute version of type string
        ///      Sequence [1, 1]
        ///          DocFileRef [0, *]
        /// }
        /// </summary>

        void BeginReadFeatureDictionary( FeatureDictionary value );
        void EndReadFeatureDictionary();
        /// <summary>
        /// Element Start of type PointType
        /// </summary>

        void BeginReadStart( PointType value );
        void EndReadStart();
        /// <summary>
        /// Element End of type PointType
        /// </summary>

        void BeginReadEnd( PointType value );
        void EndReadEnd();
        /// <summary>
        /// Element Center of type PointType
        /// </summary>

        void BeginReadCenter( PointType value );
        void EndReadCenter();
        /// <summary>
        /// Element PI of type PointType
        /// </summary>

        void BeginReadPI( PointType value );
        void EndReadPI();
        /// <summary>
        /// Element MapPoint of type PointType
        /// </summary>

        void BeginReadMapPoint( PointType value );
        void EndReadMapPoint();
        /// <summary>
        /// Element InstrumentPoint of type PointType
        /// </summary>

        void BeginReadInstrumentPoint( PointType value );
        void EndReadInstrumentPoint();
        /// <summary>
        /// Element Location of type PointType
        /// </summary>

        void BeginReadLocation( PointType value );
        void EndReadLocation();
        /// <summary>
        /// Element IrregularLine
        /// {
        ///     Attribute desc of type string
        ///      Attribute dir of type direction
        ///      Attribute length of type double
        ///      Attribute name of type string
        ///      Attribute staStart of type double
        ///      Attribute state of type stateType
        ///      Attribute oID of type string
        ///      Attribute source of type string
        ///      Attribute note of type string
        ///      Sequence [1, 1]
        ///          Start [1, 1]
        ///          End [1, 1]
        ///          Choice [1, 1]
        ///              PntList2D [1, 1]
        ///              PntList3D [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadIrregularLine( IrregularLine value );
        void EndReadIrregularLine();
        /// <summary>
        /// Element Chain
        /// {
        ///     <unnamed> Extension of ChainType
        ///      Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute code of type string
        ///      Attribute state of type stateType
        ///      Attribute pointGeometry of type pointGeometryType
        ///      Attribute DTMAttribute of type DTMAttributeType
        ///      Attribute timeStamp of type dateTime
        ///      Attribute role of type surveyRoleType
        ///      Attribute station of type station
        ///      Attribute zone of type string
        ///      Attribute status of type observationStatusType
        /// }
        /// </summary>

        void BeginReadChain( Chain value );
        void EndReadChain();
        /// <summary>
        /// Element Curve
        /// {
        ///     Attribute rot of type clockwise
        ///      Attribute chord of type double
        ///      Attribute crvType of type curveType
        ///      Attribute delta of type angle
        ///      Attribute desc of type string
        ///      Attribute dirEnd of type direction
        ///      Attribute dirStart of type direction
        ///      Attribute external of type double
        ///      Attribute length of type double
        ///      Attribute midOrd of type double
        ///      Attribute name of type string
        ///      Attribute radius of type double
        ///      Attribute staStart of type double
        ///      Attribute state of type stateType
        ///      Attribute tangent of type double
        ///      Attribute oID of type string
        ///      Attribute note of type string
        ///      Choice [3, *]
        ///          Start [1, 1]
        ///          Center [1, 1]
        ///          End [1, 1]
        ///          PI [0, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCurve( Curve value );
        void EndReadCurve();
        /// <summary>
        /// Element Spiral
        /// {
        ///     Attribute length of type double
        ///      Attribute radiusEnd of type double
        ///      Attribute radiusStart of type double
        ///      Attribute rot of type clockwise
        ///      Attribute spiType of type spiralType
        ///      Attribute chord of type double
        ///      Attribute constant of type double
        ///      Attribute desc of type string
        ///      Attribute dirEnd of type direction
        ///      Attribute dirStart of type direction
        ///      Attribute name of type string
        ///      Attribute theta of type angle
        ///      Attribute totalY of type double
        ///      Attribute totalX of type double
        ///      Attribute staStart of type double
        ///      Attribute state of type stateType
        ///      Attribute tanLong of type double
        ///      Attribute tanShort of type double
        ///      Attribute oID of type string
        ///      Sequence [1, 1]
        ///          Choice [3, 3]
        ///              Start [1, 1]
        ///              PI [1, 1]
        ///              End [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSpiral( Spiral value );
        void EndReadSpiral();
        /// <summary>
        /// Element CoordGeom
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Attribute oID of type string
        ///      Sequence [1, 1]
        ///          Choice [1, *]
        ///              Line [0, *]
        ///              IrregularLine [0, *]
        ///              Curve [0, *]
        ///              Spiral [0, *]
        ///              Chain [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCoordGeom( CoordGeom value );
        void EndReadCoordGeom();
        /// <summary>
        /// Element Line
        /// {
        ///     Attribute desc of type string
        ///      Attribute dir of type direction
        ///      Attribute length of type double
        ///      Attribute name of type string
        ///      Attribute staStart of type double
        ///      Attribute state of type stateType
        ///      Attribute oID of type string
        ///      Attribute note of type string
        ///      Sequence [1, 1]
        ///          Start [1, 1]
        ///          End [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadLine( Line value );
        void EndReadLine();
        /// <summary>
        /// Element CrossSects
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Attribute calcMethod of type xsVolCalcMethodType
        ///      Attribute curveCorrection of type boolean
        ///      Attribute swellFactor of type double
        ///      Attribute shrinkFactor of type double
        ///      Sequence [1, 1]
        ///          CrossSect [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCrossSects( CrossSects value );
        void EndReadCrossSects();
        /// <summary>
        /// Element CrossSect
        /// {
        ///     Attribute sta of type double
        ///      Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute angleSkew of type angle
        ///      Attribute areaCut of type crossSectSurfaceArea
        ///      Attribute areaFill of type crossSectSurfaceArea
        ///      Attribute centroidCut of type double
        ///      Attribute centroidFill of type double
        ///      Attribute sectType of type string
        ///      Attribute volumeCut of type crossSectSurfaceVolume
        ///      Attribute volumeFill of type crossSectSurfaceVolume
        ///      Sequence [1, 1]
        ///          CrossSectSurf [0, *]
        ///          DesignCrossSectSurf [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCrossSect( CrossSect value );
        void EndReadCrossSect();
        /// <summary>
        /// Element CrossSectSurf
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          PntList2D [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCrossSectSurf( CrossSectSurf value );
        void EndReadCrossSectSurf();
        /// <summary>
        /// Element CrossSectPnt
        /// {
        ///     <unnamed> Extension of PointType
        ///      Attribute dataFormat of type dataFormatType
        ///      Attribute alignRef of type alignmentNameRef
        ///      Attribute alignRefStation of type station
        ///      Attribute planFeatureRef of type planFeatureNameRef
        ///      Attribute planFeatureRefStation of type station
        ///      Attribute parcelRef of type parcelNameRef
        ///      Attribute parcelRefStation of type station
        /// }
        /// </summary>

        void BeginReadCrossSectPnt( CrossSectPnt value );
        void EndReadCrossSectPnt();
        /// <summary>
        /// Element DesignCrossSectSurf
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Attribute side of type sideofRoadType
        ///      Attribute material of type string
        ///      Attribute closedArea of type boolean
        ///      Attribute typicalThickness of type double
        ///      Attribute typicalWidth of type double
        ///      Attribute area of type crossSectSurfaceArea
        ///      Attribute volume of type crossSectSurfaceVolume
        ///      Sequence [1, 1]
        ///          CrossSectPnt [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDesignCrossSectSurf( DesignCrossSectSurf value );
        void EndReadDesignCrossSectSurf();
        /// <summary>
        /// Element Project
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Choice [0, *]
        ///          Feature [0, *]
        ///          XmlSchemaProcessor.Xsd.XsdParticleAny
        /// }
        /// </summary>

        void BeginReadProject( Project value );
        void EndReadProject();
        /// <summary>
        /// Element Units
        /// {
        ///     Choice [1, 1]
        ///          Metric [1, 1]
        ///          Imperial [1, 1]
        /// }
        /// </summary>

        void BeginReadUnits( Units value );
        void EndReadUnits();
        /// <summary>
        /// Element Metric
        /// {
        ///     Attribute areaUnit of type metArea
        ///      Attribute linearUnit of type metLinear
        ///      Attribute volumeUnit of type metVolume
        ///      Attribute temperatureUnit of type metTemperature
        ///      Attribute pressureUnit of type metPressure
        ///      Attribute diameterUnit of type metDiameter
        ///      Attribute widthUnit of type metWidth
        ///      Attribute heightUnit of type metHeight
        ///      Attribute velocityUnit of type metVelocity
        ///      Attribute flowUnit of type metFlow
        ///      Attribute angularUnit of type angularType
        ///      Attribute directionUnit of type angularType
        ///      Attribute latLongAngularUnit of type latLongAngularType
        ///      Attribute elevationUnit of type elevationType
        /// }
        /// </summary>

        void BeginReadMetric( Metric value );
        void EndReadMetric();
        /// <summary>
        /// Element Imperial
        /// {
        ///     Attribute areaUnit of type impArea
        ///      Attribute linearUnit of type impLinear
        ///      Attribute volumeUnit of type impVolume
        ///      Attribute temperatureUnit of type impTemperature
        ///      Attribute pressureUnit of type impPressure
        ///      Attribute diameterUnit of type impDiameter
        ///      Attribute widthUnit of type impWidth
        ///      Attribute heightUnit of type impHeight
        ///      Attribute velocityUnit of type impVelocity
        ///      Attribute flowUnit of type impFlow
        ///      Attribute angularUnit of type angularType
        ///      Attribute directionUnit of type angularType
        ///      Attribute latLongAngularUnit of type latLongAngularType
        ///      Attribute elevationUnit of type elevationType
        /// }
        /// </summary>

        void BeginReadImperial( Imperial value );
        void EndReadImperial();
        /// <summary>
        /// Element CoordinateSystem
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute epsgCode of type string
        ///      Attribute ogcWktCode of type string
        ///      Attribute horizontalDatum of type string
        ///      Attribute verticalDatum of type string
        ///      Attribute ellipsoidName of type string
        ///      Attribute horizontalCoordinateSystemName of type string
        ///      Attribute geocentricCoordinateSystemName of type string
        ///      Attribute fileLocation of type anyURI
        ///      Attribute rotationAngle of type angle
        ///      Attribute datum of type string
        ///      Attribute fittedCoordinateSystemName of type string
        ///      Attribute compoundCoordinateSystemName of type string
        ///      Attribute localCoordinateSystemName of type string
        ///      Attribute geographicCoordinateSystemName of type string
        ///      Attribute projectedCoordinateSystemName of type string
        ///      Attribute verticalCoordinateSystemName of type string
        ///      Sequence [1, 1]
        ///          Start [0, 1]
        ///          FieldNote [0, *]
        ///          Feature [0, *]
        ///          XmlSchemaProcessor.Xsd.XsdParticleAny
        /// }
        /// </summary>

        void BeginReadCoordinateSystem( CoordinateSystem value );
        void EndReadCoordinateSystem();
        /// <summary>
        /// Element Application
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute manufacturer of type string
        ///      Attribute version of type string
        ///      Attribute manufacturerURL of type string
        ///      Attribute timeStamp of type dateTime
        ///      Sequence [1, 1]
        ///          Choice [1, 1]
        ///              Author [0, *]
        ///              XmlSchemaProcessor.Xsd.XsdParticleAny
        /// }
        /// </summary>

        void BeginReadApplication( Application value );
        void EndReadApplication();
        /// <summary>
        /// Element Author
        /// {
        ///     Attribute createdBy of type string
        ///      Attribute createdByEmail of type string
        ///      Attribute company of type string
        ///      Attribute companyURL of type string
        ///      Attribute timeStamp of type dateTime
        ///      Sequence [1, 1]
        ///          XmlSchemaProcessor.Xsd.XsdParticleAny
        /// }
        /// </summary>

        void BeginReadAuthor( Author value );
        void EndReadAuthor();
        /// <summary>
        /// Element Survey
        /// {
        ///     Attribute desc of type string
        ///      Attribute date of type date
        ///      Attribute startTime of type dateTime
        ///      Attribute endTime of type dateTime
        ///      Attribute state of type stateType
        ///      Attribute horizontalAccuracy of type string
        ///      Attribute verticalAccuracy of type string
        ///      Sequence [1, 1]
        ///          SurveyHeader [1, 1]
        ///          Equipment [0, 1]
        ///          Choice [0, *]
        ///              SurveyMonument [0, 1]
        ///              CgPoints [0, 1]
        ///              InstrumentSetup [0, 1]
        ///              LaserSetup [0, 1]
        ///              GPSSetup [0, 1]
        ///              TargetSetup [0, 1]
        ///              GPSVector [1, 1]
        ///              GPSPosition [1, 1]
        ///              ObservationGroup [1, 1]
        ///              ControlChecks [1, 1]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSurvey( Survey value );
        void EndReadSurvey();
        /// <summary>
        /// Element SurveyHeader
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute purpose of type purposeType
        ///      Attribute startTime of type dateTime
        ///      Attribute endTime of type dateTime
        ///      Attribute surveyor of type string
        ///      Attribute surveyorFirm of type string
        ///      Attribute surveyorReference of type string
        ///      Attribute surveyorRegistration of type string
        ///      Attribute surveyPurpose of type string
        ///      Attribute type of type surveyType
        ///      Attribute class of type string
        ///      Attribute county of type string
        ///      Attribute applyAtmosphericCorrection of type boolean
        ///      Attribute pressure of type double
        ///      Attribute temperature of type double
        ///      Attribute applySeaLevelCorrection of type boolean
        ///      Attribute scaleFactor of type double
        ///      Attribute seaLevelCorrectionFactor of type double
        ///      Attribute combinedFactor of type double
        ///      Attribute jurisdiction of type jurisdictionType
        ///      Attribute submissionDate of type date
        ///      Attribute documentStatus of type documentStatusType
        ///      Attribute surveyFormat of type surveyFormatType
        ///      Attribute surveyStatus of type surveyStatusType
        ///      Attribute communityTitleSchemeNo of type int
        ///      Attribute communityTitleSchemeName of type string
        ///      Attribute fieldNoteFlag of type boolean
        ///      Attribute fieldNoteReference of type string
        ///      Attribute fieldReport of type string
        ///      Choice [0, *]
        ///          Annotation [0, *]
        ///          AdministrativeArea [0, *]
        ///          AdministrativeDate [0, *]
        ///          CoordinateSystem [0, 1]
        ///          Units [0, 1]
        ///          MapPoint [0, *]
        ///          Personnel [0, *]
        ///          FieldNote [0, *]
        ///          Feature [0, *]
        ///          SurveyorCertificate [0, *]
        ///          PurposeOfSurvey [0, *]
        ///          HeadOfPower [0, *]
        /// }
        /// </summary>

        void BeginReadSurveyHeader( SurveyHeader value );
        void EndReadSurveyHeader();
        /// <summary>
        /// Element HeadOfPower
        /// {
        ///     Attribute name of type headOfPowerType
        /// }
        /// </summary>

        void BeginReadHeadOfPower( HeadOfPower value );
        void EndReadHeadOfPower();
        /// <summary>
        /// Element AdministrativeArea
        /// {
        ///     Attribute adminAreaType of type adminAreaTypeType
        ///      Attribute adminAreaName of type string
        ///      Attribute adminAreaCode of type string
        ///      Attribute pclRef of type parcelNameRefs
        /// }
        /// </summary>

        void BeginReadAdministrativeArea( AdministrativeArea value );
        void EndReadAdministrativeArea();
        /// <summary>
        /// Element AdministrativeDate
        /// {
        ///     Attribute adminDateType of type adminDateTypeType
        ///      Attribute adminDate of type date
        /// }
        /// </summary>

        void BeginReadAdministrativeDate( AdministrativeDate value );
        void EndReadAdministrativeDate();
        /// <summary>
        /// Element Annotation
        /// {
        ///     Attribute type of type annotationType
        ///      Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute pclRef of type parcelNameRefs
        /// }
        /// </summary>

        void BeginReadAnnotation( Annotation value );
        void EndReadAnnotation();
        /// <summary>
        /// Element SurveyorCertificate
        /// {
        ///     Attribute name of type string
        ///      Attribute certificateType of type string
        ///      Attribute textCertificate of type string
        ///      Attribute surveyDate of type date
        /// }
        /// </summary>

        void BeginReadSurveyorCertificate( SurveyorCertificate value );
        void EndReadSurveyorCertificate();
        /// <summary>
        /// Element PurposeOfSurvey
        /// {
        ///     Attribute name of type purpSurvType
        /// }
        /// </summary>

        void BeginReadPurposeOfSurvey( PurposeOfSurvey value );
        void EndReadPurposeOfSurvey();
        /// <summary>
        /// Element Amendment
        /// {
        ///     Attribute dealingNumber of type string
        ///      Attribute amendmentDate of type date
        ///      Attribute comments of type string
        ///      Sequence [1, 1]
        ///          AmendmentItem [1, *]
        /// }
        /// </summary>

        void BeginReadAmendment( Amendment value );
        void EndReadAmendment();
        /// <summary>
        /// Element AmendmentItem
        /// {
        ///     Attribute elementName of type string
        ///      Attribute oldName of type string
        ///      Attribute newName of type string
        /// }
        /// </summary>

        void BeginReadAmendmentItem( AmendmentItem value );
        void EndReadAmendmentItem();
        /// <summary>
        /// Element Personnel
        /// {
        ///     Attribute name of type string
        ///      Attribute role of type surveyorRoleType
        ///      Attribute regType of type registrationType
        ///      Attribute regNumber of type string
        /// }
        /// </summary>

        void BeginReadPersonnel( Personnel value );
        void EndReadPersonnel();
        /// <summary>
        /// Element FieldNote
        /// {
        ///     Choice [1, *]
        ///          XmlSchemaProcessor.Xsd.XsdParticleAny
        /// }
        /// </summary>

        void BeginReadFieldNote( FieldNote value );
        void EndReadFieldNote();
        /// <summary>
        /// Element Equipment
        /// {
        ///     Sequence [1, 1]
        ///          Choice [1, 1]
        ///              InstrumentDetails [1, 1]
        ///              LaserDetails [1, 1]
        ///              GPSReceiverDetails [1, 1]
        ///              GPSAntennaDetails [1, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadEquipment( Equipment value );
        void EndReadEquipment();
        /// <summary>
        /// Element InstrumentDetails
        /// {
        ///     Attribute id of type ID
        ///      Attribute edmAccuracyConstant of type double
        ///      Attribute edmAccuracyppm of type double
        ///      Attribute edmVertOffset of type double
        ///      Attribute horizAnglePrecision of type double
        ///      Attribute manufacturer of type string
        ///      Attribute model of type string
        ///      Attribute serialNumber of type string
        ///      Attribute zenithAnglePrecision of type double
        ///      Attribute carrierWavelength of type double
        ///      Attribute refractiveIndex of type double
        ///      Attribute horizCollimation of type double
        ///      Attribute vertCollimation of type double
        ///      Attribute stadiaFactor of type double
        ///      Sequence [1, 1]
        ///          Corrections [1, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadInstrumentDetails( InstrumentDetails value );
        void EndReadInstrumentDetails();
        /// <summary>
        /// Element LaserDetails
        /// {
        ///     Attribute id of type ID
        ///      Attribute laserVertOffset of type double
        ///      Attribute manufacturer of type string
        ///      Attribute model of type string
        ///      Attribute serialNumber of type string
        ///      Sequence [1, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadLaserDetails( LaserDetails value );
        void EndReadLaserDetails();
        /// <summary>
        /// Element GPSAntennaDetails
        /// {
        ///     Attribute id of type ID
        ///      Attribute manufacturer of type string
        ///      Attribute model of type string
        ///      Attribute serialNumber of type string
        ///      Attribute latitude of type double
        ///      Attribute longitude of type double
        ///      Attribute altitude of type double
        ///      Attribute ellipsiodalHeight of type double
        ///      Attribute orthometricHeight of type double
        ///      Sequence [1, 1]
        ///          Choice [0, *]
        ///              Monument [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadGPSAntennaDetails( GPSAntennaDetails value );
        void EndReadGPSAntennaDetails();
        /// <summary>
        /// Element GPSReceiverDetails
        /// {
        ///     Attribute id of type ID
        ///      Attribute manufacturer of type string
        ///      Attribute model of type string
        ///      Attribute serialNumber of type string
        ///      Sequence [1, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadGPSReceiverDetails( GPSReceiverDetails value );
        void EndReadGPSReceiverDetails();
        /// <summary>
        /// Element Corrections
        /// {
        ///     Attribute refractionCoefficient of type double
        ///      Attribute applyRefractionCoefficient of type boolean
        ///      Attribute sphericity of type double
        ///      Attribute prismEccentricity of type double
        ///      Sequence [1, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCorrections( Corrections value );
        void EndReadCorrections();
        /// <summary>
        /// Element SurveyMonument
        /// {
        ///     Attribute mntRef of type monumentNameRef
        ///      Attribute purpose of type monumentPurpose
        ///      Attribute state of type monumentState
        ///      Attribute adoptedSurvey of type string
        ///      Attribute disturbedMonument of type string
        ///      Attribute disturbedDate of type date
        ///      Attribute disturbedAnnotation of type string
        ///      Attribute replacedMonument of type string
        ///      Attribute replacedDate of type date
        ///      Attribute replacedAnnotation of type string
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSurveyMonument( SurveyMonument value );
        void EndReadSurveyMonument();
        /// <summary>
        /// Element InstrumentSetup
        /// {
        ///     Attribute id of type ID
        ///      Attribute instrumentDetailsID of type IDREF
        ///      Attribute stationName of type string
        ///      Attribute instrumentHeight of type double
        ///      Attribute orientationAzimuth of type direction
        ///      Attribute circleAzimuth of type direction
        ///      Attribute status of type observationStatusType
        ///      Sequence [1, 1]
        ///          Choice [0, *]
        ///              InstrumentPoint [0, 1]
        ///              Backsight [0, *]
        ///              TargetSetup [0, *]
        ///              RawObservation [0, *]
        ///              ObservationGroup [0, *]
        ///              ControlChecks [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadInstrumentSetup( InstrumentSetup value );
        void EndReadInstrumentSetup();
        /// <summary>
        /// Element LaserSetup
        /// {
        ///     Attribute id of type ID
        ///      Attribute stationName
        ///      Attribute instrumentHeight of type double
        ///      Attribute laserDetailsID of type IDREF
        ///      Attribute magDeclination of type double
        ///      Choice [0, *]
        ///          InstrumentPoint [0, 1]
        ///          Backsight [0, 1]
        ///          TargetSetup [0, *]
        ///          RawObservation [1, 1]
        ///          FieldNote [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadLaserSetup( LaserSetup value );
        void EndReadLaserSetup();
        /// <summary>
        /// Element GPSSetup
        /// {
        ///     Attribute id of type ID
        ///      Attribute antennaHeight of type double
        ///      Attribute stationName
        ///      Attribute GPSAntennaDetailsID of type IDREF
        ///      Attribute GPSReceiverDetailsID of type IDREF
        ///      Attribute observationDataLink
        ///      Attribute stationDescription
        ///      Attribute startTime of type GPSTime
        ///      Attribute stopTime of type GPSTime
        ///      Sequence [1, 1]
        ///          Choice [0, *]
        ///              TargetSetup [0, *]
        ///              GPSPosition [1, 1]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadGPSSetup( GPSSetup value );
        void EndReadGPSSetup();
        /// <summary>
        /// Element TargetSetup
        /// {
        ///     Attribute id of type ID
        ///      Attribute targetHeight of type double
        ///      Attribute edmTargetVertOffset of type double
        ///      Attribute prismConstant of type double
        ///      Sequence [1, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadTargetSetup( TargetSetup value );
        void EndReadTargetSetup();
        /// <summary>
        /// Element Backsight
        /// {
        ///     Attribute id of type ID
        ///      Attribute azimuth of type direction
        ///      Attribute targetHeight of type double
        ///      Attribute circle of type angle
        ///      Attribute setupID of type IDREF
        ///      Sequence [1, 1]
        ///          BacksightPoint [0, 1]
        ///          Choice [1, 1]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadBacksight( Backsight value );
        void EndReadBacksight();
        /// <summary>
        /// Element RawObservation
        /// {
        ///     <unnamed> Restriction of RawObservationType
        /// }
        /// </summary>

        void BeginReadRawObservation( RawObservation value );
        void EndReadRawObservation();
        /// <summary>
        /// Element TestObservation
        /// {
        ///     <unnamed> Restriction of RawObservationType
        ///      Attribute setup1RodA of type double
        ///      Attribute setup1RodB of type double
        ///      Attribute setup2RodA of type double
        ///      Attribute setup2RodB of type double
        /// }
        /// </summary>

        void BeginReadTestObservation( TestObservation value );
        void EndReadTestObservation();
        /// <summary>
        /// Element TargetPoint of type PointType
        /// </summary>

        void BeginReadTargetPoint( PointType value );
        void EndReadTargetPoint();
        /// <summary>
        /// Element BacksightPoint of type PointType
        /// </summary>

        void BeginReadBacksightPoint( PointType value );
        void EndReadBacksightPoint();
        /// <summary>
        /// Element OffsetVals
        /// {
        ///     Attribute offsetInOut of type double
        ///      Attribute offsetLeftRight of type double
        ///      Attribute offsetUpDown of type double
        /// }
        /// </summary>

        void BeginReadOffsetVals( OffsetVals value );
        void EndReadOffsetVals();
        /// <summary>
        /// Element GPSVector
        /// {
        ///     Attribute dX of type double
        ///      Attribute dY of type double
        ///      Attribute dZ of type double
        ///      Attribute setupID_A of type IDREF
        ///      Attribute setupID_B of type IDREF
        ///      Attribute startTime of type dateTime
        ///      Attribute endTime of type dateTime
        ///      Attribute horizontalPrecision of type double
        ///      Attribute verticalPrecision of type double
        ///      Attribute purpose of type purposeType
        ///      Attribute setID
        ///      Attribute solutionDataLink
        ///      Attribute coordGeomRefs of type coordGeomNameRefs
        ///      Sequence [1, 1]
        ///          TargetPoint [1, 1]
        ///          GPSQCInfoLevel1 [0, 1]
        ///          GPSQCInfoLevel2 [0, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadGPSVector( GPSVector value );
        void EndReadGPSVector();
        /// <summary>
        /// Element GPSPosition
        /// {
        ///     Attribute setupID of type IDREF
        ///      Attribute setID
        ///      Attribute wgsHeight of type double
        ///      Attribute wgsLatitude of type double
        ///      Attribute wgsLongitude of type double
        ///      Attribute purpose
        ///      Attribute coordGeomRefs of type coordGeomNameRefs
        ///      Attribute pntRef of type pointNameRef
        ///      Sequence [1, 1]
        ///          TargetPoint [1, 1]
        ///          GPSQCInfoLevel1 [0, 1]
        ///          GPSQCInfoLevel2 [0, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadGPSPosition( GPSPosition value );
        void EndReadGPSPosition();
        /// <summary>
        /// Element GPSQCInfoLevel1
        /// {
        ///     Attribute GPSSolnType of type GPSSolutionTypeEnum
        ///      Attribute GPSSolnFreq of type GPSSolutionFrequencyEnum
        ///      Attribute nbrSatellites of type integer
        ///      Attribute RDOP of type double
        /// }
        /// </summary>

        void BeginReadGPSQCInfoLevel1( GPSQCInfoLevel1 value );
        void EndReadGPSQCInfoLevel1();
        /// <summary>
        /// Element GPSQCInfoLevel2
        /// {
        ///     Attribute covarianceXX of type double
        ///      Attribute covarianceXY of type double
        ///      Attribute covarianceXZ of type double
        ///      Attribute covarianceYY of type double
        ///      Attribute covarianceYZ of type double
        ///      Attribute covarianceZZ of type double
        ///      Attribute GPSSolnType of type GPSSolutionTypeEnum
        ///      Attribute GPSSolnFreq of type GPSSolutionFrequencyEnum
        ///      Attribute RMS of type double
        ///      Attribute ratio of type double
        ///      Attribute referenceVariance of type double
        ///      Attribute nbrSatellites of type integer
        ///      Attribute startTime of type GPSTime
        ///      Attribute stopTime of type GPSTime
        /// }
        /// </summary>

        void BeginReadGPSQCInfoLevel2( GPSQCInfoLevel2 value );
        void EndReadGPSQCInfoLevel2();
        /// <summary>
        /// Element ObservationGroup
        /// {
        ///     Attribute id of type ID
        ///      Attribute purpose of type purposeType
        ///      Attribute setupID of type IDREF
        ///      Attribute targetSetupID of type IDREF
        ///      Attribute setID
        ///      Attribute coordGeomRefs of type coordGeomNameRefs
        ///      Attribute alignRef of type alignmentNameRef
        ///      Attribute alignStationName of type string
        ///      Attribute alignOffset of type offsetDistance
        ///      Sequence [1, 1]
        ///          TargetPoint [0, 1]
        ///          Choice [0, *]
        ///              Backsight [1, 1]
        ///              RawObservation [1, *]
        ///              ReducedObservation [1, 1]
        ///              RedHorizontalPosition [0, 1]
        ///              ReducedArcObservation [0, 1]
        ///              RedVerticalObservation [0, 1]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadObservationGroup( ObservationGroup value );
        void EndReadObservationGroup();
        /// <summary>
        /// Element ControlChecks
        /// {
        ///     Sequence [1, 1]
        ///          Choice [0, *]
        ///              TestObservation [0, *]
        ///              ObservationGroup [0, *]
        ///              PointResults [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadControlChecks( ControlChecks value );
        void EndReadControlChecks();
        /// <summary>
        /// Element PointResults
        /// {
        ///     Attribute setupID of type IDREF
        ///      Attribute targetSetupID of type IDREF
        ///      Attribute meanHorizAngle of type double
        ///      Attribute horizStdDeviation of type double
        ///      Attribute meanzenithAngle of type zenithAngle
        ///      Attribute vertStdDeviation of type double
        ///      Attribute meanSlopeDistance of type double
        ///      Attribute slopeDistanceStdDeviation of type double
        ///      Sequence [1, 1]
        ///          TargetPoint [0, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPointResults( PointResults value );
        void EndReadPointResults();
        /// <summary>
        /// Element ReducedObservation
        /// {
        ///     Attribute purpose of type purposeType
        ///      Attribute setupID of type IDREF
        ///      Attribute targetSetupID of type IDREF
        ///      Attribute targetSetup2ID of type IDREF
        ///      Attribute setID
        ///      Attribute targetHeight of type double
        ///      Attribute azimuth of type direction
        ///      Attribute horizDistance of type double
        ///      Attribute vertDistance of type double
        ///      Attribute horizAngle of type angle
        ///      Attribute slopeDistance of type double
        ///      Attribute zenithAngle of type zenithAngle
        ///      Attribute equipmentUsed of type equipmentType
        ///      Attribute azimuthAccuracy of type double
        ///      Attribute distanceAccuracy of type double
        ///      Attribute angleAccuracy of type double
        ///      Attribute date of type date
        ///      Attribute distanceType of type observationType
        ///      Attribute azimuthType of type observationType
        ///      Attribute angleType of type observationType
        ///      Attribute adoptedAzimuthSurvey of type string
        ///      Attribute adoptedDistanceSurvey of type string
        ///      Attribute adoptedAngleSurvey of type string
        ///      Attribute distanceAccClass of type string
        ///      Attribute azimuthAccClass of type string
        ///      Attribute angleAccClass of type string
        ///      Attribute azimuthAdoptionFactor of type double
        ///      Attribute distanceAdoptionFactor of type double
        ///      Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Attribute oID of type string
        ///      Attribute MSLDistance of type string
        ///      Attribute spherDistance of type string
        ///      Attribute coordGeomRefs of type coordGeomNameRefs
        ///      Attribute alignRef of type alignmentNameRef
        ///      Attribute alignStationName of type string
        ///      Attribute alignOffset of type offsetDistance
        ///      Sequence [1, 1]
        ///          TargetPoint [0, 1]
        ///          OffsetVals [0, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadReducedObservation( ReducedObservation value );
        void EndReadReducedObservation();
        /// <summary>
        /// Element ReducedArcObservation
        /// {
        ///     Attribute purpose of type purposeType
        ///      Attribute setupID of type IDREF
        ///      Attribute targetSetupID of type IDREF
        ///      Attribute setID
        ///      Attribute chordAzimuth of type direction
        ///      Attribute radius of type double
        ///      Attribute length of type double
        ///      Attribute rot of type clockwise
        ///      Attribute equipmentUsed of type equipmentType
        ///      Attribute arcAzimuthAccuracy of type double
        ///      Attribute arcLengthAccuracy of type double
        ///      Attribute date of type date
        ///      Attribute arcType of type string
        ///      Attribute adoptedSurvey of type string
        ///      Attribute lengthAccClass of type string
        ///      Attribute azimuthAccClass of type string
        ///      Attribute azimuthAdoptionFactor of type double
        ///      Attribute lengthAdoptionFactor of type double
        ///      Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Attribute oID of type string
        ///      Attribute coordGeomRefs of type coordGeomNameRefs
        ///      Attribute alignRef of type alignmentNameRef
        ///      Attribute alignStationName of type string
        ///      Attribute alignOffset of type offsetDistance
        ///      Sequence [1, 1]
        ///          TargetPoint [0, 1]
        ///          OffsetVals [0, 1]
        ///          Choice [0, *]
        ///              FieldNote [0, *]
        ///              Feature [0, *]
        /// }
        /// </summary>

        void BeginReadReducedArcObservation( ReducedArcObservation value );
        void EndReadReducedArcObservation();
        /// <summary>
        /// Element RedHorizontalPosition
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type string
        ///      Attribute oID of type string
        ///      Attribute purpose of type purposeType
        ///      Attribute setupID of type IDREF
        ///      Attribute date of type date
        ///      Attribute equipmentUsed of type equipmentType
        ///      Attribute horizontalDatum of type string
        ///      Attribute horizontalAdjustment of type string
        ///      Attribute latitude of type string
        ///      Attribute longitude of type string
        ///      Attribute horizontalFix of type string
        ///      Attribute currencyDate of type string
        ///      Attribute localUncertainity of type double
        ///      Attribute class of type string
        ///      Attribute order of type string
        ///      Attribute positionalUncertainity of type double
        ///      Choice [0, *]
        ///          FieldNote [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadRedHorizontalPosition( RedHorizontalPosition value );
        void EndReadRedHorizontalPosition();
        /// <summary>
        /// Element RedVerticalObservation
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type string
        ///      Attribute oID of type string
        ///      Attribute purpose of type purposeType
        ///      Attribute setupID of type IDREF
        ///      Attribute date of type date
        ///      Attribute equipmentUsed of type equipmentType
        ///      Attribute height of type double
        ///      Attribute verticalAdjustment of type string
        ///      Attribute verticalFix of type string
        ///      Attribute geosphoid of type double
        ///      Attribute gsDatum of type string
        ///      Attribute gsModel of type string
        ///      Attribute gsMethod of type string
        ///      Attribute originMark of type string
        ///      Attribute verticalDatum of type string
        ///      Attribute localUncertainity of type double
        ///      Attribute class of type string
        ///      Attribute order of type string
        ///      Attribute positionalUncertainity of type double
        ///      Choice [0, *]
        ///          FieldNote [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadRedVerticalObservation( RedVerticalObservation value );
        void EndReadRedVerticalObservation();
        /// <summary>
        /// Element Monuments
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Monument [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadMonuments( Monuments value );
        void EndReadMonuments();
        /// <summary>
        /// Element Monument
        /// {
        ///     Attribute name of type string
        ///      Attribute pntRef of type pointNameRef
        ///      Attribute featureRef of type featureNameRef
        ///      Attribute desc of type string
        ///      Attribute state of type monumentState
        ///      Attribute type of type monumentType
        ///      Attribute condition of type monumentCondition
        ///      Attribute category of type monumentCategory
        ///      Attribute beacon of type beaconType
        ///      Attribute beaconProtection of type beaconProtectionType
        ///      Attribute oID of type string
        ///      Attribute reference of type string
        ///      Attribute originSurvey of type string
        /// }
        /// </summary>

        void BeginReadMonument( Monument value );
        void EndReadMonument();
        /// <summary>
        /// Element Surfaces
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Surface [1, *]
        ///          SurfVolumes [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSurfaces( Surfaces value );
        void EndReadSurfaces();
        /// <summary>
        /// Element Surface
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute OID of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Choice [1, 3]
        ///              SourceData [0, 1]
        ///              Definition [0, 1]
        ///              Watersheds [0, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSurface( Surface value );
        void EndReadSurface();
        /// <summary>
        /// Element SourceData
        /// {
        ///     Sequence [1, *]
        ///          Choice [1, 1]
        ///              Chain [0, *]
        ///              PointFiles [0, *]
        ///              Boundaries [0, *]
        ///              Breaklines [0, *]
        ///              Contours [0, *]
        ///              DataPoints [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSourceData( SourceData value );
        void EndReadSourceData();
        /// <summary>
        /// Element DataPoints
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute code of type string
        ///      Attribute state of type stateType
        ///      Attribute pntRef of type pointNameRef
        ///      Attribute pointGeometry of type pointGeometryType
        ///      Attribute DTMAttribute of type DTMAttributeType
        ///      Sequence [1, *]
        ///          PntList3D [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDataPoints( DataPoints value );
        void EndReadDataPoints();
        /// <summary>
        /// Element PointFiles
        /// {
        ///     Sequence [1, 1]
        ///          PointFile [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPointFiles( PointFiles value );
        void EndReadPointFiles();
        /// <summary>
        /// Element PointFile
        /// {
        ///     Attribute fileName
        ///      Attribute fileType
        ///      Attribute fileFormat
        /// }
        /// </summary>

        void BeginReadPointFile( PointFile value );
        void EndReadPointFile();
        /// <summary>
        /// Element Boundaries
        /// {
        ///     Sequence [1, 1]
        ///          Boundary [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadBoundaries( Boundaries value );
        void EndReadBoundaries();
        /// <summary>
        /// Element Boundary
        /// {
        ///     Attribute bndType of type surfBndType
        ///      Attribute edgeTrim of type boolean
        ///      Attribute area of type double
        ///      Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Choice [1, 1]
        ///              PntList2D [1, 1]
        ///              PntList3D [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadBoundary( Boundary value );
        void EndReadBoundary();
        /// <summary>
        /// Element Breaklines
        /// {
        ///     Sequence [1, 1]
        ///          Breakline [0, *]
        ///          RetWall [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadBreaklines( Breaklines value );
        void EndReadBreaklines();
        /// <summary>
        /// Element Breakline
        /// {
        ///     Attribute brkType of type breakLineType
        ///      Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Choice [1, 1]
        ///              PntList2D [1, 1]
        ///              PntList3D [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadBreakline( Breakline value );
        void EndReadBreakline();
        /// <summary>
        /// Element RetWall
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          RetWallPnt [2, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadRetWall( RetWall value );
        void EndReadRetWall();
        /// <summary>
        /// Element RetWallPnt
        /// {
        ///     <unnamed> Extension of PointType3dReq
        ///      Attribute height of type double
        ///      Attribute offset of type double
        /// }
        /// </summary>

        void BeginReadRetWallPnt( RetWallPnt value );
        void EndReadRetWallPnt();
        /// <summary>
        /// Element Contours
        /// {
        ///     Sequence [1, 1]
        ///          Contour [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadContours( Contours value );
        void EndReadContours();
        /// <summary>
        /// Element Contour
        /// {
        ///     Attribute elev of type double
        ///      Sequence [1, 1]
        ///          PntList2D [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadContour( Contour value );
        void EndReadContour();
        /// <summary>
        /// Element Definition
        /// {
        ///     Attribute surfType of type surfTypeEnum
        ///      Attribute area2DSurf of type double
        ///      Attribute area3DSurf of type double
        ///      Attribute elevMax of type double
        ///      Attribute elevMin of type double
        ///      Sequence [1, 1]
        ///          Pnts [1, 1]
        ///          Faces [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDefinition( Definition value );
        void EndReadDefinition();
        /// <summary>
        /// Element Pnts
        /// {
        ///     Sequence [1, 1]
        ///          P [3, *]
        /// }
        /// </summary>

        void BeginReadPnts( Pnts value );
        void EndReadPnts();
        /// <summary>
        /// Element P
        /// {
        ///     <unnamed> Extension of PointType
        ///      Attribute id of type positiveInteger
        /// }
        /// </summary>

        void BeginReadP( P value );
        void EndReadP();
        /// <summary>
        /// Element Faces
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          F [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadFaces( Faces value );
        void EndReadFaces();
        /// <summary>
        /// Element F
        /// {
        ///     <unnamed> Extension of FaceType
        ///      Attribute i of type integer
        ///      Attribute n of type FaceType
        ///      Attribute b of type positiveInteger
        /// }
        /// </summary>

        void BeginReadF( F value );
        void EndReadF();
        /// <summary>
        /// Element Watersheds
        /// {
        ///     Sequence [1, 1]
        ///          Watershed [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadWatersheds( Watersheds value );
        void EndReadWatersheds();
        /// <summary>
        /// Element Watershed
        /// {
        ///     Attribute name of type string
        ///      Attribute area of type double
        ///      Attribute desc of type string
        ///      Sequence [1, 1]
        ///          Choice [1, 1]
        ///              PntList2D [1, 1]
        ///              PntList3D [1, 1]
        ///          Outlet [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadWatershed( Watershed value );
        void EndReadWatershed();
        /// <summary>
        /// Element Outlet
        /// {
        ///     <unnamed> Extension of PointType3dReq
        ///      Attribute refWS of type waterShedNameRef
        /// }
        /// </summary>

        void BeginReadOutlet( Outlet value );
        void EndReadOutlet();
        /// <summary>
        /// Element SurfVolumes
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute surfVolCalcMethod of type surfVolCMethodType
        ///      Sequence [1, 1]
        ///          SurfVolume [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSurfVolumes( SurfVolumes value );
        void EndReadSurfVolumes();
        /// <summary>
        /// Element SurfVolume
        /// {
        ///     Attribute surfBase of type surfaceNameRef
        ///      Attribute surfCompare of type surfaceNameRef
        ///      Attribute volCut of type double
        ///      Attribute volFill of type double
        ///      Attribute volTotal of type double
        ///      Attribute desc of type string
        ///      Attribute name of type string
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSurfVolume( SurfVolume value );
        void EndReadSurfVolume();
        /// <summary>
        /// Element Parcels
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Parcel [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadParcels( Parcels value );
        void EndReadParcels();
        /// <summary>
        /// Element Parcel
        /// {
        ///     Attribute name of type string
        ///      Attribute oID of type string
        ///      Attribute area of type double
        ///      Attribute desc of type string
        ///      Attribute dirClosure of type direction
        ///      Attribute distClosure of type double
        ///      Attribute owner of type string
        ///      Attribute parcelType of type string
        ///      Attribute setbackFront of type double
        ///      Attribute setbackRear of type double
        ///      Attribute setbackSide of type double
        ///      Attribute state of type parcelStateType
        ///      Attribute taxId of type string
        ///      Attribute class of type parcelClass
        ///      Attribute useOfParcel of type useOfParcelType
        ///      Attribute parcelFormat of type parcelFormat
        ///      Attribute buildingNo of type string
        ///      Attribute buildingLevelNo of type string
        ///      Attribute volume of type string
        ///      Attribute pclRef of type parcelNameRef
        ///      Attribute lotEntitlements of type string
        ///      Attribute liabilityApportionment of type string
        ///      Sequence [1, 1]
        ///          Choice [1, *]
        ///              Center [0, 1]
        ///              CoordGeom [1, 1]
        ///              VolumeGeom [0, *]
        ///              Parcels [0, *]
        ///              Title [0, *]
        ///              Exclusions [0, *]
        ///              LocationAddress [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadParcel( Parcel value );
        void EndReadParcel();
        /// <summary>
        /// Element VolumeGeom
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Attribute oID of type string
        ///      Choice [4, *]
        ///          CoordGeom [1, 1]
        /// }
        /// </summary>

        void BeginReadVolumeGeom( VolumeGeom value );
        void EndReadVolumeGeom();
        /// <summary>
        /// Element Title
        /// {
        ///     Attribute name of type string
        ///      Attribute titleType
        /// }
        /// </summary>

        void BeginReadTitle( Title value );
        void EndReadTitle();
        /// <summary>
        /// Element Exclusions
        /// {
        ///     Attribute exclusionType of type exclusType
        ///      Attribute area of type double
        /// }
        /// </summary>

        void BeginReadExclusions( Exclusions value );
        void EndReadExclusions();
        /// <summary>
        /// Element LocationAddress
        /// {
        ///     Attribute addressType of type addressTypeType
        ///      Attribute flatType of type flatTypeType
        ///      Attribute flatNumber of type string
        ///      Attribute floorLevelType of type floorLevelTypeType
        ///      Attribute floorLevelNumber of type string
        ///      Attribute numberFirst of type int
        ///      Attribute numberSuffixFirst of type string
        ///      Attribute numberLast of type int
        ///      Attribute numberSuffixLast of type string
        ///      Sequence [1, 1]
        ///          ComplexName [0, *]
        ///          RoadName [0, *]
        ///          AdministrativeArea [0, *]
        ///          AddressPoint [0, *]
        /// }
        /// </summary>

        void BeginReadLocationAddress( LocationAddress value );
        void EndReadLocationAddress();
        /// <summary>
        /// Element ComplexName
        /// {
        ///     Attribute desc of type string
        ///      Attribute priority of type int
        /// }
        /// </summary>

        void BeginReadComplexName( ComplexName value );
        void EndReadComplexName();
        /// <summary>
        /// Element RoadName
        /// {
        ///     Attribute roadNameType of type roadNameTypeType
        ///      Attribute roadName of type string
        ///      Attribute roadNameSuffix of type roadNameSuffixType
        ///      Attribute roadType of type roadTypeType
        ///      Attribute pclRef of type parcelNameRefs
        /// }
        /// </summary>

        void BeginReadRoadName( RoadName value );
        void EndReadRoadName();
        /// <summary>
        /// Element AddressPoint
        /// {
        ///     <unnamed> Extension of PointType
        ///      Attribute addressPointType of type addressPointTypeType
        /// }
        /// </summary>

        void BeginReadAddressPoint( AddressPoint value );
        void EndReadAddressPoint();
        /// <summary>
        /// Element Alignments
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Alignment [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadAlignments( Alignments value );
        void EndReadAlignments();
        /// <summary>
        /// Element Alignment
        /// {
        ///     Attribute name of type string
        ///      Attribute length of type double
        ///      Attribute staStart of type double
        ///      Attribute desc of type string
        ///      Attribute oID of type string
        ///      Attribute state of type stateType
        ///      Choice [1, *]
        ///          Choice [1, 1]
        ///              Start [0, 1]
        ///              CoordGeom [1, 1]
        ///              AlignPIs [0, 1]
        ///              Cant [0, 1]
        ///          StaEquation [0, *]
        ///          Profile [0, *]
        ///          CrossSects [0, 1]
        ///          Superelevation [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadAlignment( Alignment value );
        void EndReadAlignment();
        /// <summary>
        /// Element StaEquation
        /// {
        ///     Attribute staAhead of type double
        ///      Attribute staBack of type double
        ///      Attribute staInternal of type double
        ///      Attribute staIncrement of type stationIncrementDirectionType
        ///      Attribute desc of type string
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadStaEquation( StaEquation value );
        void EndReadStaEquation();
        /// <summary>
        /// Element Profile
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute staStart of type double
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Choice [1, *]
        ///              ProfSurf [0, *]
        ///              ProfAlign [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadProfile( Profile value );
        void EndReadProfile();
        /// <summary>
        /// Element ProfSurf
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          PntList2D [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadProfSurf( ProfSurf value );
        void EndReadProfSurf();
        /// <summary>
        /// Element ProfAlign
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Choice [1, *]
        ///              PVI [0, *]
        ///              ParaCurve [0, *]
        ///              UnsymParaCurve [0, *]
        ///              CircCurve [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadProfAlign( ProfAlign value );
        void EndReadProfAlign();
        /// <summary>
        /// Element PVI
        /// {
        ///     <unnamed> Extension of Point2dReq
        ///      Attribute desc of type string
        /// }
        /// </summary>

        void BeginReadPVI( PVI value );
        void EndReadPVI();
        /// <summary>
        /// Element ParaCurve
        /// {
        ///     <unnamed> Extension of Point2dReq
        ///      Attribute length of type double
        ///      Attribute desc of type string
        /// }
        /// </summary>

        void BeginReadParaCurve( ParaCurve value );
        void EndReadParaCurve();
        /// <summary>
        /// Element UnsymParaCurve
        /// {
        ///     <unnamed> Extension of Point2dReq
        ///      Attribute lengthIn of type double
        ///      Attribute lengthOut of type double
        ///      Attribute desc of type string
        /// }
        /// </summary>

        void BeginReadUnsymParaCurve( UnsymParaCurve value );
        void EndReadUnsymParaCurve();
        /// <summary>
        /// Element CircCurve
        /// {
        ///     <unnamed> Extension of Point
        ///      Attribute length of type double
        ///      Attribute radius of type double
        ///      Attribute desc of type string
        /// }
        /// </summary>

        void BeginReadCircCurve( CircCurve value );
        void EndReadCircCurve();
        /// <summary>
        /// Element PipeNetworks
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          PipeNetwork [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPipeNetworks( PipeNetworks value );
        void EndReadPipeNetworks();
        /// <summary>
        /// Element PipeNetwork
        /// {
        ///     Attribute name of type string
        ///      Attribute pipeNetType of type pipeNetworkType
        ///      Attribute alignmentRef of type alignmentNameRef
        ///      Attribute desc of type string
        ///      Attribute oID of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Structs [1, 1]
        ///          Pipes [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPipeNetwork( PipeNetwork value );
        void EndReadPipeNetwork();
        /// <summary>
        /// Element Pipes
        /// {
        ///     Sequence [1, 1]
        ///          Units [0, 1]
        ///          Pipe [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPipes( Pipes value );
        void EndReadPipes();
        /// <summary>
        /// Element Pipe
        /// {
        ///     Attribute name of type string
        ///      Attribute refEnd of type structNameRef
        ///      Attribute refStart of type structNameRef
        ///      Attribute desc of type string
        ///      Attribute length of type double
        ///      Attribute oID of type string
        ///      Attribute slope of type double
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Choice [1, 1]
        ///              CircPipe [1, 1]
        ///              EggPipe [1, 1]
        ///              ElliPipe [1, 1]
        ///              RectPipe [1, 1]
        ///              Channel [1, 1]
        ///          PipeFlow [0, 1]
        ///          Center [0, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPipe( Pipe value );
        void EndReadPipe();
        /// <summary>
        /// Element CircPipe
        /// {
        ///     Attribute diameter of type double
        ///      Attribute desc of type string
        ///      Attribute hazenWilliams of type double
        ///      Attribute mannings of type double
        ///      Attribute material
        ///      Attribute thickness of type double
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCircPipe( CircPipe value );
        void EndReadCircPipe();
        /// <summary>
        /// Element ElliPipe
        /// {
        ///     Attribute height of type double
        ///      Attribute span of type double
        ///      Attribute desc of type string
        ///      Attribute hazenWilliams of type double
        ///      Attribute mannings of type double
        ///      Attribute material
        ///      Attribute thickness of type double
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadElliPipe( ElliPipe value );
        void EndReadElliPipe();
        /// <summary>
        /// Element EggPipe
        /// {
        ///     Attribute height of type double
        ///      Attribute span of type double
        ///      Attribute desc of type string
        ///      Attribute hazenWilliams of type double
        ///      Attribute mannings of type double
        ///      Attribute material
        ///      Attribute thickness of type double
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadEggPipe( EggPipe value );
        void EndReadEggPipe();
        /// <summary>
        /// Element RectPipe
        /// {
        ///     Attribute height of type double
        ///      Attribute width of type double
        ///      Attribute desc of type string
        ///      Attribute hazenWilliams of type double
        ///      Attribute mannings of type double
        ///      Attribute material
        ///      Attribute thickness of type double
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadRectPipe( RectPipe value );
        void EndReadRectPipe();
        /// <summary>
        /// Element Channel
        /// {
        ///     Attribute height of type double
        ///      Attribute widthTop of type double
        ///      Attribute widthBottom of type double
        ///      Attribute desc of type string
        ///      Attribute hazenWilliams of type double
        ///      Attribute mannings of type double
        ///      Attribute material
        ///      Attribute thickness of type double
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadChannel( Channel value );
        void EndReadChannel();
        /// <summary>
        /// Element PipeFlow
        /// {
        ///     Attribute flowIn of type double
        ///      Attribute areaCatchment of type double
        ///      Attribute desc of type string
        ///      Attribute depthCritical of type double
        ///      Attribute hglDown of type double
        ///      Attribute hglUp of type double
        ///      Attribute intensity of type double
        ///      Attribute runoffCoeff of type double
        ///      Attribute slopeCritical of type double
        ///      Attribute timeInlet of type double
        ///      Attribute velocityCritical of type double
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPipeFlow( PipeFlow value );
        void EndReadPipeFlow();
        /// <summary>
        /// Element Structs
        /// {
        ///     Sequence [1, 1]
        ///          Units [0, 1]
        ///          Struct [2, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadStructs( Structs value );
        void EndReadStructs();
        /// <summary>
        /// Element Struct
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute elevRim of type double
        ///      Attribute elevSump of type double
        ///      Attribute oID of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          Center [1, 1]
        ///          Choice [1, 1]
        ///              CircStruct [1, 1]
        ///              RectStruct [1, 1]
        ///              InletStruct [1, 1]
        ///              OutletStruct [1, 1]
        ///              Connection [1, 1]
        ///          Invert [1, *]
        ///          StructFlow [0, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadStruct( Struct value );
        void EndReadStruct();
        /// <summary>
        /// Element CircStruct
        /// {
        ///     Attribute diameter of type double
        ///      Attribute desc of type string
        ///      Attribute inletCase
        ///      Attribute lossCoeff of type double
        ///      Attribute material
        ///      Attribute thickness of type double
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCircStruct( CircStruct value );
        void EndReadCircStruct();
        /// <summary>
        /// Element RectStruct
        /// {
        ///     Attribute length of type double
        ///      Attribute lengthDir of type direction
        ///      Attribute width of type double
        ///      Attribute desc of type string
        ///      Attribute inletCase
        ///      Attribute lossCoeff of type double
        ///      Attribute material
        ///      Attribute thickness of type double
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadRectStruct( RectStruct value );
        void EndReadRectStruct();
        /// <summary>
        /// Element InletStruct
        /// {
        ///     Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadInletStruct( InletStruct value );
        void EndReadInletStruct();
        /// <summary>
        /// Element OutletStruct
        /// {
        ///     Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadOutletStruct( OutletStruct value );
        void EndReadOutletStruct();
        /// <summary>
        /// Element Connection
        /// {
        ///     Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadConnection( Connection value );
        void EndReadConnection();
        /// <summary>
        /// Element Invert
        /// {
        ///     Attribute desc of type string
        ///      Attribute elev of type double
        ///      Attribute flowDir of type inOut
        ///      Attribute refPipe of type pipeNameRef
        /// }
        /// </summary>

        void BeginReadInvert( Invert value );
        void EndReadInvert();
        /// <summary>
        /// Element StructFlow
        /// {
        ///     Attribute lossIn of type double
        ///      Attribute lossOut of type double
        ///      Attribute desc of type string
        ///      Attribute hglIn of type double
        ///      Attribute hglOut of type double
        ///      Attribute localDepression of type double
        ///      Attribute slopeSurf of type double
        ///      Attribute slopeGutter of type double
        ///      Attribute widthGutter of type double
        ///      Sequence [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadStructFlow( StructFlow value );
        void EndReadStructFlow();
        /// <summary>
        /// Element PlanFeatures
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Sequence [1, 1]
        ///          PlanFeature [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPlanFeatures( PlanFeatures value );
        void EndReadPlanFeatures();
        /// <summary>
        /// Element PlanFeature
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Choice [0, *]
        ///          CoordGeom [1, 1]
        ///          Location [0, *]
        ///          FieldNote [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPlanFeature( PlanFeature value );
        void EndReadPlanFeature();
        /// <summary>
        /// Element GradeModel
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Choice [1, *]
        ///          GradeSurface [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadGradeModel( GradeModel value );
        void EndReadGradeModel();
        /// <summary>
        /// Element GradeSurface
        /// {
        ///     Attribute alignmentRef of type alignmentNameRef
        ///      Attribute stationAlignmentRef of type alignmentNameRef
        ///      Attribute surfaceType of type zoneSurfaceType
        ///      Attribute surfaceRef of type surfaceNameRef
        ///      Attribute surfaceRefs of type surfaceNameRefs
        ///      Attribute cgPointRefs of type pointNameRefs
        ///      Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Choice [1, *]
        ///          Start [0, 1]
        ///          Zones [1, 2]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadGradeSurface( GradeSurface value );
        void EndReadGradeSurface();
        /// <summary>
        /// Element Zones
        /// {
        ///     Attribute side of type sideofRoadType
        ///      Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Choice [1, *]
        ///          Zone [1, *]
        ///          ZoneHinge [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadZones( Zones value );
        void EndReadZones();
        /// <summary>
        /// Element Zone
        /// {
        ///     Attribute desc of type string
        ///      Attribute name of type string
        ///      Attribute state of type stateType
        ///      Attribute priority of type int
        ///      Attribute category of type zoneCategoryType
        ///      Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute startWidth of type double
        ///      Attribute startVertValue of type double
        ///      Attribute startVertType of type zoneVertType
        ///      Attribute endWidth of type double
        ///      Attribute endVertValue of type double
        ///      Attribute endVertType of type zoneVertType
        ///      Choice [0, *]
        ///          ZoneWidth [0, *]
        ///          ZoneSlope [0, *]
        ///          ZoneCutFill [0, *]
        ///          ZoneMaterial [0, *]
        ///          ZoneCrossSectStructure [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadZone( Zone value );
        void EndReadZone();
        /// <summary>
        /// Element ZoneWidth
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute startWidth of type double
        ///      Attribute endWidth of type double
        ///      Choice [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadZoneWidth( ZoneWidth value );
        void EndReadZoneWidth();
        /// <summary>
        /// Element ZoneSlope
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute startVertValue of type double
        ///      Attribute startVertType of type zoneVertType
        ///      Attribute endVertValue of type double
        ///      Attribute endVertType of type zoneVertType
        ///      Attribute parabolicStartStation of type station
        ///      Attribute parabolicEndStation of type station
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadZoneSlope( ZoneSlope value );
        void EndReadZoneSlope();
        /// <summary>
        /// Element ZoneHinge
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute hingeType of type zoneHingeType
        ///      Attribute zonePriorityRef of type int
        ///      Choice [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadZoneHinge( ZoneHinge value );
        void EndReadZoneHinge();
        /// <summary>
        /// Element ZoneCutFill
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute cutSlope of type crossSlope
        ///      Attribute fillSlope of type crossSlope
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadZoneCutFill( ZoneCutFill value );
        void EndReadZoneCutFill();
        /// <summary>
        /// Element ZoneMaterial
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute material of type zoneMaterialType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadZoneMaterial( ZoneMaterial value );
        void EndReadZoneMaterial();
        /// <summary>
        /// Element ZoneCrossSectStructure
        /// {
        ///     Attribute name of type string
        ///      Attribute innerConnectPnt of type crossSectionPnt
        ///      Attribute outerConnectPnt of type crossSectionPnt
        ///      Attribute offsetMode of type zoneOffsetType
        ///      Attribute startOffset of type offsetDistance
        ///      Attribute startOffsetElev of type offsetElevation
        ///      Attribute endOffset of type offsetDistance
        ///      Attribute endOffsetElev of type offsetElevation
        ///      Attribute transition of type zoneTransitionType
        ///      Attribute placement of type zonePlacementType
        ///      Attribute catalogReference of type anyURI
        ///      Sequence [1, 1]
        ///          PntList2D [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadZoneCrossSectStructure( ZoneCrossSectStructure value );
        void EndReadZoneCrossSectStructure();
        /// <summary>
        /// Element Roadways
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Choice [1, 1]
        ///          Roadway [1, *]
        ///          Intersections [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadRoadways( Roadways value );
        void EndReadRoadways();
        /// <summary>
        /// Element Roadway
        /// {
        ///     Attribute name of type string
        ///      Attribute alignmentRefs of type alignmentNameRefs
        ///      Attribute surfaceRefs of type surfaceNameRefs
        ///      Attribute gradeModelRefs of type gradeModelNameRefs
        ///      Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute desc of type string
        ///      Attribute roadTerrain of type roadTerrainType
        ///      Attribute state of type stateType
        ///      Choice [0, *]
        ///          Classification [0, *]
        ///          Lanes [0, *]
        ///          Roadside [0, *]
        ///          Speeds [0, *]
        ///          NoPassingZone [0, *]
        ///          TrafficVolume [0, *]
        ///          CrashData [0, *]
        ///          DecisionSightDistance [0, *]
        ///          BridgeElement [0, *]
        ///          PlanFeature [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadRoadway( Roadway value );
        void EndReadRoadway();
        /// <summary>
        /// Element Classification
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute functionalClass of type functionalClassType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadClassification( Classification value );
        void EndReadClassification();
        /// <summary>
        /// Element DesignSpeed
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute speed of type speed
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDesignSpeed( DesignSpeed value );
        void EndReadDesignSpeed();
        /// <summary>
        /// Element DesignSpeed85th
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Attribute speed of type speed
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDesignSpeed85th( DesignSpeed85th value );
        void EndReadDesignSpeed85th();
        /// <summary>
        /// Element Speeds
        /// {
        ///     Choice [0, *]
        ///          DesignSpeed [1, *]
        ///          DesignSpeed85th [1, *]
        ///          PostedSpeed [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSpeeds( Speeds value );
        void EndReadSpeeds();
        /// <summary>
        /// Element DailyTrafficVolume
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute ADT of type double
        ///      Attribute year of type date
        ///      Attribute escFactor of type double
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDailyTrafficVolume( DailyTrafficVolume value );
        void EndReadDailyTrafficVolume();
        /// <summary>
        /// Element DesignHour
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute volume of type double
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDesignHour( DesignHour value );
        void EndReadDesignHour();
        /// <summary>
        /// Element PeakHour
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Attribute volume of type double
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPeakHour( PeakHour value );
        void EndReadPeakHour();
        /// <summary>
        /// Element TrafficVolume
        /// {
        ///     Choice [1, *]
        ///          DailyTrafficVolume [1, 1]
        ///          DesignHour [1, 1]
        ///          PeakHour [1, 1]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadTrafficVolume( TrafficVolume value );
        void EndReadTrafficVolume();
        /// <summary>
        /// Element Superelevation
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Choice [1, *]
        ///          BeginRunoutSta [0, *]
        ///          BeginRunoffSta [0, *]
        ///          FullSuperSta [0, *]
        ///          FullSuperelev [1, *]
        ///          RunoffSta [0, *]
        ///          StartofRunoutSta [0, *]
        ///          EndofRunoutSta [0, *]
        ///          AdverseSE [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadSuperelevation( Superelevation value );
        void EndReadSuperelevation();
        /// <summary>
        /// Element Lanes
        /// {
        ///     Choice [0, *]
        ///          ThruLane [0, *]
        ///          PassingLane [0, *]
        ///          TurnLane [0, *]
        ///          TwoWayLeftTurnLane [0, *]
        ///          ClimbLane [0, *]
        ///          OffsetLane [0, *]
        ///          WideningLane [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadLanes( Lanes value );
        void EndReadLanes();
        /// <summary>
        /// Element ThruLane
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute width of type double
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadThruLane( ThruLane value );
        void EndReadThruLane();
        /// <summary>
        /// Element PassingLane
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute beginFullWidthSta of type station
        ///      Attribute endFullWidthSta of type station
        ///      Attribute width of type double
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPassingLane( PassingLane value );
        void EndReadPassingLane();
        /// <summary>
        /// Element TurnLane
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute beginFullWidthSta of type station
        ///      Attribute width of type double
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Attribute type of type turnLaneType
        ///      Attribute taperType of type laneTaperType
        ///      Attribute taperTangentLength of type double
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadTurnLane( TurnLane value );
        void EndReadTurnLane();
        /// <summary>
        /// Element TwoWayLeftTurnLane
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute beginFullWidthSta of type station
        ///      Attribute endFullWidthSta of type station
        ///      Attribute startOffset of type offsetDistance
        ///      Attribute endOffset of type offsetDistance
        ///      Attribute width of type double
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadTwoWayLeftTurnLane( TwoWayLeftTurnLane value );
        void EndReadTwoWayLeftTurnLane();
        /// <summary>
        /// Element ClimbLane
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute beginFullWidthSta of type station
        ///      Attribute endFullWidthSta of type station
        ///      Attribute width of type double
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadClimbLane( ClimbLane value );
        void EndReadClimbLane();
        /// <summary>
        /// Element OffsetLane
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute beginFullWidthSta of type station
        ///      Attribute endFullWidthSta of type station
        ///      Attribute fullOffset of type offsetDistance
        ///      Attribute width of type double
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadOffsetLane( OffsetLane value );
        void EndReadOffsetLane();
        /// <summary>
        /// Element WideningLane
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute beginFullWidthSta of type station
        ///      Attribute endFullWidthSta of type station
        ///      Attribute offset of type offsetDistance
        ///      Attribute widening of type double
        ///      Attribute width of type double
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadWideningLane( WideningLane value );
        void EndReadWideningLane();
        /// <summary>
        /// Element Roadside
        /// {
        ///     Choice [0, *]
        ///          ObstructionOffset [0, *]
        ///          BikeFacilities [0, *]
        ///          RoadSign [0, *]
        ///          DrivewayDensity [0, *]
        ///          HazardRating [0, *]
        ///          Ditch [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadRoadside( Roadside value );
        void EndReadRoadside();
        /// <summary>
        /// Element Ditch
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute bottomWidth of type double
        ///      Attribute bottomShape of type ditchBottomShape
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDitch( Ditch value );
        void EndReadDitch();
        /// <summary>
        /// Element ObstructionOffset
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute offset of type offsetDistance
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadObstructionOffset( ObstructionOffset value );
        void EndReadObstructionOffset();
        /// <summary>
        /// Element BikeFacilities
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute width of type double
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadBikeFacilities( BikeFacilities value );
        void EndReadBikeFacilities();
        /// <summary>
        /// Element RoadSign
        /// {
        ///     Attribute MUTCDCode of type string
        ///      Attribute station of type station
        ///      Attribute offset of type offsetDistance
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Attribute type of type roadSignType
        ///      Attribute mountHeight of type double
        ///      Attribute width of type double
        ///      Attribute height of type double
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadRoadSign( RoadSign value );
        void EndReadRoadSign();
        /// <summary>
        /// Element DrivewayDensity
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute density of type int
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDrivewayDensity( DrivewayDensity value );
        void EndReadDrivewayDensity();
        /// <summary>
        /// Element HazardRating
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute rating of type int
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadHazardRating( HazardRating value );
        void EndReadHazardRating();
        /// <summary>
        /// Element Intersections
        /// {
        ///     Choice [1, *]
        ///          Intersection [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadIntersections( Intersections value );
        void EndReadIntersections();
        /// <summary>
        /// Element Intersection
        /// {
        ///     Attribute roadwayRef of type roadwayNameRef
        ///      Attribute roadwayPI of type station
        ///      Attribute intersectingRoadwayRef of type roadwayNameRef
        ///      Attribute intersectRoadwayPI of type station
        ///      Attribute contructionType of type intersectionConstructionType
        ///      Choice [0, *]
        ///          TrafficControl [0, *]
        ///          Timing [0, *]
        ///          Volume [0, *]
        ///          TurnSpeed [0, *]
        ///          TurnRestriction [0, *]
        ///          Curb [0, *]
        ///          Corner [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadIntersection( Intersection value );
        void EndReadIntersection();
        /// <summary>
        /// Element TrafficControl
        /// {
        ///     Attribute station of type station
        ///      Attribute signalPeriod of type double
        ///      Attribute controlPosition of type trafficControlPosition
        ///      Attribute controlType of type trafficControlType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadTrafficControl( TrafficControl value );
        void EndReadTrafficControl();
        /// <summary>
        /// Element Timing
        /// {
        ///     Attribute station of type station
        ///      Attribute legNumber of type int
        ///      Attribute protectedTurnPercent of type double
        ///      Attribute unprotectedTurnPercent of type double
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadTiming( Timing value );
        void EndReadTiming();
        /// <summary>
        /// Element Volume
        /// {
        ///     Attribute station of type station
        ///      Attribute legNumber of type int
        ///      Attribute turnPercent of type double
        ///      Attribute percentTrucks of type double
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadVolume( Volume value );
        void EndReadVolume();
        /// <summary>
        /// Element TurnSpeed
        /// {
        ///     Attribute station of type station
        ///      Attribute legNumber of type int
        ///      Attribute speed of type double
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadTurnSpeed( TurnSpeed value );
        void EndReadTurnSpeed();
        /// <summary>
        /// Element TurnRestriction
        /// {
        ///     Attribute station of type station
        ///      Attribute legNumber of type int
        ///      Attribute type of type trafficTurnRestriction
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadTurnRestriction( TurnRestriction value );
        void EndReadTurnRestriction();
        /// <summary>
        /// Element Curb
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Attribute type of type curbType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCurb( Curb value );
        void EndReadCurb();
        /// <summary>
        /// Element Corner
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute type of type cornerType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCorner( Corner value );
        void EndReadCorner();
        /// <summary>
        /// Element CrashData
        /// {
        ///     Choice [1, *]
        ///          CrashHistory [1, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCrashData( CrashData value );
        void EndReadCrashData();
        /// <summary>
        /// Element CrashHistory
        /// {
        ///     Attribute year of type date
        ///      Attribute location-1 of type station
        ///      Attribute location-2 of type station
        ///      Attribute severity of type crashSeverityType
        ///      Attribute intersectionRelation of type crashIntersectionRelation
        ///      Attribute intersectionLocation of type station
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCrashHistory( CrashHistory value );
        void EndReadCrashHistory();
        /// <summary>
        /// Element PostedSpeed
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Attribute speedLimit of type speed
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadPostedSpeed( PostedSpeed value );
        void EndReadPostedSpeed();
        /// <summary>
        /// Element NoPassingZone
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute sideofRoad of type sideofRoadType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadNoPassingZone( NoPassingZone value );
        void EndReadNoPassingZone();
        /// <summary>
        /// Element DecisionSightDistance
        /// {
        ///     Attribute station of type station
        ///      Attribute maneuver of type maneuverType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadDecisionSightDistance( DecisionSightDistance value );
        void EndReadDecisionSightDistance();
        /// <summary>
        /// Element BridgeElement
        /// {
        ///     Attribute staStart of type station
        ///      Attribute staEnd of type station
        ///      Attribute width of type double
        ///      Attribute projectType of type bridgeProjectType
        ///      Choice [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadBridgeElement( BridgeElement value );
        void EndReadBridgeElement();
        /// <summary>
        /// Element InSpiral
        /// {
        ///     All [1, 1]
        ///          Spiral [1, 1]
        /// }
        /// </summary>

        void BeginReadInSpiral( InSpiral value );
        void EndReadInSpiral();
        /// <summary>
        /// Element Curve1
        /// {
        ///     All [1, 1]
        ///          Curve [1, 1]
        /// }
        /// </summary>

        void BeginReadCurve1( Curve1 value );
        void EndReadCurve1();
        /// <summary>
        /// Element ConnSpiral
        /// {
        ///     All [1, 1]
        ///          Spiral [1, 1]
        /// }
        /// </summary>

        void BeginReadConnSpiral( ConnSpiral value );
        void EndReadConnSpiral();
        /// <summary>
        /// Element Curve2
        /// {
        ///     All [1, 1]
        ///          Curve [1, 1]
        /// }
        /// </summary>

        void BeginReadCurve2( Curve2 value );
        void EndReadCurve2();
        /// <summary>
        /// Element OutSpiral
        /// {
        ///     All [1, 1]
        ///          Spiral [1, 1]
        /// }
        /// </summary>

        void BeginReadOutSpiral( OutSpiral value );
        void EndReadOutSpiral();
        /// <summary>
        /// Element AlignPI
        /// {
        ///     Choice [1, *]
        ///          Station [1, 1]
        ///          PI [1, 1]
        ///          InSpiral [0, 1]
        ///          Curve1 [0, 1]
        ///          ConnSpiral [0, 1]
        ///          Curve2 [0, 1]
        ///          OutSpiral [0, 1]
        /// }
        /// </summary>

        void BeginReadAlignPI( AlignPI value );
        void EndReadAlignPI();
        /// <summary>
        /// Element AlignPIs
        /// {
        ///     Sequence [2, *]
        ///          AlignPI [1, 1]
        /// }
        /// </summary>

        void BeginReadAlignPIs( AlignPIs value );
        void EndReadAlignPIs();
        /// <summary>
        /// Element Cant
        /// {
        ///     Attribute name of type string
        ///      Attribute desc of type string
        ///      Attribute state of type stateType
        ///      Attribute equilibriumConstant of type double
        ///      Attribute appliedCantConstant of type double
        ///      Attribute gauge of type double
        ///      Attribute rotationPoint of type string
        ///      Sequence [1, 1]
        ///          Choice [1, *]
        ///              CantStation [0, *]
        ///              SpeedStation [0, *]
        ///          Feature [0, *]
        /// }
        /// </summary>

        void BeginReadCant( Cant value );
        void EndReadCant();
        /// <summary>
        /// Element CantStation
        /// {
        ///     Attribute station of type double
        ///      Attribute equilibriumCant of type double
        ///      Attribute appliedCant of type double
        ///      Attribute cantDeficiency of type double
        ///      Attribute cantExcess of type double
        ///      Attribute rateOfChangeOfAppliedCantOverTime of type double
        ///      Attribute rateOfChangeOfAppliedCantOverLength of type double
        ///      Attribute rateOfChangeOfCantDeficiencyOverTime of type double
        ///      Attribute cantGradient of type double
        ///      Attribute speed of type double
        ///      Attribute transitionType of type spiralType
        ///      Attribute curvature of type clockwise
        ///      Attribute adverse of type boolean
        /// }
        /// </summary>

        void BeginReadCantStation( CantStation value );
        void EndReadCantStation();
        /// <summary>
        /// Element SpeedStation
        /// {
        ///     Attribute station of type double
        ///      Attribute speed of type double
        /// }
        /// </summary>

        void BeginReadSpeedStation( SpeedStation value );
        void EndReadSpeedStation();

    }
}
#endif

