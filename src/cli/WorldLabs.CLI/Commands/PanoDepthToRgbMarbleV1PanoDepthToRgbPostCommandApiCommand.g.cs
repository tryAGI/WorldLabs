#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class PanoDepthToRgbMarbleV1PanoDepthToRgbPostCommandApiCommand
{
    private static Option<global::WorldLabs.DepthPanoImage> DepthPanoImage { get; } = new(
        name: @"--depth-pano-image")
    {
        Description = @"Depth panorama image (EXR or PNG). Provide via URI, media_asset, or base64 (max 100 MB).",
        Required = true,
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Random seed for reproducible generation.",
    };

    private static Option<string> TextPrompt { get; } = new(
        name: @"--text-prompt")
    {
        Description = @"Text description of the desired appearance.",
        Required = true,
    };

    private static Option<double?> ZMax { get; } = new(
        name: @"--z-max")
    {
        Description = @"Maximum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_min and must be greater than z_min. Omit for EXR depth maps.",
    };

    private static Option<double?> ZMin { get; } = new(
        name: @"--z-min")
    {
        Description = @"Minimum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_max. Omit for EXR depth maps.",
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

                    private static string FormatResponse(ParseResult parseResult, global::WorldLabs.OperationPanoDepthToRgbResult value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::WorldLabs.OperationPanoDepthToRgbResult value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"pano-depth-to-rgb-marble-v1-pano-depth-to-rgb-post", @"Pano Depth To Rgb
Generate an RGB panorama from a depth panorama.

Provide a depth panorama and a text prompt
describing the desired appearance. The depth map
supplies the scene geometry; the model synthesizes
textures that match that geometry and returns a
panoramic RGB image.

Accepted depth inputs:

* **EXR**: float depth values. Omit
  ``z_min`` and ``z_max``.
* **PNG**: depth values normalized to [0, 1].
  Provide both ``z_min`` and ``z_max`` so the
  service can decode the PNG correctly.

For a complete PNG-based workflow, see the
[web-chisel-depth-png example](https://github.com/worldlabsai/worldlabs-api-examples/tree/main/web-chisel-depth-png).

Returns a long-running ``Operation``. Poll
``GET /operations/{operation_id}`` until
``done`` is ``true``, then read the generated
panorama URL from ``response.pano_url``.

Raises:
    HTTPException: 400 if invalid request
    HTTPException: 402 if insufficient credits
    HTTPException: 500 if generation could not start");
                        command.Options.Add(DepthPanoImage);
                        command.Options.Add(Seed);
                        command.Options.Add(TextPrompt);
                        command.Options.Add(ZMax);
                        command.Options.Add(ZMin);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::WorldLabs.PanoDepthToRgbRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::WorldLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var depthPanoImage = parseResult.GetRequiredValue(DepthPanoImage);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var textPrompt = parseResult.GetRequiredValue(TextPrompt);
                        var zMax = CliRuntime.WasSpecified(parseResult, ZMax) ? parseResult.GetValue(ZMax) : (__requestBase is { } __ZMaxBaseValue ? __ZMaxBaseValue.ZMax : default);
                        var zMin = CliRuntime.WasSpecified(parseResult, ZMin) ? parseResult.GetValue(ZMin) : (__requestBase is { } __ZMinBaseValue ? __ZMinBaseValue.ZMin : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync(
                                    depthPanoImage: depthPanoImage,
                                    seed: seed,
                                    textPrompt: textPrompt,
                                    zMax: zMax,
                                    zMin: zMin,
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