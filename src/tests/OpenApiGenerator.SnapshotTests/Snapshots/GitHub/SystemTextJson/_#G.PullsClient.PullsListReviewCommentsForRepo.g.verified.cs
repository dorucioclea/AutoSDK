﻿//HintName: G.PullsClient.PullsListReviewCommentsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class PullsClient
    {
        /// <summary>
        /// List review comments in a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="since"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<PullRequestReviewComment>> PullsListReviewCommentsForRepoAsync(
            string owner,
            string repo,
            PullsListReviewCommentsForRepoSort sort,
            PullsListReviewCommentsForRepoDirection direction,
            global::System.DateTime since,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/pulls/comments?sort={sort}&direction={direction}&since={since}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<PullRequestReviewComment>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}