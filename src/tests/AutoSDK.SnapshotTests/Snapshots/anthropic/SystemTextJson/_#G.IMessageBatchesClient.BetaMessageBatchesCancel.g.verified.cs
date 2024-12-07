﻿//HintName: G.IMessageBatchesClient.BetaMessageBatchesCancel.g.cs
#nullable enable

namespace G
{
    public partial interface IMessageBatchesClient
    {
        /// <summary>
        /// Cancel a Message Batch<br/>
        /// Batches may be canceled any time before processing ends. Once cancellation is initiated, the batch enters a `canceling` state, at which time the system may complete any in-progress, non-interruptible requests before finalizing cancellation.<br/>
        /// The number of canceled requests is specified in `request_counts`. To determine which requests were canceled, check the individual results within the batch. Note that cancellation may not result in any canceled requests if they were non-interruptible.
        /// </summary>
        /// <param name="messageBatchId">
        /// ID of the Message Batch.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BetaMessageBatch> BetaMessageBatchesCancelAsync(
            string messageBatchId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}