using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;
using XmlSchemaProcessor.Processors;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor
{
    public class BuildGML
    {
        public static void Build()
        {
            /*XmlSchemaSet schemaSet = new XmlSchemaSet();
            DirectoryInfo d = new DirectoryInfo(@"Resources\Schemas\gml\3.2.2");
            foreach (FileInfo file in d.GetFiles("*.xsd"))
            {
                if (file.Name.EqualsIgnoreCase("deprecatedTypes"))
                {
                    continue;
                }

                XmlSchema xmlSchema = ProcessXmlSchema.LoadXmlSchema(file);
                schemaSet.Add(xmlSchema);
            }
            schemaSet.Compile();*/

            XmlSchema xmlSchema = ProcessXmlSchema.LoadXmlSchema(@"Resources\Schemas\gml\3.2.2\gml.xsd");

            //foreach (XmlSchema xmlSchema in schemaSet.Schemas())
            {
                XmlSchemaResolver schemaResolver = new XmlSchemaResolver(@"Resources\Schemas\gml\3.2.2");
                XsdSchema schema = new ProcessXmlSchema(xmlSchema, "gml.xsd", schemaResolver).GetSchema();
                schema.ResolveAnonymousSimpleTypes();

                XsdToNetProcess_v2 xsdToNetReader = new XsdToNetProcess_v2("a.b.c", @"C:\Temp\gml");
                //xsdToNetReader.AddXsdRoot("LandXML");
                xsdToNetReader.Process(schema);
            }
        }

        public class XmlSchemaResolver : IXmlSchemaResolver
        {
            public XmlSchemaResolver(params string[] paths)
            {
                this.paths.AddRange(paths);
            }

            private readonly List<string> paths = new List<string>();

            public XmlSchema Resolve(string schemaLocation)
            {
                foreach (string path in this.paths)
                {
                    string file = System.IO.Path.Combine(path, schemaLocation);
                    if (File.Exists(file))
                    {
                        return ProcessXmlSchema.LoadXmlSchema(file);
                    }
                }
                return null;
            }
        }
    }
}