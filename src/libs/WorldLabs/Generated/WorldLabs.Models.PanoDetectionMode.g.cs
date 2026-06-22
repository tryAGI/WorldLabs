
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum PanoDetectionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PanoDetectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PanoDetectionMode value)
        {
            return value switch
            {
                PanoDetectionMode.Auto => "auto",
                PanoDetectionMode.False => "false",
                PanoDetectionMode.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PanoDetectionMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PanoDetectionMode.Auto,
                "false" => PanoDetectionMode.False,
                "true" => PanoDetectionMode.True,
                _ => null,
            };
        }
    }
}