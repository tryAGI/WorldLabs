
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Reference to content via base64-encoded data.
    /// </summary>
    public sealed partial class DataBase64Reference
    {
        /// <summary>
        /// Base64-encoded content data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataBase64 { get; set; }

        /// <summary>
        /// File extension without dot (e.g., 'jpg', 'png')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// Default Value: data_base64
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataBase64Reference" /> class.
        /// </summary>
        /// <param name="dataBase64">
        /// Base64-encoded content data
        /// </param>
        /// <param name="extension">
        /// File extension without dot (e.g., 'jpg', 'png')
        /// </param>
        /// <param name="source">
        /// Default Value: data_base64
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataBase64Reference(
            string dataBase64,
            string? extension,
            string? source)
        {
            this.DataBase64 = dataBase64 ?? throw new global::System.ArgumentNullException(nameof(dataBase64));
            this.Extension = extension;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataBase64Reference" /> class.
        /// </summary>
        public DataBase64Reference()
        {
        }
    }
}