﻿//HintName: G.ITagClient.UpdateTagLink.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// UpdateTagLink<br/>
        /// UpdateTagLink
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagLink> UpdateTagLinkAsync(
            global::G.UpdateTagLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateTagLink<br/>
        /// UpdateTagLink
        /// </summary>
        /// <param name="link"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagLink> UpdateTagLinkAsync(
            global::G.TagLink link,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}