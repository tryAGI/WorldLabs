
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Result from depth-to-RGB panorama generation.<br/>
    /// Returned inside ``Operation.response`` when the<br/>
    /// operation completes successfully (``done=true``).
    /// </summary>
    public sealed partial class PanoDepthToRgbResult
    {
        /// <summary>
        /// URL of the generated RGB panorama image. Available when the operation succeeds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pano_url")]
        public string? PanoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PanoDepthToRgbResult" /> class.
        /// </summary>
        /// <param name="panoUrl">
        /// URL of the generated RGB panorama image. Available when the operation succeeds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PanoDepthToRgbResult(
            string? panoUrl)
        {
            this.PanoUrl = panoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PanoDepthToRgbResult" /> class.
        /// </summary>
        public PanoDepthToRgbResult()
        {
        }
    }
}