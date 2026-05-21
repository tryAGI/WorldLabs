
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// A generated world, including asset URLs.
    /// </summary>
    public sealed partial class World
    {
        /// <summary>
        /// Generated world assets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        public global::WorldLabs.WorldAssets2? Assets { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Model used for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Access control permissions for the world
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::WorldLabs.Permission? Permission { get; set; }

        /// <summary>
        /// Tags associated with the world
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// World identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("world_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorldId { get; set; }

        /// <summary>
        /// World Marble URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("world_marble_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorldMarbleUrl { get; set; }

        /// <summary>
        /// World prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("world_prompt")]
        public global::WorldLabs.WorldPromptVariant1? WorldPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="World" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name
        /// </param>
        /// <param name="worldId">
        /// World identifier
        /// </param>
        /// <param name="worldMarbleUrl">
        /// World Marble URL
        /// </param>
        /// <param name="assets">
        /// Generated world assets
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="model">
        /// Model used for generation
        /// </param>
        /// <param name="permission">
        /// Access control permissions for the world
        /// </param>
        /// <param name="tags">
        /// Tags associated with the world
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp
        /// </param>
        /// <param name="worldPrompt">
        /// World prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public World(
            string displayName,
            string worldId,
            string worldMarbleUrl,
            global::WorldLabs.WorldAssets2? assets,
            global::System.DateTime? createdAt,
            string? model,
            global::WorldLabs.Permission? permission,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? updatedAt,
            global::WorldLabs.WorldPromptVariant1? worldPrompt)
        {
            this.Assets = assets;
            this.CreatedAt = createdAt;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Model = model;
            this.Permission = permission;
            this.Tags = tags;
            this.UpdatedAt = updatedAt;
            this.WorldId = worldId ?? throw new global::System.ArgumentNullException(nameof(worldId));
            this.WorldMarbleUrl = worldMarbleUrl ?? throw new global::System.ArgumentNullException(nameof(worldMarbleUrl));
            this.WorldPrompt = worldPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="World" /> class.
        /// </summary>
        public World()
        {
        }

    }
}