
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Mesh variant to return when an HQ mesh already exists.<br/>
    /// Default Value: textured
    /// </summary>
    public enum ExportWorldRequestMeshVariant
    {
        /// <summary>
        /// 
        /// </summary>
        Textured,
        /// <summary>
        /// 
        /// </summary>
        VertexColored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportWorldRequestMeshVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportWorldRequestMeshVariant value)
        {
            return value switch
            {
                ExportWorldRequestMeshVariant.Textured => "textured",
                ExportWorldRequestMeshVariant.VertexColored => "vertex_colored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportWorldRequestMeshVariant? ToEnum(string value)
        {
            return value switch
            {
                "textured" => ExportWorldRequestMeshVariant.Textured,
                "vertex_colored" => ExportWorldRequestMeshVariant.VertexColored,
                _ => null,
            };
        }
    }
}