#nullable enable

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class SphericallyLocatedContentInputContentDiscriminatorSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSource?>
    {
        /// <inheritdoc />
        public override global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSource? Read(
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
                        return global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
