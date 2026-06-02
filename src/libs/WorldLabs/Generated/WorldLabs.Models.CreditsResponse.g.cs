
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Remaining credits for the authenticated API user.
    /// </summary>
    public sealed partial class CreditsResponse
    {
        /// <summary>
        /// Remaining API credits available to the authenticated user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RemainingCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsResponse" /> class.
        /// </summary>
        /// <param name="remainingCredits">
        /// Remaining API credits available to the authenticated user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsResponse(
            double remainingCredits)
        {
            this.RemainingCredits = remainingCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsResponse" /> class.
        /// </summary>
        public CreditsResponse()
        {
        }

    }
}