#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Pano Depth To Rgb<br/>
        /// Generate an RGB panorama from a depth panorama.<br/>
        /// Provide a depth panorama and a text prompt<br/>
        /// describing the desired appearance. The depth map<br/>
        /// supplies the scene geometry; the model synthesizes<br/>
        /// textures that match that geometry and returns a<br/>
        /// panoramic RGB image.<br/>
        /// Accepted depth inputs:<br/>
        /// * **EXR**: float depth values. Omit<br/>
        ///   ``z_min`` and ``z_max``.<br/>
        /// * **PNG**: depth values normalized to [0, 1].<br/>
        ///   Provide both ``z_min`` and ``z_max`` so the<br/>
        ///   service can decode the PNG correctly.<br/>
        /// For a complete PNG-based workflow, see the<br/>
        /// [web-chisel-depth-png example](https://github.com/worldlabsai/worldlabs-api-examples/tree/main/web-chisel-depth-png).<br/>
        /// Returns a long-running ``Operation``. Poll<br/>
        /// ``GET /operations/{operation_id}`` until<br/>
        /// ``done`` is ``true``, then read the generated<br/>
        /// panorama URL from ``response.pano_url``.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid request<br/>
        ///     HTTPException: 402 if insufficient credits<br/>
        ///     HTTPException: 500 if generation could not start
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.OperationPanoDepthToRgbResult> PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync(

            global::WorldLabs.PanoDepthToRgbRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pano Depth To Rgb<br/>
        /// Generate an RGB panorama from a depth panorama.<br/>
        /// Provide a depth panorama and a text prompt<br/>
        /// describing the desired appearance. The depth map<br/>
        /// supplies the scene geometry; the model synthesizes<br/>
        /// textures that match that geometry and returns a<br/>
        /// panoramic RGB image.<br/>
        /// Accepted depth inputs:<br/>
        /// * **EXR**: float depth values. Omit<br/>
        ///   ``z_min`` and ``z_max``.<br/>
        /// * **PNG**: depth values normalized to [0, 1].<br/>
        ///   Provide both ``z_min`` and ``z_max`` so the<br/>
        ///   service can decode the PNG correctly.<br/>
        /// For a complete PNG-based workflow, see the<br/>
        /// [web-chisel-depth-png example](https://github.com/worldlabsai/worldlabs-api-examples/tree/main/web-chisel-depth-png).<br/>
        /// Returns a long-running ``Operation``. Poll<br/>
        /// ``GET /operations/{operation_id}`` until<br/>
        /// ``done`` is ``true``, then read the generated<br/>
        /// panorama URL from ``response.pano_url``.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid request<br/>
        ///     HTTPException: 402 if insufficient credits<br/>
        ///     HTTPException: 500 if generation could not start
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.OperationPanoDepthToRgbResult>> PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsResponseAsync(

            global::WorldLabs.PanoDepthToRgbRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pano Depth To Rgb<br/>
        /// Generate an RGB panorama from a depth panorama.<br/>
        /// Provide a depth panorama and a text prompt<br/>
        /// describing the desired appearance. The depth map<br/>
        /// supplies the scene geometry; the model synthesizes<br/>
        /// textures that match that geometry and returns a<br/>
        /// panoramic RGB image.<br/>
        /// Accepted depth inputs:<br/>
        /// * **EXR**: float depth values. Omit<br/>
        ///   ``z_min`` and ``z_max``.<br/>
        /// * **PNG**: depth values normalized to [0, 1].<br/>
        ///   Provide both ``z_min`` and ``z_max`` so the<br/>
        ///   service can decode the PNG correctly.<br/>
        /// For a complete PNG-based workflow, see the<br/>
        /// [web-chisel-depth-png example](https://github.com/worldlabsai/worldlabs-api-examples/tree/main/web-chisel-depth-png).<br/>
        /// Returns a long-running ``Operation``. Poll<br/>
        /// ``GET /operations/{operation_id}`` until<br/>
        /// ``done`` is ``true``, then read the generated<br/>
        /// panorama URL from ``response.pano_url``.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid request<br/>
        ///     HTTPException: 402 if insufficient credits<br/>
        ///     HTTPException: 500 if generation could not start
        /// </summary>
        /// <param name="depthPanoImage">
        /// Depth panorama image (EXR or PNG). Provide via URI, media_asset, or base64 (max 100 MB).
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducible generation.
        /// </param>
        /// <param name="textPrompt">
        /// Text description of the desired appearance.
        /// </param>
        /// <param name="zMax">
        /// Maximum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_min and must be greater than z_min. Omit for EXR depth maps.
        /// </param>
        /// <param name="zMin">
        /// Minimum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_max. Omit for EXR depth maps.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.OperationPanoDepthToRgbResult> PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync(
            global::WorldLabs.DepthPanoImage depthPanoImage,
            string textPrompt,
            int? seed = default,
            double? zMax = default,
            double? zMin = default,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}