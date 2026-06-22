
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Settled credit cost for a successful operation.
    /// </summary>
    public sealed partial class OperationCost
    {
        /// <summary>
        /// Usage events that make up the operation's total credits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_items")]
        public global::System.Collections.Generic.IList<global::WorldLabs.OperationCostLineItem>? LineItems { get; set; }

        /// <summary>
        /// Total credits charged for the operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationCost" /> class.
        /// </summary>
        /// <param name="totalCredits">
        /// Total credits charged for the operation
        /// </param>
        /// <param name="lineItems">
        /// Usage events that make up the operation's total credits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OperationCost(
            int totalCredits,
            global::System.Collections.Generic.IList<global::WorldLabs.OperationCostLineItem>? lineItems)
        {
            this.LineItems = lineItems;
            this.TotalCredits = totalCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationCost" /> class.
        /// </summary>
        public OperationCost()
        {
        }

    }
}