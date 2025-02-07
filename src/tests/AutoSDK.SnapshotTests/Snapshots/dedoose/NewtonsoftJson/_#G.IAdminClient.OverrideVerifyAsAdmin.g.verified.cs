﻿//HintName: G.IAdminClient.OverrideVerifyAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// OverrideVerify<br/>
        /// OverrideVerify
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OverrideVerifyAsAdminAsync(
            global::G.OverrideVerifyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// OverrideVerify<br/>
        /// OverrideVerify
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OverrideVerifyAsAdminAsync(
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}