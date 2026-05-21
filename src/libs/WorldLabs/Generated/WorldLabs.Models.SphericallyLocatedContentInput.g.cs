
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Content with a preferred location on the sphere.
    /// </summary>
    public sealed partial class SphericallyLocatedContentInput
    {
        /// <summary>
        /// Azimuth angle in degrees
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azimuth")]
        public double? Azimuth { get; set; }

        /// <summary>
        /// The content at this location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WorldLabs.JsonConverters.Content2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::WorldLabs.Content2 Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericallyLocatedContentInput" /> class.
        /// </summary>
        /// <param name="content">
        /// The content at this location
        /// </param>
        /// <param name="azimuth">
        /// Azimuth angle in degrees
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SphericallyLocatedContentInput(
            global::WorldLabs.Content2 content,
            double? azimuth)
        {
            this.Azimuth = azimuth;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericallyLocatedContentInput" /> class.
        /// </summary>
        public SphericallyLocatedContentInput()
        {
        }

    }
}