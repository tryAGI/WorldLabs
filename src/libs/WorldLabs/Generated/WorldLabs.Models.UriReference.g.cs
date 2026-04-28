
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Reference to content via a publicly accessible URL.
    /// </summary>
    public sealed partial class UriReference
    {
        /// <summary>
        /// Default Value: uri
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Publicly accessible URL pointing to the media
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UriReference" /> class.
        /// </summary>
        /// <param name="uri">
        /// Publicly accessible URL pointing to the media
        /// </param>
        /// <param name="source">
        /// Default Value: uri
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UriReference(
            string uri,
            string? source)
        {
            this.Source = source;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UriReference" /> class.
        /// </summary>
        public UriReference()
        {
        }
    }
}