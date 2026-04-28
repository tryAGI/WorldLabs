
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::WorldLabs.JsonConverters.ImagePromptImagePrompt1DiscriminatorSourceJsonConverter),

            typeof(global::WorldLabs.JsonConverters.ImagePromptImagePrompt1DiscriminatorSourceNullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.ListWorldsRequestModelVariant1JsonConverter),

            typeof(global::WorldLabs.JsonConverters.ListWorldsRequestModelVariant1NullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.ListWorldsRequestModelVariant2JsonConverter),

            typeof(global::WorldLabs.JsonConverters.ListWorldsRequestModelVariant2NullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.ListWorldsRequestSortByJsonConverter),

            typeof(global::WorldLabs.JsonConverters.ListWorldsRequestSortByNullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.ListWorldsRequestStatus2JsonConverter),

            typeof(global::WorldLabs.JsonConverters.ListWorldsRequestStatus2NullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.MediaAssetKindJsonConverter),

            typeof(global::WorldLabs.JsonConverters.MediaAssetKindNullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.PanoDepthToRgbRequestDepthPanoImageDiscriminatorSourceJsonConverter),

            typeof(global::WorldLabs.JsonConverters.PanoDepthToRgbRequestDepthPanoImageDiscriminatorSourceNullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.SphericallyLocatedContentInputContentDiscriminatorSourceJsonConverter),

            typeof(global::WorldLabs.JsonConverters.SphericallyLocatedContentInputContentDiscriminatorSourceNullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.VideoPromptInputVideoPromptDiscriminatorSourceJsonConverter),

            typeof(global::WorldLabs.JsonConverters.VideoPromptInputVideoPromptDiscriminatorSourceNullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldWorldPromptVariant1DiscriminatorTypeJsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldWorldPromptVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldsGenerateRequestModelVariant1JsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldsGenerateRequestModelVariant1NullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldsGenerateRequestModelVariant2JsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldsGenerateRequestModelVariant2NullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldsGenerateRequestWorldPromptDiscriminatorTypeJsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldsGenerateRequestWorldPromptDiscriminatorTypeNullableJsonConverter),

            typeof(global::WorldLabs.JsonConverters.ImagePrompt1JsonConverter),

            typeof(global::WorldLabs.JsonConverters.DepthPanoImageJsonConverter),

            typeof(global::WorldLabs.JsonConverters.Content2JsonConverter),

            typeof(global::WorldLabs.JsonConverters.VideoPromptJsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldPromptVariant1JsonConverter),

            typeof(global::WorldLabs.JsonConverters.WorldPromptJsonConverter),

            typeof(global::WorldLabs.JsonConverters.AnyOfJsonConverter<global::WorldLabs.World, global::WorldLabs.PanoDepthToRgbResult, object>),

            typeof(global::WorldLabs.JsonConverters.AnyOfJsonConverter<global::WorldLabs.ListWorldsRequestModelVariant1?, global::WorldLabs.ListWorldsRequestModelVariant2?, object>),

            typeof(global::WorldLabs.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::WorldLabs.JsonConverters.AnyOfJsonConverter<global::WorldLabs.WorldsGenerateRequestModelVariant1?, global::WorldLabs.WorldsGenerateRequestModelVariant2?>),

            typeof(global::WorldLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.Content))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.DataBase64Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.DeleteWorldResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.DepthPanoPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.GenerateWorldResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.OperationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.AnyOf<global::WorldLabs.World, global::WorldLabs.PanoDepthToRgbResult, object>), TypeInfoPropertyName = "AnyOfWorldPanoDepthToRgbResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.World))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.PanoDepthToRgbResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::WorldLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ImagePrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ImagePrompt1), TypeInfoPropertyName = "ImagePrompt12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.MediaAssetReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.UriReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ImagePromptImagePrompt1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ImagePromptImagePrompt1DiscriminatorSource), TypeInfoPropertyName = "ImagePromptImagePrompt1DiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ImageryAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.InpaintPanoPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ListWorldsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.AnyOf<global::WorldLabs.ListWorldsRequestModelVariant1?, global::WorldLabs.ListWorldsRequestModelVariant2?, object>), TypeInfoPropertyName = "AnyOfListWorldsRequestModelVariant1ListWorldsRequestModelVariant2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ListWorldsRequestModelVariant1), TypeInfoPropertyName = "ListWorldsRequestModelVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ListWorldsRequestModelVariant2), TypeInfoPropertyName = "ListWorldsRequestModelVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ListWorldsRequestSortBy), TypeInfoPropertyName = "ListWorldsRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ListWorldsRequestStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.ListWorldsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::WorldLabs.World>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.MediaAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.MediaAssetKind), TypeInfoPropertyName = "MediaAssetKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.MediaAssetPrepareUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.MediaAssetPrepareUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.UploadUrlInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.MeshAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.MultiImagePromptInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::WorldLabs.SphericallyLocatedContentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.SphericallyLocatedContentInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.MultiImagePromptOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::WorldLabs.SphericallyLocatedContentOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.SphericallyLocatedContentOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.OperationPanoDepthToRgbResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.PanoDepthToRgbRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.DepthPanoImage), TypeInfoPropertyName = "DepthPanoImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource), TypeInfoPropertyName = "PanoDepthToRgbRequestDepthPanoImageDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.Permission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.Content2), TypeInfoPropertyName = "Content22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.SphericallyLocatedContentInputContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSource), TypeInfoPropertyName = "SphericallyLocatedContentInputContentDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.SplatAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldSemanticsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::WorldLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.VideoPromptInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.VideoPrompt), TypeInfoPropertyName = "VideoPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.VideoPromptInputVideoPromptDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.VideoPromptInputVideoPromptDiscriminatorSource), TypeInfoPropertyName = "VideoPromptInputVideoPromptDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.VideoPromptOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldAssets2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldPromptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldTextPromptOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldWorldPromptVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldWorldPromptVariant1DiscriminatorType), TypeInfoPropertyName = "WorldWorldPromptVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldTextPromptInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldsGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.AnyOf<global::WorldLabs.WorldsGenerateRequestModelVariant1?, global::WorldLabs.WorldsGenerateRequestModelVariant2?>), TypeInfoPropertyName = "AnyOfWorldsGenerateRequestModelVariant1WorldsGenerateRequestModelVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldsGenerateRequestModelVariant1), TypeInfoPropertyName = "WorldsGenerateRequestModelVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldsGenerateRequestModelVariant2), TypeInfoPropertyName = "WorldsGenerateRequestModelVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldPrompt), TypeInfoPropertyName = "WorldPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminatorType), TypeInfoPropertyName = "WorldsGenerateRequestWorldPromptDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::WorldLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::WorldLabs.World>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::WorldLabs.SphericallyLocatedContentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::WorldLabs.SphericallyLocatedContentOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::WorldLabs.AnyOf<string, int?>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}