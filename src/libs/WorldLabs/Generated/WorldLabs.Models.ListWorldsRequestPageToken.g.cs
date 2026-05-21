
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Cursor token for pagination (opaque base64 string from previous response). Use cursor from next_page_token in previous response for consistent pagination.
    /// </summary>
    public sealed partial class ListWorldsRequestPageToken
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}