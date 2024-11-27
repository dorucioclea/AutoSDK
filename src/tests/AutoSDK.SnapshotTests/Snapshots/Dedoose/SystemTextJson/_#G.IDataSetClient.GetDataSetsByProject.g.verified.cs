﻿//HintName: G.IDataSetClient.GetDataSetsByProject.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSetClient
    {
        /// <summary>
        /// GetDataSetsByProject<br/>
        /// GetDataSetsByProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DataSetVO>> GetDataSetsByProjectAsync(
            global::G.GetDataSetsByProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetDataSetsByProject<br/>
        /// GetDataSetsByProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DataSetVO>> GetDataSetsByProjectAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}