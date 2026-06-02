#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Get Credits<br/>
        /// Get remaining API credits for the authenticated user.<br/>
        /// Returns:<br/>
        ///     CreditsResponse with the current aggregate API credit balance.<br/>
        /// Raises:<br/>
        ///     HTTPException: 404 if the caller is not an API-enabled user<br/>
        ///     HTTPException: 503 if the billing backend is unavailable
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.CreditsResponse> GetCreditsMarbleV1CreditsGetAsync(
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Credits<br/>
        /// Get remaining API credits for the authenticated user.<br/>
        /// Returns:<br/>
        ///     CreditsResponse with the current aggregate API credit balance.<br/>
        /// Raises:<br/>
        ///     HTTPException: 404 if the caller is not an API-enabled user<br/>
        ///     HTTPException: 503 if the billing backend is unavailable
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.CreditsResponse>> GetCreditsMarbleV1CreditsGetAsResponseAsync(
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}