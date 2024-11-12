﻿//HintName: G.OrgsClient.OrgsCancelInvitation.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsCancelInvitationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int invitationId);
        partial void PrepareOrgsCancelInvitationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int invitationId);
        partial void ProcessOrgsCancelInvitationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Cancel an organization invitation<br/>
        /// Cancel an organization invitation. In order to cancel an organization invitation, the authenticated user must be an organization owner.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications).
        /// </summary>
        /// <param name="org"></param>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsCancelInvitationAsync(
            string org,
            int invitationId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsCancelInvitationArguments(
                httpClient: HttpClient,
                org: ref org,
                invitationId: ref invitationId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/invitations/{invitationId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsCancelInvitationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                invitationId: invitationId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsCancelInvitationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}