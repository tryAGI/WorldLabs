
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImagePromptImagePrompt1DiscriminatorSource
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
    public static class ImagePromptImagePrompt1DiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagePromptImagePrompt1DiscriminatorSource value)
        {
            return value switch
            {
                ImagePromptImagePrompt1DiscriminatorSource.DataBase64 => "data_base64",
                ImagePromptImagePrompt1DiscriminatorSource.MediaAsset => "media_asset",
                ImagePromptImagePrompt1DiscriminatorSource.Uri => "uri",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagePromptImagePrompt1DiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "data_base64" => ImagePromptImagePrompt1DiscriminatorSource.DataBase64,
                "media_asset" => ImagePromptImagePrompt1DiscriminatorSource.MediaAsset,
                "uri" => ImagePromptImagePrompt1DiscriminatorSource.Uri,
                _ => null,
            };
        }
    }
}