
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Request to generate a world from text, image, multi-image, or video input.
    /// </summary>
    public sealed partial class WorldsGenerateRequest
    {
        /// <summary>
        /// Optional display name (max 64 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The model to use for generation. marble-1.1-plus includes dynamic world sizing. Legacy names ('Marble 0.1-plus', etc.) still work but are deprecated and will be removed in a future release.<br/>
        /// Default Value: marble-1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.AnyOfJsonConverter<global::WorldLabs.WorldsGenerateRequestModelVariant1?, global::WorldLabs.WorldsGenerateRequestModelVariant2?>))]
        public global::WorldLabs.AnyOf<global::WorldLabs.WorldsGenerateRequestModelVariant1?, global::WorldLabs.WorldsGenerateRequestModelVariant2?>? Model { get; set; }

        /// <summary>
        /// The permission for the world<br/>
        /// Default Value: {"allow_id_access":false,"allowed_readers":[],"allowed_writers":[],"public":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::WorldLabs.Permission? Permission { get; set; }

        /// <summary>
        /// Random seed for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Optional tags for the world (max 10 tags, each up to 32 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The prompt specifying how to generate the world
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("world_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.WorldPromptJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.WorldPrompt WorldPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldsGenerateRequest" /> class.
        /// </summary>
        /// <param name="worldPrompt">
        /// The prompt specifying how to generate the world
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorldsGenerateRequest(
            global::WorldLabs.WorldPrompt worldPrompt,
            string? displayName,
            global::WorldLabs.AnyOf<global::WorldLabs.WorldsGenerateRequestModelVariant1?, global::WorldLabs.WorldsGenerateRequestModelVariant2?>? model,
            global::WorldLabs.Permission? permission,
            int? seed,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.DisplayName = displayName;
            this.Model = model;
            this.Permission = permission;
            this.Seed = seed;
            this.Tags = tags;
            this.WorldPrompt = worldPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldsGenerateRequest" /> class.
        /// </summary>
        public WorldsGenerateRequest()
        {
        }
    }
}