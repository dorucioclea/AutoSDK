﻿//HintName: G.ReactionsClient.ReactionsListForPullRequestReviewComment.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        /// <summary>
        /// List reactions for a pull request review comment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="content"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<Reaction>> ReactionsListForPullRequestReviewCommentAsync(
            string owner,
            string repo,
            int commentId,
            ReactionsListForPullRequestReviewCommentContent content,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var contentValue = content switch
            {
                ReactionsListForPullRequestReviewCommentContent.Plus1 => "+1",
                ReactionsListForPullRequestReviewCommentContent.Minus1 => "-1",
                ReactionsListForPullRequestReviewCommentContent.Laugh => "laugh",
                ReactionsListForPullRequestReviewCommentContent.Confused => "confused",
                ReactionsListForPullRequestReviewCommentContent.Heart => "heart",
                ReactionsListForPullRequestReviewCommentContent.Hooray => "hooray",
                ReactionsListForPullRequestReviewCommentContent.Rocket => "rocket",
                ReactionsListForPullRequestReviewCommentContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/pulls/comments/{commentId}/reactions?content={contentValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<Reaction>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}