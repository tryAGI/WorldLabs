
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListWorldsRequestModelVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Marble01Mini,
        /// <summary>
        /// 
        /// </summary>
        Marble01Plus,
        /// <summary>
        /// 
        /// </summary>
        Marble11Plus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListWorldsRequestModelVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorldsRequestModelVariant2 value)
        {
            return value switch
            {
                ListWorldsRequestModelVariant2.Marble01Mini => "Marble 0.1-mini",
                ListWorldsRequestModelVariant2.Marble01Plus => "Marble 0.1-plus",
                ListWorldsRequestModelVariant2.Marble11Plus => "Marble 1.1-plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorldsRequestModelVariant2? ToEnum(string value)
        {
            return value switch
            {
                "Marble 0.1-mini" => ListWorldsRequestModelVariant2.Marble01Mini,
                "Marble 0.1-plus" => ListWorldsRequestModelVariant2.Marble01Plus,
                "Marble 1.1-plus" => ListWorldsRequestModelVariant2.Marble11Plus,
                _ => null,
            };
        }
    }
}