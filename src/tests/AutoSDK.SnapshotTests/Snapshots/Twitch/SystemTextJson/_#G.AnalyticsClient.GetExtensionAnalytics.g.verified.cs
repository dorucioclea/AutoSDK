﻿//HintName: G.AnalyticsClient.GetExtensionAnalytics.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsClient
    {
        partial void PrepareGetExtensionAnalyticsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? extensionId,
            ref global::G.GetExtensionAnalyticsType? type,
            ref global::System.DateTime? startedAt,
            ref global::System.DateTime? endedAt,
            ref int? first,
            ref string? after);
        partial void PrepareGetExtensionAnalyticsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? extensionId,
            global::G.GetExtensionAnalyticsType? type,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            int? first,
            string? after);
        partial void ProcessGetExtensionAnalyticsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetExtensionAnalyticsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets an analytics report for one or more extensions.<br/>
        /// Gets an analytics report for one or more extensions. The response contains the URLs used to download the reports (CSV files). [Learn More](https://dev.twitch.tv/docs/insights)<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **analytics:read:extensions** scope.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="type"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetExtensionAnalyticsResponse> GetExtensionAnalyticsAsync(
            string? extensionId = default,
            global::G.GetExtensionAnalyticsType? type = default,
            global::System.DateTime? startedAt = default,
            global::System.DateTime? endedAt = default,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetExtensionAnalyticsArguments(
                httpClient: _httpClient,
                extensionId: ref extensionId,
                type: ref type,
                startedAt: ref startedAt,
                endedAt: ref endedAt,
                first: ref first,
                after: ref after);

            var __pathBuilder = new PathBuilder(
                path: "/analytics/extensions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("extension_id", extensionId) 
                .AddOptionalParameter("type", type?.ToValueString()) 
                .AddOptionalParameter("started_at", startedAt?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("ended_at", endedAt?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("first", first?.ToString()) 
                .AddOptionalParameter("after", after) 
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
            PrepareGetExtensionAnalyticsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                extensionId: extensionId,
                type: type,
                startedAt: startedAt,
                endedAt: endedAt,
                first: first,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetExtensionAnalyticsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetExtensionAnalyticsResponseContent(
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
                global::G.GetExtensionAnalyticsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}