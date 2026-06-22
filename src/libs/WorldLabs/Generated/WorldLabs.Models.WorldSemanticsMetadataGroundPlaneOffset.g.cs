
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Vertical (Y-axis) offset, in meters, of the detected ground plane in the metric-scaled frame. Subtract from Y after applying `metric_scale_factor` to place the ground at y=0.
    /// </summary>
    public sealed partial class WorldSemanticsMetadataGroundPlaneOffset
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}