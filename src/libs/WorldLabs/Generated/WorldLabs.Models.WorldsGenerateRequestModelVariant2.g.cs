
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorldsGenerateRequestModelVariant2
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
    public static class WorldsGenerateRequestModelVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorldsGenerateRequestModelVariant2 value)
        {
            return value switch
            {
                WorldsGenerateRequestModelVariant2.Marble01Mini => "Marble 0.1-mini",
                WorldsGenerateRequestModelVariant2.Marble01Plus => "Marble 0.1-plus",
                WorldsGenerateRequestModelVariant2.Marble11Plus => "Marble 1.1-plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorldsGenerateRequestModelVariant2? ToEnum(string value)
        {
            return value switch
            {
                "Marble 0.1-mini" => WorldsGenerateRequestModelVariant2.Marble01Mini,
                "Marble 0.1-plus" => WorldsGenerateRequestModelVariant2.Marble01Plus,
                "Marble 1.1-plus" => WorldsGenerateRequestModelVariant2.Marble11Plus,
                _ => null,
            };
        }
    }
}