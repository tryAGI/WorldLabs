
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Reference to a previously uploaded MediaAsset.
    /// </summary>
    public sealed partial class MediaAssetReference
    {
        /// <summary>
        /// ID of a MediaAsset resource previously created and marked READY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaAssetId { get; set; }

        /// <summary>
        /// Default Value: media_asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetReference" /> class.
        /// </summary>
        /// <param name="mediaAssetId">
        /// ID of a MediaAsset resource previously created and marked READY
        /// </param>
        /// <param name="source">
        /// Default Value: media_asset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaAssetReference(
            string mediaAssetId,
            string? source)
        {
            this.MediaAssetId = mediaAssetId ?? throw new global::System.ArgumentNullException(nameof(mediaAssetId));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetReference" /> class.
        /// </summary>
        public MediaAssetReference()
        {
        }
    }
}