
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Optional human-readable title for the world (max 64 characters). Stored as world metadata and returned in world responses; does not affect generation. If omitted, World Labs may generate a title from the prompt.
    /// </summary>
    public sealed partial class WorldsGenerateRequestDisplayName
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}