
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExportWorldResultMeshVariant2
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
    public static class ExportWorldResultMeshVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportWorldResultMeshVariant2 value)
        {
            return value switch
            {
                ExportWorldResultMeshVariant2.Textured => "textured",
                ExportWorldResultMeshVariant2.VertexColored => "vertex_colored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportWorldResultMeshVariant2? ToEnum(string value)
        {
            return value switch
            {
                "textured" => ExportWorldResultMeshVariant2.Textured,
                "vertex_colored" => ExportWorldResultMeshVariant2.VertexColored,
                _ => null,
            };
        }
    }
}