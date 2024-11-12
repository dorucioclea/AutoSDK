﻿//HintName: G.IOrgsClient.GetCurrentOrganizationInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Current Organization Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationInfo> GetCurrentOrganizationInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}