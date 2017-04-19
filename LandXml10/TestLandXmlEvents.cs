#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml10
{

    /// <summary>
    /// Event test class.
    /// </summary>
    public class TestLandXmlEvents : ILandXmlEvents
    {
        public bool AsXml { get; set; }

        // DebugWrite
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

        private static string ToAttributes(object obj)
        {
            if (obj is XsdBaseObject)
            {
                return ((XsdBaseObject)obj).ToAttributes();
            }
            return "";
        }

        public virtual void BeginReadPntList2D( IList<double> value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PntList2D {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PntList2D");
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
                buff.WriteLine("EndRead PntList2D");
            }
        }
        public virtual void BeginReadPntList3D( IList<double> value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PntList3D {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PntList3D");
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
                buff.WriteLine("EndRead PntList3D");
            }
        }
        public virtual void BeginReadF( IList<int> value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<F {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead F");
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
                buff.WriteLine("EndRead F");
            }
        }
        public virtual void BeginReadBeginRunoutSta( double value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<BeginRunoutSta {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead BeginRunoutSta");
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
                buff.WriteLine("EndRead BeginRunoutSta");
            }
        }
        public virtual void BeginReadBeginRunoffSta( double value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<BeginRunoffSta {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead BeginRunoffSta");
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
                buff.WriteLine("EndRead BeginRunoffSta");
            }
        }
        public virtual void BeginReadFullSuperSta( double value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<FullSuperSta {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead FullSuperSta");
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
                buff.WriteLine("EndRead FullSuperSta");
            }
        }
        public virtual void BeginReadFullSuperelev( double value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<FullSuperelev {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead FullSuperelev");
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
                buff.WriteLine("EndRead FullSuperelev");
            }
        }
        public virtual void BeginReadRunoffSta( double value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<RunoffSta {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead RunoffSta");
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
                buff.WriteLine("EndRead RunoffSta");
            }
        }
        public virtual void BeginReadStartofRunoutSta( double value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<StartofRunoutSta {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead StartofRunoutSta");
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
                buff.WriteLine("EndRead StartofRunoutSta");
            }
        }
        public virtual void BeginReadEndofRunoutSta( double value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<EndofRunoutSta {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead EndofRunoutSta");
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
                buff.WriteLine("EndRead EndofRunoutSta");
            }
        }
        public virtual void BeginReadAdverseSE( AdverseSEType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<AdverseSE {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead AdverseSE");
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
                buff.WriteLine("EndRead AdverseSE");
            }
        }
        public virtual void BeginReadLandXML( LandXML value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<LandXML {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead LandXML");
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
                buff.WriteLine("EndRead LandXML");
            }
        }
        public virtual void BeginReadCgPoints( CgPoints value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CgPoints {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CgPoints");
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
                buff.WriteLine("EndRead CgPoints");
            }
        }
        public virtual void BeginReadCgPoint( CgPoint value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CgPoint {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CgPoint");
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
                buff.WriteLine("EndRead CgPoint");
            }
        }
        public virtual void BeginReadDocFileRef( DocFileRef value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<DocFileRef {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead DocFileRef");
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
                buff.WriteLine("EndRead DocFileRef");
            }
        }
        public virtual void BeginReadFeature( Feature value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Feature {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Feature");
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
                buff.WriteLine("EndRead Feature");
            }
        }
        public virtual void BeginReadProperty( Property value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Property {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Property");
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
                buff.WriteLine("EndRead Property");
            }
        }
        public virtual void BeginReadStart( PointType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Start {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Start");
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
                buff.WriteLine("EndRead Start");
            }
        }
        public virtual void BeginReadEnd( PointType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<End {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead End");
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
                buff.WriteLine("EndRead End");
            }
        }
        public virtual void BeginReadCenter( PointType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Center {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Center");
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
                buff.WriteLine("EndRead Center");
            }
        }
        public virtual void BeginReadPI( PointType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PI {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PI");
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
                buff.WriteLine("EndRead PI");
            }
        }
        public virtual void BeginReadMapPoint( PointType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<MapPoint {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead MapPoint");
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
                buff.WriteLine("EndRead MapPoint");
            }
        }
        public virtual void BeginReadInstrumentPoint( PointType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<InstrumentPoint {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead InstrumentPoint");
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
                buff.WriteLine("EndRead InstrumentPoint");
            }
        }
        public virtual void BeginReadLocation( PointType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Location {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Location");
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
                buff.WriteLine("EndRead Location");
            }
        }
        public virtual void BeginReadIrregularLine( IrregularLine value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<IrregularLine {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead IrregularLine");
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
                buff.WriteLine("EndRead IrregularLine");
            }
        }
        public virtual void BeginReadChain( Chain value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Chain {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Chain");
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
                buff.WriteLine("EndRead Chain");
            }
        }
        public virtual void BeginReadCurve( Curve value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Curve {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Curve");
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
                buff.WriteLine("EndRead Curve");
            }
        }
        public virtual void BeginReadSpiral( Spiral value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Spiral {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Spiral");
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
                buff.WriteLine("EndRead Spiral");
            }
        }
        public virtual void BeginReadCoordGeom( CoordGeom value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CoordGeom {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CoordGeom");
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
                buff.WriteLine("EndRead CoordGeom");
            }
        }
        public virtual void BeginReadLine( Line value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Line {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Line");
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
                buff.WriteLine("EndRead Line");
            }
        }
        public virtual void BeginReadCrossSects( CrossSects value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CrossSects {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CrossSects");
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
                buff.WriteLine("EndRead CrossSects");
            }
        }
        public virtual void BeginReadCrossSect( CrossSect value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CrossSect {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CrossSect");
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
                buff.WriteLine("EndRead CrossSect");
            }
        }
        public virtual void BeginReadCrossSectSurf( CrossSectSurf value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CrossSectSurf {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CrossSectSurf");
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
                buff.WriteLine("EndRead CrossSectSurf");
            }
        }
        public virtual void BeginReadProject( Project value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Project {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Project");
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
                buff.WriteLine("EndRead Project");
            }
        }
        public virtual void BeginReadUnits( Units value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Units {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Units");
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
                buff.WriteLine("EndRead Units");
            }
        }
        public virtual void BeginReadMetric( Metric value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Metric {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Metric");
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
                buff.WriteLine("EndRead Metric");
            }
        }
        public virtual void BeginReadImperial( Imperial value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Imperial {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Imperial");
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
                buff.WriteLine("EndRead Imperial");
            }
        }
        public virtual void BeginReadCoordinateSystem( CoordinateSystem value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CoordinateSystem {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CoordinateSystem");
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
                buff.WriteLine("EndRead CoordinateSystem");
            }
        }
        public virtual void BeginReadApplication( Application value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Application {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Application");
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
                buff.WriteLine("EndRead Application");
            }
        }
        public virtual void BeginReadAuthor( Author value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Author {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Author");
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
                buff.WriteLine("EndRead Author");
            }
        }
        public virtual void BeginReadSurvey( Survey value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Survey {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Survey");
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
                buff.WriteLine("EndRead Survey");
            }
        }
        public virtual void BeginReadSurveyHeader( SurveyHeader value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<SurveyHeader {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead SurveyHeader");
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
                buff.WriteLine("EndRead SurveyHeader");
            }
        }
        public virtual void BeginReadPersonnel( Personnel value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Personnel {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Personnel");
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
                buff.WriteLine("EndRead Personnel");
            }
        }
        public virtual void BeginReadFieldNote( FieldNote value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<FieldNote {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead FieldNote");
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
                buff.WriteLine("EndRead FieldNote");
            }
        }
        public virtual void BeginReadEquipment( Equipment value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Equipment {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Equipment");
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
                buff.WriteLine("EndRead Equipment");
            }
        }
        public virtual void BeginReadInstrumentDetails( InstrumentDetails value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<InstrumentDetails {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead InstrumentDetails");
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
                buff.WriteLine("EndRead InstrumentDetails");
            }
        }
        public virtual void BeginReadLaserDetails( LaserDetails value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<LaserDetails {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead LaserDetails");
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
                buff.WriteLine("EndRead LaserDetails");
            }
        }
        public virtual void BeginReadGPSAntennaDetails( GPSAntennaDetails value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<GPSAntennaDetails {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead GPSAntennaDetails");
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
                buff.WriteLine("EndRead GPSAntennaDetails");
            }
        }
        public virtual void BeginReadGPSReceiverDetails( GPSReceiverDetails value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<GPSReceiverDetails {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead GPSReceiverDetails");
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
                buff.WriteLine("EndRead GPSReceiverDetails");
            }
        }
        public virtual void BeginReadCorrections( Corrections value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Corrections {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Corrections");
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
                buff.WriteLine("EndRead Corrections");
            }
        }
        public virtual void BeginReadSurveyMonument( SurveyMonument value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<SurveyMonument {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead SurveyMonument");
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
                buff.WriteLine("EndRead SurveyMonument");
            }
        }
        public virtual void BeginReadInstrumentSetup( InstrumentSetup value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<InstrumentSetup {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead InstrumentSetup");
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
                buff.WriteLine("EndRead InstrumentSetup");
            }
        }
        public virtual void BeginReadLaserSetup( LaserSetup value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<LaserSetup {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead LaserSetup");
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
                buff.WriteLine("EndRead LaserSetup");
            }
        }
        public virtual void BeginReadGPSSetup( GPSSetup value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<GPSSetup {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead GPSSetup");
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
                buff.WriteLine("EndRead GPSSetup");
            }
        }
        public virtual void BeginReadTargetSetup( TargetSetup value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<TargetSetup {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead TargetSetup");
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
                buff.WriteLine("EndRead TargetSetup");
            }
        }
        public virtual void BeginReadBacksight( Backsight value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Backsight {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Backsight");
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
                buff.WriteLine("EndRead Backsight");
            }
        }
        public virtual void BeginReadRawObservation( RawObservation value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<RawObservation {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead RawObservation");
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
                buff.WriteLine("EndRead RawObservation");
            }
        }
        public virtual void BeginReadTargetPoint( PointType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<TargetPoint {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead TargetPoint");
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
                buff.WriteLine("EndRead TargetPoint");
            }
        }
        public virtual void BeginReadBacksightPoint( PointType value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<BacksightPoint {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead BacksightPoint");
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
                buff.WriteLine("EndRead BacksightPoint");
            }
        }
        public virtual void BeginReadOffsetVals( OffsetVals value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<OffsetVals {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead OffsetVals");
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
                buff.WriteLine("EndRead OffsetVals");
            }
        }
        public virtual void BeginReadGPSVector( GPSVector value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<GPSVector {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead GPSVector");
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
                buff.WriteLine("EndRead GPSVector");
            }
        }
        public virtual void BeginReadGPSPosition( GPSPosition value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<GPSPosition {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead GPSPosition");
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
                buff.WriteLine("EndRead GPSPosition");
            }
        }
        public virtual void BeginReadGPSQCInfoLevel1( GPSQCInfoLevel1 value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<GPSQCInfoLevel1 {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead GPSQCInfoLevel1");
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
                buff.WriteLine("EndRead GPSQCInfoLevel1");
            }
        }
        public virtual void BeginReadGPSQCInfoLevel2( GPSQCInfoLevel2 value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<GPSQCInfoLevel2 {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead GPSQCInfoLevel2");
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
                buff.WriteLine("EndRead GPSQCInfoLevel2");
            }
        }
        public virtual void BeginReadObservationGroup( ObservationGroup value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ObservationGroup {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ObservationGroup");
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
                buff.WriteLine("EndRead ObservationGroup");
            }
        }
        public virtual void BeginReadControlChecks( ControlChecks value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ControlChecks {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ControlChecks");
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
                buff.WriteLine("EndRead ControlChecks");
            }
        }
        public virtual void BeginReadPointResults( PointResults value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PointResults {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PointResults");
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
                buff.WriteLine("EndRead PointResults");
            }
        }
        public virtual void BeginReadReducedObservation( ReducedObservation value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ReducedObservation {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ReducedObservation");
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
                buff.WriteLine("EndRead ReducedObservation");
            }
        }
        public virtual void BeginReadReducedArcObservation( ReducedArcObservation value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ReducedArcObservation {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ReducedArcObservation");
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
                buff.WriteLine("EndRead ReducedArcObservation");
            }
        }
        public virtual void BeginReadMonuments( Monuments value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Monuments {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Monuments");
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
                buff.WriteLine("EndRead Monuments");
            }
        }
        public virtual void BeginReadMonument( Monument value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Monument {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Monument");
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
                buff.WriteLine("EndRead Monument");
            }
        }
        public virtual void BeginReadSurfaces( Surfaces value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Surfaces {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Surfaces");
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
                buff.WriteLine("EndRead Surfaces");
            }
        }
        public virtual void BeginReadSurface( Surface value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Surface {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Surface");
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
                buff.WriteLine("EndRead Surface");
            }
        }
        public virtual void BeginReadSourceData( SourceData value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<SourceData {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead SourceData");
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
                buff.WriteLine("EndRead SourceData");
            }
        }
        public virtual void BeginReadDataPoints( DataPoints value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<DataPoints {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead DataPoints");
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
                buff.WriteLine("EndRead DataPoints");
            }
        }
        public virtual void BeginReadPointFiles( PointFiles value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PointFiles {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PointFiles");
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
                buff.WriteLine("EndRead PointFiles");
            }
        }
        public virtual void BeginReadPointFile( PointFile value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PointFile {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PointFile");
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
                buff.WriteLine("EndRead PointFile");
            }
        }
        public virtual void BeginReadBoundaries( Boundaries value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Boundaries {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Boundaries");
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
                buff.WriteLine("EndRead Boundaries");
            }
        }
        public virtual void BeginReadBoundary( Boundary value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Boundary {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Boundary");
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
                buff.WriteLine("EndRead Boundary");
            }
        }
        public virtual void BeginReadBreaklines( Breaklines value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Breaklines {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Breaklines");
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
                buff.WriteLine("EndRead Breaklines");
            }
        }
        public virtual void BeginReadBreakline( Breakline value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Breakline {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Breakline");
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
                buff.WriteLine("EndRead Breakline");
            }
        }
        public virtual void BeginReadRetWall( RetWall value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<RetWall {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead RetWall");
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
                buff.WriteLine("EndRead RetWall");
            }
        }
        public virtual void BeginReadRetWallPnt( RetWallPnt value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<RetWallPnt {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead RetWallPnt");
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
                buff.WriteLine("EndRead RetWallPnt");
            }
        }
        public virtual void BeginReadContours( Contours value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Contours {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Contours");
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
                buff.WriteLine("EndRead Contours");
            }
        }
        public virtual void BeginReadContour( Contour value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Contour {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Contour");
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
                buff.WriteLine("EndRead Contour");
            }
        }
        public virtual void BeginReadDefinition( Definition value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Definition {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Definition");
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
                buff.WriteLine("EndRead Definition");
            }
        }
        public virtual void BeginReadPnts( Pnts value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Pnts {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Pnts");
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
                buff.WriteLine("EndRead Pnts");
            }
        }
        public virtual void BeginReadP( P value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<P {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead P");
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
                buff.WriteLine("EndRead P");
            }
        }
        public virtual void BeginReadFaces( Faces value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Faces {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Faces");
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
                buff.WriteLine("EndRead Faces");
            }
        }
        public virtual void BeginReadWatersheds( Watersheds value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Watersheds {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Watersheds");
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
                buff.WriteLine("EndRead Watersheds");
            }
        }
        public virtual void BeginReadWatershed( Watershed value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Watershed {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Watershed");
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
                buff.WriteLine("EndRead Watershed");
            }
        }
        public virtual void BeginReadOutlet( Outlet value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Outlet {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Outlet");
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
                buff.WriteLine("EndRead Outlet");
            }
        }
        public virtual void BeginReadSurfVolumes( SurfVolumes value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<SurfVolumes {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead SurfVolumes");
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
                buff.WriteLine("EndRead SurfVolumes");
            }
        }
        public virtual void BeginReadSurfVolume( SurfVolume value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<SurfVolume {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead SurfVolume");
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
                buff.WriteLine("EndRead SurfVolume");
            }
        }
        public virtual void BeginReadParcels( Parcels value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Parcels {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Parcels");
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
                buff.WriteLine("EndRead Parcels");
            }
        }
        public virtual void BeginReadParcel( Parcel value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Parcel {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Parcel");
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
                buff.WriteLine("EndRead Parcel");
            }
        }
        public virtual void BeginReadTitle( Title value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Title {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Title");
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
                buff.WriteLine("EndRead Title");
            }
        }
        public virtual void BeginReadAlignments( Alignments value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Alignments {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Alignments");
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
                buff.WriteLine("EndRead Alignments");
            }
        }
        public virtual void BeginReadAlignment( Alignment value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Alignment {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Alignment");
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
                buff.WriteLine("EndRead Alignment");
            }
        }
        public virtual void BeginReadStaEquation( StaEquation value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<StaEquation {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead StaEquation");
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
                buff.WriteLine("EndRead StaEquation");
            }
        }
        public virtual void BeginReadProfile( Profile value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Profile {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Profile");
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
                buff.WriteLine("EndRead Profile");
            }
        }
        public virtual void BeginReadProfSurf( ProfSurf value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ProfSurf {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ProfSurf");
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
                buff.WriteLine("EndRead ProfSurf");
            }
        }
        public virtual void BeginReadProfAlign( ProfAlign value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ProfAlign {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ProfAlign");
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
                buff.WriteLine("EndRead ProfAlign");
            }
        }
        public virtual void BeginReadPVI( PVI value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PVI {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PVI");
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
                buff.WriteLine("EndRead PVI");
            }
        }
        public virtual void BeginReadParaCurve( ParaCurve value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ParaCurve {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ParaCurve");
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
                buff.WriteLine("EndRead ParaCurve");
            }
        }
        public virtual void BeginReadUnsymParaCurve( UnsymParaCurve value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<UnsymParaCurve {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead UnsymParaCurve");
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
                buff.WriteLine("EndRead UnsymParaCurve");
            }
        }
        public virtual void BeginReadCircCurve( CircCurve value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CircCurve {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CircCurve");
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
                buff.WriteLine("EndRead CircCurve");
            }
        }
        public virtual void BeginReadPipeNetworks( PipeNetworks value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PipeNetworks {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PipeNetworks");
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
                buff.WriteLine("EndRead PipeNetworks");
            }
        }
        public virtual void BeginReadPipeNetwork( PipeNetwork value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PipeNetwork {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PipeNetwork");
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
                buff.WriteLine("EndRead PipeNetwork");
            }
        }
        public virtual void BeginReadPipes( Pipes value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Pipes {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Pipes");
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
                buff.WriteLine("EndRead Pipes");
            }
        }
        public virtual void BeginReadPipe( Pipe value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Pipe {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Pipe");
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
                buff.WriteLine("EndRead Pipe");
            }
        }
        public virtual void BeginReadCircPipe( CircPipe value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CircPipe {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CircPipe");
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
                buff.WriteLine("EndRead CircPipe");
            }
        }
        public virtual void BeginReadElliPipe( ElliPipe value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ElliPipe {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ElliPipe");
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
                buff.WriteLine("EndRead ElliPipe");
            }
        }
        public virtual void BeginReadRectPipe( RectPipe value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<RectPipe {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead RectPipe");
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
                buff.WriteLine("EndRead RectPipe");
            }
        }
        public virtual void BeginReadChannel( Channel value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Channel {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Channel");
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
                buff.WriteLine("EndRead Channel");
            }
        }
        public virtual void BeginReadPipeFlow( PipeFlow value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PipeFlow {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PipeFlow");
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
                buff.WriteLine("EndRead PipeFlow");
            }
        }
        public virtual void BeginReadStructs( Structs value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Structs {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Structs");
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
                buff.WriteLine("EndRead Structs");
            }
        }
        public virtual void BeginReadStruct( Struct value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Struct {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Struct");
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
                buff.WriteLine("EndRead Struct");
            }
        }
        public virtual void BeginReadCircStruct( CircStruct value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CircStruct {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CircStruct");
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
                buff.WriteLine("EndRead CircStruct");
            }
        }
        public virtual void BeginReadRectStruct( RectStruct value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<RectStruct {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead RectStruct");
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
                buff.WriteLine("EndRead RectStruct");
            }
        }
        public virtual void BeginReadInletStruct( InletStruct value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<InletStruct {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead InletStruct");
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
                buff.WriteLine("EndRead InletStruct");
            }
        }
        public virtual void BeginReadOutletStruct( OutletStruct value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<OutletStruct {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead OutletStruct");
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
                buff.WriteLine("EndRead OutletStruct");
            }
        }
        public virtual void BeginReadConnection( Connection value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Connection {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Connection");
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
                buff.WriteLine("EndRead Connection");
            }
        }
        public virtual void BeginReadInvert( Invert value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Invert {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Invert");
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
                buff.WriteLine("EndRead Invert");
            }
        }
        public virtual void BeginReadStructFlow( StructFlow value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<StructFlow {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead StructFlow");
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
                buff.WriteLine("EndRead StructFlow");
            }
        }
        public virtual void BeginReadPlanFeatures( PlanFeatures value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PlanFeatures {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PlanFeatures");
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
                buff.WriteLine("EndRead PlanFeatures");
            }
        }
        public virtual void BeginReadPlanFeature( PlanFeature value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PlanFeature {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PlanFeature");
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
                buff.WriteLine("EndRead PlanFeature");
            }
        }
        public virtual void BeginReadGradeModel( GradeModel value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<GradeModel {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead GradeModel");
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
                buff.WriteLine("EndRead GradeModel");
            }
        }
        public virtual void BeginReadGradeSurface( GradeSurface value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<GradeSurface {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead GradeSurface");
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
                buff.WriteLine("EndRead GradeSurface");
            }
        }
        public virtual void BeginReadZones( Zones value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Zones {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Zones");
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
                buff.WriteLine("EndRead Zones");
            }
        }
        public virtual void BeginReadZone( Zone value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Zone {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Zone");
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
                buff.WriteLine("EndRead Zone");
            }
        }
        public virtual void BeginReadZoneWidth( ZoneWidth value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ZoneWidth {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ZoneWidth");
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
                buff.WriteLine("EndRead ZoneWidth");
            }
        }
        public virtual void BeginReadZoneSlope( ZoneSlope value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ZoneSlope {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ZoneSlope");
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
                buff.WriteLine("EndRead ZoneSlope");
            }
        }
        public virtual void BeginReadZoneHinge( ZoneHinge value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ZoneHinge {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ZoneHinge");
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
                buff.WriteLine("EndRead ZoneHinge");
            }
        }
        public virtual void BeginReadZoneCutFill( ZoneCutFill value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ZoneCutFill {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ZoneCutFill");
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
                buff.WriteLine("EndRead ZoneCutFill");
            }
        }
        public virtual void BeginReadZoneMaterial( ZoneMaterial value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ZoneMaterial {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ZoneMaterial");
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
                buff.WriteLine("EndRead ZoneMaterial");
            }
        }
        public virtual void BeginReadZoneCrossSectStructure( ZoneCrossSectStructure value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ZoneCrossSectStructure {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ZoneCrossSectStructure");
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
                buff.WriteLine("EndRead ZoneCrossSectStructure");
            }
        }
        public virtual void BeginReadRoadways( Roadways value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Roadways {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Roadways");
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
                buff.WriteLine("EndRead Roadways");
            }
        }
        public virtual void BeginReadRoadway( Roadway value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Roadway {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Roadway");
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
                buff.WriteLine("EndRead Roadway");
            }
        }
        public virtual void BeginReadClassification( Classification value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Classification {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Classification");
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
                buff.WriteLine("EndRead Classification");
            }
        }
        public virtual void BeginReadDesignSpeed( DesignSpeed value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<DesignSpeed {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead DesignSpeed");
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
                buff.WriteLine("EndRead DesignSpeed");
            }
        }
        public virtual void BeginReadDesignSpeed85th( DesignSpeed85th value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<DesignSpeed85th {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead DesignSpeed85th");
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
                buff.WriteLine("EndRead DesignSpeed85th");
            }
        }
        public virtual void BeginReadSpeeds( Speeds value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Speeds {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Speeds");
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
                buff.WriteLine("EndRead Speeds");
            }
        }
        public virtual void BeginReadDailyTrafficVolume( DailyTrafficVolume value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<DailyTrafficVolume {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead DailyTrafficVolume");
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
                buff.WriteLine("EndRead DailyTrafficVolume");
            }
        }
        public virtual void BeginReadDesignHour( DesignHour value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<DesignHour {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead DesignHour");
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
                buff.WriteLine("EndRead DesignHour");
            }
        }
        public virtual void BeginReadPeakHour( PeakHour value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PeakHour {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PeakHour");
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
                buff.WriteLine("EndRead PeakHour");
            }
        }
        public virtual void BeginReadTrafficVolume( TrafficVolume value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<TrafficVolume {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead TrafficVolume");
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
                buff.WriteLine("EndRead TrafficVolume");
            }
        }
        public virtual void BeginReadSuperelevation( Superelevation value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Superelevation {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Superelevation");
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
                buff.WriteLine("EndRead Superelevation");
            }
        }
        public virtual void BeginReadLanes( Lanes value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Lanes {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Lanes");
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
                buff.WriteLine("EndRead Lanes");
            }
        }
        public virtual void BeginReadThruLane( ThruLane value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ThruLane {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ThruLane");
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
                buff.WriteLine("EndRead ThruLane");
            }
        }
        public virtual void BeginReadPassingLane( PassingLane value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PassingLane {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PassingLane");
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
                buff.WriteLine("EndRead PassingLane");
            }
        }
        public virtual void BeginReadTurnLane( TurnLane value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<TurnLane {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead TurnLane");
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
                buff.WriteLine("EndRead TurnLane");
            }
        }
        public virtual void BeginReadTwoWayLeftTurnLane( TwoWayLeftTurnLane value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<TwoWayLeftTurnLane {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead TwoWayLeftTurnLane");
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
                buff.WriteLine("EndRead TwoWayLeftTurnLane");
            }
        }
        public virtual void BeginReadClimbLane( ClimbLane value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ClimbLane {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ClimbLane");
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
                buff.WriteLine("EndRead ClimbLane");
            }
        }
        public virtual void BeginReadOffsetLane( OffsetLane value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<OffsetLane {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead OffsetLane");
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
                buff.WriteLine("EndRead OffsetLane");
            }
        }
        public virtual void BeginReadWideningLane( WideningLane value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<WideningLane {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead WideningLane");
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
                buff.WriteLine("EndRead WideningLane");
            }
        }
        public virtual void BeginReadRoadside( Roadside value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Roadside {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Roadside");
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
                buff.WriteLine("EndRead Roadside");
            }
        }
        public virtual void BeginReadDitch( Ditch value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Ditch {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Ditch");
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
                buff.WriteLine("EndRead Ditch");
            }
        }
        public virtual void BeginReadObstructionOffset( ObstructionOffset value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<ObstructionOffset {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead ObstructionOffset");
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
                buff.WriteLine("EndRead ObstructionOffset");
            }
        }
        public virtual void BeginReadBikeFacilities( BikeFacilities value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<BikeFacilities {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead BikeFacilities");
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
                buff.WriteLine("EndRead BikeFacilities");
            }
        }
        public virtual void BeginReadRoadSign( RoadSign value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<RoadSign {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead RoadSign");
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
                buff.WriteLine("EndRead RoadSign");
            }
        }
        public virtual void BeginReadDrivewayDensity( DrivewayDensity value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<DrivewayDensity {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead DrivewayDensity");
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
                buff.WriteLine("EndRead DrivewayDensity");
            }
        }
        public virtual void BeginReadHazardRating( HazardRating value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<HazardRating {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead HazardRating");
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
                buff.WriteLine("EndRead HazardRating");
            }
        }
        public virtual void BeginReadIntersections( Intersections value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Intersections {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Intersections");
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
                buff.WriteLine("EndRead Intersections");
            }
        }
        public virtual void BeginReadIntersection( Intersection value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Intersection {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Intersection");
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
                buff.WriteLine("EndRead Intersection");
            }
        }
        public virtual void BeginReadTrafficControl( TrafficControl value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<TrafficControl {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead TrafficControl");
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
                buff.WriteLine("EndRead TrafficControl");
            }
        }
        public virtual void BeginReadTiming( Timing value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Timing {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Timing");
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
                buff.WriteLine("EndRead Timing");
            }
        }
        public virtual void BeginReadVolume( Volume value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Volume {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Volume");
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
                buff.WriteLine("EndRead Volume");
            }
        }
        public virtual void BeginReadTurnSpeed( TurnSpeed value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<TurnSpeed {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead TurnSpeed");
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
                buff.WriteLine("EndRead TurnSpeed");
            }
        }
        public virtual void BeginReadTurnRestriction( TurnRestriction value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<TurnRestriction {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead TurnRestriction");
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
                buff.WriteLine("EndRead TurnRestriction");
            }
        }
        public virtual void BeginReadCurb( Curb value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Curb {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Curb");
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
                buff.WriteLine("EndRead Curb");
            }
        }
        public virtual void BeginReadCorner( Corner value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<Corner {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead Corner");
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
                buff.WriteLine("EndRead Corner");
            }
        }
        public virtual void BeginReadCrashData( CrashData value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CrashData {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CrashData");
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
                buff.WriteLine("EndRead CrashData");
            }
        }
        public virtual void BeginReadCrashHistory( CrashHistory value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<CrashHistory {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead CrashHistory");
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
                buff.WriteLine("EndRead CrashHistory");
            }
        }
        public virtual void BeginReadPostedSpeed( PostedSpeed value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<PostedSpeed {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead PostedSpeed");
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
                buff.WriteLine("EndRead PostedSpeed");
            }
        }
        public virtual void BeginReadNoPassingZone( NoPassingZone value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<NoPassingZone {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead NoPassingZone");
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
                buff.WriteLine("EndRead NoPassingZone");
            }
        }
        public virtual void BeginReadDecisionSightDistance( DecisionSightDistance value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<DecisionSightDistance {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead DecisionSightDistance");
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
                buff.WriteLine("EndRead DecisionSightDistance");
            }
        }
        public virtual void BeginReadBridgeElement( BridgeElement value )
        {
            // BeginRead
            if (this.AsXml)
            {
                buff.WriteLine("<BridgeElement {0}>", ToAttributes(value));
                buff.Indent();
            }
            else
            {
                buff.WriteLine("BeginRead BridgeElement");
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
                buff.WriteLine("EndRead BridgeElement");
            }
        }

    }
}
#endif

