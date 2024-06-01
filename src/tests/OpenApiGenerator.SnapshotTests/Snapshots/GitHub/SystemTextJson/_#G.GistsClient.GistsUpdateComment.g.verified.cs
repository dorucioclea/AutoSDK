﻿//HintName: G.GistsClient.GistsUpdateComment.g.cs

#nullable enable

namespace G
{
    public partial class GistsClient
    {
        /// <summary>
        /// Update a gist comment
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GistComment> GistsUpdateCommentAsync(
            string gistId,
            int commentId,
            GistsUpdateCommentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/gists/{gistId}/comments/{commentId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<GistComment?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a gist comment
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="commentId"></param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GistComment> GistsUpdateCommentAsync(
            string gistId,
            int commentId,
            string body,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new GistsUpdateCommentRequest
            {
                Body = body,
            };

            return await GistsUpdateCommentAsync(
                gistId: gistId,
                commentId: commentId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}