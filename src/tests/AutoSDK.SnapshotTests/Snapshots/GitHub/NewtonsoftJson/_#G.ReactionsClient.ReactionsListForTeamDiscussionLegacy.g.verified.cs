﻿//HintName: G.ReactionsClient.ReactionsListForTeamDiscussionLegacy.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsListForTeamDiscussionLegacyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int teamId,
            ref int discussionNumber,
            ref global::G.ReactionsListForTeamDiscussionLegacyContent? content,
            ref int? perPage,
            ref int? page);
        partial void PrepareReactionsListForTeamDiscussionLegacyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int teamId,
            int discussionNumber,
            global::G.ReactionsListForTeamDiscussionLegacyContent? content,
            int? perPage,
            int? page);
        partial void ProcessReactionsListForTeamDiscussionLegacyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsListForTeamDiscussionLegacyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List reactions for a team discussion (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List reactions for a team discussion`](https://docs.github.com/rest/reactions/reactions#list-reactions-for-a-team-discussion) endpoint.<br/>
        /// List the reactions to a [team discussion](https://docs.github.com/rest/teams/discussions#get-a-discussion).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="content"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Reaction>> ReactionsListForTeamDiscussionLegacyAsync(
            int teamId,
            int discussionNumber,
            global::G.ReactionsListForTeamDiscussionLegacyContent? content = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReactionsListForTeamDiscussionLegacyArguments(
                httpClient: HttpClient,
                teamId: ref teamId,
                discussionNumber: ref discussionNumber,
                content: ref content,
                perPage: ref perPage,
                page: ref page);

            var contentValue = content switch
            {
                global::G.ReactionsListForTeamDiscussionLegacyContent.Plus1 => "+1",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Minus1 => "-1",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Laugh => "laugh",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Confused => "confused",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Heart => "heart",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Hooray => "hooray",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Rocket => "rocket",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/teams/{teamId}/discussions/{discussionNumber}/reactions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("content", contentValue?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReactionsListForTeamDiscussionLegacyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                teamId: teamId,
                discussionNumber: discussionNumber,
                content: content,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReactionsListForTeamDiscussionLegacyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessReactionsListForTeamDiscussionLegacyResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::System.InvalidOperationException(__content, __ex);
                }

                return
                    global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Reaction>?>(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Reaction>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__responseStream)));

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}