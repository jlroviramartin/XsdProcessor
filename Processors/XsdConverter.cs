using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XmlSchemaProcessor.Processors
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

            this.AddConverterValueType(v => XmlConvert.ToInt64(v));
            this.AddConverterValueType(v => XmlConvert.ToInt32(v));
            this.AddConverterValueType(v => XmlConvert.ToInt16(v));
            this.AddConverterValueType(v => XmlConvert.ToSByte(v));

            this.AddConverterValueType(v => XmlConvert.ToUInt64(v));
            this.AddConverterValueType(v => XmlConvert.ToUInt32(v));
            this.AddConverterValueType(v => XmlConvert.ToUInt16(v));
            this.AddConverterValueType(v => XmlConvert.ToByte(v));

            this.AddConverterValueType(v => XmlConvert.ToSingle(v));
            this.AddConverterValueType(v => XmlConvert.ToDouble(v));
            this.AddConverterValueType(v => XmlConvert.ToDecimal(v));

            this.AddConverterValueType(v => XmlConvert.ToChar(v));
            this.AddConverterValueType(v => XmlConvert.ToBoolean(v));

            this.AddConverterValueType(v => XmlConvert.ToDateTime(v));
            this.AddConverterValueType(v => XmlConvert.ToDateTimeOffset(v));
            this.AddConverterValueType(v => XmlConvert.ToTimeSpan(v));

            this.AddDefValueType<long>();
            this.AddDefValueType<int>();
            this.AddDefValueType<short>();
            this.AddDefValueType<sbyte>();

            this.AddDefValueType<ulong>();
            this.AddDefValueType<uint>();
            this.AddDefValueType<ushort>();
            this.AddDefValueType<byte>();

            this.AddDefValueType<float>();
            this.AddDefValueType<double>();
            this.AddDefValueType<decimal>();

            this.AddDefValueType<char>();
            this.AddDefValueType<bool>();

            this.AddDefValueType<DateTime>();
            this.AddDefValueType<DateTimeOffset>();
            this.AddDefValueType<TimeSpan>();
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
                    convert = v =>
                    {
                        return enumMap.GetSafe(v);
                    };
                }
                else if (toType.IsGenericType && (toType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                {
                    Type innerType = toType.GetGenericArguments()[0];
                    if (innerType.IsEnum)
                    {
                        Dictionary<string, object> enumMap = new Dictionary<string, object>();
                        foreach (Enum enumValue in Enum.GetValues(innerType).Cast<Enum>())
                        {
                            enumMap.Add(StringValueAttribute.GetValue(enumValue), enumValue);
                        }
                        convert = v =>
                        {
                            return (v != null) ? enumMap.GetSafe(v) : null;
                        };
                    }
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
                }
                else
                {
                    throw new Exception("No se puede convertir.");
                }
                this.map.Add(toType, convert);
            }
            return convert;
        }

        private void AddConverterValueType<T>(Func<string, T> converter) where T : struct
        {
            this.map.Add(typeof(T), v => converter(v));
            this.map.Add(typeof(T?), v => (v != null) ? converter(v) : (T?)null);
        }

        private void AddDefValueType<T>() where T : struct
        {
            this.defValues.Add(typeof(T), default(T));
            this.defValues.Add(typeof(T?), default(T?));
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