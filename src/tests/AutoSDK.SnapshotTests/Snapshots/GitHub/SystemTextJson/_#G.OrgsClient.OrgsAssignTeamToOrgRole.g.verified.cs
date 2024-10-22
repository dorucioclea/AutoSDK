﻿//HintName: G.OrgsClient.OrgsAssignTeamToOrgRole.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsAssignTeamToOrgRoleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            ref int roleId);
        partial void PrepareOrgsAssignTeamToOrgRoleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            int roleId);
        partial void ProcessOrgsAssignTeamToOrgRoleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Assign an organization role to a team<br/>
        /// Assigns an organization role to a team in an organization. For more information on organization roles, see "[Using organization roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/using-organization-roles)."<br/>
        /// The authenticated user must be an administrator for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsAssignTeamToOrgRoleAsync(
            string org,
            string teamSlug,
            int roleId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsAssignTeamToOrgRoleArguments(
                httpClient: HttpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                roleId: ref roleId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/organization-roles/teams/{teamSlug}/{roleId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsAssignTeamToOrgRoleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                teamSlug: teamSlug,
                roleId: roleId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsAssignTeamToOrgRoleResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}