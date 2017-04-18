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

using System.Text;

namespace XmlSchemaProcessor.Processors
{
    public static class ProcessorUtils
    {
        public static string PrepareNetDocumentation(string doc1, string doc2)
        {
            if (string.IsNullOrWhiteSpace(doc1))
            {
                return PrepareNetDocumentation(doc2);
            }
            if (string.IsNullOrWhiteSpace(doc2))
            {
                return PrepareNetDocumentation(doc1);
            }
            StringBuilder buff = new StringBuilder();
            buff.AppendLine(doc1);
            buff.AppendLine(doc2);
            return PrepareNetDocumentation(buff.ToString());
        }

        public static string PrepareNetDocumentation(string doc)
        {
            doc = doc.RemoveEmptyLines().Replace('\t', ' ');

            if (string.IsNullOrWhiteSpace(doc))
            {
                return string.Empty;
            }
            StringBuilder buff = new StringBuilder();
            buff.AppendLine("/// <summary>");
            buff.Append("/// ").AppendLine(doc.Replace("\n", "\n/// "));
            buff.AppendLine("/// </summary>");
            return buff.ToString();
        }
    }
}