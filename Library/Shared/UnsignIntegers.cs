﻿using Newtonsoft.Json;
using System;

namespace XyLang.Library
{
    [JsonConverter(typeof(U8Converter))]
    public class U8
    {
        private byte v;
        public U8() { }
        public U8(object o)
        {
            switch (o)
            {
                case sbyte _:
                case short _:
                case int _:
                case long _:
                case I8 _:
                case I16 _:
                case I32 _:
                case I64 _:

                case byte _:
                case ushort _:
                case uint _:
                case ulong _:
                case U8 _:
                case U16 _:
                case U32 _:
                case U64 _:

                case float _:
                case double _:
                case F32 _:
                case F64 _:

                case string _:
                case Str _:
                    v = Convert.ToByte(o);
                    break;
                default:
                    throw new Exception("not support type");
            }
        }
        public U8(Str value, I32 fromBase) => v = Convert.ToByte(value, fromBase);
        public Str ToBase(I32 fromBase) => Convert.ToString(v, fromBase);

        public static implicit operator U8(byte it) => new U8(it);
        public static implicit operator byte(U8 it) => it.v;

        public static U8 operator +(U8 a, U8 b) => new U8(a.v + b.v);
        public static U8 operator -(U8 a, U8 b) => new U8(a.v - b.v);
        public static U8 operator *(U8 a, U8 b) => new U8(a.v * b.v);
        public static U8 operator /(U8 a, U8 b) => new U8(a.v / b.v);
        public static U8 operator %(U8 a, U8 b) => new U8(a.v % b.v);

        public static bool operator <(U8 a, U8 b) => a.v < b.v;
        public static bool operator <=(U8 a, U8 b) => a.v <= b.v;
        public static bool operator >(U8 a, U8 b) => a.v > b.v;
        public static bool operator >=(U8 a, U8 b) => a.v >= b.v;
        public static bool operator ==(U8 a, U8 b) => a.v == b.v;
        public static bool operator !=(U8 a, U8 b) => a.v != b.v;

        public override bool Equals(object o)
        {
            if (o is U8 b)
            {
                return v == b.v;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(U8 b) => b != null && v == b.v;

        public override int GetHashCode() => v.GetHashCode();

        public TypeCode GetTypeCode() => v.GetTypeCode();

        public override string ToString() => v.ToString();

        public string ToString(string format) => v.ToString(format);

#if !UNITY_FLASH
        public string ToString(IFormatProvider provider) => v.ToString(provider);

        public string ToString(string format, IFormatProvider provider) => v.ToString(format, provider);
#endif
        public Str ToStr() => ToString();
        public Str ToStr(Str format) => ToString(format);

        public I8 ToI8() => new I8(v);
        public I16 ToI16() => new I16(v);
        public I32 ToI32() => new I32(v);
        public I64 ToI64() => new I64(v);
        public U8 ToU8() => new U8(v);
        public U16 ToU16() => new U16(v);
        public U32 ToU32() => new U32(v);
        public U64 ToU64() => new U64(v);
        public F32 ToF32() => new F32(v);
        public F64 ToF64() => new F64(v);

        public byte ToValue() => v;
    }

    [JsonConverter(typeof(U16Converter))]
    public class U16
    {
        private ushort v;
        public U16() { }
        public U16(object o)
        {
            switch (o)
            {
                case sbyte _:
                case short _:
                case int _:
                case long _:
                case I8 _:
                case I16 _:
                case I32 _:
                case I64 _:

                case byte _:
                case ushort _:
                case uint _:
                case ulong _:
                case U8 _:
                case U16 _:
                case U32 _:
                case U64 _:

                case float _:
                case double _:
                case F32 _:
                case F64 _:

                case string _:
                case Str _:
                    v = Convert.ToUInt16(o);
                    break;
                default:
                    throw new Exception("not support type");
            }
        }
        public U16(Str value, I32 fromBase) => v = Convert.ToUInt16(value, fromBase);
        public Str ToBase(I32 fromBase) => Convert.ToString(v, fromBase);

        public static implicit operator U16(ushort it) => new U16(it);
        public static implicit operator ushort(U16 it) => it.v;

        public static U16 operator +(U16 a, U16 b) => new U16(a.v + b.v);
        public static U16 operator -(U16 a, U16 b) => new U16(a.v - b.v);
        public static U16 operator *(U16 a, U16 b) => new U16(a.v * b.v);
        public static U16 operator /(U16 a, U16 b) => new U16(a.v / b.v);
        public static U16 operator %(U16 a, U16 b) => new U16(a.v % b.v);

        public static bool operator <(U16 a, U16 b) => a.v < b.v;
        public static bool operator <=(U16 a, U16 b) => a.v <= b.v;
        public static bool operator >(U16 a, U16 b) => a.v > b.v;
        public static bool operator >=(U16 a, U16 b) => a.v >= b.v;
        public static bool operator ==(U16 a, U16 b) => a.v == b.v;
        public static bool operator !=(U16 a, U16 b) => a.v != b.v;

        public override bool Equals(object o)
        {
            if (o is U16 b)
            {
                return v == b.v;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(U16 b) => b != null && v == b.v;

        public override int GetHashCode() => v.GetHashCode();

        public TypeCode GetTypeCode() => v.GetTypeCode();

        public override string ToString() => v.ToString();

        public string ToString(string format) => v.ToString(format);

#if !UNITY_FLASH
        public string ToString(IFormatProvider provider) => v.ToString(provider);

        public string ToString(string format, IFormatProvider provider) => v.ToString(format, provider);
#endif
        public Str ToStr() => ToString();
        public Str ToStr(Str format) => ToString(format);

        public I8 ToI8() => new I8(v);
        public I16 ToI16() => new I16(v);
        public I32 ToI32() => new I32(v);
        public I64 ToI64() => new I64(v);
        public U8 ToU8() => new U8(v);
        public U16 ToU16() => new U16(v);
        public U32 ToU32() => new U32(v);
        public U64 ToU64() => new U64(v);
        public F32 ToF32() => new F32(v);
        public F64 ToF64() => new F64(v);

        public ushort ToValue() => v;
    }

    [JsonConverter(typeof(U32Converter))]
    public class U32
    {
        private uint v;
        public U32() { }
        public U32(object o)
        {
            switch (o)
            {
                case sbyte _:
                case short _:
                case int _:
                case long _:
                case I8 _:
                case I16 _:
                case I32 _:
                case I64 _:

                case byte _:
                case ushort _:
                case uint _:
                case ulong _:
                case U8 _:
                case U16 _:
                case U32 _:
                case U64 _:

                case float _:
                case double _:
                case F32 _:
                case F64 _:

                case string _:
                case Str _:
                    v = Convert.ToUInt32(o);
                    break;
                default:
                    throw new Exception("not support type");
            }
        }
        public U32(Str value, I32 fromBase) => v = Convert.ToUInt32(value, fromBase);
        public Str ToBase(I32 fromBase) => Convert.ToString(v, fromBase);

        public static implicit operator U32(uint it) => new U32(it);
        public static implicit operator uint(U32 it) => it.v;

        public static U32 operator +(U32 a, U32 b) => new U32(a.v + b.v);
        public static U32 operator -(U32 a, U32 b) => new U32(a.v - b.v);
        public static U32 operator *(U32 a, U32 b) => new U32(a.v * b.v);
        public static U32 operator /(U32 a, U32 b) => new U32(a.v / b.v);
        public static U32 operator %(U32 a, U32 b) => new U32(a.v % b.v);

        public static bool operator <(U32 a, U32 b) => a.v < b.v;
        public static bool operator <=(U32 a, U32 b) => a.v <= b.v;
        public static bool operator >(U32 a, U32 b) => a.v > b.v;
        public static bool operator >=(U32 a, U32 b) => a.v >= b.v;
        public static bool operator ==(U32 a, U32 b) => a.v == b.v;
        public static bool operator !=(U32 a, U32 b) => a.v != b.v;

        public override bool Equals(object o)
        {
            if (o is U32 b)
            {
                return v == b.v;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(U32 b) => b != null && v == b.v;

        public override int GetHashCode() => v.GetHashCode();

        public TypeCode GetTypeCode() => v.GetTypeCode();

        public override string ToString() => v.ToString();

        public string ToString(string format) => v.ToString(format);

#if !UNITY_FLASH
        public string ToString(IFormatProvider provider) => v.ToString(provider);

        public string ToString(string format, IFormatProvider provider) => v.ToString(format, provider);
#endif
        public Str ToStr() => ToString();
        public Str ToStr(Str format) => ToString(format);

        public I8 ToI8() => new I8(v);
        public I16 ToI16() => new I16(v);
        public I32 ToI32() => new I32(v);
        public I64 ToI64() => new I64(v);
        public U8 ToU8() => new U8(v);
        public U16 ToU16() => new U16(v);
        public U32 ToU32() => new U32(v);
        public U64 ToU64() => new U64(v);
        public F32 ToF32() => new F32(v);
        public F64 ToF64() => new F64(v);

        public uint ToValue() => v;
    }

    [JsonConverter(typeof(U64Converter))]
    public class U64
    {
        private ulong v;
        public U64() { }
        public U64(object o)
        {
            switch (o)
            {
                case sbyte _:
                case short _:
                case int _:
                case long _:
                case I8 _:
                case I16 _:
                case I32 _:
                case I64 _:

                case byte _:
                case ushort _:
                case uint _:
                case ulong _:
                case U8 _:
                case U16 _:
                case U32 _:
                case U64 _:

                case float _:
                case double _:
                case F32 _:
                case F64 _:

                case string _:
                case Str _:
                    v = Convert.ToUInt64(o);
                    break;
                default:
                    throw new Exception("not support type");
            }
        }
        public U64(Str value, I32 fromBase) => v = Convert.ToUInt64(value, fromBase);
        public Str ToBase(I32 fromBase) => Convert.ToString((long)v, fromBase);

        public static implicit operator U64(ulong it) => new U64(it);
        public static implicit operator ulong(U64 it) => it.v;

        public static U64 operator +(U64 a, U64 b) => new U64(a.v + b.v);
        public static U64 operator -(U64 a, U64 b) => new U64(a.v - b.v);
        public static U64 operator *(U64 a, U64 b) => new U64(a.v * b.v);
        public static U64 operator /(U64 a, U64 b) => new U64(a.v / b.v);
        public static U64 operator %(U64 a, U64 b) => new U64(a.v % b.v);

        public static bool operator <(U64 a, U64 b) => a.v < b.v;
        public static bool operator <=(U64 a, U64 b) => a.v <= b.v;
        public static bool operator >(U64 a, U64 b) => a.v > b.v;
        public static bool operator >=(U64 a, U64 b) => a.v >= b.v;
        public static bool operator ==(U64 a, U64 b) => a.v == b.v;
        public static bool operator !=(U64 a, U64 b) => a.v != b.v;

        public override bool Equals(object o)
        {
            if (o is U64 b)
            {
                return v == b.v;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(U64 b) => b != null && v == b.v;

        public override int GetHashCode() => v.GetHashCode();

        public TypeCode GetTypeCode() => v.GetTypeCode();

        public override string ToString() => v.ToString();

        public string ToString(string format) => v.ToString(format);

#if !UNITY_FLASH
        public string ToString(IFormatProvider provider) => v.ToString(provider);

        public string ToString(string format, IFormatProvider provider) => v.ToString(format, provider);
#endif
        public Str ToStr() => ToString();
        public Str ToStr(Str format) => ToString(format);

        public I8 ToI8() => new I8(v);
        public I16 ToI16() => new I16(v);
        public I32 ToI32() => new I32(v);
        public I64 ToI64() => new I64(v);
        public U8 ToU8() => new U8(v);
        public U16 ToU16() => new U16(v);
        public U32 ToU32() => new U32(v);
        public U64 ToU64() => new U64(v);
        public F32 ToF32() => new F32(v);
        public F64 ToF64() => new F64(v);

        public ulong ToValue() => v;
    }
    public class U8Converter : JsonConverter<U8>
    {
        public override void WriteJson(JsonWriter writer, U8 value, JsonSerializer serializer) => writer.WriteValue(value);

        public override U8 ReadJson(JsonReader reader, Type objectType, U8 existingValue, bool hasExistingValue, JsonSerializer serializer) => new U8((byte)reader.Value);
    }
    public class U16Converter : JsonConverter<U16>
    {
        public override void WriteJson(JsonWriter writer, U16 value, JsonSerializer serializer) => writer.WriteValue(value);

        public override U16 ReadJson(JsonReader reader, Type objectType, U16 existingValue, bool hasExistingValue, JsonSerializer serializer) => new U16((ushort)reader.Value);
    }
    public class U32Converter : JsonConverter<U32>
    {
        public override void WriteJson(JsonWriter writer, U32 value, JsonSerializer serializer) => writer.WriteValue(value);

        public override U32 ReadJson(JsonReader reader, Type objectType, U32 existingValue, bool hasExistingValue, JsonSerializer serializer) => new U32((uint)reader.Value);
    }
    public class U64Converter : JsonConverter<U64>
    {
        public override void WriteJson(JsonWriter writer, U64 value, JsonSerializer serializer) => writer.WriteValue(value);

        public override U64 ReadJson(JsonReader reader, Type objectType, U64 existingValue, bool hasExistingValue, JsonSerializer serializer) => new U64((ulong)reader.Value);
    }
}
