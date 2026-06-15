#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class ListWorldsMarbleV1WorldsListPostCommandApiCommand
{
    private static Option<global::System.DateTime?> CreatedAfter { get; } = new(
        name: @"--created-after")
    {
        Description = @"Filter worlds created after this timestamp (inclusive)",
    };

    private static Option<global::System.DateTime?> CreatedBefore { get; } = new(
        name: @"--created-before")
    {
        Description = @"Filter worlds created before this timestamp (exclusive)",
    };

    private static Option<bool?> IsPublic { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-public",
        description: @"Filter by visibility. true=public only, false=private only, null=all");

    private static Option<global::WorldLabs.AnyOf<global::WorldLabs.ListWorldsRequestModelVariant1?, global::WorldLabs.ListWorldsRequestModelVariant2?, object>?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Filter by model used for generation. Legacy names are deprecated; use the new lowercase names.",
    };

    private static Option<int?> PageSize { get; } = new(
        name: @"--page-size")
    {
        Description = @"Number of results per page (1-100)",
    };

    private static Option<string?> PageToken { get; } = new(
        name: @"--page-token")
    {
        Description = @"Cursor token for pagination (opaque base64 string from previous response). Use cursor from next_page_token in previous response for consistent pagination.",
    };

    private static Option<global::WorldLabs.ListWorldsRequestSortBy?> SortBy { get; } = new(
        name: @"--sort-by")
    {
        Description = @"Sort results by created_at or updated_at",
    };

    private static Option<global::WorldLabs.ListWorldsRequestStatus2?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter by world status",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Filter by tags (returns worlds with ANY of these tags)",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::WorldLabs.ListWorldsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::WorldLabs.ListWorldsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-worlds-marble-v1-worlds-list-post", @"List Worlds
List worlds with optional filters.

Returns worlds created through the API with optional filtering and pagination.

Args:
    request: List request with optional filters:
        - page_size: Number of results per page (default: 10)
        - page_token: Pagination token from previous response
        - status: Filter by status (e.g., ""COMPLETED"")
        - model: Filter by model name (e.g., ""marble-1.0-plus"")
        - tags: Filter by tags (matches worlds with any tag)
        - is_public: Filter by visibility (true=public, false=private, null=all)
        - created_after: Filter by creation time (after timestamp)
        - created_before: Filter by creation time (before timestamp)
        - sort_by: Sort order (""created_at"" or ""updated_at"")

Returns:
    ListWorldsResponse with worlds list and next_page_token for pagination.

Raises:
    HTTPException: 400 if invalid parameters
    HTTPException: 500 if request fails");
                        command.Options.Add(CreatedAfter);
                        command.Options.Add(CreatedBefore);
                        command.Options.Add(IsPublic);
                        command.Options.Add(Model);
                        command.Options.Add(PageSize);
                        command.Options.Add(PageToken);
                        command.Options.Add(SortBy);
                        command.Options.Add(Status);
                        command.Options.Add(Tags);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::WorldLabs.ListWorldsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::WorldLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var createdAfter = CliRuntime.WasSpecified(parseResult, CreatedAfter) ? parseResult.GetValue(CreatedAfter) : __requestBase is not null ? __requestBase.CreatedAfter : default;
                        var createdBefore = CliRuntime.WasSpecified(parseResult, CreatedBefore) ? parseResult.GetValue(CreatedBefore) : __requestBase is not null ? __requestBase.CreatedBefore : default;
                        var isPublic = CliRuntime.WasSpecified(parseResult, IsPublic) ? parseResult.GetValue(IsPublic) : __requestBase is not null ? __requestBase.IsPublic : default;
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : __requestBase is not null ? __requestBase.Model : default;
                        var pageSize = CliRuntime.WasSpecified(parseResult, PageSize) ? parseResult.GetValue(PageSize) : __requestBase is not null ? __requestBase.PageSize : default;
                        var pageToken = CliRuntime.WasSpecified(parseResult, PageToken) ? parseResult.GetValue(PageToken) : __requestBase is not null ? __requestBase.PageToken : default;
                        var sortBy = CliRuntime.WasSpecified(parseResult, SortBy) ? parseResult.GetValue(SortBy) : __requestBase is not null ? __requestBase.SortBy : default;
                        var status = CliRuntime.WasSpecified(parseResult, Status) ? parseResult.GetValue(Status) : __requestBase is not null ? __requestBase.Status : default;
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : __requestBase is not null ? __requestBase.Tags : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ListWorldsMarbleV1WorldsListPostAsync(
                                    createdAfter: createdAfter,
                                    createdBefore: createdBefore,
                                    isPublic: isPublic,
                                    model: model,
                                    pageSize: pageSize,
                                    pageToken: pageToken,
                                    sortBy: sortBy,
                                    status: status,
                                    tags: tags,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::WorldLabs.SourceGenerationContext.Default,
                                        @"Worlds",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::WorldLabs.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}