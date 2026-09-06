
#nullable enable

namespace WorldLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ExportWorldResultMeshVariant
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
    public static class ExportWorldResultMeshVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportWorldResultMeshVariant value)
        {
            return value switch
            {
                ExportWorldResultMeshVariant.Textured => "textured",
                ExportWorldResultMeshVariant.VertexColored => "vertex_colored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportWorldResultMeshVariant? ToEnum(string value)
        {
            return value switch
            {
                "textured" => ExportWorldResultMeshVariant.Textured,
                "vertex_colored" => ExportWorldResultMeshVariant.VertexColored,
                _ => null,
            };
        }
    }
}