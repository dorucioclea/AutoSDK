﻿//HintName: G.IUserClient.UserGetFederationResponseForConnection.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// GetFederationResponseForConnection.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UserGetFederationResponseForConnectionAsync(
            string? token = default,
            global::System.Guid? connectionKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}