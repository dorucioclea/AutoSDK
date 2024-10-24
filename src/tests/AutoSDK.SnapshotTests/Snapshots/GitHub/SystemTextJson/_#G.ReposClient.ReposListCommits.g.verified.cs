﻿//HintName: G.ReposClient.ReposListCommits.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposListCommitsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? sha,
            ref string? path,
            ref string? author,
            ref string? committer,
            ref global::System.DateTime? since,
            ref global::System.DateTime? until,
            ref int? perPage,
            ref int? page);
        partial void PrepareReposListCommitsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? sha,
            string? path,
            string? author,
            string? committer,
            global::System.DateTime? since,
            global::System.DateTime? until,
            int? perPage,
            int? page);
        partial void ProcessReposListCommitsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListCommitsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List commits<br/>
        /// **Signature verification object**<br/>
        /// The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:<br/>
        /// | Name | Type | Description |<br/>
        /// | ---- | ---- | ----------- |<br/>
        /// | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. |<br/>
        /// | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. |<br/>
        /// | `signature` | `string` | The signature that was extracted from the commit. |<br/>
        /// | `payload` | `string` | The value that was signed. |<br/>
        /// These are the possible values for `reason` in the `verification` object:<br/>
        /// | Value | Description |<br/>
        /// | ----- | ----------- |<br/>
        /// | `expired_key` | The key that made the signature is expired. |<br/>
        /// | `not_signing_key` | The "signing" flag is not among the usage flags in the GPG key that made the signature. |<br/>
        /// | `gpgverify_error` | There was an error communicating with the signature verification service. |<br/>
        /// | `gpgverify_unavailable` | The signature verification service is currently unavailable. |<br/>
        /// | `unsigned` | The object does not include a signature. |<br/>
        /// | `unknown_signature_type` | A non-PGP signature was found in the commit. |<br/>
        /// | `no_user` | No user was associated with the `committer` email address in the commit. |<br/>
        /// | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on their account. |<br/>
        /// | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. |<br/>
        /// | `unknown_key` | The key that made the signature has not been registered with any user's account. |<br/>
        /// | `malformed_signature` | There was an error parsing the signature. |<br/>
        /// | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. |<br/>
        /// | `valid` | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="path"></param>
        /// <param name="author"></param>
        /// <param name="committer"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Commit>> ReposListCommitsAsync(
            string owner,
            string repo,
            string? sha = default,
            string? path = default,
            string? author = default,
            string? committer = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposListCommitsArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                sha: ref sha,
                path: ref path,
                author: ref author,
                committer: ref committer,
                since: ref since,
                until: ref until,
                perPage: ref perPage,
                page: ref page);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/commits",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("sha", sha) 
                .AddOptionalParameter("path", path) 
                .AddOptionalParameter("author", author) 
                .AddOptionalParameter("committer", committer) 
                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("until", until?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
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
            PrepareReposListCommitsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                sha: sha,
                path: path,
                author: author,
                committer: committer,
                since: since,
                until: until,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposListCommitsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposListCommitsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Commit>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}