﻿//HintName: G.SearchClient.SearchCommits.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        /// <summary>
        /// Search commits
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<SearchCommitsResponse> SearchCommitsAsync(
            string q,
            SearchCommitsSort sort,
            SearchCommitsOrder order,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/search/commits?q={q}&sort={sort}&order={order}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<SearchCommitsResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}