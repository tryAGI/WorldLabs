
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// For world models supporting multi-image (+ text) input.
    /// </summary>
    public sealed partial class MultiImagePromptOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_image_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::WorldLabs.SphericallyLocatedContentOutput> MultiImagePrompt { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reconstruct_images")]
        public bool? ReconstructImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        public string? TextPrompt { get; set; }

        /// <summary>
        /// Default Value: multi-image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiImagePromptOutput" /> class.
        /// </summary>
        /// <param name="multiImagePrompt"></param>
        /// <param name="reconstructImages">
        /// Default Value: false
        /// </param>
        /// <param name="textPrompt"></param>
        /// <param name="type">
        /// Default Value: multi-image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiImagePromptOutput(
            global::System.Collections.Generic.IList<global::WorldLabs.SphericallyLocatedContentOutput> multiImagePrompt,
            bool? reconstructImages,
            string? textPrompt,
            string? type)
        {
            this.MultiImagePrompt = multiImagePrompt ?? throw new global::System.ArgumentNullException(nameof(multiImagePrompt));
            this.ReconstructImages = reconstructImages;
            this.TextPrompt = textPrompt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiImagePromptOutput" /> class.
        /// </summary>
        public MultiImagePromptOutput()
        {
        }

    }
}