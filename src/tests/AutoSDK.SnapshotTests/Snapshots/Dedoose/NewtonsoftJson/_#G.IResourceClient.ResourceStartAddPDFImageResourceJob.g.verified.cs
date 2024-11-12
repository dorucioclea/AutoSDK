﻿//HintName: G.IResourceClient.ResourceStartAddPDFImageResourceJob.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// StartAddPDFImageResourceJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fileName"></param>
        /// <param name="fileURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResourceStartAddPDFImageResourceJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            string? fileName = default,
            string? fileURI = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}