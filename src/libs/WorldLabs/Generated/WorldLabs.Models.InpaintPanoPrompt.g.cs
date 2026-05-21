
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// For models that inpaint the masked portion of a pano image.
    /// </summary>
    public sealed partial class InpaintPanoPrompt
    {
        /// <summary>
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pano_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.Content PanoImage { get; set; }

        /// <summary>
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pano_mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.Content PanoMask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        public string? TextPrompt { get; set; }

        /// <summary>
        /// Default Value: inpaint-pano
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintPanoPrompt" /> class.
        /// </summary>
        /// <param name="panoImage">
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </param>
        /// <param name="panoMask">
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </param>
        /// <param name="textPrompt"></param>
        /// <param name="type">
        /// Default Value: inpaint-pano
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InpaintPanoPrompt(
            global::WorldLabs.Content panoImage,
            global::WorldLabs.Content panoMask,
            string? textPrompt,
            string? type)
        {
            this.PanoImage = panoImage ?? throw new global::System.ArgumentNullException(nameof(panoImage));
            this.PanoMask = panoMask ?? throw new global::System.ArgumentNullException(nameof(panoMask));
            this.TextPrompt = textPrompt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintPanoPrompt" /> class.
        /// </summary>
        public InpaintPanoPrompt()
        {
        }

    }
}