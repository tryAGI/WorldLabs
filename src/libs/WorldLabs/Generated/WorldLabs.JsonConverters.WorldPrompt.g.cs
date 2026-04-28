#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public class WorldPromptJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.WorldPrompt>
    {
        /// <inheritdoc />
        public override global::WorldLabs.WorldPrompt Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::WorldLabs.WorldTextPromptInput? text = default;
            if (discriminator?.Type == global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.WorldTextPromptInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.WorldTextPromptInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.WorldTextPromptInput)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.ImagePrompt? image = default;
            if (discriminator?.Type == global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.ImagePrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.ImagePrompt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.ImagePrompt)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.MultiImagePromptInput? multiImage = default;
            if (discriminator?.Type == global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminatorType.MultiImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.MultiImagePromptInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.MultiImagePromptInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.MultiImagePromptInput)}");
                multiImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.VideoPromptInput? video = default;
            if (discriminator?.Type == global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.VideoPromptInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.VideoPromptInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.VideoPromptInput)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::WorldLabs.WorldPrompt(
                discriminator?.Type,
                text,

                image,

                multiImage,

                video
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.WorldPrompt value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.WorldTextPromptInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.WorldTextPromptInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.WorldTextPromptInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.ImagePrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.ImagePrompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.ImagePrompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsMultiImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.MultiImagePromptInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.MultiImagePromptInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.MultiImagePromptInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MultiImage!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.VideoPromptInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.VideoPromptInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.VideoPromptInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
        }
    }
}