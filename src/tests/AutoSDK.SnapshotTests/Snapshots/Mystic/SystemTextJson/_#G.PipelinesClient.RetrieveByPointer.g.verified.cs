﻿//HintName: G.PipelinesClient.RetrieveByPointer.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareRetrieveByPointerArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pointer,
            ref bool? includePointers,
            ref bool? includeExtras,
            ref string? pipelineId,
            ref string? pipelineIdOrPointer);
        partial void PrepareRetrieveByPointerRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pointer,
            bool? includePointers,
            bool? includeExtras,
            string? pipelineId,
            string? pipelineIdOrPointer);
        partial void ProcessRetrieveByPointerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveByPointerResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve By Pointer<br/>
        /// Retrieve details for a pipeline by pointer name.<br/>
        /// Note that the fields this endpoint returns are dependent on the provided<br/>
        /// query parameters and will omit any empty fields.<br/>
        /// Accepted query parameters are:<br/>
        /// - include_pointers: include any pointers that point to this pipeline
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="includePointers">
        /// Default Value: false
        /// </param>
        /// <param name="includeExtras">
        /// Default Value: false
        /// </param>
        /// <param name="pipelineId"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AppSchemasPipelineGetDetailed> RetrieveByPointerAsync(
            string pointer,
            bool? includePointers = default,
            bool? includeExtras = default,
            string? pipelineId = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRetrieveByPointerArguments(
                httpClient: HttpClient,
                pointer: ref pointer,
                includePointers: ref includePointers,
                includeExtras: ref includeExtras,
                pipelineId: ref pipelineId,
                pipelineIdOrPointer: ref pipelineIdOrPointer);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/by-pointer/{pointer}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("include_pointers", includePointers?.ToString()) 
                .AddOptionalParameter("include_extras", includeExtras?.ToString()) 
                .AddOptionalParameter("pipeline_id", pipelineId) 
                .AddOptionalParameter("pipeline_id_or_pointer", pipelineIdOrPointer) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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
            PrepareRetrieveByPointerRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pointer: pointer,
                includePointers: includePointers,
                includeExtras: includeExtras,
                pipelineId: pipelineId,
                pipelineIdOrPointer: pipelineIdOrPointer);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRetrieveByPointerResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessRetrieveByPointerResponseContent(
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
                global::G.AppSchemasPipelineGetDetailed.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}