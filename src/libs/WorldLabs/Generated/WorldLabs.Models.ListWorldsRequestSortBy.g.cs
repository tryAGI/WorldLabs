
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Sort results by created_at or updated_at<br/>
    /// Default Value: created_at
    /// </summary>
    public enum ListWorldsRequestSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListWorldsRequestSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorldsRequestSortBy value)
        {
            return value switch
            {
                ListWorldsRequestSortBy.CreatedAt => "created_at",
                ListWorldsRequestSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorldsRequestSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListWorldsRequestSortBy.CreatedAt,
                "updated_at" => ListWorldsRequestSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}