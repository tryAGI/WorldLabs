
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Multi-image-to-world generation.<br/>
    /// Generates a world from multiple images. text_prompt is optional.<br/>
    /// Recommended image formats: jpg, jpeg, png, webp.
    /// </summary>
    public sealed partial class MultiImagePromptInput
    {
        /// <summary>
        /// If True, use text_prompt as-is without recaptioning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_recaption")]
        public bool? DisableRecaption { get; set; }

        /// <summary>
        /// List of images with optional spherical locations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_image_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::WorldLabs.SphericallyLocatedContentInput> MultiImagePrompt { get; set; }

        /// <summary>
        /// Whether to use reconstruction mode (allows up to 8 images, otherwise 4)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reconstruct_images")]
        public bool? ReconstructImages { get; set; }

        /// <summary>
        /// Optional text guidance (auto-generated if not provided)
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
        /// Initializes a new instance of the <see cref="MultiImagePromptInput" /> class.
        /// </summary>
        /// <param name="multiImagePrompt">
        /// List of images with optional spherical locations
        /// </param>
        /// <param name="disableRecaption">
        /// If True, use text_prompt as-is without recaptioning
        /// </param>
        /// <param name="reconstructImages">
        /// Whether to use reconstruction mode (allows up to 8 images, otherwise 4)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="textPrompt">
        /// Optional text guidance (auto-generated if not provided)
        /// </param>
        /// <param name="type">
        /// Default Value: multi-image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiImagePromptInput(
            global::System.Collections.Generic.IList<global::WorldLabs.SphericallyLocatedContentInput> multiImagePrompt,
            bool? disableRecaption,
            bool? reconstructImages,
            string? textPrompt,
            string? type)
        {
            this.DisableRecaption = disableRecaption;
            this.MultiImagePrompt = multiImagePrompt ?? throw new global::System.ArgumentNullException(nameof(multiImagePrompt));
            this.ReconstructImages = reconstructImages;
            this.TextPrompt = textPrompt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiImagePromptInput" /> class.
        /// </summary>
        public MultiImagePromptInput()
        {
        }
    }
}