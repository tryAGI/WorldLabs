#nullable enable

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExportWorldRequestMeshVariantNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.ExportWorldRequestMeshVariant?>
    {
        /// <inheritdoc />
        public override global::WorldLabs.ExportWorldRequestMeshVariant? Read(
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
                        return global::WorldLabs.ExportWorldRequestMeshVariantExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WorldLabs.ExportWorldRequestMeshVariant)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WorldLabs.ExportWorldRequestMeshVariant?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.ExportWorldRequestMeshVariant? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::WorldLabs.ExportWorldRequestMeshVariantExtensions.ToValueString(value.Value));
            }
        }
    }
}
