#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class DeleteWorldMarbleV1WorldsWorldIdDeleteCommandApiCommand
{
    private static Argument<string> WorldId { get; } = new(
        name: @"world-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::WorldLabs.DeleteWorldResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::WorldLabs.DeleteWorldResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-world-marble-v1-worlds-world-id-delete", @"Delete World
Delete a world by ID.

Permanently deletes a world and its associated assets.
Only the world owner can delete a world.

Args:
    world_id: The unique identifier of the world to delete.

Returns:
    DeleteWorldResponse confirming the deletion.

Raises:
    HTTPException: 403 if user is not the world owner
    HTTPException: 404 if world not found
    HTTPException: 500 if deletion fails");
                        command.Arguments.Add(WorldId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var worldId = parseResult.GetRequiredValue(WorldId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DeleteWorldMarbleV1WorldsWorldIdDeleteAsync(
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