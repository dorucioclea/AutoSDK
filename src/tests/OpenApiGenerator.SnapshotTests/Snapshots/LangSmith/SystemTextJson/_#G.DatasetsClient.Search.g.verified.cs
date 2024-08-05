﻿//HintName: G.DatasetsClient.Search.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            global::G.SearchDatasetRequest request);
        partial void PrepareSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::G.SearchDatasetRequest request);
        partial void ProcessSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search<br/>
        /// Search a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchDatasetResponse> SearchAsync(
            string datasetId,
            global::G.SearchDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSearchArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/search", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSearchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSearchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSearchResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.SearchDatasetResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Search<br/>
        /// Search a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="limit">
        /// Default Value: 5
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchDatasetResponse> SearchAsync(
            string datasetId,
            object inputs,
            int limit = 5,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.SearchDatasetRequest
            {
                Inputs = inputs,
                Limit = limit,
            };

            return await SearchAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}