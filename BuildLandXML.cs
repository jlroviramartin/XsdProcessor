// Copyright 2017 Jose Luis Rovira Martin
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#if BUILD_LAND_XML
using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using XmlSchemaProcessor.Processors;
using XmlSchemaProcessor.Xsd;

namespace XmlSchemaProcessor
{
    public class BuildLandXML
    {
        public const string LANDXML10_URI = "http://www.landxml.org/schema/LandXML-1.0";
        public const string LANDXML11_URI = "http://www.landxml.org/schema/LandXML-1.1";
        public const string LANDXML12_URI = "http://www.landxml.org/schema/LandXML-1.2";
        public const string LANDXML20_URI = "http://www.landxml.org/schema/LandXML-2.0";

        public static void Build()
        {
            BuildLandXml10(LANDXML10_URI);
            BuildLandXml11(LANDXML11_URI, LANDXML10_URI);
            BuildLandXml12(LANDXML12_URI, LANDXML11_URI, LANDXML10_URI);
            BuildLandXml20(LANDXML20_URI, LANDXML12_URI, LANDXML11_URI, LANDXML10_URI);
        }

        public static void BuildLandXml(string xsdFile, string path, string @namespace, string[] namespacesURI)
        {
            XmlSchema xmlSchema = ProcessXmlSchema.LoadXmlSchema(xsdFile);

            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(xmlSchema);
            schemaSet.Compile();

            XsdSchema schema = new ProcessXmlSchema(xmlSchema).GetSchema();
            schema.ResolveAnonymousSimpleTypes();

            XsdToNetProcess xsdToNetReader = new XsdToNetProcess(@namespace, path);
            xsdToNetReader.PropertyMap = new LandXmlPropertyMap();
            foreach (string uri in namespacesURI)
            {
                xsdToNetReader.AddNamespaceURI(uri);
            }
            xsdToNetReader.Process(schema);
        }

        public static void BuildLandXml10(params string[] namespacesURI)
        {
            BuildLandXml(@"Resources\Schemas\LandXML-1.0.xsd",
                         @"C:\Proyectos\Publicos\XsdProcessor\LandXml10\",
                         "XmlSchemaProcessor.LandXml10",
                         namespacesURI);
        }

        public static void BuildLandXml11(params string[] namespacesURI)
        {
            BuildLandXml(@"Resources\Schemas\LandXML-1.1.xsd",
                         @"C:\Proyectos\Publicos\XsdProcessor\LandXml11\",
                         "XmlSchemaProcessor.LandXml11",
                         namespacesURI);
        }

        public static void BuildLandXml12(params string[] namespacesURI)
        {
            BuildLandXml(@"Resources\Schemas\LandXML-1.2.xsd",
                         @"C:\Proyectos\Publicos\XsdProcessor\LandXml12\",
                         "XmlSchemaProcessor.LandXml12",
                         namespacesURI);
        }

        public static void BuildLandXml20(params string[] namespacesURI)
        {
            BuildLandXml(@"Resources\Schemas\LandXML-2.0.xsd",
                         @"C:\Proyectos\Publicos\XsdProcessor\LandXml20\",
                         "XmlSchemaProcessor.LandXml20",
                         namespacesURI);
        }

        public static XmlSchema LoadXmlSchema(string file)
        {
            using (FileStream stream = new FileStream(file, FileMode.Open))
            using (XmlTextReader xmlReader = new XmlTextReader(stream))
            {
                XmlSchema xmlSchema = XmlSchema.Read(xmlReader, Validation);
                return xmlSchema;
            }
        }

        private static void Validation(object sender, ValidationEventArgs args)
        {
            Debug.WriteLine("Validation Error: {0}", args.Message);
        }

        private class LandXmlPropertyMap : IPropertyMap
        {
            public string Map(XsdComplexType xsdComplexType, string typeName, string attributeName)
            {
                if (typeName.Equals("RoadName") && attributeName.Equals("roadName"))
                {
                    return "_RoadName";
                }
                return attributeName;
            }
        }
    }
}

#endif