using System.Xml.Schema;
using XmlSchemaProcessor.LandXml;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor
{
    public class Program2
    {
        private static void Main(string[] args)
        {
#if BUILD_LAND_XML
            BuildLandXml();
#else
            TestLandXml();
#endif
        }

        public static void BuildLandXml()
        {
            XmlSchema xmlSchema = ProcessXmlSchema.LoadXmlSchema(@"Resources\Schemas\LandXML-1.2.xsd");
            //XmlSchema xmlSchema = LoadXmlSchema("Test1.xsd");
            //XmlSchema xmlSchema = LoadXmlSchema("Test2.xsd");

            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(xmlSchema);
            schemaSet.Compile();

            XsdSchema schema = new ProcessXmlSchema(xmlSchema).GetSchema();
            //Debug.WriteLine(schema);

            //DocumentXsd documentXsd = new DocumentXsd();
            //documentXsd.Process(schema);
            //documentXsd.Write();

            XsdToNetReader xsdToNetReader = new XsdToNetReader();
            xsdToNetReader.Process(schema);
            xsdToNetReader.Write(@"C:\Proyectos\Publicos\XsdProcessor\LandXml\Test.cs", "XmlSchemaProcessor.LandXml");
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