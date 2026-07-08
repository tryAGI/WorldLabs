#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class ExportWorldMarbleV1WorldsWorldIdExportPostCommandApiCommand
{
    private static Argument<string> WorldId { get; } = new(
        name: @"world-id")
    {
        Description = @"",
    };

    private static Option<global::WorldLabs.ExportWorldRequestAssetType> AssetType { get; } = new(
        name: @"--asset-type")
    {
        Description = @"Asset family to export: 'splats' or 'mesh'.",
        Required = true,
    };

    private static Option<global::WorldLabs.ExportWorldRequestFormat> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Requested export format.",
        Required = true,
    };

    private static Option<global::WorldLabs.ExportWorldRequestMeshVariant?> MeshVariant { get; } = new(
        name: @"--mesh-variant")
    {
        Description = @"Mesh variant to return when an HQ mesh already exists.",
    };

    private static Option<global::WorldLabs.ExportWorldRequestResolution?> Resolution { get; } = new(
        name: @"--resolution")
    {
        Description = @"Splat resolution to convert when exporting splats as PLY.",
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

                    private static string FormatResponse(ParseResult parseResult, global::WorldLabs.ExportWorldResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::WorldLabs.ExportWorldResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"export-world-marble-v1-worlds-world-id-export-post", @"Export World
Export a generated world asset.

PLY splat exports are converted synchronously, cached in GCS, and returned
as completed operations. HQ mesh exports reuse the existing async mesh
export service and return an in-progress operation.");
                        command.Arguments.Add(WorldId);
                        command.Options.Add(AssetType);
                        command.Options.Add(Format);
                        command.Options.Add(MeshVariant);
                        command.Options.Add(Resolution);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::WorldLabs.ExportWorldRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::WorldLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var worldId = parseResult.GetRequiredValue(WorldId);
                        var assetType = parseResult.GetRequiredValue(AssetType);
                        var format = parseResult.GetRequiredValue(Format);
                        var meshVariant = CliRuntime.WasSpecified(parseResult, MeshVariant) ? parseResult.GetValue(MeshVariant) : (__requestBase is { } __MeshVariantBaseValue ? __MeshVariantBaseValue.MeshVariant : default);
                        var resolution = CliRuntime.WasSpecified(parseResult, Resolution) ? parseResult.GetValue(Resolution) : (__requestBase is { } __ResolutionBaseValue ? __ResolutionBaseValue.Resolution : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ExportWorldMarbleV1WorldsWorldIdExportPostAsync(
                                    worldId: worldId,
                                    assetType: assetType,
                                    format: format,
                                    meshVariant: meshVariant,
                                    resolution: resolution,
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