﻿//HintName: G.Models.ActionsSetCustomLabelsForSelfHostedRunnerForRepoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetCustomLabelsForSelfHostedRunnerForRepoRequest
    {
        /// <summary>
        /// The names of the custom labels to set for the runner. You can pass an empty array to remove all custom labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetCustomLabelsForSelfHostedRunnerForRepoRequest" /> class.
        /// </summary>
        /// <param name="labels">
        /// The names of the custom labels to set for the runner. You can pass an empty array to remove all custom labels.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsSetCustomLabelsForSelfHostedRunnerForRepoRequest(
            global::System.Collections.Generic.IList<string> labels)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetCustomLabelsForSelfHostedRunnerForRepoRequest" /> class.
        /// </summary>
        public ActionsSetCustomLabelsForSelfHostedRunnerForRepoRequest()
        {
        }
    }
}