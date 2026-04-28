#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Get Operation<br/>
        /// Get an operation by ID.<br/>
        /// Poll this endpoint to check the status of a long-running operation.<br/>
        /// When done=true, the response field contains the generated world.<br/>
        /// Args:<br/>
        ///     operation_id: The operation identifier from /worlds:generate.<br/>
        /// Returns:<br/>
        ///     GetOperationResponse[World] with:<br/>
        ///         - operation_id: Operation identifier<br/>
        ///         - created_at: Creation timestamp<br/>
        ///         - updated_at: Last update timestamp<br/>
        ///         - expires_at: Expiration timestamp<br/>
        ///         - done: true when complete, false while in progress<br/>
        ///         - error: Error details if failed, null otherwise<br/>
        ///         - metadata: Progress information and world_id<br/>
        ///         - response: Generated World if done=true, null otherwise<br/>
        /// Raises:<br/>
        ///     HTTPException: 401 if unauthorized<br/>
        ///     HTTPException: 404 if operation not found<br/>
        ///     HTTPException: 500 if request fails
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResult> GetOperationMarbleV1OperationsOperationIdGetAsync(
            string operationId,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}