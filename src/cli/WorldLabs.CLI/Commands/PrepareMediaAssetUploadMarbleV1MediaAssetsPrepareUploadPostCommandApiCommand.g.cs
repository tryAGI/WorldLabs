#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace WorldLabs.CLI.Commands;

internal static partial class PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostCommandApiCommand
{
    private static Option<string?> Extension { get; } = new(
        name: @"--extension")
    {
        Description = @"File extension without dot",
    };

    private static Option<string> FileName { get; } = new(
        name: @"--file-name")
    {
        Description = @"File name",
        Required = true,
    };

    private static Option<global::WorldLabs.MediaAssetKind> Kind { get; } = new(
        name: @"--kind")
    {
        Description = @"High-level media type",
        Required = true,
    };

    private static Option<object?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Optional application-specific metadata",
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

                    private static string FormatResponse(ParseResult parseResult, global::WorldLabs.MediaAssetPrepareUploadResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::WorldLabs.MediaAssetPrepareUploadResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"prepare-media-asset-upload-marble-v1-media-assets-prepare-upload-post", @"Prepare a media asset upload
Prepare a media asset upload for use in world generation.

This API endpoint creates a media asset record and returns a signed upload URL.
Use this workflow to upload images or videos that you want to reference in world
generation requests.

## Workflow

1. **Prepare Upload** (this endpoint): Get a `media_asset_id` and `upload_url`
2. **Upload File**: Use the signed URL to upload your file
3. **Generate World**: Reference the `media_asset_id` in `/worlds:generate` with
   source type ""media_asset""

## Request Parameters

- `file_name`: Your file's name (e.g., ""landscape.jpg"")
- `extension`: File extension without dot (e.g., ""jpg"", ""png"", ""mp4"")
- `kind`: Either ""image"" or ""video""
- `metadata`: Optional custom metadata object

## Response

Returns a `MediaAssetPrepareUploadResponse` containing:

- `media_asset`: Object with `media_asset_id` (use this in world generation)
- `upload_info`: Object with `upload_url`, `required_headers`, and `curl_example`

## Uploading Your File

Use the returned `upload_url` and `required_headers` to upload your file:

```bash
curl --request PUT \
  --url &lt;upload_url&gt; \
  --header ""Content-Type: &lt;content-type&gt;"" \
  --header ""&lt;header-name&gt;: &lt;header-value&gt;"" \
  --upload-file /path/to/your/file
```

Replace:
- `&lt;upload_url&gt;`: The `upload_url` from the response
- `&lt;content-type&gt;`: MIME type (e.g., `image/png`, `image/jpeg`, `video/mp4`)
- `&lt;header-name&gt;: &lt;header-value&gt;`: Each header from `required_headers`
- `/path/to/your/file`: Path to your local file

## Example Usage in World Generation

After uploading, use the `media_asset_id` in a world generation request:

```json
{
  ""world_prompt"": {
    ""type"": ""image"",
    ""image_prompt"": {
      ""source"": ""media_asset"",
      ""media_asset_id"": ""&lt;your-media-asset-id&gt;""
    }
  }
}
```");
                        command.Options.Add(Extension);
                        command.Options.Add(FileName);
                        command.Options.Add(Kind);
                        command.Options.Add(Metadata);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::WorldLabs.MediaAssetPrepareUploadRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::WorldLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var extension = CliRuntime.WasSpecified(parseResult, Extension) ? parseResult.GetValue(Extension) : __requestBase is not null ? __requestBase.Extension : default;
                        var fileName = parseResult.GetRequiredValue(FileName);
                        var kind = parseResult.GetRequiredValue(Kind);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : __requestBase is not null ? __requestBase.Metadata : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync(
                                    extension: extension,
                                    fileName: fileName,
                                    kind: kind,
                                    metadata: metadata,
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