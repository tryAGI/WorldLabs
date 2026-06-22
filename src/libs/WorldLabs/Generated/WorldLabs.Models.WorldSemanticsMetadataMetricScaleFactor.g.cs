
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Multiplicative factor that converts raw asset coordinates to meters. Multiply all XYZ positions (and isotropic scales) by this value. A value of 1.0 means scale could not be inferred and the asset was left in model units.
    /// </summary>
    public sealed partial class WorldSemanticsMetadataMetricScaleFactor
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}