
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SphericallyLocatedContentInputContentDiscriminatorSource
    {
        /// <summary>
        /// 
        /// </summary>
        DataBase64,
        /// <summary>
        /// 
        /// </summary>
        MediaAsset,
        /// <summary>
        /// 
        /// </summary>
        Uri,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SphericallyLocatedContentInputContentDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SphericallyLocatedContentInputContentDiscriminatorSource value)
        {
            return value switch
            {
                SphericallyLocatedContentInputContentDiscriminatorSource.DataBase64 => "data_base64",
                SphericallyLocatedContentInputContentDiscriminatorSource.MediaAsset => "media_asset",
                SphericallyLocatedContentInputContentDiscriminatorSource.Uri => "uri",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SphericallyLocatedContentInputContentDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "data_base64" => SphericallyLocatedContentInputContentDiscriminatorSource.DataBase64,
                "media_asset" => SphericallyLocatedContentInputContentDiscriminatorSource.MediaAsset,
                "uri" => SphericallyLocatedContentInputContentDiscriminatorSource.Uri,
                _ => null,
            };
        }
    }
}