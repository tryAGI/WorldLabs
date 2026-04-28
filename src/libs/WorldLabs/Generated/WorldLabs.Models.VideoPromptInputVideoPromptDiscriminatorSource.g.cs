
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoPromptInputVideoPromptDiscriminatorSource
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
    public static class VideoPromptInputVideoPromptDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoPromptInputVideoPromptDiscriminatorSource value)
        {
            return value switch
            {
                VideoPromptInputVideoPromptDiscriminatorSource.DataBase64 => "data_base64",
                VideoPromptInputVideoPromptDiscriminatorSource.MediaAsset => "media_asset",
                VideoPromptInputVideoPromptDiscriminatorSource.Uri => "uri",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoPromptInputVideoPromptDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "data_base64" => VideoPromptInputVideoPromptDiscriminatorSource.DataBase64,
                "media_asset" => VideoPromptInputVideoPromptDiscriminatorSource.MediaAsset,
                "uri" => VideoPromptInputVideoPromptDiscriminatorSource.Uri,
                _ => null,
            };
        }
    }
}