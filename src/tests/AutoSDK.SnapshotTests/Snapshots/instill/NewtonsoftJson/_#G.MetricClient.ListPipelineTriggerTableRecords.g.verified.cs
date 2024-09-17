﻿//HintName: G.MetricClient.ListPipelineTriggerTableRecords.g.cs

#nullable enable

namespace G
{
    public partial class MetricClient
    {
        partial void PrepareListPipelineTriggerTableRecordsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int pageSize,
            ref string? pageToken,
            ref string? filter);
        partial void PrepareListPipelineTriggerTableRecordsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int pageSize,
            string? pageToken,
            string? filter);
        partial void ProcessListPipelineTriggerTableRecordsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListPipelineTriggerTableRecordsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List pipeline trigger metrics<br/>
        /// Returns a paginated list of pipeline executions aggregated by pipeline ID.<br/>
        /// NOTE: This method is deprecated and will be retired soon.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListPipelineTriggerTableRecordsResponse> ListPipelineTriggerTableRecordsAsync(
            int pageSize = default,
            string? pageToken = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListPipelineTriggerTableRecordsArguments(
                httpClient: _httpClient,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                filter: ref filter);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1beta/metrics/vdp/pipeline/tables?pageSize={pageSize}&pageToken={pageToken}&filter={filter}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListPipelineTriggerTableRecordsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pageSize: pageSize,
                pageToken: pageToken,
                filter: filter);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListPipelineTriggerTableRecordsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListPipelineTriggerTableRecordsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListPipelineTriggerTableRecordsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}