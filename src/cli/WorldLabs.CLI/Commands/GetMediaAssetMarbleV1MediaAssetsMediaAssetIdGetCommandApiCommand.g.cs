#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class GetMediaAssetMarbleV1MediaAssetsMediaAssetIdGetCommandApiCommand
{
    private static Argument<string> MediaAssetId { get; } = new(
        name: @"media-asset-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::WorldLabs.MediaAsset value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::WorldLabs.MediaAsset value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-media-asset-marble-v1-media-assets-media-asset-id-get", @"Get Media Asset
Get a media asset by ID.

Retrieves metadata for a previously created media asset.

Args:
    media_asset_id: The media asset identifier.

Returns:
    MediaAsset object with media_asset_id, file_name, extension, kind,
    metadata, created_at, and updated_at.

Raises:
    HTTPException: 404 if not found");
                        command.Arguments.Add(MediaAssetId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var mediaAssetId = parseResult.GetRequiredValue(MediaAssetId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetMediaAssetMarbleV1MediaAssetsMediaAssetIdGetAsync(
                                    mediaAssetId: mediaAssetId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::WorldLabs.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}