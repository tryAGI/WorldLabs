
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// A single usage event contributing to an operation's total credits.
    /// </summary>
    public sealed partial class OperationCostLineItem
    {
        /// <summary>
        /// Credits charged for this usage event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// Human-readable usage event name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationCostLineItem" /> class.
        /// </summary>
        /// <param name="credits">
        /// Credits charged for this usage event
        /// </param>
        /// <param name="name">
        /// Human-readable usage event name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OperationCostLineItem(
            int credits,
            string name)
        {
            this.Credits = credits;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationCostLineItem" /> class.
        /// </summary>
        public OperationCostLineItem()
        {
        }

    }
}