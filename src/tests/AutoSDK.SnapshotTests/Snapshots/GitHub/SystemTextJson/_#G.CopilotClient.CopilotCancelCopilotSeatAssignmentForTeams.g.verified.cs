﻿//HintName: G.CopilotClient.CopilotCancelCopilotSeatAssignmentForTeams.g.cs

#nullable enable

namespace G
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotCancelCopilotSeatAssignmentForTeamsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.CopilotCancelCopilotSeatAssignmentForTeamsRequest request);
        partial void PrepareCopilotCancelCopilotSeatAssignmentForTeamsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.CopilotCancelCopilotSeatAssignmentForTeamsRequest request);
        partial void ProcessCopilotCancelCopilotSeatAssignmentForTeamsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotCancelCopilotSeatAssignmentForTeamsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove teams from the Copilot subscription for an organization<br/>
        /// **Note**: This endpoint is in beta and is subject to change.<br/>
        /// Cancels the Copilot seat assignment for all members of each team specified.<br/>
        /// This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.<br/>
        /// For more information about Copilot pricing, see "[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)".<br/>
        /// For more information about disabling access to Copilot Business or Enterprise, see "[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot/managing-access-for-copilot-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)".<br/>
        /// Only organization owners can configure GitHub Copilot in their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_billing:copilot` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CopilotCancelCopilotSeatAssignmentForTeamsResponse> CopilotCancelCopilotSeatAssignmentForTeamsAsync(
            string org,
            global::G.CopilotCancelCopilotSeatAssignmentForTeamsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCopilotCancelCopilotSeatAssignmentForTeamsArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/copilot/billing/selected_teams",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
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
            PrepareCopilotCancelCopilotSeatAssignmentForTeamsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCopilotCancelCopilotSeatAssignmentForTeamsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCopilotCancelCopilotSeatAssignmentForTeamsResponseContent(
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
                global::G.CopilotCancelCopilotSeatAssignmentForTeamsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Remove teams from the Copilot subscription for an organization<br/>
        /// **Note**: This endpoint is in beta and is subject to change.<br/>
        /// Cancels the Copilot seat assignment for all members of each team specified.<br/>
        /// This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.<br/>
        /// For more information about Copilot pricing, see "[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)".<br/>
        /// For more information about disabling access to Copilot Business or Enterprise, see "[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot/managing-access-for-copilot-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)".<br/>
        /// Only organization owners can configure GitHub Copilot in their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_billing:copilot` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedTeams">
        /// The names of teams from which to revoke access to GitHub Copilot.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CopilotCancelCopilotSeatAssignmentForTeamsResponse> CopilotCancelCopilotSeatAssignmentForTeamsAsync(
            string org,
            global::System.Collections.Generic.IList<string> selectedTeams,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CopilotCancelCopilotSeatAssignmentForTeamsRequest
            {
                SelectedTeams = selectedTeams,
            };

            return await CopilotCancelCopilotSeatAssignmentForTeamsAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}