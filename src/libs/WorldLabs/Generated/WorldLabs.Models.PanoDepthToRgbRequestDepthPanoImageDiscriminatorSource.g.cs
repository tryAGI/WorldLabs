
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource
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
    public static class PanoDepthToRgbRequestDepthPanoImageDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource value)
        {
            return value switch
            {
                PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource.DataBase64 => "data_base64",
                PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource.MediaAsset => "media_asset",
                PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource.Uri => "uri",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "data_base64" => PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource.DataBase64,
                "media_asset" => PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource.MediaAsset,
                "uri" => PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource.Uri,
                _ => null,
            };
        }
    }
}