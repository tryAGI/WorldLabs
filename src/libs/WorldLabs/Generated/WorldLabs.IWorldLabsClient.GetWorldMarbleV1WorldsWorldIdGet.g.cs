#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Get World<br/>
        /// Get a world by ID.<br/>
        /// Retrieves a world's details including generated assets if available.<br/>
        /// Only the world owner or users with access to public worlds can retrieve them.<br/>
        /// Args:<br/>
        ///     world_id: The unique identifier of the world.<br/>
        /// Returns:<br/>
        ///     World object with world_id, display_name, tags, assets, created_at,<br/>
        ///     updated_at, permission, model, world_prompt, and world_marble_url.<br/>
        /// Raises:<br/>
        ///     HTTPException: 404 if world not found or access denied
        /// </summary>
        /// <param name="worldId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.World> GetWorldMarbleV1WorldsWorldIdGetAsync(
            string worldId,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get World<br/>
        /// Get a world by ID.<br/>
        /// Retrieves a world's details including generated assets if available.<br/>
        /// Only the world owner or users with access to public worlds can retrieve them.<br/>
        /// Args:<br/>
        ///     world_id: The unique identifier of the world.<br/>
        /// Returns:<br/>
        ///     World object with world_id, display_name, tags, assets, created_at,<br/>
        ///     updated_at, permission, model, world_prompt, and world_marble_url.<br/>
        /// Raises:<br/>
        ///     HTTPException: 404 if world not found or access denied
        /// </summary>
        /// <param name="worldId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.World>> GetWorldMarbleV1WorldsWorldIdGetAsResponseAsync(
            string worldId,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}