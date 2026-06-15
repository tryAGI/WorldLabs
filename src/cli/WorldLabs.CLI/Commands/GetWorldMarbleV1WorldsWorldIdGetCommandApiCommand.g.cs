#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class GetWorldMarbleV1WorldsWorldIdGetCommandApiCommand
{
    private static Argument<string> WorldId { get; } = new(
        name: @"world-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::WorldLabs.World value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::WorldLabs.World value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-world-marble-v1-worlds-world-id-get", @"Get World
Get a world by ID.

Retrieves a world's details including generated assets if available.
Only the world owner or users with access to public worlds can retrieve them.

Args:
    world_id: The unique identifier of the world.

Returns:
    World object with world_id, display_name, tags, assets, created_at,
    updated_at, permission, model, world_prompt, and world_marble_url.

Raises:
    HTTPException: 404 if world not found or access denied");
                        command.Arguments.Add(WorldId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var worldId = parseResult.GetRequiredValue(WorldId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetWorldMarbleV1WorldsWorldIdGetAsync(
                                    worldId: worldId,
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