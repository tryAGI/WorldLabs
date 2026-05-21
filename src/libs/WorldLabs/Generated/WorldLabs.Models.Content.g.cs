
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
    /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
    /// </summary>
    public sealed partial class Content
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_base64")]
        public string? DataBase64 { get; set; }

        /// <summary>
        /// File extension without dot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        /// <param name="dataBase64"></param>
        /// <param name="extension">
        /// File extension without dot
        /// </param>
        /// <param name="uri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Content(
            string? dataBase64,
            string? extension,
            string? uri)
        {
            this.DataBase64 = dataBase64;
            this.Extension = extension;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        public Content()
        {
        }

    }
}