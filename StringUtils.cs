using System;
using System.Text;

namespace XmlSchemaProcessor
{
    public static class StringUtils
    {
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
    }
}