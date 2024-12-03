﻿//HintName: G.IFilesClient.DeleteFilesById.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete a file<br/>
        /// Delete a previously uploaded data file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileDeleteResponse> DeleteFilesByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}