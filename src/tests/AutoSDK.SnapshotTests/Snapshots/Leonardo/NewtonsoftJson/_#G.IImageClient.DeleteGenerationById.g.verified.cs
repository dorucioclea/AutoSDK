﻿//HintName: G.IImageClient.DeleteGenerationById.g.cs
#nullable enable

namespace G
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Delete a Single Generation<br/>
        /// This endpoint deletes a specific generation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteGenerationByIdResponse> DeleteGenerationByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}