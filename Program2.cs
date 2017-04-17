using System.Xml.Schema;
using XmlSchemaProcessor.LandXml;
using XmlSchemaProcessor.LandXml11;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor
{
    public class Program2
    {
        private static void Main(string[] args)
        {
#if BUILD_LAND_XML
            BuildLandXml10();
            BuildLandXml11();
            BuildLandXml12();
            BuildLandXml20();
#else
            TestLandXml();
#endif
        }

        public static void BuildLandXml(string xsdFile, string csfile, string @namespace)
        {
            XmlSchema xmlSchema = ProcessXmlSchema.LoadXmlSchema(xsdFile);

            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(xmlSchema);
            schemaSet.Compile();

            XsdSchema schema = new ProcessXmlSchema(xmlSchema).GetSchema();
            schema.ResolveAnonymousSimpleTypes();

            XsdToNetReader xsdToNetReader = new XsdToNetReader();
            xsdToNetReader.Process(schema);
            xsdToNetReader.Write(csfile, @namespace);
        }

        public static void BuildLandXml10()
        {
            BuildLandXml(@"Resources\Schemas\LandXML-1.0.xsd",
                         @"C:\Proyectos\Publicos\XsdProcessor\LandXml\LandXML10.cs",
                         "XmlSchemaProcessor.LandXml10");
        }

        public static void BuildLandXml11()
        {
            BuildLandXml(@"Resources\Schemas\LandXML-1.1.xsd",
                         @"C:\Proyectos\Publicos\XsdProcessor\LandXml\LandXML11.cs",
                         "XmlSchemaProcessor.LandXml11");
        }

        public static void BuildLandXml12()
        {
            BuildLandXml(@"Resources\Schemas\LandXML-1.2.xsd",
                         @"C:\Proyectos\Publicos\XsdProcessor\LandXml\LandXML12.cs",
                         "XmlSchemaProcessor.LandXml12");
        }

        public static void BuildLandXml20()
        {
            BuildLandXml(@"Resources\Schemas\LandXML-2.0.xsd",
                         @"C:\Proyectos\Publicos\XsdProcessor\LandXml\LandXML20.cs",
                         "XmlSchemaProcessor.LandXml20");
        }

#if !BUILD_LAND_XML
        public static void TestLandXml()
        {
            LandXmlReader reader = new LandXmlReader(new MyLandXmlEvents());
            reader.Read(@"Resources\Samples\MntnRoad.xml");
        }

        public class MyLandXmlEvents : LandXmlEvents
        {
            public override void BeginReadLandXML(LandXML value)
            {
                base.BeginReadLandXML(value);
            }

            public override void EndReadLandXML()
            {
                base.EndReadLandXML();
            }
        }
#endif
    }

    /*public struct ValueObject<T> where T : struct
        {
            public ValueObject(T t)
            {
                this.@base = t;
            }
    
            public static implicit operator T(ValueObject<T> vo)
            {
                return vo.@base;
            }
    
            public static implicit operator ValueObject<T>(T t)
            {
                return new ValueObject<T>(t);
            }
    
            public override bool Equals(object obj)
            {
                T other;
                if (obj is T)
                {
                    other = (T)obj;
                }
                else if (obj is ValueObject<T>)
                {
                    other = (ValueObject<T>)obj;
                }
                else
                {
                    return false;
                }
                return this.@base.Equals(other);
            }
    
            public override int GetHashCode()
            {
                return this.@base.GetHashCode();
            }
    
            public override string ToString()
            {
                return this.@base.ToString();
            }
    
            private readonly T @base;
        }*/
}