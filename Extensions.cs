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

using System.Collections.Generic;
using System.Text;

namespace XmlSchemaTest
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
    }
}