﻿//HintName: G.IDubbingClient.GetDubbingProjectMetadataV1DubbingDubbingIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Get Dubbing Project Metadata<br/>
        /// Returns metadata about a dubbing project, including whether it's still in progress or not
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DubbingMetadataResponse> GetDubbingProjectMetadataV1DubbingDubbingIdGetAsync(
            string dubbingId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}