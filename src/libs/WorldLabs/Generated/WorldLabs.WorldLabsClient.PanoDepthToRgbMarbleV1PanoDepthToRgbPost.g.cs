
#nullable enable

namespace WorldLabs
{
    public partial class WorldLabsClient
    {


        private static readonly global::WorldLabs.EndPointSecurityRequirement s_PanoDepthToRgbMarbleV1PanoDepthToRgbPostSecurityRequirement0 =
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
        private static readonly global::WorldLabs.EndPointSecurityRequirement[] s_PanoDepthToRgbMarbleV1PanoDepthToRgbPostSecurityRequirements =
            new global::WorldLabs.EndPointSecurityRequirement[]
            {                s_PanoDepthToRgbMarbleV1PanoDepthToRgbPostSecurityRequirement0,
            };
        partial void PreparePanoDepthToRgbMarbleV1PanoDepthToRgbPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::WorldLabs.PanoDepthToRgbRequest request);
        partial void PreparePanoDepthToRgbMarbleV1PanoDepthToRgbPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::WorldLabs.PanoDepthToRgbRequest request);
        partial void ProcessPanoDepthToRgbMarbleV1PanoDepthToRgbPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPanoDepthToRgbMarbleV1PanoDepthToRgbPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Pano Depth To Rgb<br/>
        /// Generate an RGB panorama from a depth panorama.<br/>
        /// Provide a depth panorama and a text prompt<br/>
        /// describing the desired appearance. The depth map<br/>
        /// supplies the scene geometry; the model synthesizes<br/>
        /// textures that match that geometry and returns a<br/>
        /// panoramic RGB image.<br/>
        /// Accepted depth inputs:<br/>
        /// * **EXR**: float depth values. Omit<br/>
        ///   ``z_min`` and ``z_max``.<br/>
        /// * **PNG**: depth values normalized to [0, 1].<br/>
        ///   Provide both ``z_min`` and ``z_max`` so the<br/>
        ///   service can decode the PNG correctly.<br/>
        /// For a complete PNG-based workflow, see the<br/>
        /// [web-chisel-depth-png example](https://github.com/worldlabsai/worldlabs-api-examples/tree/main/web-chisel-depth-png).<br/>
        /// Returns a long-running ``Operation``. Poll<br/>
        /// ``GET /operations/{operation_id}`` until<br/>
        /// ``done`` is ``true``, then read the generated<br/>
        /// panorama URL from ``response.pano_url``.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid request<br/>
        ///     HTTPException: 402 if insufficient credits<br/>
        ///     HTTPException: 500 if generation could not start
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::WorldLabs.OperationPanoDepthToRgbResult> PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync(

            global::WorldLabs.PanoDepthToRgbRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Pano Depth To Rgb<br/>
        /// Generate an RGB panorama from a depth panorama.<br/>
        /// Provide a depth panorama and a text prompt<br/>
        /// describing the desired appearance. The depth map<br/>
        /// supplies the scene geometry; the model synthesizes<br/>
        /// textures that match that geometry and returns a<br/>
        /// panoramic RGB image.<br/>
        /// Accepted depth inputs:<br/>
        /// * **EXR**: float depth values. Omit<br/>
        ///   ``z_min`` and ``z_max``.<br/>
        /// * **PNG**: depth values normalized to [0, 1].<br/>
        ///   Provide both ``z_min`` and ``z_max`` so the<br/>
        ///   service can decode the PNG correctly.<br/>
        /// For a complete PNG-based workflow, see the<br/>
        /// [web-chisel-depth-png example](https://github.com/worldlabsai/worldlabs-api-examples/tree/main/web-chisel-depth-png).<br/>
        /// Returns a long-running ``Operation``. Poll<br/>
        /// ``GET /operations/{operation_id}`` until<br/>
        /// ``done`` is ``true``, then read the generated<br/>
        /// panorama URL from ``response.pano_url``.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid request<br/>
        ///     HTTPException: 402 if insufficient credits<br/>
        ///     HTTPException: 500 if generation could not start
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.OperationPanoDepthToRgbResult>> PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsResponseAsync(

            global::WorldLabs.PanoDepthToRgbRequest request,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePanoDepthToRgbMarbleV1PanoDepthToRgbPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::WorldLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PanoDepthToRgbMarbleV1PanoDepthToRgbPostSecurityRequirements,
                operationName: "PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync");

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
                                path: "/marble/v1/pano:depth_to_rgb",
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
                PreparePanoDepthToRgbMarbleV1PanoDepthToRgbPostRequest(
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
                                operationId: "PanoDepthToRgbMarbleV1PanoDepthToRgbPost",
                                methodName: "PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync",
                                pathTemplate: "\"/marble/v1/pano:depth_to_rgb\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::WorldLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::WorldLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PanoDepthToRgbMarbleV1PanoDepthToRgbPost",
                                methodName: "PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync",
                                pathTemplate: "\"/marble/v1/pano:depth_to_rgb\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::WorldLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::WorldLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::WorldLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::WorldLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PanoDepthToRgbMarbleV1PanoDepthToRgbPost",
                                methodName: "PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync",
                                pathTemplate: "\"/marble/v1/pano:depth_to_rgb\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::WorldLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessPanoDepthToRgbMarbleV1PanoDepthToRgbPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::WorldLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PanoDepthToRgbMarbleV1PanoDepthToRgbPost",
                                methodName: "PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync",
                                pathTemplate: "\"/marble/v1/pano:depth_to_rgb\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::WorldLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PanoDepthToRgbMarbleV1PanoDepthToRgbPost",
                                methodName: "PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync",
                                pathTemplate: "\"/marble/v1/pano:depth_to_rgb\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                                ProcessPanoDepthToRgbMarbleV1PanoDepthToRgbPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::WorldLabs.OperationPanoDepthToRgbResult.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.OperationPanoDepthToRgbResult>(
                                        statusCode: __response.StatusCode,
                                        headers: global::WorldLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    var __value = await global::WorldLabs.OperationPanoDepthToRgbResult.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.OperationPanoDepthToRgbResult>(
                                        statusCode: __response.StatusCode,
                                        headers: global::WorldLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
        /// Pano Depth To Rgb<br/>
        /// Generate an RGB panorama from a depth panorama.<br/>
        /// Provide a depth panorama and a text prompt<br/>
        /// describing the desired appearance. The depth map<br/>
        /// supplies the scene geometry; the model synthesizes<br/>
        /// textures that match that geometry and returns a<br/>
        /// panoramic RGB image.<br/>
        /// Accepted depth inputs:<br/>
        /// * **EXR**: float depth values. Omit<br/>
        ///   ``z_min`` and ``z_max``.<br/>
        /// * **PNG**: depth values normalized to [0, 1].<br/>
        ///   Provide both ``z_min`` and ``z_max`` so the<br/>
        ///   service can decode the PNG correctly.<br/>
        /// For a complete PNG-based workflow, see the<br/>
        /// [web-chisel-depth-png example](https://github.com/worldlabsai/worldlabs-api-examples/tree/main/web-chisel-depth-png).<br/>
        /// Returns a long-running ``Operation``. Poll<br/>
        /// ``GET /operations/{operation_id}`` until<br/>
        /// ``done`` is ``true``, then read the generated<br/>
        /// panorama URL from ``response.pano_url``.<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 if invalid request<br/>
        ///     HTTPException: 402 if insufficient credits<br/>
        ///     HTTPException: 500 if generation could not start
        /// </summary>
        /// <param name="depthPanoImage">
        /// Depth panorama image (EXR or PNG). Provide via URI, media_asset, or base64 (max 100 MB).
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducible generation.
        /// </param>
        /// <param name="textPrompt">
        /// Text description of the desired appearance.
        /// </param>
        /// <param name="zMax">
        /// Maximum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_min and must be greater than z_min. Omit for EXR depth maps.
        /// </param>
        /// <param name="zMin">
        /// Minimum depth. Required for PNG depth maps (normalized to [0, 1]). Must be provided together with z_max. Omit for EXR depth maps.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::WorldLabs.OperationPanoDepthToRgbResult> PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync(
            global::WorldLabs.DepthPanoImage depthPanoImage,
            string textPrompt,
            int? seed = default,
            double? zMax = default,
            double? zMin = default,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::WorldLabs.PanoDepthToRgbRequest
            {
                DepthPanoImage = depthPanoImage,
                Seed = seed,
                TextPrompt = textPrompt,
                ZMax = zMax,
                ZMin = zMin,
            };

            return await PanoDepthToRgbMarbleV1PanoDepthToRgbPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}