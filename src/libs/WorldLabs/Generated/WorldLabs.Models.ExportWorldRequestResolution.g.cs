
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Splat resolution to convert when exporting splats as PLY.<br/>
    /// Default Value: full_res
    /// </summary>
    public enum ExportWorldRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x100k,
        /// <summary>
        /// 
        /// </summary>
        x150k,
        /// <summary>
        /// 
        /// </summary>
        x500k,
        /// <summary>
        /// 
        /// </summary>
        FullRes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportWorldRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportWorldRequestResolution value)
        {
            return value switch
            {
                ExportWorldRequestResolution.x100k => "100k",
                ExportWorldRequestResolution.x150k => "150k",
                ExportWorldRequestResolution.x500k => "500k",
                ExportWorldRequestResolution.FullRes => "full_res",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportWorldRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "100k" => ExportWorldRequestResolution.x100k,
                "150k" => ExportWorldRequestResolution.x150k,
                "500k" => ExportWorldRequestResolution.x500k,
                "full_res" => ExportWorldRequestResolution.FullRes,
                _ => null,
            };
        }
    }
}