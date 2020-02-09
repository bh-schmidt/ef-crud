using System.Diagnostics.CodeAnalysis;

namespace Utils.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNull([NotNullWhen(false)] this object? value)
        {
            return value == null;
        }
    }
}
