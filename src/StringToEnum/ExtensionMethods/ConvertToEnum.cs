using System;

namespace StringToEnum.ExtensionMethods
{
    public static class ConvertToEnum
    {
        public static T ToEnum<T>(this string value, bool ignoreCase = true)
        {
            return (T) Enum.Parse(typeof (T), value, ignoreCase);
        }
    }
}
