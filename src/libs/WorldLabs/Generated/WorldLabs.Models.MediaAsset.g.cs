
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// A user-uploaded media asset stored in managed storage.<br/>
    /// MediaAssets can be images, videos, or binary blobs that are used<br/>
    /// as input to world generation.
    /// </summary>
    public sealed partial class MediaAsset
    {
        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// File extension without dot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// High-level media type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.MediaAssetKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.MediaAssetKind Kind { get; set; }

        /// <summary>
        /// Server-generated media asset identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaAssetId { get; set; }

        /// <summary>
        /// Optional application-specific metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAsset" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="fileName">
        /// File name
        /// </param>
        /// <param name="kind">
        /// High-level media type
        /// </param>
        /// <param name="mediaAssetId">
        /// Server-generated media asset identifier
        /// </param>
        /// <param name="extension">
        /// File extension without dot
        /// </param>
        /// <param name="metadata">
        /// Optional application-specific metadata
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaAsset(
            global::System.DateTime createdAt,
            string fileName,
            global::WorldLabs.MediaAssetKind kind,
            string mediaAssetId,
            string? extension,
            object? metadata,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Extension = extension;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.Kind = kind;
            this.MediaAssetId = mediaAssetId ?? throw new global::System.ArgumentNullException(nameof(mediaAssetId));
            this.Metadata = metadata;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAsset" /> class.
        /// </summary>
        public MediaAsset()
        {
        }
    }
}