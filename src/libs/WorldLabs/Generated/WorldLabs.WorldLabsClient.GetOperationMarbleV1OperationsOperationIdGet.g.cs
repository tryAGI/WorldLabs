
#nullable enable

namespace WorldLabs
{
    public partial class WorldLabsClient
    {


        private static readonly global::WorldLabs.EndPointSecurityRequirement s_GetOperationMarbleV1OperationsOperationIdGetSecurityRequirement0 =
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
        private static readonly global::WorldLabs.EndPointSecurityRequirement[] s_GetOperationMarbleV1OperationsOperationIdGetSecurityRequirements =
            new global::WorldLabs.EndPointSecurityRequirement[]
            {                s_GetOperationMarbleV1OperationsOperationIdGetSecurityRequirement0,
            };
        partial void PrepareGetOperationMarbleV1OperationsOperationIdGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string operationId);
        partial void PrepareGetOperationMarbleV1OperationsOperationIdGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string operationId);
        partial void ProcessGetOperationMarbleV1OperationsOperationIdGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetOperationMarbleV1OperationsOperationIdGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Operation<br/>
        /// Get an operation by ID.<br/>
        /// Poll this endpoint to check the status of a long-running operation.<br/>
        /// When done=true, the response field contains the generated world.<br/>
        /// Args:<br/>
        ///     operation_id: The operation identifier from /worlds:generate.<br/>
        /// Returns:<br/>
        ///     GetOperationResponse[World] with:<br/>
        ///         - operation_id: Operation identifier<br/>
        ///         - created_at: Creation timestamp<br/>
        ///         - updated_at: Last update timestamp<br/>
        ///         - expires_at: Expiration timestamp<br/>
        ///         - done: true when complete, false while in progress<br/>
        ///         - error: Error details if failed, null otherwise<br/>
        ///         - metadata: Progress information and world_id<br/>
        ///         - response: Generated World if done=true, null otherwise<br/>
        /// Raises:<br/>
        ///     HTTPException: 401 if unauthorized<br/>
        ///     HTTPException: 404 if operation not found<br/>
        ///     HTTPException: 500 if request fails
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResult> GetOperationMarbleV1OperationsOperationIdGetAsync(
            string operationId,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetOperationMarbleV1OperationsOperationIdGetAsResponseAsync(
                operationId: operationId,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Operation<br/>
        /// Get an operation by ID.<br/>
        /// Poll this endpoint to check the status of a long-running operation.<br/>
        /// When done=true, the response field contains the generated world.<br/>
        /// Args:<br/>
        ///     operation_id: The operation identifier from /worlds:generate.<br/>
        /// Returns:<br/>
        ///     GetOperationResponse[World] with:<br/>
        ///         - operation_id: Operation identifier<br/>
        ///         - created_at: Creation timestamp<br/>
        ///         - updated_at: Last update timestamp<br/>
        ///         - expires_at: Expiration timestamp<br/>
        ///         - done: true when complete, false while in progress<br/>
        ///         - error: Error details if failed, null otherwise<br/>
        ///         - metadata: Progress information and world_id<br/>
        ///         - response: Generated World if done=true, null otherwise<br/>
        /// Raises:<br/>
        ///     HTTPException: 401 if unauthorized<br/>
        ///     HTTPException: 404 if operation not found<br/>
        ///     HTTPException: 500 if request fails
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WorldLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResult>> GetOperationMarbleV1OperationsOperationIdGetAsResponseAsync(
            string operationId,
            global::WorldLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetOperationMarbleV1OperationsOperationIdGetArguments(
                httpClient: HttpClient,
                operationId: ref operationId);


            var __authorizations = global::WorldLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetOperationMarbleV1OperationsOperationIdGetSecurityRequirements,
                operationName: "GetOperationMarbleV1OperationsOperationIdGetAsync");

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
                                path: $"/marble/v1/operations/{operationId}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::WorldLabs.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::WorldLabs.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetOperationMarbleV1OperationsOperationIdGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    operationId: operationId!);

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
                                operationId: "GetOperationMarbleV1OperationsOperationIdGet",
                                methodName: "GetOperationMarbleV1OperationsOperationIdGetAsync",
                                pathTemplate: "$\"/marble/v1/operations/{operationId}\"",
                                httpMethod: "GET",
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
                                operationId: "GetOperationMarbleV1OperationsOperationIdGet",
                                methodName: "GetOperationMarbleV1OperationsOperationIdGetAsync",
                                pathTemplate: "$\"/marble/v1/operations/{operationId}\"",
                                httpMethod: "GET",
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
                                operationId: "GetOperationMarbleV1OperationsOperationIdGet",
                                methodName: "GetOperationMarbleV1OperationsOperationIdGetAsync",
                                pathTemplate: "$\"/marble/v1/operations/{operationId}\"",
                                httpMethod: "GET",
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
                ProcessGetOperationMarbleV1OperationsOperationIdGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::WorldLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::WorldLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetOperationMarbleV1OperationsOperationIdGet",
                                methodName: "GetOperationMarbleV1OperationsOperationIdGetAsync",
                                pathTemplate: "$\"/marble/v1/operations/{operationId}\"",
                                httpMethod: "GET",
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
                                operationId: "GetOperationMarbleV1OperationsOperationIdGet",
                                methodName: "GetOperationMarbleV1OperationsOperationIdGetAsync",
                                pathTemplate: "$\"/marble/v1/operations/{operationId}\"",
                                httpMethod: "GET",
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
                                ProcessGetOperationMarbleV1OperationsOperationIdGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResult.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResult>(
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

                                    var __value = await global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResult.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::WorldLabs.AutoSDKHttpResponse<global::WorldLabs.GetOperationResponseUnionWorldPanoDepthToRgbResult>(
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
    }
}