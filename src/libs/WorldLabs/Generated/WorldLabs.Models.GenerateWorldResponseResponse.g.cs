
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Result payload when done=true and no error. Structure depends on operation type.
    /// </summary>
    public sealed partial class GenerateWorldResponseResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}