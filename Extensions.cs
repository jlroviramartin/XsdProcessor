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
        public static bool EqualsIgnoreCase(this string str1, string str2)
        {
            if (str1 == null)
            {
                return str2 == null;
            }
            if (str2 == null)
            {
                return false;
            }
            return str1.ToUpperInvariant().Equals(str2.ToUpperInvariant());
        }

        public static void PushAll<T>(this Stack<T> stack, IEnumerable<T> enumer)
        {
            foreach (T value in enumer)
            {
                stack.Push(value);
            }
        }

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

        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> enumer)
        {
            foreach (T value in enumer)
            {
                collection.Add(value);
            }
        }

        public static void AppendLine(this StringBuilder buff, object obj)
        {
            buff.AppendLine((obj != null) ? obj.ToString() : null);
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

        public static string ToPropertyName(this string name)
        {
            return FirstUpper(name);
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

        public static string RemoveEmptyLines(this string text)
        {
            return text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                       .Where(s => !string.IsNullOrWhiteSpace(s))
                       .Aggregate(String.Empty, (a, b) => a != String.Empty ? (a + Environment.NewLine + b) : b);
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
                             .Where(attributeType.GetTypeInfo().IsInstanceOfType)
                             .Cast<Attribute>()
                             .ToArray();
        }

        public static T[] GetCustomAttributes<T>(this MemberInfo memberInfo, bool inherit = true)
        {
            return memberInfo.GetCustomAttributes(inherit).OfType<T>().ToArray();
        }

        public const string INDENT = "    ";
        public const string OPEN = "{";
        public const string CLOSE = "}";

        public static string Indent(this string str, string indent = INDENT)
        {
            return indent + str.Replace(Environment.NewLine, Environment.NewLine + indent);
        }

        public static string Indent(object obj, string indent = INDENT)
        {
            return ((obj != null) ? obj.ToString().Indent(indent) : "");
        }

        public static StringBuilder AppendIndent(this StringBuilder buff, object obj, string indent = INDENT)
        {
            return buff.Append(Indent(obj, indent));
        }

        public static StringBuilder AppendLineSafe(this StringBuilder buff)
        {
            if (buff.Length > 0)
            {
                if (buff.Length >= Environment.NewLine.Length)
                {
                    bool lastIsNewLine = true;
                    for (int i = 0; i < Environment.NewLine.Length; i++)
                    {
                        if (Environment.NewLine[i] != buff[buff.Length - Environment.NewLine.Length + i])
                        {
                            lastIsNewLine = false;
                            break;
                        }
                    }
                    if (lastIsNewLine)
                    {
                        return buff;
                    }
                }
                buff.AppendLine();
            }
            return buff;
        }

        public static StringBuilder AppendRegion(this StringBuilder buff, object obj, string indent = INDENT, string open = OPEN, string close = CLOSE)
        {
            buff.Append(open);

            buff.AppendLine();
            buff.AppendIndent(obj);

            buff.AppendLine();
            buff.Append(close);

            return buff;
        }

        #region private

        private static readonly HashSet<string> restrictedNamed = new HashSet<string>(new[]
        {
            "namespace", "using", "class", "struct", "enum", "delegate",
            "public", "protected", "private", "internal",
            "static" // .. complete this list :)
        });

        #endregion
    }
}