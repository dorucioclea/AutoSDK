﻿//HintName: G.ArtifactClient.UpdateChunk.g.cs

#nullable enable

namespace G
{
    public partial class ArtifactClient
    {
        partial void PrepareUpdateChunkArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string chunkUid,
            global::G.UpdateChunkBody request);
        partial void PrepareUpdateChunkRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string chunkUid,
            global::G.UpdateChunkBody request);
        partial void ProcessUpdateChunkResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateChunkResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update catalog chunk<br/>
        /// Updates a catalog chunk.
        /// </summary>
        /// <param name="chunkUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateChunkResponse> UpdateChunkAsync(
            string chunkUid,
            global::G.UpdateChunkBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateChunkArguments(
                httpClient: HttpClient,
                chunkUid: ref chunkUid,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1alpha/chunks/{chunkUid}",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateChunkRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                chunkUid: chunkUid,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateChunkResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUpdateChunkResponseContent(
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
                    global::G.UpdateChunkResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = await global::G.UpdateChunkResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Update catalog chunk<br/>
        /// Updates a catalog chunk.
        /// </summary>
        /// <param name="chunkUid"></param>
        /// <param name="retrievable"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateChunkResponse> UpdateChunkAsync(
            string chunkUid,
            bool? retrievable = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UpdateChunkBody
            {
                Retrievable = retrievable,
            };

            return await UpdateChunkAsync(
                chunkUid: chunkUid,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}