
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorldWorldPromptVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        DepthPano,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        InpaintPano,
        /// <summary>
        /// 
        /// </summary>
        MultiImage,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorldWorldPromptVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorldWorldPromptVariant1DiscriminatorType value)
        {
            return value switch
            {
                WorldWorldPromptVariant1DiscriminatorType.DepthPano => "depth-pano",
                WorldWorldPromptVariant1DiscriminatorType.Image => "image",
                WorldWorldPromptVariant1DiscriminatorType.InpaintPano => "inpaint-pano",
                WorldWorldPromptVariant1DiscriminatorType.MultiImage => "multi-image",
                WorldWorldPromptVariant1DiscriminatorType.Text => "text",
                WorldWorldPromptVariant1DiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorldWorldPromptVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "depth-pano" => WorldWorldPromptVariant1DiscriminatorType.DepthPano,
                "image" => WorldWorldPromptVariant1DiscriminatorType.Image,
                "inpaint-pano" => WorldWorldPromptVariant1DiscriminatorType.InpaintPano,
                "multi-image" => WorldWorldPromptVariant1DiscriminatorType.MultiImage,
                "text" => WorldWorldPromptVariant1DiscriminatorType.Text,
                "video" => WorldWorldPromptVariant1DiscriminatorType.Video,
                _ => null,
            };
        }
    }
}