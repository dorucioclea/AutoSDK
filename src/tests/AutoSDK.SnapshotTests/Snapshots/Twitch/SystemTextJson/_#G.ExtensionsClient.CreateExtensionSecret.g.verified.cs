﻿//HintName: G.ExtensionsClient.CreateExtensionSecret.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        partial void PrepareCreateExtensionSecretArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string extensionId,
            ref int? delay);
        partial void PrepareCreateExtensionSecretRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string extensionId,
            int? delay);
        partial void ProcessCreateExtensionSecretResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateExtensionSecretResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a shared secret used to sign and verify JWT tokens.<br/>
        /// Creates a shared secret used to sign and verify JWT tokens. Creating a new secret removes the current secrets from service. Use this function only when you are ready to use the new secret it returns.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="delay"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateExtensionSecretResponse> CreateExtensionSecretAsync(
            string extensionId,
            int? delay = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateExtensionSecretArguments(
                httpClient: HttpClient,
                extensionId: ref extensionId,
                delay: ref delay);

            var __pathBuilder = new PathBuilder(
                path: "/extensions/jwt/secrets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("extension_id", extensionId) 
                .AddOptionalParameter("delay", delay?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCreateExtensionSecretRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                extensionId: extensionId,
                delay: delay);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateExtensionSecretResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateExtensionSecretResponseContent(
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
                global::G.CreateExtensionSecretResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}