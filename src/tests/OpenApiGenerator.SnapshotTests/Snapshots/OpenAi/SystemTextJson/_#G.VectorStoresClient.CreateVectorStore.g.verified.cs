﻿//HintName: G.VectorStoresClient.CreateVectorStore.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        /// <summary>
        /// Create a vector store.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.VectorStoreObject> CreateVectorStoreAsync(
            global::G.CreateVectorStoreRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/vector_stores", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.VectorStoreObject?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a vector store.
        /// </summary>
        /// <param name="fileIds"></param>
        /// <param name="name"></param>
        /// <param name="expiresAfter"></param>
        /// <param name="chunkingStrategy"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.VectorStoreObject> CreateVectorStoreAsync(
            global::System.Collections.Generic.IList<string?>? fileIds = default,
            string? name = default,
            global::G.VectorStoreExpirationAfter? expiresAfter = default,
            object? chunkingStrategy = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateVectorStoreRequest
            {
                FileIds = fileIds,
                Name = name,
                ExpiresAfter = expiresAfter,
                ChunkingStrategy = chunkingStrategy,
                Metadata = metadata,
            };

            return await CreateVectorStoreAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}