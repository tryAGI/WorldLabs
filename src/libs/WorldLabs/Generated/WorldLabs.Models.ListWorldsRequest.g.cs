
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Request to list API-generated worlds with optional filters.
    /// </summary>
    public sealed partial class ListWorldsRequest
    {
        /// <summary>
        /// Filter worlds created after this timestamp (inclusive)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_after")]
        public global::System.DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Filter worlds created before this timestamp (exclusive)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_before")]
        public global::System.DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Filter by visibility. true=public only, false=private only, null=all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Filter by model used for generation. Legacy names are deprecated; use the new lowercase names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.AnyOfJsonConverter<global::WorldLabs.ListWorldsRequestModelVariant1?, global::WorldLabs.ListWorldsRequestModelVariant2?, object>))]
        public global::WorldLabs.AnyOf<global::WorldLabs.ListWorldsRequestModelVariant1?, global::WorldLabs.ListWorldsRequestModelVariant2?, object>? Model { get; set; }

        /// <summary>
        /// Number of results per page (1-100)<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Cursor token for pagination (opaque base64 string from previous response). Use cursor from next_page_token in previous response for consistent pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// Sort results by created_at or updated_at<br/>
        /// Default Value: created_at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.ListWorldsRequestSortByJsonConverter))]
        public global::WorldLabs.ListWorldsRequestSortBy? SortBy { get; set; }

        /// <summary>
        /// Filter by world status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::WorldLabs.ListWorldsRequestStatus2? Status { get; set; }

        /// <summary>
        /// Filter by tags (returns worlds with ANY of these tags)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorldsRequest" /> class.
        /// </summary>
        /// <param name="createdAfter">
        /// Filter worlds created after this timestamp (inclusive)
        /// </param>
        /// <param name="createdBefore">
        /// Filter worlds created before this timestamp (exclusive)
        /// </param>
        /// <param name="isPublic">
        /// Filter by visibility. true=public only, false=private only, null=all
        /// </param>
        /// <param name="model">
        /// Filter by model used for generation. Legacy names are deprecated; use the new lowercase names.
        /// </param>
        /// <param name="pageSize">
        /// Number of results per page (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="pageToken">
        /// Cursor token for pagination (opaque base64 string from previous response). Use cursor from next_page_token in previous response for consistent pagination.
        /// </param>
        /// <param name="sortBy">
        /// Sort results by created_at or updated_at<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="status">
        /// Filter by world status
        /// </param>
        /// <param name="tags">
        /// Filter by tags (returns worlds with ANY of these tags)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorldsRequest(
            global::System.DateTime? createdAfter,
            global::System.DateTime? createdBefore,
            bool? isPublic,
            global::WorldLabs.AnyOf<global::WorldLabs.ListWorldsRequestModelVariant1?, global::WorldLabs.ListWorldsRequestModelVariant2?, object>? model,
            int? pageSize,
            string? pageToken,
            global::WorldLabs.ListWorldsRequestSortBy? sortBy,
            global::WorldLabs.ListWorldsRequestStatus2? status,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.CreatedAfter = createdAfter;
            this.CreatedBefore = createdBefore;
            this.IsPublic = isPublic;
            this.Model = model;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.SortBy = sortBy;
            this.Status = status;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorldsRequest" /> class.
        /// </summary>
        public ListWorldsRequest()
        {
        }
    }
}