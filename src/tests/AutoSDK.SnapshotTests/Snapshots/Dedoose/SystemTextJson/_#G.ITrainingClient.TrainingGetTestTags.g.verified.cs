﻿//HintName: G.ITrainingClient.TrainingGetTestTags.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// GetTestTags.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="testId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TrainingTestTag>> TrainingGetTestTagsAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? testId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}