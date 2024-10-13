﻿//HintName: G.ReposClient.ReposCreateDeploymentStatus.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateDeploymentStatusArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int deploymentId,
            global::G.ReposCreateDeploymentStatusRequest request);
        partial void PrepareReposCreateDeploymentStatusRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int deploymentId,
            global::G.ReposCreateDeploymentStatusRequest request);
        partial void ProcessReposCreateDeploymentStatusResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateDeploymentStatusResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a deployment status<br/>
        /// Users with `push` access can create deployment statuses for a given deployment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo_deployment` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeploymentStatus> ReposCreateDeploymentStatusAsync(
            string owner,
            string repo,
            int deploymentId,
            global::G.ReposCreateDeploymentStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposCreateDeploymentStatusArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                deploymentId: ref deploymentId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/deployments/{deploymentId}/statuses",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposCreateDeploymentStatusRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                deploymentId: deploymentId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposCreateDeploymentStatusResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposCreateDeploymentStatusResponseContent(
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

            return
                global::G.DeploymentStatus.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a deployment status<br/>
        /// Users with `push` access can create deployment statuses for a given deployment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo_deployment` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="deploymentId"></param>
        /// <param name="state">
        /// The state of the status. When you set a transient deployment to `inactive`, the deployment will be shown as `destroyed` in GitHub.
        /// </param>
        /// <param name="targetUrl">
        /// The target URL to associate with this status. This URL should contain output to keep the user updated while the task is running or serve as historical information for what happened in the deployment. **Note:** It's recommended to use the `log_url` parameter, which replaces `target_url`.
        /// </param>
        /// <param name="logUrl">
        /// The full URL of the deployment's output. This parameter replaces `target_url`. We will continue to accept `target_url` to support legacy uses, but we recommend replacing `target_url` with `log_url`. Setting `log_url` will automatically set `target_url` to the same value. Default: `""`
        /// </param>
        /// <param name="description">
        /// A short description of the status. The maximum description length is 140 characters.
        /// </param>
        /// <param name="environment">
        /// Name for the target deployment environment, which can be changed when setting a deploy status. For example, `production`, `staging`, or `qa`. If not defined, the environment of the previous status on the deployment will be used, if it exists. Otherwise, the environment of the deployment will be used.
        /// </param>
        /// <param name="environmentUrl">
        /// Sets the URL for accessing your environment. Default: `""`
        /// </param>
        /// <param name="autoInactive">
        /// Adds a new `inactive` status to all prior non-transient, non-production environment deployments with the same repository and `environment` name as the created status's deployment. An `inactive` status is only added to deployments that had a `success` state. Default: `true`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeploymentStatus> ReposCreateDeploymentStatusAsync(
            string owner,
            string repo,
            int deploymentId,
            global::G.ReposCreateDeploymentStatusRequestState state,
            string? targetUrl = default,
            string? logUrl = default,
            string? description = default,
            string? environment = default,
            string? environmentUrl = default,
            bool? autoInactive = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposCreateDeploymentStatusRequest
            {
                State = state,
                TargetUrl = targetUrl,
                LogUrl = logUrl,
                Description = description,
                Environment = environment,
                EnvironmentUrl = environmentUrl,
                AutoInactive = autoInactive,
            };

            return await ReposCreateDeploymentStatusAsync(
                owner: owner,
                repo: repo,
                deploymentId: deploymentId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}