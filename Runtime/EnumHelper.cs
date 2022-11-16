using System;

namespace beio.Helper
{
    public static partial class EnumHelper
    {
        public static E ToEnum<E>(this object value) where E : unmanaged, Enum
        {
            return (E)value;
        }
        public static E ToEnum<E>(this string value) where E : unmanaged, Enum
        {
            if (Enum.TryParse(value, out E result) == true)
                return result;
            return default;
        }
    }
}