#nullable enable

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExportWorldRequestAssetTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.ExportWorldRequestAssetType>
    {
        /// <inheritdoc />
        public override global::WorldLabs.ExportWorldRequestAssetType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::WorldLabs.ExportWorldRequestAssetTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WorldLabs.ExportWorldRequestAssetType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WorldLabs.ExportWorldRequestAssetType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.ExportWorldRequestAssetType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::WorldLabs.ExportWorldRequestAssetTypeExtensions.ToValueString(value));
        }
    }
}
