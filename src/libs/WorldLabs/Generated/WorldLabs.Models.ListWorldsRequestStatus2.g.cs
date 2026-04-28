
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListWorldsRequestStatus2
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
    public static class ListWorldsRequestStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorldsRequestStatus2 value)
        {
            return value switch
            {
                ListWorldsRequestStatus2.Failed => "FAILED",
                ListWorldsRequestStatus2.Pending => "PENDING",
                ListWorldsRequestStatus2.Running => "RUNNING",
                ListWorldsRequestStatus2.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorldsRequestStatus2? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => ListWorldsRequestStatus2.Failed,
                "PENDING" => ListWorldsRequestStatus2.Pending,
                "RUNNING" => ListWorldsRequestStatus2.Running,
                "SUCCEEDED" => ListWorldsRequestStatus2.Succeeded,
                _ => null,
            };
        }
    }
}