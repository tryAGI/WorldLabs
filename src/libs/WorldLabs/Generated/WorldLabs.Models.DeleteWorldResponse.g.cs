
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Response from world deletion endpoint.
    /// </summary>
    public sealed partial class DeleteWorldResponse
    {
        /// <summary>
        /// Whether the world was successfully deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// ID of the deleted world
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("world_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorldId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWorldResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the world was successfully deleted
        /// </param>
        /// <param name="worldId">
        /// ID of the deleted world
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteWorldResponse(
            bool deleted,
            string worldId)
        {
            this.Deleted = deleted;
            this.WorldId = worldId ?? throw new global::System.ArgumentNullException(nameof(worldId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWorldResponse" /> class.
        /// </summary>
        public DeleteWorldResponse()
        {
        }

    }
}