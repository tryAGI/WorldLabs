
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Response containing a list of API-generated worlds.
    /// </summary>
    public sealed partial class ListWorldsResponse
    {
        /// <summary>
        /// Token for fetching the next page of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// List of worlds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worlds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::WorldLabs.World> Worlds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorldsResponse" /> class.
        /// </summary>
        /// <param name="worlds">
        /// List of worlds
        /// </param>
        /// <param name="nextPageToken">
        /// Token for fetching the next page of results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorldsResponse(
            global::System.Collections.Generic.IList<global::WorldLabs.World> worlds,
            string? nextPageToken)
        {
            this.NextPageToken = nextPageToken;
            this.Worlds = worlds ?? throw new global::System.ArgumentNullException(nameof(worlds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorldsResponse" /> class.
        /// </summary>
        public ListWorldsResponse()
        {
        }

    }
}