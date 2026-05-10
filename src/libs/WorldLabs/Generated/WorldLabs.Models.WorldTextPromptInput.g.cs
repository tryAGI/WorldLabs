
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Text-to-world generation.<br/>
    /// Generates a world from a text description. text_prompt is REQUIRED.
    /// </summary>
    public sealed partial class WorldTextPromptInput
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
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldTextPromptInput" /> class.
        /// </summary>
        /// <param name="disableRecaption">
        /// If True, use text_prompt as-is without recaptioning
        /// </param>
        /// <param name="textPrompt">
        /// Optional text guidance (auto-generated if not provided)
        /// </param>
        /// <param name="type">
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorldTextPromptInput(
            bool? disableRecaption,
            string? textPrompt,
            string? type)
        {
            this.DisableRecaption = disableRecaption;
            this.TextPrompt = textPrompt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldTextPromptInput" /> class.
        /// </summary>
        public WorldTextPromptInput()
        {
        }

    }
}