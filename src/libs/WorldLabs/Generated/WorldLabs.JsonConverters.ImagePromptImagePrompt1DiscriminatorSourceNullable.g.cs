#nullable enable

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImagePromptImagePrompt1DiscriminatorSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSource?>
    {
        /// <inheritdoc />
        public override global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSource? Read(
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
                        return global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
