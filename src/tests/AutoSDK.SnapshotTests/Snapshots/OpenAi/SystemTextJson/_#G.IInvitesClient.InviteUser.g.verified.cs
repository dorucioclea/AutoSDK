﻿//HintName: G.IInvitesClient.InviteUser.g.cs
#nullable enable

namespace G
{
    public partial interface IInvitesClient
    {
        /// <summary>
        /// Create an invite for a user to the organization. The invite must be accepted by the user before they have access to the organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Invite> InviteUserAsync(
            global::G.InviteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an invite for a user to the organization. The invite must be accepted by the user before they have access to the organization.
        /// </summary>
        /// <param name="email">
        /// Send an email to this address
        /// </param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Invite> InviteUserAsync(
            string email,
            global::G.InviteRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}