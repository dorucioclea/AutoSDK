﻿//HintName: G.VDPClient.PipelinePublicServiceListComponentRuns.g.cs

#nullable enable

namespace G
{
    public partial class VDPClient
    {
        partial void PreparePipelinePublicServiceListComponentRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineRunId,
            ref int? page,
            ref int? pageSize,
            ref string? filter,
            ref string? orderBy,
            ref global::G.PipelinePublicServiceListComponentRunsView? view,
            ref string? instillRequesterUid);
        partial void PreparePipelinePublicServiceListComponentRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineRunId,
            int? page,
            int? pageSize,
            string? filter,
            string? orderBy,
            global::G.PipelinePublicServiceListComponentRunsView? view,
            string? instillRequesterUid);
        partial void ProcessPipelinePublicServiceListComponentRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelinePublicServiceListComponentRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Component runs<br/>
        /// Returns the information of each component execution within a pipeline run.
        /// </summary>
        /// <param name="pipelineRunId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="view"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListComponentRunsResponse> PipelinePublicServiceListComponentRunsAsync(
            string pipelineRunId,
            int? page = default,
            int? pageSize = default,
            string? filter = default,
            string? orderBy = default,
            global::G.PipelinePublicServiceListComponentRunsView? view = default,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePipelinePublicServiceListComponentRunsArguments(
                httpClient: HttpClient,
                pipelineRunId: ref pipelineRunId,
                page: ref page,
                pageSize: ref pageSize,
                filter: ref filter,
                orderBy: ref orderBy,
                view: ref view,
                instillRequesterUid: ref instillRequesterUid);

            var viewValue = view switch
            {
                global::G.PipelinePublicServiceListComponentRunsView.VIEWBASIC => "VIEW_BASIC",
                global::G.PipelinePublicServiceListComponentRunsView.VIEWFULL => "VIEW_FULL",
                global::G.PipelinePublicServiceListComponentRunsView.VIEWRECIPE => "VIEW_RECIPE",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/pipeline-runs/{pipelineRunId}/component-runs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("filter", filter) 
                .AddOptionalParameter("orderBy", orderBy) 
                .AddOptionalParameter("view", viewValue?.ToString()) 
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

            if (instillRequesterUid != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Instill-Requester-Uid", instillRequesterUid.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePipelinePublicServiceListComponentRunsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineRunId: pipelineRunId,
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy,
                view: view,
                instillRequesterUid: instillRequesterUid);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelinePublicServiceListComponentRunsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessPipelinePublicServiceListComponentRunsResponseContent(
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
                    global::G.ListComponentRunsResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = await global::G.ListComponentRunsResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}