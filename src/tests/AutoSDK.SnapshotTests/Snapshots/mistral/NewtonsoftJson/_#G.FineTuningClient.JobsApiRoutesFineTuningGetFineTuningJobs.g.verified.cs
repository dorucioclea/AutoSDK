﻿//HintName: G.FineTuningClient.JobsApiRoutesFineTuningGetFineTuningJobs.g.cs

#nullable enable

namespace G
{
    public partial class FineTuningClient
    {
        partial void PrepareJobsApiRoutesFineTuningGetFineTuningJobsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? pageSize,
            ref string? model,
            ref global::System.DateTime? createdAfter,
            ref bool? createdByMe,
            ref global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus? status,
            ref string? wandbProject,
            ref string? wandbName,
            ref string? suffix);
        partial void PrepareJobsApiRoutesFineTuningGetFineTuningJobsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? pageSize,
            string? model,
            global::System.DateTime? createdAfter,
            bool? createdByMe,
            global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus? status,
            string? wandbProject,
            string? wandbName,
            string? suffix);
        partial void ProcessJobsApiRoutesFineTuningGetFineTuningJobsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessJobsApiRoutesFineTuningGetFineTuningJobsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Fine Tuning Jobs<br/>
        /// Get a list of fine-tuning jobs for your organization and user.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="model"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdByMe">
        /// Default Value: false
        /// </param>
        /// <param name="status"></param>
        /// <param name="wandbProject"></param>
        /// <param name="wandbName"></param>
        /// <param name="suffix"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.JobsOut> JobsApiRoutesFineTuningGetFineTuningJobsAsync(
            int? page = 0,
            int? pageSize = 100,
            string? model = default,
            global::System.DateTime? createdAfter = default,
            bool? createdByMe = false,
            global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus? status = default,
            string? wandbProject = default,
            string? wandbName = default,
            string? suffix = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareJobsApiRoutesFineTuningGetFineTuningJobsArguments(
                httpClient: HttpClient,
                page: ref page,
                pageSize: ref pageSize,
                model: ref model,
                createdAfter: ref createdAfter,
                createdByMe: ref createdByMe,
                status: ref status,
                wandbProject: ref wandbProject,
                wandbName: ref wandbName,
                suffix: ref suffix);

            var statusValue = status switch
            {
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.QUEUED => "QUEUED",
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.STARTED => "STARTED",
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.VALIDATING => "VALIDATING",
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.VALIDATED => "VALIDATED",
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.RUNNING => "RUNNING",
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.FAILED => "FAILED",
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.SUCCESS => "SUCCESS",
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.CANCELLED => "CANCELLED",
                global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/v1/fine_tuning/jobs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("model", model) 
                .AddOptionalParameter("created_after", createdAfter?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("created_by_me", createdByMe?.ToString()) 
                .AddOptionalParameter("status", statusValue?.ToString()) 
                .AddOptionalParameter("wandb_project", wandbProject) 
                .AddOptionalParameter("wandb_name", wandbName) 
                .AddOptionalParameter("suffix", suffix) 
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
            PrepareJobsApiRoutesFineTuningGetFineTuningJobsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                page: page,
                pageSize: pageSize,
                model: model,
                createdAfter: createdAfter,
                createdByMe: createdByMe,
                status: status,
                wandbProject: wandbProject,
                wandbName: wandbName,
                suffix: suffix);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessJobsApiRoutesFineTuningGetFineTuningJobsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessJobsApiRoutesFineTuningGetFineTuningJobsResponseContent(
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
                global::G.JobsOut.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}