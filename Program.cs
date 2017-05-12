#if !BUILD_LAND_XML
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using XmlSchemaProcessor.LandXml20;
using XmlSchemaProcessor.Processors;

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
            /*TestLandXmlEvents landXmlEvents = new TestLandXmlEvents();
            landXmlEvents.AsXml = true;
            LandXmlReader reader = new LandXmlReader(landXmlEvents);
            reader.Read(@"Resources\Samples\MntnRoad.xml");
            landXmlEvents.DebugWrite(@"Output.txt");*/

            using (XmlReader xmlReader = new XmlTextReader(new FileStream(@"Resources\Samples\MiddleCalmarRoad.xml", FileMode.Open, FileAccess.Read)))
            {
                Find(xmlReader, "LandXML");

                Stack<XsdBaseReader> toRead = new Stack<XsdBaseReader>();

                LandXml12.LandXML land = new LandXml12.LandXML(xmlReader);

                Debug.Write(Tabs(land.Depth));
                Debug.WriteLine(land.GetType().Name + " " + land.ToAttributes());
                toRead.Push(land);
                while (toRead.Count > 0)
                {
                    XsdBaseReader xsdReader = toRead.Pop();
                    Tuple<string, object> tuple = xsdReader.ReadElement();
                    if (tuple != null)
                    {
                        toRead.Push(xsdReader);

                        XsdBaseReader aux = tuple.Item2 as XsdBaseReader;
                        if (aux != null)
                        {
                            Debug.Write(Tabs(aux.Depth));
                            Debug.WriteLine(aux.GetType().Name + " " + aux.ToAttributes());
                            toRead.Push(aux);
                        }
                    }
                }
            }
        }

        public static string Tabs(int count)
        {
            StringBuilder buff = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                buff.Append("  ");
            }
            return buff.ToString();
        }

        private static bool Find(XmlReader xmlReader, string name)
        {
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && xmlReader.Name.EqualsIgnoreCase(name))
                {
                    return true;
                }
            }
            return false;
        }
#endif
    }
}