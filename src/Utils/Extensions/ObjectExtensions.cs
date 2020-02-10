using System.Diagnostics.CodeAnalysis;

namespace Utils.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNull([NotNullWhen(false)] this object? value)
        {
            return value == null;
        }

        public static TObject CastTo<TObject>(this object value)
        {
            return (TObject)value;
        }
    }
}
