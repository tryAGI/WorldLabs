
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Response from world generation endpoint.
    /// </summary>
    public sealed partial class GenerateWorldResponse
    {
        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// True if the operation is completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// Error information if the operation failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::WorldLabs.OperationError? Error { get; set; }

        /// <summary>
        /// Expiration timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Service-specific metadata, such as progress percentage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Operation identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationId { get; set; }

        /// <summary>
        /// Result payload when done=true and no error. Structure depends on operation type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public object? Response { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateWorldResponse" /> class.
        /// </summary>
        /// <param name="done">
        /// True if the operation is completed
        /// </param>
        /// <param name="operationId">
        /// Operation identifier
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="error">
        /// Error information if the operation failed
        /// </param>
        /// <param name="expiresAt">
        /// Expiration timestamp
        /// </param>
        /// <param name="metadata">
        /// Service-specific metadata, such as progress percentage
        /// </param>
        /// <param name="response">
        /// Result payload when done=true and no error. Structure depends on operation type.
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateWorldResponse(
            bool done,
            string operationId,
            global::System.DateTime? createdAt,
            global::WorldLabs.OperationError? error,
            global::System.DateTime? expiresAt,
            object? metadata,
            object? response,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Done = done;
            this.Error = error;
            this.ExpiresAt = expiresAt;
            this.Metadata = metadata;
            this.OperationId = operationId ?? throw new global::System.ArgumentNullException(nameof(operationId));
            this.Response = response;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateWorldResponse" /> class.
        /// </summary>
        public GenerateWorldResponse()
        {
        }
    }
}