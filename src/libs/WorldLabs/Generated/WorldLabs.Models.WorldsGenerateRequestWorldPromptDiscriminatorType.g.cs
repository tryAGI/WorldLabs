
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorldsGenerateRequestWorldPromptDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
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
    public static class WorldsGenerateRequestWorldPromptDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorldsGenerateRequestWorldPromptDiscriminatorType value)
        {
            return value switch
            {
                WorldsGenerateRequestWorldPromptDiscriminatorType.Image => "image",
                WorldsGenerateRequestWorldPromptDiscriminatorType.MultiImage => "multi-image",
                WorldsGenerateRequestWorldPromptDiscriminatorType.Text => "text",
                WorldsGenerateRequestWorldPromptDiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorldsGenerateRequestWorldPromptDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => WorldsGenerateRequestWorldPromptDiscriminatorType.Image,
                "multi-image" => WorldsGenerateRequestWorldPromptDiscriminatorType.MultiImage,
                "text" => WorldsGenerateRequestWorldPromptDiscriminatorType.Text,
                "video" => WorldsGenerateRequestWorldPromptDiscriminatorType.Video,
                _ => null,
            };
        }
    }
}