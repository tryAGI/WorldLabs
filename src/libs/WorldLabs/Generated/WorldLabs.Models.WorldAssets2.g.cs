
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Downloadable outputs of world generation.
    /// </summary>
    public sealed partial class WorldAssets2
    {
        /// <summary>
        /// AI-generated description of the world
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// Imagery assets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagery")]
        public global::WorldLabs.ImageryAssets? Imagery { get; set; }

        /// <summary>
        /// Mesh assets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh")]
        public global::WorldLabs.MeshAssets? Mesh { get; set; }

        /// <summary>
        /// Gaussian splat assets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splats")]
        public global::WorldLabs.SplatAssets? Splats { get; set; }

        /// <summary>
        /// Thumbnail URL for the world
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldAssets2" /> class.
        /// </summary>
        /// <param name="caption">
        /// AI-generated description of the world
        /// </param>
        /// <param name="imagery">
        /// Imagery assets
        /// </param>
        /// <param name="mesh">
        /// Mesh assets
        /// </param>
        /// <param name="splats">
        /// Gaussian splat assets
        /// </param>
        /// <param name="thumbnailUrl">
        /// Thumbnail URL for the world
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorldAssets2(
            string? caption,
            global::WorldLabs.ImageryAssets? imagery,
            global::WorldLabs.MeshAssets? mesh,
            global::WorldLabs.SplatAssets? splats,
            string? thumbnailUrl)
        {
            this.Caption = caption;
            this.Imagery = imagery;
            this.Mesh = mesh;
            this.Splats = splats;
            this.ThumbnailUrl = thumbnailUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldAssets2" /> class.
        /// </summary>
        public WorldAssets2()
        {
        }
    }
}