﻿//HintName: G.ResourceClient.ResourceStartExportResourcesJob.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceStartExportResourcesJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds,
            ref bool? includeDescriptorInfo,
            ref bool? includeCodeCounts);
        partial void PrepareResourceStartExportResourcesJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds,
            bool? includeDescriptorInfo,
            bool? includeCodeCounts);
        partial void ProcessResourceStartExportResourcesJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceStartExportResourcesJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartExportResourcesJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="includeDescriptorInfo"></param>
        /// <param name="includeCodeCounts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ResourceStartExportResourcesJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds = default,
            bool? includeDescriptorInfo = default,
            bool? includeCodeCounts = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareResourceStartExportResourcesJobArguments(
                httpClient: HttpClient,
                token: ref token,
                projectId: ref projectId,
                resourceIds: resourceIds,
                includeDescriptorInfo: ref includeDescriptorInfo,
                includeCodeCounts: ref includeCodeCounts);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/resource/startexportresourcesjob",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("resourceIds", resourceIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("includeDescriptorInfo", includeDescriptorInfo?.ToString()) 
                .AddOptionalParameter("includeCodeCounts", includeCodeCounts?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareResourceStartExportResourcesJobRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectId: projectId,
                resourceIds: resourceIds,
                includeDescriptorInfo: includeDescriptorInfo,
                includeCodeCounts: includeCodeCounts);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessResourceStartExportResourcesJobResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessResourceStartExportResourcesJobResponseContent(
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

                    return __content;
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            using var __streamReader = new global::System.IO.StreamReader(__responseStream);
            using var __jsonReader = new global::Newtonsoft.Json.JsonTextReader(__streamReader);
            var __serializer = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions);
            var __responseValue = __serializer.Deserialize<string?>(__jsonReader);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}