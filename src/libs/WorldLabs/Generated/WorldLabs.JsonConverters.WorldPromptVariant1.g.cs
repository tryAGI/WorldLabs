#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public class WorldPromptVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.WorldPromptVariant1>
    {
        /// <inheritdoc />
        public override global::WorldLabs.WorldPromptVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.WorldWorldPromptVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.WorldWorldPromptVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.WorldWorldPromptVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::WorldLabs.WorldTextPromptOutput? text = default;
            if (discriminator?.Type == global::WorldLabs.WorldWorldPromptVariant1DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.WorldTextPromptOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.WorldTextPromptOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.WorldTextPromptOutput)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.Prompt? depthPano1 = default;
            if (discriminator?.Type == global::WorldLabs.WorldWorldPromptVariant1DiscriminatorType.DepthPano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.Prompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.Prompt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.Prompt)}");
                depthPano1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.MultiImagePromptOutput? multiImage = default;
            if (discriminator?.Type == global::WorldLabs.WorldWorldPromptVariant1DiscriminatorType.MultiImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.MultiImagePromptOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.MultiImagePromptOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.MultiImagePromptOutput)}");
                multiImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.VideoPromptOutput? video = default;
            if (discriminator?.Type == global::WorldLabs.WorldWorldPromptVariant1DiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.VideoPromptOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.VideoPromptOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.VideoPromptOutput)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.DepthPanoPrompt? depthPano2 = default;
            if (discriminator?.Type == global::WorldLabs.WorldWorldPromptVariant1DiscriminatorType.DepthPano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.DepthPanoPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.DepthPanoPrompt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.DepthPanoPrompt)}");
                depthPano2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.InpaintPanoPrompt? inpaintPano = default;
            if (discriminator?.Type == global::WorldLabs.WorldWorldPromptVariant1DiscriminatorType.InpaintPano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.InpaintPanoPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.InpaintPanoPrompt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.InpaintPanoPrompt)}");
                inpaintPano = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::WorldLabs.WorldPromptVariant1(
                discriminator?.Type,
                text,

                depthPano1,

                multiImage,

                video,

                depthPano2,

                inpaintPano
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.WorldPromptVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.WorldTextPromptOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.WorldTextPromptOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.WorldTextPromptOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsDepthPano1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.Prompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.Prompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.Prompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DepthPano1!, typeInfo);
            }
            else if (value.IsMultiImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.MultiImagePromptOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.MultiImagePromptOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.MultiImagePromptOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MultiImage!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.VideoPromptOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.VideoPromptOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.VideoPromptOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsDepthPano2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.DepthPanoPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.DepthPanoPrompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.DepthPanoPrompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DepthPano2!, typeInfo);
            }
            else if (value.IsInpaintPano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.InpaintPanoPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.InpaintPanoPrompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.InpaintPanoPrompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InpaintPano!, typeInfo);
            }
        }
    }
}