#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Export World<br/>
        /// Export a generated world asset.<br/>
        /// PLY splat exports are converted synchronously, cached in GCS, and returned<br/>
        /// as completed operations. HQ mesh exports reuse the existing async mesh<br/>
        /// export service and return an in-progress operation.
        /// </summary>
        /// <param name="worldId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.ExportWorldResponse> ExportWorldMarbleV1WorldsWorldIdExportPostAsync(
            string worldId,

            global::WorldLabs.ExportWorldRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export World<br/>
        /// Export a generated world asset.<br/>
        /// PLY splat exports are converted synchronously, cached in GCS, and returned<br/>
        /// as completed operations. HQ mesh exports reuse the existing async mesh<br/>
        /// export service and return an in-progress operation.
        /// </summary>
        /// <param name="worldId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.ExportWorldResponse>> ExportWorldMarbleV1WorldsWorldIdExportPostAsResponseAsync(
            string worldId,

            global::WorldLabs.ExportWorldRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export World<br/>
        /// Export a generated world asset.<br/>
        /// PLY splat exports are converted synchronously, cached in GCS, and returned<br/>
        /// as completed operations. HQ mesh exports reuse the existing async mesh<br/>
        /// export service and return an in-progress operation.
        /// </summary>
        /// <param name="worldId"></param>
        /// <param name="assetType">
        /// Asset family to export: 'splats' or 'mesh'.
        /// </param>
        /// <param name="format">
        /// Requested export format.
        /// </param>
        /// <param name="meshVariant">
        /// Mesh variant to return when an HQ mesh already exists.<br/>
        /// Default Value: textured
        /// </param>
        /// <param name="resolution">
        /// Splat resolution to convert when exporting splats as PLY.<br/>
        /// Default Value: full_res
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.ExportWorldResponse> ExportWorldMarbleV1WorldsWorldIdExportPostAsync(
            string worldId,
            global::WorldLabs.ExportWorldRequestAssetType assetType,
            global::WorldLabs.ExportWorldRequestFormat format,
            global::WorldLabs.ExportWorldRequestMeshVariant? meshVariant = default,
            global::WorldLabs.ExportWorldRequestResolution? resolution = default,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}