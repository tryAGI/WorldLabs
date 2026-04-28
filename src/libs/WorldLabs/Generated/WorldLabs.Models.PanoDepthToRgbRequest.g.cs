
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Request to generate an RGB panorama from a depth panorama.<br/>
    /// Provide a depth panorama and a text prompt describing<br/>
    /// the desired appearance. The depth map supplies the<br/>
    /// scene geometry; the model synthesizes textures that<br/>
    /// loosely adhere to that geometry and returns a panoramic RGB image.<br/>
    /// Accepted depth inputs:<br/>
    /// * **EXR**: float depth values. Omit ``z_min``<br/>
    ///   and ``z_max``.<br/>
    /// * **PNG**: depth values normalized to [0, 1].<br/>
    ///   Provide both ``z_min`` and ``z_max`` so the service<br/>
    ///   can decode the PNG back into metric depth.<br/>
    /// For a complete PNG-based workflow, see the<br/>
    /// `web-chisel-depth-png example &lt;https://github.com/worldlabsai/worldlabs-api-examples/tree/main/web-chisel-depth-png&gt;`.<br/>
    /// This endpoint returns a long-running ``Operation``.<br/>
    /// Poll ``GET /operations/{operation_id}`` until<br/>
    /// ``done`` is ``true``, then read the generated<br/>
    /// panorama URL from ``response.pano_url``.
    /// </summary>
    public sealed partial class PanoDepthToRgbRequest
    {
        /// <summary>
        /// Depth panorama image (EXR or PNG). Provide via URI, media_asset, or base64 (max 100 MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth_pano_image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.DepthPanoImageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.DepthPanoImage DepthPanoImage { get; set; }

        /// <summary>
        /// Random seed for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Text description of the desired appearance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPrompt { get; set; }

        /// <summary>
        /// Maximum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_min and must be greater than z_min. Omit for EXR depth maps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("z_max")]
        public double? ZMax { get; set; }

        /// <summary>
        /// Minimum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_max. Omit for EXR depth maps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("z_min")]
        public double? ZMin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PanoDepthToRgbRequest" /> class.
        /// </summary>
        /// <param name="depthPanoImage">
        /// Depth panorama image (EXR or PNG). Provide via URI, media_asset, or base64 (max 100 MB).
        /// </param>
        /// <param name="textPrompt">
        /// Text description of the desired appearance.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducible generation.
        /// </param>
        /// <param name="zMax">
        /// Maximum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_min and must be greater than z_min. Omit for EXR depth maps.
        /// </param>
        /// <param name="zMin">
        /// Minimum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_max. Omit for EXR depth maps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PanoDepthToRgbRequest(
            global::WorldLabs.DepthPanoImage depthPanoImage,
            string textPrompt,
            int? seed,
            double? zMax,
            double? zMin)
        {
            this.DepthPanoImage = depthPanoImage;
            this.Seed = seed;
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.ZMax = zMax;
            this.ZMin = zMin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PanoDepthToRgbRequest" /> class.
        /// </summary>
        public PanoDepthToRgbRequest()
        {
        }
    }
}