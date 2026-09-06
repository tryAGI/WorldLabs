
#nullable enable

namespace WorldLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListWorldsRequestStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListWorldsRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorldsRequestStatus value)
        {
            return value switch
            {
                ListWorldsRequestStatus.Failed => "FAILED",
                ListWorldsRequestStatus.Pending => "PENDING",
                ListWorldsRequestStatus.Running => "RUNNING",
                ListWorldsRequestStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorldsRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => ListWorldsRequestStatus.Failed,
                "PENDING" => ListWorldsRequestStatus.Pending,
                "RUNNING" => ListWorldsRequestStatus.Running,
                "SUCCEEDED" => ListWorldsRequestStatus.Succeeded,
                _ => null,
            };
        }
    }
}