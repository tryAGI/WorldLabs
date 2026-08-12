#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class GenerateWorldMarbleV1WorldsGeneratePostCommandApiCommand
{
    private static Option<string?> DisplayName { get; } = new(
        name: @"--display-name")
    {
        Description = @"Optional human-readable title for the world (max 64 characters). Stored as world metadata and returned in world responses; does not affect generation. If omitted, World Labs may generate a title from the prompt.",
    };

    private static Option<global::WorldLabs.AnyOf<global::WorldLabs.WorldsGenerateRequestModelVariant1?, global::WorldLabs.WorldsGenerateRequestModelVariant2?>?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use for generation. marble-1.1-plus includes dynamic world sizing. Legacy names ('Marble 0.1-plus', etc.) still work but are deprecated and will be removed in a future release.",
    };

    private static Option<global::WorldLabs.Permission?> Permission { get; } = new(
        name: @"--permission")
    {
        Description = @"The permission for the world",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Random seed for generation",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Optional tags for the world (max 10 tags, each up to 32 characters)",
    };

    private static Option<global::WorldLabs.WorldPrompt> WorldPrompt { get; } = new(
        name: @"--world-prompt")
    {
        Description = @"The prompt specifying how to generate the world",
        Required = true,
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

                    private static string FormatResponse(ParseResult parseResult, global::WorldLabs.GenerateWorldResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::WorldLabs.GenerateWorldResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate-world-marble-v1-worlds-generate-post", @"Generate World
Start world generation.

Creates a new world generation job and returns a long-running operation.
Poll the /operations/{operation_id} endpoint to check generation status
and retrieve the generated world when complete.

Args:
    request: The world generation request containing world_prompt, display_name,
        tags, model, seed, and permission settings.

Returns:
    GenerateWorldResponse with operation_id and timestamps. Use the operation_id
    to poll for completion.

Raises:
    HTTPException: 400 if invalid request or content violates policies
    HTTPException: 402 if insufficient credits
    HTTPException: 500 if generation could not be started");
                        command.Options.Add(DisplayName);
                        command.Options.Add(Model);
                        command.Options.Add(Permission);
                        command.Options.Add(Seed);
                        command.Options.Add(Tags);
                        command.Options.Add(WorldPrompt);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::WorldLabs.WorldsGenerateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::WorldLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var displayName = CliRuntime.WasSpecified(parseResult, DisplayName) ? parseResult.GetValue(DisplayName) : (__requestBase is { } __DisplayNameBaseValue ? __DisplayNameBaseValue.DisplayName : default);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var permission = CliRuntime.WasSpecified(parseResult, Permission) ? parseResult.GetValue(Permission) : (__requestBase is { } __PermissionBaseValue ? __PermissionBaseValue.Permission : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : (__requestBase is { } __TagsBaseValue ? __TagsBaseValue.Tags : default);
                        var worldPrompt = parseResult.GetRequiredValue(WorldPrompt);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GenerateWorldMarbleV1WorldsGeneratePostAsync(
                                    displayName: displayName,
                                    model: model,
                                    permission: permission,
                                    seed: seed,
                                    tags: tags,
                                    worldPrompt: worldPrompt,
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