﻿//HintName: G.IAdminClient.GetFilteredUsersAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetFilteredUsers<br/>
        /// GetFilteredUsers
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredUsersAsAdminAsync(
            global::G.GetFilteredUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetFilteredUsers<br/>
        /// GetFilteredUsers
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredUsersAsAdminAsync(
            string filter,
            int maxResults,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}