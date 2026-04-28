
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Gaussian splat asset URLs.
    /// </summary>
    public sealed partial class SplatAssets
    {
        /// <summary>
        /// Semantic metadata for the world
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semantics_metadata")]
        public global::WorldLabs.WorldSemanticsMetadata? SemanticsMetadata { get; set; }

        /// <summary>
        /// URLs for SPZ format Gaussian splat files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spz_urls")]
        public global::System.Collections.Generic.Dictionary<string, string>? SpzUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplatAssets" /> class.
        /// </summary>
        /// <param name="semanticsMetadata">
        /// Semantic metadata for the world
        /// </param>
        /// <param name="spzUrls">
        /// URLs for SPZ format Gaussian splat files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplatAssets(
            global::WorldLabs.WorldSemanticsMetadata? semanticsMetadata,
            global::System.Collections.Generic.Dictionary<string, string>? spzUrls)
        {
            this.SemanticsMetadata = semanticsMetadata;
            this.SpzUrls = spzUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplatAssets" /> class.
        /// </summary>
        public SplatAssets()
        {
        }
    }
}