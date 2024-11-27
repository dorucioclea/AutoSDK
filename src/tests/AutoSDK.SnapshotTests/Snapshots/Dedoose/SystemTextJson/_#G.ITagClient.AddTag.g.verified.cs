﻿//HintName: G.ITagClient.AddTag.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// AddTag<br/>
        /// AddTag
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tag> AddTagAsync(
            global::G.AddTagRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddTag<br/>
        /// AddTag
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="allowDecimalWeights"></param>
        /// <param name="color"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tag> AddTagAsync(
            global::System.Guid projectId,
            string title,
            string description,
            bool isWeighted,
            double? weightMin,
            double? weightMax,
            double? weightDefault,
            bool? allowDecimalWeights,
            int color,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}