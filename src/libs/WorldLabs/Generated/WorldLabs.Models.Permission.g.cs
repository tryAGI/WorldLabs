
#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// Access control permissions for a resource.
    /// </summary>
    public sealed partial class Permission
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_id_access")]
        public bool? AllowIdAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_readers")]
        public global::System.Collections.Generic.IList<string>? AllowedReaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_writers")]
        public global::System.Collections.Generic.IList<string>? AllowedWriters { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="allowIdAccess">
        /// Default Value: false
        /// </param>
        /// <param name="allowedReaders"></param>
        /// <param name="allowedWriters"></param>
        /// <param name="public">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Permission(
            bool? allowIdAccess,
            global::System.Collections.Generic.IList<string>? allowedReaders,
            global::System.Collections.Generic.IList<string>? allowedWriters,
            bool? @public)
        {
            this.AllowIdAccess = allowIdAccess;
            this.AllowedReaders = allowedReaders;
            this.AllowedWriters = allowedWriters;
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        public Permission()
        {
        }
    }
}