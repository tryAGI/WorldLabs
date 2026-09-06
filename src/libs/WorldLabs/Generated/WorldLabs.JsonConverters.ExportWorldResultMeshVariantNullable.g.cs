#nullable enable

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExportWorldResultMeshVariantNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.ExportWorldResultMeshVariant?>
    {
        /// <inheritdoc />
        public override global::WorldLabs.ExportWorldResultMeshVariant? Read(
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
                        return global::WorldLabs.ExportWorldResultMeshVariantExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WorldLabs.ExportWorldResultMeshVariant)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WorldLabs.ExportWorldResultMeshVariant?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.ExportWorldResultMeshVariant? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::WorldLabs.ExportWorldResultMeshVariantExtensions.ToValueString(value.Value));
            }
        }
    }
}
