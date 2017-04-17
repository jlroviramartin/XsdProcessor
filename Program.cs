using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace XmlSchemaProcessor
{
    class Program
    {
        static void Main2(string[] args)
        {
            XmlSchema xmlSchema = LoadXmlSchema(@"LandXML-1.2.xsd");
            ProcessXmlSchema(xmlSchema);
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

        private static void ProcessXmlSchema(XmlSchema xmlSchema)
        {
            foreach (XmlSchemaObject xmlSchemaObject in xmlSchema.Items)
            {
                if (xmlSchemaObject is XmlSchemaAnnotated)
                {
                    Debug.WriteLine("XmlSchemaAnnotated " + xmlSchemaObject);
                }
                else if (xmlSchemaObject is XmlSchemaAnnotation)
                {
                    Debug.WriteLine("XmlSchemaAnnotation " + xmlSchemaObject);
                }
                else if (xmlSchemaObject is XmlSchemaAppInfo)
                {
                    Debug.WriteLine("XmlSchemaAppInfo " + xmlSchemaObject);
                }
                else if (xmlSchemaObject is XmlSchemaDocumentation)
                {
                    Debug.WriteLine("XmlSchemaDocumentation " + xmlSchemaObject);
                }
                else if (xmlSchemaObject is XmlSchemaExternal)
                {
                    Debug.WriteLine("XmlSchemaExternal " + xmlSchemaObject);
                }
            }
        }

        private class Process
        {
            private Process()
            {
                this.emptyAction = this.EmptyAction;
            }

            private void Add<T>(Action<T> action)
                where T : XmlSchemaObject
            {
                this.actions.Add(Tuple.Create(typeof (T), new Action<XmlSchemaObject>(x => action((T)x))));
            }

            private Action<XmlSchemaObject> Find(Type type)
            {
                Action<XmlSchemaObject> action;
                if (!this.cacheActions.TryGetValue(type, out action))
                {
                    Tuple<Type, Action<XmlSchemaObject>> curr = null;
                    foreach (Tuple<Type, Action<XmlSchemaObject>> tuple in this.actions)
                    {
                        if (tuple.Item1 == type)
                        {
                            curr = tuple;
                            break;
                        }
                        else if (tuple.Item1.IsAssignableFrom(type))
                        {
                            if (curr == null)
                            {
                                curr = tuple;
                            }
                            else if (tuple.Item1.IsAssignableFrom(curr.Item1))
                            {
                                curr = tuple;
                            }
                        }
                    }
                    if (curr == null)
                    {
                        curr = Tuple.Create(type, this.emptyAction);
                    }
                    this.cacheActions.Add(type, curr.Item2);
                }
                return action;
            }

            private void InitActions()
            {
                this.Add<XmlSchemaObject>(this.ProcessXmlSchemaObject);
                this.Add<XmlSchemaAnnotated>(this.ProcessXmlSchemaAnnotated);
                {
                    /*this.Add<XmlSchemaAnyAttribute>(this.ProcessXmlSchemaAnyAttribute);
                    this.Add<XmlSchemaAttribute>(this.ProcessXmlSchemaAttribute);
                    this.Add<XmlSchemaAttributeGroup>(this.ProcessXmlSchemaAttributeGroup);
                    this.Add<XmlSchemaAttributeGroupRef>(this.ProcessXmlSchemaAttributeGroupRef);
                    this.Add<XmlSchemaContent>(this.ProcessXmlSchemaContent);
                    this.Add<XmlSchemaContentModel>(this.ProcessXmlSchemaContentModel);
                    this.Add<XmlSchemaFacet>(this.ProcessXmlSchemaFacet);
                    this.Add<XmlSchemaGroup>(this.ProcessXmlSchemaGroup);
                    this.Add<XmlSchemaIdentityConstraint>(this.ProcessXmlSchemaIdentityConstraint);
                    this.Add<XmlSchemaNotation>(this.ProcessXmlSchemaNotation);
                    this.Add<XmlSchemaParticle>(this.ProcessXmlSchemaParticle);
                    this.Add<XmlSchemaSimpleTypeContent>(this.ProcessXmlSchemaSimpleTypeContent);
                    this.Add<XmlSchemaType>(this.ProcessXmlSchemaType);
                    this.Add<XmlSchemaXPath>(this.ProcessXmlSchemaXPath);*/
                }
                this.Add<XmlSchemaAnnotation>(this.ProcessXmlSchemaAnnotation);
                this.Add<XmlSchemaAppInfo>(this.ProcessXmlSchemaAppInfo);
                this.Add<XmlSchemaDocumentation>(this.ProcessXmlSchemaDocumentation);
                this.Add<XmlSchemaExternal>(this.ProcessXmlSchemaExternal);
            }

            public virtual void ProcessXmlSchemaObject(XmlSchemaObject schemaObject)
            {
                Debug.WriteLine("XmlSchemaObject " + schemaObject);
            }

            public virtual void ProcessXmlSchemaAnnotated(XmlSchemaAnnotated schemaAnnotated)
            {
                Debug.WriteLine("XmlSchemaAnnotated " + schemaAnnotated);
            }

            public virtual void ProcessXmlSchemaAnnotation(XmlSchemaAnnotation schemaAnnotation)
            {
                Debug.WriteLine("XmlSchemaAnnotation " + schemaAnnotation);
            }

            public virtual void ProcessXmlSchemaAppInfo(XmlSchemaAppInfo schemaAppInfo)
            {
                Debug.WriteLine("XmlSchemaAppInfo " + schemaAppInfo);
            }

            public virtual void ProcessXmlSchemaDocumentation(XmlSchemaDocumentation schemaDocumentation)
            {
                Debug.WriteLine("XmlSchemaDocumentation " + schemaDocumentation);
            }

            public virtual void ProcessXmlSchemaExternal(XmlSchemaExternal schemaExternal)
            {
                Debug.WriteLine("XmlSchemaExternal " + schemaExternal);
            }

            private void EmptyAction(XmlSchemaObject schemaObject)
            {
            }

            private readonly Action<XmlSchemaObject> emptyAction;

            private readonly Dictionary<Type, Action<XmlSchemaObject>> cacheActions = new Dictionary<Type, Action<XmlSchemaObject>>();
            private readonly List<Tuple<Type, Action<XmlSchemaObject>>> actions = new List<Tuple<Type, Action<XmlSchemaObject>>>();
        }
    }
}