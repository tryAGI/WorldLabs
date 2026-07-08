#nullable enable

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExportWorldResultAssetTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.ExportWorldResultAssetType?>
    {
        /// <inheritdoc />
        public override global::WorldLabs.ExportWorldResultAssetType? Read(
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
                        return global::WorldLabs.ExportWorldResultAssetTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WorldLabs.ExportWorldResultAssetType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WorldLabs.ExportWorldResultAssetType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.ExportWorldResultAssetType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::WorldLabs.ExportWorldResultAssetTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
