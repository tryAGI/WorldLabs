
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Request to prepare a media asset upload.
    /// </summary>
    public sealed partial class MediaAssetPrepareUploadRequest
    {
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
        /// Optional application-specific metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetPrepareUploadRequest" /> class.
        /// </summary>
        /// <param name="fileName">
        /// File name
        /// </param>
        /// <param name="kind">
        /// High-level media type
        /// </param>
        /// <param name="extension">
        /// File extension without dot
        /// </param>
        /// <param name="metadata">
        /// Optional application-specific metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaAssetPrepareUploadRequest(
            string fileName,
            global::WorldLabs.MediaAssetKind kind,
            string? extension,
            object? metadata)
        {
            this.Extension = extension;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.Kind = kind;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetPrepareUploadRequest" /> class.
        /// </summary>
        public MediaAssetPrepareUploadRequest()
        {
        }
    }
}