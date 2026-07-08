
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Exported file format
    /// </summary>
    public enum ExportWorldResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Glb,
        /// <summary>
        /// 
        /// </summary>
        Ply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportWorldResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportWorldResultFormat value)
        {
            return value switch
            {
                ExportWorldResultFormat.Glb => "glb",
                ExportWorldResultFormat.Ply => "ply",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportWorldResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "glb" => ExportWorldResultFormat.Glb,
                "ply" => ExportWorldResultFormat.Ply,
                _ => null,
            };
        }
    }
}