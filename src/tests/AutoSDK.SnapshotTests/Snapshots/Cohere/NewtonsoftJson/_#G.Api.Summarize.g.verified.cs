﻿//HintName: G.Api.Summarize.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareSummarizeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.SummarizeRequest request);
        partial void PrepareSummarizeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.SummarizeRequest request);
        partial void ProcessSummarizeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSummarizeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Summarize<br/>
        /// &lt;Warning&gt;<br/>
        /// This API is marked as "Legacy" and is no longer maintained. Follow the [migration guide](/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Generates a summary in English for a given text.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SummarizeResponse> SummarizeAsync(
            global::G.SummarizeRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSummarizeArguments(
                httpClient: HttpClient,
                xClientName: ref xClientName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/summarize",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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

            if (xClientName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSummarizeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xClientName: xClientName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSummarizeResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::G.SummarizeResponse2? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::G.SummarizeResponse2.FromJson(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::G.SummarizeResponse2.FromJsonStreamAsync(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse2>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::G.SummarizeResponse3? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::G.SummarizeResponse3.FromJson(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::G.SummarizeResponse3.FromJsonStreamAsync(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse3>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::G.SummarizeResponse4? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::G.SummarizeResponse4.FromJson(__content_403, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::G.SummarizeResponse4.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse4>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.SummarizeResponse5? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.SummarizeResponse5.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.SummarizeResponse5.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse5>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.SummarizeResponse6? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.SummarizeResponse6.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.SummarizeResponse6.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse6>(
                    message: __response.ReasonPhrase ?? string.Empty,
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
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::G.SummarizeResponse7? __value_429 = null;
                if (ReadResponseAsString)
                {
                    __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = global::G.SummarizeResponse7.FromJson(__content_429, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = await global::G.SummarizeResponse7.FromJsonStreamAsync(__contentStream_429, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse7>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 498)
            {
                string? __content_498 = null;
                global::G.SummarizeResponse8? __value_498 = null;
                if (ReadResponseAsString)
                {
                    __content_498 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_498 = global::G.SummarizeResponse8.FromJson(__content_498, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_498 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_498 = await global::G.SummarizeResponse8.FromJsonStreamAsync(__contentStream_498, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse8>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_498,
                    ResponseObject = __value_498,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 499)
            {
                string? __content_499 = null;
                global::G.SummarizeResponse9? __value_499 = null;
                if (ReadResponseAsString)
                {
                    __content_499 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_499 = global::G.SummarizeResponse9.FromJson(__content_499, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_499 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_499 = await global::G.SummarizeResponse9.FromJsonStreamAsync(__contentStream_499, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse9>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_499,
                    ResponseObject = __value_499,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::G.SummarizeResponse10? __value_500 = null;
                if (ReadResponseAsString)
                {
                    __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = global::G.SummarizeResponse10.FromJson(__content_500, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = await global::G.SummarizeResponse10.FromJsonStreamAsync(__contentStream_500, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse10>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 501)
            {
                string? __content_501 = null;
                global::G.SummarizeResponse11? __value_501 = null;
                if (ReadResponseAsString)
                {
                    __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_501 = global::G.SummarizeResponse11.FromJson(__content_501, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_501 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_501 = await global::G.SummarizeResponse11.FromJsonStreamAsync(__contentStream_501, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse11>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_501,
                    ResponseObject = __value_501,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::G.SummarizeResponse12? __value_503 = null;
                if (ReadResponseAsString)
                {
                    __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = global::G.SummarizeResponse12.FromJson(__content_503, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_503 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = await global::G.SummarizeResponse12.FromJsonStreamAsync(__contentStream_503, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse12>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::G.SummarizeResponse13? __value_504 = null;
                if (ReadResponseAsString)
                {
                    __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = global::G.SummarizeResponse13.FromJson(__content_504, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_504 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = await global::G.SummarizeResponse13.FromJsonStreamAsync(__contentStream_504, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.SummarizeResponse13>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseObject = __value_504,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessSummarizeResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::System.InvalidOperationException(__content, __ex);
                }

                return
                    global::G.SummarizeResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = await global::G.SummarizeResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Summarize<br/>
        /// &lt;Warning&gt;<br/>
        /// This API is marked as "Legacy" and is no longer maintained. Follow the [migration guide](/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Generates a summary in English for a given text.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="text">
        /// The text to generate a summary for. Can be up to 100,000 characters long. Currently the only supported language is English.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="length">
        /// One of `short`, `medium`, `long`, or `auto` defaults to `auto`. Indicates the approximate length of the summary. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: medium<br/>
        /// Included only in requests
        /// </param>
        /// <param name="format">
        /// One of `paragraph`, `bullets`, or `auto`, defaults to `auto`. Indicates the style in which the summary will be delivered - in a free form paragraph or in bullet points. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: paragraph<br/>
        /// Included only in requests
        /// </param>
        /// <param name="model">
        /// The identifier of the model to generate the summary with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental). Smaller, "light" models are faster, while larger models will perform better.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="extractiveness">
        /// One of `low`, `medium`, `high`, or `auto`, defaults to `auto`. Controls how close to the original text the summary is. `high` extractiveness summaries will lean towards reusing sentences verbatim, while `low` extractiveness summaries will tend to paraphrase more. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: low<br/>
        /// Included only in requests
        /// </param>
        /// <param name="temperature">
        /// Ranges from 0 to 5. Controls the randomness of the output. Lower values tend to generate more “predictable” output, while higher values tend to generate more “creative” output. The sweet spot is typically between 0 and 1.<br/>
        /// Default Value: 0.3<br/>
        /// Included only in requests
        /// </param>
        /// <param name="additionalCommand">
        /// A free-form instruction for modifying how the summaries get generated. Should complete the sentence "Generate a summary _". Eg. "focusing on the next steps" or "written by Yoda"<br/>
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SummarizeResponse> SummarizeAsync(
            string text,
            global::G.SummarizeRequestLength length,
            global::G.SummarizeRequestFormat format,
            string model,
            global::G.SummarizeRequestExtractiveness extractiveness,
            double temperature,
            string additionalCommand,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SummarizeRequest
            {
                Text = text,
                Length = length,
                Format = format,
                Model = model,
                Extractiveness = extractiveness,
                Temperature = temperature,
                AdditionalCommand = additionalCommand,
            };

            return await SummarizeAsync(
                xClientName: xClientName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}