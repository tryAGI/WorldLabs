
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// For world models supporting video (+ text) input.
    /// </summary>
    public sealed partial class VideoPromptOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        public string? TextPrompt { get; set; }

        /// <summary>
        /// Default Value: video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.Content VideoPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPromptOutput" /> class.
        /// </summary>
        /// <param name="videoPrompt">
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </param>
        /// <param name="textPrompt"></param>
        /// <param name="type">
        /// Default Value: video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoPromptOutput(
            global::WorldLabs.Content videoPrompt,
            string? textPrompt,
            string? type)
        {
            this.TextPrompt = textPrompt;
            this.Type = type;
            this.VideoPrompt = videoPrompt ?? throw new global::System.ArgumentNullException(nameof(videoPrompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPromptOutput" /> class.
        /// </summary>
        public VideoPromptOutput()
        {
        }
    }
}