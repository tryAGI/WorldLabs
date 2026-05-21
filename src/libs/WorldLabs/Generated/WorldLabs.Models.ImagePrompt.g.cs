
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Image-to-world generation.<br/>
    /// Generates a world from an image. text_prompt is optional - if not provided,<br/>
    /// it will be generated via recaptioning.<br/>
    /// Recommended image formats: jpg, jpeg, png, webp.
    /// </summary>
    public sealed partial class ImagePrompt
    {
        /// <summary>
        /// If True, use text_prompt as-is without recaptioning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_recaption")]
        public bool? DisableRecaption { get; set; }

        /// <summary>
        /// Image content for world generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.ImagePrompt1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.ImagePrompt1 ImagePrompt1 { get; set; }

        /// <summary>
        /// Whether the provided image is already a panorama
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_pano")]
        public bool? IsPano { get; set; }

        /// <summary>
        /// Optional text guidance (auto-generated if not provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        public string? TextPrompt { get; set; }

        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePrompt" /> class.
        /// </summary>
        /// <param name="imagePrompt1">
        /// Image content for world generation
        /// </param>
        /// <param name="disableRecaption">
        /// If True, use text_prompt as-is without recaptioning
        /// </param>
        /// <param name="isPano">
        /// Whether the provided image is already a panorama
        /// </param>
        /// <param name="textPrompt">
        /// Optional text guidance (auto-generated if not provided)
        /// </param>
        /// <param name="type">
        /// Default Value: image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagePrompt(
            global::WorldLabs.ImagePrompt1 imagePrompt1,
            bool? disableRecaption,
            bool? isPano,
            string? textPrompt,
            string? type)
        {
            this.DisableRecaption = disableRecaption;
            this.ImagePrompt1 = imagePrompt1;
            this.IsPano = isPano;
            this.TextPrompt = textPrompt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePrompt" /> class.
        /// </summary>
        public ImagePrompt()
        {
        }

    }
}