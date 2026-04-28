#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// List Worlds<br/>
        /// List worlds with optional filters.<br/>
        /// Returns worlds created through the API with optional filtering and pagination.<br/>
        /// Args:<br/>
        ///     request: List request with optional filters:<br/>
        ///         - page_size: Number of results per page (default: 10)<br/>
        ///         - page_token: Pagination token from previous response<br/>
        ///         - status: Filter by status (e.g., "COMPLETED")<br/>
        ///         - model: Filter by model name (e.g., "marble-1.0-plus")<br/>
        ///         - tags: Filter by tags (matches worlds with any tag)<br/>
        ///         - is_public: Filter by visibility (true=public, false=private, null=all)<br/>
        ///         - created_after: Filter by creation time (after timestamp)<br/>
        ///         - created_before: Filter by creation time (before timestamp)<br/>
        ///         - sort_by: Sort order ("created_at" or "updated_at")<br/>
        /// Returns:<br/>
        ///     ListWorldsResponse with worlds list and next_page_token for pagination.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid parameters<br/>
        ///     HTTPException: 500 if request fails
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.ListWorldsResponse> ListWorldsMarbleV1WorldsListPostAsync(

            global::WorldLabs.ListWorldsRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Worlds<br/>
        /// List worlds with optional filters.<br/>
        /// Returns worlds created through the API with optional filtering and pagination.<br/>
        /// Args:<br/>
        ///     request: List request with optional filters:<br/>
        ///         - page_size: Number of results per page (default: 10)<br/>
        ///         - page_token: Pagination token from previous response<br/>
        ///         - status: Filter by status (e.g., "COMPLETED")<br/>
        ///         - model: Filter by model name (e.g., "marble-1.0-plus")<br/>
        ///         - tags: Filter by tags (matches worlds with any tag)<br/>
        ///         - is_public: Filter by visibility (true=public, false=private, null=all)<br/>
        ///         - created_after: Filter by creation time (after timestamp)<br/>
        ///         - created_before: Filter by creation time (before timestamp)<br/>
        ///         - sort_by: Sort order ("created_at" or "updated_at")<br/>
        /// Returns:<br/>
        ///     ListWorldsResponse with worlds list and next_page_token for pagination.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid parameters<br/>
        ///     HTTPException: 500 if request fails
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.ListWorldsResponse> ListWorldsMarbleV1WorldsListPostAsync(
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            bool? isPublic = default,
            global::WorldLabs.AnyOf<global::WorldLabs.ListWorldsRequestModelVariant1?, global::WorldLabs.ListWorldsRequestModelVariant2?, object>? model = default,
            int? pageSize = default,
            string? pageToken = default,
            global::WorldLabs.ListWorldsRequestSortBy? sortBy = default,
            global::WorldLabs.ListWorldsRequestStatus2? status = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}