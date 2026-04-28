
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// High-level media asset type.
    /// </summary>
    public enum MediaAssetKind
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaAssetKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaAssetKind value)
        {
            return value switch
            {
                MediaAssetKind.Image => "image",
                MediaAssetKind.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaAssetKind? ToEnum(string value)
        {
            return value switch
            {
                "image" => MediaAssetKind.Image,
                "video" => MediaAssetKind.Video,
                _ => null,
            };
        }
    }
}