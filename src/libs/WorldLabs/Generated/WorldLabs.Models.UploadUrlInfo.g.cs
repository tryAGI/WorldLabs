
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Information required to upload raw bytes directly to storage.
    /// </summary>
    public sealed partial class UploadUrlInfo
    {
        /// <summary>
        /// Optional curl example for convenience
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("curl_example")]
        public string? CurlExample { get; set; }

        /// <summary>
        /// Headers that MUST be included when uploading (e.g. Content-Type)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequiredHeaders { get; set; }

        /// <summary>
        /// Upload method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadMethod { get; set; }

        /// <summary>
        /// Signed URL for uploading bytes via PUT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadUrlInfo" /> class.
        /// </summary>
        /// <param name="uploadMethod">
        /// Upload method
        /// </param>
        /// <param name="uploadUrl">
        /// Signed URL for uploading bytes via PUT
        /// </param>
        /// <param name="curlExample">
        /// Optional curl example for convenience
        /// </param>
        /// <param name="requiredHeaders">
        /// Headers that MUST be included when uploading (e.g. Content-Type)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadUrlInfo(
            string uploadMethod,
            string uploadUrl,
            string? curlExample,
            global::System.Collections.Generic.Dictionary<string, string>? requiredHeaders)
        {
            this.CurlExample = curlExample;
            this.RequiredHeaders = requiredHeaders;
            this.UploadMethod = uploadMethod ?? throw new global::System.ArgumentNullException(nameof(uploadMethod));
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadUrlInfo" /> class.
        /// </summary>
        public UploadUrlInfo()
        {
        }

    }
}