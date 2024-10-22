﻿//HintName: G.UsersClient.BlockUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareBlockUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string targetUserId,
            ref global::G.BlockUserSourceContext? sourceContext,
            ref global::G.BlockUserReason? reason);
        partial void PrepareBlockUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string targetUserId,
            global::G.BlockUserSourceContext? sourceContext,
            global::G.BlockUserReason? reason);
        partial void ProcessBlockUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Blocks the specified user from interacting with or having contact with the broadcaster.<br/>
        /// Blocks the specified user from interacting with or having contact with the broadcaster. The user ID in the OAuth token identifies the broadcaster who is blocking the user.<br/>
        /// To learn more about blocking users, see [Block Other Users on Twitch](https://help.twitch.tv/s/article/how-to-manage-harassment-in-chat?language=en%5FUS#BlockWhispersandMessagesfromStrangers).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:blocked\_users** scope.
        /// </summary>
        /// <param name="targetUserId"></param>
        /// <param name="sourceContext"></param>
        /// <param name="reason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task BlockUserAsync(
            string targetUserId,
            global::G.BlockUserSourceContext? sourceContext = default,
            global::G.BlockUserReason? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareBlockUserArguments(
                httpClient: HttpClient,
                targetUserId: ref targetUserId,
                sourceContext: ref sourceContext,
                reason: ref reason);

            var sourceContextValue = sourceContext switch
            {
                global::G.BlockUserSourceContext.Chat => "chat",
                global::G.BlockUserSourceContext.Whisper => "whisper",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var reasonValue = reason switch
            {
                global::G.BlockUserReason.Harassment => "harassment",
                global::G.BlockUserReason.Spam => "spam",
                global::G.BlockUserReason.Other => "other",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/users/blocks",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("target_user_id", targetUserId) 
                .AddOptionalParameter("source_context", sourceContextValue?.ToString()) 
                .AddOptionalParameter("reason", reasonValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareBlockUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                targetUserId: targetUserId,
                sourceContext: sourceContext,
                reason: reason);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessBlockUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}