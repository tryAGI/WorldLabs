
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Content with a preferred location on the sphere.
    /// </summary>
    public sealed partial class SphericallyLocatedContentOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azimuth")]
        public double? Azimuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_base64")]
        public string? DataBase64 { get; set; }

        /// <summary>
        /// File extension without dot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericallyLocatedContentOutput" /> class.
        /// </summary>
        /// <param name="azimuth"></param>
        /// <param name="dataBase64"></param>
        /// <param name="extension">
        /// File extension without dot
        /// </param>
        /// <param name="uri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SphericallyLocatedContentOutput(
            double? azimuth,
            string? dataBase64,
            string? extension,
            string? uri)
        {
            this.Azimuth = azimuth;
            this.DataBase64 = dataBase64;
            this.Extension = extension;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericallyLocatedContentOutput" /> class.
        /// </summary>
        public SphericallyLocatedContentOutput()
        {
        }

    }
}