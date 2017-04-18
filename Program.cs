#if !BUILD_LAND_XML
using XmlSchemaProcessor.LandXml20;
#endif

namespace XmlSchemaProcessor
{
    public class Program
    {
        private static void Main(string[] args)
        {
#if BUILD_LAND_XML
            BuildLandXML.Build();
#else
            TestLandXml();
#endif
        }

#if !BUILD_LAND_XML
        public static void TestLandXml()
        {
            TestLandXmlEvents landXmlEvents = new TestLandXmlEvents();
            landXmlEvents.AsXml = false;
            LandXmlReader reader = new LandXmlReader(landXmlEvents);
            reader.Read(@"Resources\Samples\MntnRoad.xml");
            landXmlEvents.DebugWrite(@"Output.txt");
        }
#endif
    }
}