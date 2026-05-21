
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagePromptImagePrompt1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.ImagePromptImagePrompt1DiscriminatorSourceJsonConverter))]
        public global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePromptImagePrompt1Discriminator" /> class.
        /// </summary>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagePromptImagePrompt1Discriminator(
            global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSource? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePromptImagePrompt1Discriminator" /> class.
        /// </summary>
        public ImagePromptImagePrompt1Discriminator()
        {
        }

    }
}