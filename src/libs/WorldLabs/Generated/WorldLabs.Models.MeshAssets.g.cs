
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Mesh asset URLs.
    /// </summary>
    public sealed partial class MeshAssets
    {
        /// <summary>
        /// Collider mesh URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collider_mesh_url")]
        public string? ColliderMeshUrl { get; set; }

        /// <summary>
        /// Full-resolution vertex-colored mesh URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_res_mesh_url")]
        public string? FullResMeshUrl { get; set; }

        /// <summary>
        /// High-quality textured mesh URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hq_mesh_url")]
        public string? HqMeshUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshAssets" /> class.
        /// </summary>
        /// <param name="colliderMeshUrl">
        /// Collider mesh URL
        /// </param>
        /// <param name="fullResMeshUrl">
        /// Full-resolution vertex-colored mesh URL
        /// </param>
        /// <param name="hqMeshUrl">
        /// High-quality textured mesh URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeshAssets(
            string? colliderMeshUrl,
            string? fullResMeshUrl,
            string? hqMeshUrl)
        {
            this.ColliderMeshUrl = colliderMeshUrl;
            this.FullResMeshUrl = fullResMeshUrl;
            this.HqMeshUrl = hqMeshUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshAssets" /> class.
        /// </summary>
        public MeshAssets()
        {
        }

    }
}