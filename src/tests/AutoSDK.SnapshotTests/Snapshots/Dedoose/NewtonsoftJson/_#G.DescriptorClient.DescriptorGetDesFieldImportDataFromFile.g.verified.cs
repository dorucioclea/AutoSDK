﻿//HintName: G.DescriptorClient.DescriptorGetDesFieldImportDataFromFile.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorGetDesFieldImportDataFromFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? relativeFileURL);
        partial void PrepareDescriptorGetDesFieldImportDataFromFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? relativeFileURL);
        partial void ProcessDescriptorGetDesFieldImportDataFromFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorGetDesFieldImportDataFromFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetDesFieldImportDataFromFile.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="relativeFileURL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> DescriptorGetDesFieldImportDataFromFileAsync(
            string? token = default,
            string? relativeFileURL = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorGetDesFieldImportDataFromFileArguments(
                httpClient: _httpClient,
                token: ref token,
                relativeFileURL: ref relativeFileURL);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/descriptor/getdesfieldimportdatafromfile",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("relativeFileURL", relativeFileURL) 
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
            PrepareDescriptorGetDesFieldImportDataFromFileRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                relativeFileURL: relativeFileURL);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorGetDesFieldImportDataFromFileResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorGetDesFieldImportDataFromFileResponseContent(
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