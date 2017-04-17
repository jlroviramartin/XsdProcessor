using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XmlSchemaProcessor
{
    public class XsdConverter
    {
        public static readonly XsdConverter Instance = new XsdConverter();

        public XsdConverter()
        {
            this.Initialize();
        }

        public T Convert<T>(string value)
        {
            return (T)this.Convert(value, typeof(T));
        }

        public object Convert(string value, Type toType)
        {
            if (value == null)
            {
                return this.GetDefValue(toType);
            }

            Func<string, object> convert = this.GetConverter(toType);

            try
            {
                return convert(value);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

                return this.GetDefValue(toType);
            }
        }

        public T Convert<T>(string value, T defValue)
        {
            return (T)this.Convert(value, typeof(T), defValue);
        }

        public object Convert(string value, Type toType, object defValue)
        {
            if (value == null)
            {
                return defValue;
            }

            Func<string, object> convert = this.GetConverter(toType);

            try
            {
                return convert(value);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

                return defValue;
            }
        }

        #region private

        private void Initialize()
        {
            this.map.Add(typeof(string), v => v);

            this.map.Add(typeof(long), v => XmlConvert.ToInt64(v));
            this.map.Add(typeof(int), v => XmlConvert.ToInt32(v));
            this.map.Add(typeof(short), v => XmlConvert.ToInt16(v));
            this.map.Add(typeof(sbyte), v => XmlConvert.ToSByte(v));

            this.map.Add(typeof(ulong), v => XmlConvert.ToUInt64(v));
            this.map.Add(typeof(uint), v => XmlConvert.ToUInt32(v));
            this.map.Add(typeof(ushort), v => XmlConvert.ToUInt16(v));
            this.map.Add(typeof(byte), v => XmlConvert.ToByte(v));

            this.map.Add(typeof(float), v => XmlConvert.ToSingle(v));
            this.map.Add(typeof(double), v => XmlConvert.ToDouble(v));
            this.map.Add(typeof(decimal), v => XmlConvert.ToDecimal(v));

            this.map.Add(typeof(char), v => XmlConvert.ToChar(v));
            this.map.Add(typeof(bool), v => XmlConvert.ToBoolean(v));

            this.map.Add(typeof(DateTime), v => XmlConvert.ToDateTime(v));
            this.map.Add(typeof(DateTimeOffset), v => XmlConvert.ToDateTimeOffset(v));
            this.map.Add(typeof(TimeSpan), v => XmlConvert.ToTimeSpan(v));

            this.AddDef<long>();
            this.AddDef<int>();
            this.AddDef<short>();
            this.AddDef<sbyte>();

            this.AddDef<ulong>();
            this.AddDef<uint>();
            this.AddDef<ushort>();
            this.AddDef<byte>();

            this.AddDef<float>();
            this.AddDef<double>();
            this.AddDef<decimal>();

            this.AddDef<char>();
            this.AddDef<bool>();

            this.AddDef<DateTime>();
            this.AddDef<DateTimeOffset>();
            this.AddDef<TimeSpan>();
        }

        private object GetDefValue(Type toType)
        {
            object def;
            if (!this.defValues.TryGetValue(toType, out def))
            {
                if (toType.IsEnum)
                {
                    def = Enum.GetValues(toType).Cast<Enum>().First();
                    this.defValues.Add(toType, def);
                }
            }
            return def;
        }

        private Func<string, object> GetConverter(Type toType)
        {
            Func<string, object> convert = this.map.GetSafe(toType);
            if (convert == null)
            {
                if (toType.IsEnum)
                {
                    Dictionary<string, object> enumMap = new Dictionary<string, object>();
                    foreach (Enum enumValue in Enum.GetValues(toType).Cast<Enum>())
                    {
                        enumMap.Add(StringValueAttribute.GetValue(enumValue), enumValue);
                    }
                    Enum defValue = Enum.GetValues(toType).Cast<Enum>().First();
                    convert = v =>
                    {
                        return enumMap.GetSafe(v);
                    };
                    this.map.Add(toType, convert);
                }
                else if (toType.IsGenericType && (toType.GetGenericTypeDefinition() == typeof(IList<>)))
                {
                    char[] separator = { ',' };
                    Type innerType = toType.GetGenericArguments()[0];
                    Type listType = typeof(List<>).MakeGenericType(innerType);
                    convert = v =>
                    {
                        IList list = (IList)Activator.CreateInstance(listType);
                        foreach (string sub in v.Split(separator, StringSplitOptions.RemoveEmptyEntries))
                        {
                            list.Add(this.Convert(sub, innerType));
                        }
                        return list;
                    };
                    this.map.Add(toType, convert);
                }
                else
                {
                    throw new Exception("No se puede convertir.");
                }
            }
            return convert;
        }

        private void AddDef<T>()
        {
            this.defValues.Add(typeof(T), default(T));
        }

        private readonly Dictionary<Type, Func<string, object>> map = new Dictionary<Type, Func<string, object>>();

        private readonly Dictionary<Type, object> defValues = new Dictionary<Type, object>();

        #endregion
    }
}