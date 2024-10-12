﻿//HintName: G.DatasetsClient.ReadDatasets.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareReadDatasetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DataType>, global::G.DataType?, object>? dataType,
            ref global::G.AnyOf<string, object>? name,
            ref global::G.AnyOf<string, object>? nameContains,
            ref global::G.AnyOf<string, object>? metadata,
            ref int? offset,
            ref int? limit,
            ref global::G.SortByDatasetColumn? sortBy,
            ref bool? sortByDesc,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId);
        partial void PrepareReadDatasetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DataType>, global::G.DataType?, object>? dataType,
            global::G.AnyOf<string, object>? name,
            global::G.AnyOf<string, object>? nameContains,
            global::G.AnyOf<string, object>? metadata,
            int? offset,
            int? limit,
            global::G.SortByDatasetColumn? sortBy,
            bool? sortByDesc,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId);
        partial void ProcessReadDatasetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadDatasetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Datasets<br/>
        /// Get all datasets by query params and owner.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataType"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="metadata"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Enum for available dataset columns to sort by.
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Dataset>> ReadDatasetsAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DataType>, global::G.DataType?, object>? dataType = default,
            global::G.AnyOf<string, object>? name = default,
            global::G.AnyOf<string, object>? nameContains = default,
            global::G.AnyOf<string, object>? metadata = default,
            int? offset = 0,
            int? limit = 100,
            global::G.SortByDatasetColumn? sortBy = default,
            bool? sortByDesc = true,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadDatasetsArguments(
                httpClient: _httpClient,
                id: ref id,
                dataType: ref dataType,
                name: ref name,
                nameContains: ref nameContains,
                metadata: ref metadata,
                offset: ref offset,
                limit: ref limit,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                tagValueId: ref tagValueId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/datasets",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id?.ToString() ?? string.Empty) 
                .AddOptionalParameter("data_type", dataType?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name", name?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name_contains", nameContains?.ToString() ?? string.Empty) 
                .AddOptionalParameter("metadata", metadata?.ToString() ?? string.Empty) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("sort_by", sortBy?.ToValueString()) 
                .AddOptionalParameter("sort_by_desc", sortByDesc?.ToString()) 
                .AddOptionalParameter("tag_value_id", tagValueId?.ToString() ?? string.Empty) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadDatasetsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                dataType: dataType,
                name: name,
                nameContains: nameContains,
                metadata: metadata,
                offset: offset,
                limit: limit,
                sortBy: sortBy,
                sortByDesc: sortByDesc,
                tagValueId: tagValueId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadDatasetsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadDatasetsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Dataset>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}