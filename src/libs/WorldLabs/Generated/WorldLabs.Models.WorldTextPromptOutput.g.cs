
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Input prompt class for text-conditioned world generation.
    /// </summary>
    public sealed partial class WorldTextPromptOutput
    {
        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="WorldTextPromptOutput" /> class.
        /// </summary>
        /// <param name="textPrompt"></param>
        /// <param name="type">
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorldTextPromptOutput(
            string? textPrompt,
            string? type)
        {
            this.TextPrompt = textPrompt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldTextPromptOutput" /> class.
        /// </summary>
        public WorldTextPromptOutput()
        {
        }

    }
}