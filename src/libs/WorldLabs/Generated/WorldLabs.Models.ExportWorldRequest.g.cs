
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Request to export a generated world asset.
    /// </summary>
    public sealed partial class ExportWorldRequest
    {
        /// <summary>
        /// Asset family to export: 'splats' or 'mesh'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.ExportWorldRequestAssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.ExportWorldRequestAssetType AssetType { get; set; }

        /// <summary>
        /// Requested export format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.ExportWorldRequestFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.ExportWorldRequestFormat Format { get; set; }

        /// <summary>
        /// Mesh variant to return when an HQ mesh already exists.<br/>
        /// Default Value: textured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.ExportWorldRequestMeshVariantJsonConverter))]
        public global::WorldLabs.ExportWorldRequestMeshVariant? MeshVariant { get; set; }

        /// <summary>
        /// Splat resolution to convert when exporting splats as PLY.<br/>
        /// Default Value: full_res
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.ExportWorldRequestResolutionJsonConverter))]
        public global::WorldLabs.ExportWorldRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportWorldRequest" /> class.
        /// </summary>
        /// <param name="assetType">
        /// Asset family to export: 'splats' or 'mesh'.
        /// </param>
        /// <param name="format">
        /// Requested export format.
        /// </param>
        /// <param name="meshVariant">
        /// Mesh variant to return when an HQ mesh already exists.<br/>
        /// Default Value: textured
        /// </param>
        /// <param name="resolution">
        /// Splat resolution to convert when exporting splats as PLY.<br/>
        /// Default Value: full_res
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportWorldRequest(
            global::WorldLabs.ExportWorldRequestAssetType assetType,
            global::WorldLabs.ExportWorldRequestFormat format,
            global::WorldLabs.ExportWorldRequestMeshVariant? meshVariant,
            global::WorldLabs.ExportWorldRequestResolution? resolution)
        {
            this.AssetType = assetType;
            this.Format = format;
            this.MeshVariant = meshVariant;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportWorldRequest" /> class.
        /// </summary>
        public ExportWorldRequest()
        {
        }

    }
}