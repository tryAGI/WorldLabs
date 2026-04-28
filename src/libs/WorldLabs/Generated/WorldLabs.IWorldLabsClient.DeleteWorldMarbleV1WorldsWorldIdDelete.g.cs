#nullable enable

namespace WorldLabs
{
    public partial interface IWorldLabsClient
    {
        /// <summary>
        /// Delete World<br/>
        /// Delete a world by ID.<br/>
        /// Permanently deletes a world and its associated assets.<br/>
        /// Only the world owner can delete a world.<br/>
        /// Args:<br/>
        ///     world_id: The unique identifier of the world to delete.<br/>
        /// Returns:<br/>
        ///     DeleteWorldResponse confirming the deletion.<br/>
        /// Raises:<br/>
        ///     HTTPException: 403 if user is not the world owner<br/>
        ///     HTTPException: 404 if world not found<br/>
        ///     HTTPException: 500 if deletion fails
        /// </summary>
        /// <param name="worldId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WorldLabs.DeleteWorldResponse> DeleteWorldMarbleV1WorldsWorldIdDeleteAsync(
            string worldId,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}