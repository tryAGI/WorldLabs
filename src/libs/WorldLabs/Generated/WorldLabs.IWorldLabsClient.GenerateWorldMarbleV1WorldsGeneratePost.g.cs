#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Generate World<br/>
        /// Start world generation.<br/>
        /// Creates a new world generation job and returns a long-running operation.<br/>
        /// Poll the /operations/{operation_id} endpoint to check generation status<br/>
        /// and retrieve the generated world when complete.<br/>
        /// Args:<br/>
        ///     request: The world generation request containing world_prompt, display_name,<br/>
        ///         tags, model, seed, and permission settings.<br/>
        /// Returns:<br/>
        ///     GenerateWorldResponse with operation_id and timestamps. Use the operation_id<br/>
        ///     to poll for completion.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid request or content violates policies<br/>
        ///     HTTPException: 402 if insufficient credits<br/>
        ///     HTTPException: 500 if generation could not be started
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.GenerateWorldResponse> GenerateWorldMarbleV1WorldsGeneratePostAsync(

            global::WorldLabs.WorldsGenerateRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate World<br/>
        /// Start world generation.<br/>
        /// Creates a new world generation job and returns a long-running operation.<br/>
        /// Poll the /operations/{operation_id} endpoint to check generation status<br/>
        /// and retrieve the generated world when complete.<br/>
        /// Args:<br/>
        ///     request: The world generation request containing world_prompt, display_name,<br/>
        ///         tags, model, seed, and permission settings.<br/>
        /// Returns:<br/>
        ///     GenerateWorldResponse with operation_id and timestamps. Use the operation_id<br/>
        ///     to poll for completion.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid request or content violates policies<br/>
        ///     HTTPException: 402 if insufficient credits<br/>
        ///     HTTPException: 500 if generation could not be started
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.GenerateWorldResponse>> GenerateWorldMarbleV1WorldsGeneratePostAsResponseAsync(

            global::WorldLabs.WorldsGenerateRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate World<br/>
        /// Start world generation.<br/>
        /// Creates a new world generation job and returns a long-running operation.<br/>
        /// Poll the /operations/{operation_id} endpoint to check generation status<br/>
        /// and retrieve the generated world when complete.<br/>
        /// Args:<br/>
        ///     request: The world generation request containing world_prompt, display_name,<br/>
        ///         tags, model, seed, and permission settings.<br/>
        /// Returns:<br/>
        ///     GenerateWorldResponse with operation_id and timestamps. Use the operation_id<br/>
        ///     to poll for completion.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid request or content violates policies<br/>
        ///     HTTPException: 402 if insufficient credits<br/>
        ///     HTTPException: 500 if generation could not be started
        /// </summary>
        /// <param name="displayName">
        /// Optional display name (max 64 characters)
        /// </param>
        /// <param name="model">
        /// The model to use for generation. marble-1.1-plus includes dynamic world sizing. Legacy names ('Marble 0.1-plus', etc.) still work but are deprecated and will be removed in a future release.<br/>
        /// Default Value: marble-1.0
        /// </param>
        /// <param name="permission">
        /// The permission for the world<br/>
        /// Default Value: {"allow_id_access":false,"allowed_readers":[],"allowed_writers":[],"public":false}
        /// </param>
        /// <param name="seed">
        /// Random seed for generation
        /// </param>
        /// <param name="tags">
        /// Optional tags for the world (max 10 tags, each up to 32 characters)
        /// </param>
        /// <param name="worldPrompt">
        /// The prompt specifying how to generate the world
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.GenerateWorldResponse> GenerateWorldMarbleV1WorldsGeneratePostAsync(
            global::WorldLabs.WorldPrompt worldPrompt,
            string? displayName = default,
            global::WorldLabs.AnyOf<global::WorldLabs.WorldsGenerateRequestModelVariant1?, global::WorldLabs.WorldsGenerateRequestModelVariant2?>? model = default,
            global::WorldLabs.Permission? permission = default,
            int? seed = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}