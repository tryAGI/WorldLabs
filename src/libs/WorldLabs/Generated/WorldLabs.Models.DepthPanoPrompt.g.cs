
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// For models conditioned on a depth pano and text.<br/>
    /// When depth_pano_image is a log-encoded PNG, z_min and z_max are required<br/>
    /// to decode it correctly. When it is an EXR file containing raw float depth<br/>
    /// values, z_min and z_max will both be ignored.<br/>
    /// Please set z_min and z_max both to None when using an EXR file.
    /// </summary>
    public sealed partial class DepthPanoPrompt
    {
        /// <summary>
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth_pano_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.Content DepthPanoImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        public string? TextPrompt { get; set; }

        /// <summary>
        /// Default Value: depth-pano
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("z_max")]
        public double? ZMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("z_min")]
        public double? ZMin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DepthPanoPrompt" /> class.
        /// </summary>
        /// <param name="depthPanoImage">
        /// Represents content (media, text, images) that can be stored inline or via URL.<br/>
        /// Supports both direct data storage (up to 10MB) and URL references (up to 20MB).
        /// </param>
        /// <param name="textPrompt"></param>
        /// <param name="type">
        /// Default Value: depth-pano
        /// </param>
        /// <param name="zMax"></param>
        /// <param name="zMin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DepthPanoPrompt(
            global::WorldLabs.Content depthPanoImage,
            string? textPrompt,
            string? type,
            double? zMax,
            double? zMin)
        {
            this.DepthPanoImage = depthPanoImage ?? throw new global::System.ArgumentNullException(nameof(depthPanoImage));
            this.TextPrompt = textPrompt;
            this.Type = type;
            this.ZMax = zMax;
            this.ZMin = zMin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepthPanoPrompt" /> class.
        /// </summary>
        public DepthPanoPrompt()
        {
        }

    }
}