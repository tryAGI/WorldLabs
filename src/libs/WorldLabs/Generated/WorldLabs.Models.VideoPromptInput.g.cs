
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Video-to-world generation.<br/>
    /// Generates a world from a video. text_prompt is optional.<br/>
    /// Recommended video formats: mp4, webm, mov, avi.<br/>
    /// Maximum video size: 100MB.
    /// </summary>
    public sealed partial class VideoPromptInput
    {
        /// <summary>
        /// If True, use text_prompt as-is without recaptioning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_recaption")]
        public bool? DisableRecaption { get; set; }

        /// <summary>
        /// Optional text guidance (auto-generated if not provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        public string? TextPrompt { get; set; }

        /// <summary>
        /// Default Value: video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Video content for world generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.VideoPromptJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.VideoPrompt VideoPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPromptInput" /> class.
        /// </summary>
        /// <param name="videoPrompt">
        /// Video content for world generation
        /// </param>
        /// <param name="disableRecaption">
        /// If True, use text_prompt as-is without recaptioning
        /// </param>
        /// <param name="textPrompt">
        /// Optional text guidance (auto-generated if not provided)
        /// </param>
        /// <param name="type">
        /// Default Value: video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoPromptInput(
            global::WorldLabs.VideoPrompt videoPrompt,
            bool? disableRecaption,
            string? textPrompt,
            string? type)
        {
            this.DisableRecaption = disableRecaption;
            this.TextPrompt = textPrompt;
            this.Type = type;
            this.VideoPrompt = videoPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPromptInput" /> class.
        /// </summary>
        public VideoPromptInput()
        {
        }
    }
}