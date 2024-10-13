﻿//HintName: G.MigrationsClient.MigrationsUnlockRepoForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsUnlockRepoForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int migrationId,
            ref string repoName);
        partial void PrepareMigrationsUnlockRepoForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int migrationId,
            string repoName);
        partial void ProcessMigrationsUnlockRepoForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsUnlockRepoForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Unlock a user repository<br/>
        /// Unlocks a repository. You can lock repositories when you [start a user migration](https://docs.github.com/rest/migrations/users#start-a-user-migration). Once the migration is complete you can unlock each repository to begin using it again or [delete the repository](https://docs.github.com/rest/repos/repos#delete-a-repository) if you no longer need the source data. Returns a status of `404 Not Found` if the repository is not locked.
        /// </summary>
        /// <param name="migrationId"></param>
        /// <param name="repoName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> MigrationsUnlockRepoForAuthenticatedUserAsync(
            int migrationId,
            string repoName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMigrationsUnlockRepoForAuthenticatedUserArguments(
                httpClient: _httpClient,
                migrationId: ref migrationId,
                repoName: ref repoName);

            var __pathBuilder = new PathBuilder(
                path: $"/user/migrations/{migrationId}/repos/{repoName}/lock",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMigrationsUnlockRepoForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                migrationId: migrationId,
                repoName: repoName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMigrationsUnlockRepoForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMigrationsUnlockRepoForAuthenticatedUserResponseContent(
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
                global::G.BasicError.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}