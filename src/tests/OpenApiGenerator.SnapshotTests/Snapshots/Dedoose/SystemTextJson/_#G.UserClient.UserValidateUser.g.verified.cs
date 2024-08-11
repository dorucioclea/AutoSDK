﻿//HintName: G.UserClient.UserValidateUser.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserValidateUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? username,
            ref string? passSalt,
            ref string? connectionKey);
        partial void PrepareUserValidateUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? username,
            string? passSalt,
            string? connectionKey);
        partial void ProcessUserValidateUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserValidateUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ValidateUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <param name="passSalt"></param>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UserValidateUserResponse> UserValidateUserAsync(
            string? token,
            string? username,
            string? passSalt,
            string? connectionKey,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUserValidateUserArguments(
                httpClient: _httpClient,
                token: ref token,
                username: ref username,
                passSalt: ref passSalt,
                connectionKey: ref connectionKey);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/user/validateuser?username={username}&passSalt={passSalt}&connectionKey={connectionKey}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUserValidateUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                username: username,
                passSalt: passSalt,
                connectionKey: connectionKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUserValidateUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUserValidateUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserValidateUserResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}