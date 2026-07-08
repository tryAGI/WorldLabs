
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Requested export format.
    /// </summary>
    public enum ExportWorldRequestFormat
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
    public static class ExportWorldRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportWorldRequestFormat value)
        {
            return value switch
            {
                ExportWorldRequestFormat.Glb => "glb",
                ExportWorldRequestFormat.Ply => "ply",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportWorldRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "glb" => ExportWorldRequestFormat.Glb,
                "ply" => ExportWorldRequestFormat.Ply,
                _ => null,
            };
        }
    }
}