#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Healthz<br/>
        /// Health check endpoint for Kubernetes probes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthzHealthzGetAsync(
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Healthz<br/>
        /// Health check endpoint for Kubernetes probes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.AutoSDKHttpResponse<string>> HealthzHealthzGetAsResponseAsync(
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}