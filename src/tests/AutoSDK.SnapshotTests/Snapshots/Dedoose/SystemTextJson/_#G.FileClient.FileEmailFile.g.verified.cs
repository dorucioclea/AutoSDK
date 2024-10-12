﻿//HintName: G.FileClient.FileEmailFile.g.cs

#nullable enable

namespace G
{
    public partial class FileClient
    {
        partial void PrepareFileEmailFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? fileURI,
            ref string? attachmentFileName,
            ref string? emailAddress,
            ref string? subject);
        partial void PrepareFileEmailFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? fileURI,
            string? attachmentFileName,
            string? emailAddress,
            string? subject);
        partial void ProcessFileEmailFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFileEmailFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// EmailFile.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="fileURI"></param>
        /// <param name="attachmentFileName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="subject"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> FileEmailFileAsync(
            string? token = default,
            string? fileURI = default,
            string? attachmentFileName = default,
            string? emailAddress = default,
            string? subject = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareFileEmailFileArguments(
                httpClient: _httpClient,
                token: ref token,
                fileURI: ref fileURI,
                attachmentFileName: ref attachmentFileName,
                emailAddress: ref emailAddress,
                subject: ref subject);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/file/emailfile",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("fileURI", fileURI) 
                .AddOptionalParameter("attachmentFileName", attachmentFileName) 
                .AddOptionalParameter("emailAddress", emailAddress) 
                .AddOptionalParameter("subject", subject) 
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
            PrepareFileEmailFileRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                fileURI: fileURI,
                attachmentFileName: attachmentFileName,
                emailAddress: emailAddress,
                subject: subject);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessFileEmailFileResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessFileEmailFileResponseContent(
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