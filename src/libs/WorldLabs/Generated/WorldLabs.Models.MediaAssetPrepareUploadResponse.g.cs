
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Response from preparing a media asset upload.
    /// </summary>
    public sealed partial class MediaAssetPrepareUploadResponse
    {
        /// <summary>
        /// The created media asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_asset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.MediaAsset MediaAsset { get; set; }

        /// <summary>
        /// Upload URL information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.UploadUrlInfo UploadInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetPrepareUploadResponse" /> class.
        /// </summary>
        /// <param name="mediaAsset">
        /// The created media asset
        /// </param>
        /// <param name="uploadInfo">
        /// Upload URL information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaAssetPrepareUploadResponse(
            global::WorldLabs.MediaAsset mediaAsset,
            global::WorldLabs.UploadUrlInfo uploadInfo)
        {
            this.MediaAsset = mediaAsset ?? throw new global::System.ArgumentNullException(nameof(mediaAsset));
            this.UploadInfo = uploadInfo ?? throw new global::System.ArgumentNullException(nameof(uploadInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetPrepareUploadResponse" /> class.
        /// </summary>
        public MediaAssetPrepareUploadResponse()
        {
        }

    }
}