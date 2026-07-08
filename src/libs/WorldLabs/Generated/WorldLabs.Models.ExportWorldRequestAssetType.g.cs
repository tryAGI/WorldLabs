
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Asset family to export: 'splats' or 'mesh'.
    /// </summary>
    public enum ExportWorldRequestAssetType
    {
        /// <summary>
        /// 'splats' or 'mesh'.
        /// </summary>
        Mesh,
        /// <summary>
        /// 'splats' or 'mesh'.
        /// </summary>
        Splats,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportWorldRequestAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportWorldRequestAssetType value)
        {
            return value switch
            {
                ExportWorldRequestAssetType.Mesh => "mesh",
                ExportWorldRequestAssetType.Splats => "splats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportWorldRequestAssetType? ToEnum(string value)
        {
            return value switch
            {
                "mesh" => ExportWorldRequestAssetType.Mesh,
                "splats" => ExportWorldRequestAssetType.Splats,
                _ => null,
            };
        }
    }
}