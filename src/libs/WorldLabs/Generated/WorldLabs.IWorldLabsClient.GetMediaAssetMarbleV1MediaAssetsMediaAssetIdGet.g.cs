#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Get Media Asset<br/>
        /// Get a media asset by ID.<br/>
        /// Retrieves metadata for a previously created media asset.<br/>
        /// Args:<br/>
        ///     media_asset_id: The media asset identifier.<br/>
        /// Returns:<br/>
        ///     MediaAsset object with media_asset_id, file_name, extension, kind,<br/>
        ///     metadata, created_at, and updated_at.<br/>
        /// Raises:<br/>
        ///     HTTPException: 404 if not found
        /// </summary>
        /// <param name="mediaAssetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.MediaAsset> GetMediaAssetMarbleV1MediaAssetsMediaAssetIdGetAsync(
            string mediaAssetId,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Media Asset<br/>
        /// Get a media asset by ID.<br/>
        /// Retrieves metadata for a previously created media asset.<br/>
        /// Args:<br/>
        ///     media_asset_id: The media asset identifier.<br/>
        /// Returns:<br/>
        ///     MediaAsset object with media_asset_id, file_name, extension, kind,<br/>
        ///     metadata, created_at, and updated_at.<br/>
        /// Raises:<br/>
        ///     HTTPException: 404 if not found
        /// </summary>
        /// <param name="mediaAssetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.MediaAsset>> GetMediaAssetMarbleV1MediaAssetsMediaAssetIdGetAsResponseAsync(
            string mediaAssetId,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}