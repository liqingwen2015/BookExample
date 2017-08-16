#region

using System;
using Newtonsoft.Json;

#endregion

namespace Common
{
    public static class ExtendsionMethod
    {
        public static bool IsEqual(this string self, string value)
        {
            return self.Equals(value, StringComparison.OrdinalIgnoreCase);
        }

        public static string ToJson<T>(this T self)
        {
            return JsonConvert.SerializeObject(self);
        }
    }
}