using System.Xml.Schema;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaTest
{
    public class Program2
    {
        private static void Main(string[] args)
        {
            XmlSchema xmlSchema = ProcessXmlSchema.LoadXmlSchema("LandXML-1.2.xsd");
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

            XsdToReader xsdToReader = new XsdToReader();
            xsdToReader.Process(schema);
            xsdToReader.Write();
        }
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