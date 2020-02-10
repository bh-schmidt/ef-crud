using System;

namespace Utils.Extensions
{
    public static class Int32Extentions
    {
        public static TEnum ToEnum<TEnum>(this int value) where TEnum : Enum =>
            Enum.ToObject(typeof(TEnum), value).CastTo<TEnum>();
    }
}
