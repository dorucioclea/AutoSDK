﻿//HintName: G.ActivityClient.ActivityListReposStarredByAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        partial void PrepareActivityListReposStarredByAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.ActivityListReposStarredByAuthenticatedUserSort? sort,
            ref global::G.ActivityListReposStarredByAuthenticatedUserDirection? direction,
            ref int perPage,
            ref int page);
        partial void PrepareActivityListReposStarredByAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ActivityListReposStarredByAuthenticatedUserSort? sort,
            global::G.ActivityListReposStarredByAuthenticatedUserDirection? direction,
            int perPage,
            int page);
        partial void ProcessActivityListReposStarredByAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActivityListReposStarredByAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repositories starred by the authenticated user<br/>
        /// Lists repositories the authenticated user has starred.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.star+json`**: Includes a timestamp of when the star was created.
        /// </summary>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Repository>> ActivityListReposStarredByAuthenticatedUserAsync(
            global::G.ActivityListReposStarredByAuthenticatedUserSort? sort,
            global::G.ActivityListReposStarredByAuthenticatedUserDirection? direction,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActivityListReposStarredByAuthenticatedUserArguments(
                httpClient: _httpClient,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/starred?sort={sort}&direction={direction}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActivityListReposStarredByAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActivityListReposStarredByAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActivityListReposStarredByAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Repository>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}