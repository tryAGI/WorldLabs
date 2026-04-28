
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorldsGenerateRequestModelVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Marble10,
        /// <summary>
        /// 
        /// </summary>
        Marble10Draft,
        /// <summary>
        /// 
        /// </summary>
        Marble11,
        /// <summary>
        /// 
        /// </summary>
        Marble11Plus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorldsGenerateRequestModelVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorldsGenerateRequestModelVariant1 value)
        {
            return value switch
            {
                WorldsGenerateRequestModelVariant1.Marble10 => "marble-1.0",
                WorldsGenerateRequestModelVariant1.Marble10Draft => "marble-1.0-draft",
                WorldsGenerateRequestModelVariant1.Marble11 => "marble-1.1",
                WorldsGenerateRequestModelVariant1.Marble11Plus => "marble-1.1-plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorldsGenerateRequestModelVariant1? ToEnum(string value)
        {
            return value switch
            {
                "marble-1.0" => WorldsGenerateRequestModelVariant1.Marble10,
                "marble-1.0-draft" => WorldsGenerateRequestModelVariant1.Marble10Draft,
                "marble-1.1" => WorldsGenerateRequestModelVariant1.Marble11,
                "marble-1.1-plus" => WorldsGenerateRequestModelVariant1.Marble11Plus,
                _ => null,
            };
        }
    }
}