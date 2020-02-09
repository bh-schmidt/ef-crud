using System.Collections.Generic;
using System.Linq;

namespace Utils.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<TEnumerable>(this IEnumerable<TEnumerable> value)
        {
            return value.IsNull() || !value.Any();
        }
    }
}
