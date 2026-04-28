#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace WorldLabs.JsonConverters
{
    /// <inheritdoc />
    public class DepthPanoImageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WorldLabs.DepthPanoImage>
    {
        /// <inheritdoc />
        public override global::WorldLabs.DepthPanoImage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::WorldLabs.MediaAssetReference? mediaAsset = default;
            if (discriminator?.Source == global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource.MediaAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.MediaAssetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.MediaAssetReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.MediaAssetReference)}");
                mediaAsset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.UriReference? uri = default;
            if (discriminator?.Source == global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource.Uri)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.UriReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.UriReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.UriReference)}");
                uri = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::WorldLabs.DataBase64Reference? dataBase64 = default;
            if (discriminator?.Source == global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource.DataBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.DataBase64Reference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.DataBase64Reference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::WorldLabs.DataBase64Reference)}");
                dataBase64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::WorldLabs.DepthPanoImage(
                discriminator?.Source,
                mediaAsset,

                uri,

                dataBase64
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WorldLabs.DepthPanoImage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMediaAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.MediaAssetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.MediaAssetReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.MediaAssetReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MediaAsset!, typeInfo);
            }
            else if (value.IsUri)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.UriReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.UriReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.UriReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Uri!, typeInfo);
            }
            else if (value.IsDataBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WorldLabs.DataBase64Reference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WorldLabs.DataBase64Reference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WorldLabs.DataBase64Reference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DataBase64!, typeInfo);
            }
        }
    }
}