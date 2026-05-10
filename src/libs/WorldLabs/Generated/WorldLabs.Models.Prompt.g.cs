
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// For world models generating a world from a single image (+ text).<br/>
    /// Images can be generated using the :image-generation method.<br/>
    /// If no text prompt is provided, it will be generated via recaption.
    /// </summary>
    public sealed partial class Prompt
    {
        /// <summary>
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.Content ImagePrompt { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_pano")]
        public bool? IsPano { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="Prompt" /> class.
        /// </summary>
        /// <param name="imagePrompt">
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </param>
        /// <param name="isPano">
        /// Default Value: false
        /// </param>
        /// <param name="textPrompt"></param>
        /// <param name="type">
        /// Default Value: image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prompt(
            global::WorldLabs.Content imagePrompt,
            bool? isPano,
            string? textPrompt,
            string? type)
        {
            this.ImagePrompt = imagePrompt ?? throw new global::System.ArgumentNullException(nameof(imagePrompt));
            this.IsPano = isPano;
            this.TextPrompt = textPrompt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt" /> class.
        /// </summary>
        public Prompt()
        {
        }

    }
}