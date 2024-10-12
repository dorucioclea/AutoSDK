﻿//HintName: G.AdminClient.AdminSetAccountUserAdminStatus.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminSetAccountUserAdminStatusArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? accountId,
            ref global::System.Guid? userId,
            ref bool? isAdmin);
        partial void PrepareAdminSetAccountUserAdminStatusRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? accountId,
            global::System.Guid? userId,
            bool? isAdmin);
        partial void ProcessAdminSetAccountUserAdminStatusResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminSetAccountUserAdminStatusResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// SetAccountUserAdminStatus.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        /// <param name="isAdmin"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> AdminSetAccountUserAdminStatusAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            global::System.Guid? userId = default,
            bool? isAdmin = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAdminSetAccountUserAdminStatusArguments(
                httpClient: _httpClient,
                token: ref token,
                accountId: ref accountId,
                userId: ref userId,
                isAdmin: ref isAdmin);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/admin/setaccountuseradminstatus",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("accountId", accountId?.ToString()) 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("isAdmin", isAdmin?.ToString()) 
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
            PrepareAdminSetAccountUserAdminStatusRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                accountId: accountId,
                userId: userId,
                isAdmin: isAdmin);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAdminSetAccountUserAdminStatusResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAdminSetAccountUserAdminStatusResponseContent(
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