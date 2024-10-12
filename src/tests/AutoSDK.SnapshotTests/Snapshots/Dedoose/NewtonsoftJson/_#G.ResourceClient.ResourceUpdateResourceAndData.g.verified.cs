﻿//HintName: G.ResourceClient.ResourceUpdateResourceAndData.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceUpdateResourceAndDataArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref global::System.Guid? resourceId,
            ref string? title,
            ref string? description,
            ref string? fileURL,
            ref int? length,
            ref bool? isLocked);
        partial void PrepareResourceUpdateResourceAndDataRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Guid? resourceId,
            string? title,
            string? description,
            string? fileURL,
            int? length,
            bool? isLocked);
        partial void ProcessResourceUpdateResourceAndDataResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceUpdateResourceAndDataResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateResourceAndData.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="fileURL"></param>
        /// <param name="length"></param>
        /// <param name="isLocked"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ResourceUpdateResourceAndDataAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? resourceId = default,
            string? title = default,
            string? description = default,
            string? fileURL = default,
            int? length = default,
            bool? isLocked = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareResourceUpdateResourceAndDataArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                resourceId: ref resourceId,
                title: ref title,
                description: ref description,
                fileURL: ref fileURL,
                length: ref length,
                isLocked: ref isLocked);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/resource/updateresourceanddata",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("title", title) 
                .AddOptionalParameter("description", description) 
                .AddOptionalParameter("fileURL", fileURL) 
                .AddOptionalParameter("length", length?.ToString()) 
                .AddOptionalParameter("isLocked", isLocked?.ToString()) 
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
            PrepareResourceUpdateResourceAndDataRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                resourceId: resourceId,
                title: title,
                description: description,
                fileURL: fileURL,
                length: length,
                isLocked: isLocked);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResourceUpdateResourceAndDataResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResourceUpdateResourceAndDataResponseContent(
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