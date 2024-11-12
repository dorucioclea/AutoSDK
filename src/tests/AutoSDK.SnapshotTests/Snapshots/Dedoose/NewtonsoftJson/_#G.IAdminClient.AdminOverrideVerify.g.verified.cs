﻿//HintName: G.IAdminClient.AdminOverrideVerify.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// OverrideVerify.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AdminOverrideVerifyAsync(
            string? token = default,
            global::System.Guid? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}