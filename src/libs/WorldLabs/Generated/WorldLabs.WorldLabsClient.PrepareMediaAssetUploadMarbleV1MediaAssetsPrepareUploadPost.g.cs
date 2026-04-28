
#nullable enable

namespace WorldLabs
{
    public partial class WorldLabsClient
    {


        private static readonly global::WorldLabs.EndPointSecurityRequirement s_PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostSecurityRequirement0 =
            new global::WorldLabs.EndPointSecurityRequirement
            {
                Authorizations = new global::WorldLabs.EndPointAuthorizationRequirement[]
                {                    new global::WorldLabs.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyWltApiKey",
                        Location = "Header",
                        Name = "WLT-Api-Key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::WorldLabs.EndPointSecurityRequirement[] s_PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostSecurityRequirements =
            new global::WorldLabs.EndPointSecurityRequirement[]
            {                s_PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostSecurityRequirement0,
            };
        partial void PreparePrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::WorldLabs.MediaAssetPrepareUploadRequest request);
        partial void PreparePrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::WorldLabs.MediaAssetPrepareUploadRequest request);
        partial void ProcessPrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Prepare a media asset upload<br/>
        /// Prepare a media asset upload for use in world generation.<br/>
        /// This API endpoint creates a media asset record and returns a signed upload URL.<br/>
        /// Use this workflow to upload images or videos that you want to reference in world<br/>
        /// generation requests.<br/>
        /// ## Workflow<br/>
        /// 1. **Prepare Upload** (this endpoint): Get a `media_asset_id` and `upload_url`<br/>
        /// 2. **Upload File**: Use the signed URL to upload your file<br/>
        /// 3. **Generate World**: Reference the `media_asset_id` in `/worlds:generate` with<br/>
        ///    source type "media_asset"<br/>
        /// ## Request Parameters<br/>
        /// - `file_name`: Your file's name (e.g., "landscape.jpg")<br/>
        /// - `extension`: File extension without dot (e.g., "jpg", "png", "mp4")<br/>
        /// - `kind`: Either "image" or "video"<br/>
        /// - `metadata`: Optional custom metadata object<br/>
        /// ## Response<br/>
        /// Returns a `MediaAssetPrepareUploadResponse` containing:<br/>
        /// - `media_asset`: Object with `media_asset_id` (use this in world generation)<br/>
        /// - `upload_info`: Object with `upload_url`, `required_headers`, and `curl_example`<br/>
        /// ## Uploading Your File<br/>
        /// Use the returned `upload_url` and `required_headers` to upload your file:<br/>
        /// ```bash<br/>
        /// curl --request PUT \<br/>
        ///   --url &lt;upload_url&gt; \<br/>
        ///   --header "Content-Type: &lt;content-type&gt;" \<br/>
        ///   --header "&lt;header-name&gt;: &lt;header-value&gt;" \<br/>
        ///   --upload-file /path/to/your/file<br/>
        /// ```<br/>
        /// Replace:<br/>
        /// - `&lt;upload_url&gt;`: The `upload_url` from the response<br/>
        /// - `&lt;content-type&gt;`: MIME type (e.g., `image/png`, `image/jpeg`, `video/mp4`)<br/>
        /// - `&lt;header-name&gt;: &lt;header-value&gt;`: Each header from `required_headers`<br/>
        /// - `/path/to/your/file`: Path to your local file<br/>
        /// ## Example Usage in World Generation<br/>
        /// After uploading, use the `media_asset_id` in a world generation request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "world_prompt": {<br/>
        ///     "type": "image",<br/>
        ///     "image_prompt": {<br/>
        ///       "source": "media_asset",<br/>
        ///       "media_asset_id": "&lt;your-media-asset-id&gt;"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::WorldLabs.MediaAssetPrepareUploadResponse> PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync(

            global::WorldLabs.MediaAssetPrepareUploadRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::WorldLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostSecurityRequirements,
                operationName: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync");

            using var __timeoutCancellationTokenSource = global::WorldLabs.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::WorldLabs.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::WorldLabs.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::WorldLabs.PathBuilder(
                                path: "/marble/v1/media-assets:prepare_upload",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::WorldLabs.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::WorldLabs.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::WorldLabs.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPost",
                                methodName: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync",
                                pathTemplate: "\"/marble/v1/media-assets:prepare_upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::WorldLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPost",
                                methodName: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync",
                                pathTemplate: "\"/marble/v1/media-assets:prepare_upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::WorldLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::WorldLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::WorldLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPost",
                                methodName: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync",
                                pathTemplate: "\"/marble/v1/media-assets:prepare_upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::WorldLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessPrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::WorldLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPost",
                                methodName: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync",
                                pathTemplate: "\"/marble/v1/media-assets:prepare_upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::WorldLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPost",
                                methodName: "PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync",
                                pathTemplate: "\"/marble/v1/media-assets:prepare_upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::WorldLabs.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::WorldLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::WorldLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::WorldLabs.ApiException<global::WorldLabs.HTTPValidationError>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessPrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::WorldLabs.MediaAssetPrepareUploadResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::WorldLabs.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::WorldLabs.MediaAssetPrepareUploadResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::WorldLabs.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Prepare a media asset upload<br/>
        /// Prepare a media asset upload for use in world generation.<br/>
        /// This API endpoint creates a media asset record and returns a signed upload URL.<br/>
        /// Use this workflow to upload images or videos that you want to reference in world<br/>
        /// generation requests.<br/>
        /// ## Workflow<br/>
        /// 1. **Prepare Upload** (this endpoint): Get a `media_asset_id` and `upload_url`<br/>
        /// 2. **Upload File**: Use the signed URL to upload your file<br/>
        /// 3. **Generate World**: Reference the `media_asset_id` in `/worlds:generate` with<br/>
        ///    source type "media_asset"<br/>
        /// ## Request Parameters<br/>
        /// - `file_name`: Your file's name (e.g., "landscape.jpg")<br/>
        /// - `extension`: File extension without dot (e.g., "jpg", "png", "mp4")<br/>
        /// - `kind`: Either "image" or "video"<br/>
        /// - `metadata`: Optional custom metadata object<br/>
        /// ## Response<br/>
        /// Returns a `MediaAssetPrepareUploadResponse` containing:<br/>
        /// - `media_asset`: Object with `media_asset_id` (use this in world generation)<br/>
        /// - `upload_info`: Object with `upload_url`, `required_headers`, and `curl_example`<br/>
        /// ## Uploading Your File<br/>
        /// Use the returned `upload_url` and `required_headers` to upload your file:<br/>
        /// ```bash<br/>
        /// curl --request PUT \<br/>
        ///   --url &lt;upload_url&gt; \<br/>
        ///   --header "Content-Type: &lt;content-type&gt;" \<br/>
        ///   --header "&lt;header-name&gt;: &lt;header-value&gt;" \<br/>
        ///   --upload-file /path/to/your/file<br/>
        /// ```<br/>
        /// Replace:<br/>
        /// - `&lt;upload_url&gt;`: The `upload_url` from the response<br/>
        /// - `&lt;content-type&gt;`: MIME type (e.g., `image/png`, `image/jpeg`, `video/mp4`)<br/>
        /// - `&lt;header-name&gt;: &lt;header-value&gt;`: Each header from `required_headers`<br/>
        /// - `/path/to/your/file`: Path to your local file<br/>
        /// ## Example Usage in World Generation<br/>
        /// After uploading, use the `media_asset_id` in a world generation request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "world_prompt": {<br/>
        ///     "type": "image",<br/>
        ///     "image_prompt": {<br/>
        ///       "source": "media_asset",<br/>
        ///       "media_asset_id": "&lt;your-media-asset-id&gt;"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="extension">
        /// File extension without dot
        /// </param>
        /// <param name="fileName">
        /// File name
        /// </param>
        /// <param name="kind">
        /// High-level media type
        /// </param>
        /// <param name="metadata">
        /// Optional application-specific metadata
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::WorldLabs.MediaAssetPrepareUploadResponse> PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync(
            string fileName,
            global::WorldLabs.MediaAssetKind kind,
            string? extension = default,
            object? metadata = default,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::WorldLabs.MediaAssetPrepareUploadRequest
            {
                Extension = extension,
                FileName = fileName,
                Kind = kind,
                Metadata = metadata,
            };

            return await PrepareMediaAssetUploadMarbleV1MediaAssetsPrepareUploadPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}