
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PanoDepthToRgbRequestDepthPanoImageDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.PanoDepthToRgbRequestDepthPanoImageDiscriminatorSourceJsonConverter))]
        public global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PanoDepthToRgbRequestDepthPanoImageDiscriminator" /> class.
        /// </summary>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PanoDepthToRgbRequestDepthPanoImageDiscriminator(
            global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PanoDepthToRgbRequestDepthPanoImageDiscriminator" /> class.
        /// </summary>
        public PanoDepthToRgbRequestDepthPanoImageDiscriminator()
        {
        }
    }
}