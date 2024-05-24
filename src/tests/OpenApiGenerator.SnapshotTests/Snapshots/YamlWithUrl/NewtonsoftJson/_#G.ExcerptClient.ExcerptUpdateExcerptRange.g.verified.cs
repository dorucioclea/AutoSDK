﻿//HintName: G.ExcerptClient.ExcerptUpdateExcerptRange.g.cs

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        /// <summary>
        /// UpdateExcerptRange.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="excerptId"></param>
        /// <param name="newStart"></param>
        /// <param name="newEnd"></param>
        /// <param name="updatedTextURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Excerpt> ExcerptUpdateExcerptRangeAsync(
            string token,
            string projectId,
            string userId,
            string excerptId,
            int newStart,
            int newEnd,
            string updatedTextURI,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/excerpt/updateexcerptrange?projectId={projectId}&userId={userId}&excerptId={excerptId}&newStart={newStart}&newEnd={newEnd}&updatedTextURI={updatedTextURI}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Excerpt>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}