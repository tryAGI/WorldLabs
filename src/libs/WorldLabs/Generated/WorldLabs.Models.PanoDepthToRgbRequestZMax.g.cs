
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Maximum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_min and must be greater than z_min. Omit for EXR depth maps.
    /// </summary>
    public sealed partial class PanoDepthToRgbRequestZMax
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}