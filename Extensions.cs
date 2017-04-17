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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace XmlSchemaProcessor
{
    public static class Extensions
    {
        public static TV GetSafe<TK, TV>(this IDictionary<TK, TV> dicc, TK key, TV def = default(TV))
        {
            TV value;
            if (!dicc.TryGetValue(key, out value))
            {
                value = def;
            }
            return value;
        }

        public static void SafeAdd<TK, TV>(this IDictionary<TK, TV> dicc, TK key, TV value)
        {
            if (!dicc.ContainsKey(key))
            {
                dicc.Add(key, value);
            }
            else
            {
                dicc[key] = value;
            }
        }

        public static string ToStringAsList(this IEnumerable<string> enumer, string sep)
        {
            StringBuilder buff = new StringBuilder();
            bool first = true;
            foreach (string s in enumer)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    buff.Append(sep);
                }
                buff.Append(s);
            }
            return buff.ToString();
        }

        public static string ToFieldName(this string name)
        {
            return FirstLower(name);
        }

        public static string ToMethodName(this string name)
        {
            return FirstUpper(name);
        }

        public static string ToTypeName(this string name)
        {
            return FirstUpper(name);
        }

        public static string ToEnumValueName(this string name)
        {
            return FirstUpper(name);
        }

        public static string FirstUpper(this string name)
        {
            return Normalize(name, false);
        }

        public static string FirstLower(this string name)
        {
            return Normalize(name, true);
        }

        public static string Normalize(this string name, bool firstLower)
        {
            char[] separator = { ' ', '-', '+', '.' };

            StringBuilder buff = new StringBuilder();
            bool first = true;
            foreach (string sub in name.Split(separator, StringSplitOptions.RemoveEmptyEntries))
            {
                if (first)
                {
                    first = false;
                    if (firstLower)
                    {
                        buff.Append(char.ToLower(sub[0]));
                    }
                    else
                    {
                        buff.Append(char.ToUpper(sub[0]));
                    }
                }
                else
                {
                    buff.Append(char.ToUpper(sub[0]));
                }
                buff.Append(sub.Substring(1));
            }
            string aux = buff.ToString();
            if (restrictedNamed.Contains(aux))
            {
                aux = "@" + aux;
            }
            return aux;
        }

        public static Attribute[] GetCustomAttributes(this MemberInfo memberInfo, Type attributeType, bool inherit = true)
        {
            return memberInfo.GetCustomAttributes(inherit)
                             .Where(attributeType.IsInstanceOfType)
                             .Cast<Attribute>()
                             .ToArray();
        }

        public static T[] GetCustomAttributes<T>(this MemberInfo memberInfo, bool inherit = true)
        {
            return memberInfo.GetCustomAttributes(inherit).OfType<T>().ToArray();
        }

        private static readonly HashSet<string> restrictedNamed = new HashSet<string>(new[]
        {
            "namespace", "using", "class", "struct", "enum", "delegate",
            "public", "protected", "private", "internal",
            "static" // .. complete this list :)
        });
    }
}