﻿//HintName: G.ISecurityClient.SecurityGetProjectGroups.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// GetProjectGroups.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UserGroup>> SecurityGetProjectGroupsAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}