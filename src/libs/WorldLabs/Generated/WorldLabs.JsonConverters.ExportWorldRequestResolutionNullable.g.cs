#nullable enable

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExportWorldRequestResolutionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.ExportWorldRequestResolution?>
    {
        /// <inheritdoc />
        public override global::WorldLabs.ExportWorldRequestResolution? Read(
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
                        return global::WorldLabs.ExportWorldRequestResolutionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WorldLabs.ExportWorldRequestResolution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WorldLabs.ExportWorldRequestResolution?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.ExportWorldRequestResolution? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::WorldLabs.ExportWorldRequestResolutionExtensions.ToValueString(value.Value));
            }
        }
    }
}
