
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Exported asset family
    /// </summary>
    public enum ExportWorldResultAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Mesh,
        /// <summary>
        /// 
        /// </summary>
        Splats,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportWorldResultAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportWorldResultAssetType value)
        {
            return value switch
            {
                ExportWorldResultAssetType.Mesh => "mesh",
                ExportWorldResultAssetType.Splats => "splats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportWorldResultAssetType? ToEnum(string value)
        {
            return value switch
            {
                "mesh" => ExportWorldResultAssetType.Mesh,
                "splats" => ExportWorldResultAssetType.Splats,
                _ => null,
            };
        }
    }
}