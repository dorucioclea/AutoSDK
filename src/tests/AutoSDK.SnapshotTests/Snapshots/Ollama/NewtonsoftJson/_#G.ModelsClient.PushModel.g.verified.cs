﻿//HintName: G.ModelsClient.PushModel.g.cs

#nullable enable

namespace G
{
    public partial class ModelsClient
    {
        partial void PreparePushModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PushModelRequest request);
        partial void PreparePushModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PushModelRequest request);
        partial void ProcessPushModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Upload a model to a model library.<br/>
        /// Requires registering for ollama.ai and adding a public key first.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.PushModelResponse> PushModelAsync(
            global::G.PushModelRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePushModelArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/push",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePushModelRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPushModelResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            using var reader = new global::System.IO.StreamReader(stream);

            while (!reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {
                var __content = await reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                var streamedResponse = global::G.PushModelResponse.FromJson(__content, JsonSerializerOptions) ??
                                       throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");

                yield return streamedResponse;
            }
        }

        /// <summary>
        /// Upload a model to a model library.<br/>
        /// Requires registering for ollama.ai and adding a public key first.
        /// </summary>
        /// <param name="model">
        /// The name of the model to push in the form of &lt;namespace&gt;/&lt;model&gt;:&lt;tag&gt;.<br/>
        /// Example: mattw/pygmalion:latest
        /// </param>
        /// <param name="insecure">
        /// Allow insecure connections to the library. <br/>
        /// Only use this if you are pushing to your library during development.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="username">
        /// Ollama username.
        /// </param>
        /// <param name="password">
        /// Ollama password.
        /// </param>
        /// <param name="stream">
        /// If `false` the response will be returned as a single response object, otherwise the response will be streamed as a series of objects.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.PushModelResponse> PushModelAsync(
            string model,
            bool? insecure = false,
            string? username = default,
            string? password = default,
            bool? stream = true,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.PushModelRequest
            {
                Model = model,
                Insecure = insecure,
                Username = username,
                Password = password,
                Stream = stream,
            };

            var enumerable = PushModelAsync(
                request: request,
                cancellationToken: cancellationToken);

            await foreach (var response in enumerable)
            {
                yield return response;
            }
        }
    }
}