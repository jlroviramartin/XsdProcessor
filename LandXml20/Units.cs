#if !BUILD_LAND_XML
using System;
using System.IO;
using System.Collections.Generic;
using XmlSchemaProcessor.Processors;

namespace XmlSchemaProcessor.LandXml20
{

    /// <summary>
    /// All angular and direction values default to radians unless otherwise noted. Angular values, expressed in the specified Units.angleUnit are measured counter-clockwise from east=0. Horizontal directions, expressed in the specified Units.directionUnit are measured counter-clockwise from 0 degrees = north
    /// </summary>

    public class Units : XsdBaseObject
    {
        public override bool Read(IDictionary<string, string> attributes, string text)
        {
            base.Read(attributes, text);


            return true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.AppendLine(base.ToString());


            return buff.ToString();
        }

        public override string ToAttributes()
        {
            System.Text.StringBuilder buff = new System.Text.StringBuilder();
            buff.Append(base.ToAttributes());


            return buff.ToString();
        }


    }
}
#endif

