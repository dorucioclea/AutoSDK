﻿//HintName: G.IssuesClient.IssuesDeleteMilestone.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesDeleteMilestoneArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int milestoneNumber);
        partial void PrepareIssuesDeleteMilestoneRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int milestoneNumber);
        partial void ProcessIssuesDeleteMilestoneResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesDeleteMilestoneResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete a milestone<br/>
        /// Deletes a milestone using the given milestone number.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestoneNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> IssuesDeleteMilestoneAsync(
            string owner,
            string repo,
            int milestoneNumber,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareIssuesDeleteMilestoneArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                milestoneNumber: ref milestoneNumber);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/milestones/{milestoneNumber}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareIssuesDeleteMilestoneRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                milestoneNumber: milestoneNumber);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessIssuesDeleteMilestoneResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessIssuesDeleteMilestoneResponseContent(
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
                    global::G.BasicError.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::G.BasicError.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}