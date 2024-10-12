﻿//HintName: G.AdminClient.AdminMergeProjects.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminMergeProjectsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? project1Id,
            ref global::System.Guid? project2Id,
            ref string? newTitle,
            ref string? newDescription,
            ref global::System.Guid? creatorId,
            ref bool? mergeCodes);
        partial void PrepareAdminMergeProjectsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? project1Id,
            global::System.Guid? project2Id,
            string? newTitle,
            string? newDescription,
            global::System.Guid? creatorId,
            bool? mergeCodes);
        partial void ProcessAdminMergeProjectsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminMergeProjectsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// MergeProjects.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="project1Id"></param>
        /// <param name="project2Id"></param>
        /// <param name="newTitle"></param>
        /// <param name="newDescription"></param>
        /// <param name="creatorId"></param>
        /// <param name="mergeCodes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> AdminMergeProjectsAsync(
            string? token = default,
            global::System.Guid? project1Id = default,
            global::System.Guid? project2Id = default,
            string? newTitle = default,
            string? newDescription = default,
            global::System.Guid? creatorId = default,
            bool? mergeCodes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAdminMergeProjectsArguments(
                httpClient: _httpClient,
                token: ref token,
                project1Id: ref project1Id,
                project2Id: ref project2Id,
                newTitle: ref newTitle,
                newDescription: ref newDescription,
                creatorId: ref creatorId,
                mergeCodes: ref mergeCodes);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/admin/mergeprojects",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("project1Id", project1Id?.ToString()) 
                .AddOptionalParameter("project2Id", project2Id?.ToString()) 
                .AddOptionalParameter("newTitle", newTitle) 
                .AddOptionalParameter("newDescription", newDescription) 
                .AddOptionalParameter("creatorId", creatorId?.ToString()) 
                .AddOptionalParameter("mergeCodes", mergeCodes?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAdminMergeProjectsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                project1Id: project1Id,
                project2Id: project2Id,
                newTitle: newTitle,
                newDescription: newDescription,
                creatorId: creatorId,
                mergeCodes: mergeCodes);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAdminMergeProjectsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAdminMergeProjectsResponseContent(
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

            return __content;
        }
    }
}