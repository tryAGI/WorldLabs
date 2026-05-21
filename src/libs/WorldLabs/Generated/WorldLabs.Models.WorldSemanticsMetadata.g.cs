
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Semantic metadata describing how to interpret the generated splat<br/>
    /// asset in real-world units. The exported asset is in arbitrary model<br/>
    /// units; apply the transform below to convert to a metric, ground-aligned<br/>
    /// frame:<br/>
    ///     metric_xyz = raw_xyz * metric_scale_factor<br/>
    ///     aligned_xyz = metric_xyz - (0, ground_plane_offset, 0)
    /// </summary>
    public sealed partial class WorldSemanticsMetadata
    {
        /// <summary>
        /// Vertical (Y-axis) offset, in meters, of the detected ground plane<br/>
        /// in the metric-scaled frame. Subtract from Y after applying<br/>
        /// `metric_scale_factor` to place the ground at y=0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_plane_offset")]
        public double? GroundPlaneOffset { get; set; }

        /// <summary>
        /// Multiplicative factor that converts raw asset coordinates to<br/>
        /// meters. Multiply all XYZ positions (and isotropic scales) by this<br/>
        /// value. A value of 1.0 means scale could not be inferred and the<br/>
        /// asset was left in model units.
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
        /// <param name="groundPlaneOffset">
        /// Vertical (Y-axis) offset, in meters, of the detected ground plane<br/>
        /// in the metric-scaled frame. Subtract from Y after applying<br/>
        /// `metric_scale_factor` to place the ground at y=0.
        /// </param>
        /// <param name="metricScaleFactor">
        /// Multiplicative factor that converts raw asset coordinates to<br/>
        /// meters. Multiply all XYZ positions (and isotropic scales) by this<br/>
        /// value. A value of 1.0 means scale could not be inferred and the<br/>
        /// asset was left in model units.
        /// </param>
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