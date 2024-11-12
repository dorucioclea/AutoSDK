﻿//HintName: G.IBulkEmbeddingsClient.RetrieveJobV1BulkEmbeddingsJobIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBulkEmbeddingsClient
    {
        /// <summary>
        /// Retrieve Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkEmbeddingJobResponse> RetrieveJobV1BulkEmbeddingsJobIdGetAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}