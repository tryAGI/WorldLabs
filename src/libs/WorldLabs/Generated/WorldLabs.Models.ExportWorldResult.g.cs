
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Downloadable exported world asset.
    /// </summary>
    public sealed partial class ExportWorldResult
    {
        /// <summary>
        /// Exported asset family
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.ExportWorldResultAssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.ExportWorldResultAssetType AssetType { get; set; }

        /// <summary>
        /// Exported file format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.ExportWorldResultFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.ExportWorldResultFormat Format { get; set; }

        /// <summary>
        /// Mesh variant returned for this export, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_variant")]
        public global::WorldLabs.ExportWorldResultMeshVariant2? MeshVariant { get; set; }

        /// <summary>
        /// Splat resolution used for this export, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Download URL for the exported asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportWorldResult" /> class.
        /// </summary>
        /// <param name="assetType">
        /// Exported asset family
        /// </param>
        /// <param name="format">
        /// Exported file format
        /// </param>
        /// <param name="url">
        /// Download URL for the exported asset
        /// </param>
        /// <param name="meshVariant">
        /// Mesh variant returned for this export, if applicable
        /// </param>
        /// <param name="resolution">
        /// Splat resolution used for this export, if applicable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportWorldResult(
            global::WorldLabs.ExportWorldResultAssetType assetType,
            global::WorldLabs.ExportWorldResultFormat format,
            string url,
            global::WorldLabs.ExportWorldResultMeshVariant2? meshVariant,
            string? resolution)
        {
            this.AssetType = assetType;
            this.Format = format;
            this.MeshVariant = meshVariant;
            this.Resolution = resolution;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportWorldResult" /> class.
        /// </summary>
        public ExportWorldResult()
        {
        }

    }
}