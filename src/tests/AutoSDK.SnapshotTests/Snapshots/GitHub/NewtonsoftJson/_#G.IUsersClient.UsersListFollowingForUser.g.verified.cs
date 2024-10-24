﻿//HintName: G.IUsersClient.UsersListFollowingForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List the people a user follows<br/>
        /// Lists the people who the specified user follows.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SimpleUser>> UsersListFollowingForUserAsync(
            string username,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}