﻿//HintName: G.CopilotClient.CopilotUsageMetricsForOrg.g.cs

#nullable enable

namespace G
{
    public partial class CopilotClient
    {
        /// <summary>
        /// Get a summary of Copilot usage for organization members
        /// </summary>
        /// <param name="org"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<CopilotUsageMetrics>> CopilotUsageMetricsForOrgAsync(
            string org,
            string since,
            string until,
            int page,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/copilot/usage?since={since}&until={until}&page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<CopilotUsageMetrics>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}