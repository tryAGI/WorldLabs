#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Prepare a media asset upload<br/>
        /// Prepare a media asset upload for use in world generation.<br/>
        /// This API endpoint creates a media asset record and returns a signed upload URL.<br/>
        /// Use this workflow to upload images or videos that you want to reference in world<br/>
        /// generation requests.<br/>
        /// ## Workflow<br/>
        /// 1. **Prepare Upload** (this endpoint): Get a `media_asset_id` and `upload_url`<br/>
        /// 2. **Upload File**: Use the signed URL to upload your file<br/>
        /// 3. **Generate World**: Reference the `media_asset_id` in `/worlds:generate` with<br/>
        ///    source type "media_asset"<br/>
        /// ## Request Parameters<br/>
        /// - `file_name`: Your file's name (e.g., "landscape.jpg")<br/>
        /// - `extension`: File extension without dot (e.g., "jpg", "png", "mp4")<br/>
        /// - `kind`: Either "image" or "video"<br/>
        /// - `metadata`: Optional custom metadata object<br/>
        /// ## Response<br/>
        /// Returns a `MediaAssetPrepareUploadResponse` containing:<br/>
        /// - `media_asset`: Object with `media_asset_id` (use this in world generation)<br/>
        /// - `upload_info`: Object with `upload_url`, `required_headers`, and `curl_example`<br/>
        /// ## Uploading Your File<br/>
        /// Use the returned `upload_url` and `required_headers` to upload your file:<br/>
        /// ```bash<br/>
        /// curl --request PUT \<br/>
        ///   --url &lt;upload_url&gt; \<br/>
        ///   --header "Content-Type: &lt;content-type&gt;" \<br/>
        ///   --header "&lt;header-name&gt;: &lt;header-value&gt;" \<br/>
        ///   --upload-file /path/to/your/file<br/>
        /// ```<br/>
        /// Replace:<br/>
        /// - `&lt;upload_url&gt;`: The `upload_url` from the response<br/>
        /// - `&lt;content-type&gt;`: MIME type (e.g., `image/png`, `image/jpeg`, `video/mp4`)<br/>
        /// - `&lt;header-name&gt;: &lt;header-value&gt;`: Each header from `required_headers`<br/>
        /// - `/path/to/your/file`: Path to your local file<br/>
        /// ## Example Usage in World Generation<br/>
        /// After uploading, use the `media_asset_id` in a world generation request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "world_prompt": {<br/>
        ///     "type": "image",<br/>
        ///     "image_prompt": {<br/>
        ///       "source": "media_asset",<br/>
        ///       "media_asset_id": "&lt;your-media-asset-id&gt;"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.MediaAssetPrepareUploadResponse> PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync(

            global::WorldLabs.MediaAssetPrepareUploadRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prepare a media asset upload<br/>
        /// Prepare a media asset upload for use in world generation.<br/>
        /// This API endpoint creates a media asset record and returns a signed upload URL.<br/>
        /// Use this workflow to upload images or videos that you want to reference in world<br/>
        /// generation requests.<br/>
        /// ## Workflow<br/>
        /// 1. **Prepare Upload** (this endpoint): Get a `media_asset_id` and `upload_url`<br/>
        /// 2. **Upload File**: Use the signed URL to upload your file<br/>
        /// 3. **Generate World**: Reference the `media_asset_id` in `/worlds:generate` with<br/>
        ///    source type "media_asset"<br/>
        /// ## Request Parameters<br/>
        /// - `file_name`: Your file's name (e.g., "landscape.jpg")<br/>
        /// - `extension`: File extension without dot (e.g., "jpg", "png", "mp4")<br/>
        /// - `kind`: Either "image" or "video"<br/>
        /// - `metadata`: Optional custom metadata object<br/>
        /// ## Response<br/>
        /// Returns a `MediaAssetPrepareUploadResponse` containing:<br/>
        /// - `media_asset`: Object with `media_asset_id` (use this in world generation)<br/>
        /// - `upload_info`: Object with `upload_url`, `required_headers`, and `curl_example`<br/>
        /// ## Uploading Your File<br/>
        /// Use the returned `upload_url` and `required_headers` to upload your file:<br/>
        /// ```bash<br/>
        /// curl --request PUT \<br/>
        ///   --url &lt;upload_url&gt; \<br/>
        ///   --header "Content-Type: &lt;content-type&gt;" \<br/>
        ///   --header "&lt;header-name&gt;: &lt;header-value&gt;" \<br/>
        ///   --upload-file /path/to/your/file<br/>
        /// ```<br/>
        /// Replace:<br/>
        /// - `&lt;upload_url&gt;`: The `upload_url` from the response<br/>
        /// - `&lt;content-type&gt;`: MIME type (e.g., `image/png`, `image/jpeg`, `video/mp4`)<br/>
        /// - `&lt;header-name&gt;: &lt;header-value&gt;`: Each header from `required_headers`<br/>
        /// - `/path/to/your/file`: Path to your local file<br/>
        /// ## Example Usage in World Generation<br/>
        /// After uploading, use the `media_asset_id` in a world generation request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "world_prompt": {<br/>
        ///     "type": "image",<br/>
        ///     "image_prompt": {<br/>
        ///       "source": "media_asset",<br/>
        ///       "media_asset_id": "&lt;your-media-asset-id&gt;"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="extension">
        /// File extension without dot
        /// </param>
        /// <param name="fileName">
        /// File name
        /// </param>
        /// <param name="kind">
        /// High-level media type
        /// </param>
        /// <param name="metadata">
        /// Optional application-specific metadata
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.MediaAssetPrepareUploadResponse> PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync(
            string fileName,
            global::WorldLabs.MediaAssetKind kind,
            string? extension = default,
            object? metadata = default,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}