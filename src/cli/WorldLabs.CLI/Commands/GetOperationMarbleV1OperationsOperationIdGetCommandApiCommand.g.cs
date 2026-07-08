#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class GetOperationMarbleV1OperationsOperationIdGetCommandApiCommand
{
    private static Argument<string> OperationId { get; } = new(
        name: @"operation-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResultExportWorldResult value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResultExportWorldResult value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-operation-marble-v1-operations-operation-id-get", @"Get Operation
Get an operation by ID.

Poll this endpoint to check the status of a long-running operation.
When done=true, the response field contains the generated world.

Args:
    operation_id: The operation identifier from /worlds:generate.

Returns:
    GetOperationResponse[World] with:
        - operation_id: Operation identifier
        - created_at: Creation timestamp
        - updated_at: Last update timestamp
        - expires_at: Expiration timestamp
        - done: true when complete, false while in progress
        - error: Error details if failed, null otherwise
        - metadata: Progress information and world_id
        - response: Generated World if done=true, null otherwise
        - cost: Settled credit cost breakdown; populated only when the
          operation completed successfully (done=true with no error)
          and a public price is known for its operation type. Failed
          or in-progress operations return null.

Raises:
    HTTPException: 401 if unauthorized
    HTTPException: 404 if operation not found
    HTTPException: 500 if request fails");
                        command.Arguments.Add(OperationId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var operationId = parseResult.GetRequiredValue(OperationId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetOperationMarbleV1OperationsOperationIdGetAsync(
                                    operationId: operationId,
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