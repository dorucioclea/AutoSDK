﻿//HintName: G.ActionsClient.ActionsListJobsForWorkflowRun.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// List jobs for a workflow run
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="filter"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsListJobsForWorkflowRunResponse> ActionsListJobsForWorkflowRunAsync(
            string owner,
            string repo,
            int runId,
            ActionsListJobsForWorkflowRunFilter filter,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var filterValue = filter switch
            {
                ActionsListJobsForWorkflowRunFilter.Latest => "latest",
                ActionsListJobsForWorkflowRunFilter.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/runs/{runId}/jobs?filter={filterValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ActionsListJobsForWorkflowRunResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}