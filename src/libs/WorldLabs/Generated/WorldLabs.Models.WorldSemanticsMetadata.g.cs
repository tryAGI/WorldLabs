
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Semantic metadata for world generation output.
    /// </summary>
    public sealed partial class WorldSemanticsMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_plane_offset")]
        public double? GroundPlaneOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_scale_factor")]
        public double? MetricScaleFactor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldSemanticsMetadata" /> class.
        /// </summary>
        /// <param name="groundPlaneOffset"></param>
        /// <param name="metricScaleFactor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorldSemanticsMetadata(
            double? groundPlaneOffset,
            double? metricScaleFactor)
        {
            this.GroundPlaneOffset = groundPlaneOffset;
            this.MetricScaleFactor = metricScaleFactor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldSemanticsMetadata" /> class.
        /// </summary>
        public WorldSemanticsMetadata()
        {
        }
    }
}