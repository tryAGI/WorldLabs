
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Imagery asset URLs.
    /// </summary>
    public sealed partial class ImageryAssets
    {
        /// <summary>
        /// Panorama image URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pano_url")]
        public string? PanoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageryAssets" /> class.
        /// </summary>
        /// <param name="panoUrl">
        /// Panorama image URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageryAssets(
            string? panoUrl)
        {
            this.PanoUrl = panoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageryAssets" /> class.
        /// </summary>
        public ImageryAssets()
        {
        }

    }
}