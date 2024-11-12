﻿//HintName: G.ActionsClient.ActionsRemoveSelectedRepoFromOrgSecret.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsRemoveSelectedRepoFromOrgSecretArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string secretName,
            ref int repositoryId);
        partial void PrepareActionsRemoveSelectedRepoFromOrgSecretRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string secretName,
            int repositoryId);
        partial void ProcessActionsRemoveSelectedRepoFromOrgSecretResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Remove selected repository from an organization secret<br/>
        /// Removes a repository from an organization secret when the `visibility`<br/>
        /// for repository access is set to `selected`. The visibility is set when you [Create<br/>
        /// or update an organization secret](https://docs.github.com/rest/actions/secrets#create-or-update-an-organization-secret).<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ActionsRemoveSelectedRepoFromOrgSecretAsync(
            string org,
            string secretName,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsRemoveSelectedRepoFromOrgSecretArguments(
                httpClient: HttpClient,
                org: ref org,
                secretName: ref secretName,
                repositoryId: ref repositoryId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/secrets/{secretName}/repositories/{repositoryId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsRemoveSelectedRepoFromOrgSecretRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                secretName: secretName,
                repositoryId: repositoryId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsRemoveSelectedRepoFromOrgSecretResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}